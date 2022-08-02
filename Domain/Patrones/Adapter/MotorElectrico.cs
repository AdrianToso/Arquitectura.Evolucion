using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Patrones.Adapter
{
    public class MotorElectrico
    {
        bool _conectado;
        bool _activo;
        bool _moviendo;
        public void Conectar()
        {
            if (_conectado)
                Console.WriteLine("Imposible conectar motor ya conectado");
            else
               {
                _conectado = true;
                Console.WriteLine("Motor conectado");
               }
        }
        public void Activar()
        {
            if (!_conectado)
                Console.WriteLine("Imposible activar  motor no conectado");
            else
            {
                _activo = true;
                Console.WriteLine("Motor activado");
            }
        }
        public void Mover()
        {
            if (_conectado && _activo)
            {
                _moviendo = true;
                Console.WriteLine("Moviendo vehiculo con motor electrico");
            }
            else
            {
                
                Console.WriteLine("El motor debe estar conectado y activo");
            }
        }
        public void Parar()
        {
            if (_moviendo)
            {
                _moviendo = false;
                Console.WriteLine("Deteniendo vehiculo con motor electrico");
            }
            else
            {

                Console.WriteLine("El motor esta detenido");
            }
        }
        public void Desconectar()
        {
            if (_conectado )
            {
                Console.WriteLine("Motor desconectado");
            }
            else
            {
                Console.WriteLine("El motor debe estar conectado y activo");
            }
        }
        public void Desactivar()
        {
            if (_activo)
            {
                _activo = false;
                Console.WriteLine("Desactivado");

            }
            else
            {
                Console.WriteLine("Motor inactivo");
            }

        }
        public void Enchufar()
        {
            if(!_activo)
            {
                _activo = false;
                Console.WriteLine("Cargando bateria");

            }else
            {
                Console.WriteLine("Motor Activo imposible cargar");
            }

        }


    }
       

}
