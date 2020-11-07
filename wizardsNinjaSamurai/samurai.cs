using System;
using System.Threading;

namespace wizardsNinjaSamurai
{
    public class Samurai : Human
    {
        private static int Count = 0;
        public Samurai(string name, ISecretWeapon weapon) :base(name, weapon)
        {
            Health = 200;
            Count += 1;
        }

        public static void HowMany() => Console.WriteLine("Samauris: " + Count);
    }
}