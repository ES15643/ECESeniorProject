namespace DavinciBotView
{
    partial class DavinciBotView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DavinciBotView));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadFromFileToolbarButton = new System.Windows.Forms.ToolStripMenuItem();
            this.fromToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OurPictureBox = new System.Windows.Forms.PictureBox();
            this.previewImageBox = new System.Windows.Forms.PictureBox();
            this.invertCheckBox = new System.Windows.Forms.CheckBox();
            this.startCameraButton = new System.Windows.Forms.Button();
            this.takePictureButton = new System.Windows.Forms.Button();
            this.saveCameraImageButton = new System.Windows.Forms.Button();
            this.stopCameraButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.thresholdNumberBox = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.thresholdControlPanel = new System.Windows.Forms.TableLayoutPanel();
            this.trackbar1Panel = new System.Windows.Forms.Panel();
            this.clearImageButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.uploadImageFromFileButton = new System.Windows.Forms.Button();
            this.uploadImageFromFileTextbox = new System.Windows.Forms.TextBox();
            this.printingButtonsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.startPrintingButton = new System.Windows.Forms.Button();
            this.generateGcodeButton = new System.Windows.Forms.Button();
            this.stopPrintingButton = new System.Windows.Forms.Button();
            this.pausePrintingButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.LoadGCodeFromFileButton = new System.Windows.Forms.Button();
            this.loadedGcodeTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.recentPicture0 = new System.Windows.Forms.PictureBox();
            this.recentPicture1 = new System.Windows.Forms.PictureBox();
            this.recentPicture2 = new System.Windows.Forms.PictureBox();
            this.recentPicture4 = new System.Windows.Forms.PictureBox();
            this.recentPicture3 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.recentPicture5 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OurPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.previewImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdNumberBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.thresholdControlPanel.SuspendLayout();
            this.trackbar1Panel.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.printingButtonsPanel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recentPicture0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recentPicture1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recentPicture2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recentPicture4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recentPicture3)).BeginInit();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recentPicture5)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(2075, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadImageToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(56, 34);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadImageToolStripMenuItem
            // 
            this.loadImageToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.loadImageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoadFromFileToolbarButton,
            this.fromToolStripMenuItem});
            this.loadImageToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.loadImageToolStripMenuItem.Name = "loadImageToolStripMenuItem";
            this.loadImageToolStripMenuItem.Size = new System.Drawing.Size(213, 34);
            this.loadImageToolStripMenuItem.Text = "Load Image";
            // 
            // LoadFromFileToolbarButton
            // 
            this.LoadFromFileToolbarButton.Name = "LoadFromFileToolbarButton";
            this.LoadFromFileToolbarButton.Size = new System.Drawing.Size(228, 34);
            this.LoadFromFileToolbarButton.Text = "From File";
            this.LoadFromFileToolbarButton.Click += new System.EventHandler(this.LoadFromFileToolbarButton_Click);
            // 
            // fromToolStripMenuItem
            // 
            this.fromToolStripMenuItem.Name = "fromToolStripMenuItem";
            this.fromToolStripMenuItem.Size = new System.Drawing.Size(228, 34);
            this.fromToolStripMenuItem.Text = "From Camera";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.saveToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(213, 34);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(68, 34);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // OurPictureBox
            // 
            this.OurPictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OurPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.OurPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OurPictureBox.Location = new System.Drawing.Point(175, 64);
            this.OurPictureBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.OurPictureBox.Name = "OurPictureBox";
            this.OurPictureBox.Size = new System.Drawing.Size(835, 482);
            this.OurPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.OurPictureBox.TabIndex = 1;
            this.OurPictureBox.TabStop = false;
            this.OurPictureBox.Click += new System.EventHandler(this.ImageToBeDrawnBox_Click);
            // 
            // previewImageBox
            // 
            this.previewImageBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.previewImageBox.BackColor = System.Drawing.Color.Transparent;
            this.previewImageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.previewImageBox.Location = new System.Drawing.Point(1095, 64);
            this.previewImageBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.previewImageBox.Name = "previewImageBox";
            this.previewImageBox.Size = new System.Drawing.Size(820, 482);
            this.previewImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.previewImageBox.TabIndex = 7;
            this.previewImageBox.TabStop = false;
            // 
            // invertCheckBox
            // 
            this.invertCheckBox.BackColor = System.Drawing.SystemColors.Control;
            this.invertCheckBox.BackgroundImage = global::DavinciBotView.Properties.Resources.actualDarkestbutton;
            this.invertCheckBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.invertCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invertCheckBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.invertCheckBox.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.invertCheckBox.Location = new System.Drawing.Point(403, 4);
            this.invertCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.invertCheckBox.Name = "invertCheckBox";
            this.invertCheckBox.Size = new System.Drawing.Size(438, 42);
            this.invertCheckBox.TabIndex = 9;
            this.invertCheckBox.Text = "Invert Contour";
            this.invertCheckBox.UseVisualStyleBackColor = false;
            this.invertCheckBox.CheckedChanged += new System.EventHandler(this.InvertCheckBox_CheckedChanged);
            this.invertCheckBox.Click += new System.EventHandler(this.InvertCheckBox_Click);
            // 
            // startCameraButton
            // 
            this.startCameraButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.startCameraButton.BackgroundImage = global::DavinciBotView.Properties.Resources.actualDarkestbutton;
            this.startCameraButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel3.SetColumnSpan(this.startCameraButton, 2);
            this.startCameraButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.startCameraButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startCameraButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.startCameraButton.Location = new System.Drawing.Point(4, 4);
            this.startCameraButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.startCameraButton.Name = "startCameraButton";
            this.startCameraButton.Size = new System.Drawing.Size(844, 64);
            this.startCameraButton.TabIndex = 12;
            this.startCameraButton.Text = "Use Camera";
            this.startCameraButton.UseVisualStyleBackColor = true;
            this.startCameraButton.Click += new System.EventHandler(this.StartCameraButton_Click);
            // 
            // takePictureButton
            // 
            this.takePictureButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.takePictureButton.BackgroundImage = global::DavinciBotView.Properties.Resources.actualDarkestbutton;
            this.takePictureButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.takePictureButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.takePictureButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.takePictureButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.takePictureButton.Location = new System.Drawing.Point(4, 4);
            this.takePictureButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.takePictureButton.Name = "takePictureButton";
            this.takePictureButton.Size = new System.Drawing.Size(413, 56);
            this.takePictureButton.TabIndex = 13;
            this.takePictureButton.Text = "Take Picture";
            this.takePictureButton.UseVisualStyleBackColor = false;
            this.takePictureButton.Click += new System.EventHandler(this.TakePictureButton_Click);
            // 
            // saveCameraImageButton
            // 
            this.saveCameraImageButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.saveCameraImageButton.BackgroundImage = global::DavinciBotView.Properties.Resources.actualDarkestbutton;
            this.saveCameraImageButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.saveCameraImageButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveCameraImageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveCameraImageButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.saveCameraImageButton.Location = new System.Drawing.Point(426, 4);
            this.saveCameraImageButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.saveCameraImageButton.Name = "saveCameraImageButton";
            this.saveCameraImageButton.Size = new System.Drawing.Size(414, 56);
            this.saveCameraImageButton.TabIndex = 14;
            this.saveCameraImageButton.Text = "Save Image";
            this.saveCameraImageButton.UseVisualStyleBackColor = false;
            this.saveCameraImageButton.Click += new System.EventHandler(this.SaveCameraImageButton_Click);
            // 
            // stopCameraButton
            // 
            this.stopCameraButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.stopCameraButton.BackgroundImage = global::DavinciBotView.Properties.Resources.actualDarkestbutton;
            this.stopCameraButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel3.SetColumnSpan(this.stopCameraButton, 2);
            this.stopCameraButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.stopCameraButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopCameraButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.stopCameraButton.Location = new System.Drawing.Point(4, 148);
            this.stopCameraButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.stopCameraButton.Name = "stopCameraButton";
            this.stopCameraButton.Size = new System.Drawing.Size(844, 56);
            this.stopCameraButton.TabIndex = 15;
            this.stopCameraButton.Text = "Close Camera";
            this.stopCameraButton.UseVisualStyleBackColor = false;
            this.stopCameraButton.Click += new System.EventHandler(this.StopCameraButton_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(417, 601);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 0);
            this.panel1.TabIndex = 21;
            // 
            // thresholdNumberBox
            // 
            this.thresholdNumberBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.thresholdNumberBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thresholdNumberBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.thresholdNumberBox.Location = new System.Drawing.Point(4, 4);
            this.thresholdNumberBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.thresholdNumberBox.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.thresholdNumberBox.Name = "thresholdNumberBox";
            this.thresholdNumberBox.Size = new System.Drawing.Size(391, 42);
            this.thresholdNumberBox.TabIndex = 10;
            this.thresholdNumberBox.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.thresholdNumberBox.ValueChanged += new System.EventHandler(this.ThresholdNumberBox_ValueChanged);
            this.thresholdNumberBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ThresholdNumberBox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(792, 80);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "200";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(395, 80);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 25);
            this.label5.TabIndex = 17;
            this.label5.Text = "100";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(4, 80);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "0";
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.trackBar1.Location = new System.Drawing.Point(-4, 17);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.trackBar1.Maximum = 200;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(841, 80);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.TickFrequency = 20;
            this.trackBar1.Value = 100;
            this.trackBar1.Scroll += new System.EventHandler(this.TrackBar1_Scroll);
            this.trackBar1.ValueChanged += new System.EventHandler(this.TrackBar1_ValueChanged);
            // 
            // thresholdControlPanel
            // 
            this.thresholdControlPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.thresholdControlPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.thresholdControlPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.thresholdControlPanel.ColumnCount = 2;
            this.thresholdControlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47F));
            this.thresholdControlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53F));
            this.thresholdControlPanel.Controls.Add(this.thresholdNumberBox, 0, 0);
            this.thresholdControlPanel.Controls.Add(this.invertCheckBox, 1, 0);
            this.thresholdControlPanel.Controls.Add(this.trackbar1Panel, 0, 1);
            this.thresholdControlPanel.Location = new System.Drawing.Point(1091, 557);
            this.thresholdControlPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.thresholdControlPanel.Name = "thresholdControlPanel";
            this.thresholdControlPanel.RowCount = 2;
            this.thresholdControlPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.thresholdControlPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.thresholdControlPanel.Size = new System.Drawing.Size(850, 161);
            this.thresholdControlPanel.TabIndex = 24;
            this.thresholdControlPanel.Click += new System.EventHandler(this.ThresholdControlPanel_Click);
            // 
            // trackbar1Panel
            // 
            this.trackbar1Panel.AutoSize = true;
            this.trackbar1Panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.trackbar1Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.thresholdControlPanel.SetColumnSpan(this.trackbar1Panel, 2);
            this.trackbar1Panel.Controls.Add(this.label6);
            this.trackbar1Panel.Controls.Add(this.label4);
            this.trackbar1Panel.Controls.Add(this.label5);
            this.trackbar1Panel.Controls.Add(this.trackBar1);
            this.trackbar1Panel.Location = new System.Drawing.Point(4, 54);
            this.trackbar1Panel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.trackbar1Panel.Name = "trackbar1Panel";
            this.trackbar1Panel.Size = new System.Drawing.Size(841, 105);
            this.trackbar1Panel.TabIndex = 22;
            this.trackbar1Panel.Click += new System.EventHandler(this.Trackbar1Panel_Click);
            // 
            // clearImageButton
            // 
            this.clearImageButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.clearImageButton.BackgroundImage = global::DavinciBotView.Properties.Resources.actualDarkestbutton;
            this.tableLayoutPanel3.SetColumnSpan(this.clearImageButton, 2);
            this.clearImageButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearImageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearImageButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.clearImageButton.Location = new System.Drawing.Point(4, 220);
            this.clearImageButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clearImageButton.Name = "clearImageButton";
            this.clearImageButton.Size = new System.Drawing.Size(844, 56);
            this.clearImageButton.TabIndex = 26;
            this.clearImageButton.Text = "Clear Image";
            this.clearImageButton.UseVisualStyleBackColor = false;
            this.clearImageButton.Click += new System.EventHandler(this.ClearImageButton_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.stopCameraButton, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.startCameraButton, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.clearImageButton, 0, 3);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(167, 640);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(853, 291);
            this.tableLayoutPanel3.TabIndex = 29;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel3.SetColumnSpan(this.tableLayoutPanel5, 2);
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.takePictureButton, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.saveCameraImageButton, 1, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(4, 76);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(844, 64);
            this.tableLayoutPanel5.TabIndex = 25;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.uploadImageFromFileButton, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.uploadImageFromFileTextbox, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(165, 554);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(854, 59);
            this.tableLayoutPanel4.TabIndex = 29;
            // 
            // uploadImageFromFileButton
            // 
            this.uploadImageFromFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uploadImageFromFileButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.uploadImageFromFileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uploadImageFromFileButton.BackgroundImage = global::DavinciBotView.Properties.Resources.actualDarkestbutton;
            this.uploadImageFromFileButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uploadImageFromFileButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.uploadImageFromFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.uploadImageFromFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadImageFromFileButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.uploadImageFromFileButton.Location = new System.Drawing.Point(431, 3);
            this.uploadImageFromFileButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.uploadImageFromFileButton.Name = "uploadImageFromFileButton";
            this.tableLayoutPanel4.SetRowSpan(this.uploadImageFromFileButton, 2);
            this.uploadImageFromFileButton.Size = new System.Drawing.Size(419, 53);
            this.uploadImageFromFileButton.TabIndex = 2;
            this.uploadImageFromFileButton.Text = "Upload Image From File";
            this.uploadImageFromFileButton.UseVisualStyleBackColor = false;
            this.uploadImageFromFileButton.Click += new System.EventHandler(this.UploadImageFromFileButton_Click);
            // 
            // uploadImageFromFileTextbox
            // 
            this.uploadImageFromFileTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.uploadImageFromFileTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uploadImageFromFileTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadImageFromFileTextbox.ForeColor = System.Drawing.Color.White;
            this.uploadImageFromFileTextbox.Location = new System.Drawing.Point(4, 4);
            this.uploadImageFromFileTextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uploadImageFromFileTextbox.Name = "uploadImageFromFileTextbox";
            this.uploadImageFromFileTextbox.Size = new System.Drawing.Size(419, 44);
            this.uploadImageFromFileTextbox.TabIndex = 29;
            // 
            // printingButtonsPanel
            // 
            this.printingButtonsPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.printingButtonsPanel.BackColor = System.Drawing.Color.Transparent;
            this.printingButtonsPanel.ColumnCount = 3;
            this.tableLayoutPanel1.SetColumnSpan(this.printingButtonsPanel, 2);
            this.printingButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.printingButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.printingButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.printingButtonsPanel.Controls.Add(this.startPrintingButton, 0, 1);
            this.printingButtonsPanel.Controls.Add(this.generateGcodeButton, 0, 0);
            this.printingButtonsPanel.Controls.Add(this.stopPrintingButton, 2, 1);
            this.printingButtonsPanel.Controls.Add(this.pausePrintingButton, 1, 1);
            this.printingButtonsPanel.Location = new System.Drawing.Point(3, 55);
            this.printingButtonsPanel.Name = "printingButtonsPanel";
            this.printingButtonsPanel.RowCount = 1;
            this.printingButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.printingButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.printingButtonsPanel.Size = new System.Drawing.Size(598, 83);
            this.printingButtonsPanel.TabIndex = 25;
            // 
            // startPrintingButton
            // 
            this.startPrintingButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startPrintingButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.startPrintingButton.BackgroundImage = global::DavinciBotView.Properties.Resources.actualDarkestbutton;
            this.startPrintingButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.startPrintingButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.startPrintingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startPrintingButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.startPrintingButton.Location = new System.Drawing.Point(3, 43);
            this.startPrintingButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.startPrintingButton.Name = "startPrintingButton";
            this.startPrintingButton.Size = new System.Drawing.Size(196, 38);
            this.startPrintingButton.TabIndex = 6;
            this.startPrintingButton.Text = "Start Printing";
            this.startPrintingButton.UseVisualStyleBackColor = false;
            this.startPrintingButton.Click += new System.EventHandler(this.StartPrintingButton_Click);
            // 
            // generateGcodeButton
            // 
            this.generateGcodeButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.generateGcodeButton.AutoSize = true;
            this.generateGcodeButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.generateGcodeButton.BackgroundImage = global::DavinciBotView.Properties.Resources.actualDarkestbutton;
            this.generateGcodeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.printingButtonsPanel.SetColumnSpan(this.generateGcodeButton, 3);
            this.generateGcodeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.generateGcodeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateGcodeButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.generateGcodeButton.Location = new System.Drawing.Point(13, 2);
            this.generateGcodeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.generateGcodeButton.Name = "generateGcodeButton";
            this.generateGcodeButton.Size = new System.Drawing.Size(572, 37);
            this.generateGcodeButton.TabIndex = 4;
            this.generateGcodeButton.Tag = "EditingOptionsButton";
            this.generateGcodeButton.Text = "Generate G-Code";
            this.generateGcodeButton.UseCompatibleTextRendering = true;
            this.generateGcodeButton.UseVisualStyleBackColor = false;
            this.generateGcodeButton.Click += new System.EventHandler(this.GenerateGcodeButton_Click);
            // 
            // stopPrintingButton
            // 
            this.stopPrintingButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.stopPrintingButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.stopPrintingButton.BackgroundImage = global::DavinciBotView.Properties.Resources.actualDarkestbutton;
            this.stopPrintingButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.stopPrintingButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.stopPrintingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopPrintingButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.stopPrintingButton.Location = new System.Drawing.Point(420, 43);
            this.stopPrintingButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stopPrintingButton.Name = "stopPrintingButton";
            this.stopPrintingButton.Size = new System.Drawing.Size(171, 38);
            this.stopPrintingButton.TabIndex = 3;
            this.stopPrintingButton.Tag = "StopButton";
            this.stopPrintingButton.Text = "Stop Printing";
            this.stopPrintingButton.UseVisualStyleBackColor = false;
            this.stopPrintingButton.Click += new System.EventHandler(this.stopPrintingButton_Click);
            // 
            // pausePrintingButton
            // 
            this.pausePrintingButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pausePrintingButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pausePrintingButton.BackgroundImage = global::DavinciBotView.Properties.Resources.actualDarkestbutton;
            this.pausePrintingButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pausePrintingButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pausePrintingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pausePrintingButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.pausePrintingButton.Location = new System.Drawing.Point(205, 43);
            this.pausePrintingButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pausePrintingButton.Name = "pausePrintingButton";
            this.pausePrintingButton.Size = new System.Drawing.Size(206, 38);
            this.pausePrintingButton.TabIndex = 36;
            this.pausePrintingButton.Tag = "StopButton";
            this.pausePrintingButton.Text = "Pause Printing";
            this.pausePrintingButton.UseVisualStyleBackColor = false;
            this.pausePrintingButton.Click += new System.EventHandler(this.pausePrintingButton_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 2);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.LoadGCodeFromFileButton, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.loadedGcodeTextBox, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(836, 64);
            this.tableLayoutPanel2.TabIndex = 29;
            // 
            // LoadGCodeFromFileButton
            // 
            this.LoadGCodeFromFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoadGCodeFromFileButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LoadGCodeFromFileButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.LoadGCodeFromFileButton.BackgroundImage = global::DavinciBotView.Properties.Resources.actualDarkestbutton;
            this.LoadGCodeFromFileButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LoadGCodeFromFileButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.LoadGCodeFromFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LoadGCodeFromFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadGCodeFromFileButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LoadGCodeFromFileButton.Location = new System.Drawing.Point(422, 3);
            this.LoadGCodeFromFileButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.LoadGCodeFromFileButton.Name = "LoadGCodeFromFileButton";
            this.tableLayoutPanel2.SetRowSpan(this.LoadGCodeFromFileButton, 2);
            this.LoadGCodeFromFileButton.Size = new System.Drawing.Size(410, 56);
            this.LoadGCodeFromFileButton.TabIndex = 2;
            this.LoadGCodeFromFileButton.Text = "Load G-Code From File";
            this.LoadGCodeFromFileButton.UseVisualStyleBackColor = false;
            this.LoadGCodeFromFileButton.Click += new System.EventHandler(this.LoadGCodeFromFileButton_Click);
            // 
            // loadedGcodeTextBox
            // 
            this.loadedGcodeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.loadedGcodeTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.loadedGcodeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadedGcodeTextBox.ForeColor = System.Drawing.Color.White;
            this.loadedGcodeTextBox.Location = new System.Drawing.Point(4, 4);
            this.loadedGcodeTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.loadedGcodeTextBox.Name = "loadedGcodeTextBox";
            this.loadedGcodeTextBox.Size = new System.Drawing.Size(410, 44);
            this.loadedGcodeTextBox.TabIndex = 29;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.printingButtonsPanel, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1086, 734);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.00787F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.99213F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(846, 197);
            this.tableLayoutPanel1.TabIndex = 27;
            // 
            // recentPicture0
            // 
            this.recentPicture0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.recentPicture0.Location = new System.Drawing.Point(19, 19);
            this.recentPicture0.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.recentPicture0.Name = "recentPicture0";
            this.recentPicture0.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.recentPicture0.Size = new System.Drawing.Size(278, 208);
            this.recentPicture0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.recentPicture0.TabIndex = 30;
            this.recentPicture0.TabStop = false;
            this.recentPicture0.Click += new System.EventHandler(this.recentPicture0_Click);
            // 
            // recentPicture1
            // 
            this.recentPicture1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.recentPicture1.Location = new System.Drawing.Point(305, 19);
            this.recentPicture1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.recentPicture1.Name = "recentPicture1";
            this.recentPicture1.Size = new System.Drawing.Size(278, 208);
            this.recentPicture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.recentPicture1.TabIndex = 31;
            this.recentPicture1.TabStop = false;
            this.recentPicture1.Click += new System.EventHandler(this.recentPicture1_Click);
            // 
            // recentPicture2
            // 
            this.recentPicture2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.recentPicture2.Location = new System.Drawing.Point(591, 19);
            this.recentPicture2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.recentPicture2.Name = "recentPicture2";
            this.recentPicture2.Size = new System.Drawing.Size(278, 208);
            this.recentPicture2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.recentPicture2.TabIndex = 32;
            this.recentPicture2.TabStop = false;
            this.recentPicture2.Click += new System.EventHandler(this.recentPicture2_Click);
            // 
            // recentPicture4
            // 
            this.recentPicture4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.recentPicture4.Location = new System.Drawing.Point(1163, 19);
            this.recentPicture4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.recentPicture4.Name = "recentPicture4";
            this.recentPicture4.Size = new System.Drawing.Size(278, 208);
            this.recentPicture4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.recentPicture4.TabIndex = 33;
            this.recentPicture4.TabStop = false;
            this.recentPicture4.Click += new System.EventHandler(this.recentPicture4_Click);
            // 
            // recentPicture3
            // 
            this.recentPicture3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.recentPicture3.Location = new System.Drawing.Point(877, 19);
            this.recentPicture3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.recentPicture3.Name = "recentPicture3";
            this.recentPicture3.Size = new System.Drawing.Size(278, 208);
            this.recentPicture3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.recentPicture3.TabIndex = 34;
            this.recentPicture3.TabStop = false;
            this.recentPicture3.Click += new System.EventHandler(this.recentPicture3_Click);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel6.AutoSize = true;
            this.tableLayoutPanel6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tableLayoutPanel6.ColumnCount = 6;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.Controls.Add(this.recentPicture5, 5, 0);
            this.tableLayoutPanel6.Controls.Add(this.recentPicture0, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.recentPicture4, 4, 0);
            this.tableLayoutPanel6.Controls.Add(this.recentPicture3, 3, 0);
            this.tableLayoutPanel6.Controls.Add(this.recentPicture1, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.recentPicture2, 2, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(165, 960);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.Padding = new System.Windows.Forms.Padding(15, 15, 15, 15);
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(1746, 246);
            this.tableLayoutPanel6.TabIndex = 35;
            // 
            // recentPicture5
            // 
            this.recentPicture5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.recentPicture5.Location = new System.Drawing.Point(1449, 19);
            this.recentPicture5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.recentPicture5.Name = "recentPicture5";
            this.recentPicture5.Size = new System.Drawing.Size(278, 208);
            this.recentPicture5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.recentPicture5.TabIndex = 36;
            this.recentPicture5.TabStop = false;
            this.recentPicture5.Click += new System.EventHandler(this.recentPicture5_Click);
            // 
            // DavinciBotView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(168F, 168F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(2075, 1334);
            this.Controls.Add(this.tableLayoutPanel6);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.previewImageBox);
            this.Controls.Add(this.OurPictureBox);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.thresholdControlPanel);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "DavinciBotView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DaVinci-Bot";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DavinciBotView_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DavinciBotView_FormClosed);
            this.Load += new System.EventHandler(this.DavinciBotView_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OurPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.previewImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdNumberBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.thresholdControlPanel.ResumeLayout(false);
            this.thresholdControlPanel.PerformLayout();
            this.trackbar1Panel.ResumeLayout(false);
            this.trackbar1Panel.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.printingButtonsPanel.ResumeLayout(false);
            this.printingButtonsPanel.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recentPicture0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recentPicture1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recentPicture2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recentPicture4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recentPicture3)).EndInit();
            this.tableLayoutPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.recentPicture5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LoadFromFileToolbarButton;
        private System.Windows.Forms.ToolStripMenuItem fromToolStripMenuItem;
        private System.Windows.Forms.PictureBox OurPictureBox;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.PictureBox previewImageBox;
        private System.Windows.Forms.CheckBox invertCheckBox;
        private System.Windows.Forms.Button startCameraButton;
        private System.Windows.Forms.Button takePictureButton;
        private System.Windows.Forms.Button saveCameraImageButton;
        private System.Windows.Forms.Button stopCameraButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown thresholdNumberBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TableLayoutPanel thresholdControlPanel;
        private System.Windows.Forms.Panel trackbar1Panel;
        private System.Windows.Forms.Button clearImageButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button uploadImageFromFileButton;
        private System.Windows.Forms.TextBox uploadImageFromFileTextbox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel printingButtonsPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button LoadGCodeFromFileButton;
        private System.Windows.Forms.TextBox loadedGcodeTextBox;
        private System.Windows.Forms.Button startPrintingButton;
        private System.Windows.Forms.Button stopPrintingButton;
        private System.Windows.Forms.Button generateGcodeButton;
        private System.Windows.Forms.PictureBox recentPicture0;
        private System.Windows.Forms.PictureBox recentPicture1;
        private System.Windows.Forms.PictureBox recentPicture2;
        private System.Windows.Forms.PictureBox recentPicture4;
        private System.Windows.Forms.PictureBox recentPicture3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.PictureBox recentPicture5;
        private System.Windows.Forms.Button pausePrintingButton;
    }
}

