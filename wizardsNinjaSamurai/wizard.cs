using System;

namespace wizardsNinjaSamurai
{
    public class Wizard : Human
    {
        public Wizard(string name, ISecretWeapon weapon) :base(name, weapon)
        {
            Health = 50;
            Intelligence = 25;
        }
    }
}