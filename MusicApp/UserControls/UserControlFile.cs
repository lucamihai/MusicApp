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

        public UserControlFile(string filePath, MainWindow mainWindow)
        {
            InitializeComponent();

            textBoxFileLocation.Text = filePath;
            this.mainWindow = mainWindow;

            // Get only the filename
            string[] words = filePath.Split('\\');
            textBoxFileName.Text = words[words.Length - 1];
        }

        public string FilePath
        {
            get
            {
                return textBoxFileLocation.Text;
            }
        }

        public bool Selected
        {
            get
            {
                return checkBoxSelect.Checked;
            }
        }
    }
}
