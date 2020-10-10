using System;

namespace lektionTamagotchi
{
    class Program
    {
        static void Main(string[] args)
        {
            Tamagotchi t1 = new Tamagotchi();
            t1.name = Name();
            Console.ReadLine();
        }
        static string Name()
        {
            string name = Console.ReadLine();
            while (name.Length > 10 && name.Length < 1)
            {
                Console.WriteLine("Skriv ett giltigt namn mellan 1-10 bokstäver.");
            }
                return name;
        }
    }
}
