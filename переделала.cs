class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Выберите действие:");
        Console.WriteLine("1. угадай число");
        Console.WriteLine("2. таблица умножения");
        Console.WriteLine("3. вывести делитель числа");
        ;
        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine("Вы выбрали 'угадай число'");

                Console.WriteLine("\"Угадай число\"");
                Console.WriteLine("Угадай число (от 0 до 50)");
                Random random = new Random();
                int ZagChislo = random.Next(0, 50);
                Console.WriteLine(ZagChislo);
                int n = 0;
                while (true)
                {
                    Console.Write("Ваше число: ");
                    string stroka = Console.ReadLine();

                    while (!int.TryParse(stroka, out n))
                    {
                        Console.WriteLine("\nЭто не число");
                        Console.WriteLine("Повторите");
                        stroka = Console.ReadLine();
                    }
                    if (n != ZagChislo)
                    {
                        Console.WriteLine("Неа, попробуй ещё раз"); //stashko
                        if (n > ZagChislo)
                        {
                            Console.WriteLine("Нужно число поменьше\n");
                        }
                        else
                        {
                            Console.WriteLine("Нужно число побольше\n");
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nДа,ты угадал число");
                        break;
                    }
                }
                Console.ReadKey();
                break;
            case 2:
                Console.WriteLine("Вы выбрали 'таблица умножения'.");

                Console.WriteLine("Multiplication Table");
                Console.WriteLine("================в====");

                int size = 10;

                Console.Write("   |");
                for (int i = 1; i <= size; i++)
                {
                    Console.Write("{0,4}", i);
                }
                Console.WriteLine();
                Console.WriteLine("----" + new string('-', size * 4));

                for (int i = 1; i <= size; i++)
                {
                    Console.Write("{0,3}|", i);
                    for (int j = 1; j <= size; j++) //stashko
                    {
                        Console.Write("{0,4}", i * j);
                    }
                    Console.WriteLine();
                }

                Console.ReadLine();

                break;
            case 3:
                Console.WriteLine("Вы выбрали 'вывести делитель числа'.");

                Console.Write("введи число: ");
                int number = int.Parse(Console.ReadLine());

                Console.WriteLine("делители от {0}:", number); //stshk

                for (int i = 1; i <= number; i++)
                {
                    if (number % i == 0)
                    {
                        Console.WriteLine(i);
                    }
                }

                Console.ReadLine();


                break;
            default:
                Console.WriteLine("Неверное действие.");
                break;
        }

        Console.ReadLine();
    }
}


