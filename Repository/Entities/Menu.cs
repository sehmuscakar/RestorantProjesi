using Repository.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entities
{
   public class Menu:BaseEntity
    {
        public string Hedaer { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public int amount { get; set; }

    }
}
