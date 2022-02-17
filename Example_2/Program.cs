using System;

namespace Example_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string textMenu, res = ""; //сообщение и ответ пользователя
            DateTime d;                //переменные типа дата-время
            //строковой переменной присваевается значение дословного литерала
            textMenu = @" Выберите действие:
             1 - Вывести дату;
             2 - Вывести текущее время;
             3 - выход из программы";
            d = DateTime.Now;          //записываем текущую дату и время в переменную
            while (res != "3")  //пока пользователь введёт "3"
            {
                Console.Clear();       //очистка экрана
                Console.WriteLine(textMenu);  //вывод текстового меню
                res = Console.ReadLine();     //считывание ответа пользователя

                switch (res)    //проверяем варианты ответа пользователя
                {
                    //если пользователь выбрал 1й пункт, выводим дату
                    case "1":
                        {
                            Console.WriteLine("Сегодня: {0}", d.ToShortDateString());
                            break;
                        }
                    //если пользователь выбрал 2й пункт, выводим время
                    case "2":
                        {
                            Console.WriteLine("Сейчас: {0}", d.ToShortTimeString());
                            break;
                        }
                    //если пользователь ввёл 3й пункт, выходим из программы
                    case "3":
                        {
                            Console.WriteLine("Выход из программы");
                            break;
                        }
                    //если пользователь ввел другое значение
                    default:
                        {
                            Console.WriteLine("Ошибка ввода");
                            break;
                        }
                }
                Console.ReadLine();
                 
                        

            }

        }


    }
}
