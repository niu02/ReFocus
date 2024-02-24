namespace ReFocus
{
    public partial class BunnyRun
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
            this.bunny = new System.Windows.Forms.PictureBox();
            this.bush1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tTimer = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.speedLabel = new System.Windows.Forms.Label();
            this.appTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bunny)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bush1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // bunny
            // 
            this.bunny.BackColor = System.Drawing.Color.Transparent;
            this.bunny.Image = global::ReFocus.Properties.Resources.rabbit_normal;
            this.bunny.Location = new System.Drawing.Point(103, 453);
            this.bunny.Name = "bunny";
            this.bunny.Size = new System.Drawing.Size(59, 51);
            this.bunny.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunny.TabIndex = 1;
            this.bunny.TabStop = false;
            // 
            // bush1
            // 
            this.bush1.BackColor = System.Drawing.Color.Transparent;
            this.bush1.Image = global::ReFocus.Properties.Resources.plat11;
            this.bush1.Location = new System.Drawing.Point(512, 453);
            this.bush1.Name = "bush1";
            this.bush1.Size = new System.Drawing.Size(62, 54);
            this.bush1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bush1.TabIndex = 3;
            this.bush1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timerTick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 800;
            this.timer2.Tick += new System.EventHandler(this.timer2Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(119, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Re:Focus Bunny Run";
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(21, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(74, 30);
            this.backButton.TabIndex = 15;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.BackToMenu);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::ReFocus.Properties.Resources.timer3;
            this.pictureBox2.Location = new System.Drawing.Point(382, 14);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 28);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // tTimer
            // 
            this.tTimer.AutoSize = true;
            this.tTimer.BackColor = System.Drawing.Color.Transparent;
            this.tTimer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tTimer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.tTimer.Location = new System.Drawing.Point(413, 17);
            this.tTimer.Name = "tTimer";
            this.tTimer.Size = new System.Drawing.Size(49, 21);
            this.tTimer.TabIndex = 16;
            this.tTimer.Text = "00:00";
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.scoreLabel.Font = new System.Drawing.Font("Segoe UI Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.scoreLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.scoreLabel.Location = new System.Drawing.Point(191, 95);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(86, 30);
            this.scoreLabel.TabIndex = 18;
            this.scoreLabel.Text = "Score: 0";
            // 
            // speedLabel
            // 
            this.speedLabel.AutoSize = true;
            this.speedLabel.BackColor = System.Drawing.Color.Transparent;
            this.speedLabel.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.speedLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.speedLabel.Location = new System.Drawing.Point(193, 146);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(80, 21);
            this.speedLabel.TabIndex = 19;
            this.speedLabel.Text = "Difficulty: 1";
            // 
            // appTimer
            // 
            this.appTimer.Enabled = true;
            this.appTimer.Interval = 1000;
            this.appTimer.Tick += new System.EventHandler(this.appTimerTick);
            // 
            // BunnyRun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ReFocus.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(477, 611);
            this.ControlBox = false;
            this.Controls.Add(this.speedLabel);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.tTimer);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bunny);
            this.Controls.Add(this.bush1);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BunnyRun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Re:Focus BunnyRun";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnClick);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnRelease);
            ((System.ComponentModel.ISupportInitialize)(this.bunny)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bush1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBox bunny;
        private PictureBox bush1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private Label label1;
        private Button backButton;
        private PictureBox pictureBox2;
        private Label tTimer;
        private Label scoreLabel;
        private Label speedLabel;
        private System.Windows.Forms.Timer appTimer;
    }
}