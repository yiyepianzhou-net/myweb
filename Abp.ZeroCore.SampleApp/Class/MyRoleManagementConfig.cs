using Abp.Zero.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abp.ZeroCore.SampleApp.Class
{
    public class MyRoleManagementConfig : IRoleManagementConfig
    {
        public List<StaticRoleDefinition> StaticRoles
        {
            get;
        }

        public MyRoleManagementConfig()
        {
            StaticRoles = new List<StaticRoleDefinition>();
        }
    }
}
