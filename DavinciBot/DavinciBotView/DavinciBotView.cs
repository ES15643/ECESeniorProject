using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Collections.ObjectModel;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;

namespace DavinciBotView
{
    public partial class DavinciBotView : Form
    {
        public string loadedImagePath;
        public string loadedImageName;
        private bool invertedContour = false;
        private static bool startedCamera = false;
        private static FilterInfoCollection Devices;
        private static VideoCaptureDevice frame;

        //Customize form objects in here
        public DavinciBotView()
        {
            InitializeComponent();
            InitializeOurPictureBox();
        }

        /// <summary>
        /// Initialize all main components of the GUI
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DavinciBotView_Load(object sender, EventArgs e)
        {
            //videoSource = new VideoCaptureDevice();
            Devices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            frame = new VideoCaptureDevice(Devices[1].MonikerString);
            this.Activate();
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
                var splitFilePath = filePath.Split('\\');
                loadedImageName = splitFilePath[splitFilePath.Length - 1];
                using (var fs = new System.IO.FileStream(loadedImagePath, System.IO.FileMode.Open))
                {
                    var bmp = new Bitmap(fs);
                    OurPictureBox.Image = (Bitmap)bmp.Clone();
                }
                FindContour();
            }
            // MessageBox.Show(fileContent, "File Content at path: " + filePath, MessageBoxButtons.OK);
        }

        private void ImageToBeDrawnBox_Click(object sender, EventArgs e)
        {
            LoadFromFileToolbarButton_Click(sender, e);
        }

        public void InitializeOurPictureBox()
        {
            OurPictureBox.BackColor = Color.LightGray;
            OurPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
        }
        /// <summary>
        /// Load File Button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            LoadFromFileToolbarButton_Click(sender, e);
        }

        /// <summary>
        ///Asks the user if they really want to close the program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DavinciBotView_FormClosing(object sender, FormClosingEventArgs e)
        {   
            DialogResult dialogue = MessageBox.Show("Are you sure you want to exit?", "Exit",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

            if (dialogue != DialogResult.Yes)
                e.Cancel = true;
        }

        /// <summary>
        /// Processes preview image to rastor-style gcode file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GenerateGcodeButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogue = MessageBox.Show(
                    "Would you like to save a copy of your G-Code file?", "DaVinciBot",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (dialogue == DialogResult.Cancel)
            {
                return;
            }
            else
            {
                string oldDir = Environment.CurrentDirectory;
                RunPythonScript("gcode");
                Environment.CurrentDirectory = oldDir;

                if (dialogue == DialogResult.Yes)
                {
                    SaveFileDialog saveConvertedImage = new SaveFileDialog();
                    saveConvertedImage.Filter = "G-Code File (*.gco)|*.gco";
                    if (saveConvertedImage.ShowDialog() == DialogResult.OK)
                    {
                        copyFile("commands.gco", saveConvertedImage.FileName);
                    }
                }
            }
        }
        
        /// <summary>
        /// Mode is either "gcode" or "contour"
        /// </summary>
        /// <param name="mode"></param>
        private void RunPythonScript(string mode)
        {
            using (Runspace runspace = RunspaceFactory.CreateRunspace())
            {
                Environment.CurrentDirectory = "../../../../Image_Processor_Files";
                string pScript = BuildPythonScript(mode);

                runspace.Open();
                using (Pipeline pipeline = runspace.CreatePipeline())
                {
                    pipeline.Commands.AddScript(pScript);
                    pipeline.Commands.Add("Out-String");
                    Collection<PSObject> results = pipeline.Invoke();
                }
                //Put a message box here
                runspace.Dispose();
            }           
            return;
        }
        
        /// <summary>
        /// Builds the python scripts for either the gcode generator or the findContour method
        /// </summary>
        /// <param name="mode"></param>
        /// <returns></returns>
        
        private string BuildPythonScript(string mode)
        {
            string script;
            switch (mode)
            {
                case "gcode":
                    {
                        //need to change this to scale image properly based on user inputs
                        double x_offset_mm = 0;
                        double y_offset_mm = 0;
                        double output_image_horizontal_size_mm = 400;
                        double pixel_size_mm = .5;
                        double feedrate = 100;
                        double max_laser_power = 255;
                        int number_of_colors = 2;

                        script = "python "
                            + "./imgcode.py "
                            + "preview_contour.jpg "
                            + "./commands.gco "
                            + x_offset_mm + ' '
                            + y_offset_mm + ' '
                            + output_image_horizontal_size_mm + ' '
                            + pixel_size_mm + ' '
                            + feedrate + ' '
                            + max_laser_power + ' '
                            + number_of_colors;

                        break;
                    }
                case "contour":
                    {
                        string contourFile;
                        if (invertedContour)
                        {
                            contourFile = "./contours0.py";
                        }
                        else
                        {
                            contourFile = "./contours.py";
                        }
                        script = "python "
                                + contourFile
                                + " --image_file "
                                + '"'
                                + loadedImagePath
                                + '"'
                                + " --threshold "
                                + trackBar1.Value;
                        break;
                    }
                default:
                    script = "";
                    break;
            }
            return script;
        }
       
        /// <summary>
        /// Calls python script to find contours in an image and update the image preview
        /// Referenced from: https://blogs.msdn.microsoft.com/kebab/2014/04/28/executing-powershell-scripts-from-c/
        /// </summary>
        private void FindContour()
        {
            string oldDir = Environment.CurrentDirectory;
            RunPythonScript("contour");

            using (var fs = new System.IO.FileStream("preview_contour.jpg", System.IO.FileMode.Open))
            {
                var bmp = new Bitmap(fs);
                previewImageBox.Image = (Bitmap)bmp.Clone();
            }
            Environment.CurrentDirectory = oldDir;
        }

        /// <summary>
        /// Updates image preview window when threshold for image processing has changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImagePreviewThresholdChanged(object sender, EventArgs e)
        {
            Controls.Add(trackBar1);
            thresholdNumberBox.Value = trackBar1.Value;
        }

        /// <summary>
        /// Adjusts image processing threshold
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void trackBar1_MouseUp(object sender, MouseEventArgs e)
        {
            Controls.Add(trackBar1);
            //Update preview image
            FindContour();

        }

        /// <summary>
        /// Toggles between proessing with contour.py and contour 2.py
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void invertCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            invertedContour = !invertedContour;
            FindContour();
        }

        private void thresholdNumberBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                e.KeyChar = (char)46;
                int val = (int)thresholdNumberBox.Value;
                FindContour();
                trackBar1.Value = val;
                this.ActiveControl = null;
            }
        }

        private void startCameraButton_Click(object sender, EventArgs e)
        {
            startCamera();
        }

        /// <summary>
        /// Turn on camera to take pictures
        /// References: https://www.youtube.com/watch?v=A4Qcq9GOvGQ
        /// </summary>
        private void startCamera()
        {
            //STOP ALL PREVIOUS CAMERAS OR YOU GET A THREADING ISSUE
            //            if (startedCamera == false)
            //          {
            frame.NewFrame += new AForge.Video.NewFrameEventHandler(FrameEvent);
            frame.Start();
            startedCamera = true;
            //        }
        }
        
        private void stopCamera()
        {
            frame.SignalToStop();
            frame.NewFrame -= new NewFrameEventHandler(FrameEvent);
            frame.WaitForStop();
            while (frame.IsRunning)
            {
                frame.Stop();
            }
            cameraBox.Image = null;
        }
        
        private void FrameEvent(object sender, NewFrameEventArgs e)
        {
            try
            {
                Image temp = (Image)e.Frame.Clone();
                temp.RotateFlip(RotateFlipType.RotateNoneFlipX);
                cameraBox.Image = temp;

            }
            catch (Exception) //need e?
            {
                throw;
            }
        }
        
        private void captureImageButton_Click(object sender, EventArgs e)
        {
            frame.SignalToStop();
            frame.NewFrame -= new NewFrameEventHandler(FrameEvent);
            frame.WaitForStop();
            while (frame.IsRunning)
            {
                frame.Stop();
            }
            //SaveFileDialog saveCameraImage = new SaveFileDialog

        }
        
        private void stopCameraButton_Click(object sender, EventArgs e)
        {
            stopCamera();
        }

        /// <summary>
        /// Copies contents of one file to another given two string filenames.
        /// </summary>
        /// <param name="fromFile"></param>
        /// <param name="toFile"></param>
        private void copyFile(string fromFile, string toFile)
        {
            string line;
            using (System.IO.StreamWriter output = new System.IO.StreamWriter(toFile, true))
            {
                System.IO.StreamReader file = new System.IO.StreamReader(fromFile);
                while ((line = file.ReadLine()) != null)
                {
                    output.WriteLine(line);
                }

                file.Close();
            }
        }

        private void thresholdNumberBox_ValueChanged(object sender, EventArgs e)
        {
            trackBar1.Value = (int)thresholdNumberBox.Value;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            thresholdNumberBox.Value = trackBar1.Value;
            FindContour();
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            trackBar1_Scroll(sender, e);
        }
        
        /// <summary>
        ///Closes camera resources before exiting
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DavinciBotView_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (frame != null)
            {
                stopCamera();
            }
            Application.Exit();
        }
    }

}
