using System;
using System.Globalization;


namespace Deliverable_one
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter the first dollar amount: ");
            String val1;
            val1 = Console.ReadLine();

            Console.WriteLine("Please enter the second dollar amount: ");
            String val2;
            val2 = Console.ReadLine();

            Console.WriteLine("Please enter the thrid dollar amount: ");
            String val3;
            val3 = Console.ReadLine();

            Int32 a = Convert.ToInt32(val1);
            Int32 b = Convert.ToInt32(val2);
            Int32 c = Convert.ToInt32(val3);

            Int32 sum = a + b + c;
            Int32 average = sum / 3;

            int[] arr = new int[] { a, b, c };
            Array.Sort(arr);

            Console.WriteLine("The average is {0}", average);
            Console.WriteLine("The smallest value is {0} ", arr[0]);
            Console.WriteLine("The largest value is {0}", arr[2]);

            Console.WriteLine("US:{0}", sum.ToString("C"));
            Console.WriteLine("Swedish: {0}", (sum * 9.48).ToString("C", new CultureInfo("sv-SE")));
            Console.WriteLine("Japanese:{0}", (sum * 108.67).ToString("C", new CultureInfo("ja-JP")));
            Console.WriteLine("Thai:{0}", (sum * 31.24).ToString("C", new CultureInfo("th-TH")));
        

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();

        }
    }
}
