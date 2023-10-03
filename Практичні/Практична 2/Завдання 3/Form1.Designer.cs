namespace Завдання_3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            txtSentence = new TextBox();
            txtMaxWordLength = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 118);
            button1.Name = "button1";
            button1.Size = new Size(280, 55);
            button1.TabIndex = 0;
            button1.Text = "Надрукуй...";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtSentence
            // 
            txtSentence.Location = new Point(11, 32);
            txtSentence.Name = "txtSentence";
            txtSentence.Size = new Size(281, 27);
            txtSentence.TabIndex = 1;
            // 
            // txtMaxWordLength
            // 
            txtMaxWordLength.Location = new Point(13, 85);
            txtMaxWordLength.Name = "txtMaxWordLength";
            txtMaxWordLength.Size = new Size(280, 27);
            txtMaxWordLength.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 9);
            label1.Name = "label1";
            label1.Size = new Size(168, 20);
            label1.TabIndex = 3;
            label1.Text = "Для введення речення";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 62);
            label2.Name = "label2";
            label2.Size = new Size(149, 20);
            label2.TabIndex = 4;
            label2.Text = "Для введення числа";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 185);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtMaxWordLength);
            Controls.Add(txtSentence);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txtSentence;
        private TextBox txtMaxWordLength;
        private Label label1;
        private Label label2;
    }
}