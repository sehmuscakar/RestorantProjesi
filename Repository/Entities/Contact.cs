using Repository.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entities
{
    public class Contact:BaseEntity
    {
        public string Name { get; set; }
        public string Mail { get; set; }
        public string Message { get; set; }
        public string Subject { get; set; }
        public string? BokkingContact { get; set; }
        public string? GeneralContact { get; set; }
        public string? TechnicalContact { get; set; }

    }
}
