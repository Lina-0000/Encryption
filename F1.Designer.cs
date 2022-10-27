
namespace LR1
{
    partial class F1
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
            this.shifr = new System.Windows.Forms.RadioButton();
            this.deShifr = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.textInit = new System.Windows.Forms.TextBox();
            this.textRez = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // shifr
            // 
            this.shifr.AutoSize = true;
            this.shifr.Location = new System.Drawing.Point(13, 52);
            this.shifr.Name = "shifr";
            this.shifr.Size = new System.Drawing.Size(96, 29);
            this.shifr.TabIndex = 0;
            this.shifr.TabStop = true;
            this.shifr.Text = "Encrypt";
            this.shifr.UseVisualStyleBackColor = true;
            // 
            // deShifr
            // 
            this.deShifr.AutoSize = true;
            this.deShifr.Location = new System.Drawing.Point(13, 87);
            this.deShifr.Name = "deShifr";
            this.deShifr.Size = new System.Drawing.Size(99, 29);
            this.deShifr.TabIndex = 1;
            this.deShifr.TabStop = true;
            this.deShifr.Text = "Decrypt";
            this.deShifr.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textInit
            // 
            this.textInit.Location = new System.Drawing.Point(188, 40);
            this.textInit.Multiline = true;
            this.textInit.Name = "textInit";
            this.textInit.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textInit.Size = new System.Drawing.Size(270, 398);
            this.textInit.TabIndex = 4;
            // 
            // textRez
            // 
            this.textRez.Location = new System.Drawing.Point(470, 40);
            this.textRez.Multiline = true;
            this.textRez.Name = "textRez";
            this.textRez.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textRez.Size = new System.Drawing.Size(270, 398);
            this.textRez.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Source text:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(470, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Result:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(75, 122);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(86, 31);
            this.numericUpDown1.TabIndex = 10;
            this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Key:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 34);
            this.button2.TabIndex = 13;
            this.button2.Text = "Select a file";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // F1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textRez);
            this.Controls.Add(this.textInit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.deShifr);
            this.Controls.Add(this.shifr);
            this.Name = "F1";
            this.Text = "Caesar cipher";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton shifr;
        private System.Windows.Forms.RadioButton deShifr;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textInit;
        private System.Windows.Forms.TextBox textRez;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}