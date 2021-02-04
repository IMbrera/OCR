using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;

namespace HistogramOCRTrainer.FEctra
{
    public class BitmapExtras
    {
    public static Bitmap ChangeAllNonWhitePixelsToColour(Bitmap bitmap, Color replace)
    {
        for (var y = 0; y < bitmap.Height; y++)
        {
            for (var x = 0; x < bitmap.Width; x++)
            {
                var p = bitmap.GetPixel(x, y);
                var white = !(p.R != 255 || p.G != 255 || p.B != 255);
                bitmap.SetPixel(x, y, white ? Color.White : replace);
            }
        }
        return bitmap;
    }
      /// <summary>
      /// Растягивание изображения
      /// </summary>
      /// <param name="bitmap"></param>
      /// <param name="width"></param>
      /// <param name="height"></param>
      /// <returns></returns>
    public static Bitmap StretchBitmap(Bitmap bitmap, int width, int height)
    {
        var ret = new Bitmap(bitmap, width, height);
        return ret;
    }

/// <summary>
/// обрезание изображения на осное новой высоты и ширины
/// </summary>
/// <param name="bitmap"></param>
/// <param name="newWidth"></param>
/// <param name="newHeight"></param>
/// <param name="startx"></param>
/// <param name="starty"></param>
/// <returns></returns>
    public static Bitmap Crop(Bitmap bitmap, int newWidth = -1, int newHeight = -1, int startx = 0, int starty = 0)
    {
        var w = newWidth == -1 ? bitmap.Width : newWidth;
        var h = newHeight == -1 ? bitmap.Height : newHeight;
        var rect = new Rectangle(startx, starty, w, h);

        return bitmap.Clone(rect, PixelFormat.DontCare);
    }

    /// <summary>
    /// определение цветных пикселей
    /// </summary>
    /// <param name="bitmap">The bitmap.</param>
    /// <param name="colour">The colour.</param>
    /// <returns></returns>
    public static bool IsAllPixelsAColour(Bitmap bitmap, Color colour)
    {
        for (var y = 0; y < bitmap.Height; y++)
        {
            if (IsRowOrColSameColour(bitmap, y, true, colour) == false)
                return false;
        }
        return true;
    }

        /// <summary>
        ///  Определяет, есть ли в растровом изображении вся строка / столбец одного цвета
    /// </summary>
    /// <param name="bitmap">The bitmap.</param>
    /// <param name="rowOrCol">The row or col.</param>
    /// <param name="isRow">if set to <c>true</c> [is row].</param>
    /// <param name="c">The c.</param>
    /// <returns></returns>
    public static bool IsRowOrColSameColour(Bitmap bitmap, int rowOrCol, bool isRow, Color c)
    {
        var w = bitmap.Width;
        var h = bitmap.Height;
        var to = isRow ? w : h;

        for (var v = 0; v < to; v++)
        {
            var c2 = isRow ? bitmap.GetPixel(v, rowOrCol) : bitmap.GetPixel(rowOrCol, v);

            if (c2.R != c.R || c2.G != c.G || c2.B != c.B)
                return false;
        }
        return true;
    }

        /// <summary>
        /// Удаляет лишние пробелы.
        /// </summary>
        /// <param name="bitmap"></param>
        /// <param name="keepPureWhite"></param>
        /// <param name="padx"></param>
        /// <param name="pady"></param>
        /// <returns></returns>
    public static Bitmap RemoveExcessWhitespace(Bitmap bitmap, bool keepPureWhite = true)
    {
        //remove rows of white
        var starty = -1;
        var endy = -1;
        var startx = -1;
        var endx = -1;
        for (var y = 0; y < bitmap.Height; y++)
        {
            if (starty == -1)
            {
                if (IsRowOrColSameColour(bitmap, y, true, Color.White) == false)
                    starty = y;
            }

            if (endy == -1)
            {
                var ey = (bitmap.Height - 1) - y;
                if (IsRowOrColSameColour(bitmap, ey, true, Color.White) == false)
                    endy = ey;
            }

            if (starty != -1 && endy != -1)
                break;
        }

        for (var x = 0; x < bitmap.Width; x++)
        {
            if (startx == -1)
            {
                if (IsRowOrColSameColour(bitmap, x, false, Color.White) == false)
                    startx = x;
            }

            if (endx == -1)
            {
                var ex = (bitmap.Width - 1) - x;
                if (IsRowOrColSameColour(bitmap, ex, false, Color.White) == false)
                    endx = ex;
            }

            if (startx != -1 && endx != -1)
                break;
        }

        if (starty == -1 || startx == -1 || endy == -1 || endx == -1)
        {
            if (keepPureWhite)
                return bitmap;
            throw new Exception("ошибка изменения размера");
        }

        var nb = Crop(bitmap, endx - startx, endy - starty, startx, starty);

        return nb;
    }
}
}