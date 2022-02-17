using System;

namespace Example_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string secondname;
            string sAge;
            byte age;
            Console.WriteLine("Введите Имя");
            name = Console.ReadLine(); //считывание строки в пременную
            Console.Clear();
            Console.WriteLine("Введите Фамилию");
            secondname = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Возраст");
            sAge = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Здравствуйте, {0} {1} {2}! ", name,secondname,sAge);
            if (byte.TryParse(sAge, out age)) //если строку можно преобразовать в тип byte
            {
                if (age < 18)
                {
                    Console.WriteLine("Несовершеннолетний");
                }
                else
                    Console.WriteLine("Совершеннолетний");
            }
            else
                Console.WriteLine("Ошибка ввода");

            
        }
    }
}
