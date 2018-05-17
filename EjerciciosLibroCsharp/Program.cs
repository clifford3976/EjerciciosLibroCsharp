using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjerciciosLibroCsharp
{
    class Program
    {
        static void Main(string[] args)
        {

            string linea;
            for (; ; )
            {
                Console.WriteLine("Aqui tenemos todos los ejercicios del capitulo 5 hastas el capitulo 8");
                Console.WriteLine("Escoge una opcion: ");
                Console.WriteLine("1- Capitulo 5 ");
                Console.WriteLine("2- Capitulo 6 ");
                Console.WriteLine("3- Capitulo 7 ");
                Console.WriteLine("4- Capitulo 8 ");
                linea = Console.ReadLine();
                Console.Clear();
                switch (linea)
                {
                    case "1":
                        Console.WriteLine("1- factorial de un numero");
                        Console.WriteLine("2- cadena que regresa palabras");
                        linea = Console.ReadLine();
                        Console.Clear();
                        if (linea == "1")
                        {
                            EjerciciosLibroCsharp.Capitulo5.ejercicios4_5 E = new EjerciciosLibroCsharp.Capitulo5.ejercicios4_5();
                            E.cap5_4();

                        }
                        else
                            if (linea == "2")
                        {
                            EjerciciosLibroCsharp.Capitulo5.ejercicios4_5 E = new EjerciciosLibroCsharp.Capitulo5.ejercicios4_5();
                            E.cap5_5();
                        }
                        Console.Clear();

                        break;
                }
            }
        }
    }
}
