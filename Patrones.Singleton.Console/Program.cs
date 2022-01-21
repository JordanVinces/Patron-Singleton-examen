using Patrones.Singleton.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Singleton.UIConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            Usuario usuario = new Usuario();
            usuario.Username = "coco";
            usuario.Password = "dulce";

            try
            {

                Sesionadmid.Login(usuario);
                
                Sesionadmid u = Sesionadmid.GetInstance;

                Sesionadmid.Logout();


            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }


         

        }
    }
}
