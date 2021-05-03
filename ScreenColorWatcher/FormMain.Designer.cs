
namespace ScreenColorWatcher
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.labelCurrentMouseX = new System.Windows.Forms.Label();
            this.numericUpDownCurrentMouseX = new System.Windows.Forms.NumericUpDown();
            this.labelCurrentMouseY = new System.Windows.Forms.Label();
            this.numericUpDownCurrentMouseY = new System.Windows.Forms.NumericUpDown();
            this.labelWatchX = new System.Windows.Forms.Label();
            this.labelOutput = new System.Windows.Forms.Label();
            this.numericUpDownWatchX = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownWatchY = new System.Windows.Forms.NumericUpDown();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.timerWatch = new System.Windows.Forms.Timer(this.components);
            this.buttonClearLog = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCurrentMouseX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCurrentMouseY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWatchX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWatchY)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOutput.Location = new System.Drawing.Point(14, 200);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.ReadOnly = true;
            this.textBoxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxOutput.Size = new System.Drawing.Size(774, 238);
            this.textBoxOutput.TabIndex = 100;
            // 
            // labelCurrentMouseX
            // 
            this.labelCurrentMouseX.AutoSize = true;
            this.labelCurrentMouseX.Location = new System.Drawing.Point(12, 9);
            this.labelCurrentMouseX.Name = "labelCurrentMouseX";
            this.labelCurrentMouseX.Size = new System.Drawing.Size(125, 12);
            this.labelCurrentMouseX.TabIndex = 1;
            this.labelCurrentMouseX.Text = "現在マウスカーソル座標X";
            // 
            // numericUpDownCurrentMouseX
            // 
            this.numericUpDownCurrentMouseX.Location = new System.Drawing.Point(143, 7);
            this.numericUpDownCurrentMouseX.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numericUpDownCurrentMouseX.Minimum = new decimal(new int[] {
            99999,
            0,
            0,
            -2147483648});
            this.numericUpDownCurrentMouseX.Name = "numericUpDownCurrentMouseX";
            this.numericUpDownCurrentMouseX.ReadOnly = true;
            this.numericUpDownCurrentMouseX.Size = new System.Drawing.Size(67, 19);
            this.numericUpDownCurrentMouseX.TabIndex = 0;
            // 
            // labelCurrentMouseY
            // 
            this.labelCurrentMouseY.AutoSize = true;
            this.labelCurrentMouseY.Location = new System.Drawing.Point(12, 34);
            this.labelCurrentMouseY.Name = "labelCurrentMouseY";
            this.labelCurrentMouseY.Size = new System.Drawing.Size(125, 12);
            this.labelCurrentMouseY.TabIndex = 1;
            this.labelCurrentMouseY.Text = "現在マウスカーソル座標Y";
            // 
            // numericUpDownCurrentMouseY
            // 
            this.numericUpDownCurrentMouseY.Location = new System.Drawing.Point(143, 32);
            this.numericUpDownCurrentMouseY.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numericUpDownCurrentMouseY.Minimum = new decimal(new int[] {
            99999,
            0,
            0,
            -2147483648});
            this.numericUpDownCurrentMouseY.Name = "numericUpDownCurrentMouseY";
            this.numericUpDownCurrentMouseY.ReadOnly = true;
            this.numericUpDownCurrentMouseY.Size = new System.Drawing.Size(67, 19);
            this.numericUpDownCurrentMouseY.TabIndex = 1;
            // 
            // labelWatchX
            // 
            this.labelWatchX.AutoSize = true;
            this.labelWatchX.Location = new System.Drawing.Point(12, 81);
            this.labelWatchX.Name = "labelWatchX";
            this.labelWatchX.Size = new System.Drawing.Size(72, 12);
            this.labelWatchX.TabIndex = 1;
            this.labelWatchX.Text = "色監視座標X";
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Location = new System.Drawing.Point(12, 185);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(213, 12);
            this.labelOutput.TabIndex = 1;
            this.labelOutput.Text = "監視結果ログ(色が変化したら追記されます)";
            // 
            // numericUpDownWatchX
            // 
            this.numericUpDownWatchX.Location = new System.Drawing.Point(143, 79);
            this.numericUpDownWatchX.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numericUpDownWatchX.Minimum = new decimal(new int[] {
            99999,
            0,
            0,
            -2147483648});
            this.numericUpDownWatchX.Name = "numericUpDownWatchX";
            this.numericUpDownWatchX.Size = new System.Drawing.Size(67, 19);
            this.numericUpDownWatchX.TabIndex = 10;
            // 
            // numericUpDownWatchY
            // 
            this.numericUpDownWatchY.Location = new System.Drawing.Point(143, 104);
            this.numericUpDownWatchY.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numericUpDownWatchY.Minimum = new decimal(new int[] {
            99999,
            0,
            0,
            -2147483648});
            this.numericUpDownWatchY.Name = "numericUpDownWatchY";
            this.numericUpDownWatchY.Size = new System.Drawing.Size(67, 19);
            this.numericUpDownWatchY.TabIndex = 11;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(14, 142);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 20;
            this.buttonStart.Text = "監視開始";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(104, 142);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 21;
            this.buttonStop.Text = "監視停止";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // timerWatch
            // 
            this.timerWatch.Enabled = true;
            this.timerWatch.Interval = 1;
            this.timerWatch.Tick += new System.EventHandler(this.timerWatch_Tick);
            // 
            // buttonClearLog
            // 
            this.buttonClearLog.Location = new System.Drawing.Point(247, 142);
            this.buttonClearLog.Name = "buttonClearLog";
            this.buttonClearLog.Size = new System.Drawing.Size(75, 23);
            this.buttonClearLog.TabIndex = 22;
            this.buttonClearLog.Text = "ログクリア";
            this.buttonClearLog.UseVisualStyleBackColor = true;
            this.buttonClearLog.Click += new System.EventHandler(this.buttonClearLog_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "色監視座標Y";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonClearLog);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.numericUpDownWatchY);
            this.Controls.Add(this.numericUpDownCurrentMouseY);
            this.Controls.Add(this.numericUpDownWatchX);
            this.Controls.Add(this.numericUpDownCurrentMouseX);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.labelCurrentMouseY);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelWatchX);
            this.Controls.Add(this.labelCurrentMouseX);
            this.Controls.Add(this.textBoxOutput);
            this.Name = "FormMain";
            this.Text = "スクリーン一点の色を監視するプログラム";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCurrentMouseX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCurrentMouseY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWatchX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWatchY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.Label labelCurrentMouseX;
        private System.Windows.Forms.NumericUpDown numericUpDownCurrentMouseX;
        private System.Windows.Forms.Label labelCurrentMouseY;
        private System.Windows.Forms.NumericUpDown numericUpDownCurrentMouseY;
        private System.Windows.Forms.Label labelWatchX;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.NumericUpDown numericUpDownWatchX;
        private System.Windows.Forms.NumericUpDown numericUpDownWatchY;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Timer timerWatch;
        private System.Windows.Forms.Button buttonClearLog;
        private System.Windows.Forms.Label label1;
    }
}

