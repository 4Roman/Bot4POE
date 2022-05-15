using System;
using System.Drawing.Imaging;
using Utilities;


namespace Bot4POE
{
    internal class Program
    {
        [STAThread]
        static void Main()
        {
            var kh = new KeyboardHook(true);
            kh.KeyDown += Kh_KeyDown;
            Application.Run();            
        }

        private static void Kh_KeyDown(Keys key, bool Shift, bool Ctrl, bool Alt)
        {
            Console.WriteLine("The Key: " + key);
        }

    }

}