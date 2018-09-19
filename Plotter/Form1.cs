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

        Bitmap[] images = new Bitmap[30];
        int images_index = 0;
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

            if (image.GetPixel(x + 1, y + 1).Name == "ffffffff")
            {
                return true;
            }
            if (image.GetPixel(x + 1, y).Name == "ffffffff")
            {
                return true;
            }
            if (image.GetPixel(x + 1, y - 1).Name == "ffffffff")
            {
                return true;
            }
            if (image.GetPixel(x - 1, y - 1).Name == "ffffffff")
            {
                return true;
            }
            if (image.GetPixel(x - 1, y + 1).Name == "ffffffff")
            {
                return true;
            }
            if (image.GetPixel(x, y + 1).Name == "ffffffff")
            {
                return true;
            }
            if (image.GetPixel(x,y - 1).Name == "ffffffff")
            {
                return true;
            }
            if (image.GetPixel(x - 1, y).Name == "ffffffff")
            {
                return true;
            }

            return false;
        }
        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            //pictureBox1.Image = Image.FromFile(files[0]);
            Bitmap temp = new Bitmap(Image.FromFile(files[0]));
            Selected_Image.Items.Add( files[0]);
            images[images_index] = temp;
            label1.Text = "";
            calculate.Enabled = true;
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AllowDrop = true;
            print.Enabled = false;
            calculate.Enabled = true;
            image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
        }

        private void print_Click(object sender, EventArgs e)
        {

        }

        private void SelectImage_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                label1.Text = "";
                calculate.Enabled = true;
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
                 if (image.GetPixel(current_x + 1, current_y + 1).Name != "ffffffff" && writed[current_x+1, current_y+1] != 1 && check_around(current_x+1,current_y+1))
                 {
                     direction = 2;
                 }
                 if (image.GetPixel(current_x + 1, current_y).Name  != "ffffffff" && writed[current_x+1, current_y] != 1 && check_around(current_x+1, current_y))
                 {
                     direction = 0;
                 }
                 if (image.GetPixel(current_x + 1, current_y - 1).Name  != "ffffffff" && writed[current_x+1, current_y-1] != 1 && check_around(current_x+1, current_y-1))
                 {
                     direction = 1;
                 }
                 if (image.GetPixel(current_x - 1, current_y - 1).Name != "ffffffff" && writed[current_x-1, current_y-1] != 1 && check_around(current_x-1, current_y-1))
                 {
                     direction = 3;
                 }
                 if (image.GetPixel(current_x - 1, current_y + 1).Name != "ffffffff" && writed[current_x-1, current_y+1] != 1 && check_around(current_x-1, current_y+1))
                 {
                     direction = 4;
                 }
                 if (image.GetPixel(current_x, current_y + 1).Name != "ffffffff" && writed[current_x, current_y+1] != 1 && check_around(current_x, current_y+1))
                 {
                     direction = 5;
                 }
                 if (image.GetPixel(current_x, current_y - 1).Name != "ffffffff" && writed[current_x, current_y-1] != 1 && check_around(current_x, current_y-1))
                 {
                     direction = 6;
                 }
                 if (image.GetPixel(current_x - 1, current_y).Name != "ffffffff" && writed[current_x-1, current_y] != 1 && check_around(current_x-1, current_y))
                 {
                     direction = 7;
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
                        
                     /*   for (int y = 0; y < image.Height && ok == 0; y++) //loop through all pixels
                        {
                            for (int x = 0; x < image.Width && ok == 0; x++)
                            {
                                if (writed[x,y] == 1) { 
                                    result_image.SetPixel(x, y, Color.Black);
                                    
                                }
                            }
                        }*/
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

        }

        private void Selected_image_y_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
