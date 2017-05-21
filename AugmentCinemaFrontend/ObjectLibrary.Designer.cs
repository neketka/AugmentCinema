namespace AugmentCinemaFrontend
{
    partial class ObjectLibrary
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
            this.scrollWindow = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.scroller = new System.Windows.Forms.HScrollBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.importButton = new System.Windows.Forms.Button();
            this.importCancelButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.scrollWindow.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // scrollWindow
            // 
            this.scrollWindow.BackColor = System.Drawing.SystemColors.ControlDark;
            this.scrollWindow.Controls.Add(this.panel3);
            this.scrollWindow.Controls.Add(this.panel2);
            this.scrollWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scrollWindow.Location = new System.Drawing.Point(0, 0);
            this.scrollWindow.Margin = new System.Windows.Forms.Padding(8);
            this.scrollWindow.Name = "scrollWindow";
            this.scrollWindow.Size = new System.Drawing.Size(527, 214);
            this.scrollWindow.TabIndex = 0;
            this.scrollWindow.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.scroller);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 163);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(527, 19);
            this.panel3.TabIndex = 1;
            // 
            // scroller
            // 
            this.scroller.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scroller.Location = new System.Drawing.Point(0, 0);
            this.scroller.Name = "scroller";
            this.scroller.Size = new System.Drawing.Size(527, 19);
            this.scroller.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.importCancelButton);
            this.panel2.Controls.Add(this.importButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 182);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(527, 32);
            this.panel2.TabIndex = 0;
            // 
            // importButton
            // 
            this.importButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.importButton.Location = new System.Drawing.Point(0, 0);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(264, 32);
            this.importButton.TabIndex = 1;
            this.importButton.Text = "Import";
            this.importButton.UseVisualStyleBackColor = true;
            this.importButton.Click += new System.EventHandler(this.importButton_Click);
            // 
            // importCancelButton
            // 
            this.importCancelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.importCancelButton.Location = new System.Drawing.Point(264, 0);
            this.importCancelButton.Name = "importCancelButton";
            this.importCancelButton.Size = new System.Drawing.Size(263, 32);
            this.importCancelButton.TabIndex = 2;
            this.importCancelButton.Text = "Cancel";
            this.importCancelButton.UseVisualStyleBackColor = true;
            this.importCancelButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ObjectLibrary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 214);
            this.Controls.Add(this.scrollWindow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ObjectLibrary";
            this.Text = "Object Library";
            this.Load += new System.EventHandler(this.ObjectLibrary_Load);
            this.scrollWindow.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel scrollWindow;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.HScrollBar scroller;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button importButton;
        private System.Windows.Forms.Button importCancelButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}