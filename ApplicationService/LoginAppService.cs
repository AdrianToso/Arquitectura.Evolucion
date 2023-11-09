using Domain;
using Repository;
using Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationService
{
    public class LoginAppService
    {
        private UserRepository _repo;
        public LoginAppService()
        {
            _repo = new UserRepository();   
        }
      
     
        
        public void Login(string username, string password)
        {
            if (String.IsNullOrEmpty(username) || String.IsNullOrEmpty(password)) 
                throw new Exception("Todos los campos son obligatorios");


            try
            {
                User user = _repo.GetUserByUsernamePassword(username, password);               

                if (user ==null) throw new Exception("usuario o password incorrecto");

                SessionHandler.Login(user);
                         
            }
            catch (Exception e)
            {
                throw e;

            }
           

        }
        public static void CerrarSession()
        {
           SessionHandler.CerrarSession();
        }


    }
}
