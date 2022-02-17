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
                Console.Clear();

            }
        }


    }
}
