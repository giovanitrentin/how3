using DAL;

namespace BLL
{
    public static class EfetuaLoginBLL
    {
        public static bool EfetuaLogin(string login, string senha)
        {
            return LoginDAL.EfetuaLogin(login, senha) != null;
        }
    }
}
