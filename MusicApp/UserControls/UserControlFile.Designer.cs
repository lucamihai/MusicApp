namespace MusicApp.UserControls
{
    partial class UserControlFile
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxFileLocation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.checkBoxSelect = new System.Windows.Forms.CheckBox();
            this.numericFileNumber = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericFileNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxFileLocation
            // 
            this.textBoxFileLocation.Location = new System.Drawing.Point(64, 54);
            this.textBoxFileLocation.Multiline = true;
            this.textBoxFileLocation.Name = "textBoxFileLocation";
            this.textBoxFileLocation.ReadOnly = true;
            this.textBoxFileLocation.Size = new System.Drawing.Size(484, 20);
            this.textBoxFileLocation.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "File path:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "File name:";
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.Location = new System.Drawing.Point(64, 28);
            this.textBoxFileName.Multiline = true;
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.ReadOnly = true;
            this.textBoxFileName.Size = new System.Drawing.Size(484, 20);
            this.textBoxFileName.TabIndex = 2;
            // 
            // checkBoxSelect
            // 
            this.checkBoxSelect.AutoSize = true;
            this.checkBoxSelect.Location = new System.Drawing.Point(64, 80);
            this.checkBoxSelect.Name = "checkBoxSelect";
            this.checkBoxSelect.Size = new System.Drawing.Size(56, 17);
            this.checkBoxSelect.TabIndex = 4;
            this.checkBoxSelect.Text = "Select";
            this.checkBoxSelect.UseVisualStyleBackColor = true;
            // 
            // numericFileNumber
            // 
            this.numericFileNumber.Location = new System.Drawing.Point(64, 3);
            this.numericFileNumber.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericFileNumber.Name = "numericFileNumber";
            this.numericFileNumber.Size = new System.Drawing.Size(73, 20);
            this.numericFileNumber.TabIndex = 5;
            this.numericFileNumber.ValueChanged += new System.EventHandler(this.numericFileNumber_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "File number";
            // 
            // UserControlFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericFileNumber);
            this.Controls.Add(this.checkBoxSelect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxFileName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxFileLocation);
            this.Name = "UserControlFile";
            this.Size = new System.Drawing.Size(598, 98);
            ((System.ComponentModel.ISupportInitialize)(this.numericFileNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFileLocation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxFileName;
        private System.Windows.Forms.CheckBox checkBoxSelect;
        private System.Windows.Forms.NumericUpDown numericFileNumber;
        private System.Windows.Forms.Label label3;
    }
}
