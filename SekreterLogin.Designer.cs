namespace HastahaneRandevuProje
{
    partial class SekreterLogin
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
            this.btnSekreterGirisYap = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSekreterKadi = new System.Windows.Forms.TextBox();
            this.txtSekretersifre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSekreterAnasayfa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSekreterGirisYap
            // 
            this.btnSekreterGirisYap.Location = new System.Drawing.Point(24, 133);
            this.btnSekreterGirisYap.Name = "btnSekreterGirisYap";
            this.btnSekreterGirisYap.Size = new System.Drawing.Size(107, 23);
            this.btnSekreterGirisYap.TabIndex = 0;
            this.btnSekreterGirisYap.Text = "GİRİŞ YAP";
            this.btnSekreterGirisYap.UseVisualStyleBackColor = true;
            this.btnSekreterGirisYap.Click += new System.EventHandler(this.btnSekreterGirisYap_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "KULLANICI \r\nADI :\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtSekreterKadi
            // 
            this.txtSekreterKadi.Location = new System.Drawing.Point(107, 23);
            this.txtSekreterKadi.Name = "txtSekreterKadi";
            this.txtSekreterKadi.Size = new System.Drawing.Size(156, 20);
            this.txtSekreterKadi.TabIndex = 2;
            // 
            // txtSekretersifre
            // 
            this.txtSekretersifre.Location = new System.Drawing.Point(107, 69);
            this.txtSekretersifre.Name = "txtSekretersifre";
            this.txtSekretersifre.Size = new System.Drawing.Size(156, 20);
            this.txtSekretersifre.TabIndex = 4;
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
            // btnSekreterAnasayfa
            // 
            this.btnSekreterAnasayfa.Location = new System.Drawing.Point(191, 133);
            this.btnSekreterAnasayfa.Name = "btnSekreterAnasayfa";
            this.btnSekreterAnasayfa.Size = new System.Drawing.Size(107, 23);
            this.btnSekreterAnasayfa.TabIndex = 5;
            this.btnSekreterAnasayfa.Text = "GERİ DÖN";
            this.btnSekreterAnasayfa.UseVisualStyleBackColor = true;
            this.btnSekreterAnasayfa.Click += new System.EventHandler(this.btnSekreterAnasayfa_Click);
            // 
            // SekreterLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 199);
            this.ControlBox = false;
            this.Controls.Add(this.btnSekreterAnasayfa);
            this.Controls.Add(this.txtSekretersifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSekreterKadi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSekreterGirisYap);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SekreterLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SEKRETER GİRİŞİ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSekreterGirisYap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSekreterKadi;
        private System.Windows.Forms.TextBox txtSekretersifre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSekreterAnasayfa;
    }
}