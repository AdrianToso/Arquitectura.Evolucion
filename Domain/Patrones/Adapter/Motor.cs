using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Patrones.Adapter
{
    public abstract class Motor
    {
        public abstract void Acelerar();
        public abstract void Arrancar();
        public abstract void Detener();
        public abstract void CargarCombustible();

    }
}
