namespace _0911
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> Data = new Dictionary<string, string>();

            string a;
            do
            {

                Console.WriteLine("1. Добавить логин,пароль");
                Console.WriteLine("2. Удалить логин");
                Console.WriteLine("3. Изменение данных");
                Console.WriteLine("4. Показать пароль(надо ввести логин)");
                Console.WriteLine("5. Показать все записи");

                a = Console.ReadLine();
                switch (a)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Добавить логин,пароль");
                        Console.WriteLine("Введите логин -> ");
                        string log = Console.ReadLine();
                        Console.WriteLine("Введите пароль");
                        string pass = Console.ReadLine();
                        Data.Add(log, pass);
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("Удалить логин");
                        Console.WriteLine("Введите логин для удаления -> ");
                        string log1 = Console.ReadLine();
                        foreach (var a1 in Data.Keys) { 
                            if (a1 == log1)
                            {
                                Data.Remove(a1);
                            } 
                        }
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("Изменение данных");
                        Console.WriteLine("Изменить логин -11");
                        Console.WriteLine("Изменить пароль -22");
                        string f;
                        f = Console.ReadLine();
                        switch (f)
                        {
                            case "11":
                                Console.Clear();
                                Console.WriteLine("Введите логин для изменения -> ");
                                string log2 = Console.ReadLine();
                                Console.WriteLine("Введите  новый логин -> ");
                                string log22 = Console.ReadLine();
                                foreach (var a2 in Data.Keys)
                                {
                                    if (a2 == log2)
                                    {
                                        Data.Add(log22, Data[a2]);
                                        Data.Remove(a2);
                                    }
                                }
                                break;
                            case "22":
                                Console.Clear();
                                Console.WriteLine("Введите логин для изменения -> ");
                                string log24 = Console.ReadLine();
                                Console.WriteLine("Введите  новый пароль -> ");
                                string pass2 = Console.ReadLine();
                                foreach (var a2 in Data.Keys)
                                {
                                    if (a2 == log24)
                                    {
                                        Data[a2]=pass2 ;
                                    }
                                }
                                break;
                        }
                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine("Показать пароль(надо ввести логин)");
                        Console.WriteLine("Введите логин для поиска -> ");
                        string log3 = Console.ReadLine();
                        foreach (var a3 in Data.Keys)
                        {
                            if (a3 == log3)
                            {
                                Console.WriteLine(Data[log3]);
                            }
                        }

                        break;
                    case "5":
                        Console.Clear();
                        Console.WriteLine("Показать все записи");

                        foreach (var t in Data.Keys)
                        {
                            Console.WriteLine(t + ": " + Data[t]);
                        }
                        break;
                    case "6":
                        Console.Clear();
                        Console.WriteLine("Exit");
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Нет таког пункта!!!");
                        break;
                }
            } while (a != "6");
        }
    }
}
