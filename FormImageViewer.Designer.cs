namespace ImageViewer
{
    partial class FormImageViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormImageViewer));
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.barMenu = new System.Windows.Forms.MenuStrip();
            this.archiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.grayscaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.centeredToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.stretchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel = new System.Windows.Forms.Panel();
            this.statusStripPath = new System.Windows.Forms.StatusStrip();
            this.tssLabelPath = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.tsbModeNormal = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbModeGrayscale = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbCentered = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbStretch = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbZoom = new System.Windows.Forms.ToolStripButton();
            this.rbCentered = new System.Windows.Forms.RadioButton();
            this.rbStretch = new System.Windows.Forms.RadioButton();
            this.rbZoom = new System.Windows.Forms.RadioButton();
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.rbNormal = new System.Windows.Forms.RadioButton();
            this.rbGrayscale = new System.Windows.Forms.RadioButton();
            this.gbMode = new System.Windows.Forms.GroupBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbActualImg = new System.Windows.Forms.ComboBox();
            this.btnTwoStepsBack = new System.Windows.Forms.Button();
            this.btnTwoStepsForward = new System.Windows.Forms.Button();
            this.btnOneStepForward = new System.Windows.Forms.Button();
            this.btnOneStepBack = new System.Windows.Forms.Button();
            this.barMenu.SuspendLayout();
            this.panel.SuspendLayout();
            this.statusStripPath.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.gbSize.SuspendLayout();
            this.gbMode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(240, 6);
            // 
            // barMenu
            // 
            this.barMenu.BackColor = System.Drawing.Color.Gainsboro;
            this.barMenu.ImageScalingSize = new System.Drawing.Size(20, 25);
            this.barMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archiveToolStripMenuItem,
            this.visionToolStripMenuItem,
            this.sizeToolStripMenuItem});
            this.barMenu.Location = new System.Drawing.Point(0, 0);
            this.barMenu.Name = "barMenu";
            this.barMenu.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.barMenu.Size = new System.Drawing.Size(1795, 28);
            this.barMenu.TabIndex = 2;
            this.barMenu.Text = "menuStrip1";
            // 
            // archiveToolStripMenuItem
            // 
            this.archiveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.toolStripSeparator4,
            this.exitToolStripMenuItem});
            this.archiveToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.archiveToolStripMenuItem.Name = "archiveToolStripMenuItem";
            this.archiveToolStripMenuItem.Size = new System.Drawing.Size(46, 26);
            this.archiveToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(192, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.E)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // visionToolStripMenuItem
            // 
            this.visionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.normalToolStripMenuItem,
            this.toolStripSeparator5,
            this.grayscaleToolStripMenuItem});
            this.visionToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.visionToolStripMenuItem.Name = "visionToolStripMenuItem";
            this.visionToolStripMenuItem.Size = new System.Drawing.Size(63, 26);
            this.visionToolStripMenuItem.Text = "Vision";
            // 
            // normalToolStripMenuItem
            // 
            this.normalToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("normalToolStripMenuItem.Image")));
            this.normalToolStripMenuItem.Name = "normalToolStripMenuItem";
            this.normalToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.normalToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.normalToolStripMenuItem.Text = "Normal";
            this.normalToolStripMenuItem.Click += new System.EventHandler(this.rbNormal_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(204, 6);
            // 
            // grayscaleToolStripMenuItem
            // 
            this.grayscaleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("grayscaleToolStripMenuItem.Image")));
            this.grayscaleToolStripMenuItem.Name = "grayscaleToolStripMenuItem";
            this.grayscaleToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.grayscaleToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.grayscaleToolStripMenuItem.Text = "Grayscale";
            this.grayscaleToolStripMenuItem.Click += new System.EventHandler(this.rbGrayscale_Click);
            // 
            // sizeToolStripMenuItem
            // 
            this.sizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.centeredToolStripMenuItem,
            this.toolStripSeparator1,
            this.stretchToolStripMenuItem,
            this.toolStripSeparator2,
            this.zoomToolStripMenuItem});
            this.sizeToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.sizeToolStripMenuItem.Name = "sizeToolStripMenuItem";
            this.sizeToolStripMenuItem.Size = new System.Drawing.Size(50, 26);
            this.sizeToolStripMenuItem.Text = "Size";
            // 
            // centeredToolStripMenuItem
            // 
            this.centeredToolStripMenuItem.Name = "centeredToolStripMenuItem";
            this.centeredToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
            this.centeredToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.centeredToolStripMenuItem.Text = "Centered";
            this.centeredToolStripMenuItem.Click += new System.EventHandler(this.rbCentered_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(240, 6);
            // 
            // stretchToolStripMenuItem
            // 
            this.stretchToolStripMenuItem.Name = "stretchToolStripMenuItem";
            this.stretchToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.A)));
            this.stretchToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.stretchToolStripMenuItem.Text = "Stretch";
            this.stretchToolStripMenuItem.Click += new System.EventHandler(this.rbStretch_Click);
            // 
            // zoomToolStripMenuItem
            // 
            this.zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            this.zoomToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Z)));
            this.zoomToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.zoomToolStripMenuItem.Text = "Zoom";
            this.zoomToolStripMenuItem.Click += new System.EventHandler(this.rbZoom_Click);
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.AutoSize = true;
            this.panel.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel.BackgroundImage")));
            this.panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Controls.Add(this.statusStripPath);
            this.panel.Controls.Add(this.toolStrip);
            this.panel.Controls.Add(this.btnOneStepBack);
            this.panel.Controls.Add(this.btnOneStepForward);
            this.panel.Controls.Add(this.btnTwoStepsForward);
            this.panel.Controls.Add(this.btnTwoStepsBack);
            this.panel.Controls.Add(this.cmbActualImg);
            this.panel.Controls.Add(this.label1);
            this.panel.Controls.Add(this.pictureBox);
            this.panel.Controls.Add(this.gbMode);
            this.panel.Controls.Add(this.gbSize);
            this.panel.Controls.Add(this.barMenu);
            this.panel.ForeColor = System.Drawing.Color.White;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1797, 845);
            this.panel.TabIndex = 1;
            // 
            // statusStripPath
            // 
            this.statusStripPath.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.statusStripPath.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStripPath.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssLabelPath});
            this.statusStripPath.Location = new System.Drawing.Point(0, 821);
            this.statusStripPath.Name = "statusStripPath";
            this.statusStripPath.Size = new System.Drawing.Size(1795, 22);
            this.statusStripPath.TabIndex = 14;
            this.statusStripPath.Text = "statusStrip1";
            // 
            // tssLabelPath
            // 
            this.tssLabelPath.ForeColor = System.Drawing.Color.DarkBlue;
            this.tssLabelPath.Name = "tssLabelPath";
            this.tssLabelPath.Size = new System.Drawing.Size(0, 16);
            // 
            // toolStrip
            // 
            this.toolStrip.BackColor = System.Drawing.Color.DimGray;
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbModeNormal,
            this.toolStripSeparator3,
            this.tsbModeGrayscale,
            this.toolStripSeparator6,
            this.tsbCentered,
            this.toolStripSeparator7,
            this.tsbStretch,
            this.toolStripSeparator8,
            this.tsbZoom});
            this.toolStrip.Location = new System.Drawing.Point(0, 28);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1795, 27);
            this.toolStrip.TabIndex = 13;
            this.toolStrip.Text = "toolStrip1";
            // 
            // tsbModeNormal
            // 
            this.tsbModeNormal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbModeNormal.Image = ((System.Drawing.Image)(resources.GetObject("tsbModeNormal.Image")));
            this.tsbModeNormal.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbModeNormal.Name = "tsbModeNormal";
            this.tsbModeNormal.Size = new System.Drawing.Size(29, 28);
            this.tsbModeNormal.Text = "Normal Color";
            this.tsbModeNormal.Click += new System.EventHandler(this.rbNormal_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 31);
            // 
            // tsbModeGrayscale
            // 
            this.tsbModeGrayscale.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbModeGrayscale.Image = ((System.Drawing.Image)(resources.GetObject("tsbModeGrayscale.Image")));
            this.tsbModeGrayscale.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbModeGrayscale.Name = "tsbModeGrayscale";
            this.tsbModeGrayscale.Size = new System.Drawing.Size(29, 28);
            this.tsbModeGrayscale.Text = "GrayScale Color";
            this.tsbModeGrayscale.Click += new System.EventHandler(this.rbGrayscale_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 31);
            // 
            // tsbCentered
            // 
            this.tsbCentered.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCentered.Image = ((System.Drawing.Image)(resources.GetObject("tsbCentered.Image")));
            this.tsbCentered.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCentered.Name = "tsbCentered";
            this.tsbCentered.Size = new System.Drawing.Size(29, 28);
            this.tsbCentered.Text = "Centered Image";
            this.tsbCentered.Click += new System.EventHandler(this.rbCentered_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 31);
            // 
            // tsbStretch
            // 
            this.tsbStretch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbStretch.Image = ((System.Drawing.Image)(resources.GetObject("tsbStretch.Image")));
            this.tsbStretch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbStretch.Name = "tsbStretch";
            this.tsbStretch.Size = new System.Drawing.Size(29, 28);
            this.tsbStretch.Text = "Strech Image";
            this.tsbStretch.Click += new System.EventHandler(this.rbStretch_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 31);
            // 
            // tsbZoom
            // 
            this.tsbZoom.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbZoom.Image = ((System.Drawing.Image)(resources.GetObject("tsbZoom.Image")));
            this.tsbZoom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbZoom.Name = "tsbZoom";
            this.tsbZoom.Size = new System.Drawing.Size(29, 28);
            this.tsbZoom.Text = "Zoom Image";
            this.tsbZoom.Click += new System.EventHandler(this.rbZoom_Click);
            // 
            // rbCentered
            // 
            this.rbCentered.AutoSize = true;
            this.rbCentered.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbCentered.Location = new System.Drawing.Point(30, 59);
            this.rbCentered.Name = "rbCentered";
            this.rbCentered.Size = new System.Drawing.Size(114, 29);
            this.rbCentered.TabIndex = 0;
            this.rbCentered.Text = "Centered";
            this.rbCentered.UseVisualStyleBackColor = true;
            this.rbCentered.Click += new System.EventHandler(this.rbCentered_Click);
            // 
            // rbStretch
            // 
            this.rbStretch.AutoSize = true;
            this.rbStretch.Checked = true;
            this.rbStretch.Location = new System.Drawing.Point(30, 124);
            this.rbStretch.Name = "rbStretch";
            this.rbStretch.Size = new System.Drawing.Size(95, 29);
            this.rbStretch.TabIndex = 1;
            this.rbStretch.TabStop = true;
            this.rbStretch.Text = "Stretch";
            this.rbStretch.UseVisualStyleBackColor = true;
            this.rbStretch.Click += new System.EventHandler(this.rbStretch_Click);
            // 
            // rbZoom
            // 
            this.rbZoom.AutoSize = true;
            this.rbZoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbZoom.Location = new System.Drawing.Point(30, 191);
            this.rbZoom.Name = "rbZoom";
            this.rbZoom.Size = new System.Drawing.Size(83, 29);
            this.rbZoom.TabIndex = 2;
            this.rbZoom.Text = "Zoom";
            this.rbZoom.UseVisualStyleBackColor = true;
            this.rbZoom.Click += new System.EventHandler(this.rbZoom_Click);
            // 
            // gbSize
            // 
            this.gbSize.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbSize.BackColor = System.Drawing.Color.Transparent;
            this.gbSize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gbSize.Controls.Add(this.rbZoom);
            this.gbSize.Controls.Add(this.rbStretch);
            this.gbSize.Controls.Add(this.rbCentered);
            this.gbSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gbSize.ForeColor = System.Drawing.Color.White;
            this.gbSize.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gbSize.Location = new System.Drawing.Point(1155, 295);
            this.gbSize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbSize.Name = "gbSize";
            this.gbSize.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbSize.Size = new System.Drawing.Size(185, 248);
            this.gbSize.TabIndex = 1;
            this.gbSize.TabStop = false;
            this.gbSize.Text = "Size";
            // 
            // rbNormal
            // 
            this.rbNormal.AutoSize = true;
            this.rbNormal.Checked = true;
            this.rbNormal.Location = new System.Drawing.Point(163, 27);
            this.rbNormal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbNormal.Name = "rbNormal";
            this.rbNormal.Size = new System.Drawing.Size(95, 29);
            this.rbNormal.TabIndex = 0;
            this.rbNormal.TabStop = true;
            this.rbNormal.Text = "Normal";
            this.rbNormal.UseVisualStyleBackColor = true;
            this.rbNormal.Click += new System.EventHandler(this.rbNormal_Click);
            // 
            // rbGrayscale
            // 
            this.rbGrayscale.AutoSize = true;
            this.rbGrayscale.Location = new System.Drawing.Point(507, 27);
            this.rbGrayscale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbGrayscale.Name = "rbGrayscale";
            this.rbGrayscale.Size = new System.Drawing.Size(121, 29);
            this.rbGrayscale.TabIndex = 1;
            this.rbGrayscale.Text = "Grayscale";
            this.rbGrayscale.UseVisualStyleBackColor = true;
            this.rbGrayscale.Click += new System.EventHandler(this.rbGrayscale_Click);
            // 
            // gbMode
            // 
            this.gbMode.BackColor = System.Drawing.Color.Transparent;
            this.gbMode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gbMode.Controls.Add(this.rbGrayscale);
            this.gbMode.Controls.Add(this.rbNormal);
            this.gbMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gbMode.ForeColor = System.Drawing.Color.White;
            this.gbMode.Location = new System.Drawing.Point(153, 93);
            this.gbMode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbMode.Name = "gbMode";
            this.gbMode.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbMode.Size = new System.Drawing.Size(862, 80);
            this.gbMode.TabIndex = 0;
            this.gbMode.TabStop = false;
            this.gbMode.Text = "Mode";
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox.Location = new System.Drawing.Point(153, 295);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(862, 383);
            this.pictureBox.TabIndex = 3;
            this.pictureBox.TabStop = false;
            this.pictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(238, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Actual Image:";
            // 
            // cmbActualImg
            // 
            this.cmbActualImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbActualImg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbActualImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbActualImg.FormattingEnabled = true;
            this.cmbActualImg.Location = new System.Drawing.Point(409, 228);
            this.cmbActualImg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbActualImg.Name = "cmbActualImg";
            this.cmbActualImg.Size = new System.Drawing.Size(274, 33);
            this.cmbActualImg.TabIndex = 5;
            this.cmbActualImg.SelectedValueChanged += new System.EventHandler(this.cmbActualImg_SelectedValueChanged);
            // 
            // btnTwoStepsBack
            // 
            this.btnTwoStepsBack.BackColor = System.Drawing.Color.DarkRed;
            this.btnTwoStepsBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTwoStepsBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnTwoStepsBack.ForeColor = System.Drawing.Color.White;
            this.btnTwoStepsBack.Location = new System.Drawing.Point(254, 724);
            this.btnTwoStepsBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTwoStepsBack.Name = "btnTwoStepsBack";
            this.btnTwoStepsBack.Size = new System.Drawing.Size(101, 43);
            this.btnTwoStepsBack.TabIndex = 6;
            this.btnTwoStepsBack.Text = "<<";
            this.btnTwoStepsBack.UseVisualStyleBackColor = false;
            this.btnTwoStepsBack.Click += new System.EventHandler(this.btnTwoStepsBack_Click);
            // 
            // btnTwoStepsForward
            // 
            this.btnTwoStepsForward.BackColor = System.Drawing.Color.DarkRed;
            this.btnTwoStepsForward.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTwoStepsForward.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnTwoStepsForward.ForeColor = System.Drawing.Color.White;
            this.btnTwoStepsForward.Location = new System.Drawing.Point(775, 724);
            this.btnTwoStepsForward.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTwoStepsForward.Name = "btnTwoStepsForward";
            this.btnTwoStepsForward.Size = new System.Drawing.Size(101, 43);
            this.btnTwoStepsForward.TabIndex = 10;
            this.btnTwoStepsForward.Text = ">>";
            this.btnTwoStepsForward.UseVisualStyleBackColor = false;
            this.btnTwoStepsForward.Click += new System.EventHandler(this.btnTwoStepsForward_Click);
            // 
            // btnOneStepForward
            // 
            this.btnOneStepForward.BackColor = System.Drawing.Color.DarkOrange;
            this.btnOneStepForward.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOneStepForward.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnOneStepForward.ForeColor = System.Drawing.Color.White;
            this.btnOneStepForward.Location = new System.Drawing.Point(582, 724);
            this.btnOneStepForward.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOneStepForward.Name = "btnOneStepForward";
            this.btnOneStepForward.Size = new System.Drawing.Size(101, 43);
            this.btnOneStepForward.TabIndex = 11;
            this.btnOneStepForward.Text = ">";
            this.btnOneStepForward.UseVisualStyleBackColor = false;
            this.btnOneStepForward.Click += new System.EventHandler(this.btnOneStepForward_Click);
            // 
            // btnOneStepBack
            // 
            this.btnOneStepBack.BackColor = System.Drawing.Color.DarkOrange;
            this.btnOneStepBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOneStepBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnOneStepBack.ForeColor = System.Drawing.Color.White;
            this.btnOneStepBack.Location = new System.Drawing.Point(438, 724);
            this.btnOneStepBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOneStepBack.Name = "btnOneStepBack";
            this.btnOneStepBack.Size = new System.Drawing.Size(101, 43);
            this.btnOneStepBack.TabIndex = 12;
            this.btnOneStepBack.Text = "<";
            this.btnOneStepBack.UseVisualStyleBackColor = false;
            this.btnOneStepBack.Click += new System.EventHandler(this.btnOneStepBack_Click);
            // 
            // FormImageViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1797, 845);
            this.Controls.Add(this.panel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormImageViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image Viewer";
            this.Load += new System.EventHandler(this.FormImageViewer_Load);
            this.barMenu.ResumeLayout(false);
            this.barMenu.PerformLayout();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.statusStripPath.ResumeLayout(false);
            this.statusStripPath.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            this.gbMode.ResumeLayout(false);
            this.gbMode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.MenuStrip barMenu;
        private System.Windows.Forms.ToolStripMenuItem archiveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem normalToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem grayscaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem centeredToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem stretchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomToolStripMenuItem;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton tsbModeNormal;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbModeGrayscale;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton tsbCentered;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton tsbStretch;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton tsbZoom;
        private System.Windows.Forms.StatusStrip statusStripPath;
        private System.Windows.Forms.ToolStripStatusLabel tssLabelPath;
        private System.Windows.Forms.Button btnOneStepBack;
        private System.Windows.Forms.Button btnOneStepForward;
        private System.Windows.Forms.Button btnTwoStepsForward;
        private System.Windows.Forms.Button btnTwoStepsBack;
        private System.Windows.Forms.ComboBox cmbActualImg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.GroupBox gbMode;
        private System.Windows.Forms.RadioButton rbGrayscale;
        private System.Windows.Forms.RadioButton rbNormal;
        private System.Windows.Forms.GroupBox gbSize;
        private System.Windows.Forms.RadioButton rbZoom;
        private System.Windows.Forms.RadioButton rbStretch;
        private System.Windows.Forms.RadioButton rbCentered;
    }
}

