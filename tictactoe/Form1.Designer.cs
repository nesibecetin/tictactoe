namespace tictactoe
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
            this.A00 = new System.Windows.Forms.Button();
            this.A10 = new System.Windows.Forms.Button();
            this.A20 = new System.Windows.Forms.Button();
            this.A21 = new System.Windows.Forms.Button();
            this.A11 = new System.Windows.Forms.Button();
            this.A01 = new System.Windows.Forms.Button();
            this.A22 = new System.Windows.Forms.Button();
            this.A12 = new System.Windows.Forms.Button();
            this.A02 = new System.Windows.Forms.Button();
            this.btnYeniOyun = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.lblMe = new System.Windows.Forms.Label();
            this.lblDraws = new System.Windows.Forms.Label();
            this.lblCPU = new System.Windows.Forms.Label();
            this.CPUScore = new System.Windows.Forms.Label();
            this.DrawsCount = new System.Windows.Forms.Label();
            this.MyScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // A00
            // 
            this.A00.Location = new System.Drawing.Point(15, 72);
            this.A00.Name = "A00";
            this.A00.Size = new System.Drawing.Size(90, 75);
            this.A00.TabIndex = 0;
            this.A00.UseVisualStyleBackColor = true;
            this.A00.Click += new System.EventHandler(this.buttonClick);
            // 
            // A10
            // 
            this.A10.Location = new System.Drawing.Point(15, 153);
            this.A10.Name = "A10";
            this.A10.Size = new System.Drawing.Size(90, 75);
            this.A10.TabIndex = 1;
            this.A10.UseVisualStyleBackColor = true;
            this.A10.Click += new System.EventHandler(this.buttonClick);
            // 
            // A20
            // 
            this.A20.Location = new System.Drawing.Point(15, 234);
            this.A20.Name = "A20";
            this.A20.Size = new System.Drawing.Size(90, 75);
            this.A20.TabIndex = 2;
            this.A20.UseVisualStyleBackColor = true;
            this.A20.Click += new System.EventHandler(this.buttonClick);
            // 
            // A21
            // 
            this.A21.Location = new System.Drawing.Point(111, 234);
            this.A21.Name = "A21";
            this.A21.Size = new System.Drawing.Size(90, 75);
            this.A21.TabIndex = 5;
            this.A21.UseVisualStyleBackColor = true;
            this.A21.Click += new System.EventHandler(this.buttonClick);
            // 
            // A11
            // 
            this.A11.Location = new System.Drawing.Point(111, 153);
            this.A11.Name = "A11";
            this.A11.Size = new System.Drawing.Size(90, 75);
            this.A11.TabIndex = 4;
            this.A11.UseVisualStyleBackColor = true;
            this.A11.Click += new System.EventHandler(this.buttonClick);
            // 
            // A01
            // 
            this.A01.Location = new System.Drawing.Point(111, 72);
            this.A01.Name = "A01";
            this.A01.Size = new System.Drawing.Size(90, 75);
            this.A01.TabIndex = 3;
            this.A01.UseVisualStyleBackColor = true;
            this.A01.Click += new System.EventHandler(this.buttonClick);
            // 
            // A22
            // 
            this.A22.Location = new System.Drawing.Point(207, 234);
            this.A22.Name = "A22";
            this.A22.Size = new System.Drawing.Size(90, 75);
            this.A22.TabIndex = 8;
            this.A22.UseVisualStyleBackColor = true;
            this.A22.Click += new System.EventHandler(this.buttonClick);
            // 
            // A12
            // 
            this.A12.Location = new System.Drawing.Point(207, 153);
            this.A12.Name = "A12";
            this.A12.Size = new System.Drawing.Size(90, 75);
            this.A12.TabIndex = 7;
            this.A12.UseVisualStyleBackColor = true;
            this.A12.Click += new System.EventHandler(this.buttonClick);
            // 
            // A02
            // 
            this.A02.Location = new System.Drawing.Point(207, 72);
            this.A02.Name = "A02";
            this.A02.Size = new System.Drawing.Size(90, 75);
            this.A02.TabIndex = 6;
            this.A02.UseVisualStyleBackColor = true;
            this.A02.Click += new System.EventHandler(this.buttonClick);
            // 
            // btnYeniOyun
            // 
            this.btnYeniOyun.Location = new System.Drawing.Point(16, 12);
            this.btnYeniOyun.Name = "btnYeniOyun";
            this.btnYeniOyun.Size = new System.Drawing.Size(89, 33);
            this.btnYeniOyun.TabIndex = 9;
            this.btnYeniOyun.Text = "Yeni Oyun";
            this.btnYeniOyun.UseVisualStyleBackColor = true;
            this.btnYeniOyun.Click += new System.EventHandler(this.btnYeniOyun_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(112, 12);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(89, 33);
            this.btnTemizle.TabIndex = 10;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(207, 12);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(89, 33);
            this.btnCikis.TabIndex = 11;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // lblMe
            // 
            this.lblMe.Location = new System.Drawing.Point(13, 321);
            this.lblMe.Name = "lblMe";
            this.lblMe.Size = new System.Drawing.Size(100, 23);
            this.lblMe.TabIndex = 12;
            this.lblMe.Text = "Me";
            // 
            // lblDraws
            // 
            this.lblDraws.Location = new System.Drawing.Point(109, 321);
            this.lblDraws.Name = "lblDraws";
            this.lblDraws.Size = new System.Drawing.Size(92, 23);
            this.lblDraws.TabIndex = 13;
            this.lblDraws.Text = "Draws";
            // 
            // lblCPU
            // 
            this.lblCPU.Location = new System.Drawing.Point(207, 321);
            this.lblCPU.Name = "lblCPU";
            this.lblCPU.Size = new System.Drawing.Size(100, 23);
            this.lblCPU.TabIndex = 14;
            this.lblCPU.Text = "CPU";
            // 
            // CPUScore
            // 
            this.CPUScore.Location = new System.Drawing.Point(207, 344);
            this.CPUScore.Name = "CPUScore";
            this.CPUScore.Size = new System.Drawing.Size(100, 23);
            this.CPUScore.TabIndex = 17;
            // 
            // DrawsCount
            // 
            this.DrawsCount.Location = new System.Drawing.Point(109, 344);
            this.DrawsCount.Name = "DrawsCount";
            this.DrawsCount.Size = new System.Drawing.Size(92, 23);
            this.DrawsCount.TabIndex = 16;
            // 
            // MyScore
            // 
            this.MyScore.Location = new System.Drawing.Point(13, 344);
            this.MyScore.Name = "MyScore";
            this.MyScore.Size = new System.Drawing.Size(92, 23);
            this.MyScore.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 373);
            this.Controls.Add(this.CPUScore);
            this.Controls.Add(this.DrawsCount);
            this.Controls.Add(this.MyScore);
            this.Controls.Add(this.lblCPU);
            this.Controls.Add(this.lblDraws);
            this.Controls.Add(this.lblMe);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnYeniOyun);
            this.Controls.Add(this.A22);
            this.Controls.Add(this.A12);
            this.Controls.Add(this.A02);
            this.Controls.Add(this.A21);
            this.Controls.Add(this.A11);
            this.Controls.Add(this.A01);
            this.Controls.Add(this.A20);
            this.Controls.Add(this.A10);
            this.Controls.Add(this.A00);
            this.Name = "Form1";
            this.Text = "Bilgisayara Karşı";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button A00;
        private System.Windows.Forms.Button A10;
        private System.Windows.Forms.Button A20;
        private System.Windows.Forms.Button A21;
        private System.Windows.Forms.Button A11;
        private System.Windows.Forms.Button A01;
        private System.Windows.Forms.Button A22;
        private System.Windows.Forms.Button A12;
        private System.Windows.Forms.Button A02;
        private System.Windows.Forms.Button btnYeniOyun;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Label lblMe;
        private System.Windows.Forms.Label lblDraws;
        private System.Windows.Forms.Label lblCPU;
        private System.Windows.Forms.Label CPUScore;
        private System.Windows.Forms.Label DrawsCount;
        private System.Windows.Forms.Label MyScore;
    }
}

