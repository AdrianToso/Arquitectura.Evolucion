using Abstractions;
using Abstractions.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public  class User : Entity , IUsuario
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
