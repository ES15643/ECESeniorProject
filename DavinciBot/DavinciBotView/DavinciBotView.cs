using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 

namespace DavinciBotView
{
    public partial class DavinciBotView : Form
    {
        private int imageLoadCount = 0;
        public string loadedImagePath;

        //Customize form objects in here
        public DavinciBotView()
        {
            InitializeComponent();
            InitializeOurPictureBox();
        }

        private void LoadFromFileToolbarButton_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;
            OpenFileDialog openFile = new OpenFileDialog();

            //TODO: Enter the most recently accessed directory instead of c:\\ 
            // openFile.InitialDirectory = "c:\\";
            openFile.InitialDirectory = "C:\\Documents and Settings\\USER\\Recent";
            openFile.Filter = "Image files (*.jpg; *.jpeg; *.png; *.bmp)|*.jpg; *.jpeg; *.png; *.bmp ";
            openFile.FilterIndex = 2;
            openFile.RestoreDirectory = true;

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                filePath = openFile.FileName;
                loadedImagePath = filePath;
                OurPictureBox.Image = new Bitmap(filePath);
            }

            // MessageBox.Show(fileContent, "File Content at path: " + filePath, MessageBoxButtons.OK);
        }

        //Our picture box
        private void ImageToBeDrawnBox_Click(object sender, EventArgs e)
        {
            LoadFromFileToolbarButton_Click(sender, e);
        }

        public void InitializeOurPictureBox()
        {
            OurPictureBox.BackColor = Color.Transparent;
            OurPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadFromFileToolbarButton_Click(sender, e);
        }

        private void DavinciBotView_Load(object sender, EventArgs e)
        {

        }

        private void DavinciBotView_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Asks the user if they really want to close the program

            /*
            DialogResult dialogue = MessageBox.Show("Are you sure you want to exit?", "Exit",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

            if (dialogue == DialogResult.Yes)
            {
                //SaveFileDialog
                Application.Exit();
            }

            else
            {
                e.Cancel = true;
            }
            */
        }

        //After the image is loaded, process through python/gcode, print to a .txt file
        //Testing: uses image "Loaded from File" and prints its path to a fileS
        private void ConvertImageButton_Click(object sender, EventArgs e)
        {
            string[] lines = { "it's", "a", "test" };
;
            SaveFileDialog saveConvertedImage = new SaveFileDialog();
            if (saveConvertedImage.ShowDialog() == DialogResult.OK)
            {
                using (Stream s = File.Open(saveConvertedImage.FileName, FileMode.OpenOrCreate))
                using (StreamWriter sw = new StreamWriter(s))
                {
                    /* foreach(string line in lines)
                     sw.WriteLine(line);
                     */
                    sw.WriteLine(loadedImagePath);
                }

            }

        }

        private void FindContour()
        {
            var processInfo = new ProcessStartInfo
            {
                UseShellExecute = false, // change value to false
                FileName = "cmd.exe",
                Arguments = "/c time"
            };

            Console.WriteLine("Starting child process...");
            using (var process = Process.Start(processInfo))
            {
                process.WaitForExit();
            }
        }
    }

}
