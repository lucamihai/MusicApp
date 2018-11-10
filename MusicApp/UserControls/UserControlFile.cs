using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicApp.UserControls
{
    public partial class UserControlFile : UserControl
    {
        MainWindow mainWindow;

        public UserControlFile()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Stores the filepath and filename of the provided file, and links the user control to the main window.
        /// </summary>
        /// <param name="filePath">Path of the file</param>
        /// <param name="mainWindow">The main window to be linked with</param>
        public UserControlFile(string filePath, MainWindow mainWindow)
        {
            InitializeComponent();

            textBoxFileLocation.Text = filePath;
            this.mainWindow = mainWindow;

            // Obtain the filename
            string[] words = filePath.Split('\\');
            textBoxFileName.Text = words[words.Length - 1];
        }


        /// <summary>
        /// Checks the <see cref="checkBoxSelect"/>
        /// </summary>
        public void SelectFile()
        {
            checkBoxSelect.Checked = true;
        }


        /// <summary>
        /// Unchecks the <see cref="checkBoxSelect"/>
        /// </summary>
        public void DeselectFile()
        {
            checkBoxSelect.Checked = false;
        }


        /// <summary>
        /// The path of the file
        /// </summary>
        public string FilePath
        {
            get
            {
                return textBoxFileLocation.Text;
            }
        }


        /// <summary>
        /// The name of the file
        /// </summary>
        public string FileName
        {
            get
            {
                return textBoxFileName.Text;
            }
        }


        /// <summary>
        /// True if the file is selected
        /// </summary>
        public bool Selected
        {
            get
            {
                return checkBoxSelect.Checked;
            }
        }
    }
}
