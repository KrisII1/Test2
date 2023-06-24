using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Interest
    {
        [Key]
        public int Id { get; set; }
        [StringLength(20, MinimumLength = 1)]

        public string Name { get; set; }

        public Area Area { get; set; }
        public List<User> Users { get; set; }


        public Interest(string name)
        {
            Name = name;
            Users = new List<User>();
        }

        private Interest()
        {
            Users = new List<User>();
        }
    }
}
