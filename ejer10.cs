using System;

namespace DdF1_10
{
    public static class Ejer10
    {
        public static void Run()
        {
            Console.WriteLine("Ingrese un nÃºmero para saber si es positivo o negativo:");
            if (double.TryParse(Console.ReadLine(), out double numero))
            {
                if (numero > 0)
                {
                    Console.WriteLine("El nÃºmero es positivo.");
                }
                else if (numero < 0)
                {
                    Console.WriteLine("El nÃºmero es negativo.");
                }
                else
                {
                    Console.WriteLine("El nÃºmero es cero.");
                }
            }
            else
            {
                Console.WriteLine("Entrada no vÃ¡lida. Por favor, ingrese un nÃºmero.");
            }
        }
    }
}