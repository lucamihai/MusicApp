namespace MusicApp
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
            this.panelFiles = new System.Windows.Forms.Panel();
            this.buttonAddFiles = new System.Windows.Forms.Button();
            this.buttonRemoveSelected = new System.Windows.Forms.Button();
            this.buttonRemoveAll = new System.Windows.Forms.Button();
            this.buttonOpenFolder = new System.Windows.Forms.Button();
            this.buttonSelectDestination = new System.Windows.Forms.Button();
            this.textBoxDestination = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // panelFiles
            // 
            this.panelFiles.AutoScroll = true;
            this.panelFiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelFiles.Location = new System.Drawing.Point(23, 175);
            this.panelFiles.Name = "panelFiles";
            this.panelFiles.Size = new System.Drawing.Size(742, 457);
            this.panelFiles.TabIndex = 0;
            // 
            // buttonAddFiles
            // 
            this.buttonAddFiles.Location = new System.Drawing.Point(23, 27);
            this.buttonAddFiles.Name = "buttonAddFiles";
            this.buttonAddFiles.Size = new System.Drawing.Size(75, 23);
            this.buttonAddFiles.TabIndex = 1;
            this.buttonAddFiles.Text = "Add files";
            this.buttonAddFiles.UseVisualStyleBackColor = true;
            this.buttonAddFiles.Click += new System.EventHandler(this.buttonAddFiles_Click);
            // 
            // buttonRemoveSelected
            // 
            this.buttonRemoveSelected.Enabled = false;
            this.buttonRemoveSelected.Location = new System.Drawing.Point(23, 101);
            this.buttonRemoveSelected.Name = "buttonRemoveSelected";
            this.buttonRemoveSelected.Size = new System.Drawing.Size(106, 23);
            this.buttonRemoveSelected.TabIndex = 2;
            this.buttonRemoveSelected.Text = "Remove selected";
            this.buttonRemoveSelected.UseVisualStyleBackColor = true;
            this.buttonRemoveSelected.Click += new System.EventHandler(this.buttonRemoveSelected_Click);
            // 
            // buttonRemoveAll
            // 
            this.buttonRemoveAll.Enabled = false;
            this.buttonRemoveAll.Location = new System.Drawing.Point(135, 101);
            this.buttonRemoveAll.Name = "buttonRemoveAll";
            this.buttonRemoveAll.Size = new System.Drawing.Size(75, 23);
            this.buttonRemoveAll.TabIndex = 3;
            this.buttonRemoveAll.Text = "Remove all";
            this.buttonRemoveAll.UseVisualStyleBackColor = true;
            this.buttonRemoveAll.Click += new System.EventHandler(this.buttonRemoveAll_Click);
            // 
            // buttonOpenFolder
            // 
            this.buttonOpenFolder.Location = new System.Drawing.Point(23, 56);
            this.buttonOpenFolder.Name = "buttonOpenFolder";
            this.buttonOpenFolder.Size = new System.Drawing.Size(75, 23);
            this.buttonOpenFolder.TabIndex = 4;
            this.buttonOpenFolder.Text = "Open folder";
            this.buttonOpenFolder.UseVisualStyleBackColor = true;
            // 
            // buttonSelectDestination
            // 
            this.buttonSelectDestination.Location = new System.Drawing.Point(814, 30);
            this.buttonSelectDestination.Name = "buttonSelectDestination";
            this.buttonSelectDestination.Size = new System.Drawing.Size(101, 23);
            this.buttonSelectDestination.TabIndex = 5;
            this.buttonSelectDestination.Text = "Select destination";
            this.buttonSelectDestination.UseVisualStyleBackColor = true;
            this.buttonSelectDestination.Click += new System.EventHandler(this.buttonSelectDestination_Click);
            // 
            // textBoxDestination
            // 
            this.textBoxDestination.Location = new System.Drawing.Point(814, 59);
            this.textBoxDestination.Multiline = true;
            this.textBoxDestination.Name = "textBoxDestination";
            this.textBoxDestination.ReadOnly = true;
            this.textBoxDestination.Size = new System.Drawing.Size(366, 20);
            this.textBoxDestination.TabIndex = 6;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.textBoxDestination);
            this.Controls.Add(this.buttonSelectDestination);
            this.Controls.Add(this.buttonOpenFolder);
            this.Controls.Add(this.buttonRemoveAll);
            this.Controls.Add(this.buttonRemoveSelected);
            this.Controls.Add(this.buttonAddFiles);
            this.Controls.Add(this.panelFiles);
            this.Name = "MainWindow";
            this.Text = "Music app";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelFiles;
        private System.Windows.Forms.Button buttonAddFiles;
        private System.Windows.Forms.Button buttonRemoveSelected;
        private System.Windows.Forms.Button buttonRemoveAll;
        private System.Windows.Forms.Button buttonOpenFolder;
        private System.Windows.Forms.Button buttonSelectDestination;
        private System.Windows.Forms.TextBox textBoxDestination;
    }
}

