namespace Tutorial.MVP
{
    partial class StartUp
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
            this.btnSayiArttır = new System.Windows.Forms.Button();
            this.btnSayiAzalt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // btnSayiArttır
            // 
            this.btnSayiArttır.Location = new System.Drawing.Point(128, 10);
            this.btnSayiArttır.Name = "btnSayiArttır";
            this.btnSayiArttır.Size = new System.Drawing.Size(75, 23);
            this.btnSayiArttır.TabIndex = 1;
            this.btnSayiArttır.Text = "Sayıyı Arttır";
            this.btnSayiArttır.UseVisualStyleBackColor = true;
            this.btnSayiArttır.Click += new System.EventHandler(this.btnSayiArttır_Click);
            // 
            // btnSayiAzalt
            // 
            this.btnSayiAzalt.Location = new System.Drawing.Point(209, 10);
            this.btnSayiAzalt.Name = "btnSayiAzalt";
            this.btnSayiAzalt.Size = new System.Drawing.Size(75, 23);
            this.btnSayiAzalt.TabIndex = 2;
            this.btnSayiAzalt.Text = "Sayıyı Azalt";
            this.btnSayiAzalt.UseVisualStyleBackColor = true;
            this.btnSayiAzalt.Click += new System.EventHandler(this.btnSayiAzalt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 381);
            this.Controls.Add(this.btnSayiAzalt);
            this.Controls.Add(this.btnSayiArttır);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSayiArttır;
        private System.Windows.Forms.Button btnSayiAzalt;
    }
}

