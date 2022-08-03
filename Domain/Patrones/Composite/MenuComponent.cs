using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Patrones.Composite
{
    public abstract class MenuComponent
    {

        string _descrip;
        string _nombre;
        string _precio  ;
        public MenuComponent(string nombre, string descrip, string precio)
        {
            _nombre = nombre;
            _descrip = descrip;
            _precio = precio;
        }
        public string Nombre { get { return _nombre; } }
        public string Description { get { return _descrip; } }
        public string Precio { get { return _precio; } }
        public abstract void RemoveChildren(MenuComponent mc);
       public abstract string GetDescrip();
        public abstract string GetPrecio();
        public abstract string Imprimir();
        public abstract void AddChildren(MenuComponent mc);
    }
}
