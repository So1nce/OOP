namespace Практическая1_2_
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
            InputTextBox = new TextBox();
            button1 = new Button();
            ResultTextBox = new Label();
            SuspendLayout();
            // 
            // InputTextBox
            // 
            InputTextBox.Location = new Point(12, 32);
            InputTextBox.Name = "InputTextBox";
            InputTextBox.Size = new Size(214, 27);
            InputTextBox.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(12, 65);
            button1.Name = "button1";
            button1.Size = new Size(214, 29);
            button1.TabIndex = 1;
            button1.Text = "Вiдфiльтрувати";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ResultTextBox
            // 
            ResultTextBox.AutoSize = true;
            ResultTextBox.Location = new Point(12, 9);
            ResultTextBox.Name = "ResultTextBox";
            ResultTextBox.Size = new Size(84, 20);
            ResultTextBox.TabIndex = 2;
            ResultTextBox.Text = "Результат...";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(238, 105);
            Controls.Add(ResultTextBox);
            Controls.Add(button1);
            Controls.Add(InputTextBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox InputTextBox;
        private Button button1;
        private Label ResultTextBox;
    }
}