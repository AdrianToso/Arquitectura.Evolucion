﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Patrones.Decorator
{
    public abstract class BebidaComponent
    {
        public abstract double Costo { get; }
        public abstract string Descripcion { get; }
    }
}
