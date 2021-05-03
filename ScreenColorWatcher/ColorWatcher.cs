using System;
using System.Drawing;

namespace ScreenColorWatcher
{
    public class ColorWatcher
    {
        private Color _lastColor;
        private DateTime _lastDateTime;
        private readonly int _allowRgbDelta;

        public ColorWatcher(Color initialColor, DateTime initialDateTime, int allowRgbDelta)
        {
            if (allowRgbDelta < 0) { throw new ArgumentOutOfRangeException(nameof(allowRgbDelta)); }

            _lastColor = initialColor;
            _lastDateTime = initialDateTime;
            this._allowRgbDelta = allowRgbDelta;
        }

        public string Update(Color color, DateTime dateTime)
        {
            int diffR = Math.Abs(_lastColor.R - color.R);
            int diffG = Math.Abs(_lastColor.G - color.G);
            int diffB = Math.Abs(_lastColor.B - color.B);
            if (diffR <= _allowRgbDelta &&
                diffG <= _allowRgbDelta &&
                diffB <= _allowRgbDelta)
            {
                return null;
            }

            string begin = _lastDateTime.ToString("HH:mm:ss.fff");
            string end = dateTime.ToString("HH:mm:ss.fff");
            string elapssed = (dateTime - _lastDateTime).ToString(@"hh\:mm\:ss\.fffffff"); // TimeSpanのToStringはクセがすごい
            string rgb = $"#{_lastColor.R:X2}{_lastColor.G:X2}{_lastColor.B:X2}";
            string log = $"[{begin}-{end}]: {rgb} ({elapssed})";

            _lastColor = color;
            _lastDateTime = dateTime;
            return log;
        }
    }
}
