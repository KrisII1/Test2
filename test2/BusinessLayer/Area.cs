using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Area
    {
        [Key]
        public int Id { get; set; }

        [StringLength(20, MinimumLength = 1,
            ErrorMessage= "first name should be minimum 1 character")]
        public string Name { get; set; }

        public List<User> Users { get; set; }

        public Area(string name)
        {
            Name = name;
            Users = new List<User>();
        }
        private Area()
        {
            Users = new List<User>();
        }
    }
}
