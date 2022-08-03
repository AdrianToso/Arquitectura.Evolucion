using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Patrones.Composite
{
    public class Archivo : Componente
    {
        int _size; //sigue el temita de la ñ 
        public Archivo(string nombre , int size) : base(nombre)
        {
            _size = size;
        }

        public int Size { get { return _size; } }

        public override int GetSize
        {
            get { return _size; }
        }

        public override void AgregarHijo(Componente c)
        {
            
        }

        public override IList<Componente> ObtenerHijos()
        {
            return null;
        }
    }
}
