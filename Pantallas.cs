using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2___1
{
    public class Pantallas
    {
        public static string[] Almunos = new string[100];
        public static float[] Notas = new float[100];
        public static int contador = 0;
        
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
             string texto = "=============================\n" +
                 "Ingresar Nota\n" +
                 "=============================\n";
             Console.Write(texto);
        
             string NombreAlumno = Operaciones.getTextoPantalla("Ingrese el nombre: ");
             float  NotaAlumno = Operaciones.getDecimal("Ingrese la nota: ");
        
             Almunos[contador] = NombreAlumno;
             Notas[contador] = NotaAlumno;
             contador++;
        
             string texto2 ="=============================\n" +
                 "¡Guardado!\n" +
                 "=============================\n" +
                 "1: Agregar uno mas | 2: Volver\n" +
                 "=============================\n";
             Console.Write(texto2);
        
             int opcion = Operaciones.getEntero("Ingrese una opción: ", texto);
             if (opcion == 2) return 0;
             return opcion;
         }
        
         public static int NotamasAlta()
         {
             string texto = "=============================\n" +
                 "Nota mas alta\n" +
                 "=============================\n";
             Console.Write(texto);
        
             float NotaMayor = Notas[0];
             int PosicionNotaMayor = 0;
             for (int i = 0; i < contador; i++)
             {
                 if (Notas[i] > NotaMayor)
                 {
                     NotaMayor = Notas[i];
                     PosicionNotaMayor = i;
                 }
             }
        
             string nombredealumno = Almunos[PosicionNotaMayor];
             string AlumnoNotaMayor = "Estudiante: " + nombredealumno + 
                 "\nNota: " + NotaMayor;
             Console.WriteLine(AlumnoNotaMayor);
        
             string texto2 = "=============================\n" +
                 "Presiona Enter para volver\n" +
                 "=============================\n" +
                 ">";
             Console.Write(texto2);
             
             Console.ReadLine();
             Console.Clear();
             return MenuPrincipal();
         }
        
         public static int NotamasBaja()
         {
             string texto = "=============================\n" +
                           "Nota más baja\n" +
                           "=============================\n";
             Console.Write(texto);
        
             float NotaMenor = Notas[0];
             int PosicionNotaMenor = 0;
             for (int i = 0; i < contador; i++)
             {
                 if (Notas[i] < NotaMenor)
                 {
                     NotaMenor = Notas[i];
                     PosicionNotaMenor = i;
                 }
             }
        
             string nombredealumno = Almunos[PosicionNotaMenor];
             string AlumnoNotaMenor = "Estudiante: " + nombredealumno +
                 "\nNota: " + NotaMenor;
             Console.WriteLine(AlumnoNotaMenor);
        
             string texto2 = "=============================\n" +
                 "Presiona Enter para volver\n" +
                 "=============================\n" +
                 ">";
             Console.Write(texto2);
        
             Console.ReadLine();
             Console.Clear();
             return MenuPrincipal();
         }
        
         public static int ListaEstudiantes()
         {
             string texto = "=============================\n" +
              "Lista de Estudiantes\n" +
              "=============================\n";
             Console.Write(texto);
        
             for (int i = 0; i < contador; i++)
             {
                 Console.WriteLine(Almunos[i] + "\t\t\t" + Notas[i]);
             }
        
            string texto2 =  "=============================\n" +
              "Presiona Enter para volver\n" +
              "=============================\n" +
              ">";
             Console.Write(texto2);
        
             Console.ReadLine();
             Console.Clear();
             return MenuPrincipal();
         }
    }
}
