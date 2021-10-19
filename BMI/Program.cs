using System;

namespace BMI
{
    class Program
    {
        static void Main(string[] args)
        {
            double hmotnost;
            double výška;
            double BMI;


            Console.WriteLine("Zadejte hmotnost(kg)");
            Double.TryParse(Console.ReadLine(), out hmotnost);
            if (hmotnost <= 0)
            {
                Console.WriteLine();
                Console.WriteLine("Pouze kladná hodnota je povolena");
            }
            else
            {
                Console.WriteLine("Zadejte výšku(cm)");
                výška = double.Parse(Console.ReadLine());
                if (výška <= 0)
                {
                    Console.WriteLine("Pouze kladná hodnota je povolena");
                }
                else
                {
                    BMI = hmotnost / Math.Pow(výška / 100, 2);
                    BMI = Math.Round(BMI);

                    Console.WriteLine();
                    Console.WriteLine($"Vaše BMI je {BMI} ");
                }
            }
            Console.ReadLine();

        }

    }
}
