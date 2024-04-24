namespace Paperman
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            listFilesButton = new Button();
            addFileButton = new Button();
            removeFileButton = new Button();
            jsButton = new Button();
            cssButton = new Button();
            htmlButton = new Button();
            phpButton = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(315, 76);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.BackColor = Color.OrangeRed;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(315, 76);
            label1.TabIndex = 0;
            label1.Text = "P A P E R M A N";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SteelBlue;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 76);
            panel2.Name = "panel2";
            panel2.Size = new Size(315, 1);
            panel2.TabIndex = 1;
            // 
            // listFilesButton
            // 
            listFilesButton.BackColor = Color.Tomato;
            listFilesButton.Dock = DockStyle.Top;
            listFilesButton.FlatStyle = FlatStyle.Flat;
            listFilesButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listFilesButton.ForeColor = Color.Blue;
            listFilesButton.Image = Paperman_Resources.icons8_file_25px;
            listFilesButton.ImageAlign = ContentAlignment.MiddleRight;
            listFilesButton.Location = new Point(0, 77);
            listFilesButton.Name = "listFilesButton";
            listFilesButton.Padding = new Padding(15, 0, 15, 0);
            listFilesButton.Size = new Size(315, 58);
            listFilesButton.TabIndex = 2;
            listFilesButton.Text = "List Files";
            listFilesButton.TextAlign = ContentAlignment.MiddleLeft;
            listFilesButton.UseVisualStyleBackColor = false;
            listFilesButton.Click += listFilesButton_Click;
            // 
            // addFileButton
            // 
            addFileButton.BackColor = Color.Tomato;
            addFileButton.Dock = DockStyle.Top;
            addFileButton.FlatStyle = FlatStyle.Flat;
            addFileButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addFileButton.ForeColor = Color.Blue;
            addFileButton.Image = Paperman_Resources.icons8_add_file_25px_1;
            addFileButton.ImageAlign = ContentAlignment.MiddleRight;
            addFileButton.Location = new Point(0, 135);
            addFileButton.Name = "addFileButton";
            addFileButton.Padding = new Padding(15, 0, 15, 0);
            addFileButton.Size = new Size(315, 58);
            addFileButton.TabIndex = 3;
            addFileButton.Text = "Add File";
            addFileButton.TextAlign = ContentAlignment.MiddleLeft;
            addFileButton.UseVisualStyleBackColor = false;
            addFileButton.Click += addFileButton_Click;
            // 
            // removeFileButton
            // 
            removeFileButton.BackColor = Color.Tomato;
            removeFileButton.Dock = DockStyle.Top;
            removeFileButton.FlatStyle = FlatStyle.Flat;
            removeFileButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            removeFileButton.ForeColor = Color.Blue;
            removeFileButton.Image = Paperman_Resources.icons8_file_delete_25px;
            removeFileButton.ImageAlign = ContentAlignment.MiddleRight;
            removeFileButton.Location = new Point(0, 193);
            removeFileButton.Name = "removeFileButton";
            removeFileButton.Padding = new Padding(15, 0, 15, 0);
            removeFileButton.Size = new Size(315, 53);
            removeFileButton.TabIndex = 4;
            removeFileButton.Text = "Remove File";
            removeFileButton.TextAlign = ContentAlignment.MiddleLeft;
            removeFileButton.UseVisualStyleBackColor = false;
            removeFileButton.Click += removeFileButton_Click;
            // 
            // jsButton
            // 
            jsButton.BackColor = Color.Tomato;
            jsButton.Dock = DockStyle.Top;
            jsButton.FlatStyle = FlatStyle.Flat;
            jsButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            jsButton.ForeColor = Color.Blue;
            jsButton.Image = Paperman_Resources.icons8_js_25px;
            jsButton.ImageAlign = ContentAlignment.MiddleRight;
            jsButton.Location = new Point(0, 362);
            jsButton.Name = "jsButton";
            jsButton.Padding = new Padding(15, 0, 15, 0);
            jsButton.Size = new Size(315, 55);
            jsButton.TabIndex = 7;
            jsButton.Text = "JS File";
            jsButton.TextAlign = ContentAlignment.MiddleLeft;
            jsButton.UseVisualStyleBackColor = false;
            jsButton.Click += jsButton_Click;
            // 
            // cssButton
            // 
            cssButton.BackColor = Color.Tomato;
            cssButton.Dock = DockStyle.Top;
            cssButton.FlatStyle = FlatStyle.Flat;
            cssButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cssButton.ForeColor = Color.Blue;
            cssButton.Image = Paperman_Resources.icons8_css_25px;
            cssButton.ImageAlign = ContentAlignment.MiddleRight;
            cssButton.Location = new Point(0, 304);
            cssButton.Name = "cssButton";
            cssButton.Padding = new Padding(15, 0, 15, 0);
            cssButton.Size = new Size(315, 58);
            cssButton.TabIndex = 6;
            cssButton.Text = "CSS File";
            cssButton.TextAlign = ContentAlignment.MiddleLeft;
            cssButton.UseVisualStyleBackColor = false;
            cssButton.Click += cssButton_Click;
            // 
            // htmlButton
            // 
            htmlButton.BackColor = Color.Tomato;
            htmlButton.Dock = DockStyle.Top;
            htmlButton.FlatStyle = FlatStyle.Flat;
            htmlButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            htmlButton.ForeColor = Color.Blue;
            htmlButton.Image = Paperman_Resources.icons8_html_25px;
            htmlButton.ImageAlign = ContentAlignment.MiddleRight;
            htmlButton.Location = new Point(0, 246);
            htmlButton.Name = "htmlButton";
            htmlButton.Padding = new Padding(15, 0, 15, 0);
            htmlButton.Size = new Size(315, 58);
            htmlButton.TabIndex = 5;
            htmlButton.Text = "HTML File";
            htmlButton.TextAlign = ContentAlignment.MiddleLeft;
            htmlButton.UseVisualStyleBackColor = false;
            htmlButton.Click += htmlButton_Click;
            // 
            // phpButton
            // 
            phpButton.BackColor = Color.Tomato;
            phpButton.Dock = DockStyle.Top;
            phpButton.FlatStyle = FlatStyle.Flat;
            phpButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            phpButton.ForeColor = Color.Blue;
            phpButton.Image = Paperman_Resources.icons8_php_25px;
            phpButton.ImageAlign = ContentAlignment.MiddleRight;
            phpButton.Location = new Point(0, 417);
            phpButton.Name = "phpButton";
            phpButton.Padding = new Padding(15, 0, 15, 0);
            phpButton.Size = new Size(315, 55);
            phpButton.TabIndex = 8;
            phpButton.Text = "PHP File";
            phpButton.TextAlign = ContentAlignment.MiddleLeft;
            phpButton.UseVisualStyleBackColor = false;
            phpButton.Click += phpButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(315, 470);
            Controls.Add(phpButton);
            Controls.Add(jsButton);
            Controls.Add(cssButton);
            Controls.Add(htmlButton);
            Controls.Add(removeFileButton);
            Controls.Add(addFileButton);
            Controls.Add(listFilesButton);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Paperman";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Button listFilesButton;
        private Button addFileButton;
        private Button removeFileButton;
        private Button jsButton;
        private Button cssButton;
        private Button htmlButton;
        private Button phpButton;
    }
}
