using System;
using System.Collections.Generic;
using System.Linq;

namespace linqOrderingOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            //ORDERING OPERATIONS

            // Order these student names alphabetically, in descending order (Z to A)
            List<string> names = new List<string>()
{
    "Heather", "James", "Xavier", "Michelle", "Brian", "Nina",
    "Kathleen", "Sophia", "Amir", "Douglas", "Zarley", "Beatrice",
    "Theodora", "William", "Svetlana", "Charisse", "Yolanda",
    "Gregorio", "Jean-Paul", "Evangelina", "Viktor", "Jacqueline",
    "Francisco", "Tre"
};

            List<string> descend = names;
            descend.Sort();
            descend.Reverse();

            Console.WriteLine();
            foreach (var name in descend)
            {
                Console.WriteLine(name);
            }


            // Build a collection of these numbers sorted in ascending order
            List<int> numbers = new List<int>()
{
    15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
};

            List<int> orderNumbers = numbers.OrderBy(num => num).ToList();
            Console.WriteLine();
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }



        }
    }
}
