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
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveSceneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importExistingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.objectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newObjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.centerPictureButton = new System.Windows.Forms.Button();
            this.openObjectLibraryButton = new System.Windows.Forms.Button();
            this.takeVideoButton = new System.Windows.Forms.Button();
            this.takePictureButton = new System.Windows.Forms.Button();
            this.importButton = new System.Windows.Forms.Button();
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
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveSceneToolStripMenuItem,
            this.importExistingToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.createToolStripMenuItem.Text = "New Scene";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.saveToolStripMenuItem.Text = "Open Scene";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveSceneToolStripMenuItem
            // 
            this.saveSceneToolStripMenuItem.Name = "saveSceneToolStripMenuItem";
            this.saveSceneToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.saveSceneToolStripMenuItem.Text = "Save Scene";
            // 
            // importExistingToolStripMenuItem
            // 
            this.importExistingToolStripMenuItem.Name = "importExistingToolStripMenuItem";
            this.importExistingToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.importExistingToolStripMenuItem.Text = "Import Existing";
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
            this.newObjectToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.newObjectToolStripMenuItem.Text = "Import Object";
            this.newObjectToolStripMenuItem.Click += new System.EventHandler(this.newObjectToolStripMenuItem_Click);
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
            // panel2
            // 
            this.panel2.Controls.Add(this.importButton);
            this.panel2.Controls.Add(this.centerPictureButton);
            this.panel2.Controls.Add(this.openObjectLibraryButton);
            this.panel2.Controls.Add(this.takeVideoButton);
            this.panel2.Controls.Add(this.takePictureButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(345, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(148, 215);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // centerPictureButton
            // 
            this.centerPictureButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.centerPictureButton.Location = new System.Drawing.Point(0, 140);
            this.centerPictureButton.Name = "centerPictureButton";
            this.centerPictureButton.Size = new System.Drawing.Size(148, 23);
            this.centerPictureButton.TabIndex = 2;
            this.centerPictureButton.Text = "Center Picture";
            this.centerPictureButton.UseVisualStyleBackColor = true;
            this.centerPictureButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // openObjectLibraryButton
            // 
            this.openObjectLibraryButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.openObjectLibraryButton.Location = new System.Drawing.Point(0, 163);
            this.openObjectLibraryButton.Name = "openObjectLibraryButton";
            this.openObjectLibraryButton.Size = new System.Drawing.Size(148, 52);
            this.openObjectLibraryButton.TabIndex = 1;
            this.openObjectLibraryButton.Text = "Open Object Library";
            this.openObjectLibraryButton.UseVisualStyleBackColor = true;
            this.openObjectLibraryButton.Click += new System.EventHandler(this.OpenObjectLibraryButton_Click);
            // 
            // takeVideoButton
            // 
            this.takeVideoButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.takeVideoButton.Location = new System.Drawing.Point(0, 52);
            this.takeVideoButton.Name = "takeVideoButton";
            this.takeVideoButton.Size = new System.Drawing.Size(148, 54);
            this.takeVideoButton.TabIndex = 0;
            this.takeVideoButton.Text = "Take Video";
            this.takeVideoButton.UseVisualStyleBackColor = true;
            // 
            // takePictureButton
            // 
            this.takePictureButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.takePictureButton.Location = new System.Drawing.Point(0, 0);
            this.takePictureButton.Name = "takePictureButton";
            this.takePictureButton.Size = new System.Drawing.Size(148, 52);
            this.takePictureButton.TabIndex = 0;
            this.takePictureButton.Text = "Take picture";
            this.takePictureButton.UseVisualStyleBackColor = true;
            this.takePictureButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // importButton
            // 
            this.importButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.importButton.Location = new System.Drawing.Point(0, 106);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(148, 35);
            this.importButton.TabIndex = 3;
            this.importButton.Text = "Import Existing";
            this.importButton.UseVisualStyleBackColor = true;
            this.importButton.Click += new System.EventHandler(this.button1_Click_2);
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
        private System.Windows.Forms.Button takeVideoButton;
        private System.Windows.Forms.Button takePictureButton;
        private System.Windows.Forms.ToolStripMenuItem saveSceneToolStripMenuItem;
        private System.Windows.Forms.Button openObjectLibraryButton;
        private System.Windows.Forms.ToolStripMenuItem importExistingToolStripMenuItem;
        private System.Windows.Forms.Button centerPictureButton;
        private System.Windows.Forms.Button importButton;
    }
}

