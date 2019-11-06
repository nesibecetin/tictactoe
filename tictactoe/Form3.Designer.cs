namespace tictactoe
{
    partial class Form3
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
            this.OScore = new System.Windows.Forms.Label();
            this.DrawsCount1 = new System.Windows.Forms.Label();
            this.XScore = new System.Windows.Forms.Label();
            this.lblOWinor = new System.Windows.Forms.Label();
            this.lblDraws1 = new System.Windows.Forms.Label();
            this.lblXWinor = new System.Windows.Forms.Label();
            this.btnCikis1 = new System.Windows.Forms.Button();
            this.btnTemizle1 = new System.Windows.Forms.Button();
            this.btnYeniOyun1 = new System.Windows.Forms.Button();
            this.A22 = new System.Windows.Forms.Button();
            this.A12 = new System.Windows.Forms.Button();
            this.A02 = new System.Windows.Forms.Button();
            this.A21 = new System.Windows.Forms.Button();
            this.A11 = new System.Windows.Forms.Button();
            this.A01 = new System.Windows.Forms.Button();
            this.A20 = new System.Windows.Forms.Button();
            this.A10 = new System.Windows.Forms.Button();
            this.A00 = new System.Windows.Forms.Button();
            this.TTimer = new System.Windows.Forms.Timer(this.components);
            this.Otimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OSure = new System.Windows.Forms.Label();
            this.XSure = new System.Windows.Forms.Label();
            this.lblOSure = new System.Windows.Forms.Label();
            this.lblXSure = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OScore
            // 
            this.OScore.Location = new System.Drawing.Point(212, 351);
            this.OScore.Name = "OScore";
            this.OScore.Size = new System.Drawing.Size(100, 23);
            this.OScore.TabIndex = 35;
            // 
            // DrawsCount1
            // 
            this.DrawsCount1.Location = new System.Drawing.Point(114, 351);
            this.DrawsCount1.Name = "DrawsCount1";
            this.DrawsCount1.Size = new System.Drawing.Size(92, 23);
            this.DrawsCount1.TabIndex = 34;
            // 
            // XScore
            // 
            this.XScore.Location = new System.Drawing.Point(17, 351);
            this.XScore.Name = "XScore";
            this.XScore.Size = new System.Drawing.Size(100, 23);
            this.XScore.TabIndex = 33;
            // 
            // lblOWinor
            // 
            this.lblOWinor.Location = new System.Drawing.Point(212, 328);
            this.lblOWinor.Name = "lblOWinor";
            this.lblOWinor.Size = new System.Drawing.Size(100, 23);
            this.lblOWinor.TabIndex = 32;
            this.lblOWinor.Text = "OWinor";
            // 
            // lblDraws1
            // 
            this.lblDraws1.Location = new System.Drawing.Point(114, 328);
            this.lblDraws1.Name = "lblDraws1";
            this.lblDraws1.Size = new System.Drawing.Size(92, 23);
            this.lblDraws1.TabIndex = 31;
            this.lblDraws1.Text = "Draws";
            // 
            // lblXWinor
            // 
            this.lblXWinor.Location = new System.Drawing.Point(21, 328);
            this.lblXWinor.Name = "lblXWinor";
            this.lblXWinor.Size = new System.Drawing.Size(89, 23);
            this.lblXWinor.TabIndex = 30;
            this.lblXWinor.Text = "XWinor";
            // 
            // btnCikis1
            // 
            this.btnCikis1.Location = new System.Drawing.Point(212, 19);
            this.btnCikis1.Name = "btnCikis1";
            this.btnCikis1.Size = new System.Drawing.Size(89, 33);
            this.btnCikis1.TabIndex = 29;
            this.btnCikis1.Text = "Çıkış";
            this.btnCikis1.UseVisualStyleBackColor = true;
            this.btnCikis1.Click += new System.EventHandler(this.btnCikis1_Click);
            // 
            // btnTemizle1
            // 
            this.btnTemizle1.Location = new System.Drawing.Point(117, 19);
            this.btnTemizle1.Name = "btnTemizle1";
            this.btnTemizle1.Size = new System.Drawing.Size(89, 33);
            this.btnTemizle1.TabIndex = 28;
            this.btnTemizle1.Text = "Temizle";
            this.btnTemizle1.UseVisualStyleBackColor = true;
            this.btnTemizle1.Click += new System.EventHandler(this.btnTemizle1_Click);
            // 
            // btnYeniOyun1
            // 
            this.btnYeniOyun1.Location = new System.Drawing.Point(21, 19);
            this.btnYeniOyun1.Name = "btnYeniOyun1";
            this.btnYeniOyun1.Size = new System.Drawing.Size(89, 33);
            this.btnYeniOyun1.TabIndex = 27;
            this.btnYeniOyun1.Text = "Yeni Oyun";
            this.btnYeniOyun1.UseVisualStyleBackColor = true;
            this.btnYeniOyun1.Click += new System.EventHandler(this.btnYeniOyun1_Click);
            // 
            // A22
            // 
            this.A22.Location = new System.Drawing.Point(212, 241);
            this.A22.Name = "A22";
            this.A22.Size = new System.Drawing.Size(90, 75);
            this.A22.TabIndex = 26;
            this.A22.UseVisualStyleBackColor = true;
            this.A22.Click += new System.EventHandler(this.buttonClick);
            // 
            // A12
            // 
            this.A12.Location = new System.Drawing.Point(212, 160);
            this.A12.Name = "A12";
            this.A12.Size = new System.Drawing.Size(90, 75);
            this.A12.TabIndex = 25;
            this.A12.UseVisualStyleBackColor = true;
            this.A12.Click += new System.EventHandler(this.buttonClick);
            // 
            // A02
            // 
            this.A02.Location = new System.Drawing.Point(212, 79);
            this.A02.Name = "A02";
            this.A02.Size = new System.Drawing.Size(90, 75);
            this.A02.TabIndex = 24;
            this.A02.UseVisualStyleBackColor = true;
            this.A02.Click += new System.EventHandler(this.buttonClick);
            // 
            // A21
            // 
            this.A21.Location = new System.Drawing.Point(116, 241);
            this.A21.Name = "A21";
            this.A21.Size = new System.Drawing.Size(90, 75);
            this.A21.TabIndex = 23;
            this.A21.UseVisualStyleBackColor = true;
            this.A21.Click += new System.EventHandler(this.buttonClick);
            // 
            // A11
            // 
            this.A11.Location = new System.Drawing.Point(116, 160);
            this.A11.Name = "A11";
            this.A11.Size = new System.Drawing.Size(90, 75);
            this.A11.TabIndex = 22;
            this.A11.UseVisualStyleBackColor = true;
            this.A11.Click += new System.EventHandler(this.buttonClick);
            // 
            // A01
            // 
            this.A01.Location = new System.Drawing.Point(116, 79);
            this.A01.Name = "A01";
            this.A01.Size = new System.Drawing.Size(90, 75);
            this.A01.TabIndex = 21;
            this.A01.UseVisualStyleBackColor = true;
            this.A01.Click += new System.EventHandler(this.buttonClick);
            // 
            // A20
            // 
            this.A20.Location = new System.Drawing.Point(20, 241);
            this.A20.Name = "A20";
            this.A20.Size = new System.Drawing.Size(90, 75);
            this.A20.TabIndex = 20;
            this.A20.UseVisualStyleBackColor = true;
            this.A20.Click += new System.EventHandler(this.buttonClick);
            // 
            // A10
            // 
            this.A10.Location = new System.Drawing.Point(20, 160);
            this.A10.Name = "A10";
            this.A10.Size = new System.Drawing.Size(90, 75);
            this.A10.TabIndex = 19;
            this.A10.UseVisualStyleBackColor = true;
            this.A10.Click += new System.EventHandler(this.buttonClick);
            // 
            // A00
            // 
            this.A00.Location = new System.Drawing.Point(20, 79);
            this.A00.Name = "A00";
            this.A00.Size = new System.Drawing.Size(90, 75);
            this.A00.TabIndex = 18;
            this.A00.UseVisualStyleBackColor = true;
            this.A00.Click += new System.EventHandler(this.buttonClick);
            // 
            // TTimer
            // 
            this.TTimer.Interval = 1000;
            this.TTimer.Tick += new System.EventHandler(this.TTimer_Tick);
            // 
            // Otimer
            // 
            this.Otimer.Interval = 1000;
            this.Otimer.Tick += new System.EventHandler(this.Otimer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 385);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "X oyuncu süresi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 408);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "O oyuncu süresi";
            // 
            // OSure
            // 
            this.OSure.AutoSize = true;
            this.OSure.Location = new System.Drawing.Point(113, 408);
            this.OSure.Name = "OSure";
            this.OSure.Size = new System.Drawing.Size(0, 13);
            this.OSure.TabIndex = 39;
            // 
            // XSure
            // 
            this.XSure.AutoSize = true;
            this.XSure.Location = new System.Drawing.Point(114, 385);
            this.XSure.Name = "XSure";
            this.XSure.Size = new System.Drawing.Size(0, 13);
            this.XSure.TabIndex = 38;
            // 
            // lblOSure
            // 
            this.lblOSure.Location = new System.Drawing.Point(140, 408);
            this.lblOSure.Name = "lblOSure";
            this.lblOSure.Size = new System.Drawing.Size(100, 23);
            this.lblOSure.TabIndex = 40;
            // 
            // lblXSure
            // 
            this.lblXSure.Location = new System.Drawing.Point(140, 385);
            this.lblXSure.Name = "lblXSure";
            this.lblXSure.Size = new System.Drawing.Size(100, 23);
            this.lblXSure.TabIndex = 41;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 430);
            this.Controls.Add(this.lblXSure);
            this.Controls.Add(this.lblOSure);
            this.Controls.Add(this.OSure);
            this.Controls.Add(this.XSure);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OScore);
            this.Controls.Add(this.DrawsCount1);
            this.Controls.Add(this.XScore);
            this.Controls.Add(this.lblOWinor);
            this.Controls.Add(this.lblDraws1);
            this.Controls.Add(this.lblXWinor);
            this.Controls.Add(this.btnCikis1);
            this.Controls.Add(this.btnTemizle1);
            this.Controls.Add(this.btnYeniOyun1);
            this.Controls.Add(this.A22);
            this.Controls.Add(this.A12);
            this.Controls.Add(this.A02);
            this.Controls.Add(this.A21);
            this.Controls.Add(this.A11);
            this.Controls.Add(this.A01);
            this.Controls.Add(this.A20);
            this.Controls.Add(this.A10);
            this.Controls.Add(this.A00);
            this.Name = "Form3";
            this.Text = "İki Oyuncu";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OScore;
        private System.Windows.Forms.Label DrawsCount1;
        private System.Windows.Forms.Label XScore;
        private System.Windows.Forms.Label lblOWinor;
        private System.Windows.Forms.Label lblDraws1;
        private System.Windows.Forms.Label lblXWinor;
        private System.Windows.Forms.Button btnCikis1;
        private System.Windows.Forms.Button btnTemizle1;
        private System.Windows.Forms.Button btnYeniOyun1;
        private System.Windows.Forms.Button A22;
        private System.Windows.Forms.Button A12;
        private System.Windows.Forms.Button A02;
        private System.Windows.Forms.Button A21;
        private System.Windows.Forms.Button A11;
        private System.Windows.Forms.Button A01;
        private System.Windows.Forms.Button A20;
        private System.Windows.Forms.Button A10;
        private System.Windows.Forms.Button A00;
        private System.Windows.Forms.Timer TTimer;
        private System.Windows.Forms.Timer Otimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label OSure;
        private System.Windows.Forms.Label XSure;
        private System.Windows.Forms.Label lblOSure;
        private System.Windows.Forms.Label lblXSure;
    }
}