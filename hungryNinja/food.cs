using System; 

namespace hungryNinja
{
    class Food
    {
        public string Name;
        public int Calories;
        public bool IsSpicy;
        public bool IsSweet;

        public Food(string n, int c, bool sp, bool sw)
        {
            this.Name = n;
            this.Calories = c;
            this.IsSpicy = sp;
            this.IsSweet = sw;
        }
    }
} 
