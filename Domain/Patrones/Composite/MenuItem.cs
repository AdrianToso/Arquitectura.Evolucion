using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Patrones.Composite
{
    public class MenuItem : MenuComponent
    {
        public MenuItem(string nombre, string descrip, string precio) : base(nombre, descrip, precio)
        {
        }

        public override void AddChildren(MenuComponent mc)
        {
           
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
           return Nombre+ " " +Description+"  $:" + Precio ;
        }

        public override void RemoveChildren(MenuComponent mc)
        {
           ;
        }
    }
}
