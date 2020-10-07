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

        public void Feed(int hunger)
        {
            hunger -= 1;
        }
    }
}
