﻿namespace DavinciBotView
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
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.useCameraImageButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.uploadImageFromFileButton = new System.Windows.Forms.Button();
            this.uploadImageFromFileTextbox = new System.Windows.Forms.TextBox();
            this.printingButtonsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.generateGcodeButton = new System.Windows.Forms.Button();
            this.stopPrintingButton = new System.Windows.Forms.Button();
            this.startPrintingButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.loadedGcodeTextBox = new System.Windows.Forms.TextBox();
            this.LoadGCodeFromFileButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
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
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1482, 28);
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
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
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
            this.loadImageToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.loadImageToolStripMenuItem.Text = "Load Image";
            // 
            // LoadFromFileToolbarButton
            // 
            this.LoadFromFileToolbarButton.Name = "LoadFromFileToolbarButton";
            this.LoadFromFileToolbarButton.Size = new System.Drawing.Size(224, 26);
            this.LoadFromFileToolbarButton.Text = "From File";
            this.LoadFromFileToolbarButton.Click += new System.EventHandler(this.LoadFromFileToolbarButton_Click);
            // 
            // fromToolStripMenuItem
            // 
            this.fromToolStripMenuItem.Name = "fromToolStripMenuItem";
            this.fromToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.fromToolStripMenuItem.Text = "From Camera";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.saveToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // OurPictureBox
            // 
            this.OurPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.OurPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(30)))));
            this.OurPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OurPictureBox.Location = new System.Drawing.Point(10, 53);
            this.OurPictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OurPictureBox.Name = "OurPictureBox";
            this.OurPictureBox.Size = new System.Drawing.Size(610, 444);
            this.OurPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.OurPictureBox.TabIndex = 1;
            this.OurPictureBox.TabStop = false;
            this.OurPictureBox.Click += new System.EventHandler(this.ImageToBeDrawnBox_Click);
            // 
            // previewImageBox
            // 
            this.previewImageBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.previewImageBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(30)))));
            this.previewImageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.previewImageBox.Location = new System.Drawing.Point(668, 53);
            this.previewImageBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.previewImageBox.Name = "previewImageBox";
            this.previewImageBox.Size = new System.Drawing.Size(610, 444);
            this.previewImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.previewImageBox.TabIndex = 7;
            this.previewImageBox.TabStop = false;
            // 
            // invertCheckBox
            // 
            this.invertCheckBox.BackColor = System.Drawing.SystemColors.Control;
            this.invertCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invertCheckBox.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.invertCheckBox.Location = new System.Drawing.Point(288, 3);
            this.invertCheckBox.Name = "invertCheckBox";
            this.invertCheckBox.Size = new System.Drawing.Size(313, 30);
            this.invertCheckBox.TabIndex = 9;
            this.invertCheckBox.Text = "Invert Contour";
            this.invertCheckBox.UseVisualStyleBackColor = false;
            this.invertCheckBox.CheckedChanged += new System.EventHandler(this.InvertCheckBox_CheckedChanged);
            this.invertCheckBox.Click += new System.EventHandler(this.InvertCheckBox_Click);
            // 
            // startCameraButton
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.startCameraButton, 2);
            this.startCameraButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startCameraButton.Location = new System.Drawing.Point(3, 3);
            this.startCameraButton.Name = "startCameraButton";
            this.startCameraButton.Size = new System.Drawing.Size(603, 38);
            this.startCameraButton.TabIndex = 12;
            this.startCameraButton.Text = "Use Camera";
            this.startCameraButton.UseVisualStyleBackColor = true;
            this.startCameraButton.Click += new System.EventHandler(this.StartCameraButton_Click);
            // 
            // takePictureButton
            // 
            this.takePictureButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.takePictureButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.takePictureButton.Location = new System.Drawing.Point(3, 3);
            this.takePictureButton.Name = "takePictureButton";
            this.takePictureButton.Size = new System.Drawing.Size(295, 38);
            this.takePictureButton.TabIndex = 13;
            this.takePictureButton.Text = "Take Picture";
            this.takePictureButton.UseVisualStyleBackColor = false;
            this.takePictureButton.Click += new System.EventHandler(this.TakePictureButton_Click);
            // 
            // saveCameraImageButton
            // 
            this.saveCameraImageButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.saveCameraImageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveCameraImageButton.Location = new System.Drawing.Point(304, 3);
            this.saveCameraImageButton.Name = "saveCameraImageButton";
            this.saveCameraImageButton.Size = new System.Drawing.Size(296, 38);
            this.saveCameraImageButton.TabIndex = 14;
            this.saveCameraImageButton.Text = "Save Image";
            this.saveCameraImageButton.UseVisualStyleBackColor = false;
            // 
            // stopCameraButton
            // 
            this.stopCameraButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tableLayoutPanel3.SetColumnSpan(this.stopCameraButton, 2);
            this.stopCameraButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopCameraButton.Location = new System.Drawing.Point(3, 111);
            this.stopCameraButton.Name = "stopCameraButton";
            this.stopCameraButton.Size = new System.Drawing.Size(603, 38);
            this.stopCameraButton.TabIndex = 15;
            this.stopCameraButton.Text = "Close Camera";
            this.stopCameraButton.UseVisualStyleBackColor = false;
            this.stopCameraButton.Click += new System.EventHandler(this.StopCameraButton_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(190, 547);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 0);
            this.panel1.TabIndex = 21;
            // 
            // thresholdNumberBox
            // 
            this.thresholdNumberBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thresholdNumberBox.Location = new System.Drawing.Point(3, 3);
            this.thresholdNumberBox.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.thresholdNumberBox.Name = "thresholdNumberBox";
            this.thresholdNumberBox.Size = new System.Drawing.Size(279, 32);
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
            this.label4.Location = new System.Drawing.Point(566, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "200";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(282, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "100";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(3, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "0";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(-3, 12);
            this.trackBar1.Maximum = 200;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(601, 56);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.TickFrequency = 20;
            this.trackBar1.Value = 100;
            this.trackBar1.Scroll += new System.EventHandler(this.TrackBar1_Scroll);
            this.trackBar1.ValueChanged += new System.EventHandler(this.TrackBar1_ValueChanged);
            // 
            // thresholdControlPanel
            // 
            this.thresholdControlPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.thresholdControlPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.thresholdControlPanel.ColumnCount = 2;
            this.thresholdControlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47F));
            this.thresholdControlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53F));
            this.thresholdControlPanel.Controls.Add(this.thresholdNumberBox, 0, 0);
            this.thresholdControlPanel.Controls.Add(this.invertCheckBox, 1, 0);
            this.thresholdControlPanel.Controls.Add(this.trackbar1Panel, 0, 1);
            this.thresholdControlPanel.Location = new System.Drawing.Point(671, 516);
            this.thresholdControlPanel.Name = "thresholdControlPanel";
            this.thresholdControlPanel.RowCount = 2;
            this.thresholdControlPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.thresholdControlPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.thresholdControlPanel.Size = new System.Drawing.Size(607, 115);
            this.thresholdControlPanel.TabIndex = 24;
            this.thresholdControlPanel.Click += new System.EventHandler(this.ThresholdControlPanel_Click);
            // 
            // trackbar1Panel
            // 
            this.trackbar1Panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.trackbar1Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.thresholdControlPanel.SetColumnSpan(this.trackbar1Panel, 2);
            this.trackbar1Panel.Controls.Add(this.label6);
            this.trackbar1Panel.Controls.Add(this.label4);
            this.trackbar1Panel.Controls.Add(this.label5);
            this.trackbar1Panel.Controls.Add(this.trackBar1);
            this.trackbar1Panel.Location = new System.Drawing.Point(3, 41);
            this.trackbar1Panel.Name = "trackbar1Panel";
            this.trackbar1Panel.Size = new System.Drawing.Size(601, 96);
            this.trackbar1Panel.TabIndex = 22;
            this.trackbar1Panel.Click += new System.EventHandler(this.Trackbar1Panel_Click);
            // 
            // useCameraImageButton
            // 
            this.useCameraImageButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tableLayoutPanel3.SetColumnSpan(this.useCameraImageButton, 2);
            this.useCameraImageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.useCameraImageButton.Location = new System.Drawing.Point(3, 165);
            this.useCameraImageButton.Name = "useCameraImageButton";
            this.useCameraImageButton.Size = new System.Drawing.Size(603, 38);
            this.useCameraImageButton.TabIndex = 26;
            this.useCameraImageButton.Text = "Use This Image";
            this.useCameraImageButton.UseVisualStyleBackColor = false;
            this.useCameraImageButton.Click += new System.EventHandler(this.UseCameraImageButton_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.stopCameraButton, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.startCameraButton, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.useCameraImageButton, 0, 3);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(11, 575);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(609, 218);
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
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 57);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(603, 48);
            this.tableLayoutPanel5.TabIndex = 25;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.uploadImageFromFileButton, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.uploadImageFromFileTextbox, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(10, 514);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(610, 42);
            this.tableLayoutPanel4.TabIndex = 29;
            // 
            // uploadImageFromFileButton
            // 
            this.uploadImageFromFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uploadImageFromFileButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.uploadImageFromFileButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.uploadImageFromFileButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.uploadImageFromFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadImageFromFileButton.Location = new System.Drawing.Point(308, 2);
            this.uploadImageFromFileButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uploadImageFromFileButton.Name = "uploadImageFromFileButton";
            this.tableLayoutPanel4.SetRowSpan(this.uploadImageFromFileButton, 2);
            this.uploadImageFromFileButton.Size = new System.Drawing.Size(299, 38);
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
            this.uploadImageFromFileTextbox.Location = new System.Drawing.Point(3, 3);
            this.uploadImageFromFileTextbox.Name = "uploadImageFromFileTextbox";
            this.uploadImageFromFileTextbox.Size = new System.Drawing.Size(299, 34);
            this.uploadImageFromFileTextbox.TabIndex = 29;
            // 
            // printingButtonsPanel
            // 
            this.printingButtonsPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.printingButtonsPanel.BackColor = System.Drawing.Color.Transparent;
            this.printingButtonsPanel.ColumnCount = 2;
            this.tableLayoutPanel1.SetColumnSpan(this.printingButtonsPanel, 2);
            this.printingButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.printingButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.printingButtonsPanel.Controls.Add(this.startPrintingButton, 0, 1);
            this.printingButtonsPanel.Controls.Add(this.stopPrintingButton, 1, 1);
            this.printingButtonsPanel.Controls.Add(this.generateGcodeButton, 0, 0);
            this.printingButtonsPanel.Location = new System.Drawing.Point(3, 58);
            this.printingButtonsPanel.Name = "printingButtonsPanel";
            this.printingButtonsPanel.RowCount = 1;
            this.printingButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.printingButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.printingButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.printingButtonsPanel.Size = new System.Drawing.Size(604, 90);
            this.printingButtonsPanel.TabIndex = 25;
            // 
            // generateGcodeButton
            // 
            this.generateGcodeButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.generateGcodeButton.AutoSize = true;
            this.generateGcodeButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.printingButtonsPanel.SetColumnSpan(this.generateGcodeButton, 2);
            this.generateGcodeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateGcodeButton.Location = new System.Drawing.Point(3, 4);
            this.generateGcodeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.generateGcodeButton.Name = "generateGcodeButton";
            this.generateGcodeButton.Size = new System.Drawing.Size(598, 36);
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
            this.stopPrintingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopPrintingButton.Location = new System.Drawing.Point(305, 50);
            this.stopPrintingButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stopPrintingButton.Name = "stopPrintingButton";
            this.stopPrintingButton.Size = new System.Drawing.Size(296, 35);
            this.stopPrintingButton.TabIndex = 3;
            this.stopPrintingButton.Tag = "StopButton";
            this.stopPrintingButton.Text = "Stop Printing";
            this.stopPrintingButton.UseVisualStyleBackColor = false;
            // 
            // startPrintingButton
            // 
            this.startPrintingButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startPrintingButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.startPrintingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startPrintingButton.Location = new System.Drawing.Point(3, 50);
            this.startPrintingButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.startPrintingButton.Name = "startPrintingButton";
            this.startPrintingButton.Size = new System.Drawing.Size(296, 34);
            this.startPrintingButton.TabIndex = 6;
            this.startPrintingButton.Text = "Start Printing";
            this.startPrintingButton.UseVisualStyleBackColor = false;
            this.startPrintingButton.Click += new System.EventHandler(this.startPrintingButton_Click);
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(604, 49);
            this.tableLayoutPanel2.TabIndex = 29;
            // 
            // loadedGcodeTextBox
            // 
            this.loadedGcodeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.loadedGcodeTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.loadedGcodeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadedGcodeTextBox.ForeColor = System.Drawing.Color.White;
            this.loadedGcodeTextBox.Location = new System.Drawing.Point(3, 3);
            this.loadedGcodeTextBox.Name = "loadedGcodeTextBox";
            this.loadedGcodeTextBox.Size = new System.Drawing.Size(296, 34);
            this.loadedGcodeTextBox.TabIndex = 29;
            // 
            // LoadGCodeFromFileButton
            // 
            this.LoadGCodeFromFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoadGCodeFromFileButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LoadGCodeFromFileButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.LoadGCodeFromFileButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.LoadGCodeFromFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadGCodeFromFileButton.Location = new System.Drawing.Point(305, 2);
            this.LoadGCodeFromFileButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LoadGCodeFromFileButton.Name = "LoadGCodeFromFileButton";
            this.tableLayoutPanel2.SetRowSpan(this.LoadGCodeFromFileButton, 2);
            this.LoadGCodeFromFileButton.Size = new System.Drawing.Size(296, 38);
            this.LoadGCodeFromFileButton.TabIndex = 2;
            this.LoadGCodeFromFileButton.Text = "Load G-Code From File";
            this.LoadGCodeFromFileButton.UseVisualStyleBackColor = false;
            this.LoadGCodeFromFileButton.Click += new System.EventHandler(this.LoadGCodeFromFileButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.printingButtonsPanel, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(668, 642);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.00787F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.99213F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(610, 151);
            this.tableLayoutPanel1.TabIndex = 27;
            // 
            // DavinciBotView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1482, 1055);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.previewImageBox);
            this.Controls.Add(this.OurPictureBox);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.thresholdControlPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DavinciBotView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DaVinci-Bot";
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
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
        private System.Windows.Forms.Button useCameraImageButton;
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
    }
}

