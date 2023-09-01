using Repository.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entities
{
   public class Booking:BaseEntity
    {
        public string Name { get; set; }
        public string Mail { get; set; }
        public DateTime Time { get; set; }
        public int PeopleCount { get; set; }
        public string description { get; set; }

    }
}
