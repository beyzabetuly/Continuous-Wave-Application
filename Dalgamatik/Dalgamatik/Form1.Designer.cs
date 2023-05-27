
namespace Dalgamatik
{
    partial class Form1
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
            this.pictureHavuz = new System.Windows.Forms.PictureBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBarsiddet = new System.Windows.Forms.TrackBar();
            this.trackBarfrekans = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.timer_Hareket = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureHavuz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarsiddet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarfrekans)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureHavuz
            // 
            this.pictureHavuz.BackColor = System.Drawing.Color.Gray;
            this.pictureHavuz.Location = new System.Drawing.Point(304, 44);
            this.pictureHavuz.Name = "pictureHavuz";
            this.pictureHavuz.Size = new System.Drawing.Size(614, 507);
            this.pictureHavuz.TabIndex = 0;
            this.pictureHavuz.TabStop = false;
            this.pictureHavuz.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureHavuz_Paint);
            this.pictureHavuz.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureHavuz_MouseClick);
            this.pictureHavuz.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pictureHavuz_MouseDoubleClick);
            this.pictureHavuz.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureHavuz_MouseMove);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(59, 129);
            this.trackBar1.Maximum = 4;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(145, 56);
            this.trackBar1.TabIndex = 1;
            this.trackBar1.Value = 2;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // trackBarsiddet
            // 
            this.trackBarsiddet.Location = new System.Drawing.Point(59, 276);
            this.trackBarsiddet.Maximum = 4;
            this.trackBarsiddet.Name = "trackBarsiddet";
            this.trackBarsiddet.Size = new System.Drawing.Size(145, 56);
            this.trackBarsiddet.TabIndex = 2;
            this.trackBarsiddet.Value = 2;
            this.trackBarsiddet.Scroll += new System.EventHandler(this.trackBarsiddet_Scroll);
            // 
            // trackBarfrekans
            // 
            this.trackBarfrekans.Location = new System.Drawing.Point(59, 426);
            this.trackBarfrekans.Maximum = 4;
            this.trackBarfrekans.Name = "trackBarfrekans";
            this.trackBarfrekans.Size = new System.Drawing.Size(145, 56);
            this.trackBarfrekans.TabIndex = 3;
            this.trackBarfrekans.Value = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Harlow Solid Italic", 20F, System.Drawing.FontStyle.Italic);
            this.label1.Location = new System.Drawing.Point(90, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 43);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hız";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Harlow Solid Italic", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 42);
            this.label2.TabIndex = 5;
            this.label2.Text = "Şiddet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Harlow Solid Italic", 20F, System.Drawing.FontStyle.Italic);
            this.label3.Location = new System.Drawing.Point(60, 359);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 43);
            this.label3.TabIndex = 6;
            this.label3.Text = "Frekans";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Orange;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(47, 488);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 75);
            this.button1.TabIndex = 7;
            this.button1.Text = "Temizle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer_Hareket
            // 
            this.timer_Hareket.Enabled = true;
            this.timer_Hareket.Interval = 50;
            this.timer_Hareket.Tick += new System.EventHandler(this.timer_Hareket_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(943, 606);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBarfrekans);
            this.Controls.Add(this.trackBarsiddet);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.pictureHavuz);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DALGAMATİK";
            ((System.ComponentModel.ISupportInitialize)(this.pictureHavuz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarsiddet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarfrekans)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureHavuz;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBarsiddet;
        private System.Windows.Forms.TrackBar trackBarfrekans;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer_Hareket;
    }
}

