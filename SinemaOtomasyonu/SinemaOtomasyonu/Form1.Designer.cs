
namespace SinemaOtomasyonu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.flpKoltuklar = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.pbDolu = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pbBos = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDolu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(578, 68);
            this.panel1.TabIndex = 1;
            // 
            // flpKoltuklar
            // 
            this.flpKoltuklar.Location = new System.Drawing.Point(0, 114);
            this.flpKoltuklar.Name = "flpKoltuklar";
            this.flpKoltuklar.Size = new System.Drawing.Size(578, 397);
            this.flpKoltuklar.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(98, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "SİNEMA OTOMASYONU";
            // 
            // pbDolu
            // 
            this.pbDolu.Location = new System.Drawing.Point(493, 450);
            this.pbDolu.Name = "pbDolu";
            this.pbDolu.Size = new System.Drawing.Size(60, 50);
            this.pbDolu.TabIndex = 3;
            this.pbDolu.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(441, 464);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Dolu";
            // 
            // pbBos
            // 
            this.pbBos.Location = new System.Drawing.Point(377, 450);
            this.pbBos.Name = "pbBos";
            this.pbBos.Size = new System.Drawing.Size(60, 50);
            this.pbBos.TabIndex = 3;
            this.pbBos.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(328, 464);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Boş";
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 512);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pbBos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbDolu);
            this.Controls.Add(this.flpKoltuklar);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDolu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flpKoltuklar;
        private System.Windows.Forms.PictureBox pbDolu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbBos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
    }
}

