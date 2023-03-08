using System.Collections;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using AutoMapper;
using eCinema.Model.Dtos;
using eCinema.Model.Requests;
using eCinema.Model.SearchObjects;
using eCinema.Services.Database;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eCinema.Services.Services
{
    public class UserService : BaseCRUDService<UserDto, User, UserSearchObject, UserInsertRequest, UserUpdateRequest>,
        IUserService
    {
        public UserService(CinemaContext cinemaContext, IMapper mapper) : base(cinemaContext, mapper)
        {
        }

        public async Task<UserDto> UpdateUserAdmin(Guid id, UserAdminUpdateRequest update)
        {

            var entity = await _cinemaContext.Users.FindAsync(id);

            if (entity is null)
                throw new InvalidOperationException();

            _mapper.Map(update, entity);

            await _cinemaContext.SaveChangesAsync();

            return _mapper.Map<UserDto>(entity);

        }

        public override void BeforeInsert(UserInsertRequest insert, User entity)
        {
            var salt = GenerateSalt();
            entity.LozinkaSalt = salt;
            entity.LozinkaHash = GenerateHash(salt, insert.Password!);
        }

        public static string GenerateHash(string salt, string password)
        {
            var src = Convert.FromBase64String(salt);
            var bytes = Encoding.Unicode.GetBytes(password);
            var dst = new byte[src.Length + bytes.Length];

            System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            var algorithm = HashAlgorithm.Create("SHA1");
            var inArray = algorithm?.ComputeHash(dst);
            return Convert.ToBase64String(inArray!);
        }

        public static string GenerateSalt()
        {
            var provider = new RNGCryptoServiceProvider();
            var byteArray = new byte[16];
            provider.GetBytes(byteArray);
            
            return Convert.ToBase64String(byteArray);
        }

        public override IQueryable<User> AddFilter(IQueryable<User> query, UserSearchObject search)
        {
            var filteredQuery = query;
            if (!string.IsNullOrWhiteSpace(search.Name))
                filteredQuery = query.Where(x=> x.FirstName.ToLower().Contains(search.Name.ToLower()) || 
                    x.LastName.ToLower().Contains(search.Name.ToLower()));
            if (!string.IsNullOrWhiteSpace(search.Role) && search.Role != "Svi")
            {
                filteredQuery = filteredQuery.Include(x=> x.Role).Where(x=> x.Role.Name == search.Role);
            }
            if (search?.IsActive is not null)
            {
                filteredQuery = filteredQuery.Where(x => x.IsActive == search.IsActive);
            }

            return filteredQuery;

        }

        public override IQueryable<User> AddInclude(IQueryable<User> query, UserSearchObject search)
        { 
            if(search?.IncludeRoles is true)
            {
                query = query.Include(x => x.Role);
            }
            
            return query;
        }

            public async Task<UserDto> Login(string username, string password)
            {
            var entity = await _cinemaContext.Users.Include(x => x.Role).FirstOrDefaultAsync(x => x.Username == username);

            if (entity is null)
                throw new Exception("User doesn't exists!");

            var hash = GenerateHash(entity.LozinkaSalt!, password);
            
            if(hash != entity.LozinkaHash)
                throw new Exception("User doesn't exists!");

            return _mapper.Map<UserDto>(entity);
        }

            [AllowAnonymous]
            public async Task<UserDto> Register(RegistrationRequest registration)
            {
               var user = new User
                {
                    FirstName = registration.FirstName,
                    LastName = registration.LastName,
                    Email = registration.Email,
                    PhoneNumber = registration.PhoneNumber,
                    Username = registration.Username,
                    RoleId = new Guid("7ba66fcc-69b4-465e-8ad4-4f7d1a7b1788"),
                };
                var salt = GenerateSalt();
                user.LozinkaSalt = salt;
                user.LozinkaHash = GenerateHash(salt, registration.Password!);
                
                await _cinemaContext.AddAsync(user);
                await _cinemaContext.SaveChangesAsync();
                
                return new UserDto
                {
                    Id = user.Id,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Email = user.Email,
                    PhoneNumber = user.PhoneNumber,
                    Username = user.Username
                };
            }
    }
}
