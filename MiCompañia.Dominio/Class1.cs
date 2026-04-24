using MiCompañia.Datos;
namespace MiCompañia.Dominio
{
    
   
    public class UserModel 
    {
        UserDAO userDAO = new UserDAO();
        public bool LoginUser(string user, string pass)
        {
            return userDAO.Login(user,pass);
        }
    }
}
