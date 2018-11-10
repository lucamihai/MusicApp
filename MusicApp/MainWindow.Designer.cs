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
            this.buttonCreateFiles = new System.Windows.Forms.Button();
            this.buttonSelectAll = new System.Windows.Forms.Button();
            this.buttonDeselect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericBeginFrom = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBoxOverwrite = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericBeginFrom)).BeginInit();
            this.SuspendLayout();
            // 
            // panelFiles
            // 
            this.panelFiles.AutoScroll = true;
            this.panelFiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelFiles.Location = new System.Drawing.Point(23, 179);
            this.panelFiles.Name = "panelFiles";
            this.panelFiles.Size = new System.Drawing.Size(742, 477);
            this.panelFiles.TabIndex = 0;
            // 
            // buttonAddFiles
            // 
            this.buttonAddFiles.Location = new System.Drawing.Point(23, 61);
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
            this.buttonRemoveSelected.Location = new System.Drawing.Point(261, 150);
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
            this.buttonRemoveAll.Location = new System.Drawing.Point(373, 150);
            this.buttonRemoveAll.Name = "buttonRemoveAll";
            this.buttonRemoveAll.Size = new System.Drawing.Size(75, 23);
            this.buttonRemoveAll.TabIndex = 3;
            this.buttonRemoveAll.Text = "Remove all";
            this.buttonRemoveAll.UseVisualStyleBackColor = true;
            this.buttonRemoveAll.Click += new System.EventHandler(this.buttonRemoveAll_Click);
            // 
            // buttonOpenFolder
            // 
            this.buttonOpenFolder.Location = new System.Drawing.Point(23, 90);
            this.buttonOpenFolder.Name = "buttonOpenFolder";
            this.buttonOpenFolder.Size = new System.Drawing.Size(75, 23);
            this.buttonOpenFolder.TabIndex = 4;
            this.buttonOpenFolder.Text = "Open folder";
            this.buttonOpenFolder.UseVisualStyleBackColor = true;
            // 
            // buttonSelectDestination
            // 
            this.buttonSelectDestination.Location = new System.Drawing.Point(803, 75);
            this.buttonSelectDestination.Name = "buttonSelectDestination";
            this.buttonSelectDestination.Size = new System.Drawing.Size(101, 23);
            this.buttonSelectDestination.TabIndex = 5;
            this.buttonSelectDestination.Text = "Select destination";
            this.buttonSelectDestination.UseVisualStyleBackColor = true;
            this.buttonSelectDestination.Click += new System.EventHandler(this.buttonSelectDestination_Click);
            // 
            // textBoxDestination
            // 
            this.textBoxDestination.Location = new System.Drawing.Point(803, 129);
            this.textBoxDestination.Multiline = true;
            this.textBoxDestination.Name = "textBoxDestination";
            this.textBoxDestination.ReadOnly = true;
            this.textBoxDestination.Size = new System.Drawing.Size(366, 20);
            this.textBoxDestination.TabIndex = 6;
            this.textBoxDestination.Text = "Select a destination...";
            // 
            // buttonCreateFiles
            // 
            this.buttonCreateFiles.Location = new System.Drawing.Point(801, 271);
            this.buttonCreateFiles.Name = "buttonCreateFiles";
            this.buttonCreateFiles.Size = new System.Drawing.Size(117, 23);
            this.buttonCreateFiles.TabIndex = 7;
            this.buttonCreateFiles.Text = "Create selected files";
            this.buttonCreateFiles.UseVisualStyleBackColor = true;
            this.buttonCreateFiles.Click += new System.EventHandler(this.buttonCreateFiles_Click);
            // 
            // buttonSelectAll
            // 
            this.buttonSelectAll.Location = new System.Drawing.Point(23, 150);
            this.buttonSelectAll.Name = "buttonSelectAll";
            this.buttonSelectAll.Size = new System.Drawing.Size(75, 23);
            this.buttonSelectAll.TabIndex = 8;
            this.buttonSelectAll.Text = "Select all";
            this.buttonSelectAll.UseVisualStyleBackColor = true;
            this.buttonSelectAll.Click += new System.EventHandler(this.buttonSelectAll_Click);
            // 
            // buttonDeselect
            // 
            this.buttonDeselect.Location = new System.Drawing.Point(113, 150);
            this.buttonDeselect.Name = "buttonDeselect";
            this.buttonDeselect.Size = new System.Drawing.Size(75, 23);
            this.buttonDeselect.TabIndex = 9;
            this.buttonDeselect.Text = "Deselect";
            this.buttonDeselect.UseVisualStyleBackColor = true;
            this.buttonDeselect.Click += new System.EventHandler(this.buttonDeselect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "File managing";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(799, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "File handling";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(104, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Add multiple files";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(104, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "Add all the files from a folder";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(799, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "Resulting files will go to:";
            // 
            // numericBeginFrom
            // 
            this.numericBeginFrom.Location = new System.Drawing.Point(883, 190);
            this.numericBeginFrom.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericBeginFrom.Name = "numericBeginFrom";
            this.numericBeginFrom.Size = new System.Drawing.Size(67, 20);
            this.numericBeginFrom.TabIndex = 15;
            this.numericBeginFrom.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(799, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 19);
            this.label6.TabIndex = 16;
            this.label6.Text = "Begin from:";
            // 
            // checkBoxOverwrite
            // 
            this.checkBoxOverwrite.AutoSize = true;
            this.checkBoxOverwrite.Location = new System.Drawing.Point(803, 248);
            this.checkBoxOverwrite.Name = "checkBoxOverwrite";
            this.checkBoxOverwrite.Size = new System.Drawing.Size(124, 17);
            this.checkBoxOverwrite.TabIndex = 17;
            this.checkBoxOverwrite.Text = "Overwrite if file exists";
            this.checkBoxOverwrite.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.checkBoxOverwrite);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericBeginFrom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDeselect);
            this.Controls.Add(this.buttonSelectAll);
            this.Controls.Add(this.buttonCreateFiles);
            this.Controls.Add(this.textBoxDestination);
            this.Controls.Add(this.buttonSelectDestination);
            this.Controls.Add(this.buttonOpenFolder);
            this.Controls.Add(this.buttonRemoveAll);
            this.Controls.Add(this.buttonRemoveSelected);
            this.Controls.Add(this.buttonAddFiles);
            this.Controls.Add(this.panelFiles);
            this.Name = "MainWindow";
            this.Text = "Music app";
            ((System.ComponentModel.ISupportInitialize)(this.numericBeginFrom)).EndInit();
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
        private System.Windows.Forms.Button buttonCreateFiles;
        private System.Windows.Forms.Button buttonSelectAll;
        private System.Windows.Forms.Button buttonDeselect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericBeginFrom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBoxOverwrite;
    }
}

