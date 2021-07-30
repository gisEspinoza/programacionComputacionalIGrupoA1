//referencia hacia los espacios de nombre del .NET Framework
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace claseTeorica2907 //nombre del espacio de nombres
{
    class TiposDatos //nombre de la clase
    {
        static void Main(string[] args) //metodo principal
        {
            /*Console.WriteLine("Esta es la clase Variables");
            Console.ReadKey();*/

            //VARIABLES
            //tipos de datos

            //almacena 1 byte
            byte num1 = 255;

            //variante de byte
            //solo almacena numeros negativos
            sbyte num2 = -127;

            //int, soporta negativos y postivos, 4 bytes
            int num3 = 22;
            int num4 = -20;

            //uint, solamente adminte numeros positivos
            uint num5 = 28;

            //long permite almacenar mas datos
            //para procesar millones de datos, 8 bytes
            long num6 = -158;
            long num7 = 2000;

            ulong num8 = 2222222222; //solo admite numeros positivos

            //procesamiento de decimales
            //float, se debe especificar con una f, 4 bytes
            float num9 = 100.9f;

            //double, tiene mas alcance,8 bytes
            double num10 = 100.9d;

            //decimal, 16 bytes
            decimal num11 = 100.9m;

            //guardar cadena de caracater, solo permite 2 bytes
            //los 2 bytes se usan para representar la letra
            char caracter = 'A'; //se encierra en comillas simples

            //string
            string texto = "Programacion computacional I";


            //variables de tipo implicito
            //var, para declarar cualquier tipo de datos integrado o un tipo definido
            Console.WriteLine("Cual es su nombre: ");
            var nombre = Console.ReadLine(); //captura lo que el usuario escribe por teclado
            var cantidad = 100.50d;


            Console.WriteLine("El tipo de dato para la variable nombre es {0}", nombre.GetType());
            Console.WriteLine("El tipo de dato para la variable cantidad es {0}", cantidad.GetType());
            Console.ReadKey();

        }
    }
}
