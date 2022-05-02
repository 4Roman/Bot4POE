using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
namespace Bot4POE
{
    public static class Screenshot
    {
        public static Bitmap MakeScreenshot()
        {            
            Rectangle bounds = Screen.GetBounds(Point.Empty);// получаем размеры окна рабочего стола            
            using (Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height))// создаем пустое изображения размером с экран устройства
            {
                using (var g = Graphics.FromImage(bitmap))// создаем объект на котором можно рисовать
                {
                    g.CopyFromScreen(Point.Empty, Point.Empty, bounds.Size);// перерисовываем экран на наш графический объект
                }
                bitmap.Save("screenshot_01.jpg", ImageFormat.Jpeg);// сохраняем в файл с форматом JPG
                return bitmap;                
            }
        }
        public static Bitmap Crop(Bitmap image)
        {
            Rectangle rectangle = new Rectangle(0,image.Height*3/4,image.Width/5,image.Height/4);
            Bitmap pic = new Bitmap(image);
            pic = pic.Clone(rectangle, PixelFormat.Format16bppRgb555);
            pic.Save("screenshot_02.jpg", ImageFormat.Jpeg);// сохраняем в файл с форматом JPG
            return pic;

        }
    }


}