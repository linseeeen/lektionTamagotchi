using System.Net.Mime;
using System;

namespace lektionTamagotchi
{
    class Program
    {
        static void Main(string[] args)
        {
            Tamagotchi t1 = new Tamagotchi();
            t1.name = Name();
            while (t1.GetAlive() == true)
            {
                switch (WhatShouldIDo())
                {
                    case "1":
                        Console.WriteLine("Lär mig ett nytt ord! \nVilket ord vill du lära mig?");
                        t1.Teach(Console.ReadLine());
                        break;
                    case "2":
                        t1.Hi();
                        break;
                    case "3":
                        t1.Feed();
                        break;
                    case "4":
                        Console.WriteLine("Okej! Vi hittar på något en annan gång!");
                        break;
                }
                Console.ReadLine();
                t1.Tick();
                Console.Clear();
                t1.PrintStats();
                Console.ReadLine();
                Console.Clear();
            }
            Console.ReadLine();
        }
        static string Name()
        {
            Console.WriteLine("Hej! Jag är din Tamagotchi!\nVad vill du att jag ska heta? Skriv ett namn mellan 1-10 bokstäver!");
            Console.Write("Svar: ");
            string name = Console.ReadLine();
            while (name.Length > 10 || name.Length < 1)
            {
                Console.WriteLine("Skriv ett giltigt namn mellan 1-10 bokstäver.");
                name = Console.ReadLine();
            }
            Console.Clear();
                return name;
        }
        static string WhatShouldIDo()
        {
            string answer = "";
            Console.WriteLine("Vad vill du göra idag?\n1. Lära mig ett nytt ord\n2. Säga hej\n3. Mata mig\n4. Göra ingenting");
            Console.Write("Skriv siffran du önskar utföra: ");
            answer = Console.ReadLine();
            while (answer != "1" && answer != "2" && answer != "3" && answer != "4")
            {
                Console.WriteLine("Skriv ett giltigt värde!");
                answer = Console.ReadLine();
            }
            return answer;
        }
    }
}
