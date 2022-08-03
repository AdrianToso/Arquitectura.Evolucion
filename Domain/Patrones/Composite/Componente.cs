using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Patrones.Composite
{
    public abstract class Componente
    {
        string _nombre;
        public Componente(string nombre)
        {
            _nombre = nombre;
        }
        public string Nombre { get { return _nombre; } }
        public abstract void AgregarHijo(Componente c);
        public abstract IList<Componente> ObtenerHijos();
        public abstract int GetSize { get; } //la en ingles por la ñ
    }
}
