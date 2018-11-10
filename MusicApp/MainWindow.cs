using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MusicApp.UserControls;

namespace MusicApp
{
    public partial class MainWindow : Form
    {
        List<UserControlFile> UserControlFiles;

        public MainWindow()
        {
            InitializeComponent();

            UserControlFiles = new List<UserControlFile>();
        }

        private void buttonAddFiles_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                foreach (string file in openFileDialog.FileNames)
                {
                    UserControlFile userControlFile = new UserControlFile(file, this);

                    // Determine the y coordinate of the new user control
                    int numberOfFiles = UserControlFiles.Count;
                    int yCoordinate = (userControlFile.Height + 10) * numberOfFiles;
                    userControlFile.Location = new Point(0, yCoordinate);

                    UserControlFiles.Add(userControlFile);
                    panelFiles.Controls.Add(userControlFile);
                }
            }

            if (UserControlFiles.Count > 0)
            {
                buttonRemoveAll.Enabled      = true;
                buttonRemoveSelected.Enabled = true;
            }
        }

        private void buttonSelectDestination_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            if (folderBrowserDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBoxDestination.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void buttonRemoveSelected_Click(object sender, EventArgs e)
        {
            panelFiles.Controls.Clear();

            List<UserControlFile> userControlFilesToBeRemoved = new List<UserControlFile>();
            foreach (UserControlFile userControlFile in UserControlFiles)
            {
                if ( userControlFile.Selected )
                {
                    userControlFilesToBeRemoved.Add(userControlFile);
                }
            }

            foreach (UserControlFile userControlFile in userControlFilesToBeRemoved)
            {
                UserControlFiles.Remove(userControlFile);
            }

            if (UserControlFiles.Count == 0)
            {
                buttonRemoveAll.Enabled      = false;
                buttonRemoveSelected.Enabled = false;
                return;
            }

            // Rebuild panel controls
            int counter = 0;
            foreach (UserControlFile userControlFile in UserControlFiles)
            {
                // Determine the y coordinate of the user control
                int numberOfFiles = UserControlFiles.Count;
                int yCoordinate = (userControlFile.Height + 10) * counter++;
                userControlFile.Location = new Point(0, yCoordinate);

                panelFiles.Controls.Add(userControlFile);
            }
        }

        private void buttonRemoveAll_Click(object sender, EventArgs e)
        {

        }
    }
}
