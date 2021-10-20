
namespace Odev4
{
    partial class Form56
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
            this.btnasalSayiKontrol = new System.Windows.Forms.Button();
            this.txtSayi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnasalSayiKontrol
            // 
            this.btnasalSayiKontrol.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnasalSayiKontrol.Location = new System.Drawing.Point(324, 185);
            this.btnasalSayiKontrol.Name = "btnasalSayiKontrol";
            this.btnasalSayiKontrol.Size = new System.Drawing.Size(117, 41);
            this.btnasalSayiKontrol.TabIndex = 0;
            this.btnasalSayiKontrol.Text = "Kontrol Et";
            this.btnasalSayiKontrol.UseVisualStyleBackColor = false;
            this.btnasalSayiKontrol.Click += new System.EventHandler(this.btnasalSayiKontrol_Click);
            // 
            // txtSayi
            // 
            this.txtSayi.Location = new System.Drawing.Point(233, 115);
            this.txtSayi.Name = "txtSayi";
            this.txtSayi.Size = new System.Drawing.Size(290, 22);
            this.txtSayi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(230, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lütfen bir sayı giriniz:";
            // 
            // Form56
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSayi);
            this.Controls.Add(this.btnasalSayiKontrol);
            this.Name = "Form56";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnasalSayiKontrol;
        private System.Windows.Forms.TextBox txtSayi;
        private System.Windows.Forms.Label label1;
    }
}

