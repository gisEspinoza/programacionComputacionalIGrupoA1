using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clasePractica3007
{
    class Ejericio1
    {
        //declaracion de ENUm
        //constantes
        public enum Dias { 
            LUNES, MARTES, MIERCOLES, JUEVES, VIERNES, SABADO, DOMINGO
        }
        static void Main(string[] args)
        {
            //ENUM
            //clase especial, representa un conjutno de constantes
            Console.WriteLine("Escriba el numero correspondiente al dia de la semana: ");
            //int dia = Convert.ToInt32(Console.ReadLine()); //Convert. se utiliza para convertir tipos de datos
            int dia = int.Parse(Console.ReadLine()); //realiza un tipo de conversion

            switch (dia)
            {
                case 1:
                    Console.WriteLine(Dias.LUNES);
                    break;
                case 2:
                    Console.WriteLine(Dias.MARTES);
                    break;
            }

            Console.ReadKey();
        }
    }
}
