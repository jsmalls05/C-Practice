using System;

namespace hungryNinja 
{
class Program
    {
        static void Main(string[] args)
        {   
            Buffet Gege = new Buffet();
            Ninja Eddie = new Ninja(2200);
            while(!Eddie.IsFull)
            {
                Eddie.Eat(Gege.Serve());
            }
            Eddie.Eat(Gege.Serve());
        }
    }
}
