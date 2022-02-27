using System;

namespace Zadanie_11
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, c = 0;
            string pair;
            Console.WriteLine("Укажите конвертируемую валюту(USD, EUR, RUB):");
            pair = Console.ReadLine();
            Console.WriteLine("Укажите сумму конвертируемой валюты:");
            a = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Укажите получаемую валюту(USD, EUR, RUB):");
            pair = pair + «/»+ Console.ReadLine();
            switch (pair)
                {
                case "USD / RUB": c = 75f; break;
                case "EUR / RUB": c = 85f; break;
                case "EUR / USD": c = 1.1f; break;
                default: c = 0; break;
            }
            Console.WriteLine("Суумма после конвертации { pair}: { a* c}");
        }
    }
}
