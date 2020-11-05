using System;

namespace collectionPractice
{
class Program
    {
        static void Main(string[] args)
        {
            // THREE BASIC ARRAYS
            // Create an array to hold integer values 0 through 9
            int[] array1 = new int[10];
            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = i;
            }
            // or
            int[] array2 = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
            
            // Create an array of the names "Tim", "Martin", "Nikki", & "Sara"
            string[] names = {"Tim", "Martin", "Nikki", "Sara"};

            // Create an array of length 10 that alternates between true and false values, starting with true
            bool[] booleanArr = new bool[10];
            for (int i = 0; i < booleanArr.Length; i++)
            {
                if (i % 2 == 0)
                {
                    booleanArr[i] = true;
                }
                else
                {
                    booleanArr[i] = false;
                }
            }

            // LIST OF FLAVORS
            // Create a list of Ice Cream flavors that holds at least 5 different flavors (feel free to add more than 5!)
            string[] flavors = {"Vanilla", "Butter Pecan", "Strawberry", "Chocolate", "Birthday Cake"};
            List<string> flavorsList = new List<string>();
            for (var i = 0; i < flavors.Length; i++)
            {
                flavorsList.Add(flavors[i]);
            }

            // Output the length of this list after building it
            Console.WriteLine("The length of our Ice Cream flavorsList is {0}", flavorsList.Count);

            // Output the third flavor in the list, then remove this value.
            Console.WriteLine("The 3rd flavor in this list is {0}.", flavorsList[2]);
            flavorsList.RemoveAt(2);
            Console.WriteLine("Now we have removed the 3rd element. The new 3rd element in the flavorsList is {0}.", flavorsList[2]);

            // Output the new length of the list (Note it should just be one less~)
            Console.WriteLine("The new length of the list is now " + flavorsList.Count + ".");
            // USER INFO DICTIONARY
            Dictionary<string,string> nameKeys = new Dictionary<string, string>();
            foreach (var name in names)
            {
                nameKeys.Add(name, null);
            }
            Random rand = new Random();
            foreach (var name in names)
            {
                int randInx = rand.Next(flavors.Count - 1);
                nameKeys[name] = flavors[randInx];
                flavors.RemoveAt(randInx);
            }

            foreach (var entry in nameKeys)
            {
                Console.WriteLine("{0}'s favorite flavor is {1}", entry.Key, entry.Value);
            }
        }
    }
}