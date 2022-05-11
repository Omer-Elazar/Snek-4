namespace Snek
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
            this.Scoretxt = new System.Windows.Forms.Label();
            this.HighScoretxt = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Newbtn = new System.Windows.Forms.Button();
            this.Pausebtn = new System.Windows.Forms.Button();
            this.Savebtn = new System.Windows.Forms.Button();
            this.Snapbtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.GoldenTimer = new System.Windows.Forms.Timer(this.components);
            this.Loadbtn = new System.Windows.Forms.Button();
            this.Colorbtn = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.GameOvertxt = new System.Windows.Forms.Label();
            this.Startbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Scoretxt
            // 
            this.Scoretxt.AutoSize = true;
            this.Scoretxt.BackColor = System.Drawing.Color.White;
            this.Scoretxt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Scoretxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Scoretxt.Location = new System.Drawing.Point(12, 69);
            this.Scoretxt.Name = "Scoretxt";
            this.Scoretxt.Size = new System.Drawing.Size(77, 22);
            this.Scoretxt.TabIndex = 0;
            this.Scoretxt.Text = "Score:     ";
            // 
            // HighScoretxt
            // 
            this.HighScoretxt.AutoSize = true;
            this.HighScoretxt.BackColor = System.Drawing.Color.White;
            this.HighScoretxt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.HighScoretxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HighScoretxt.Location = new System.Drawing.Point(119, 69);
            this.HighScoretxt.Name = "HighScoretxt";
            this.HighScoretxt.Size = new System.Drawing.Size(118, 22);
            this.HighScoretxt.TabIndex = 1;
            this.HighScoretxt.Text = "HighScore:       ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pictureBox1.Location = new System.Drawing.Point(12, 105);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(650, 580);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // Newbtn
            // 
            this.Newbtn.Enabled = false;
            this.Newbtn.Location = new System.Drawing.Point(12, 12);
            this.Newbtn.Name = "Newbtn";
            this.Newbtn.Size = new System.Drawing.Size(105, 30);
            this.Newbtn.TabIndex = 3;
            this.Newbtn.TabStop = false;
            this.Newbtn.Text = "New";
            this.Newbtn.UseVisualStyleBackColor = true;
            this.Newbtn.Click += new System.EventHandler(this.Newbtn_Click);
            // 
            // Pausebtn
            // 
            this.Pausebtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Pausebtn.Enabled = false;
            this.Pausebtn.Location = new System.Drawing.Point(123, 12);
            this.Pausebtn.Name = "Pausebtn";
            this.Pausebtn.Size = new System.Drawing.Size(105, 30);
            this.Pausebtn.TabIndex = 4;
            this.Pausebtn.TabStop = false;
            this.Pausebtn.Text = "Pause";
            this.Pausebtn.UseVisualStyleBackColor = true;
            this.Pausebtn.Click += new System.EventHandler(this.Pausebtn_Click);
            // 
            // Savebtn
            // 
            this.Savebtn.Enabled = false;
            this.Savebtn.Location = new System.Drawing.Point(326, 64);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(105, 30);
            this.Savebtn.TabIndex = 5;
            this.Savebtn.TabStop = false;
            this.Savebtn.Text = "Save";
            this.Savebtn.UseVisualStyleBackColor = true;
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // Snapbtn
            // 
            this.Snapbtn.Location = new System.Drawing.Point(548, 12);
            this.Snapbtn.Name = "Snapbtn";
            this.Snapbtn.Size = new System.Drawing.Size(110, 30);
            this.Snapbtn.TabIndex = 6;
            this.Snapbtn.TabStop = false;
            this.Snapbtn.Text = "ScreenShot";
            this.Snapbtn.UseVisualStyleBackColor = true;
            this.Snapbtn.Click += new System.EventHandler(this.Snapbtn_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.TimerTick);
            // 
            // GoldenTimer
            // 
            this.GoldenTimer.Interval = 5000;
            this.GoldenTimer.Tick += new System.EventHandler(this.GoldenTimerTick);
            // 
            // Loadbtn
            // 
            this.Loadbtn.Location = new System.Drawing.Point(437, 64);
            this.Loadbtn.Name = "Loadbtn";
            this.Loadbtn.Size = new System.Drawing.Size(105, 30);
            this.Loadbtn.TabIndex = 7;
            this.Loadbtn.TabStop = false;
            this.Loadbtn.Text = "Load";
            this.Loadbtn.UseVisualStyleBackColor = true;
            this.Loadbtn.Click += new System.EventHandler(this.Loadbtn_Click);
            // 
            // Colorbtn
            // 
            this.Colorbtn.Location = new System.Drawing.Point(432, 12);
            this.Colorbtn.Name = "Colorbtn";
            this.Colorbtn.Size = new System.Drawing.Size(110, 30);
            this.Colorbtn.TabIndex = 8;
            this.Colorbtn.TabStop = false;
            this.Colorbtn.Text = "Snake color";
            this.Colorbtn.UseVisualStyleBackColor = true;
            this.Colorbtn.Click += new System.EventHandler(this.Colorbtn_Click);
            // 
            // colorDialog1
            // 
            this.colorDialog1.FullOpen = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(544, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 40);
            this.label1.TabIndex = 9;
            this.label1.Text = "Press [esc] to\r\nPause/Resume\r\n";
            // 
            // GameOvertxt
            // 
            this.GameOvertxt.AutoSize = true;
            this.GameOvertxt.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.GameOvertxt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GameOvertxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameOvertxt.ForeColor = System.Drawing.Color.Red;
            this.GameOvertxt.Location = new System.Drawing.Point(136, 327);
            this.GameOvertxt.Name = "GameOvertxt";
            this.GameOvertxt.Size = new System.Drawing.Size(404, 71);
            this.GameOvertxt.TabIndex = 10;
            this.GameOvertxt.Text = "GAME OVER";
            this.GameOvertxt.Visible = false;
            // 
            // Startbtn
            // 
            this.Startbtn.Location = new System.Drawing.Point(234, 12);
            this.Startbtn.Name = "Startbtn";
            this.Startbtn.Size = new System.Drawing.Size(105, 30);
            this.Startbtn.TabIndex = 11;
            this.Startbtn.Text = "Start";
            this.Startbtn.UseVisualStyleBackColor = true;
            this.Startbtn.Click += new System.EventHandler(this.Stratbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.Pausebtn;
            this.ClientSize = new System.Drawing.Size(674, 740);
            this.Controls.Add(this.Startbtn);
            this.Controls.Add(this.GameOvertxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Colorbtn);
            this.Controls.Add(this.Loadbtn);
            this.Controls.Add(this.Snapbtn);
            this.Controls.Add(this.Savebtn);
            this.Controls.Add(this.Pausebtn);
            this.Controls.Add(this.Newbtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.HighScoretxt);
            this.Controls.Add(this.Scoretxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximumSize = new System.Drawing.Size(700, 800);
            this.MinimumSize = new System.Drawing.Size(700, 800);
            this.Name = "Form1";
            this.Text = "Snek";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Newbtn;
        private System.Windows.Forms.Button Pausebtn;
        private System.Windows.Forms.Button Savebtn;
        private System.Windows.Forms.Button Snapbtn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer GoldenTimer;
        public System.Windows.Forms.Label Scoretxt;
        public System.Windows.Forms.Label HighScoretxt;
        private System.Windows.Forms.Button Loadbtn;
        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Colorbtn;
        public System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label GameOvertxt;
        private System.Windows.Forms.Button Startbtn;
    }
}

