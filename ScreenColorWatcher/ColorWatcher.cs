using System;
using System.Drawing;

namespace ScreenColorWatcher
{
    public class ColorWatcher
    {
        private Color _lastColor;
        private DateTime _lastDateTime;

        public ColorWatcher(Color initialColor, DateTime initialDateTime)
        {
            _lastColor = initialColor;
            _lastDateTime = initialDateTime;
        }

        public string Update(Color color, DateTime dateTime)
        {
            if (_lastColor == color) { return null; }

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
