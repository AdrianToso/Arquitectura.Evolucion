using Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Domain.Patrones.Observer
{

    public class Usuario : IObserverUsuario
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public Usuario(string nombre, string apellido)
        {
            Nombre = nombre;
            Apellido = apellido;
        }
     
        //public void Actualizar(Producto p)
        //{
        //  //  Form1 f = (Form1)Application.OpenForms[0];
        //    //f.Notificar($"El usuario {this} recibio la notificacion del productio {p}");
        //}

        public void Actualizar(ISujetoProducto p)
        {
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            return $"{Nombre} {Apellido}";
        }
    }
}
