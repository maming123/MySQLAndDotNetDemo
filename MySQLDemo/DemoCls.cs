using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models.RCS;

namespace MySQLDemo
{
    public class DemoCls
    {
        public static void GetUserRole()
        {
            sys_role_permisson sysRP = new sys_role_permisson() { ID = Guid.NewGuid(), IsDelete = true, PermissonID = Guid.NewGuid(), PermissonType = 1, RoleID = Guid.NewGuid(), Version = 1 };
            sysRP.Insert();
            sys_user sysUser = sys_user.SingleOrDefault((object)"3712AB63-CB72-4028-9021-1E39737B4944");
        }
    }
}
