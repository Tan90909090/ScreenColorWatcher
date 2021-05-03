using System.Drawing;

namespace ScreenColorWatcher
{
    public static class ColorGetter
    {
        public static Color FromScreenPosition(Point p)
        {
            using var bmp = new Bitmap(width: 1, height: 1);
            using var g = Graphics.FromImage(bmp);
            g.CopyFromScreen(upperLeftSource: p, upperLeftDestination: Point.Empty, blockRegionSize: bmp.Size);
            return bmp.GetPixel(0, 0);
        }
    }
}
