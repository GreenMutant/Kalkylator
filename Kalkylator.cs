using System;
using System.IO;


namespace UppgiftAxel
{
    public class Character
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Strength { get; set; }
        public int Fortune { get; set; }
        public Character(string name, int health, int strength, int fortune)
        {
            Name = name;
            Health = health;
            Strength = strength;
            Fortune = fortune;
        }

    }
    class Uppgifter
    {
        static void Menu()
        {
            Console.WriteLine("1. Hello World");
            Console.WriteLine("2. Mata in namn");
            Console.WriteLine("3. Ändra färg");
            Console.WriteLine("4. Datum");
            Console.WriteLine("5. Jämför tal");
            Console.WriteLine("6. Gissa tal");
            Console.WriteLine("7. Skriv fil");
            Console.WriteLine("8. Ladda fil"); 
            Console.WriteLine("9. Decimaltal&kvadrat"); 
            Console.WriteLine("10. Multiplikation"); 
            Console.WriteLine("11. Array"); 
            Console.WriteLine("12. Palindrom");
            Console.WriteLine("13. Input&Output"); 
            Console.WriteLine("14. Udda&Jämnt"); //
            Console.WriteLine("15. Addition"); //
            Console.WriteLine("16. Instanser"); //
            Console.WriteLine("q. Avsluta"); 

            String input = Console.ReadLine();
            int val;
            Int32.TryParse(input, out val);
            Console.Clear();
            if (input == "q")
            {
                Environment.Exit(1);// avsluta
            }
            if (val == 1)
            {
                HelloWorld();
                Console.WriteLine("\nTryck Enter för att återgå till Menyn");
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key.Equals(ConsoleKey.Enter))
                {
                    Console.Clear();
                    Menu();
                }
                
            }
            if (val == 2)
            {
                WriteName();
                Console.WriteLine("\nTryck Enter för att återgå till Menyn");
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key.Equals(ConsoleKey.Enter))
                {
                    Console.Clear();
                    Menu();
                }
            }
            if (val == 3)
            {
                ChangeColor();
                Console.WriteLine("\nTryck Enter för att återgå till Menyn");
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key.Equals(ConsoleKey.Enter))
                {
                    Console.Clear();
                    Menu();
                }
            }
            if (val == 4)
            {
                WriteDate();
                Console.WriteLine("\nTryck Enter för att återgå till Menyn");
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key.Equals(ConsoleKey.Enter))
                {
                    Console.Clear();
                    Menu();
                }
            }
            if (val == 5)
            {
                CompareNumbers();
                Console.WriteLine("\nTryck Enter för att återgå till Menyn");
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key.Equals(ConsoleKey.Enter))
                {
                    Console.Clear();
                    Menu();
                }
            }
            if (val == 6)
            {
                GuessNumber();
                
            }
            if (val == 7)
            {
                WriteFile();
                Console.WriteLine("\nTryck Enter för att återgå till Menyn");
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key.Equals(ConsoleKey.Enter))
                {
                    Console.Clear();
                    Menu();
                }

            }

            if (val == 8)
            {
                ReadFile();
                Console.WriteLine("\nTryck Enter för att återgå till Menyn");
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key.Equals(ConsoleKey.Enter))
                {
                    Console.Clear();
                    Menu();
                }

            }
            if (val == 9)
            {
                DecimalKvadrat();
                Console.WriteLine("\nTryck Enter för att återgå till Menyn");
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key.Equals(ConsoleKey.Enter))
                {
                    Console.Clear();
                    Menu();
                }
            }
            if (val == 10)
            {
                MultiTabell();
                Console.WriteLine("\nTryck Enter för att återgå till Menyn");
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key.Equals(ConsoleKey.Enter))
                {
                    Console.Clear();
                    Menu();
                }
            }
            if (val == 11)
            {
                ArrSort();
                Console.WriteLine("\nTryck Enter för att återgå till Menyn");
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key.Equals(ConsoleKey.Enter))
                {
                    Console.Clear();
                    Menu();
                }
            }
            if (val == 12)
            {
                CheckDrome();
                

            }
            if (val == 13)
            {
                WriteBetween();
                Console.WriteLine("\nTryck Enter för att återgå till Menyn");
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key.Equals(ConsoleKey.Enter))
                {
                    Console.Clear();
                    Menu();
                }
            }
            if (val == 14)
            {
                OddEven();
                Console.WriteLine("\nTryck Enter för att återgå till Menyn");
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key.Equals(ConsoleKey.Enter))
                {
                    Console.Clear();
                    Menu();
                }
            }
            if (val == 15)
            {
                AddDigits();
                Console.WriteLine("\nTryck Enter för att återgå till Menyn");
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key.Equals(ConsoleKey.Enter))
                {
                    Console.Clear();
                    Menu();
                }
            }
            if (val == 16)
            {
                ClassInstances();
                Console.WriteLine("\nTryck Enter för att återgå till Menyn");
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key.Equals(ConsoleKey.Enter))
                {
                    Console.Clear();
                    Menu();
                }
            }
        }
        static void HelloWorld()
        {
            Console.WriteLine("Hello World!");
        }

        static void WriteName()
        {
            Console.WriteLine("Skriv förnamn:");
            string forNamn = Console.ReadLine();
            Console.WriteLine("Skriv efternamn:");
            string efterNamn = Console.ReadLine();
            Console.WriteLine("Skriv ålder:");
            string alder = Console.ReadLine();
            Console.WriteLine("\nNamn & ålder: " + forNamn + " " + efterNamn + " " + alder);
        }
        static void ChangeColor()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine("Press Enter");
            ConsoleKeyInfo key = Console.ReadKey();

            if (key.Key.Equals(ConsoleKey.Enter))
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Clear();
            }
        }
        static void WriteDate()
        {
            Console.WriteLine(DateTime.Now.ToString("yyyy/MM/dd"));
        }
        static void CompareNumbers()
        {

            Console.WriteLine("Mata in heltal 1:");
            string input1 = Console.ReadLine();
            Console.WriteLine("Mata in heltal 2:");
            string input2 = Console.ReadLine();
            int heltal1;
            int heltal2;
            Int32.TryParse(input1, out heltal1);
            Int32.TryParse(input2, out heltal2);
            if (heltal1 > heltal2)
            {
            Console.WriteLine(heltal1 + "är det största talet.");
            }
            else
            {
                Console.WriteLine(heltal2 + " är det största talet.");
            }

        }
        static void GuessNumber()
        {
            Random r = new Random();
            int rInt = r.Next(1, 100);
            int range = 100;
            int tal;
            String input;
            Console.WriteLine("Gissa ett tal mellan 1 och 100:");
            input = Console.ReadLine();
           
            Int32.TryParse(input, out tal);
            
            while (tal != rInt)
            {
                
                if (tal < rInt)
                {
                    Console.WriteLine("För lågt. Försök igen.");
                    input = Console.ReadLine();
                    Int32.TryParse(input, out tal);
                }
                else if (tal > rInt)
                {
                    Console.WriteLine("För högt. Försök igen.");
                    input = Console.ReadLine();
                    Int32.TryParse(input, out tal);
                }
                
                

            }
            if (tal == rInt)
            {
                Console.WriteLine("Du gissade rätt!");
                Console.WriteLine("\nTryck Enter för att återgå till Menyn");
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key.Equals(ConsoleKey.Enter))
                {
                    Console.Clear();
                    Menu();
                }
            }
            
        }
        static void WriteFile()
        {
            
            string rad;
            Console.WriteLine("Skriv en rad:");
            rad = Console.ReadLine();
            try
            {
                
                StreamWriter sw = new StreamWriter("TextRad.txt");
                sw.WriteLine(rad);
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Raden sparad på fil.");
            }
        }
        static void ReadFile()
        {
            int counter = 0;

              
            foreach (string line in System.IO.File.ReadLines("TextRad.txt"))
            {
                System.Console.WriteLine(line);
                counter++;
            }
            
            
           
        }

        static void DecimalKvadrat()
        {
            Console.Write("Skriv ett tal:");
            double tal = Convert.ToDouble(Console.ReadLine());
            double kvadrattio;

            if (tal > 0)
            {
                double rot = tal / 3;
                int i;
                for (i = 0; i < 32; i++)
                    rot = (rot + tal / rot) / 2;
                Console.WriteLine("Kvadratrot:{0}", rot);
                
            }
            else
            {
                Console.WriteLine(Double.NaN);
            }
            double kvadrat = tal * tal;
            Console.WriteLine("Kvadrat:{0}", kvadrat);

            double tiokvadrat = Math.Pow(tal, 11);
            Console.WriteLine("Kvadrat upphöjt till 10:{0}", tiokvadrat);
        }

        static void MultiTabell()
        {
            
           
            int center = 1;
            int[] arrayLeft = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] arrayRight = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


            if (center < 51)
            {
                
                int i = 5;

                for (i = 0; i < 10; i++)
                {
                    Console.WriteLine(arrayLeft[0] + " * " + center + " = " + arrayRight[0] + "\t" +
                    arrayLeft[1] + " * " + center + " = " + arrayRight[1] + "\t" +
                    arrayLeft[2] + " * " + center + " = " + arrayRight[2] + "\t" +
                    arrayLeft[3] + " * " + center + " = " + arrayRight[3] + "\t" +
                    arrayLeft[4] + " * " + center + " = " + arrayRight[4]);

                    center = center + 1;

                    arrayRight[0] = arrayRight[0] + 1;
                    arrayRight[1] = arrayRight[1] + 2;
                    arrayRight[2] = arrayRight[2] + 3;
                    arrayRight[3] = arrayRight[3] + 4;
                    arrayRight[4] = arrayRight[4] + 5;  
                }

                Console.WriteLine("\t");
                center = 0;

                for (i = 0; i < 10; i++)
                {
                    center = center + 1;

                    Console.WriteLine(arrayLeft[5] + " * " + center + " = " + arrayRight[5] + "\t" +
                    arrayLeft[6] + " * " + center + " = " + arrayRight[6] + "\t" +
                    arrayLeft[7] + " * " + center + " = " + arrayRight[7] + "\t" +
                    arrayLeft[8] + " * " + center + " = " + arrayRight[8] + "\t" +
                    arrayLeft[9] + " * " + center + " = " + arrayRight[9]);

                    arrayRight[5] = arrayRight[5] + 6;
                    arrayRight[6] = arrayRight[6] + 7;
                    arrayRight[7] = arrayRight[7] + 8;
                    arrayRight[8] = arrayRight[8] + 9;
                    arrayRight[9] = arrayRight[9] + 10;
                }

            }
            
            

            
        }

        static void ArrSort()
        {
            int[] randomArr = new int[5];
            int[] sortedArr = new int[5];

            int i = 0;

            for (i = 0; i < 5; i++)
            {
                Random r = new Random();
                int rInt = r.Next(1, 100);
                int range = 100;
                randomArr[i] = rInt;
            }

            Console.WriteLine("\nArray osorterad: ");
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine(randomArr[i] + " ");
            }

            for (i = 0; i < 5; i++)
            {
                for (int j = i + 1; j < 5; j++)
                {
                    if (randomArr[i] > randomArr[j])
                    {      
                        int temp = 0;
                        temp = randomArr[i];
                        randomArr[i] = randomArr[j];
                        randomArr[j] = temp;
                    }
                }
            }
            
                
            Console.WriteLine("\nArray sorterad: ");
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine(randomArr[i] + " ");
            }

        }
            static void CheckDrome()
            {
                Console.WriteLine("Skriv ett ord:");
                string ord = Console.ReadLine();
                string value = "";
                int length = ord.Length;

                for (int i = 0; i < length / 2; i++)
                {
                    if (ord[i] != ord[length - i - 1])

                    value = " inte";
                }

            Console.WriteLine("Är" + value + " ett Palindrom");
            Console.WriteLine("\nTryck Enter för att återgå till Menyn");

            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key.Equals(ConsoleKey.Enter))
            {
                Console.Clear();
                Menu();
            }




        }

        static void WriteBetween()
        {
            
            int tal1;
            int tal2;
            String input;
            Console.WriteLine("Mata in ett heltal mellan 1 och 100:");
            input = Console.ReadLine();

            Int32.TryParse(input, out tal1);

            Console.WriteLine("Mata in ett till heltal mellan 1 och 100:");
            input = Console.ReadLine();

            Int32.TryParse(input, out tal2);

            if (tal1 == tal2)
                {
                Console.WriteLine("Det finns inga nummer mellan " + tal1 + " och " + tal2);
            }
            if (tal1 > tal2)
            {
                int i;
                int mellan = tal1 - tal2;
                for (i = 0; i < (mellan - 1); i++)

                { Console.WriteLine("\n" + (tal1 - i - 1)); }
            }
            if (tal1 < tal2)
            {
                int i;
                int mellan = tal2 - tal1;
                for (i = 0; i < (mellan - 1); i++)

                { Console.WriteLine("\n" + (tal2 - i - 1)); }
            }




        }
        static void OddEven()
        {

            string str1;
            string str2 = string.Empty;
            

            Console.WriteLine("Mata in kommaseparerade siffror (max 10 siffror) mellan 1 och 9:");
            str1 = Console.ReadLine();

            int val = 0;
            
            for (int i = 0; i < str1.Length; i++)
            {
                if (Char.IsDigit(str1[i]))
                    str2 += str1[i];
                
               
            }
            if (str2.Length > 0)
                val = int.Parse(str2);
            
            


            var digits = new List<int>();
            
            while (val > 0)
            {
                digits.Add(val % 10);
                val /= 10;
            }

            digits.Reverse();

            Console.WriteLine("\nJämna: ");
            for (int i = 0; i < str2.Length; i++)
            {
                if (digits[i] % 2 == 0)
                Console.WriteLine(digits[i]);
            }
            Console.WriteLine("\nOjämna: ");
            for (int i = 0; i < str2.Length; i++)
            {
                if (digits[i] % 2 != 0)
                    Console.WriteLine(digits[i]);
            }




        }

        static void AddDigits()
        {
            string str1;
            string str2 = string.Empty;


            Console.WriteLine("Mata in kommaseparerade siffror (max 10 siffror) mellan 1 och 9:");
            str1 = Console.ReadLine();

            int val = 0;

            for (int i = 0; i < str1.Length; i++)
            {
                if (Char.IsDigit(str1[i]))
                    str2 += str1[i];
            }
            if (str2.Length > 0)
                val = int.Parse(str2);

            var digits = new List<int>();

            while (val > 0)
            {
                digits.Add(val % 10);
                val /= 10;
            }

            digits.Reverse();

            int summa = 0;
            for (int i = 0; i < str2.Length; i++)
            {  
                summa = digits[i] + summa;
            }

            Console.WriteLine("\nsumman är: " + summa);
        }

        static void ClassInstances()
        {
            string namn1 = "namn1";
            string namn2 = "namn2";
            int[] values = new int[3];

            Console.WriteLine("Skriv in namnet på karaktär 1:");
            namn1 = Console.ReadLine();

            int i = 0;

            for (i = 0; i < 3; i++)
            {
                Random r = new Random();
                int rInt = r.Next(1, 100);
                int range = 100;
                values[i] = rInt;
            }

            Character person1 = new Character(namn1, values[0], values[1], values[2]);

            Console.WriteLine("Skriv in namnet på karaktär 2:");
            namn2 = Console.ReadLine();

            i = 0;

            for (i = 0; i < 3; i++)
            {
                Random r = new Random();
                int rInt = r.Next(1, 100);
                int range = 100;
                values[i] = rInt;
            }

            Character person2 = new Character(namn1, values[0], values[1], values[2]);

            Console.WriteLine("person1 Namn = {0} Hälsa = {1} Styrka = {2} Tur = {3}", person1.Name, person1.Health, person1.Strength, person1.Fortune);
            Console.WriteLine("person2 Namn = {0} Hälsa = {1} Styrka = {2} Tur = {3}", person2.Name, person2.Health, person2.Strength, person2.Fortune);

           

            
        }
        static void Main(string[] args)
        {
            Menu();

        }
    }
}