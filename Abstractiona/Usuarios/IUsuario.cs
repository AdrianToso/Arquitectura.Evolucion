﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractions.Usuarios
{
 
    public interface IUsuario : IEntity
    {
            string Username { get; set; }
            string Password { get; set; }
        }
    }

