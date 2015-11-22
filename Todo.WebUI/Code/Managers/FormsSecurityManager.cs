using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Todo.WebUI.Code.Managers.Interfaces;
using System.Web.Security;
using Todo.Repositories.Interfaces;
using Todo.Repositories;

namespace Todo.WebUI.Code.Managers
{
    public class FormsSecurityManager : ISecurityManager
    {
        IFakeUserRepository _usrRepository;
        public FormsSecurityManager(IFakeUserRepository usrRepository)
        {
            _usrRepository = usrRepository;
        }
        bool ISecurityManager.Login(string login, string password)
        {

            if (_usrRepository.IsUser(login, password))
            {
                FormsAuthentication.SetAuthCookie(login, false);
                return true;
            }
            else
            {
                return false;
            }

            //if (userName == "admin" && password == "Misha")
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
        }
        void ISecurityManager.Logout()
        {
            FormsAuthentication.SignOut();
        }
    }
}