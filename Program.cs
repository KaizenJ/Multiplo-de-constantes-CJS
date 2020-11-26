using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplo_de_constantesCJS
{
    class Program
    {
        static void Main(string[] args)
        {
         //Variables
            string Nombre;
            string Apellido;
            string Curso;
         //Register 

            Console.WriteLine(" ««««« Bienvenido al register KaizenJS »»»»»»");
            Console.ReadLine();


            Console.WriteLine("Nombre del estudiante: ");
            Nombre = Console.ReadLine();
         //Console.ReadLine();

            Console.WriteLine("Apellido del estudiante: ");
            Apellido = Console.ReadLine();

            Console.WriteLine("Curso de estudiante: ");
            Curso = (Console.ReadLine());

         //Auto-Calculator

            Console.WriteLine("¦¦¦¦¦¦¦¦¦¦¦¦¦¦¦¦¦ Bienvenido a Calculator JS ¦¦¦¦¦¦¦¦¦¦¦¦¦¦¦¦¦¦¦¦¦");
            Console.ReadLine();

            Console.WriteLine("Usuario completlo: {0} {1} ,Pertenece a : {2} ", Nombre, Apellido, Curso);
            Console.ReadLine();


            int Num1, Num2, Total;
            string Linea;

            Console.WriteLine("Digite su primer numero: ");
            Linea = Console.ReadLine();
            Num1 = int.Parse(Linea);

            Console.WriteLine("Digite su segundo numero: ");
            Linea = Console.ReadLine();
            Num2 = int.Parse(Linea);

            Console.WriteLine();
            Total = Num1 * Num2;
            Console.WriteLine("El total de su multiplicación es : " + Total);
            Total = Num1 + Num2;
            Console.WriteLine("El total si fuera sumando seria de : " + Total);
            Total = Num1 - Num2;
            Console.WriteLine("El total si fuera restando seria de :" + Total);
            Total = Num1 / Num2;
            Console.WriteLine("El total si fuera dividiendo seria de :" + Total);

         //Key .exit
            Console.WriteLine("Pulse cualquier tecla para salir.");
            Console.ReadKey();

        }
    }
}
