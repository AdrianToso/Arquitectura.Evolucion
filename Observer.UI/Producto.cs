using Observer.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Domain.Patrones.Observer
{
    public class Producto : ISujetoProducto
    {
        private List<IObserverUsuario> _usuarios;
        public Producto(string nonbre, double precio)
        {
            _usuarios = new List<IObserverUsuario>();
            Nombre = nonbre;
            _precio = precio;
        }
        public string Nombre { get; set; }
        double _precio;
        public double Precio
        {
            get
            {
                return _precio;
            }
            set
            {
                _precio = value;
                this.Notificar();
            }
        }
        public void Agregar(IObserverUsuario usuario)
        {
            if (!_usuarios.Contains(usuario))
            {
                _usuarios.Add(usuario);
            }
            else
            {
                throw new Exception($"Ya existe una suscripcion para {(Usuario)usuario}");
            }

        }
        public override string ToString()
        {
            return $"{Nombre} ${_precio}";
        }
        public void Notificar()
        {
            foreach (var usuario in _usuarios)
            {
                usuario.Actualizar(this);
            }
            Form1 f = (Form1)Application.OpenForms[0];
            if (_usuarios.Count == 0)
            {
                f.Notificar($"No hay suscripciones");
            }
            f.Notificar($"------------------------------------------------------------------");
        }

        public void Quitar(IObserverUsuario usuario)
        {
            if (_usuarios.Contains(usuario))
            {
                _usuarios.Remove(usuario);
            }
            else
            {
                throw new Exception($"No existe una suscripcion para {((Usuario)usuario)}");
            }
        }
    }
}
