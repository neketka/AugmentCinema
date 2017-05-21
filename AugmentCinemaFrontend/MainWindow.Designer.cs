namespace AugmentCinemaFrontend
{
    partial class MainWindow
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TakePictureButton = new System.Windows.Forms.Button();
            this.TakeVideoButton = new System.Windows.Forms.Button();
            this.objectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newObjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveSceneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenObjectLibraryButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 239);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(493, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.objectToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(493, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(345, 215);
            this.panel1.TabIndex = 2;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveSceneToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.createToolStripMenuItem.Text = "New Scene";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Open Scene";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.OpenObjectLibraryButton);
            this.panel2.Controls.Add(this.TakeVideoButton);
            this.panel2.Controls.Add(this.TakePictureButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(345, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(148, 215);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // TakePictureButton
            // 
            this.TakePictureButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.TakePictureButton.Location = new System.Drawing.Point(0, 0);
            this.TakePictureButton.Name = "TakePictureButton";
            this.TakePictureButton.Size = new System.Drawing.Size(148, 23);
            this.TakePictureButton.TabIndex = 0;
            this.TakePictureButton.Text = "Take picture";
            this.TakePictureButton.UseVisualStyleBackColor = true;
            this.TakePictureButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // TakeVideoButton
            // 
            this.TakeVideoButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.TakeVideoButton.Location = new System.Drawing.Point(0, 23);
            this.TakeVideoButton.Name = "TakeVideoButton";
            this.TakeVideoButton.Size = new System.Drawing.Size(148, 30);
            this.TakeVideoButton.TabIndex = 0;
            this.TakeVideoButton.Text = "Take Video";
            this.TakeVideoButton.UseVisualStyleBackColor = true;
            // 
            // objectToolStripMenuItem
            // 
            this.objectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newObjectToolStripMenuItem});
            this.objectToolStripMenuItem.Name = "objectToolStripMenuItem";
            this.objectToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.objectToolStripMenuItem.Text = "Object";
            // 
            // newObjectToolStripMenuItem
            // 
            this.newObjectToolStripMenuItem.Name = "newObjectToolStripMenuItem";
            this.newObjectToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newObjectToolStripMenuItem.Text = "Import Object";
            this.newObjectToolStripMenuItem.Click += new System.EventHandler(this.newObjectToolStripMenuItem_Click);
            // 
            // saveSceneToolStripMenuItem
            // 
            this.saveSceneToolStripMenuItem.Name = "saveSceneToolStripMenuItem";
            this.saveSceneToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveSceneToolStripMenuItem.Text = "Save Scene";
            // 
            // OpenObjectLibraryButton
            // 
            this.OpenObjectLibraryButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.OpenObjectLibraryButton.Location = new System.Drawing.Point(0, 53);
            this.OpenObjectLibraryButton.Name = "OpenObjectLibraryButton";
            this.OpenObjectLibraryButton.Size = new System.Drawing.Size(148, 23);
            this.OpenObjectLibraryButton.TabIndex = 1;
            this.OpenObjectLibraryButton.Text = "Open Object Library";
            this.OpenObjectLibraryButton.UseVisualStyleBackColor = true;
            this.OpenObjectLibraryButton.Click += new System.EventHandler(this.OpenObjectLibraryButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 261);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "Augment Cinema";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem objectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newObjectToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button TakeVideoButton;
        private System.Windows.Forms.Button TakePictureButton;
        private System.Windows.Forms.ToolStripMenuItem saveSceneToolStripMenuItem;
        private System.Windows.Forms.Button OpenObjectLibraryButton;
    }
}

