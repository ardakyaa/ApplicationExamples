
namespace StringExtensionMethods
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
            this.txtMetin = new System.Windows.Forms.TextBox();
            this.btnStartsWith = new System.Windows.Forms.Button();
            this.txtIfade = new System.Windows.Forms.TextBox();
            this.btnContains = new System.Windows.Forms.Button();
            this.btnCompareTo = new System.Windows.Forms.Button();
            this.btnIndexOf = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnLastIndexOf = new System.Windows.Forms.Button();
            this.btnReplace = new System.Windows.Forms.Button();
            this.txtYeniIfade = new System.Windows.Forms.TextBox();
            this.btnSplit = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnSubString = new System.Windows.Forms.Button();
            this.btnEndWith = new System.Windows.Forms.Button();
            this.btnToCharArray = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMetin
            // 
            this.txtMetin.Location = new System.Drawing.Point(64, 12);
            this.txtMetin.Multiline = true;
            this.txtMetin.Name = "txtMetin";
            this.txtMetin.Size = new System.Drawing.Size(610, 121);
            this.txtMetin.TabIndex = 0;
            // 
            // btnStartsWith
            // 
            this.btnStartsWith.Location = new System.Drawing.Point(281, 215);
            this.btnStartsWith.Name = "btnStartsWith";
            this.btnStartsWith.Size = new System.Drawing.Size(176, 38);
            this.btnStartsWith.TabIndex = 1;
            this.btnStartsWith.Text = "Starts With";
            this.btnStartsWith.UseVisualStyleBackColor = true;
            this.btnStartsWith.Click += new System.EventHandler(this.btnStartsWith_Click);
            // 
            // txtIfade
            // 
            this.txtIfade.Location = new System.Drawing.Point(64, 139);
            this.txtIfade.Name = "txtIfade";
            this.txtIfade.Size = new System.Drawing.Size(610, 22);
            this.txtIfade.TabIndex = 2;
            // 
            // btnContains
            // 
            this.btnContains.BackColor = System.Drawing.Color.Red;
            this.btnContains.Location = new System.Drawing.Point(64, 215);
            this.btnContains.Name = "btnContains";
            this.btnContains.Size = new System.Drawing.Size(176, 38);
            this.btnContains.TabIndex = 1;
            this.btnContains.Text = "Contains";
            this.btnContains.UseVisualStyleBackColor = false;
            this.btnContains.Click += new System.EventHandler(this.btnContains_Click_1);
            // 
            // btnCompareTo
            // 
            this.btnCompareTo.BackColor = System.Drawing.Color.Red;
            this.btnCompareTo.Location = new System.Drawing.Point(498, 215);
            this.btnCompareTo.Name = "btnCompareTo";
            this.btnCompareTo.Size = new System.Drawing.Size(176, 38);
            this.btnCompareTo.TabIndex = 1;
            this.btnCompareTo.Text = "Compare To";
            this.btnCompareTo.UseVisualStyleBackColor = false;
            this.btnCompareTo.Click += new System.EventHandler(this.btnCompareTo_Click);
            // 
            // btnIndexOf
            // 
            this.btnIndexOf.Location = new System.Drawing.Point(64, 259);
            this.btnIndexOf.Name = "btnIndexOf";
            this.btnIndexOf.Size = new System.Drawing.Size(176, 38);
            this.btnIndexOf.TabIndex = 1;
            this.btnIndexOf.Text = "Index Of";
            this.btnIndexOf.UseVisualStyleBackColor = true;
            this.btnIndexOf.Click += new System.EventHandler(this.btnIndexOf_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(498, 259);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(176, 38);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnLastIndexOf
            // 
            this.btnLastIndexOf.Location = new System.Drawing.Point(281, 259);
            this.btnLastIndexOf.Name = "btnLastIndexOf";
            this.btnLastIndexOf.Size = new System.Drawing.Size(176, 38);
            this.btnLastIndexOf.TabIndex = 1;
            this.btnLastIndexOf.Text = "LastIndexOf";
            this.btnLastIndexOf.UseVisualStyleBackColor = true;
            this.btnLastIndexOf.Click += new System.EventHandler(this.btnLastIndexOf_Click);
            // 
            // btnReplace
            // 
            this.btnReplace.BackColor = System.Drawing.Color.Red;
            this.btnReplace.Location = new System.Drawing.Point(64, 303);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(176, 38);
            this.btnReplace.TabIndex = 1;
            this.btnReplace.Text = "Replace";
            this.btnReplace.UseVisualStyleBackColor = false;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // txtYeniIfade
            // 
            this.txtYeniIfade.Location = new System.Drawing.Point(64, 167);
            this.txtYeniIfade.Name = "txtYeniIfade";
            this.txtYeniIfade.Size = new System.Drawing.Size(610, 22);
            this.txtYeniIfade.TabIndex = 2;
            // 
            // btnSplit
            // 
            this.btnSplit.BackColor = System.Drawing.Color.Red;
            this.btnSplit.Location = new System.Drawing.Point(281, 303);
            this.btnSplit.Name = "btnSplit";
            this.btnSplit.Size = new System.Drawing.Size(176, 38);
            this.btnSplit.TabIndex = 1;
            this.btnSplit.Text = "Split";
            this.btnSplit.UseVisualStyleBackColor = false;
            this.btnSplit.Click += new System.EventHandler(this.btnSplit_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(498, 303);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(176, 38);
            this.btnInsert.TabIndex = 1;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnSubString
            // 
            this.btnSubString.Location = new System.Drawing.Point(64, 347);
            this.btnSubString.Name = "btnSubString";
            this.btnSubString.Size = new System.Drawing.Size(176, 38);
            this.btnSubString.TabIndex = 1;
            this.btnSubString.Text = "SubString";
            this.btnSubString.UseVisualStyleBackColor = true;
            this.btnSubString.Click += new System.EventHandler(this.btnSubString_Click);
            // 
            // btnEndWith
            // 
            this.btnEndWith.Location = new System.Drawing.Point(498, 347);
            this.btnEndWith.Name = "btnEndWith";
            this.btnEndWith.Size = new System.Drawing.Size(176, 38);
            this.btnEndWith.TabIndex = 1;
            this.btnEndWith.Text = "End With";
            this.btnEndWith.UseVisualStyleBackColor = true;
            this.btnEndWith.Click += new System.EventHandler(this.btnEndWith_Click);
            // 
            // btnToCharArray
            // 
            this.btnToCharArray.Location = new System.Drawing.Point(281, 347);
            this.btnToCharArray.Name = "btnToCharArray";
            this.btnToCharArray.Size = new System.Drawing.Size(176, 38);
            this.btnToCharArray.TabIndex = 1;
            this.btnToCharArray.Text = "ToCharArray";
            this.btnToCharArray.UseVisualStyleBackColor = true;
            this.btnToCharArray.Click += new System.EventHandler(this.btnToCharArray_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtYeniIfade);
            this.Controls.Add(this.txtIfade);
            this.Controls.Add(this.btnLastIndexOf);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnToCharArray);
            this.Controls.Add(this.btnEndWith);
            this.Controls.Add(this.btnSubString);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnSplit);
            this.Controls.Add(this.btnReplace);
            this.Controls.Add(this.btnIndexOf);
            this.Controls.Add(this.btnContains);
            this.Controls.Add(this.btnCompareTo);
            this.Controls.Add(this.btnStartsWith);
            this.Controls.Add(this.txtMetin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMetin;
        private System.Windows.Forms.Button btnStartsWith;
        private System.Windows.Forms.TextBox txtIfade;
        private System.Windows.Forms.Button btnContains;
        private System.Windows.Forms.Button btnCompareTo;
        private System.Windows.Forms.Button btnIndexOf;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnLastIndexOf;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.TextBox txtYeniIfade;
        private System.Windows.Forms.Button btnSplit;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnSubString;
        private System.Windows.Forms.Button btnEndWith;
        private System.Windows.Forms.Button btnToCharArray;
    }
}

