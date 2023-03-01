using System;
using System.Collections.Generic; // Kolekcje - Zadanie 3

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pierwszy program - rozgrzewka
            // Zadanie 2

            Console.WriteLine("Podaj swoje imię:");
            var name = Console.ReadLine();
            Console.WriteLine("Hello " + name);

            // Zadanie 3

            int result1 = 5 + 9;

            // Operatory
            // Zadanie 1

            int number = 13;
            float money = 24.5F;
            string text = "to jest test";
            bool isLogged = true;
            char myChar = 'A';
            decimal price = 13.5M;

            Console.WriteLine(number);
            Console.WriteLine(money);
            Console.WriteLine(text);
            Console.WriteLine(isLogged);
            Console.WriteLine(myChar);
            Console.WriteLine(price);

            // Zadanie 2

            string myAge = "Age: ";
            int wifeAge = 18;
            string result2 = myAge + wifeAge.ToString();

            Console.WriteLine(result2);

            // Zadanie 3

            bool isTrue = true;
            bool isFalse = false;
            bool isReallyTrue = true;

            bool and = isTrue && isFalse;
            bool or = isTrue || isReallyTrue;
            bool negative = !isFalse;

            Console.WriteLine(and);
            Console.WriteLine(or);
            Console.WriteLine(negative);

            // Zadanie 4

            int a = 5;
            int b = 12;

            int add = a + b;
            int sub = a - b;
            int div = a / b;
            int mul = a * b;
            int mod = a % b;

            Console.WriteLine(add);
            Console.WriteLine(sub);
            Console.WriteLine(div);
            Console.WriteLine(mul);
            Console.WriteLine(mod);

            // Zadanie 5

            string aa = "Ala ";
            string bb = "ma ";
            string cc = "kota";

            string resultz = aa + bb + cc;
            Console.WriteLine(resultz);

            // Wniosek - zwracać uwagę na powtarzające się zmienne
            // Wniosek - zmienne typu string można ze sobą łączyć

            // Instrukcje sterujące i pętle
            // Zadanie 1

            int n1 = 10;
            int n2 = 20;

            if (n1 > n2)
            {
                Console.WriteLine("n1 jest większe od n2");
            }
            else if (n2 > n1)
            {
                Console.WriteLine("n2 jest większe od n1");
            }
            else
            {
                Console.WriteLine("n1 jest równe n2");
            }

            // Zadanie 2

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("C#");
            }

            int licznik = 0;

            while (licznik < 10)
            {
                Console.WriteLine("C#");
                licznik++;
            }

            // Zadanie 3

            int n = 10;

            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i.ToString() + " - Parzysta");
                }
                else
                {
                    Console.WriteLine(i.ToString() + " - Nieparzysta");
                }
            }

            // Zadanie 4*

            n = 5;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }

            // Zadanie 5*

            int exam = 69;

            if (exam >= 0 && exam <= 39)
            {
                Console.Write("Ocena Niedostateczna");
            }
            else if (exam >= 40 && exam <= 54)
            {
                Console.Write("Ocena Dopuszczająca");
            }
            else if (exam >= 55 && exam <= 69)
            {
                Console.Write("Ocena Dostateczna");
            }
            else if (exam >= 70 && exam <= 84)
            {
                Console.Write("Ocena Dobra");
            }
            else if (exam >= 85 && exam <= 98)
            {
                Console.Write("Ocena Bardzo Dobra");
            }
            else if (exam >= 99 && exam <= 100)
            {
                Console.Write("Ocena Celująca");
            }
            else
            {
                Console.Write("Wartość poza zakresem");
            }

            // Kolekcje
            // Zadanie 1

            string[] colors = new string[4] { "czarny", "biały", "niebieski", "czerwony" };

            Console.WriteLine("Mój pierwszy kolor to: " + colors[0]);
            Console.WriteLine("Mój ostatni kolor to: " + colors[3]);

            // Zadanie 2

            int[] tab = new int[10] { 23, 453, 654, 342, 8, 34, 12, 76, 87, 123 };

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Liczba: " + tab[i]);
            }

            foreach (int i in tab)
            {
                Console.WriteLine("Liczba: " + i);
            }

            licznik = 0;

            while (licznik < 10)
            {
                Console.WriteLine("Liczba: " + tab[licznik]);
                licznik++;
            }

            // Zadanie 3

            List<string> fruits = new List<string>();
            fruits.Add("banan");
            fruits.Add("papaja");
            fruits.Add("ananas");
            fruits.Add("kiwi");

            for (int i = 0; i < fruits.Count; i++)
            {
                if (i == fruits.Count - 1)
                {
                    Console.Write(fruits[i]);
                }
                else
                {
                    Console.Write(fruits[i] + ", ");
                }
            }

            fruits.Remove(fruits[0]);
            fruits.RemoveAt(fruits.Count - 1);

            for (int i = 0; i < fruits.Count; i++)
            {
                if (i == fruits.Count - 1)
                {
                    Console.Write(fruits[i]);
                }
                else
                {
                    Console.Write(fruits[i] + ", ");
                }
            }

        }
    }
}