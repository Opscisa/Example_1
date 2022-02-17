using System;

namespace Example_4
{
    class Program
    {
        static void Main()
        {
            byte n = 31;                    //количество дней
            short[] tempJan = new short[n]; //массив со значениями температуры по дням
            Random rand = new Random();     //создание генератора чисел
            string outputString = "";       //выходная строка проинициализирована пустым значением
            byte coldDays = 0;
            for (byte  i = 0; i < n; i++)
            {
                //генерируем число от -10 до 10 и заносим в массив
                tempJan[i] = (short)rand.Next(-10, 10);

                //добавляем перенос строки для разделения недель
                if (i % 7 == 1) outputString = outputString + '\n';

                //выводим в строку значение температуры текущего дня
                outputString = outputString + String.Format(" {0,3}: {1,3}", i, tempJan[i]);
            }
            Console.WriteLine("Среднесуточные температуры января:" + coldDays);
            foreach (short tempDay in tempJan) //для каждого элемента массива проверяем
            {
                if (tempDay < 0)
                {
                    coldDays++;
                }
            }
            Console.WriteLine("\nТемпература опускалась ниже нуля {0} раз", coldDays);

        }
    }
}
