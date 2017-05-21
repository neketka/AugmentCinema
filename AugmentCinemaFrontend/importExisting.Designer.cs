namespace AugmentCinemaFrontend
{
    partial class importExisting
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
            this.ImportDialog = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.openImportButton = new System.Windows.Forms.Button();
            this.cancelImport = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ImportDialog
            // 
            this.ImportDialog.FileName = "ImportExisting";
            this.ImportDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cancelImport);
            this.panel1.Controls.Add(this.openImportButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 220);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 41);
            this.panel1.TabIndex = 0;
            // 
            // openImportButton
            // 
            this.openImportButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.openImportButton.Location = new System.Drawing.Point(145, 0);
            this.openImportButton.Name = "openImportButton";
            this.openImportButton.Size = new System.Drawing.Size(139, 41);
            this.openImportButton.TabIndex = 0;
            this.openImportButton.Text = "Open";
            this.openImportButton.UseVisualStyleBackColor = true;
            // 
            // cancelImport
            // 
            this.cancelImport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cancelImport.Location = new System.Drawing.Point(0, 0);
            this.cancelImport.Name = "cancelImport";
            this.cancelImport.Size = new System.Drawing.Size(145, 41);
            this.cancelImport.TabIndex = 1;
            this.cancelImport.Text = "Cancel";
            this.cancelImport.UseVisualStyleBackColor = true;
            // 
            // importExisting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.panel1);
            this.Name = "importExisting";
            this.Text = "Import Scene";
            this.Load += new System.EventHandler(this.importExisting_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ImportDialog;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cancelImport;
        private System.Windows.Forms.Button openImportButton;
    }
}