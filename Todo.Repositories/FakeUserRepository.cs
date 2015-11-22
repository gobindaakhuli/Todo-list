using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo.Repositories.Interfaces;

namespace Todo.Repositories
{
    public class FakeUserRepository : IFakeUserRepository
    {
        public bool IsUser(string login, string pass)
        {
            if (login == "admin" && pass == "Misha")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
