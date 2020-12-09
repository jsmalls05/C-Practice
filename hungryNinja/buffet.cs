using System;
using System.Collections.Generic;

namespace hungryNinja
{
    class Buffet
    {
        public List<Food> Menu;
        public static Random rand = new Random();
        
        //constructor
        public Buffet()
        {
            Menu = new List<Food>()
            {
                new Food("Steak & Loaded Baked Potato", 850, false, false), 
                new Food("Pizza Slice(Meat Lovers)", 300, true, false),
                new Food("Rice & Spicy Beans", 700, true, false),
                new Food("General Tso Chicken", 1200, true, true),
                new Food("Browine & Ice Cream", 600, false, true),
                new Food("Dragon Roll w/Spicy Mayo", 500, true, false),
                new Food("Burger & Fries", 900, false, false),
                new Food("Chocolate Chip Cookie", 80, false, true),
            };
        }
        
        public Food Serve()
        {
            return Menu[rand.Next(Menu.Count)];
        }
    }

}
