using Repository.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entities
{
    public class About: BaseEntity
    {
        public string Header { get; set; }
        public string Image1 { get; set; }
        public string Image2 { get; set; }
        public string Image3 { get; set; }
        public string Image4 { get; set; }
        public string Description { get; set; }
        public int Experience { get; set; }
        public int Chefs { get; set; }
        public string Mission { get; set; }
        public string vision { get; set; }
    }
}
