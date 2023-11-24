namespace Практична_3
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
            btnSelectFile = new Button();
            btnSaveXml = new Button();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            txtXmlContent = new TextBox();
            txtInputText = new TextBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnSelectFile
            // 
            btnSelectFile.Location = new Point(12, 12);
            btnSelectFile.Name = "btnSelectFile";
            btnSelectFile.Size = new Size(377, 23);
            btnSelectFile.TabIndex = 0;
            btnSelectFile.Text = "Обрати файл";
            btnSelectFile.UseVisualStyleBackColor = true;
            btnSelectFile.Click += btnSelectFile_Click;
            // 
            // btnSaveXml
            // 
            btnSaveXml.Location = new Point(428, 415);
            btnSaveXml.Name = "btnSaveXml";
            btnSaveXml.Size = new Size(377, 23);
            btnSaveXml.TabIndex = 1;
            btnSaveXml.Text = "Зберегти файл";
            btnSaveXml.UseVisualStyleBackColor = true;
            btnSaveXml.Click += btnSaveXml_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtXmlContent
            // 
            txtXmlContent.Enabled = false;
            txtXmlContent.Location = new Point(12, 41);
            txtXmlContent.Multiline = true;
            txtXmlContent.Name = "txtXmlContent";
            txtXmlContent.ReadOnly = true;
            txtXmlContent.Size = new Size(377, 397);
            txtXmlContent.TabIndex = 2;
            // 
            // txtInputText
            // 
            txtInputText.Location = new Point(428, 63);
            txtInputText.Multiline = true;
            txtInputText.Name = "txtInputText";
            txtInputText.Size = new Size(377, 346);
            txtInputText.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.image_2023_11_18_21_35_471;
            pictureBox1.Location = new Point(393, -37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(31, 519);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label1.Location = new Point(450, 12);
            label1.Name = "label1";
            label1.Size = new Size(334, 37);
            label1.TabIndex = 5;
            label1.Text = "Введiть щось нижче...";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(817, 450);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(txtInputText);
            Controls.Add(txtXmlContent);
            Controls.Add(btnSaveXml);
            Controls.Add(btnSelectFile);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSelectFile;
        private Button btnSaveXml;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private TextBox txtXmlContent;
        private TextBox txtInputText;
        private PictureBox pictureBox1;
        private Label label1;
    }
}
