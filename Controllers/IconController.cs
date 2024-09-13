﻿using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherNotification.Controllers
{
    public static class IconController
    {
        public static Color BackgroundColor { get; set; } = Color.Black;
        public static Color ForegroundColor { get; set; } = Color.White;

        public static Icon GenerateIcon(string text)
        {
            Font imageFont = new("Saens Serif", 32, FontStyle.Bold,GraphicsUnit.Point);
            Bitmap bitmap = DrawText(text, imageFont);
            return Icon.FromHandle(bitmap.GetHicon());

        }

        private static Bitmap DrawText(string text, Font imageFont)
        {
            
            Size fontSize = TextRenderer.MeasureText(text, imageFont);
            Bitmap bmp = new(fontSize.Width, fontSize.Height);
            using (Graphics graphics = Graphics.FromImage(bmp))
            {

                graphics.FillRectangle(new SolidBrush(BackgroundColor), 0, 0, bmp.Width, bmp.Height);
                graphics.DrawString(text, imageFont, new SolidBrush(ForegroundColor), 0, 0);


            }
            return bmp;

        }

    }
}