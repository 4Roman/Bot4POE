using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace Bot4POE
{
    public static class Screenshots
    {
        /// <summary>
        /// Разрешение монитора
        /// </summary>
        public static Rectangle Bounds = Screen.GetBounds(Point.Empty);

        /// <summary>
        /// Делает скришот (для любого разрешения из поля Bounds)
        /// </summary>
        public static Bitmap MakeScreenshot()
        {
            Bitmap bitmap = new Bitmap(Bounds.Width, Bounds.Height);
            using (var g = Graphics.FromImage(bitmap))// создаем объект на котором можно рисовать
            {
                g.CopyFromScreen(Point.Empty, Point.Empty, Bounds.Size);// перерисовываем экран на наш графический объект
                ;
            }
            bitmap.Save("screenshot_01.jpg", ImageFormat.Jpeg);// сохраняем в файл с форматом JPG
            return bitmap;
        }

        /// <summary>
        /// Обрезает скриншот по тексту здоровья (для 1920x1080) и сохраняет в папке с проектом
        /// </summary>
        public static Bitmap Crop(Bitmap image, Rectangle rectangle)
        {           
            Bitmap pic = new Bitmap(image);
            pic = pic.Clone(rectangle, PixelFormat.Format16bppRgb555);
            pic.Save("screenshot_02.jpg", ImageFormat.Jpeg);// сохраняем в файл с форматом JPG
            return pic;
        }
        

        private static Rectangle LifeString = new Rectangle(0, Bounds.Height * 3 / 4, Bounds.Width / 5, Bounds.Height / 4);
        //private static Rectangle LifeBar = new Rectangle(0, Bounds.Height * 3 / 4, Bounds.Width / 5, Bounds.Height / 4);
        //private static Rectangle ManaString = new Rectangle(0, Bounds.Height * 3 / 4, Bounds.Width / 5, Bounds.Height / 4);
        //private static Rectangle ManaBar = new Rectangle(0, Bounds.Height * 3 / 4, Bounds.Width / 5, Bounds.Height / 4);


    }


}