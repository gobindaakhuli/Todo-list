using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo.WebUI.Code.Managers.Interfaces
{
    public interface ISecurityManager
    {
        bool Login(string userName, string password);
        void Logout();
    }
}
