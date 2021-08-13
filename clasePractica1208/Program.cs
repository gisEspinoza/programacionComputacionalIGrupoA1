using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clasePractica1208
{
    class Program
    {
        static void Main(string[] args)
        {
            //llamado al metodo loops
            loops();

            Console.ReadLine();
        }
        ///bucles
        public static void loops()
        {
            //1- escribir un ciclo que permita capturar los valores
            //a almacenar en el arreglo de numbers con un tamaño de 10
            //2- calcular e imprimir el promedio de los numeros almacenados en el array

            int[] numbers = new int[10];
            int sumatoria=0; //almacenara la sumatoria de los valores

            /* numbers[0] = 5;
             numbers[1] = 10;
             numbers[2] = 15;*/

            //capturar los valores a almacenar en el array
            for (int x = 0; x < numbers.Length; x++)
            {
                Console.Write("Escriba el valor para el elemento {0}: ", x);
                numbers[x] = Convert.ToInt32(Console.ReadLine());
            }

            //ciclo while
            int i = 0;
            Console.WriteLine("IMPRIME ELEMENTOS CON WHILE");
            while (i < numbers.Length)
            {
                Console.WriteLine(numbers[i]);
                i = i + 1; //i++
            }

            Console.WriteLine("IMPRIME ELEMENTOS CON DO-WHILE");
            int inc = 0;
            do
            {
                Console.WriteLine(numbers[inc]);
                inc++;
            } while (inc < numbers.Length);


            Console.WriteLine("IMPRIME ELEMENTOS CON FOR - ARREGLO ORDENADO");
            //llamado a la clase Array y al metodo sort
            Array.Sort(numbers); //el metodo sort permite ordenar los valores dentro de un array
            for (int j = 0; j < numbers.Length; j++)
            {
                Console.WriteLine("Posicion {0} : {1}", j, numbers[j]);

                //sumar los valores dentro del array
                //sumatoria = 0 + 5; numbers[0]
                //sumatoria = 5 + 10; numbers[1]
                //sumatoria = sumatoria + numbers[j];
                sumatoria += numbers[j];
                //Console.WriteLine(sumatoria);
            }

            Console.WriteLine("IMPRIME ELEMENTOS CON FOREACH -  ARREGLO INVERTIDO");
            Array.Reverse(numbers); //reverse permite invertir los valores dentro de un array
            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }

            //mostramos el valor promedio de los numeros del array
            Console.WriteLine("El valor promedio es de: {0}", sumatoria/(numbers.Length));
        }

    }
}
