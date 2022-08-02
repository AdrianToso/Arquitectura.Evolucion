using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Patrones.Adapter
{
    public class MotorDiesel : Motor
    {
        public override void Acelerar()
        {
            Console.WriteLine("acelerando motor diesel");
        }

        public override void Arrancar()
        {
            Console.WriteLine("arrancando motor diesel");
        }

        public override void CargarCombustible()
        {
            Console.WriteLine("cargando combustible motor diesel");
        }

        public override void Detener()
        {
            Console.WriteLine("deteniendo motor diesel");
        }
    }
}
