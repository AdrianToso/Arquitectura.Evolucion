using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Patrones.Decorator
{
    public class CafeDescafeinado :BebidaComponent
    {
        public override double Costo => 12;

        public override string Descripcion => "Café descafeinado";
    }
}
