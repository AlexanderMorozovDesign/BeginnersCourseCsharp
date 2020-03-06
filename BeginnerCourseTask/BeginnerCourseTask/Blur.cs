using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;

namespace Blur
{
    class Blur
    {
        private static double LimitColorValue(double color)
        {
            if (color > 255)
            {
                return 255;
            }

            if (color < 0)
            {
                return 0;
            }

            return color;
        }

        private static Bitmap ApplyFilter(Bitmap sourceImage, double[,] matrix)
        {
            Bitmap resultBitmap = new Bitmap(sourceImage);

            int matrixWidth = matrix.GetLength(0);
            int offset = (matrixWidth - 1) / 2;

            for (int imageX = offset; imageX < sourceImage.Width - offset; imageX++)
            {
                for (int imageY = offset; imageY < sourceImage.Height - offset; imageY++)
                {
                    double blue = 0.0;
                    double green = 0.0;
                    double red = 0.0;

                    for (int x = -offset; x <= offset; x++)
                    {
                        for (int y = -offset; y <= offset; y++)
                        {
                            Color pixel = sourceImage.GetPixel(imageX + x, imageY + y);
                            red += pixel.R * matrix[x + offset, y + offset];
                            green += pixel.G * matrix[x + offset, y + offset];
                            blue += pixel.B * matrix[x + offset, y + offset];
                        }
                    }

                    blue = LimitColorValue(blue);
                    green = LimitColorValue(green);
                    red = LimitColorValue(red);

                    Color newColor = Color.FromArgb((int)red, (int)green, (int)blue);
                    resultBitmap.SetPixel(imageX, imageY, newColor);
                }
            }

            return resultBitmap;
        }

        static void Main(string[] args)
        {
            double[,] matrixOfTheeByThree = { {1/9.0, 1/9.0, 1/9.0},
                                            {  1/9.0, 1/9.0, 1/9.0},
                                            {  1/9.0, 1/9.0, 1/9.0}};

            double[,] matrixOfFiveByFive = { {1/25.0, 1/25.0, 1/25.0, 1/25.0, 1/25.0},
                                           {  1/25.0, 1/25.0, 1/25.0, 1/25.0, 1/25.0},
                                           {  1/25.0, 1/25.0, 1/25.0, 1/25.0, 1/25.0},
                                           {  1/25.0, 1/25.0, 1/25.0, 1/25.0, 1/25.0},
                                           {  1/25.0, 1/25.0, 1/25.0, 1/25.0, 1/25.0}};

            Console.WriteLine("Импорт картинки и начало обработки ");

            Bitmap sourceImage = new Bitmap("..\\..\\image.jpg");

            Bitmap resultBitmap3x3 = ApplyFilter(sourceImage, matrixOfTheeByThree);

            Bitmap resultBitmap5x5 = ApplyFilter(sourceImage, matrixOfFiveByFive);

            Console.WriteLine("Завершение обработки картинки и экспорт в файл");

            resultBitmap3x3.Save("..\\..\\out3x3.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
            resultBitmap5x5.Save("..\\..\\out5x5.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);

            Console.ReadKey();
        }
    }
}
