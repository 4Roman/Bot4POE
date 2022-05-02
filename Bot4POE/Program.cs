using System;

namespace Bot4POE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bitmap test = (Bitmap)Screenshot.MakeScreenshot();
            Screenshot.Crop(test);
        }
    }
}