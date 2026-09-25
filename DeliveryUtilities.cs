using System;
using System.Collections.Generic;
using System.Text;

namespace Assigment.Net.OOP5
{
    public static class DeliveryUtilities
    {
        public static void PrintSeparator()
        {
            Console.WriteLine("==========================================");
        }

        public static void PrintSystemTitle(string title)
        {
            PrintSeparator();
            Console.WriteLine(title);
            PrintSeparator();
        }
    }
}
