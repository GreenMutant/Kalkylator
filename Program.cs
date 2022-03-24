﻿class program
{

    static void Menu()
    {
        Console.WriteLine("Välkommen till Kalkylatorn.\n");
        Console.WriteLine("Tryck (enter) för att starta\n");
        Console.WriteLine("(a) addition");
        Console.WriteLine("(s) subtraktion");
        Console.WriteLine("(m) multiplikation");
        Console.WriteLine("(d) division");
        Console.WriteLine("(e) elevition\n");
        Console.WriteLine("Tryck (q) för att avsluta.\n");
    }
    public static int Operation(int val)

    {
        string inmat;
        

        Console.WriteLine("Välj operation (a),(s),(m),(d),(e):");
        inmat = Console.ReadLine();

        if (inmat == "a")
            { val = 1; }

            if (inmat == "s")
            { val = 2; }

            if (inmat == "m")
            { val = 3; }

            if (inmat == "d")
            { val = 4; }

            if (inmat == "e")
            { val = 5; }

            return val;
    }

    public static double Addition(double tal1, double tal2)
    {
        double summa = tal1 + tal2;
        return summa;
    }

    public static double Subtraktion(double tal1, double tal2)
    {
        double summa = tal1 - tal2;
        return summa;
    }

    public static double Multiplikation(double tal1, double tal2)
    {
        double summa = tal1 * tal2;
        return summa;
    }

    public static double Division(double tal1, double tal2)
    {
        double summa = tal1 / tal2;
        return summa;
    }

    public static double Elevition(double tal1, double tal2)
    {
        double summa = Math.Pow(tal1, tal2);
     
        return summa;
    }

    static void Main(string[] args)
    {
        int menu = 0;
        bool quit = true;
        int action = 0;
        string inmat = "noll";
        

        if (menu == 0)
        {
            Menu();
            
        }

        do
        {
            if (menu == 1)
            {
                Menu();

            }


            inmat = Console.ReadLine();
            if (inmat == "q")
            {
                quit = false;
            }
            
            else
        {

                Console.WriteLine("Mata in ett tal:");

                double tal1 = Convert.ToDouble(Console.ReadLine());

                action = Operation(action);

                Console.WriteLine("Mata in ett tal:");
                double tal2 = Convert.ToDouble(Console.ReadLine());

                if ((action == 4) && (tal1 == 0) || (tal2 == 0))
                {
                    Console.WriteLine("Ogiltigt");
                    action = 0;
                }

                double summa = 0;

                switch (action)
            {
                case 1:
                    {
                        summa = Addition(tal1, tal2);
                        Console.WriteLine("\n" + tal1 + " + " + tal2 + " = " + summa);
                        break;
                    }
                case 2:
                    {
                        summa = Subtraktion(tal1, tal2);
                        Console.WriteLine("\n" + tal1 + " - " + tal2 + " = " + summa);
                        break;
                    }
                case 3:
                    {
                        summa = Multiplikation(tal1, tal2);
                        Console.WriteLine("\n" + tal1 + " * " + tal2 + " = " + summa);
                        break;
                    }
                case 4:
                    {
                        summa = Division(tal1, tal2);
                        Console.WriteLine("\n" + tal1 + " / " + tal2 + " = " + summa);
                        break;
                    }
                case 5:
                    {
                        summa = Elevition(tal1, tal2);
                        Console.WriteLine(tal1 + " ^ " + tal2 + " = " + summa);
                        break;
                    }
            }


            



            Console.WriteLine("\nTryck (enter) för ny operation. (q) för att avsluta.");

                ConsoleKeyInfo key = Console.ReadKey();

                if (key.Key.Equals(ConsoleKey.Enter))
                {
                    Console.Clear();
                    menu = 1;

                }
                if (key.Key.Equals(ConsoleKey.Q))
                {
                    quit = false;
                }
            }
        }
        while (quit == true);

        Environment.Exit(0);
    }
}

