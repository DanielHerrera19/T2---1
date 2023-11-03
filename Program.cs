using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T2___1;

namespace T2___1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion = Pantallas.MenuPrincipal();

            do
            {
                switch (opcion)
                {
                    case 1:
                        Pantallas.IngresarNota();
                        break;
                    case 0:
                        Pantallas.MenuPrincipal();
                        break;
                }
            } while (opcion !=4);
        }        
    }
}
