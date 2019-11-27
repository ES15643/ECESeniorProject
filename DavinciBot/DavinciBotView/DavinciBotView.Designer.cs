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
            this.LoadFromFileButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.ConvertImageButton = new System.Windows.Forms.Button();
            this.LoadFromCameraButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.previewImageBox = new System.Windows.Forms.PictureBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.invertCheckBox = new System.Windows.Forms.CheckBox();
            this.thresholdNumberBox = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OurPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.previewImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdNumberBox)).BeginInit();
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
            this.OurPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.OurPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OurPictureBox.Location = new System.Drawing.Point(0, 30);
            this.OurPictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OurPictureBox.Name = "OurPictureBox";
            this.OurPictureBox.Size = new System.Drawing.Size(300, 300);
            this.OurPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.OurPictureBox.TabIndex = 1;
            this.OurPictureBox.TabStop = false;
            this.OurPictureBox.Click += new System.EventHandler(this.ImageToBeDrawnBox_Click);
            // 
            // LoadFromFileButton
            // 
            this.LoadFromFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LoadFromFileButton.Location = new System.Drawing.Point(1208, 41);
            this.LoadFromFileButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LoadFromFileButton.Name = "LoadFromFileButton";
            this.LoadFromFileButton.Size = new System.Drawing.Size(196, 66);
            this.LoadFromFileButton.TabIndex = 2;
            this.LoadFromFileButton.Text = "Load From File";
            this.LoadFromFileButton.UseVisualStyleBackColor = true;
            this.LoadFromFileButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // StopButton
            // 
            this.StopButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StopButton.Location = new System.Drawing.Point(1208, 398);
            this.StopButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(196, 66);
            this.StopButton.TabIndex = 3;
            this.StopButton.Tag = "StopButton";
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            // 
            // ConvertImageButton
            // 
            this.ConvertImageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ConvertImageButton.Location = new System.Drawing.Point(1208, 215);
            this.ConvertImageButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ConvertImageButton.Name = "ConvertImageButton";
            this.ConvertImageButton.Size = new System.Drawing.Size(196, 66);
            this.ConvertImageButton.TabIndex = 4;
            this.ConvertImageButton.Tag = "EditingOptionsButton";
            this.ConvertImageButton.Text = "Convert Image File";
            this.ConvertImageButton.UseCompatibleTextRendering = true;
            this.ConvertImageButton.UseVisualStyleBackColor = true;
            this.ConvertImageButton.Click += new System.EventHandler(this.ConvertImageButton_Click);
            // 
            // LoadFromCameraButton
            // 
            this.LoadFromCameraButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LoadFromCameraButton.Location = new System.Drawing.Point(1208, 129);
            this.LoadFromCameraButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LoadFromCameraButton.Name = "LoadFromCameraButton";
            this.LoadFromCameraButton.Size = new System.Drawing.Size(196, 66);
            this.LoadFromCameraButton.TabIndex = 5;
            this.LoadFromCameraButton.Text = "Load From Camera";
            this.LoadFromCameraButton.UseVisualStyleBackColor = true;
            // 
            // StartButton
            // 
            this.StartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StartButton.Location = new System.Drawing.Point(1208, 304);
            this.StartButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(196, 66);
            this.StartButton.TabIndex = 6;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            // 
            // previewImageBox
            // 
            this.previewImageBox.BackColor = System.Drawing.Color.Transparent;
            this.previewImageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.previewImageBox.Location = new System.Drawing.Point(437, 30);
            this.previewImageBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.previewImageBox.Name = "previewImageBox";
            this.previewImageBox.Size = new System.Drawing.Size(300, 300);
            this.previewImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.previewImageBox.TabIndex = 7;
            this.previewImageBox.TabStop = false;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(0, 445);
            this.trackBar1.Maximum = 200;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(300, 56);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.TickFrequency = 20;
            this.trackBar1.Value = 100;
            this.trackBar1.Scroll += new System.EventHandler(this.ImagePreviewThresholdChanged);
            this.trackBar1.ValueChanged += new System.EventHandler(this.ImagePreviewThresholdChanged);
            this.trackBar1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackBar1_MouseUp);
            // 
            // invertCheckBox
            // 
            this.invertCheckBox.AutoSize = true;
            this.invertCheckBox.Location = new System.Drawing.Point(410, 473);
            this.invertCheckBox.Name = "invertCheckBox";
            this.invertCheckBox.Size = new System.Drawing.Size(119, 21);
            this.invertCheckBox.TabIndex = 9;
            this.invertCheckBox.Text = "Invert Contour";
            this.invertCheckBox.UseVisualStyleBackColor = true;
            this.invertCheckBox.CheckedChanged += new System.EventHandler(this.invertCheckBox_CheckedChanged);
            this.invertCheckBox.CheckStateChanged += new System.EventHandler(this.invertCheckBox_CheckStateChanged);
            // 
            // thresholdNumberBox
            // 
            this.thresholdNumberBox.Location = new System.Drawing.Point(410, 445);
            this.thresholdNumberBox.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.thresholdNumberBox.Name = "thresholdNumberBox";
            this.thresholdNumberBox.Size = new System.Drawing.Size(231, 22);
            this.thresholdNumberBox.TabIndex = 10;
            this.thresholdNumberBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.thresholdNumberBox_KeyPress);
            // 
            // DavinciBotView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1482, 1055);
            this.Controls.Add(this.thresholdNumberBox);
            this.Controls.Add(this.invertCheckBox);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.previewImageBox);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.LoadFromCameraButton);
            this.Controls.Add(this.ConvertImageButton);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.LoadFromFileButton);
            this.Controls.Add(this.OurPictureBox);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DavinciBotView";
            this.Text = "DaVinci-Bot";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DavinciBotView_FormClosing);
            this.Load += new System.EventHandler(this.DavinciBotView_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OurPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.previewImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdNumberBox)).EndInit();
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
        private System.Windows.Forms.Button LoadFromFileButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Button ConvertImageButton;
        private System.Windows.Forms.Button LoadFromCameraButton;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.PictureBox previewImageBox;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.CheckBox invertCheckBox;
        private System.Windows.Forms.NumericUpDown thresholdNumberBox;
    }
}

