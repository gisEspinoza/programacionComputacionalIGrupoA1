using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace claseTeorica1208
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
            //escribir un ciclo que permita capturar los valores
            //a almacenar en el arreglo de numbers con un tamaño de 10

            int[] numbers = new int[10];
            /* numbers[0] = 5;
             numbers[1] = 10;
             numbers[2] = 15;*/
            for (int x= 0; x < numbers.Length; x++)
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
                i=i+1; //i++
            }

            Console.WriteLine("IMPRIME ELEMENTOS CON DO-WHILE");
            int inc = 0;
            do
            {
                Console.WriteLine(numbers[inc]);
                inc++;
            } while (inc < numbers.Length);


            Console.WriteLine("IMPRIME ELEMENTOS CON FOR - ARRAY ORDENADO");
            Array.Sort(numbers); //el metodo Sort de la clase Array permite ordenar un arreglo de una dimension
            for (int j = 0; j < numbers.Length; j++)
            {
                Console.WriteLine("Posicion {0} : {1}", j, numbers[j]);
            }

            Console.WriteLine("IMPRIME ELEMENTOS CON FOREACH -  ARRAY INVERTIDO");
            Array.Reverse(numbers); //el metodo Reverse de la clase Array permite invertir los valores
            //dentro de un array
            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }
           
        }

    }
}
