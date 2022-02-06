using System;
using System.Collections;

namespace Unlimited_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList myArray = new ArrayList();
            bool check = true;
            int sum = 0;
            while (check)
            {
                Console.Write("Number or Command? ");
                var inp =Console.ReadLine();
                if (inp == "sum")
                {
                    Console.WriteLine("Sum is: "+ sum);
                }
                else if (inp == "view")
                {
                    foreach (var item in myArray)
                    {
                        
                            Console.WriteLine("element: " + item);
                    }
                }
                else if (inp == "end")
                {
                    check = false;
                }
                else
                {
                    myArray.Add(inp);
                    sum += int.Parse(inp);
                }
            }


        }
    }
}
