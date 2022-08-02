using Domain;
using Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationService
{
    public class UserAppService
    {
        private UserRepository _repo;
        public UserAppService()
        {
            _repo = new UserRepository();
        }
        public User GetUserById(int Id)
        {
            return _repo.GetUserById(Id);
        }
    }
}