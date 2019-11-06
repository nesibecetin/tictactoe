namespace tictactoe
{
    partial class Form2
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
            this.btnBilgisayar = new System.Windows.Forms.Button();
            this.btnIkiOyuncu = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBilgisayar
            // 
            this.btnBilgisayar.Location = new System.Drawing.Point(107, 79);
            this.btnBilgisayar.Name = "btnBilgisayar";
            this.btnBilgisayar.Size = new System.Drawing.Size(105, 44);
            this.btnBilgisayar.TabIndex = 0;
            this.btnBilgisayar.Text = "Bilgisayarla Oyna";
            this.btnBilgisayar.UseVisualStyleBackColor = true;
            this.btnBilgisayar.Click += new System.EventHandler(this.btnBilgisayar_Click);
            // 
            // btnIkiOyuncu
            // 
            this.btnIkiOyuncu.Location = new System.Drawing.Point(107, 129);
            this.btnIkiOyuncu.Name = "btnIkiOyuncu";
            this.btnIkiOyuncu.Size = new System.Drawing.Size(105, 44);
            this.btnIkiOyuncu.TabIndex = 1;
            this.btnIkiOyuncu.Text = "İkiOyuncu";
            this.btnIkiOyuncu.UseVisualStyleBackColor = true;
            this.btnIkiOyuncu.Click += new System.EventHandler(this.btnIkiOyuncu_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(107, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 44);
            this.button1.TabIndex = 2;
            this.button1.Text = "Network";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 307);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnIkiOyuncu);
            this.Controls.Add(this.btnBilgisayar);
            this.Name = "Form2";
            this.Text = "Ana Ekran";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBilgisayar;
        private System.Windows.Forms.Button btnIkiOyuncu;
        private System.Windows.Forms.Button button1;
    }
}