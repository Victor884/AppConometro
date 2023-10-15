using System;
using System.Threading;

public class Program
{
    private static void Main(string[] args)
    {
        menu();
    }

    static void menu()
    {
        Console.WriteLine("S = Segundo => 10s = 10 segundos");
        Console.WriteLine("M = Minuto => 1m = 1 minuto");
        Console.WriteLine("0 = Sair");
        Console.WriteLine("Quanto tempo deseja contar");

        string data = Console.ReadLine().ToLower();

        if (data == "0")
        {
            System.Environment.Exit(0);
        }

        char type;
        int time;
        if (data.EndsWith("s") || data.EndsWith("m"))
        {
            type = data[data.Length - 1];
            if (int.TryParse(data.Substring(0, data.Length - 1), out time))
            {
                int multiplier = 1;
                if (type == 'm')
                    multiplier = 60;

                PreStart(time * multiplier);
            }
            else
            {
                Console.WriteLine("Entrada inválida. Tente novamente.");
                menu();
            }
        }
        else
        {
            Console.WriteLine("Entrada inválida. Tente novamente.");
            menu();
        }
    }

    static void PreStart(int time)
    {
        Console.Clear();
        Console.WriteLine("preparar...");
        Thread.Sleep(1000);
        Console.WriteLine("apontando...");
        Thread.Sleep(1000);
        Console.WriteLine("já...");
        Thread.Sleep(2500);

        Start(time);
    }

    static void Start(int time)
    {
        int currentTime = 0;

        while (currentTime != time)
        {
            Console.Clear();
            currentTime++;
            Console.WriteLine(currentTime);
            Thread.Sleep(1000);
        }

        Console.Clear();
        Console.WriteLine("cronômetro foi finalizado");
        Thread.Sleep(2500);
        menu();
    }
}
