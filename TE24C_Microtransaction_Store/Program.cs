// lite metod bara
kräkhén();

static void kräkhén()
{
    int peng = 100;
    int yxkostnad = 75;
    int blomkostnad = 5;
    int limpkostnad = 15;
    string x;

    Console.WriteLine("vad heter du");
    string namn = Console.ReadLine();


    Console.WriteLine($"välkommen {namn} this is a store, you have {peng} pengar");

    Console.WriteLine($"En yxa kostar {yxkostnad} peng");

    Console.WriteLine($"En blomma kostar {blomkostnad} peng");

    Console.WriteLine($"En Brödlimpa kostar {limpkostnad} peng");

    Console.WriteLine("Vad vill du köpa?");
    while (peng > 0)
    {
        x = Console.ReadLine();
        if (x == "yxa" || x == "blomma")
        {
            Console.WriteLine("okej");
        }

        else if (x == "");
    }
    Console.ReadLine();
}