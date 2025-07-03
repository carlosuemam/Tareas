using System;

namespace DdF1_10
{
    public static class Ejer7
    {
        public static void Run()
        {
            Console.WriteLine("Ingrese los datos del cÃ­rculo:");
            
            Console.Write("Radio: ");
            
            double radio = Convert.ToDouble(Console.ReadLine());
            
            double area = Math.PI * Math.Pow(radio, 2); 
            //Math.Pow(base, exponente)
            //Devuelve un nÃºmero especificado elevado a la potencia especificada.
            
            Console.WriteLine($"El Ã¡rea del cÃ­rculo es: {area}");
        }
    }
}