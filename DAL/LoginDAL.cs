using Model;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public static class LoginDAL
    {
        public static Login Get(int id)
        {
            using (Context context = new Context())
            {
                return context.Logins.FirstOrDefault(c => c.Id == id);
            }
        }

        public static Login Add(Login login)
        {
            using (Context context = new Context())
            {
                context.Logins.Add(login);
                context.SaveChanges();
                return login;
            }
        }

        public static Login Update(Login login)
        {
            using (Context context = new Context())
            {
                context.Logins.Update(login);
                context.SaveChanges();
                return login;
            }
        }

        public static List<Login> GetAll()
        {
            using (Context context = new Context())
            {
                return context.Logins.ToList();
            }
        }

        public static Login EfetuaLogin(string login, string senha)
        {
            using (Context context = new Context())
            {
                return context.Logins.FirstOrDefault(c => c.Email.Equals(login) && c.Senha.Equals(senha));
            }
        }
    }
}
