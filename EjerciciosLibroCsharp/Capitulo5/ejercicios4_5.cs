using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjerciciosLibroCsharp.Capitulo5
{
    class ejercicios4_5
    {
        public void cap5_4()
        {
            int numero, factorial = 1;

            Console.WriteLine("digite un numero");
            numero = int.Parse(Console.ReadLine());

            for (int x = 1; x < numero + 1; x++)
            {
                factorial = factorial * x;
            }
            Console.Write("el resultado es : " + factorial);

            Console.ReadKey();
        }

        public void cap5_5()
        {
            int numero;
            Console.WriteLine("digite un numero");
            numero = int.Parse(Console.ReadLine());

            if (numero == 1)
            {
                Console.Write("Clifford Jeffrey");

            }
            else if (numero == 2)
            {
                Console.Write("Danilo Medina");
            }
            else if (numero == 3)
            {
                Console.Write("Programacion Aplicada 1");
            }
            else if (numero == 4)
            {
                Console.Write("Republica Dominicana");
            }
            else if (numero > 4)
            {
                Console.WriteLine("ya no hay mas Palabra solo cuatro Palabra");

            }
            Console.ReadKey();
        }
    }
    }

