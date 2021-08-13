using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace claseTeorica1208
{
    class Ejercicio1
    {
        static void Main()
        {
            //definir el arreglo estudiantes con 10 elementos
            string[] estudiantes = new string[5];
            string[] genero = new string[5];
            int[] edad = new int[5];

            //almacenara la cantidad de estudiantes con el genero femenino
            int femenino = 0; //inicializamos la variable

            //solicitar nombres
            for (int i = 0; i < estudiantes.Length; i++)
            {
                Console.Write("Escriba el nombre para el alumno {0}: ", i);
                estudiantes[i] = Console.ReadLine();
                Console.Write("Seleccione el genero f/m: ");

                edad[i] = Convert.ToInt32(Console.ReadLine());

                genero[i] = Console.ReadLine();
            }

            //imprimir datos de los estudiantes
            //ordenar array
            Console.WriteLine("DATOS DE LOS ESTUDIANTES");
          //  Array.Sort(estudiantes); //ORDENA EL ARRAY
            for (int i = 0; i < estudiantes.Length; i++)
            {
                Console.WriteLine("Nombre: {0} | Genero: {1}",estudiantes[i], genero[i]);

                //evaluar la cantidad de estudiantes con el genero femeniino
                if (genero[i] == "f")
                {
                    //femenino = femenino + 1;
                    femenino += 1;
                }
            }
            Console.WriteLine("La cantidad de estudiantes con genero femenino es {0}", femenino);
            Console.ReadKey();
        }
    }
}
