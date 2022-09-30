

using System;

namespace Bootcamp_Calculator
{
    class Program
    { 
        /// <summary>
        /// Bootcamp - Calculator
        /// </summary>
        /// <param name="args">not used</param>
        static void Main(string[] args)
        {
            Console.WriteLine($"La Resta es {Resta(2, 1)}");
        }

        /// <summary>
        /// Resta de dos numeros enteros
        /// </summary>
        /// <param name="a">1er valor</param>
        /// <param name="b">2do valor</param>
        /// <returns></returns>
        private static int? Resta(int a, int b) {
            try
            {
                return a - b;
            }
            catch (Exception e){
                Console.WriteLine("Error en la Resta");
            }
            return null;
        }
    }
}
