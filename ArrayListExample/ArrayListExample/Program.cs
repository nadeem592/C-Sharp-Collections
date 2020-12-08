using System;
using System.Collections;

namespace ArrayListExample
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList l = new ArrayList();
            Console.WriteLine("Enter the no.elements that you want: ");
            int num = Convert.ToInt32(Console.ReadLine());
            for(int i=0;i<num;i++)
            {
                Console.Write($"Enter element at {i} index: ");
                var t = Console.ReadLine();
                l.Add(t);
            }
            Console.WriteLine("Do you want to add some new elements.? ( Y / N)");
            string response = Console.ReadLine();
            if(response=="Y")
            {
                Console.WriteLine("At which index do you want to add element.?");
                int index = Convert.ToInt32(Console.ReadLine());
                if (num < index)
                {
                    Console.WriteLine($"Please enter index number not greater than {num}");
                    index = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("Enter the element: ");
                string extraElement = Console.ReadLine();
                l.Insert(index,extraElement);
                Console.WriteLine();
                Console.WriteLine("Your List contains follwing Elements: ");
                foreach (string str in l)
                    Console.WriteLine(str);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Your List contains the following elements: ");
                foreach (string str in l)
                    Console.WriteLine(str);
            }
            


        }
    }
}
