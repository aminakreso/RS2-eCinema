namespace eCinema.Model.Dtos
{
    public class ProjectionDto
    {
        public DateTime? DateTime { get; set; }

        public Guid? HallId { get; set; }

        public Guid? MovieId { get; set; }

        public Guid? PriceId { get; set; }

        public string? ProjectionType { get; set; }
        public string? ProjectionStatus { get; set; }
        
        public bool? IsActive { get; set; }

    }
}
