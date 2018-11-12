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
            this.labelFileManaging = new System.Windows.Forms.Label();
            this.labelFileHandling = new System.Windows.Forms.Label();
            this.labelAddMultipleFiles = new System.Windows.Forms.Label();
            this.labelOpenFolder = new System.Windows.Forms.Label();
            this.labelDestination = new System.Windows.Forms.Label();
            this.numericBeginFrom = new System.Windows.Forms.NumericUpDown();
            this.labelBeginFrom = new System.Windows.Forms.Label();
            this.checkBoxOverwrite = new System.Windows.Forms.CheckBox();
            this.panelLanguages = new System.Windows.Forms.Panel();
            this.radioButtonEnglish = new System.Windows.Forms.RadioButton();
            this.radioButtonRomanian = new System.Windows.Forms.RadioButton();
            this.labelChooseLanguage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericBeginFrom)).BeginInit();
            this.panelLanguages.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFiles
            // 
            this.panelFiles.AutoScroll = true;
            this.panelFiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelFiles.Location = new System.Drawing.Point(23, 179);
            this.panelFiles.Name = "panelFiles";
            this.panelFiles.Size = new System.Drawing.Size(680, 477);
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
            this.buttonOpenFolder.Click += new System.EventHandler(this.buttonOpenFolder_Click);
            // 
            // buttonSelectDestination
            // 
            this.buttonSelectDestination.Location = new System.Drawing.Point(803, 75);
            this.buttonSelectDestination.Name = "buttonSelectDestination";
            this.buttonSelectDestination.Size = new System.Drawing.Size(111, 23);
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
            this.buttonCreateFiles.Enabled = false;
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
            this.buttonDeselect.Size = new System.Drawing.Size(81, 23);
            this.buttonDeselect.TabIndex = 9;
            this.buttonDeselect.Text = "Deselect";
            this.buttonDeselect.UseVisualStyleBackColor = true;
            this.buttonDeselect.Click += new System.EventHandler(this.buttonDeselect_Click);
            // 
            // labelFileManaging
            // 
            this.labelFileManaging.AutoSize = true;
            this.labelFileManaging.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFileManaging.Location = new System.Drawing.Point(19, 25);
            this.labelFileManaging.Name = "labelFileManaging";
            this.labelFileManaging.Size = new System.Drawing.Size(128, 23);
            this.labelFileManaging.TabIndex = 10;
            this.labelFileManaging.Text = "File managing";
            // 
            // labelFileHandling
            // 
            this.labelFileHandling.AutoSize = true;
            this.labelFileHandling.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFileHandling.Location = new System.Drawing.Point(799, 25);
            this.labelFileHandling.Name = "labelFileHandling";
            this.labelFileHandling.Size = new System.Drawing.Size(119, 23);
            this.labelFileHandling.TabIndex = 11;
            this.labelFileHandling.Text = "File handling";
            // 
            // labelAddMultipleFiles
            // 
            this.labelAddMultipleFiles.AutoSize = true;
            this.labelAddMultipleFiles.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddMultipleFiles.Location = new System.Drawing.Point(104, 63);
            this.labelAddMultipleFiles.Name = "labelAddMultipleFiles";
            this.labelAddMultipleFiles.Size = new System.Drawing.Size(113, 19);
            this.labelAddMultipleFiles.TabIndex = 12;
            this.labelAddMultipleFiles.Text = "Add multiple files";
            // 
            // labelOpenFolder
            // 
            this.labelOpenFolder.AutoSize = true;
            this.labelOpenFolder.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOpenFolder.Location = new System.Drawing.Point(104, 92);
            this.labelOpenFolder.Name = "labelOpenFolder";
            this.labelOpenFolder.Size = new System.Drawing.Size(184, 19);
            this.labelOpenFolder.TabIndex = 13;
            this.labelOpenFolder.Text = "Add all the files from a folder";
            // 
            // labelDestination
            // 
            this.labelDestination.AutoSize = true;
            this.labelDestination.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDestination.Location = new System.Drawing.Point(799, 107);
            this.labelDestination.Name = "labelDestination";
            this.labelDestination.Size = new System.Drawing.Size(152, 19);
            this.labelDestination.TabIndex = 14;
            this.labelDestination.Text = "Resulting files will go to:";
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
            // labelBeginFrom
            // 
            this.labelBeginFrom.AutoSize = true;
            this.labelBeginFrom.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBeginFrom.Location = new System.Drawing.Point(799, 188);
            this.labelBeginFrom.Name = "labelBeginFrom";
            this.labelBeginFrom.Size = new System.Drawing.Size(78, 19);
            this.labelBeginFrom.TabIndex = 16;
            this.labelBeginFrom.Text = "Begin from:";
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
            // panelLanguages
            // 
            this.panelLanguages.Controls.Add(this.labelChooseLanguage);
            this.panelLanguages.Controls.Add(this.radioButtonRomanian);
            this.panelLanguages.Controls.Add(this.radioButtonEnglish);
            this.panelLanguages.Location = new System.Drawing.Point(791, 404);
            this.panelLanguages.Name = "panelLanguages";
            this.panelLanguages.Size = new System.Drawing.Size(200, 100);
            this.panelLanguages.TabIndex = 18;
            // 
            // radioButtonEnglish
            // 
            this.radioButtonEnglish.AutoSize = true;
            this.radioButtonEnglish.Location = new System.Drawing.Point(12, 40);
            this.radioButtonEnglish.Name = "radioButtonEnglish";
            this.radioButtonEnglish.Size = new System.Drawing.Size(59, 17);
            this.radioButtonEnglish.TabIndex = 0;
            this.radioButtonEnglish.TabStop = true;
            this.radioButtonEnglish.Text = "English";
            this.radioButtonEnglish.UseVisualStyleBackColor = true;
            this.radioButtonEnglish.CheckedChanged += new System.EventHandler(this.radioButtonEnglish_CheckedChanged);
            // 
            // radioButtonRomanian
            // 
            this.radioButtonRomanian.AutoSize = true;
            this.radioButtonRomanian.Location = new System.Drawing.Point(12, 63);
            this.radioButtonRomanian.Name = "radioButtonRomanian";
            this.radioButtonRomanian.Size = new System.Drawing.Size(73, 17);
            this.radioButtonRomanian.TabIndex = 1;
            this.radioButtonRomanian.TabStop = true;
            this.radioButtonRomanian.Text = "Romanian";
            this.radioButtonRomanian.UseVisualStyleBackColor = true;
            this.radioButtonRomanian.CheckedChanged += new System.EventHandler(this.radioButtonRomanian_CheckedChanged);
            // 
            // labelChooseLanguage
            // 
            this.labelChooseLanguage.AutoSize = true;
            this.labelChooseLanguage.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChooseLanguage.Location = new System.Drawing.Point(8, 18);
            this.labelChooseLanguage.Name = "labelChooseLanguage";
            this.labelChooseLanguage.Size = new System.Drawing.Size(115, 19);
            this.labelChooseLanguage.TabIndex = 19;
            this.labelChooseLanguage.Text = "Choose language:";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panelLanguages);
            this.Controls.Add(this.checkBoxOverwrite);
            this.Controls.Add(this.labelBeginFrom);
            this.Controls.Add(this.numericBeginFrom);
            this.Controls.Add(this.labelDestination);
            this.Controls.Add(this.labelOpenFolder);
            this.Controls.Add(this.labelAddMultipleFiles);
            this.Controls.Add(this.labelFileHandling);
            this.Controls.Add(this.labelFileManaging);
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
            this.panelLanguages.ResumeLayout(false);
            this.panelLanguages.PerformLayout();
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
        private System.Windows.Forms.Label labelFileManaging;
        private System.Windows.Forms.Label labelFileHandling;
        private System.Windows.Forms.Label labelAddMultipleFiles;
        private System.Windows.Forms.Label labelOpenFolder;
        private System.Windows.Forms.Label labelDestination;
        private System.Windows.Forms.NumericUpDown numericBeginFrom;
        private System.Windows.Forms.Label labelBeginFrom;
        private System.Windows.Forms.CheckBox checkBoxOverwrite;
        private System.Windows.Forms.Panel panelLanguages;
        private System.Windows.Forms.Label labelChooseLanguage;
        private System.Windows.Forms.RadioButton radioButtonRomanian;
        private System.Windows.Forms.RadioButton radioButtonEnglish;
    }
}

