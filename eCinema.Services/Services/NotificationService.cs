using AutoMapper;
using eCinema.Model.Dtos;
using eCinema.Model.Requests;
using eCinema.Model.SearchObjects;
using eCinema.Services.Database;

namespace eCinema.Services.Services
{
    public class NotificationService : BaseCRUDService<NotificationDto, Notification, NotificationSearchObject, NotificationInsertRequest, NotificationUpdateRequest>, INotificationService
    {
        public NotificationService(CinemaContext cinemaContext, IMapper mapper) : base(cinemaContext, mapper)
        {
        }

        public override IQueryable<Notification> AddFilter(IQueryable<Notification> query, NotificationSearchObject search)
        {
            var filteredQuery = query;
            if (!string.IsNullOrWhiteSpace(search.Title))
                filteredQuery = query.Where(x => x.Title != null && x.Title.ToLower().Contains(search.Title.ToLower()));
            if (!string.IsNullOrWhiteSpace(search.NotificationType))
                filteredQuery = query.Where(x => x.NotificationType != null && x.NotificationType.ToLower().Contains(search.NotificationType.ToLower()));

            return filteredQuery;

        }

        public override void BeforeInsert(NotificationInsertRequest insert,Notification entity)
        {
            entity.AuthorId = new Guid("6f68092a-978e-4b67-8f9b-720cca484d43");
            entity.Date = DateTime.Now;
        }

        public override void BeforeUpdate(Notification entity)
        {
            entity.Date = DateTime.Now;
        }
    }
}
