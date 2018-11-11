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


        /// <summary>
        /// Displays an <see cref="OpenFileDialog"/> with Multiselect enabled and creates a <see cref="UserControlFile"/> instance
        /// for each file provided in the dialog.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

            // If there's at least one file, enable certain buttons
            if (UserControlFiles.Count > 0)
            {
                buttonRemoveAll.Enabled      = true;
                buttonRemoveSelected.Enabled = true;
            }

            RebuildPanelControls();
        }


        /// <summary>
        /// Displays a <see cref="FolderBrowserDialog"/> and stores the folder path provided in the dialog.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSelectDestination_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            if (folderBrowserDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBoxDestination.Text = folderBrowserDialog.SelectedPath;
            }
        }


        /// <summary>
        /// Removes any <see cref="UserControlFile"/> instance that is checked.
        /// Rebuilds <see cref="panelFiles"/> with the remaining <see cref="UserControlFile"/> instances.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRemoveSelected_Click(object sender, EventArgs e)
        {
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

            RebuildPanelControls();
        }


        /// <summary>
        /// Clears all the controls from <see cref="panelFiles"/>, then readds them in the order found in <see cref="UserControlFiles"/>.
        /// </summary>
        void RebuildPanelControls()
        {
            panelFiles.Controls.Clear();

            int counter = 0;
            foreach (UserControlFile userControlFile in UserControlFiles)
            {
                // Determine the y coordinate of the user control
                int numberOfFiles = UserControlFiles.Count;
                int yCoordinate = (userControlFile.Height + 10) * counter;
                userControlFile.Location = new Point(0, yCoordinate);

                panelFiles.Controls.Add(userControlFile);

                userControlFile.FileNumber = counter;

                counter++;
            }
        }


        /// <summary>
        /// Removes all the <see cref="UserControlFile"/> instances and clears the controls of <see cref="panelFiles"/>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRemoveAll_Click(object sender, EventArgs e)
        {
            panelFiles.Controls.Clear();
            UserControlFiles.Clear();

            buttonRemoveAll.Enabled      = false;
            buttonRemoveSelected.Enabled = false;
        }


        /// <summary>
        /// Checks the checkbox of every <see cref="UserControlFile"/> instance.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSelectAll_Click(object sender, EventArgs e)
        {
            foreach (UserControlFile userControlFile in UserControlFiles)
            {
                userControlFile.Selected = true;
            }
        }


        /// <summary>
        /// Deselects any selected <see cref="UserControlFile"/>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDeselect_Click(object sender, EventArgs e)
        {
            foreach (UserControlFile userControlFile in UserControlFiles)
            {
                userControlFile.Selected = false;
            }
        }


        /// <summary>
        /// For each selected <see cref="UserControlFile"/>, creates a file at the destination path 
        /// + an increasing number (starting from the value of <see cref="numericBeginFrom"/>) 
        /// + the file's name.
        /// <para>
        /// For example, if <see cref="numericBeginFrom"/>'s value is 1, "0001.Filename1.extension" will be created,
        /// then "0002.Filename2.extension", and so on.
        /// </para>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCreateFiles_Click(object sender, EventArgs e)
        {
            int currentNumber = (int)numericBeginFrom.Value;

            foreach (UserControlFile userControlFile in UserControlFiles)
            {
                if (userControlFile.Selected)
                {
                    string fileNumberString = currentNumber.ToString();

                    // Determine how many zeroes should be placed before the number
                    // For example, for the number 5, there should be placed 3 zeroes, resulting in 0005
                    int missingZeroes = 4 - fileNumberString.Length;
                    for (int step = 0; step < missingZeroes; step++)
                    {
                        fileNumberString = "0" + fileNumberString;
                    }

                    string destinationFileName = fileNumberString + ". " + userControlFile.FileName;
                    string destinationFilePath = textBoxDestination.Text + "\\" + destinationFileName;

                    // Try and catch used in case a file already exists, and overwrite is not activated.
                    try
                    {
                        System.IO.File.Copy(userControlFile.FilePath, destinationFilePath, checkBoxOverwrite.Checked);
                    }

                    catch
                    {
                        
                    }

                    currentNumber++;
                }
            }

            MessageBox.Show("Done");
        }


        /// <summary>
        /// Tries to set userControlFile's position at newPosition.
        /// If there is an element at that index, will perform a swap between these 2 elements.
        /// If newPosition is higher than <see cref="UserControlFiles"/>'s Count, resets userControlFile's numeric value to
        /// its original value.
        /// </summary>
        /// <param name="userControlFile"></param>
        /// <param name="newPosition"></param>
        public void ChangePosition(UserControlFile userControlFile, int newPosition)
        {
            int oldPosition = UserControlFiles.IndexOf(userControlFile);

            if (oldPosition == newPosition)
            { 
                return;
            }

            if (newPosition >= UserControlFiles.Count)
            {
                userControlFile.FileNumber = oldPosition;
                return;
            }

            UserControlFile userControlFileToBeSwappedWith = UserControlFiles[newPosition];
            UserControlFiles[newPosition] = userControlFile;
            UserControlFiles[oldPosition] = userControlFileToBeSwappedWith;

            RebuildPanelControls();

            //MessageBox.Show("File " + userControlFile.FileName + " wants to change from position " + oldPosition + " to " + newPosition);
        }
    }
}
