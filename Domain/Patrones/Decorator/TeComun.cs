using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Patrones.Decorator
{
    public class TeComun : BebidaComponent
    {
        public override double Costo => 8;

        public override string Descripcion => "Té";
    }
}
