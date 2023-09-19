using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCinema.Model.SearchObjects
{
    public class FITPasosSearchObject : BaseSearchObject
    {

        //public Guid UserId { get; set; }

        public DateTime? ExpirationDate { get; set; }

        public string? User { get; set; }

        public bool IncludeUsers { get; set; }
    }
}
