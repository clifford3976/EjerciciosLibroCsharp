using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjerciciosLibroCsharp.Chapter8
{
    class ejercicios3_5
    {
        public void cap8_3()
        {
            {
                Console.WriteLine(string.Format("{0:hh:mm:ss tt}", DateTime.Now));

                Console.WriteLine(DateTime.Now.ToShortDateString());
                Console.ReadKey();
            }
        }
    }
}
