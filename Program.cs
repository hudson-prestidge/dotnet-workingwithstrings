using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // string myStr = "My so called \"Life\"\n\n\n hmm";
            // string myStr = "go to your c:\\ drive";
            // string myStr = @"go to your c:\ drive";
            // string myStr = String.Format("{0} = {0} != {1}", "first", "second");
            // string myStr = String.Format("{0:C}", 123.45);
            // string myStr = String.Format("{0:N}", 1234567890);
            // string myStr = String.Format("{0:P}", .123 );
            string myStr = String.Format("{0:(###) ###-####}", 1234567890);
            Console.WriteLine(myStr);
            Console.ReadLine();
        }
    }
}
