using System;

namespace Example_7
{
    class Program
    {
        static byte n = 30;     //максимальное количество пользователей
        static short count = 0; //текущее количество пользователей
        static string[] userList = new string[n];  //список пользователей
    }
    static bool searchUser(string name)
    {
        foreach (string userName in userList)
        {
            if (userName == name)  //если имя текущего пользователя равно искомому
            {
                return true; //функция возвращает результат истина - 
                             //пользователь найден, функция завершается
            }
        }
        return false;        //иначе возвращает результат ложь - совпадений не найдено
    }
    static void addUser()
    {
        if (count < n)       //если текущее количество элементов в массиве меньше максимального
        {
            Console.WriteLine("Введите имя пользователя");
            string userName = Console.ReadLine();  //считываем имя
                                                   //если имя не найдено в списке - функция поиска вернула результат false
            if (!searchUser(userName))
            {
                userList[count] = userName;        //вносим изменений в массив
                count++;                           //увеличиваем количество элементов
                Console.WriteLine("Пользователь добавлен");
            }
            else Console.WriteLine("Пользователь с таким именем уже существует");
        }
        else Console.WriteLine("Превышено допустимое количество пользователей");
        return;
    }
    static void viewList()
    {
        Console.WriteLine("Список польщователей");
        if (count > 0)
        {
            foreach (string userName in userList)
            {
                if (userName != null)             //вывод текста меню
                {
                    Console.WriteLine(userName);
                }
            }
        }
        else Console.WriteLine("Нет записей!");
        return;
    }
    static void Main(string[] args)
    {
        string menu = "Выберите действие: \n1 - добавить пользователя;\n2 - вывести  список пользователей;\n3 - выход";
        string inputString = "";
        do
        {
            Console.Clear();
            Console.WriteLine(menu);            //вывод текста меню
            inputString = Console.ReadLine();   //считывание выбранного пункта меню
            Console.Clear();

            switch (inputString)                //проверяем выбор
            {
                case "1": { addUser(); break; } //вызов функции добавления пользователя
                case "2": { viewList(); break; } //вызов функции просмотра списка
                case "3": { Console.WriteLine("Работа программы завершена"); break; }
            }
            Console.ReadLine();
        }
        while (inputString != "3");
    }
}
