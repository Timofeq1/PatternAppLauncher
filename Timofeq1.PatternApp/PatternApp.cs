#region Hello and Welcome to the code of PatternApp!

// In this project I tried to write a readable code, applying all my C# knowledge.
// Methods and variables named using Mixed_Case_With_Underscores
// Default methods named using the "WindowsFormsContainerName" + "Method_Name"
// Hope you like my code!
#endregion

#region Привет и Добро пожаловать в код приложения PatternApp!

// Я стремился написать читаемый код, применяя все мои знанния С#.
// Для именования методов и переменных использовалась Смешанная_Нотация_С_Подчеркиваниями
// Стандартные методы именовались по формуле "WindowsFormsНазваниеКонтейнера" + "Имя_Метода"
// Надеюсь вам понравится мой код!

#endregion

using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Windows.Forms;

namespace PatternAppLauncher
{
    public partial class PatternApp : Form
    {
        #region My variables and props

        #region Integers

        private int Length = 50;
        private int Iterations_Number = 100;
        private int Brush_Radius = 10;
        private int Custom_X = 1280;
        private int Custom_Y = 720;
        private int Current_Preset = 0;
        private int Current_Rotation_Index = -1;

        #endregion

        #region Booleans
        private bool Preset_Changed_Bool = false;
        private bool Clicked_Pen_Radius = false;
        private bool Clicked_Length = false;
        private bool Clicked_Iterations = false;
        private bool Draw_Background = true;
        private bool Custom_Resolutions = false;
        private bool Unlimited_Iterations = false;
        private bool Show_Coordinates = false;
        private bool Anti_Aliasing = true;
        private bool Random_Coordinates = true;
        #endregion

        #region Other types

        private float x0 = 0F;
        private float y0 = 0F;
        private float fi = 0F;
        private Color Brush_Color { get; set; } = Color.Black;
        private Color Background_Color { get; set; } = Color.White;

        #endregion

        #endregion

        #region My Methods
        // Returns main settings to defaults, is being used when changing presets.
        private void Preset_Changed()
        {
            if (Preset_Changed_Bool)
            {
                Length = 50;
                Brush_Radius = 10;
                Iterations_Number = 100;
                Random_Coordinates = true;
                toolStripMenuItem_Random_Coordinates.BackColor = Color.LightGreen;
                toolStripMenuItem1_Angle.SelectedIndex = -1;
                Current_Preset = 0;

            }
            Preset_Changed_Bool = true;
        }

        // Main app method, creates all magic, app's brain.
        private void Painter(int preset = 0)
        {
            // Creating the canvas with the resolution chosen by User.
            pictureBox1_Main.ClientSize = My_Resolution();
            pictureBox1_Main.Size = My_Resolution();

            // Adding to the main form size the width and height of tools panel.
            Size = My_Resolution(16, 71);

            // Adding a bitmap image to the canvas.
            Bitmap Bitmap_Main = new Bitmap(My_Resolution().Width, My_Resolution().Height);
            pictureBox1_Main.Image = Bitmap_Main;
            Graphics graphics = Graphics.FromImage(Bitmap_Main);

            // Checks additional conditions
            if (Draw_Background)
            {
                graphics.DrawImage(Background(), 0, 0);
            }
            if (Current_Rotation_Index == 3)
            {
                fi = Guid_Random_Float(0, (int)(Math.PI * 2));
            }
            if (Anti_Aliasing)
            {
                graphics.SmoothingMode = SmoothingMode.AntiAlias;
            }

            // Creates pen and brush with User entered parameters.
            var UserPen = new Pen(Brush_Color, Brush_Radius);
            var UserBrush = new SolidBrush(Brush_Color);

            // This is "for" cycle that repeats Iteration_Number times.
            for (var i = 0; i < Iterations_Number; i++)
            {

                if (Random_Coordinates)
                {
                    x0 = Guid_Random_Float(0, My_Resolution().Width);
                    y0 = Guid_Random_Float(0, My_Resolution().Height);
                }
                else
                {
                    x0 = My_Resolution().Width / 2;
                    y0 = My_Resolution().Height / 2;
                }

                switch (Current_Rotation_Index)
                {
                    case 0: // Two directions mode
                        (UserPen.Width, Length) = (Length, (int)UserPen.Width);
                        break;
                    case 1: // Horizontal mode.
                        fi = 0;
                        break;
                    case 2: // Vertical mode.
                        fi = 0;
                        break;
                    case 3: // Wind mode (fi is defined before the for cycle).
                        break;
                    default: // Random rotation.
                        fi = Guid_Random_Float(0, (int)(Math.PI * 2));
                        break;
                }

                switch (Current_Preset)
                {
                    case 0: // Classic sectors painter.

                        var x1 = Length * Math.Cos(fi);
                        var y1 = Length * Math.Sin(fi);

                        if (Current_Rotation_Index == 2)
                        {
                            x1 = 0; // sin(0) = 0
                            y1 = Length; // cos(0) = 1
                        } // Vertical mode (swaps x1 and y1)

                        graphics.DrawLine(UserPen, x0, y0, (float)(x0 + x1), (float)(y0 + y1));
                        break;
                    case 1: // Circles painter.
                        graphics.DrawEllipse(UserPen, x0, y0, Brush_Radius, Length);
                        graphics.FillEllipse(UserBrush, x0, y0, Brush_Radius, Length);
                        break;
                }
                if (Show_Coordinates)
                {
                    graphics.DrawString($"x0={x0} y0={y0}", DefaultFont, UserBrush, new PointF(x0, y0));
                }


            }

            //Fixes bug then Iterations_Number is odd number
            if (Iterations_Number % 2 != 0 && Current_Rotation_Index == 0)
            {
                (UserPen.Width, Length) = (Length, (int)UserPen.Width);

            }

            // Releases all resources used by graphics
            graphics.Dispose();
        }

        // Checks if input in ToolStripTextBox form is lower than highlimit and higher than zero(or other number), returns natural numbers, else message boxes with warnings. 
        private int Text_Box_Input_Checker(in ToolStripTextBox box1, in int highlimit,in int lowlimit = 0)
       {
            string input = box1.Text;
            if (input.StartsWith("0") && input.Length > 1)
            {
                MessageBox.Show($"PatternApp does not recognize {input} as natural number\nTry again.", "Input error");
                box1.Clear();
                box1.Text = lowlimit.ToString();
                return lowlimit;
            }
            if (int.TryParse(input, out int result) || input == "")
            {
                if (input == "")
                {
                    box1.Clear();
                    box1.Text = lowlimit.ToString();
                    return lowlimit;
                }
                if (result >= lowlimit)
                {
                    if (result <= highlimit)
                    {
                        return result;
                    }
                    else
                    {
                        MessageBox.Show($"Sorry, but {input} is more than allowed limit - {highlimit}.", "Input error");
                        box1.Clear();
                        box1.Text = lowlimit.ToString();
                        return lowlimit;
                    }
                }
                else
                {
                    MessageBox.Show($"Sorry, but {input} is too low for this parameter.\nTry again.", "Input error");
                    box1.Clear();
                    box1.Text = lowlimit.ToString();
                    return lowlimit;
                }

            }

            if (long.TryParse(input, out _))
            {
                MessageBox.Show($"Sorry, this number is too big.\nTry again.", "Input error");
                box1.Clear();
                box1.Text = lowlimit.ToString();
                return lowlimit;
            } 
            else
            {
                MessageBox.Show($"PatternApp does not recognize {input} number.\nTry again.", "Input error");
                box1.Clear();
                box1.Text = lowlimit.ToString();
                return lowlimit;
            }

        }

        // Works like usual Random, but uses Guid to be more "random", returns integer.
        private int Guid_Random_Integer(in int a, in int b)  
        {
            return new Random(Guid.NewGuid().ToByteArray().Sum(f => f)).Next(a,b);
        }

        // Works like previous method, but adds two random numbers after comma, returns float.
        private float Guid_Random_Float(in int a, in int b) 
        {
            int First = new Random(Guid.NewGuid().ToByteArray().Sum(f => f)).Next(a, b);
            float Second = new Random(Guid.NewGuid().ToByteArray().Sum(f => f)).Next(1, 99);
            float Number = First - Second / 100;
            return Number;
        }

        // Inverts bool, and ToolStripMenuItem Back color.
        private bool Invert_Bool_And_Back_Color(bool a, ToolStripMenuItem box1)

        {
            if (a == false)
            {
                box1.BackColor = Color.LightGreen;
                return true;
            }
            else
            {
                box1.BackColor = Color.LightPink;
                return false;

            }
        }

        // Fills an Bitmap Image with user color, is being used to create background.
        private Bitmap Background()
        {
            SolidBrush Background_Brush = new SolidBrush(Background_Color);
            Bitmap Background_Bitmap = new Bitmap(My_Resolution().Width, My_Resolution().Height);
            Graphics Background_Graphics = Graphics.FromImage(Background_Bitmap);
            Background_Graphics.FillRectangle(Background_Brush, 0, 0, My_Resolution().Width, My_Resolution().Height);
            return Background_Bitmap;
        }

        #endregion

        #region Default initializer

        public PatternApp()
        {
            InitializeComponent();
        }

        #endregion

        #region Main Buttons

        // Start button.
        private void toolStripButton1_start_Click_1(object sender, EventArgs e)
        {
            Painter(Current_Preset);
        }

        // Eraser button.
        private void toolStripButton1_Eraser_Button_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1_Main.CreateGraphics();
            g.Clear(Background_Color);
        }

        // Save button.
        private void toolStripButton1_Save_Click(object sender, EventArgs e)
        {
            if (pictureBox1_Main.Image != null)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Title = "Save image as...";
                save.CheckPathExists = true;
                save.Filter = "Image Files(*.png)|*.png|" +
                "Image Files(*.bmp)|*.bmp|" +
                "Image Files(*.tiff)|*.tiff|" +
                "Image Files(*.gif)|*.gif|" +
                "Image Files(*.jpeg)|*.jpeg|" +
                "Image Files(*.ico)|*.ico|" +
                "All files (*.*)|*.*";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    try
                    {   
                        switch(save.FilterIndex)
                        {
                            case 1:
                                pictureBox1_Main.Image.Save(save.FileName, ImageFormat.Png);
                                break;
                            case 2:
                                pictureBox1_Main.Image.Save(save.FileName, ImageFormat.Bmp);
                                break;
                            case 3:
                                pictureBox1_Main.Image.Save(save.FileName, ImageFormat.Tiff);
                                break;
                            case 4:
                                pictureBox1_Main.Image.Save(save.FileName, ImageFormat.Gif);
                                break;
                            case 6:
                                pictureBox1_Main.Image.Save(save.FileName, ImageFormat.Icon);
                                break;
                            default:
                                pictureBox1_Main.Image.Save(save.FileName, ImageFormat.Jpeg);
                                break;
                        } 
                    }
                    catch
                    {
                        MessageBox.Show("Saving error.\nTry again.","Error");
                    }
                }
            }
            else
            {
                MessageBox.Show("Canvas is empty!","Error");
            }
        }

        #endregion

        #region Painting Settings

        #region Pen settings
        // Pen radius (sector width).
        private void toolStripTextBox1_Pen_Radius_TextChanged(object sender, EventArgs e)
        {
            Brush_Radius = Text_Box_Input_Checker(toolStripTextBox1_Pen_Radius, 10000, 1);
        }

        private void toolStripTextBox1_Pen_Radius_Click(object sender, EventArgs e)
        {
            if (!Clicked_Pen_Radius)
            {
                toolStripTextBox1_Pen_Radius.Text = Brush_Radius.ToString();
                Clicked_Pen_Radius = true;
            }
        }

        // Sector length.
        private void toolStripTextBox2_Length_Click(object sender, EventArgs e)
        {
            if (!Clicked_Length)
            {
                toolStripTextBox2_Length.Text = Length.ToString();
                Clicked_Length = true;
            }
        }

        private void toolStripTextBox2_Length_TextChanged(object sender, EventArgs e)
        {
            Length = Text_Box_Input_Checker(toolStripTextBox2_Length, 10000, 1);
        }

        // Pen color.
        private void toolStripTextBox1_Pen_Color_Click(object sender, EventArgs e)
        {
            var ColorDialog1 = new ColorDialog();
            if (ColorDialog1.ShowDialog() == DialogResult.OK)
            {
                Brush_Color = ColorDialog1.Color;
            }
            toolStripTextBox1_Pen_Color.Text = $"{Brush_Color.Name}";
        }

        #endregion

        #region Background settings
        // Background color.
        private void toolStripTextBox1_Canvas_Click(object sender, EventArgs e)
        {
            var ColorDialog2 = new ColorDialog();
            if (ColorDialog2.ShowDialog() == DialogResult.OK)
            {
                Background_Color = ColorDialog2.Color;
            }
            toolStripTextBox1_Canvas.Text = $"{Background_Color.Name}";
        }

        //Ready resolutions.
        private Size My_Resolution(int x = 0, int y = 0)
        {
            if (Custom_Resolutions)
            {
                if (Custom_X == 0 || Custom_Y == 0)
                {
                    MessageBox.Show("Resolution can't be null, returning to the defaults...", "Error");
                    Custom_X = 1280;
                    Custom_Y = 720;
                    toolStripTextBox_Custom_Resolution_X.Text = "1280";
                    toolStripTextBox_Custom_Resolution_Y.Text = "720";
                    return new Size(Custom_X + x, Custom_Y + y);
                }
                return new Size(Custom_X + x, Custom_Y + y);
            }
            switch (toolStripComboBox_Ready_Resolutions.SelectedIndex)
            {
                case 0:
                    return new Size(640 + x, 360 + y);
                case 1:
                    return new Size(960 + x, 540 + y);
                case 2:
                    return new Size(1280 + x, 720 + y);
                case 3:
                    return new Size(1920 + x, 1080 + y);
                case 4:
                    return new Size(2560 + x, 1440 + y);
                case 5:
                    return new Size(3840 + x, 2160 + y);
                case 6:
                    return new Size(7680 + x, 4320 + y);

            }
            return new Size(1280 + x, 720 + y);
        }

        //Custom resolutions.
        private void toolStripTextBox_Custom_Resolution_X_TextChanged(object sender, EventArgs e)
        {
            Custom_X = Text_Box_Input_Checker(toolStripTextBox_Custom_Resolution_X, 10000, 0);
        }

        private void toolStripTextBox_Custom_Resolution_Y_TextChanged(object sender, EventArgs e)
        {
            Custom_Y = Text_Box_Input_Checker(toolStripTextBox_Custom_Resolution_Y, 10000, 0);
        }

        #endregion

        #region Other settings
        // Rotation modes.
        private void toolStripMenuItem1_Angle_SelectedIndexChanged(object sender, EventArgs e)
        {
            Current_Rotation_Index = toolStripMenuItem1_Angle.SelectedIndex;
        }

        // Iteration number.
        private void toolStripTextBox2_Iterations_Click(object sender, EventArgs e)
        {
            if (!Clicked_Iterations)
            {
                toolStripTextBox2_Iterations.Text = Iterations_Number.ToString();
                Clicked_Iterations = true;
            }

        }

        private void toolStripTextBox2_Iterations_TextChanged(object sender, EventArgs e)
        {
            var IterLim = 100000;
            if (Unlimited_Iterations)
            {
                IterLim = int.MaxValue;
            }
            Iterations_Number = Text_Box_Input_Checker(toolStripTextBox2_Iterations, IterLim);
        }

        #endregion

        #endregion

        #region More settings button ( On / Off )

        private void toolStripMenuItem_Custom_Resolutions_Click(object sender, EventArgs e)
        {
            Custom_Resolutions = Invert_Bool_And_Back_Color(Custom_Resolutions, toolStripMenuItem_Custom_Resolutions);
            if (Custom_Resolutions)
            {
                toolStripSeparator_1.Visible = true;
                toolStripTextBox_Custom_Resolution_X.Visible = true;
                toolStripTextBox_XLabel.Visible = true;
                toolStripTextBox_Custom_Resolution_Y.Visible = true;
                toolStripSeparator_2.Visible = true;
            }
            else
            {
                toolStripSeparator_1.Visible = false;
                toolStripTextBox_Custom_Resolution_X.Visible = false;
                toolStripTextBox_XLabel.Visible = false;
                toolStripTextBox_Custom_Resolution_Y.Visible = false;
                toolStripSeparator_2.Visible = false;
            }
        }

        private void toolStripTextBox1_Unlimited_Iterations_Click(object sender, EventArgs e)
        {
            Unlimited_Iterations = Invert_Bool_And_Back_Color(Unlimited_Iterations, toolStripTextBox1_Unlimited_Iterations);
        }

        private void toolStripTextBox1_Coordinates_Click(object sender, EventArgs e)
        {
            Show_Coordinates = Invert_Bool_And_Back_Color(Show_Coordinates, toolStripTextBox1_Coordinates);
        }

        private void toolStripTextBox1_AntiAliasing_Click(object sender, EventArgs e)
        {
            Anti_Aliasing = Invert_Bool_And_Back_Color(Anti_Aliasing, toolStripTextBox1_AntiAliasing);
        }

        private void toolStripMenuItem_Draw_Background_Click(object sender, EventArgs e)
        {
            Draw_Background = Invert_Bool_And_Back_Color(Draw_Background, toolStripMenuItem_Draw_Background);
        }

        private void toolStripMenuItem_Random_Coordinates_Click(object sender, EventArgs e)
        {
            Random_Coordinates = Invert_Bool_And_Back_Color(Random_Coordinates, toolStripMenuItem_Random_Coordinates);
        }

        #endregion

        #region Presets
        //Classic sector painter.
        private void ToolStripMenuItem_Sectors_Painter_Click(object sender, EventArgs e)
        {
            Preset_Changed();
            Current_Preset = 0;
            Painter();

        }

        //Circles painter.
        private void toolStripMenuItem1_Circles_Painter_Click(object sender, EventArgs e)
        {
            Preset_Changed();
            Brush_Radius = Length = 10;
            Current_Preset = 1;
            Painter(1);
        }

        //Squares painter.
        private void toolStripMenuItem_Sqares_Painter_Click(object sender, EventArgs e)
        {
            Preset_Changed();
            Length = Brush_Radius = 10;
            Painter();
        }

        // Bar-code painter.
        private void toolStripMenuItem_Barcode_Painter_Click(object sender, EventArgs e)
        {
            Preset_Changed();
            toolStripMenuItem1_Angle.SelectedIndex = 1;
            Brush_Radius = 1;
            Length = Math.Max(My_Resolution().Width, My_Resolution().Height);
            if (My_Resolution().Height * 3 < 10000)
            {
                Iterations_Number = My_Resolution().Height * 3;
            }
            else
            {
                Iterations_Number = My_Resolution().Height;
            }
            Painter();
        }

        // At the speed of light.
        private void ToolStripMenuItem_Light_Speed_Click(object sender, EventArgs e)
        {
            Preset_Changed();
            Brush_Radius = 2;
            Length = Math.Max(My_Resolution().Width, My_Resolution().Height);
            Random_Coordinates = false;
            toolStripMenuItem_Random_Coordinates.BackColor = Color.LightPink;
            Painter();
        }



        




        #endregion

        #region Restart button
        private void toolStripButton_Resart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
        #endregion

    }
}

// Timofey Ivlev 2023.
