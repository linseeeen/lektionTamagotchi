using System.Collections.Generic;
using System;

namespace lektionTamagotchi
{
    public class Tamagotchi
    {
        private Random generator = new Random();
        private int hunger = 0;
        private int boredom = 0;
        private List<string> words = new List<string>();    
        private bool isAlive = true;
        public string name = "";

        public void Feed()
        {
            Console.WriteLine("NOMNOMNOM!!");
            this.hunger -= 1;
        }
        private void ReduceBoredome()
        {
            this.boredom -= 1;
        }
        public void Hi()
        {
            Console.WriteLine("Hej! Kolla vad jag kan säga!");
            int number = generator.Next(this.words.Count);
            if (words.Count < 1)
            {
                Console.WriteLine("Jag kan inga ord än!");
            }
            else
            {
                Console.WriteLine(this.words[number]);
            }
            ReduceBoredome();
        }
        public void Teach(string word)
        {
            this.words.Add(word);
            ReduceBoredome();
        }
        public void Tick()
        {
            this.hunger += 1;
            this.boredom += 1;
            if (this.hunger > 10|| this.boredom > 10)
            {
                this.isAlive = false;
            }
        }
        public void PrintStats()
        {
            Console.WriteLine(name + " har " + this.hunger + " hunger.");
            Console.WriteLine(name + " är " + this.boredom + " uttråkad.");
            if (GetAlive() == true)
            {
                Console.WriteLine(name + " lever.");
            }
            else
            {
                Console.WriteLine(name + " är död.");
            }
        }
        public bool GetAlive()
        {
            return(this.isAlive);
        }
    }
}
