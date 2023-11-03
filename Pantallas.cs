using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2___1
{
    public class Pantallas
    {
        public static int MenuPrincipal()
        {
            string texto = "=============================\n" +
                "Notas de Estudiante\n" +
                "=============================\n" +
                "1: Ingresar Nota\n" +
                "2: Nota mas alta\n" +
                "3: Nota mas baja\n" +
                "4: Ver lista de estudiantes\n" +
                "=============================\n";
            Console.Write(texto);

            return Operaciones.getEntero("Ingrese una opción: ", texto);
        }

        public static int IngresarNota()
        {
            Console.Clear();
            string texto = "=============================\n" +
                "Ingresar Nota\n" +
                "=============================\n"+
                "Ingrese el nombre: \n" +
                "Ingrese la nota: \n" + 
                "=============================\n" +
                "¡Guardado!\n" +
                "=============================\n" +
                "1: Agregar uno mas | 2: Volver\n" +
                "=============================\n"; 
                Console.Write(texto);

            int opcion =Operaciones.getEntero("Ingrese una opción: ", texto);
            if (opcion == 2) return 0;
            if (opcion == 1) return 1;
            return opcion;
        }


    }
}
