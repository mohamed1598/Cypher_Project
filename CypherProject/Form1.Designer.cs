
namespace CypherProject
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            this.transpositionDecrypted = new System.Windows.Forms.TextBox();
            this.transpositionEncrypt = new System.Windows.Forms.Button();
            this.transpostionKey = new System.Windows.Forms.TextBox();
            this.transpostionEncrypted = new System.Windows.Forms.TextBox();
            this.transpositionDecrypt = new System.Windows.Forms.Button();
            this.RSAEncryped = new System.Windows.Forms.TextBox();
            this.RSAq = new System.Windows.Forms.NumericUpDown();
            this.RSAp = new System.Windows.Forms.NumericUpDown();
            this.RSAEncrypt = new System.Windows.Forms.Button();
            this.RSADecrypt = new System.Windows.Forms.Button();
            this.RSADecrypted = new System.Windows.Forms.TextBox();
            this.FairPlayEncrypted = new System.Windows.Forms.TextBox();
            this.FairPlayKey = new System.Windows.Forms.TextBox();
            this.FairPlayDecrypted = new System.Windows.Forms.TextBox();
            this.FairPlayDecrypt = new System.Windows.Forms.Button();
            this.FairPlayEncrypt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RSAq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RSAp)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(-2, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(237, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(551, 18);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(249, 20);
            this.textBox2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(324, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "SubsitutionEncrypt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(241, 17);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(77, 20);
            this.numericUpDown1.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(436, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "SubsitutionDecrypt";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // transpositionDecrypted
            // 
            this.transpositionDecrypted.Location = new System.Drawing.Point(551, 65);
            this.transpositionDecrypted.Name = "transpositionDecrypted";
            this.transpositionDecrypted.Size = new System.Drawing.Size(249, 20);
            this.transpositionDecrypted.TabIndex = 6;
            // 
            // transpositionEncrypt
            // 
            this.transpositionEncrypt.Location = new System.Drawing.Point(324, 62);
            this.transpositionEncrypt.Name = "transpositionEncrypt";
            this.transpositionEncrypt.Size = new System.Drawing.Size(107, 23);
            this.transpositionEncrypt.TabIndex = 7;
            this.transpositionEncrypt.Text = "transpositionEncrypt";
            this.transpositionEncrypt.UseVisualStyleBackColor = true;
            this.transpositionEncrypt.Click += new System.EventHandler(this.transpositionEncrypt_Click);
            // 
            // transpostionKey
            // 
            this.transpostionKey.Location = new System.Drawing.Point(241, 64);
            this.transpostionKey.Name = "transpostionKey";
            this.transpostionKey.Size = new System.Drawing.Size(77, 20);
            this.transpostionKey.TabIndex = 8;
            // 
            // transpostionEncrypted
            // 
            this.transpostionEncrypted.Location = new System.Drawing.Point(-2, 64);
            this.transpostionEncrypted.Name = "transpostionEncrypted";
            this.transpostionEncrypted.Size = new System.Drawing.Size(237, 20);
            this.transpostionEncrypted.TabIndex = 9;
            // 
            // transpositionDecrypt
            // 
            this.transpositionDecrypt.Location = new System.Drawing.Point(436, 62);
            this.transpositionDecrypt.Name = "transpositionDecrypt";
            this.transpositionDecrypt.Size = new System.Drawing.Size(109, 23);
            this.transpositionDecrypt.TabIndex = 10;
            this.transpositionDecrypt.Text = "transpositionDecrypt";
            this.transpositionDecrypt.UseVisualStyleBackColor = true;
            this.transpositionDecrypt.Click += new System.EventHandler(this.transpositionDecrypt_Click);
            // 
            // RSAEncryped
            // 
            this.RSAEncryped.Location = new System.Drawing.Point(-2, 113);
            this.RSAEncryped.Name = "RSAEncryped";
            this.RSAEncryped.Size = new System.Drawing.Size(183, 20);
            this.RSAEncryped.TabIndex = 11;
            // 
            // RSAq
            // 
            this.RSAq.Location = new System.Drawing.Point(270, 113);
            this.RSAq.Name = "RSAq";
            this.RSAq.Size = new System.Drawing.Size(77, 20);
            this.RSAq.TabIndex = 12;
            // 
            // RSAp
            // 
            this.RSAp.Location = new System.Drawing.Point(187, 114);
            this.RSAp.Name = "RSAp";
            this.RSAp.Size = new System.Drawing.Size(77, 20);
            this.RSAp.TabIndex = 13;
            // 
            // RSAEncrypt
            // 
            this.RSAEncrypt.Location = new System.Drawing.Point(353, 113);
            this.RSAEncrypt.Name = "RSAEncrypt";
            this.RSAEncrypt.Size = new System.Drawing.Size(107, 23);
            this.RSAEncrypt.TabIndex = 14;
            this.RSAEncrypt.Text = "RSAEncrypt";
            this.RSAEncrypt.UseVisualStyleBackColor = true;
            this.RSAEncrypt.Click += new System.EventHandler(this.RSAEncrypt_Click);
            // 
            // RSADecrypt
            // 
            this.RSADecrypt.Location = new System.Drawing.Point(466, 114);
            this.RSADecrypt.Name = "RSADecrypt";
            this.RSADecrypt.Size = new System.Drawing.Size(107, 23);
            this.RSADecrypt.TabIndex = 15;
            this.RSADecrypt.Text = "RSADecrypt";
            this.RSADecrypt.UseVisualStyleBackColor = true;
            this.RSADecrypt.Click += new System.EventHandler(this.RSADecrypt_Click);
            // 
            // RSADecrypted
            // 
            this.RSADecrypted.Location = new System.Drawing.Point(579, 115);
            this.RSADecrypted.Name = "RSADecrypted";
            this.RSADecrypted.Size = new System.Drawing.Size(209, 20);
            this.RSADecrypted.TabIndex = 16;
            // 
            // FairPlayEncrypted
            // 
            this.FairPlayEncrypted.Location = new System.Drawing.Point(-2, 164);
            this.FairPlayEncrypted.Name = "FairPlayEncrypted";
            this.FairPlayEncrypted.Size = new System.Drawing.Size(237, 20);
            this.FairPlayEncrypted.TabIndex = 17;
            // 
            // FairPlayKey
            // 
            this.FairPlayKey.Location = new System.Drawing.Point(241, 164);
            this.FairPlayKey.Name = "FairPlayKey";
            this.FairPlayKey.Size = new System.Drawing.Size(77, 20);
            this.FairPlayKey.TabIndex = 18;
            // 
            // FairPlayDecrypted
            // 
            this.FairPlayDecrypted.Location = new System.Drawing.Point(551, 164);
            this.FairPlayDecrypted.Name = "FairPlayDecrypted";
            this.FairPlayDecrypted.Size = new System.Drawing.Size(249, 20);
            this.FairPlayDecrypted.TabIndex = 19;
            // 
            // FairPlayDecrypt
            // 
            this.FairPlayDecrypt.Location = new System.Drawing.Point(436, 164);
            this.FairPlayDecrypt.Name = "FairPlayDecrypt";
            this.FairPlayDecrypt.Size = new System.Drawing.Size(109, 23);
            this.FairPlayDecrypt.TabIndex = 20;
            this.FairPlayDecrypt.Text = "FPDecrypt";
            this.FairPlayDecrypt.UseVisualStyleBackColor = true;
            this.FairPlayDecrypt.Click += new System.EventHandler(this.FairPlayDecrypt_Click);
            // 
            // FairPlayEncrypt
            // 
            this.FairPlayEncrypt.Location = new System.Drawing.Point(324, 164);
            this.FairPlayEncrypt.Name = "FairPlayEncrypt";
            this.FairPlayEncrypt.Size = new System.Drawing.Size(107, 23);
            this.FairPlayEncrypt.TabIndex = 21;
            this.FairPlayEncrypt.Text = "FPEncrypt";
            this.FairPlayEncrypt.UseVisualStyleBackColor = true;
            this.FairPlayEncrypt.Click += new System.EventHandler(this.FairPlayEncrypt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FairPlayEncrypt);
            this.Controls.Add(this.FairPlayDecrypt);
            this.Controls.Add(this.FairPlayDecrypted);
            this.Controls.Add(this.FairPlayKey);
            this.Controls.Add(this.FairPlayEncrypted);
            this.Controls.Add(this.RSADecrypted);
            this.Controls.Add(this.RSADecrypt);
            this.Controls.Add(this.RSAEncrypt);
            this.Controls.Add(this.RSAp);
            this.Controls.Add(this.RSAq);
            this.Controls.Add(this.RSAEncryped);
            this.Controls.Add(this.transpositionDecrypt);
            this.Controls.Add(this.transpostionEncrypted);
            this.Controls.Add(this.transpostionKey);
            this.Controls.Add(this.transpositionEncrypt);
            this.Controls.Add(this.transpositionDecrypted);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RSAq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RSAp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox transpositionDecrypted;
        private System.Windows.Forms.Button transpositionEncrypt;
        private System.Windows.Forms.TextBox transpostionKey;
        private System.Windows.Forms.TextBox transpostionEncrypted;
        private System.Windows.Forms.Button transpositionDecrypt;
        private System.Windows.Forms.TextBox RSAEncryped;
        private System.Windows.Forms.NumericUpDown RSAq;
        private System.Windows.Forms.NumericUpDown RSAp;
        private System.Windows.Forms.Button RSAEncrypt;
        private System.Windows.Forms.Button RSADecrypt;
        private System.Windows.Forms.TextBox RSADecrypted;
        private System.Windows.Forms.TextBox FairPlayEncrypted;
        private System.Windows.Forms.TextBox FairPlayKey;
        private System.Windows.Forms.TextBox FairPlayDecrypted;
        private System.Windows.Forms.Button FairPlayDecrypt;
        private System.Windows.Forms.Button FairPlayEncrypt;
    }
}

