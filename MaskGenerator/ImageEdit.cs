using System.Drawing;

namespace MaskGenerator
{
    internal class ImageEdit
    {

        internal Bitmap ScaledImage(Image img, Size size)
        {
            if (img == null)
            { return null; }
            if (img.Size == size)
            { return (Bitmap)img; }
            return new Bitmap(img, size);
        }

        internal float GetVibrancy(Bitmap bitmap, int x, int y)
        {
            if (bitmap == null)
            { return default; }
            Color col = bitmap.GetPixel(x, y);
            return col.GetBrightness();
        }

        internal Color SetChannels(Color color, byte r = default, byte g = default, byte b = default, byte a = default)
        {
            r = r == default ? color.R : r;
            g = g == default ? color.G : g;
            b = b == default ? color.B : b;
            a = a == default ? color.A : a;

            Color res = Color.FromArgb((int)a, (int)r, (int)g, (int)b);
            return res;
        }



        internal byte FloatToByte(float value)
        {
            float from1 = 0;
            float to1 = 1;
            float from2 = 0;
            float to2 = 255;
            float remapped = (value - from1) / (to1 - from1) * (to2 - from2) + from2;
            return (byte)remapped;
        }

    }
}
