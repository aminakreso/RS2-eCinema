namespace eCinema.Model.Dtos
{
    public class NotificationDto
    {
        public string? Title { get; set; }

        public string? Content { get; set; }

        public DateTime? Date { get; set; }

        public Guid AuthorId { get; set; }

        public string? NotificationType { get; set; }

        public string? Picture { get; set; }
        
        public bool? IsActive { get; set; }

    }
}
