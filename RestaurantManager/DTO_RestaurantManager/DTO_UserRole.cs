using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_RestaurantManager
{
    public class DTO_UserRole
    {
        public int roleId { get; set; }
        public string roleName { get; set; }

        // Constructor không tham số
        public DTO_UserRole()
        {
        }

        // Constructor với tham số
        public DTO_UserRole(int roleId, string roleName)
        {
            this.roleId = roleId;
            this.roleName = roleName;
        }
    }
}
