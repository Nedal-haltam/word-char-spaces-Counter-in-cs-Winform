namespace Project_Word_Counter_Desktop_App
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
            this.lblword = new System.Windows.Forms.Label();
            this.lblchar = new System.Windows.Forms.Label();
            this.lblspace = new System.Windows.Forms.Label();
            this.lblsentence = new System.Windows.Forms.Label();
            this.tbfield = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblword
            // 
            this.lblword.AutoSize = true;
            this.lblword.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblword.Location = new System.Drawing.Point(169, 95);
            this.lblword.Name = "lblword";
            this.lblword.Size = new System.Drawing.Size(26, 39);
            this.lblword.TabIndex = 0;
            this.lblword.Text = " ";
            // 
            // lblchar
            // 
            this.lblchar.AutoSize = true;
            this.lblchar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblchar.Location = new System.Drawing.Point(408, 95);
            this.lblchar.Name = "lblchar";
            this.lblchar.Size = new System.Drawing.Size(26, 39);
            this.lblchar.TabIndex = 1;
            this.lblchar.Text = " ";
            // 
            // lblspace
            // 
            this.lblspace.AutoSize = true;
            this.lblspace.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblspace.Location = new System.Drawing.Point(634, 95);
            this.lblspace.Name = "lblspace";
            this.lblspace.Size = new System.Drawing.Size(26, 39);
            this.lblspace.TabIndex = 2;
            this.lblspace.Text = " ";
            // 
            // lblsentence
            // 
            this.lblsentence.AutoSize = true;
            this.lblsentence.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsentence.Location = new System.Drawing.Point(857, 95);
            this.lblsentence.Name = "lblsentence";
            this.lblsentence.Size = new System.Drawing.Size(26, 39);
            this.lblsentence.TabIndex = 3;
            this.lblsentence.Text = " ";
            // 
            // tbfield
            // 
            this.tbfield.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbfield.Location = new System.Drawing.Point(43, 174);
            this.tbfield.MaxLength = 1233211;
            this.tbfield.Multiline = true;
            this.tbfield.Name = "tbfield";
            this.tbfield.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbfield.Size = new System.Drawing.Size(1304, 509);
            this.tbfield.TabIndex = 5;
            this.tbfield.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 39);
            this.label1.TabIndex = 6;
            this.label1.Text = "words";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(197, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(292, 39);
            this.label2.TabIndex = 7;
            this.label2.Text = "char (with spaces)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(523, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 39);
            this.label3.TabIndex = 8;
            this.label3.Text = "spaces";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(742, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 39);
            this.label4.TabIndex = 9;
            this.label4.Text = "sentences";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1398, 712);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbfield);
            this.Controls.Add(this.lblsentence);
            this.Controls.Add(this.lblspace);
            this.Controls.Add(this.lblchar);
            this.Controls.Add(this.lblword);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblword;
        private System.Windows.Forms.Label lblchar;
        private System.Windows.Forms.Label lblspace;
        private System.Windows.Forms.Label lblsentence;
        private System.Windows.Forms.TextBox tbfield;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

