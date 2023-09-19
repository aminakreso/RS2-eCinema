using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCinema.Services.Database
{
    public class FITPasos
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public User? User { get; set; }

        public string? Value { get; set; }

        public DateTime? IssueDate { get; set; }
        public DateTime? ExpirationDate { get; set; }

        public bool? IsValid { get; set; }
    }
}
