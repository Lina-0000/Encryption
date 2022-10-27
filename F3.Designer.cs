
namespace LR1
{
    partial class F3
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
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textRez = new System.Windows.Forms.TextBox();
            this.textInit = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.deShifr = new System.Windows.Forms.RadioButton();
            this.shifr = new System.Windows.Forms.RadioButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 34);
            this.button2.TabIndex = 31;
            this.button2.Text = "Select a file";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(469, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 25);
            this.label3.TabIndex = 30;
            this.label3.Text = "Result:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 29;
            this.label2.Text = "Source text:";
            // 
            // textRez
            // 
            this.textRez.Location = new System.Drawing.Point(469, 40);
            this.textRez.Multiline = true;
            this.textRez.Name = "textRez";
            this.textRez.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textRez.Size = new System.Drawing.Size(270, 398);
            this.textRez.TabIndex = 28;
            // 
            // textInit
            // 
            this.textInit.Location = new System.Drawing.Point(187, 40);
            this.textInit.Multiline = true;
            this.textInit.Name = "textInit";
            this.textInit.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textInit.Size = new System.Drawing.Size(270, 398);
            this.textInit.TabIndex = 27;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 34);
            this.button1.TabIndex = 26;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // deShifr
            // 
            this.deShifr.AutoSize = true;
            this.deShifr.Location = new System.Drawing.Point(12, 87);
            this.deShifr.Name = "deShifr";
            this.deShifr.Size = new System.Drawing.Size(99, 29);
            this.deShifr.TabIndex = 25;
            this.deShifr.TabStop = true;
            this.deShifr.Text = "Decrypt";
            this.deShifr.UseVisualStyleBackColor = true;
            // 
            // shifr
            // 
            this.shifr.AutoSize = true;
            this.shifr.Location = new System.Drawing.Point(12, 52);
            this.shifr.Name = "shifr";
            this.shifr.Size = new System.Drawing.Size(96, 29);
            this.shifr.TabIndex = 24;
            this.shifr.TabStop = true;
            this.shifr.Text = "Encrypt";
            this.shifr.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // F3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textRez);
            this.Controls.Add(this.textInit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.deShifr);
            this.Controls.Add(this.shifr);
            this.Name = "F3";
            this.Text = "Trithemius cipher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textRez;
        private System.Windows.Forms.TextBox textInit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton deShifr;
        private System.Windows.Forms.RadioButton shifr;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}