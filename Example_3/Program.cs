using System;

namespace Example_3
{
    class Program
    {
        static void Main()
        {
            byte count = 0;   //количество генерируемых чисел
            string sCount;
            int n;          //случайное число;
            Console.WriteLine("Введите количество чисел");
            sCount = Console.ReadLine();
            Random rand = new Random();
            try
            {
                //преобразование строки sCount в целое чистло count
                count = System.Convert.ToByte(sCount);
            }
            catch (System.ArgumentNullException)    //если введена пустая строка
            {
                Console.WriteLine("Ошибка: пустая строка");
                count = 0;
            }
            catch (System.FormatException)          //если введено значение неверного типа
            {
                Console.WriteLine("Неправильный формат");
                count = 0;
            }
            catch (System.OverflowException)        //если значение входит в деапазон byte
            {
                Console.WriteLine("Ошибка: переполнение");
                count = 0;
            }
            if (count !=0)
            {
                for (int i=1; i<=count; i++)
                {
                    n = rand.Next(0, 10);  //генерируем число в от 0 до 10
                    Console.WriteLine("{0}-е число: {1}  ", i, n);
                }
            }
        }
    }
}
