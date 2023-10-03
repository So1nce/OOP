namespace Завдання_2
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
            txtInput = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 45);
            button1.Name = "button1";
            button1.Size = new Size(252, 29);
            button1.TabIndex = 0;
            button1.Text = "Розрахуй...";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(12, 12);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(252, 27);
            txtInput.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(276, 85);
            Controls.Add(txtInput);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txtInput;
    }
}