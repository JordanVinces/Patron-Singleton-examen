using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Singleton.Core
{
    public class Sesionadmid
    {

        private static object _lock = new Object();
        private static Sesionadmid _session;

        public Usuario Usuario { get; set; }
        public DateTime FechaInicio { get; set; }

        public static Sesionadmid GetInstance
        {
            get
            {
                if (_session == null) throw new Exception("Sesión no iniciada");

                return _session;
            }
        }

       public static void Login(Usuario usuario)
        {

            lock (_lock)
            {
                if (_session == null)
                {
                    _session = new Sesionadmid();
                    _session.Usuario = usuario;
                    _session.FechaInicio = DateTime.Now;
                }
                else
                {
                    throw new Exception("Sesión ya iniciada");
                }
            }
            } 

        public static void Logout()
        {
            lock (_lock)
            {
                if (_session != null)
                {
                    _session = null;
                }
                else
                {
                    throw new Exception("Sesión no iniciada");
                }
            }

           
        }

        private Sesionadmid()
        {

        }


    }
}
