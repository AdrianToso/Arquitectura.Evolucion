using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Patrones.Decorator
{
    public class Leche : AgregadoDecorator
    {
        public Leche(BebidaComponent bebida) : base(bebida)
        {
        }

        public override double Costo => _bebida.Costo + 4;

        public override string Descripcion => string.Format($"{_bebida.Descripcion}, Leche");
    }
}
