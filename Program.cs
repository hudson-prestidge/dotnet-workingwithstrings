using System;
using System.Text;

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
            // string myStr = String.Format("{0:(###) ###-####}", 1234567890);

            string myStr = " that summer we took threes across the board ";
            // myStr = myStr.Substring(0,13).Replace(" ", "--").Remove(6, 2);

            myStr = String.Format("length before: {0} - length after: {1}",
            myStr.Length, myStr.Trim().Length);

            // strings are immutable!
            // method names all start with uppercase!
            // don't forget semicolons!

            StringBuilder myString = new StringBuilder();

            for (int i = 0; i < 50; i++){
                myString.Append(i);
                myString.Append("--");
            }
            Console.WriteLine(myStr);
            Console.WriteLine(myString);
            Console.ReadLine();
        }
    }
}
