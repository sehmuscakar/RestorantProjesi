using Repository.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entities
{
    public class Team:BaseEntity
    {
        public string Name { get; set; }
        public string Expert { get; set; }
        public string Image { get; set; }
        public string SocialMedia { get; set; }
    }
}
