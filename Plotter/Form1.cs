using System;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Windows.Forms;


namespace Plotter
{
    public partial class Form1 : Form
    {
        //---------config----------//
        String pen_down = "G0 Z0";
        String pen_up = "G0 Z100";    
        string poort = "COM3";      
        int baud = 112500;
        //------------------------//

        private SerialPort myport;
        Bitmap image;
        Bitmap result_image;
        Bitmap temp;
        Bitmap prev_image;
        int image_x = 0;
        int image_y =0;

        Bitmap temp_org;
        int temp_width_org = 0;
        int temp_height_org = 0;

        int start_x = 0;
        int start_y = 0;

        bool mouse_status = false;
        Point prev_point = Point.Empty;

        public Form1()
        {
            InitializeComponent();
        }
        void find_begin() // find first pixel != white
        {
            
            for (int y = 0; y < image.Height; y++)
            {

                for (int x = 0; x < image.Width; x++)
                {

                    if (image.GetPixel(x, y).Name != "ffffffff")
                    {
                        start_x = x;
                        start_y = y;
                        return;
                    }
                }
            }
        }
        bool check_around(int x, int y) // look for arounding pixels that are white
        {
            if (x + 1 > image.Width && x - 1 < 0 && y + 1 > image.Height && y - 1 < 0)
                return true;

            if (x + 1 < image.Width && y + 1 < image.Height)
            {
                if (image.GetPixel(x + 1, y + 1).Name == "ffffffff")
                {
                    return true;
                }
            }
            if (x + 1 < image.Width)
            {
                if (image.GetPixel(x + 1, y).Name == "ffffffff")
                {
                    return true;
                }
            }
            if (x + 1 < image.Width && y - 1 >= 0)
            {
                if (image.GetPixel(x + 1, y - 1).Name == "ffffffff")
                {
                    return true;
                }
            }
            if (x - 1 >= 0 && y - 1 >=0)
            {
                if (image.GetPixel(x - 1, y - 1).Name == "ffffffff")
                {
                    return true;
                }
            }
            if (x - 1 >=0 && y + 1 < image.Height)
            {
                if (image.GetPixel(x - 1, y + 1).Name == "ffffffff")
                {
                    return true;
                }
            }
            if ( y + 1 < image.Height)
            {
                if (image.GetPixel(x, y + 1).Name == "ffffffff")
                {
                    return true;
                }
            }
            if ( y - 1 >=0)
            {
                if (image.GetPixel(x, y - 1).Name == "ffffffff")
                {
                    return true;
                }
            }
            if (x - 1 >= 0)
            {
                if (image.GetPixel(x - 1, y).Name == "ffffffff")
                {
                    return true;
                }
            }

            return false;
        }

        
        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            prev_image = new Bitmap(image);
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (Path.GetExtension(files[0]) == ".png" || Path.GetExtension(files[0]) == ".PNG" || Path.GetExtension(files[0]) == ".jpg" || Path.GetExtension(files[0]) == ".JPG" || Path.GetExtension(files[0]) == ".jpeg" || Path.GetExtension(files[0]) == ".JPEG)
            {
                temp = new Bitmap(Image.FromFile(files[0]));
                temp_org = new Bitmap(Image.FromFile(files[0]));
                for (int y = 0; y < temp.Height; y++)
                {
                    for (int x = 0; x < temp.Width; x++)
                    {
                        if (x + image_x < image.Width && y + image_y < image.Height && temp.GetPixel(x, y).Name != "ffffffff")
                            image.SetPixel(x + image_x, y + image_y, Color.Black);
                    }
                }
                temp_height_org = temp.Height;
                temp_width_org = temp.Width;

                pictureBox1.Image = image;

                label1.Text = "";
                numericUpDown1.Value = 100;
                Selected_image_x.Value = 0;
                Selected_image_y.Value = 0;
                numericUpDown1.Enabled = true;
                Selected_image_x.Enabled = true;
                Selected_image_y.Enabled = true;
                Selected_image_remove.Enabled = true;
                calculate.Enabled = true;
            }
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AllowDrop = true;
            print.Enabled = false;
            calculate.Enabled = false;
            numericUpDown1.Enabled = false;
            Selected_image_x.Enabled = false;
            Selected_image_y.Enabled = false;
            Selected_image_remove.Enabled = false;
            image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            prev_image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            using (Graphics gfx = Graphics.FromImage(image))
            using (SolidBrush brush = new SolidBrush(Color.White))
            {
                gfx.FillRectangle(brush, 0, 0, pictureBox1.Width, pictureBox1.Height);
            }
            using (Graphics gfx = Graphics.FromImage(prev_image))
            using (SolidBrush brush = new SolidBrush(Color.White))
            {
                gfx.FillRectangle(brush, 0, 0, pictureBox1.Width, pictureBox1.Height);
            }

            pictureBox1.Image = image;
        }

        private void print_Click(object sender, EventArgs e)
        {

        }

        private void SelectImage_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                temp = new Bitmap(Image.FromFile(openFileDialog1.FileName));
                temp_org = new Bitmap(Image.FromFile(openFileDialog1.FileName));
                for (int y = 0; y < temp.Height; y++)
                {
                    for (int x = 0; x < temp.Width; x++)
                    {
                        if (x + image_x < image.Width && y + image_y < image.Height && temp.GetPixel(x, y).Name != "ffffffff")
                            image.SetPixel(x + image_x, y + image_y, Color.Black);
                    }
                }
                temp_height_org = temp.Height;
                temp_width_org = temp.Width;

                pictureBox1.Image = image;

                label1.Text = "";
                calculate.Enabled = true;

                numericUpDown1.Value = 100;
                Selected_image_x.Value = 0;
                Selected_image_y.Value = 0;
                numericUpDown1.Enabled = true;
                Selected_image_x.Enabled = true;
                Selected_image_y.Enabled = true;
                Selected_image_remove.Enabled = true;
            }
        }

        private void calculate_Click(object sender, EventArgs e)
        {

            if (pictureBox1.Image == null)
            {
                return;
            }
            image = new Bitmap(pictureBox1.Image);
            print.Enabled = false;
            StreamWriter sw = new StreamWriter("gcode.txt"); //open file to write gcode
            int[,] writed = new int[image.Width, image.Height]; //array with points already in gcode
            result_image = new Bitmap(image.Width, image.Height);
            

            find_begin(); //find first pixel != white
             int current_x = start_x;
             int current_y = start_y;
             int prev_direction = 0;

             sw.WriteLine(pen_down); //write pen down in gcode

             for (; ; ) { //loop infinity
                 int direction = 8; //set default direction 

                //check for arounded pixel that isn't white and set direction
                if (current_x + 1 < image.Width && current_y + 1 < image.Height )
                {
                    if (image.GetPixel(current_x + 1, current_y + 1).Name != "ffffffff" && writed[current_x + 1, current_y + 1] != 1 && check_around(current_x + 1, current_y + 1))
                    {
                        direction = 2;
                    }
                }
                if (current_x + 1 < image.Width)
                {
                    if (image.GetPixel(current_x + 1, current_y).Name != "ffffffff" && writed[current_x + 1, current_y] != 1 && check_around(current_x + 1, current_y))
                    {
                        direction = 0;
                    }
                }
                if (current_x + 1 < image.Width && current_y - 1 >= 0)
                {
                    if (image.GetPixel(current_x + 1,current_y - 1).Name != "ffffffff" && writed[current_x + 1, current_y - 1] != 1 && check_around(current_x + 1, current_y - 1))
                    {
                        direction = 1;
                    }
                }
                if (current_x - 1 >= 0 && current_y - 1 >= 0)
                {
                    if (image.GetPixel(current_x - 1, current_y - 1).Name != "ffffffff" && writed[current_x - 1, current_y - 1] != 1 && check_around(current_x - 1, current_y - 1))
                    {
                        direction = 3;
                    }
                }
                if (current_x -1 >= 0  && current_y + 1 < image.Height)
                {
                    if (image.GetPixel(current_x - 1, current_y + 1).Name != "ffffffff" && writed[current_x - 1, current_y + 1] != 1 && check_around(current_x - 1, current_y + 1))
                    {
                        direction = 4;
                    }
                }
                if ( current_y + 1 < image.Height)
                {
                    if (image.GetPixel(current_x, current_y + 1).Name != "ffffffff" && writed[current_x, current_y + 1] != 1 && check_around(current_x, current_y + 1))
                    {
                        direction = 5;
                    }
                }
                if ( current_y - 1 >= 0)
                {
                    if (image.GetPixel(current_x, current_y - 1).Name != "ffffffff" && writed[current_x, current_y - 1] != 1 && check_around(current_x, current_y - 1))
                    {
                        direction = 6;
                    }
                }
                if (current_x - 1 >= 0)
                {
                    if (image.GetPixel(Math.Abs(current_x - 1), current_y).Name != "ffffffff" && writed[Math.Abs(current_x - 1), current_y] != 1 && check_around(current_x - 1, current_y))
                    {
                        direction = 7;
                    }
                }

                 //if no arounded pixel is found
                 if(direction == 8)
                 {
                     int ok = 0;
                     for(int y=0; y < image.Height && ok ==0; y++) //loop through all pixels
                     {
                         for(int x =0; x<image.Width && ok == 0; x++)
                         {
                             if (image.GetPixel(x, y).Name != "ffffffff" && writed[x,y] != 1 && check_around(x,y)) //check for pixel != white that isn't already writed.
                             {
                                 current_x = x;
                                 current_y = y;
                                 sw.WriteLine(pen_up);// write pen up to gcode fiel
                                 sw.WriteLine("G0 X" + current_x + " Y" + current_y + " F2400"); //move to coordinate of pixel != white
                                 sw.WriteLine(pen_down); //write pen down to gcode file
                                 ok = 1; //stop with looping
                                 writed[x, y] = 1; //set founden pixel in array writed
                              }
                         }
                     }
                     if(ok == 0) //all pixels have been writed to gcode file
                     {
                         sw.WriteLine(pen_up); //write pen up
                         //Close the file
                         sw.Close();
                        
                     
                        result.Image = result_image;
                        print.Enabled = true; // enable print button
                         return; // break out of infinity loop
                     }
                     
                 }
                 if (direction != prev_direction) //check if direction changes
                 {
                     sw.WriteLine("G0 X" + current_x + " Y" + current_y + " F2400"); //move to current coordinate
                 }

                 switch (direction)
                 {
                     case 0:
                         writed[current_x, current_y] = 1;
                        result_image.SetPixel(current_x, current_y, Color.Black);
                        current_x++;
                         break;

                     case 1:
                         writed[current_x, current_y] = 1;
                        result_image.SetPixel(current_x, current_y, Color.Black);
                        current_x++;
                         current_y--;
                         break;

                     case 2:
                         writed[current_x, current_y] = 1;
                        result_image.SetPixel(current_x, current_y, Color.Black);
                        current_x++;
                         current_y++;
                         break;
                     case 3:
                         writed[current_x, current_y] = 1;
                        result_image.SetPixel(current_x, current_y, Color.Black);
                        current_x--;
                         current_y--;
                         break;
                     case 4:
                         writed[current_x, current_y] = 1;
                        result_image.SetPixel(current_x, current_y, Color.Black);
                        current_x--;
                         current_y++;
                         break;
                     case 5:
                         writed[current_x, current_y] = 1;
                        result_image.SetPixel(current_x, current_y, Color.Black);
                        current_y++;
                         break;
                     case 6:
                         writed[current_x, current_y] = 1;
                        result_image.SetPixel(current_x, current_y, Color.Black);
                        current_y--;
                         break;
                     case 7:
                         writed[current_x, current_y] = 1;
                        result_image.SetPixel(current_x, current_y, Color.Black);
                        current_x--;
                         break;

                     default:
                         break;


                 }
               
            }
             
      }

        private void Connect_Click(object sender, EventArgs e)
        {
          int  ok = 1;
            
            try
            {
                myport = new SerialPort();
                myport.BaudRate = baud;
                myport.PortName = poort;
                //  if (myport.IsOpen) myport.Close();
                myport.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("kan geen verbinding maken op " + poort + ".\nprobeer een andere poort.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ok = 0;
            }
            if (ok == 1)
            {
                MessageBox.Show("verbinding gemaakt op " + poort, "verbinding gemaakt.", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, pictureBox1.ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        }

        private void result_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, result.ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouse_status && prev_point != null)
            {
                if (pictureBox1.Image == null)
                {
                    Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                    pictureBox1.Image = bmp;
                }

                using (Graphics g = Graphics.FromImage(pictureBox1.Image))
                {
                    g.DrawLine(new Pen(Color.Black, 2), prev_point, e.Location);
                }
                pictureBox1.Invalidate();
                prev_point = e.Location;
                calculate.Enabled = true;
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            mouse_status = true;
            prev_point = e.Location;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            mouse_status = false;
        }

        private void Selected_image_x_ValueChanged(object sender, EventArgs e)
        {
            
            for (int y = 0; y < temp.Height; y++)
              {
                  for (int x = 0; x < temp.Width; x++)
                  {
                      if (x + image_x < image.Width && y + image_y < image.Height && temp.GetPixel(x, y).Name == "ff000000" && prev_image.GetPixel(x, y).Name != "ff000000")
                          image.SetPixel(x + image_x, y + image_y, Color.White);
                  }
              }
              image_x = (int)Selected_image_x.Value;
              for (int y = 0; y < temp.Height; y++)
              {
                  for (int x = 0; x < temp.Width; x++)
                  {
                      if (x + image_x < image.Width && y + image_y < image.Height && temp.GetPixel(x, y).Name == "ff000000")
                          image.SetPixel(x + image_x, y + image_y, Color.Black);
                  }
              }
             pictureBox1.Image = image;
            
        }

        private void Selected_image_y_ValueChanged(object sender, EventArgs e)
        {
            for (int y = 0; y < temp.Height; y++)
            {
                for (int x = 0; x < temp.Width; x++)
                {
                    if (x + image_x < image.Width && y + image_y < image.Height && temp.GetPixel(x, y).Name == "ff000000" && prev_image.GetPixel(x, y).Name != "ff000000")
                        image.SetPixel(x + image_x, y + image_y, Color.White);
                }
            }
            image_y = (int)Selected_image_y.Value;
            for (int y = 0; y < temp.Height; y++)
            {
                for (int x = 0; x < temp.Width; x++)
                {
                    if (x + image_x < image.Width && y + image_y < image.Height && temp.GetPixel(x, y).Name == "ff000000")
                        image.SetPixel(x + image_x, y + image_y, Color.Black);
                }
            }
            pictureBox1.Image = image;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            for (int y = 0; y < temp.Height; y++)
            {
                for (int x = 0; x < temp.Width; x++)
                {
                    if (x + image_x < image.Width && y + image_y < image.Height && temp.GetPixel(x, y).Name == "ff000000" && prev_image.GetPixel(x, y).Name != "ff000000")
                        image.SetPixel(x + image_x, y + image_y, Color.White);
                }
            }
            temp = new Bitmap(temp_org, new Size((int)(temp_width_org *( (float)numericUpDown1.Value /100)),(int)( temp_height_org *( (float)numericUpDown1.Value /100))));

            for (int y = 0; y < temp.Height; y++)
            {
                for (int x = 0; x < temp.Width; x++)
                {
                    if (x + image_x < image.Width && y + image_y < image.Height && temp.GetPixel(x, y).Name == "ff000000")
                        image.SetPixel(x + image_x, y + image_y, Color.Black);
                }
            }
            pictureBox1.Image = image;
        }

        private void Selected_image_remove_Click(object sender, EventArgs e)
        {
            for (int y = 0; y < temp.Height; y++)
            {
                for (int x = 0; x < temp.Width; x++)
                {
                    if (x + image_x < image.Width && y + image_y < image.Height && temp.GetPixel(x, y).Name == "ff000000" && prev_image.GetPixel(x, y).Name != "ff000000")
                        image.SetPixel(x + image_x, y + image_y, Color.White);
                }
            }

            for (int y = 0; y < temp.Height; y++)
            {
                for (int x = 0; x < temp.Width; x++)
                {
                    temp.SetPixel(x, y, Color.White);
                }
            }
            pictureBox1.Image = image;
            numericUpDown1.Enabled = false;
            Selected_image_x.Enabled = false;
            Selected_image_y.Enabled = false;
            Selected_image_remove.Enabled = false;
            

        }
    }
}
