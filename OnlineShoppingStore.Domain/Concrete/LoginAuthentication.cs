using OnlineShoppingStore.Domain.Abstract;
using OnlineShoppingStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShoppingStore.Domain.Concrete
{
    public class LoginAuthentication : ILoginAuthentication
    {
        private readonly DBContextjqueryMVC context = new DBContextjqueryMVC();
        public bool AuthenticateUser(string UserName,string Password)
        {
           User user= context.Users.FirstOrDefault(u => u.Name==UserName);
            if (user != null)
            {
                if (user.Password == Password)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }

        public void SaveUser(User user)
        {
            User dbUser = null;
            if ( user.UserId==null)
            {
                dbUser= new User();
                dbUser.UserId =( context.Users.Max(u=>u.UserId)+ 1).ToString();
            }
            else
            {
                dbUser = new User(); 
                 dbUser=   context.Users.FirstOrDefault(u => u.UserId == user.UserId); 
            }
            dbUser.Name = user.Name;
            dbUser.Password = user.Password;
            dbUser.Email = user.Email;
            dbUser.Phone = user.Phone;
            dbUser.Address1 = user.Address1;
            dbUser.Address2 = user.Address2;

            context.SaveChanges();
        }
    }
}
