using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCorePermissionBaseDatabase.Entities
{
    public class Menu
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Link { get; set; }
        public DateTime CreatedTime { get; set; }
        public int CreatedUser { get; set; }
        public DateTime? UpdatedTime { get; set; }
        public int? UpdatedUser { get; set; }

        public ICollection<Role> Roles { get; set; }
    }
}
