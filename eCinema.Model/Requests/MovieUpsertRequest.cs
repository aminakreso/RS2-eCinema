using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace eCinema.Model.Requests
{
    public class MovieUpsertRequest
    {
        public string? Name { get; set; }

        public string? Description { get; set; }

        public int? Duration { get; set; }

        public int? ReleaseYear { get; set; }

        public string? Country { get; set; }

        public string? Actors { get; set; }

        public string? Director { get; set; }
        [NotMapped]
        public IFormFile? AcctualPicture { get; set; }
        //slika s forme
        public byte[]? Picture { get; set; }
        public string? Genres { get; set; }

    }
}
