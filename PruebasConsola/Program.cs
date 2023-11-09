using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Domain.Patrones.Adapter;
using Domain.Patrones.Composite;
using Domain.Patrones.Decorator;

namespace PruebasConsola
{
    internal class Program
    {
        public static object Nombre { get; private set; }

        static void Main(string[] args)
        {
            #region ADAPTER
            /*
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

            Console.ReadKey();*/
            #endregion

            #region DECORATOR
            /*
            BebidaComponent cafe = new CafeSolo();
            cafe = new Leche(cafe);
            cafe = new Azucar(cafe);

            BebidaComponent cafe1 = new CafeSolo();
            cafe1 = new Azucar(cafe1);
            cafe1 = new Azucar(cafe1);
            cafe1 = new Crema(cafe1);


            BebidaComponent te = new TeComun();
            te = new Edulcorante(te);

            BebidaComponent decaf = new CafeDescafeinado();
            decaf = new Edulcorante(decaf);

            Console.WriteLine($"Producto: {cafe.Descripcion} tiene un costo de : ${cafe.Costo}");
            Console.WriteLine();
            Console.WriteLine($"Producto: {cafe1.Descripcion} tiene un costo de : ${cafe1.Costo}");
            Console.WriteLine();
            Console.WriteLine($"Producto: {te.Descripcion} tiene un costo de : ${te.Costo}");
            Console.WriteLine();
            Console.WriteLine($"Producto: {decaf.Descripcion} tiene un costo de : ${decaf.Costo}");
            Console.ReadKey();*/
            #endregion

            #region COMPOSITE

            #endregion
        }
    }
}
