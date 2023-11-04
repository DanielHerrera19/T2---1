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
                 Console.Clear();
                 switch (opcion)
                 {
                     case 1:
                         opcion = Pantallas.IngresarNota();
                         break;
                     case 2:
                         opcion= Pantallas.NotamasAlta();
                         break;
                     case 3:
                         opcion = Pantallas.NotamasBaja();
                         break;
                     case 4:
                         opcion = Pantallas.ListaEstudiantes();
                         break;
                     case 0:
                     default:
                         opcion = Pantallas.MenuPrincipal();
                         break;
                 }
            } while (opcion !=5);
        }        
    }
}
