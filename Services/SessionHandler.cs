using Abstractiona;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public static class SessionHandler
    {
      
            static IUsuario _session;
            public static IUsuario Session
            {
                get
                {
                    return _session;
                }
            }
            public static void Login(IUsuario user)
            {
                _session = user;

            }
            public static void CerrarSession()
            {
                _session = null;
            }
            public static bool isLogged()
            {
                return _session != null;
            }
        }
    }


