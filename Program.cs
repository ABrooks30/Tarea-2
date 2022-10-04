using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tarea2
{
    class Program
    {
        static void Main(string[] args)
        {
            string empleado;
            int salario1, salario2, salario3, salario4, salario5;
            string salarios;
            int aguinaldo1, aguinaldo2, aguinaldo3, aguinaldo4, aguinaldo5;
            string aguinaldo;
            {

                Console.Write("Ingrese el nombre del empleado");
                empleado = Console.ReadLine();
                Console.Write("Ingrese el salario del empleado");
                salarios = Console.ReadLine();
                salario1 = int.Parse(salarios);
                Console.Write("Ingrese el nombre del empleado");
                empleado = Console.ReadLine();
                Console.Write("Ingrese el salario del empleado");
                salarios = Console.ReadLine();
                salario2 = int.Parse(salarios);
                Console.Write("Ingrese el nombre del empleado");
                empleado = Console.ReadLine();
                Console.Write("Ingrese el salario del empleado");
                salarios = Console.ReadLine();
                salario3 = int.Parse(salarios);
                Console.Write("Ingrese el nombre del empleado");
                empleado = Console.ReadLine();
                Console.Write("Ingrese el salario del empleado");
                salarios = Console.ReadLine();
                salario4 = int.Parse(salarios);
                Console.Write("Ingrese el nombre del empleado");
                empleado = Console.ReadLine();
                Console.Write("Ingrese el salario del empleado");
                salarios = Console.ReadLine();
                salario5 = int.Parse(salarios);


                aguinaldo1 = salario1 * 12;
                aguinaldo2 = salario1 * 12;
                aguinaldo3 = salario1 * 12;
                aguinaldo4 = salario1 * 12;
                aguinaldo5 = salario1 * 12;


                Console.WriteLine("El salario de " + empleado "es de: " + salario1 "y su aguinaldo es de: " + aguinaldo1);
                Console.WriteLine("El salario de " + empleado "es de: " + salario2 "y su aguinaldo es de: " + aguinaldo2);
                Console.WriteLine("El salario de " + empleado "es de: " + salario3 "y su aguinaldo es de: " + aguinaldo3);
                Console.WriteLine("El salario de " + empleado "es de: " + salario4 "y su aguinaldo es de: " + aguinaldo4);
                Console.WriteLine("El salario de " + empleado "es de: " + salario5 "y su aguinaldo es de: " + aguinaldo5);



            }
        }
    }
}
