using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Domain.Patrones.Adapter;

namespace PruebasConsola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MotorNaftero motor1 = new MotorNaftero();
            motor1.Arrancar();
            motor1.Acelerar();
            motor1.Detener();
            motor1.CargarCombustible();

            MotorDiesel motor2 = new MotorDiesel();
            motor2.Arrancar();
            motor2.Acelerar();
            motor2.Detener();
            motor2.CargarCombustible();

            MotorElectricoAdapter motor = new MotorElectricoAdapter();
            motor.Arrancar();
            motor.Acelerar();
            motor.Detener();
            motor.CargarCombustible();

            Console.ReadKey();
        }
    }
}
