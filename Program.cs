namespace c2f_f2c;


class Program
{
    static char menu() 
    {
        while (true) {
            Console.WriteLine("Меню:");
            Console.WriteLine("1 - перевести градусы Цельсия в градусы Фаренгейта");
            Console.WriteLine("2 - перевести градусы Фаренгейта в градусы Цельсия");
            Console.WriteLine("3 - выход из программы");
            Console.Write("Ваш выбор: ");
            string x = Console.ReadLine();
            if (x == "1" | x == "2" | x == "3") {
                return x[0];
            } else {
                Console.WriteLine("Введите 1, 2 или 3");
            }
        }
    }

    static void onC2F_chose()
    {
        double c = 0.0;
        while (true) {
            try {
                Console.Write("Введите градусы Цельсия: ");
                c = Single.Parse(Console.ReadLine());
                break;
            } catch (FormatException) {    
                Console.WriteLine("Вы ввели не число!");
            }
        }
        double f = Math.Round(c * 9 / 5 + 32, 1);
        Console.WriteLine("это {0} градусов Фаренгейта", f);        
    }

    static void onF2C_chose()
    {
        double f = 0.0;
        while (true) {
            try {
                Console.Write("Введите градусы Фаренгейта: ");
                f = Single.Parse(Console.ReadLine());
                break;
            } catch (FormatException) {    
                Console.WriteLine("Вы ввели не число!");
            }
        }
        double c = Math.Round((f - 32) * 5 / 9, 1);
        Console.WriteLine("это {0} градусов Цельсия", c);  
    }

    static void Main(string[] args)
    {
        while (true) {
            char chose = menu();
            if (chose == '3') {
                break;
            } else if (chose == '1') {
                onC2F_chose();
            } else if (chose == '2') {
                onF2C_chose();
            }
        }
    }
}
