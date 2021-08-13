﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clasePractica1208
{
    class Colecciones
    {
        static void Main(string[] args)
        {
            //diccionario
            //almacena pares de dato clave y valor
            //definir un diccionario
            Dictionary<string, string> EmployeeList = new Dictionary<string, string>();

            //agregar elementos al diccionario
            EmployeeList.Add("Jose Flores", "Programador");
            EmployeeList.Add("Miranda Campos", "Gerente");
            EmployeeList.Add("Carmen Valladares", "Arquitecta");


            Dictionary<string, int> Students = new Dictionary<string, int>();
            Students.Add("Jose Flores", 22);
            Students.Add("Miranda Campos", 20);
            Students.Add("Carmen Valladares", 24);


            //leer el diccionario y mostarr los datos
            foreach (KeyValuePair<string, string> employee in EmployeeList)
            {
                Console.WriteLine("Clave: {0}, Valor: {1}", employee.Key, employee.Value);
            }

            //ordenar elementos del diccionario
            var dic = EmployeeList.Keys.ToList();
            dic.Sort();

            Console.WriteLine("Diccionario ordenado");
            foreach (var item in dic)
            {
                Console.WriteLine("{0}: {1}", item, EmployeeList[item]);
            }

            //contar elementos de un diccionario
            Console.WriteLine("Elementos en el diccionario: {0}", EmployeeList.Count);

            Console.ReadKey();
        }
    }
}
