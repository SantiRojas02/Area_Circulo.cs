using System;

namespace Area_Circulo.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            double area = 3.1415;
            Console.Write("Ingrese el radio del circulo: ");
            int radio = Convert.ToInt32(Console.ReadLine());

            area = 3.1415 * radio * 2;

            Console.WriteLine("El area del circulo es: " + area);


            Console.ReadKey();
        }
    }
}
