using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clasePractica3007
{
    class Program
    {
        static void Main(string[] args)
        {
            //operadores
            string nombre = "jose";
            string saludo = "Bienvenido";
            int a = 10;
            int b = 20;

            //Console.WriteLine(saludo + nombre);

            /* if (a < b) //operador de comparacion, menor que
             {
                 Console.WriteLine("a es menor a b");
             }
             else if(a > b)
             {
                 Console.WriteLine("a es mayor a b");
             }
             else
             {
                 Console.WriteLine("a y b son iguales");
             }*/

            //IF ANIDADOS
            if (a != b) //operador de comparacion, diferente de
            {
                if (a < b)
                {
                    Console.WriteLine("a es menor que b");
                }
                else if (a > b)
                {
                    Console.WriteLine("a es mayor a b");
                }
            }
            else
                Console.WriteLine("a es igual a b");


            //OPERADOR TERNARIO
            //la forma abreviada de if else

            var resultado = a > b ? "a es mayor a b" : "a es menor a b";
            Console.WriteLine("Resultado con operador ternario: {0}", resultado);

            Console.ReadKey();

        }
    }
}
