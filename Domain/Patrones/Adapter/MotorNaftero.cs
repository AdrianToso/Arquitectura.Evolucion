using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Patrones.Adapter
{
    public class MotorNaftero:Motor
    {
        public override void Acelerar()
        {
            Console.WriteLine("acelerando motor naftero");
        }

        public override void Arrancar()
        {
            Console.WriteLine("arrancando motor naftero");
        }

        public override void CargarCombustible()
        {
            Console.WriteLine("cargando combustible motor naftero");
        }

        public override void Detener()
        {
            Console.WriteLine("deteniendo motor naftero");
        }
    }
}
