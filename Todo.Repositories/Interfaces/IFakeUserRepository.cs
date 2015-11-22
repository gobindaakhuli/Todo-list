using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo.Repositories.Interfaces
{
    public interface IFakeUserRepository
    {
        bool IsUser(string login, string pass);
    }
}
