using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Patrones.Observer
{
    public interface IObserverUsuario
    {
        void Actualizar(Producto p);
    }
}
