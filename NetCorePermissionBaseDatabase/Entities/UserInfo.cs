using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCorePermissionBaseDatabase.Entities
{
    public class UserInfo
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public DateTime CreatedTime { get; set; }
        public int CreatedUser { get; set; }
        public DateTime? UpdatedTime { get; set; }
        public int? UpdatedUser { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}
