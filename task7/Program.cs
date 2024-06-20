using System;

namespace CurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Предположим, что курс обмена 1 USD = 0.85 EUR
            double exchangeRate = 0.85;

            Console.WriteLine("Введите сумму в USD для конвертации в EUR:");
            double usdAmount = Convert.ToDouble(Console.ReadLine());

            double eurAmount = usdAmount * exchangeRate;

            Console.WriteLine($"{usdAmount} USD равно {eurAmount} EUR");
        }
    }
}
