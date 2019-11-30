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
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OurPictureBox = new System.Windows.Forms.PictureBox();
            this.LoadGCodeFromFileButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.generateGcodeButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.previewImageBox = new System.Windows.Forms.PictureBox();
            this.invertCheckBox = new System.Windows.Forms.CheckBox();
            this.cameraBox = new System.Windows.Forms.PictureBox();
            this.startCameraButton = new System.Windows.Forms.Button();
            this.captureImageButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.stopCameraButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.thresholdNumberBox = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.thresholdControlPanel = new System.Windows.Forms.TableLayoutPanel();
            this.trackbar1Panel = new System.Windows.Forms.Panel();
            this.printingButtonsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OurPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.previewImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cameraBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdNumberBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.thresholdControlPanel.SuspendLayout();
            this.trackbar1Panel.SuspendLayout();
            this.printingButtonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
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
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadImageToolStripMenuItem
            // 
            this.loadImageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoadFromFileToolbarButton,
            this.fromToolStripMenuItem});
            this.loadImageToolStripMenuItem.Name = "loadImageToolStripMenuItem";
            this.loadImageToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.loadImageToolStripMenuItem.Text = "Load Image";
            // 
            // LoadFromFileToolbarButton
            // 
            this.LoadFromFileToolbarButton.Name = "LoadFromFileToolbarButton";
            this.LoadFromFileToolbarButton.Size = new System.Drawing.Size(181, 26);
            this.LoadFromFileToolbarButton.Text = "From File";
            this.LoadFromFileToolbarButton.Click += new System.EventHandler(this.LoadFromFileToolbarButton_Click);
            // 
            // fromToolStripMenuItem
            // 
            this.fromToolStripMenuItem.Name = "fromToolStripMenuItem";
            this.fromToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.fromToolStripMenuItem.Text = "From Camera";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // OurPictureBox
            // 
            this.OurPictureBox.BackColor = System.Drawing.Color.LightGray;
            this.OurPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OurPictureBox.Location = new System.Drawing.Point(10, 53);
            this.OurPictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OurPictureBox.Name = "OurPictureBox";
            this.OurPictureBox.Size = new System.Drawing.Size(375, 275);
            this.OurPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.OurPictureBox.TabIndex = 1;
            this.OurPictureBox.TabStop = false;
            this.OurPictureBox.Click += new System.EventHandler(this.ImageToBeDrawnBox_Click);
            // 
            // LoadGCodeFromFileButton
            // 
            this.LoadGCodeFromFileButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LoadGCodeFromFileButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LoadGCodeFromFileButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.LoadGCodeFromFileButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.LoadGCodeFromFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadGCodeFromFileButton.Location = new System.Drawing.Point(10, 4);
            this.LoadGCodeFromFileButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LoadGCodeFromFileButton.Name = "LoadGCodeFromFileButton";
            this.LoadGCodeFromFileButton.Size = new System.Drawing.Size(230, 60);
            this.LoadGCodeFromFileButton.TabIndex = 2;
            this.LoadGCodeFromFileButton.Text = "Load G-Code From File";
            this.LoadGCodeFromFileButton.UseVisualStyleBackColor = false;
            this.LoadGCodeFromFileButton.Click += new System.EventHandler(this.LoadGCodeFromFileButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopButton.Location = new System.Drawing.Point(10, 214);
            this.StopButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(230, 50);
            this.StopButton.TabIndex = 3;
            this.StopButton.Tag = "StopButton";
            this.StopButton.Text = "Stop Printing";
            this.StopButton.UseVisualStyleBackColor = true;
            // 
            // generateGcodeButton
            // 
            this.generateGcodeButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.generateGcodeButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.generateGcodeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateGcodeButton.Location = new System.Drawing.Point(10, 77);
            this.generateGcodeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.generateGcodeButton.Name = "generateGcodeButton";
            this.generateGcodeButton.Size = new System.Drawing.Size(230, 50);
            this.generateGcodeButton.TabIndex = 4;
            this.generateGcodeButton.Tag = "EditingOptionsButton";
            this.generateGcodeButton.Text = "Generate G-Code";
            this.generateGcodeButton.UseCompatibleTextRendering = true;
            this.generateGcodeButton.UseVisualStyleBackColor = false;
            this.generateGcodeButton.Click += new System.EventHandler(this.GenerateGcodeButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StartButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.Location = new System.Drawing.Point(10, 145);
            this.StartButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(230, 50);
            this.StartButton.TabIndex = 6;
            this.StartButton.Text = "Start Printing";
            this.StartButton.UseVisualStyleBackColor = false;
            // 
            // previewImageBox
            // 
            this.previewImageBox.BackColor = System.Drawing.Color.LightGray;
            this.previewImageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.previewImageBox.Location = new System.Drawing.Point(411, 52);
            this.previewImageBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.previewImageBox.Name = "previewImageBox";
            this.previewImageBox.Size = new System.Drawing.Size(375, 275);
            this.previewImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.previewImageBox.TabIndex = 7;
            this.previewImageBox.TabStop = false;
            // 
            // invertCheckBox
            // 
            this.invertCheckBox.AutoSize = true;
            this.invertCheckBox.BackColor = System.Drawing.SystemColors.Control;
            this.invertCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invertCheckBox.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.invertCheckBox.Location = new System.Drawing.Point(179, 3);
            this.invertCheckBox.Name = "invertCheckBox";
            this.invertCheckBox.Size = new System.Drawing.Size(171, 30);
            this.invertCheckBox.TabIndex = 9;
            this.invertCheckBox.Text = "Invert Contour";
            this.invertCheckBox.UseVisualStyleBackColor = false;
            this.invertCheckBox.CheckedChanged += new System.EventHandler(this.invertCheckBox_CheckedChanged);
            this.invertCheckBox.Click += new System.EventHandler(this.invertCheckBox_Click);
            // 
            // cameraBox
            // 
            this.cameraBox.BackColor = System.Drawing.Color.LightGray;
            this.cameraBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cameraBox.Location = new System.Drawing.Point(803, 52);
            this.cameraBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cameraBox.Name = "cameraBox";
            this.cameraBox.Size = new System.Drawing.Size(375, 275);
            this.cameraBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cameraBox.TabIndex = 11;
            this.cameraBox.TabStop = false;
            // 
            // startCameraButton
            // 
            this.startCameraButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startCameraButton.Location = new System.Drawing.Point(860, 349);
            this.startCameraButton.Name = "startCameraButton";
            this.startCameraButton.Size = new System.Drawing.Size(256, 35);
            this.startCameraButton.TabIndex = 12;
            this.startCameraButton.Text = "Start Camera";
            this.startCameraButton.UseVisualStyleBackColor = true;
            this.startCameraButton.Click += new System.EventHandler(this.startCameraButton_Click);
            // 
            // captureImageButton
            // 
            this.captureImageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.captureImageButton.Location = new System.Drawing.Point(860, 389);
            this.captureImageButton.Name = "captureImageButton";
            this.captureImageButton.Size = new System.Drawing.Size(256, 38);
            this.captureImageButton.TabIndex = 13;
            this.captureImageButton.Text = "Capture Image";
            this.captureImageButton.UseVisualStyleBackColor = true;
            this.captureImageButton.Click += new System.EventHandler(this.captureImageButton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(860, 432);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(256, 38);
            this.button1.TabIndex = 14;
            this.button1.Text = "Save Image";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // stopCameraButton
            // 
            this.stopCameraButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopCameraButton.Location = new System.Drawing.Point(860, 474);
            this.stopCameraButton.Name = "stopCameraButton";
            this.stopCameraButton.Size = new System.Drawing.Size(256, 38);
            this.stopCameraButton.TabIndex = 15;
            this.stopCameraButton.Text = "Stop Camera";
            this.stopCameraButton.UseVisualStyleBackColor = true;
            this.stopCameraButton.Click += new System.EventHandler(this.stopCameraButton_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(189, 556);
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
            this.thresholdNumberBox.Size = new System.Drawing.Size(132, 32);
            this.thresholdNumberBox.TabIndex = 10;
            this.thresholdNumberBox.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.thresholdNumberBox.ValueChanged += new System.EventHandler(this.thresholdNumberBox_ValueChanged);
            this.thresholdNumberBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.thresholdNumberBox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(326, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "200";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(163, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "100";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(3, 51);
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
            this.trackBar1.Size = new System.Drawing.Size(361, 56);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.TickFrequency = 20;
            this.trackBar1.Value = 100;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // thresholdControlPanel
            // 
            this.thresholdControlPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.thresholdControlPanel.ColumnCount = 2;
            this.thresholdControlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47F));
            this.thresholdControlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53F));
            this.thresholdControlPanel.Controls.Add(this.thresholdNumberBox, 0, 0);
            this.thresholdControlPanel.Controls.Add(this.invertCheckBox, 1, 0);
            this.thresholdControlPanel.Controls.Add(this.trackbar1Panel, 0, 1);
            this.thresholdControlPanel.Location = new System.Drawing.Point(412, 348);
            this.thresholdControlPanel.Name = "thresholdControlPanel";
            this.thresholdControlPanel.RowCount = 2;
            this.thresholdControlPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.thresholdControlPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.thresholdControlPanel.Size = new System.Drawing.Size(375, 115);
            this.thresholdControlPanel.TabIndex = 24;
            this.thresholdControlPanel.Click += new System.EventHandler(this.thresholdControlPanel_Click);
            // 
            // trackbar1Panel
            // 
            this.trackbar1Panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.trackbar1Panel.BackColor = System.Drawing.Color.Transparent;
            this.thresholdControlPanel.SetColumnSpan(this.trackbar1Panel, 2);
            this.trackbar1Panel.Controls.Add(this.label6);
            this.trackbar1Panel.Controls.Add(this.label4);
            this.trackbar1Panel.Controls.Add(this.label5);
            this.trackbar1Panel.Controls.Add(this.trackBar1);
            this.trackbar1Panel.Location = new System.Drawing.Point(3, 41);
            this.trackbar1Panel.Name = "trackbar1Panel";
            this.trackbar1Panel.Size = new System.Drawing.Size(369, 96);
            this.trackbar1Panel.TabIndex = 22;
            this.trackbar1Panel.Click += new System.EventHandler(this.trackbar1Panel_Click);
            // 
            // printingButtonsPanel
            // 
            this.printingButtonsPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.printingButtonsPanel.BackColor = System.Drawing.Color.Transparent;
            this.printingButtonsPanel.ColumnCount = 1;
            this.printingButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.printingButtonsPanel.Controls.Add(this.LoadGCodeFromFileButton, 0, 0);
            this.printingButtonsPanel.Controls.Add(this.generateGcodeButton, 0, 1);
            this.printingButtonsPanel.Controls.Add(this.StartButton, 0, 2);
            this.printingButtonsPanel.Controls.Add(this.StopButton, 0, 3);
            this.printingButtonsPanel.Location = new System.Drawing.Point(1219, 53);
            this.printingButtonsPanel.Name = "printingButtonsPanel";
            this.printingButtonsPanel.RowCount = 4;
            this.printingButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.printingButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.printingButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.printingButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.printingButtonsPanel.Size = new System.Drawing.Size(251, 274);
            this.printingButtonsPanel.TabIndex = 25;
            // 
            // DavinciBotView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1482, 1055);
            this.Controls.Add(this.printingButtonsPanel);
            this.Controls.Add(this.stopCameraButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.captureImageButton);
            this.Controls.Add(this.startCameraButton);
            this.Controls.Add(this.cameraBox);
            this.Controls.Add(this.previewImageBox);
            this.Controls.Add(this.OurPictureBox);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.thresholdControlPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DavinciBotView";
            this.Text = "DaVinci-Bot";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DavinciBotView_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DavinciBotView_FormClosed);
            this.Load += new System.EventHandler(this.DavinciBotView_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OurPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.previewImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cameraBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdNumberBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.thresholdControlPanel.ResumeLayout(false);
            this.thresholdControlPanel.PerformLayout();
            this.trackbar1Panel.ResumeLayout(false);
            this.trackbar1Panel.PerformLayout();
            this.printingButtonsPanel.ResumeLayout(false);
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
        private System.Windows.Forms.Button LoadGCodeFromFileButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Button generateGcodeButton;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.PictureBox previewImageBox;
        private System.Windows.Forms.CheckBox invertCheckBox;
        private System.Windows.Forms.PictureBox cameraBox;
        private System.Windows.Forms.Button startCameraButton;
        private System.Windows.Forms.Button captureImageButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button stopCameraButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown thresholdNumberBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TableLayoutPanel thresholdControlPanel;
        private System.Windows.Forms.Panel trackbar1Panel;
        private System.Windows.Forms.TableLayoutPanel printingButtonsPanel;
    }
}

