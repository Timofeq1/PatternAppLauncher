using System.Drawing;

namespace PatternAppLauncher
{
    partial class PatternApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatternApp));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1_start = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1_Eraser_Button = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1_Save = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButton_Pen_settings = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripTextBox2_PenSetlabel = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBox1_Pen_Radius = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBox2_Length = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBox1_Pen_Color = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBox1_BDlabel = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripComboBox_Ready_Resolutions = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator_1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox_Custom_Resolution_X = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBox_XLabel = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBox_Custom_Resolution_Y = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator_2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1_Canvas = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripMenuItem1_Angle = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripTextBox2_Iterations = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1_AdditionalSettings = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItem_Custom_Resolutions = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1_Unlimited_Iterations = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1_Coordinates = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1_AntiAliasing = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Draw_Background = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Random_Coordinates = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1_Presets = new System.Windows.Forms.ToolStripDropDownButton();
            this.ToolStripMenuItem_Sectors_Painter = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem1_Circles_Painter = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Squares_Painter = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem_Barcode_Painter = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Light_Speed = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_Resart = new System.Windows.Forms.ToolStripButton();
            this.pictureBox1_Main = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1_Main)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1_start,
            this.toolStripButton1_Eraser_Button,
            this.toolStripButton1_Save,
            this.toolStripSeparator6,
            this.toolStripDropDownButton_Pen_settings,
            this.toolStripSeparator3,
            this.toolStripButton1_AdditionalSettings,
            this.toolStripSeparator1,
            this.toolStripLabel1_Presets,
            this.toolStripSeparator4,
            this.toolStripButton_Resart});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1280, 33);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1_start
            // 
            this.toolStripButton1_start.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toolStripButton1_start.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1_start.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.toolStripButton1_start.Image = global::PatternAppLauncher.Properties.Resources.Play_Button_25x25;
            this.toolStripButton1_start.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1_start.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1_start.Name = "toolStripButton1_start";
            this.toolStripButton1_start.Size = new System.Drawing.Size(29, 30);
            this.toolStripButton1_start.Text = "Start";
            this.toolStripButton1_start.Click += new System.EventHandler(this.toolStripButton1_start_Click_1);
            // 
            // toolStripButton1_Eraser_Button
            // 
            this.toolStripButton1_Eraser_Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1_Eraser_Button.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripButton1_Eraser_Button.Image = global::PatternAppLauncher.Properties.Resources.Eraser_Button25x25;
            this.toolStripButton1_Eraser_Button.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1_Eraser_Button.ImageTransparentColor = System.Drawing.Color.White;
            this.toolStripButton1_Eraser_Button.Name = "toolStripButton1_Eraser_Button";
            this.toolStripButton1_Eraser_Button.Size = new System.Drawing.Size(29, 30);
            this.toolStripButton1_Eraser_Button.Text = "Clear";
            this.toolStripButton1_Eraser_Button.ToolTipText = "Clear the canvas";
            this.toolStripButton1_Eraser_Button.Click += new System.EventHandler(this.toolStripButton1_Eraser_Button_Click);
            // 
            // toolStripButton1_Save
            // 
            this.toolStripButton1_Save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1_Save.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripButton1_Save.Image = global::PatternAppLauncher.Properties.Resources.Save_Button_25x25;
            this.toolStripButton1_Save.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1_Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1_Save.Name = "toolStripButton1_Save";
            this.toolStripButton1_Save.Size = new System.Drawing.Size(29, 30);
            this.toolStripButton1_Save.Text = "Save image as...";
            this.toolStripButton1_Save.ToolTipText = "Save image as...";
            this.toolStripButton1_Save.Click += new System.EventHandler(this.toolStripButton1_Save_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.AutoSize = false;
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(10, 33);
            // 
            // toolStripDropDownButton_Pen_settings
            // 
            this.toolStripDropDownButton_Pen_settings.AutoSize = false;
            this.toolStripDropDownButton_Pen_settings.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toolStripDropDownButton_Pen_settings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox2_PenSetlabel,
            this.toolStripTextBox1_Pen_Radius,
            this.toolStripTextBox2_Length,
            this.toolStripTextBox1_Pen_Color,
            this.toolStripTextBox1_BDlabel,
            this.toolStripComboBox_Ready_Resolutions,
            this.toolStripSeparator_1,
            this.toolStripTextBox_Custom_Resolution_X,
            this.toolStripTextBox_XLabel,
            this.toolStripTextBox_Custom_Resolution_Y,
            this.toolStripSeparator_2,
            this.toolStripTextBox1_Canvas,
            this.toolStripTextBox1,
            this.toolStripMenuItem1_Angle,
            this.toolStripTextBox2_Iterations});
            this.toolStripDropDownButton_Pen_settings.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripDropDownButton_Pen_settings.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolStripDropDownButton_Pen_settings.Image = global::PatternAppLauncher.Properties.Resources.Pen_Settings_Button25x25;
            this.toolStripDropDownButton_Pen_settings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripDropDownButton_Pen_settings.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripDropDownButton_Pen_settings.ImageTransparentColor = System.Drawing.Color.White;
            this.toolStripDropDownButton_Pen_settings.Name = "toolStripDropDownButton_Pen_settings";
            this.toolStripDropDownButton_Pen_settings.Size = new System.Drawing.Size(140, 29);
            this.toolStripDropDownButton_Pen_settings.Text = "Painting settings";
            this.toolStripDropDownButton_Pen_settings.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripDropDownButton_Pen_settings.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.toolStripDropDownButton_Pen_settings.ToolTipText = "Here you can set key parameters";
            // 
            // toolStripTextBox2_PenSetlabel
            // 
            this.toolStripTextBox2_PenSetlabel.Enabled = false;
            this.toolStripTextBox2_PenSetlabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripTextBox2_PenSetlabel.Name = "toolStripTextBox2_PenSetlabel";
            this.toolStripTextBox2_PenSetlabel.Size = new System.Drawing.Size(155, 23);
            this.toolStripTextBox2_PenSetlabel.Text = "Pen settings";
            this.toolStripTextBox2_PenSetlabel.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // toolStripTextBox1_Pen_Radius
            // 
            this.toolStripTextBox1_Pen_Radius.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.toolStripTextBox1_Pen_Radius.Name = "toolStripTextBox1_Pen_Radius";
            this.toolStripTextBox1_Pen_Radius.Size = new System.Drawing.Size(155, 23);
            this.toolStripTextBox1_Pen_Radius.Text = "Enter the sector width...";
            this.toolStripTextBox1_Pen_Radius.ToolTipText = "Is 10 by default";
            this.toolStripTextBox1_Pen_Radius.Click += new System.EventHandler(this.toolStripTextBox1_Pen_Radius_Click);
            this.toolStripTextBox1_Pen_Radius.TextChanged += new System.EventHandler(this.toolStripTextBox1_Pen_Radius_TextChanged);
            // 
            // toolStripTextBox2_Length
            // 
            this.toolStripTextBox2_Length.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.toolStripTextBox2_Length.Name = "toolStripTextBox2_Length";
            this.toolStripTextBox2_Length.Size = new System.Drawing.Size(155, 23);
            this.toolStripTextBox2_Length.Text = "Enter the sector length...";
            this.toolStripTextBox2_Length.ToolTipText = "Is 50 by default.\r\nIf \"width\" and \"length\" parameters are equal, pen draws sqares" +
    ".";
            this.toolStripTextBox2_Length.Click += new System.EventHandler(this.toolStripTextBox2_Length_Click);
            this.toolStripTextBox2_Length.TextChanged += new System.EventHandler(this.toolStripTextBox2_Length_TextChanged);
            // 
            // toolStripTextBox1_Pen_Color
            // 
            this.toolStripTextBox1_Pen_Color.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.toolStripTextBox1_Pen_Color.Name = "toolStripTextBox1_Pen_Color";
            this.toolStripTextBox1_Pen_Color.Size = new System.Drawing.Size(155, 23);
            this.toolStripTextBox1_Pen_Color.Text = "Choose pen color...";
            this.toolStripTextBox1_Pen_Color.ToolTipText = "Default pen color is black.\r\n";
            this.toolStripTextBox1_Pen_Color.Click += new System.EventHandler(this.toolStripTextBox1_Pen_Color_Click);
            // 
            // toolStripTextBox1_BDlabel
            // 
            this.toolStripTextBox1_BDlabel.Enabled = false;
            this.toolStripTextBox1_BDlabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripTextBox1_BDlabel.Name = "toolStripTextBox1_BDlabel";
            this.toolStripTextBox1_BDlabel.Size = new System.Drawing.Size(155, 23);
            this.toolStripTextBox1_BDlabel.Text = "Background settings";
            this.toolStripTextBox1_BDlabel.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // toolStripComboBox_Ready_Resolutions
            // 
            this.toolStripComboBox_Ready_Resolutions.Items.AddRange(new object[] {
            "640 x 360 (nHD)",
            "960 x 540 (qHD)",
            "1280 x 720 (HD) (Default)",
            "1920 x 1080 (Full HD)",
            "2560 x 1440 (2K)",
            "3840 x 2160 (4K)",
            "7680 x 4320 (8K)"});
            this.toolStripComboBox_Ready_Resolutions.Name = "toolStripComboBox_Ready_Resolutions";
            this.toolStripComboBox_Ready_Resolutions.Size = new System.Drawing.Size(155, 23);
            this.toolStripComboBox_Ready_Resolutions.Text = "1280 x 720 (HD) (Default)";
            this.toolStripComboBox_Ready_Resolutions.ToolTipText = "Here you can choose from some common resolutions.";
            // 
            // toolStripSeparator_1
            // 
            this.toolStripSeparator_1.AutoSize = false;
            this.toolStripSeparator_1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.toolStripSeparator_1.Name = "toolStripSeparator_1";
            this.toolStripSeparator_1.Size = new System.Drawing.Size(212, 10);
            this.toolStripSeparator_1.Visible = false;
            // 
            // toolStripTextBox_Custom_Resolution_X
            // 
            this.toolStripTextBox_Custom_Resolution_X.BackColor = System.Drawing.SystemColors.Window;
            this.toolStripTextBox_Custom_Resolution_X.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.toolStripTextBox_Custom_Resolution_X.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.toolStripTextBox_Custom_Resolution_X.Name = "toolStripTextBox_Custom_Resolution_X";
            this.toolStripTextBox_Custom_Resolution_X.Size = new System.Drawing.Size(155, 16);
            this.toolStripTextBox_Custom_Resolution_X.Text = "1280";
            this.toolStripTextBox_Custom_Resolution_X.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolStripTextBox_Custom_Resolution_X.ToolTipText = "Horizontal resolution";
            this.toolStripTextBox_Custom_Resolution_X.Visible = false;
            this.toolStripTextBox_Custom_Resolution_X.TextChanged += new System.EventHandler(this.toolStripTextBox_Custom_Resolution_X_TextChanged);
            // 
            // toolStripTextBox_XLabel
            // 
            this.toolStripTextBox_XLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toolStripTextBox_XLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.toolStripTextBox_XLabel.Enabled = false;
            this.toolStripTextBox_XLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripTextBox_XLabel.Name = "toolStripTextBox_XLabel";
            this.toolStripTextBox_XLabel.Size = new System.Drawing.Size(155, 16);
            this.toolStripTextBox_XLabel.Text = "x";
            this.toolStripTextBox_XLabel.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolStripTextBox_XLabel.Visible = false;
            // 
            // toolStripTextBox_Custom_Resolution_Y
            // 
            this.toolStripTextBox_Custom_Resolution_Y.BackColor = System.Drawing.SystemColors.Window;
            this.toolStripTextBox_Custom_Resolution_Y.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.toolStripTextBox_Custom_Resolution_Y.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.toolStripTextBox_Custom_Resolution_Y.Name = "toolStripTextBox_Custom_Resolution_Y";
            this.toolStripTextBox_Custom_Resolution_Y.Size = new System.Drawing.Size(155, 16);
            this.toolStripTextBox_Custom_Resolution_Y.Text = "720";
            this.toolStripTextBox_Custom_Resolution_Y.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolStripTextBox_Custom_Resolution_Y.ToolTipText = "Vertical resolution";
            this.toolStripTextBox_Custom_Resolution_Y.Visible = false;
            this.toolStripTextBox_Custom_Resolution_Y.TextChanged += new System.EventHandler(this.toolStripTextBox_Custom_Resolution_Y_TextChanged);
            // 
            // toolStripSeparator_2
            // 
            this.toolStripSeparator_2.AutoSize = false;
            this.toolStripSeparator_2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.toolStripSeparator_2.Name = "toolStripSeparator_2";
            this.toolStripSeparator_2.Size = new System.Drawing.Size(212, 10);
            this.toolStripSeparator_2.Visible = false;
            // 
            // toolStripTextBox1_Canvas
            // 
            this.toolStripTextBox1_Canvas.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1_Canvas.Name = "toolStripTextBox1_Canvas";
            this.toolStripTextBox1_Canvas.Size = new System.Drawing.Size(155, 23);
            this.toolStripTextBox1_Canvas.Text = "Choose canvas color...";
            this.toolStripTextBox1_Canvas.ToolTipText = "Canvas color is white by default.\r\n";
            this.toolStripTextBox1_Canvas.Click += new System.EventHandler(this.toolStripTextBox1_Canvas_Click);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Enabled = false;
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripTextBox1.Size = new System.Drawing.Size(155, 23);
            this.toolStripTextBox1.Text = "Other settings";
            this.toolStripTextBox1.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // toolStripMenuItem1_Angle
            // 
            this.toolStripMenuItem1_Angle.Items.AddRange(new object[] {
            "Two directions mode",
            "Horizontal mode",
            "Vertical mode",
            "Wind mode",
            "Random direction mode"});
            this.toolStripMenuItem1_Angle.Name = "toolStripMenuItem1_Angle";
            this.toolStripMenuItem1_Angle.Size = new System.Drawing.Size(155, 23);
            this.toolStripMenuItem1_Angle.Text = "Sector rotation modes";
            this.toolStripMenuItem1_Angle.ToolTipText = "Here you can choose rotation mode. \r\nBy default, it is random direction mode.";
            this.toolStripMenuItem1_Angle.SelectedIndexChanged += new System.EventHandler(this.toolStripMenuItem1_Angle_SelectedIndexChanged);
            // 
            // toolStripTextBox2_Iterations
            // 
            this.toolStripTextBox2_Iterations.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.toolStripTextBox2_Iterations.Name = "toolStripTextBox2_Iterations";
            this.toolStripTextBox2_Iterations.Size = new System.Drawing.Size(155, 23);
            this.toolStripTextBox2_Iterations.Text = "Enter the iteration number...";
            this.toolStripTextBox2_Iterations.ToolTipText = "The number of iterations is 100 by default.\r\nKeep in mind, that the bigger number" +
    " is - the longer you have to wait.\r\nAlso, there is a limit of iterations, that c" +
    "an be turned off manually, if needed.";
            this.toolStripTextBox2_Iterations.Click += new System.EventHandler(this.toolStripTextBox2_Iterations_Click);
            this.toolStripTextBox2_Iterations.TextChanged += new System.EventHandler(this.toolStripTextBox2_Iterations_TextChanged);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.AutoSize = false;
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(10, 33);
            // 
            // toolStripButton1_AdditionalSettings
            // 
            this.toolStripButton1_AdditionalSettings.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toolStripButton1_AdditionalSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_Custom_Resolutions,
            this.toolStripTextBox1_Unlimited_Iterations,
            this.toolStripTextBox1_Coordinates,
            this.toolStripTextBox1_AntiAliasing,
            this.toolStripMenuItem_Draw_Background,
            this.toolStripMenuItem_Random_Coordinates});
            this.toolStripButton1_AdditionalSettings.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripButton1_AdditionalSettings.ForeColor = System.Drawing.SystemColors.WindowText;
            this.toolStripButton1_AdditionalSettings.Image = global::PatternAppLauncher.Properties.Resources.Settings_Button_25x25;
            this.toolStripButton1_AdditionalSettings.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1_AdditionalSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1_AdditionalSettings.Name = "toolStripButton1_AdditionalSettings";
            this.toolStripButton1_AdditionalSettings.Size = new System.Drawing.Size(75, 30);
            this.toolStripButton1_AdditionalSettings.Text = "More";
            this.toolStripButton1_AdditionalSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolStripButton1_AdditionalSettings.ToolTipText = "Here you can set additional parameters\r\n";
            // 
            // toolStripMenuItem_Custom_Resolutions
            // 
            this.toolStripMenuItem_Custom_Resolutions.BackColor = System.Drawing.Color.LightPink;
            this.toolStripMenuItem_Custom_Resolutions.Name = "toolStripMenuItem_Custom_Resolutions";
            this.toolStripMenuItem_Custom_Resolutions.Size = new System.Drawing.Size(188, 22);
            this.toolStripMenuItem_Custom_Resolutions.Text = "Custom resolutions";
            this.toolStripMenuItem_Custom_Resolutions.ToolTipText = "Allows to set resolution manualy, in painting settings.\r\n";
            this.toolStripMenuItem_Custom_Resolutions.Click += new System.EventHandler(this.toolStripMenuItem_Custom_Resolutions_Click);
            // 
            // toolStripTextBox1_Unlimited_Iterations
            // 
            this.toolStripTextBox1_Unlimited_Iterations.BackColor = System.Drawing.Color.LightPink;
            this.toolStripTextBox1_Unlimited_Iterations.Name = "toolStripTextBox1_Unlimited_Iterations";
            this.toolStripTextBox1_Unlimited_Iterations.Size = new System.Drawing.Size(188, 22);
            this.toolStripTextBox1_Unlimited_Iterations.Text = "Unlimited iterations";
            this.toolStripTextBox1_Unlimited_Iterations.ToolTipText = "By default maximum amount of iterations is 100 000.";
            this.toolStripTextBox1_Unlimited_Iterations.Click += new System.EventHandler(this.toolStripTextBox1_Unlimited_Iterations_Click);
            // 
            // toolStripTextBox1_Coordinates
            // 
            this.toolStripTextBox1_Coordinates.BackColor = System.Drawing.Color.LightPink;
            this.toolStripTextBox1_Coordinates.Name = "toolStripTextBox1_Coordinates";
            this.toolStripTextBox1_Coordinates.Size = new System.Drawing.Size(188, 22);
            this.toolStripTextBox1_Coordinates.Text = "Show coordinates";
            this.toolStripTextBox1_Coordinates.ToolTipText = "Shows x0 and y0 coordinates of each sector.";
            this.toolStripTextBox1_Coordinates.Click += new System.EventHandler(this.toolStripTextBox1_Coordinates_Click);
            // 
            // toolStripTextBox1_AntiAliasing
            // 
            this.toolStripTextBox1_AntiAliasing.BackColor = System.Drawing.Color.LightGreen;
            this.toolStripTextBox1_AntiAliasing.Name = "toolStripTextBox1_AntiAliasing";
            this.toolStripTextBox1_AntiAliasing.Size = new System.Drawing.Size(188, 22);
            this.toolStripTextBox1_AntiAliasing.Text = "Anti-aliasing";
            this.toolStripTextBox1_AntiAliasing.ToolTipText = "Makes the image smoother.";
            this.toolStripTextBox1_AntiAliasing.Click += new System.EventHandler(this.toolStripTextBox1_AntiAliasing_Click);
            // 
            // toolStripMenuItem_Draw_Background
            // 
            this.toolStripMenuItem_Draw_Background.BackColor = System.Drawing.Color.LightGreen;
            this.toolStripMenuItem_Draw_Background.Name = "toolStripMenuItem_Draw_Background";
            this.toolStripMenuItem_Draw_Background.Size = new System.Drawing.Size(188, 22);
            this.toolStripMenuItem_Draw_Background.Text = "Draw background";
            this.toolStripMenuItem_Draw_Background.ToolTipText = "By default is true.\r\nIt you want to save an image without background,\r\nit is reco" +
    "mmended to use \"png\" image format,\r\nbecause it supports transparent layers.";
            this.toolStripMenuItem_Draw_Background.Click += new System.EventHandler(this.toolStripMenuItem_Draw_Background_Click);
            // 
            // toolStripMenuItem_Random_Coordinates
            // 
            this.toolStripMenuItem_Random_Coordinates.BackColor = System.Drawing.Color.LightGreen;
            this.toolStripMenuItem_Random_Coordinates.Name = "toolStripMenuItem_Random_Coordinates";
            this.toolStripMenuItem_Random_Coordinates.Size = new System.Drawing.Size(188, 22);
            this.toolStripMenuItem_Random_Coordinates.Text = "Random coordinates";
            this.toolStripMenuItem_Random_Coordinates.ToolTipText = "True by default. \r\nIf you turn this off, x0 and y0 coordinates of each sector app" +
    "ear only at the canvas center,\r\nbut x1, x2 remain random.";
            this.toolStripMenuItem_Random_Coordinates.Click += new System.EventHandler(this.toolStripMenuItem_Random_Coordinates_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.AutoSize = false;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(10, 33);
            // 
            // toolStripLabel1_Presets
            // 
            this.toolStripLabel1_Presets.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Sectors_Painter,
            this.toolStripSeparator9,
            this.toolStripMenuItem1_Circles_Painter,
            this.toolStripMenuItem_Squares_Painter,
            this.toolStripSeparator2,
            this.toolStripMenuItem_Barcode_Painter,
            this.ToolStripMenuItem_Light_Speed});
            this.toolStripLabel1_Presets.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripLabel1_Presets.Image = global::PatternAppLauncher.Properties.Resources.Presets_Button25x25;
            this.toolStripLabel1_Presets.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripLabel1_Presets.Name = "toolStripLabel1_Presets";
            this.toolStripLabel1_Presets.Size = new System.Drawing.Size(87, 30);
            this.toolStripLabel1_Presets.Text = "Presets";
            this.toolStripLabel1_Presets.ToolTipText = "Here you can choose from ready patterns\r\n";
            // 
            // ToolStripMenuItem_Sectors_Painter
            // 
            this.ToolStripMenuItem_Sectors_Painter.Name = "ToolStripMenuItem_Sectors_Painter";
            this.ToolStripMenuItem_Sectors_Painter.Size = new System.Drawing.Size(191, 22);
            this.ToolStripMenuItem_Sectors_Painter.Text = "Classic sector painter";
            this.ToolStripMenuItem_Sectors_Painter.Click += new System.EventHandler(this.ToolStripMenuItem_Sectors_Painter_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(188, 6);
            // 
            // toolStripMenuItem1_Circles_Painter
            // 
            this.toolStripMenuItem1_Circles_Painter.Name = "toolStripMenuItem1_Circles_Painter";
            this.toolStripMenuItem1_Circles_Painter.Size = new System.Drawing.Size(191, 22);
            this.toolStripMenuItem1_Circles_Painter.Text = "Circles painter";
            this.toolStripMenuItem1_Circles_Painter.Click += new System.EventHandler(this.toolStripMenuItem1_Circles_Painter_Click);
            // 
            // toolStripMenuItem_Squares_Painter
            // 
            this.toolStripMenuItem_Squares_Painter.Name = "toolStripMenuItem_Squares_Painter";
            this.toolStripMenuItem_Squares_Painter.Size = new System.Drawing.Size(191, 22);
            this.toolStripMenuItem_Squares_Painter.Text = "Squares painter";
            this.toolStripMenuItem_Squares_Painter.Click += new System.EventHandler(this.toolStripMenuItem_Sqares_Painter_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(188, 6);
            // 
            // toolStripMenuItem_Barcode_Painter
            // 
            this.toolStripMenuItem_Barcode_Painter.Name = "toolStripMenuItem_Barcode_Painter";
            this.toolStripMenuItem_Barcode_Painter.Size = new System.Drawing.Size(191, 22);
            this.toolStripMenuItem_Barcode_Painter.Text = "Barcoder";
            this.toolStripMenuItem_Barcode_Painter.Click += new System.EventHandler(this.toolStripMenuItem_Barcode_Painter_Click);
            // 
            // ToolStripMenuItem_Light_Speed
            // 
            this.ToolStripMenuItem_Light_Speed.Name = "ToolStripMenuItem_Light_Speed";
            this.ToolStripMenuItem_Light_Speed.Size = new System.Drawing.Size(191, 22);
            this.ToolStripMenuItem_Light_Speed.Text = "At the speed of Light";
            this.ToolStripMenuItem_Light_Speed.Click += new System.EventHandler(this.ToolStripMenuItem_Light_Speed_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.AutoSize = false;
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(10, 33);
            // 
            // toolStripButton_Resart
            // 
            this.toolStripButton_Resart.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripButton_Resart.Image = global::PatternAppLauncher.Properties.Resources.Restart_25x25;
            this.toolStripButton_Resart.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton_Resart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Resart.Name = "toolStripButton_Resart";
            this.toolStripButton_Resart.Size = new System.Drawing.Size(77, 30);
            this.toolStripButton_Resart.Text = "Reboot";
            this.toolStripButton_Resart.ToolTipText = "Restarts application";
            this.toolStripButton_Resart.Click += new System.EventHandler(this.toolStripButton_Resart_Click);
            // 
            // pictureBox1_Main
            // 
            this.pictureBox1_Main.BackColor = System.Drawing.Color.White;
            this.pictureBox1_Main.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1_Main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1_Main.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1_Main.InitialImage = null;
            this.pictureBox1_Main.Location = new System.Drawing.Point(0, 33);
            this.pictureBox1_Main.Name = "pictureBox1_Main";
            this.pictureBox1_Main.Size = new System.Drawing.Size(1280, 719);
            this.pictureBox1_Main.TabIndex = 5;
            this.pictureBox1_Main.TabStop = false;
            // 
            // PatternApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1280, 752);
            this.Controls.Add(this.pictureBox1_Main);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PatternApp";
            this.Text = "PatternApp";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1_Main)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1_start;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.PictureBox pictureBox1_Main;
        private System.Windows.Forms.ToolStripDropDownButton toolStripButton1_AdditionalSettings;
        private System.Windows.Forms.ToolStripButton toolStripButton1_Save;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton toolStripButton1_Eraser_Button;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton_Pen_settings;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1_Pen_Radius;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2_PenSetlabel;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1_Pen_Color;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1_BDlabel;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1_Canvas;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2_Length;
        private System.Windows.Forms.ToolStripMenuItem toolStripTextBox1_Unlimited_Iterations;
        private System.Windows.Forms.ToolStripMenuItem toolStripTextBox1_Coordinates;
        private System.Windows.Forms.ToolStripMenuItem toolStripTextBox1_AntiAliasing;
        private System.Windows.Forms.ToolStripComboBox toolStripMenuItem1_Angle;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2_Iterations;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox_Ready_Resolutions;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator_1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox_Custom_Resolution_X;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox_XLabel;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox_Custom_Resolution_Y;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator_2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Custom_Resolutions;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Draw_Background;
        private System.Windows.Forms.ToolStripDropDownButton toolStripLabel1_Presets;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Sectors_Painter;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1_Circles_Painter;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Squares_Painter;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Barcode_Painter;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Random_Coordinates;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Light_Speed;
        private System.Windows.Forms.ToolStripButton toolStripButton_Resart;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    }
}