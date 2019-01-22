using OnlineShoppingStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShoppingStore.Domain.Abstract
{
    public interface ILoginAuthentication
    {
        bool AuthenticateUser(string UserName, string Password); 
        void SaveUser(User user);
    }
}
