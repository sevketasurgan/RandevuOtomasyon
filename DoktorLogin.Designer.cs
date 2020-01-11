namespace HastahaneRandevuProje
{
    partial class DoktorLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtdoktorKadi = new System.Windows.Forms.TextBox();
            this.txtdoktorSifre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGirisYap = new System.Windows.Forms.Button();
            this.btnGeriDön = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "KULLANICI \r\nADI :";
            // 
            // txtdoktorKadi
            // 
            this.txtdoktorKadi.Location = new System.Drawing.Point(107, 23);
            this.txtdoktorKadi.Name = "txtdoktorKadi";
            this.txtdoktorKadi.Size = new System.Drawing.Size(156, 20);
            this.txtdoktorKadi.TabIndex = 2;
            // 
            // txtdoktorSifre
            // 
            this.txtdoktorSifre.Location = new System.Drawing.Point(107, 69);
            this.txtdoktorSifre.Name = "txtdoktorSifre";
            this.txtdoktorSifre.Size = new System.Drawing.Size(156, 20);
            this.txtdoktorSifre.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "SİFRE :";
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.Location = new System.Drawing.Point(24, 133);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(107, 23);
            this.btnGirisYap.TabIndex = 5;
            this.btnGirisYap.Text = "GİRİŞ YAP";
            this.btnGirisYap.UseVisualStyleBackColor = true;
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            // 
            // btnGeriDön
            // 
            this.btnGeriDön.Location = new System.Drawing.Point(191, 133);
            this.btnGeriDön.Name = "btnGeriDön";
            this.btnGeriDön.Size = new System.Drawing.Size(107, 23);
            this.btnGeriDön.TabIndex = 6;
            this.btnGeriDön.Text = "GERİ DÖN";
            this.btnGeriDön.UseVisualStyleBackColor = true;
            this.btnGeriDön.Click += new System.EventHandler(this.btnGeriDön_Click);
            // 
            // DoktorLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 199);
            this.ControlBox = false;
            this.Controls.Add(this.btnGeriDön);
            this.Controls.Add(this.btnGirisYap);
            this.Controls.Add(this.txtdoktorSifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtdoktorKadi);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DoktorLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DOKTOR GİRİŞİ";
            this.Load += new System.EventHandler(this.DoktorLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtdoktorKadi;
        private System.Windows.Forms.TextBox txtdoktorSifre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGirisYap;
        private System.Windows.Forms.Button btnGeriDön;
    }
}