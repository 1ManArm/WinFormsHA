namespace WinFormsHA
{
    partial class MainForm
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
            textBoxRead = new TextBox();
            buttonLoad = new Button();
            buttonEdit = new Button();
            SuspendLayout();
            // 
            // textBoxRead
            // 
            textBoxRead.Location = new Point(46, 58);
            textBoxRead.Multiline = true;
            textBoxRead.Name = "textBoxRead";
            textBoxRead.ReadOnly = true;
            textBoxRead.Size = new Size(339, 356);
            textBoxRead.TabIndex = 0;
            // 
            // buttonLoad
            // 
            buttonLoad.Location = new Point(412, 58);
            buttonLoad.Name = "buttonLoad";
            buttonLoad.Size = new Size(200, 29);
            buttonLoad.TabIndex = 1;
            buttonLoad.Text = "Загрузить";
            buttonLoad.UseVisualStyleBackColor = true;
            buttonLoad.Click += buttonLoad_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Enabled = false;
            buttonEdit.Location = new Point(412, 93);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(200, 29);
            buttonEdit.TabIndex = 2;
            buttonEdit.Text = "Редактировать";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonEdit);
            Controls.Add(buttonLoad);
            Controls.Add(textBoxRead);
            Name = "MainForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonLoad;
        private Button buttonEdit;
        public TextBox textBoxRead;
    }
}
