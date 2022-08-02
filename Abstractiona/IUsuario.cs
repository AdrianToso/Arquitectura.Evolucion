using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractiona
{
    public interface IEntity
    {
        int Id { get; set; }
    }
    public interface IUsuario:IEntity
    {
        string Username { get; set; }
        string Password { get; set; }
    }
}
