namespace eCinema.Model.SearchObjects
{
    public class ProjectionSearchObject : BaseSearchObject
    {
        public DateTime? DateTime { get; set; }

        public Guid? HallId { get; set; }

        public Guid? MovieId { get; set; }

        public string? ProjectionStatus { get; set; }
    }
}
