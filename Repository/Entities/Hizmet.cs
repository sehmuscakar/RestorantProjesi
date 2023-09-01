using Repository.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entities
{
    public class Hizmet:BaseEntity
    {
        public  string Header  { get; set; }
        public  string Description { get; set; }
        public  string Image { get; set; }
    }
}
