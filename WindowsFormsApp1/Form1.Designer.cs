namespace WindowsFormsApp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.rbtnMass = new System.Windows.Forms.RadioButton();
            this.rbtnLength = new System.Windows.Forms.RadioButton();
            this.gbConventerType = new System.Windows.Forms.GroupBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.gbConventerType.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(151, 163);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(163, 22);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(151, 208);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(163, 22);
            this.textBox2.TabIndex = 3;
            // 
            // rbtnMass
            // 
            this.rbtnMass.AutoSize = true;
            this.rbtnMass.Location = new System.Drawing.Point(6, 28);
            this.rbtnMass.Name = "rbtnMass";
            this.rbtnMass.Size = new System.Drawing.Size(62, 21);
            this.rbtnMass.TabIndex = 4;
            this.rbtnMass.TabStop = true;
            this.rbtnMass.Text = "Mass";
            this.rbtnMass.UseVisualStyleBackColor = true;
            this.rbtnMass.CheckedChanged += new System.EventHandler(this.RbtnMass_CheckedChanged);
            // 
            // rbtnLength
            // 
            this.rbtnLength.AutoSize = true;
            this.rbtnLength.Location = new System.Drawing.Point(6, 55);
            this.rbtnLength.Name = "rbtnLength";
            this.rbtnLength.Size = new System.Drawing.Size(73, 21);
            this.rbtnLength.TabIndex = 5;
            this.rbtnLength.TabStop = true;
            this.rbtnLength.Text = "Length";
            this.rbtnLength.UseVisualStyleBackColor = true;
            this.rbtnLength.CheckedChanged += new System.EventHandler(this.RbtnLength_CheckedChanged);
            // 
            // gbConventerType
            // 
            this.gbConventerType.Controls.Add(this.rbtnMass);
            this.gbConventerType.Controls.Add(this.rbtnLength);
            this.gbConventerType.Location = new System.Drawing.Point(46, 27);
            this.gbConventerType.Name = "gbConventerType";
            this.gbConventerType.Size = new System.Drawing.Size(200, 100);
            this.gbConventerType.TabIndex = 6;
            this.gbConventerType.TabStop = false;
            this.gbConventerType.Text = "Conventer type";
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(239, 266);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 7;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.BtnConvert_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 389);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.gbConventerType);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbConventerType.ResumeLayout(false);
            this.gbConventerType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RadioButton rbtnMass;
        private System.Windows.Forms.RadioButton rbtnLength;
        private System.Windows.Forms.GroupBox gbConventerType;
        private System.Windows.Forms.Button btnConvert;
    }
}

