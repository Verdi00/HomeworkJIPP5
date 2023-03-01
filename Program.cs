using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;

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

            string a1 = "Ala ";
            string b1 = "ma ";
            string c1 = "kota";

            string result3 = a1 + b1 + c1;
            Console.WriteLine(result3);



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
            int counter1 = 0;

            while (counter1 < 10)
            {
                Console.WriteLine("C#");
                counter1++;
            }



            // Kolekcje
            // Zadanie 1

            string[] colors = new string[4] { "niebieski", "żółty", "zielony", "czerwony" };

            Console.WriteLine("Mój pierwszy kolor to: " + colors[0]);
            Console.WriteLine("Mój ostatni kolor to: " + colors[3]);

            // Zadanie 2

            int[] tab = new int[10] { 2423, 455233, 622554, 3626242, 84234, 32424, 123422, 7234256, 8235257, 12262363 };

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Liczba: " + tab[i]);
            }

            foreach (int i in tab)
            {
                Console.WriteLine("Liczba: " + i);
            }

            counter1 = 0;

            while (counter1 < 10)
            {
                Console.WriteLine("Liczba: " + tab[counter1]);
                counter1++;
            }

            // Zadanie 3

            List<string> fruits = new List<string>();
            fruits.Add("kiwi");
            fruits.Add("arbuz");
            fruits.Add("pomarańcza");
            fruits.Add("mandarynka");

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
            Console.WriteLine(" ");
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
