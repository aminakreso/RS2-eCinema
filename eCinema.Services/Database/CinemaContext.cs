using eCinema.Services.Services;
using Microsoft.EntityFrameworkCore;

namespace eCinema.Services.Database
{
    public class CinemaContext : DbContext
    {
        public CinemaContext(DbContextOptions<CinemaContext> options) : base(options)
        {
        }

        public DbSet<Hall> Halls { get; set; }

        public DbSet<Payment> Payments { get; set; }

        public DbSet<Movie> Movies { get; set; }

        public DbSet<Notification> Notifications { get; set; }

        public DbSet<Price> Prices { get; set; }

        public DbSet<Projection> Projections { get; set; }

        public DbSet<Reservation> Reservations { get; set; }

        public DbSet<Role> Roles { get; set; }

        public DbSet<Seat> Seats { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<SeatxrefReservation> SeatReservations { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                    "Data Source=localhost;Initial Catalog=eCinema;Trusted_Connection=true;MultipleActiveResultSets=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var saltAdmin = UserService.GenerateSalt();
            var saltUser = UserService.GenerateSalt();

            var adminRoleId = Guid.NewGuid();
            var userRoleId = Guid.NewGuid();
            var hall1Id = Guid.NewGuid();
            var priceDnevnaId = Guid.NewGuid();
            

            modelBuilder.Entity<Hall>().HasData(
                new Hall { Id = hall1Id, Name = "Hall 1" },
                new Hall { Id = Guid.NewGuid(), Name = "Hall 2" },
                new Hall { Id = Guid.NewGuid(), Name = "Hall 3" },
                new Hall { Id = Guid.NewGuid(), Name = "Hall 4" },
                new Hall { Id = Guid.NewGuid(), Name = "Hall 5" }
            );

            modelBuilder.Entity<Price>().HasData(
                new Price { Id = priceDnevnaId, Name = "Dnevna projekcija", Value = 6 },
                new Price { Id = Guid.NewGuid(), Name = "Vecernja projekcija", Value = 7 },
                new Price { Id = Guid.NewGuid(), Name = "Vikend projekcija", Value = 8 }
            );

            modelBuilder.Entity<Role>().HasData(
                new Role { Id = adminRoleId, Name = "Admin" },
                new Role { Id = Guid.NewGuid(), Name = "User" }
            );

            var adminId = Guid.NewGuid();
            var userId = Guid.NewGuid();

            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = adminId, FirstName = "Admin", LastName = "Admin", Email = "admin@gmail.com",
                    Username = "admin", LozinkaSalt = saltAdmin, LozinkaHash = UserService.GenerateHash(saltAdmin, "admin"),
                    RoleId = adminRoleId
                },
                new User
                {
                    Id = userId, FirstName = "User", LastName = "User", Email = "user@gmail.com",
                    Username = "user", LozinkaSalt = saltUser, LozinkaHash = UserService.GenerateHash(saltUser, "user"),
                    RoleId = adminRoleId
                }
            );

            var movie1Id = Guid.NewGuid();
            var movie1 = new Movie
            {
                Id = movie1Id,
                Name = "Avatar",
                Description = "Lol",
                Duration = 202,
                ReleaseYear = 2010,
                Country = "SAD",
                Actors = "Ima",
                Director = "Ima",
                IsActive = true,
            };
            modelBuilder.Entity<Movie>().HasData(
                movie1
            );

            var projectionId = Guid.NewGuid();
            modelBuilder.Entity<Projection>().HasData(
                new Projection
                {
                    Id = projectionId,
                    StartTime = new DateTime(2023,3,1,17,30,00),
                    EndTime = new DateTime(2023,3,1,19,30,00),
                    HallId = hall1Id,
                    MovieId = movie1Id,
                    PriceId = priceDnevnaId,
                    ProjectionType = "Late",
                    StateMachine = "Draft",
                    Status = "Active",
                    IsActive = true,
                }
            );
            
        }
    }
}
