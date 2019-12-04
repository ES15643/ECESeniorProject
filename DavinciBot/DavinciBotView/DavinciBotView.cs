using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace DavinciBotView
{
    public partial class DavinciBotView : Form
    {
        public string loadedImagePath;
        public string loadedImageName;
        public string gCodeFilePath;
        private bool pictureTakenWithCamera = false;
        private bool imageLoaded = false;
        private bool invertedContour = false;
        private static bool startedCamera = false;
        private static FilterInfoCollection Devices;
        private static VideoCaptureDevice frame;
        private const string masterGcodeFile = "commands.gco";
        private const int defaultThresholdValue = 100;
        private const string masterDirectory = "../../../../Image_Processor_Files";
        private List<Image> recentPictures = new List<Image>(6);
        private int recentImageCount = 0;


        //Customize form objects in here
        public DavinciBotView()
        {
            InitializeComponent();
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
            EnableImageControls(false);
            EnableCameraControls(false);
            EnableGcodeControls(false);
            this.ActiveControl = uploadImageFromFileButton;
        }

        /// <summary>
        /// Enables or disables buttons that can only be used when an image is loaded
        /// </summary>
        /// <param name="m"></param>
        private void EnableImageControls(bool m)
        {
            trackBar1.Enabled = m;
            thresholdNumberBox.Enabled = m;
            invertCheckBox.Enabled = m;
            generateGcodeButton.Enabled = m;
        }
        private void EnableCameraControls(bool m)
        {
            startCameraButton.Enabled = !m;
            takePictureButton.Enabled = m;
            stopCameraButton.Enabled = m;
            saveCameraImageButton.Enabled = m;
            useCameraImageButton.Enabled = m;
        }
        private void EnableGcodeControls(bool m)
        {
            generateGcodeButton.Enabled = m;
            startPrintingButton.Enabled = m;
            stopPrintingButton.Enabled = m;
        }

        private void LoadFromFileToolbarButton_Click(object sender, EventArgs e)
        {
            HandleUploadedImage(sender, e);
        }

        private void ImageToBeDrawnBox_Click(object sender, EventArgs e)
        {
            HandleUploadedImage(sender, e);
        }

        /// <summary>
        /// Loads gcode from file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadGCodeFromFileButton_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;
            OpenFileDialog openFile = new OpenFileDialog();

            //TODO: Enter the most recently accessed directory instead of c:\\ 
            // openFile.InitialDirectory = "c:\\";
            openFile.InitialDirectory = "C:\\Documents and Settings\\USER\\Recent";
            openFile.Filter = "G-Code Files (*.gco)|*.gco";
            openFile.FilterIndex = 2;
            openFile.RestoreDirectory = true;

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                filePath = openFile.FileName;
                gCodeFilePath = filePath;
                CopyFile(gCodeFilePath, masterGcodeFile);
                EnableGcodeControls(true);
                generateGcodeButton.Enabled = false;
                loadedGcodeTextBox.Text = gCodeFilePath;
            }
            // MessageBox.Show(fileContent, "File Content at path: " + filePath, MessageBoxButtons.OK);
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
                RunPythonScript("gcode", 0);
                Environment.CurrentDirectory = oldDir;

                if (dialogue == DialogResult.Yes)
                {
                    SaveFileDialog saveConvertedImage = new SaveFileDialog();
                    saveConvertedImage.Filter = "G-Code Files (*.gco)|*.gco";
                    if (saveConvertedImage.ShowDialog() == DialogResult.OK)
                    {
                        CopyFile(masterGcodeFile, saveConvertedImage.FileName);
                    }
                }
            }
        }

        /// <summary>
        /// Mode is either "gcode" or "contour"
        /// </summary>
        /// <param name="mode"></param>
        private void RunPythonScript(string mode, int threshold)
        {
            using (Runspace runspace = RunspaceFactory.CreateRunspace())
            {
                Environment.CurrentDirectory = masterDirectory;
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
        private void FindContour(int threshold)
        {
            string oldDir = Environment.CurrentDirectory;
            RunPythonScript("contour", threshold);

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
            HandleThresholdValueChange(sender, e, "trackbar");
            thresholdNumberBox.Value = trackBar1.Value;
        }

        /// <summary>
        /// Adjusts image processing threshold
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TrackBar1_MouseUp(object sender, MouseEventArgs e)
        {
            HandleThresholdValueChange(sender, e, "trackbar");

        }

        /// <summary>
        /// Toggles between proessing with contour.py and contour 2.py
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InvertCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void StartCameraButton_Click(object sender, EventArgs e)
        {
            StartCamera();
        }

        /// <summary>
        /// Turn on camera to take pictures
        /// References: https://www.youtube.com/watch?v=A4Qcq9GOvGQ
        /// </summary>
        private void StartCamera()
        {
            //STOP ALL PREVIOUS CAMERAS OR YOU GET A THREADING ISSUE
            frame.NewFrame += new AForge.Video.NewFrameEventHandler(FrameEvent);
            frame.Start();
            startedCamera = true;
            EnableCameraControls(false); //Reset
            takePictureButton.Enabled = true;
            stopCameraButton.Enabled = true;
            startCameraButton.Enabled = false;
        }

        private void StopCamera()
        {
            frame.SignalToStop();
            frame.NewFrame -= new NewFrameEventHandler(FrameEvent);
            frame.WaitForStop();
            while (frame.IsRunning)
            {
                frame.Stop();
            }

            //Ask if user wants to save camera image
            
            EnableCameraControls(false);


        }

        private void FrameEvent(object sender, NewFrameEventArgs e)
        {
            try
            {
                Image temp = (Image)e.Frame.Clone();
                temp.RotateFlip(RotateFlipType.RotateNoneFlipX);
                OurPictureBox.Image = temp;

            }
            catch (Exception) //need e?
            {
                throw;
            }
        }

        private void TakePictureButton_Click(object sender, EventArgs e)
        {
            frame.SignalToStop();
            frame.NewFrame -= new NewFrameEventHandler(FrameEvent);
            frame.WaitForStop();
            while (frame.IsRunning)
            {
                frame.Stop();
            }
            saveCameraImageButton.Enabled = true;
            useCameraImageButton.Enabled = true;
            takePictureButton.Enabled = false;
            startCameraButton.Enabled = true;
            Image temp = (Image)OurPictureBox.Image.Clone();
            //Puts it in the main box. Save this for later.
            OurPictureBox.Image = temp;
            pictureTakenWithCamera = true;
            //make sure to update loadedImagePath to this temp file
            //uploadImageFromFileTextbox 
            //SaveFileDialog saveCameraImage = new SaveFileDialog

        }

        private void StopCameraButton_Click(object sender, EventArgs e)
        {
            StopCamera();
        }

        /// <summary>
        /// Copies contents of one file to another given two string filenames.
        /// </summary>
        /// <param name="fromFile"></param>
        /// <param name="toFile"></param>
        private void CopyFile(string fromFile, string toFile)
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

        /// <summary>
        /// When a user enters a threshold value manually and clicks enter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ThresholdNumberBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                e.KeyChar = (char)46;
                int val = (int)thresholdNumberBox.Value;
                FindContour(val);
                trackBar1.Value = val;
                this.ActiveControl = null;
            }
        }

        private void ThresholdNumberBox_ValueChanged(object sender, EventArgs e)
        {
            HandleThresholdValueChange(sender, e, "box");
        }
        /// <summary>
        /// Threshold trackbar event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TrackBar1_ValueChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Error handling for threshold changes.
        /// mode param can either be "trackbar" or "box", whichever event was triggered
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <param name="mode"></param>
        private void HandleThresholdValueChange(object sender, EventArgs e, string mode)
        {
            if (!imageLoaded)
            {
                EnableImageControls(false);
            }
            else
            {
                switch (mode)
                {
                    case "trackbar":
                        {
                            thresholdNumberBox.Value = trackBar1.Value;
                            break;
                        }
                    case "box":
                        {
                            trackBar1.Value = (int)thresholdNumberBox.Value;
                            break;
                        }
                    default:
                        {
                            trackBar1.Value = defaultThresholdValue;
                            thresholdNumberBox.Value = defaultThresholdValue;
                            break;
                        }
                }
                FindContour(trackBar1.Value);
            }
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
                StopCamera();
            }
            Application.Exit();
        }

        /// <summary>
        /// General error handling for operations that require prerequisites
        /// </summary>
        private void ReportImageOperationError()
        {
            DialogResult dialogue = MessageBox.Show("You must select an image first.", "Error",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
        }

        private void InvertCheckBox_Click(object sender, EventArgs e)
        {
            if (imageLoaded)
            {
                invertedContour = !invertedContour;
                FindContour(trackBar1.Value);
            }
            else
            {
                invertCheckBox.Checked = false;
            }
        }

        private void ThresholdControlPanel_Click(object sender, EventArgs e)
        {
            if (!trackBar1.Enabled && !thresholdNumberBox.Enabled && !invertCheckBox.Enabled)
                ReportImageOperationError();
        }

        private void Trackbar1Panel_Click(object sender, EventArgs e)
        {
            ThresholdControlPanel_Click(sender, e);
        }

        private void TrackBar1_Scroll(object sender, EventArgs e)
        {
            HandleThresholdValueChange(sender, e, "trackbar");
        }

        private void UseCameraImageButton_Click(object sender, EventArgs e)
        {
            string oldDir = Environment.CurrentDirectory;
            Environment.CurrentDirectory = masterDirectory;
            
            loadedImagePath = "temp.jpg";
            OurPictureBox.Image.Save(loadedImagePath);
            AddToRecentPictures(OurPictureBox.Image);
            Environment.CurrentDirectory = oldDir;

            FindContour(defaultThresholdValue);
            imageLoaded = true;
            EnableImageControls(true);
            
        }

        //Need to remember to add cancel functionality to this
        private void RunGcodeClient()
        {
            TcpClient client = new TcpClient();
            Console.WriteLine("Connecting...");

            client.Connect("192.168.4.1", 80);
            //client.Connect(IPAddress.Loopback, 80);

            Console.WriteLine("Connected");

            string[] commands = File.ReadAllLines(@"..\..\commands.gco");

            int numCommands = commands.Length;

            NetworkStream stream = client.GetStream();

            int count = 0;
            int index = 0;

            foreach (string line in commands)
            {
                byte[] command = Encoding.UTF8.GetBytes(line + "\n");

                if (count == 0)
                {
                    byte[] request = new byte[5];

                    while (request.Select(x => int.Parse(x.ToString())).Sum() == 0) { stream.Read(request, 0, request.Length); }

                    string result = Encoding.UTF8.GetString(request);

                    if (BitConverter.IsLittleEndian)
                        Array.Reverse(request);

                    count = Convert.ToInt32(result);
                }

                stream.Write(command, 0, command.Length);

                count -= command.Length;
                index++;

                Console.WriteLine((double)index / (double)numCommands);
            }

            string endMessage = "Transmission Complete\n";

            stream.Write(Encoding.UTF8.GetBytes(endMessage), 0, endMessage.Length);
            stream.Read(new byte[1], 0, 1);

            stream.Close();
            client.Close();

            return;
        }

        private void UploadImageFromFileButton_Click(object sender, EventArgs e)
        {
            HandleUploadedImage(sender, e);
        }

        private void AskToSaveCameraImage()
        {

        }

        private void HandleUploadedImage(object sender, EventArgs e)
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
                uploadImageFromFileTextbox.Text = loadedImagePath;
                using (var fs = new System.IO.FileStream(loadedImagePath, System.IO.FileMode.Open))
                {
                    var bmp = new Bitmap(fs);
                    OurPictureBox.Image = (Bitmap)bmp.Clone();
                    AddToRecentPictures(OurPictureBox.Image);
                }
                HandleThresholdValueChange(sender, e, "");
                FindContour(defaultThresholdValue);
            }
            imageLoaded = true;
            EnableImageControls(true);            
            // MessageBox.Show(fileContent, "File Content at path: " + filePath, MessageBoxButtons.OK);
        }

        private void startPrintingButton_Click(object sender, EventArgs e)
        {
            RunGcodeClient();
        }

        private void AddToRecentPictures(Image im)
        {
            /*
            for(int i = recent; i < recentImageCount ; i++)
            {
                //if(recentPictures[i] != null)
                {
                    recentPictures[i + 1] = recentPictures[i];                    
                }
            }
            */
            if(recentImageCount == 6)
            {
                recentImageCount = 0;
            }
            recentPictures.Add((Image)im.Clone());
            UpdateRecentPictureBoxes();
            recentImageCount++;
            
        }
        private void UpdateRecentPictureBoxes()
        {
            recentPicture0.Image = (Image)recentPictures[0];

            if (recentImageCount > 0)
            {
                recentPicture1.Image = (Image)recentPictures[1];
            }
            if (recentImageCount > 1)
            {
                recentPicture2.Image = (Image)recentPictures[2];
            }
            if (recentImageCount > 2)
            {
                recentPicture3.Image = (Image)recentPictures[3];
            }
            if (recentImageCount > 3)
            {
                recentPicture4.Image = (Image)recentPictures[4];
            }
            if (recentImageCount > 4)
            {
                recentPicture5.Image = (Image)recentPictures[5];
            }
        }
    }
}
