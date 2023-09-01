using Repository.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entities
{
   public  class Testimonial:BaseEntity
    {
        public string ProjejctName { get; set; }
        public string Level { get; set; }
        public string Decription { get; set; }
        public string Image { get; set; }


    }
}
