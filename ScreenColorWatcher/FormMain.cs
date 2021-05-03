using System;
using System.Drawing;
using System.Windows.Forms;

namespace ScreenColorWatcher
{
    public partial class FormMain : Form
    {
        private ColorWatcher _colorWatcher = null;

        public FormMain()
        {
            InitializeComponent();

            UpdateControlStatus();
        }
        private bool IsWatching => _colorWatcher != null;

        private void UpdateControlStatus()
        {
            numericUpDownWatchX.Enabled = !IsWatching;
            numericUpDownWatchY.Enabled = !IsWatching;
            numericUpDownlabelAllowDifferenceColorRange.Enabled = !IsWatching;
            buttonStart.Enabled = !IsWatching;
            buttonStop.Enabled = IsWatching;
        }

        private Color GetSpecifiedPositionColor()
        {
            int x = (int)numericUpDownWatchX.Value;
            int y = (int)numericUpDownWatchY.Value;
            return ColorGetter.FromScreenPosition(new Point(x, y));
        }

        private void UpdateMousePositionControl()
        {
            var p = MousePosition;
            numericUpDownCurrentMouseX.Value = p.X;
            numericUpDownCurrentMouseY.Value = p.Y;
        }
        private void PollWatching()
        {
            var log = _colorWatcher.Update(GetSpecifiedPositionColor(), DateTime.Now);
            if (log == null) { return; }

            textBoxOutput.AppendText(log + Environment.NewLine);
        }

        private void timerWatch_Tick(object sender, System.EventArgs e)
        {
            UpdateMousePositionControl();

            if (IsWatching)
            {
                PollWatching();
            }
        }

        private void buttonStart_Click(object sender, System.EventArgs e)
        {
            _colorWatcher = new ColorWatcher(
                GetSpecifiedPositionColor(),
                DateTime.Now,
                (int)numericUpDownlabelAllowDifferenceColorRange.Value);
            UpdateControlStatus();
        }

        private void buttonStop_Click(object sender, System.EventArgs e)
        {
            _colorWatcher = null;
            UpdateControlStatus();
        }

        private void buttonClearLog_Click(object sender, EventArgs e)
        {
            textBoxOutput.Clear();
        }
    }
}
