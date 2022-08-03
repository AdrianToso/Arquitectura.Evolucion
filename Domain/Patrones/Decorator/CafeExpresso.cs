using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Patrones.Decorator
{
    public class CafeExpresso :BebidaComponent
    {
        public override double Costo => 15;

        public override string Descripcion => "Café expresso";
    }
}
