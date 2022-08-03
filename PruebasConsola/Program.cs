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
            Componente root = new Directorio("Raiz");

            Componente archivo1 = new Archivo("Archivo1.txt",10);
            Componente archivo2 = new Archivo("Archivo2.txt", 30);
            Componente archivo3 = new Archivo("Archivo3.txt", 120);
            Componente archivo4 = new Archivo("Archivo4.txt", 800);
            Componente archivo5 = new Archivo("Archivo5.txt", 460);

            Componente dir1 = new Directorio("dir1");
            Componente dir2 = new Directorio("dir2");
            Componente dir3 = new Directorio("dir3");

            dir1.AgregarHijo(archivo1);
            dir2.AgregarHijo(archivo2);
            dir3.AgregarHijo(archivo3);
            dir3.AgregarHijo(archivo4);
            dir1.AgregarHijo(dir3);

            root.AgregarHijo(dir1);
            root.AgregarHijo(dir2);
            root.AgregarHijo(archivo5);


            Console.WriteLine($"El tamaño del directorio: {root.Nombre} es: {root.GetSize}");
            Console.WriteLine();
            Console.WriteLine($"El tamaño del directorio: {dir1.Nombre} es: {dir1.GetSize}");
            Console.WriteLine();
            Console.WriteLine($"El tamaño del directorio: {dir2.Nombre} es: {dir2.GetSize}");
            Console.WriteLine();
            Console.WriteLine($"El tamaño del directorio: {dir3.Nombre} es: {dir3.GetSize}");
            Console.WriteLine();
            Console.ReadKey();


            #endregion
        }
    }
}
