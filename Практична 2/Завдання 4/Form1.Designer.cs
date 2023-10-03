namespace Завдання_4
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
            txtSentence = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtSentence
            // 
            txtSentence.Location = new Point(12, 12);
            txtSentence.Name = "txtSentence";
            txtSentence.Size = new Size(293, 27);
            txtSentence.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(12, 45);
            button1.Name = "button1";
            button1.Size = new Size(293, 29);
            button1.TabIndex = 1;
            button1.Text = "Сформувати...";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(320, 85);
            Controls.Add(button1);
            Controls.Add(txtSentence);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSentence;
        private Button button1;
    }
}