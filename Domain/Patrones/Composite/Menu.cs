using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Patrones.Composite
{
    public class Menu : MenuComponent
    {
        
        private List<MenuItem> _items;
        public Menu(string nombre, string descrip, string precio) : base(nombre, descrip, precio)
        {
            _items = new List<MenuItem>();
        }

        public override void AddChildren(MenuComponent mc)
        {
            _items.Add((MenuItem)mc);
        }

        public override string GetDescrip()
        {
            return Description;
        }

        public override string GetPrecio()
        {
            return Precio;
        }

        public override string Imprimir()
        {
            return _items.ToList().ToString();
        }

        public override void RemoveChildren(MenuComponent mc)
        {
           _items.Remove((MenuItem)mc);
        }
    }
}
