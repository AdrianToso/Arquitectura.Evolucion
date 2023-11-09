﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractions
{
    public interface ISujetoProducto
    {
        void Agregar(IObserverUsuario usuario);
        void Quitar(IObserverUsuario usuario);
        void Notificar();
    }
}
