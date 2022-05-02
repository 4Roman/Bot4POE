using System;

namespace Bot4POE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bitmap test = (Bitmap)Screenshot.MakeScreenshot().Clone(); 
            Console.WriteLine(test.Width);
            Console.WriteLine(test.Height);
        }
    }
}