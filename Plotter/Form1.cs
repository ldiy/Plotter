using System;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Windows.Forms;
using System.Threading;
using OxyPlot;
using OxyPlot.Series;
using OxyPlot.WindowsForms;

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

        int draw_mode = 1; // 1 = pen    0 = gum

       // bool calculate_status = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Myport_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string line = myport.ReadLine();
            this.BeginInvoke(new LineReceivedEvent(LineReceived), line);
        }

        private delegate void LineReceivedEvent(string line);
        private void LineReceived(string line)
        {
            //What to do with the received line here
            String SerialOntvangen = (Serial_box.Text + "\r\n" + line);
            Serial_box.Text = (SerialOntvangen);
            Serial_box.ScrollToCaret();


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
            if (x + 1 > image.Width && x - 1 < 0 && y + 1 > image.Height && y - 1 < 0) //check if it is in its limtis
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

        void calculte_gcode()
        {
            //var backgroundWorker = sender as BackgroundWorker;
            if (pictureBox1.Image == null) //check if a image is in the picturebox
            {
                return;
            }
            image = new Bitmap(pictureBox1.Image);

            StreamWriter sw = new StreamWriter("gcode.txt"); //open file to write gcode
            int[,] writed = new int[image.Width, image.Height]; //array with points already in gcode
            result_image = new Bitmap(image.Width, image.Height);


            find_begin(); //find first pixel != white
            int current_x = start_x;
            int current_y = start_y;
            int prev_direction = 0;

            sw.WriteLine(pen_down); //write pen down in gcode

            int status = 0;
            int black_pixel_in_image = 1;

            //count all black pixels in image for status
            for(int y=0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Height; x++)
                {
                    if (image.GetPixel(x, y).Name != "ffffffff")
                        black_pixel_in_image++;
                }
            }
            
            for (; ; )
            { //loop infinity
                int direction = 8; //set default direction 

                //check for arounded pixel that isn't white and set direction
                if (current_x + 1 < image.Width && current_y + 1 < image.Height)
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
                    if (image.GetPixel(current_x + 1, current_y - 1).Name != "ffffffff" && writed[current_x + 1, current_y - 1] != 1 && check_around(current_x + 1, current_y - 1))
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
                if (current_x - 1 >= 0 && current_y + 1 < image.Height)
                {
                    if (image.GetPixel(current_x - 1, current_y + 1).Name != "ffffffff" && writed[current_x - 1, current_y + 1] != 1 && check_around(current_x - 1, current_y + 1))
                    {
                        direction = 4;
                    }
                }
                if (current_y + 1 < image.Height)
                {
                    if (image.GetPixel(current_x, current_y + 1).Name != "ffffffff" && writed[current_x, current_y + 1] != 1 && check_around(current_x, current_y + 1))
                    {
                        direction = 5;
                    }
                }
                if (current_y - 1 >= 0)
                {
                    if (image.GetPixel(current_x, current_y - 1).Name != "ffffffff" && writed[current_x, current_y - 1] != 1 && check_around(current_x, current_y - 1))
                    {
                        direction = 6;
                    }
                }
                if (current_x - 1 >= 0)
                {
                    if (image.GetPixel(current_x - 1, current_y).Name != "ffffffff" && writed[current_x - 1, current_y] != 1 && check_around(current_x - 1, current_y))
                    {
                        direction = 7;
                    }
                }

                //if no arounded pixel is found
                if (direction == 8)
                {
                    int ok = 0;
                    for (int y = 0; y < image.Height && ok == 0; y++) //loop through all pixels
                    {
                        for (int x = 0; x < image.Width && ok == 0; x++)
                        {
                            if (image.GetPixel(x, y).Name != "ffffffff" && writed[x, y] != 1 && check_around(x, y)) //check for pixel != white that isn't already writed.
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
                    if (ok == 0) //all pixels have been writed to gcode file
                    {
                        sw.WriteLine(pen_up); //write pen up
                                              //Close the file
                        sw.Close();


                        result.Image = result_image;
                        backgroundWorker1.ReportProgress(100);
                        Thread.Sleep(200);
                        backgroundWorker1.ReportProgress(0);
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
                        status++;
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
                        status++;
                        break;
                    case 3:
                        writed[current_x, current_y] = 1;
                        result_image.SetPixel(current_x, current_y, Color.Black);
                        current_x--;
                        current_y--;
                        status++;
                        break;
                    case 4:
                        writed[current_x, current_y] = 1;
                        result_image.SetPixel(current_x, current_y, Color.Black);
                        current_x--;
                        current_y++;
                        status++;
                        break;
                    case 5:
                        writed[current_x, current_y] = 1;
                        result_image.SetPixel(current_x, current_y, Color.Black);
                        current_y++;
                        status++;
                        break;
                    case 6:
                        writed[current_x, current_y] = 1;
                        result_image.SetPixel(current_x, current_y, Color.Black);
                        current_y--;
                        status++;
                        break;
                    case 7:
                        writed[current_x, current_y] = 1;
                        result_image.SetPixel(current_x, current_y, Color.Black);
                        current_x--;
                        status++;
                        break;

                    default:
                        break;


                }
                backgroundWorker1.ReportProgress(100 * status / black_pixel_in_image);
            }

        }
        
        private void Form1_DragDrop(object sender, DragEventArgs e) //function for draging files
        {
            prev_image = new Bitmap(image);
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop); //get file location 
            if (Path.GetExtension(files[0]) == ".png" || Path.GetExtension(files[0]) == ".PNG" || Path.GetExtension(files[0]) == ".jpg" || Path.GetExtension(files[0]) == ".JPG" || Path.GetExtension(files[0]) == ".jpeg" || Path.GetExtension(files[0]) == ".JPEG") //check if file is a image
            {
                //get bitmap form image
                temp = new Bitmap(Image.FromFile(files[0]));
                temp_org = new Bitmap(Image.FromFile(files[0]));

                //add image to full image
                for (int y = 0; y < temp.Height; y++)
                {
                    for (int x = 0; x < temp.Width; x++)
                    {
                        if (x + image_x < image.Width && y + image_y < image.Height && temp.GetPixel(x, y).Name != "ffffffff")
                            image.SetPixel(x + image_x, y + image_y, Color.Black);
                    }
                }
                pictureBox1.Image = image;

                //set some vars
                temp_height_org = temp.Height;
                temp_width_org = temp.Width;
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
            //set some vars
            AllowDrop = true;
            print.Enabled = false;
            calculate.Enabled = false;
            numericUpDown1.Enabled = false;
            Selected_image_x.Enabled = false;
            Selected_image_y.Enabled = false;
            Selected_image_remove.Enabled = false;         
            X_add.Enabled = false;
            X_min.Enabled = false;
            Y_add.Enabled = false;
            Y_min.Enabled = false;
            home.Enabled = false;
            Clean.Enabled = false;
            Pen_down_button.Enabled = false;
            pen_up_button.Enabled = false;
            //create new bitmaps with size of the picturebox
            image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            prev_image = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            //make created bitmaps fully white
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

            //display bitmap in picturebox
            pictureBox1.Image = image;
        }

        private void print_Click(object sender, EventArgs e) //Send to plotter
        {

        }

        private void SelectImage_Click(object sender, EventArgs e) //function for select an image
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK) //open a file dialog
            {
                //create bitmaps from file
                temp = new Bitmap(Image.FromFile(openFileDialog1.FileName));
                temp_org = new Bitmap(Image.FromFile(openFileDialog1.FileName));

                //add selected bitmap to fully bitmap
                for (int y = 0; y < temp.Height; y++)
                {
                    for (int x = 0; x < temp.Width; x++)
                    {
                        if (x + image_x < image.Width && y + image_y < image.Height && temp.GetPixel(x, y).Name != "ffffffff")
                            image.SetPixel(x + image_x, y + image_y, Color.Black);
                    }
                }
                pictureBox1.Image = image; //display bitmap in picturebox

                //set some vars
                temp_height_org = temp.Height;
                temp_width_org = temp.Width;           
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
           

            print.Enabled = false;


            // calculte_gcode();

            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.RunWorkerAsync();

            print.Enabled = true; // enable print button
           
        }

        private void Connect_Click(object sender, EventArgs e)
        {
          int  ok = 1;
            poort = COM_port.Text;
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
                myport.DataReceived += Myport_DataReceived;
                X_add.Enabled = true;
                X_min.Enabled = true;
                Y_add.Enabled = true;
                Y_min.Enabled = true;
                home.Enabled = true;
                Clean.Enabled = true;
                Pen_down_button.Enabled = true;
                pen_up_button.Enabled = true;
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e) //border around picturebox
        {
            ControlPaint.DrawBorder(e.Graphics, pictureBox1.ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        }

        private void result_Paint(object sender, PaintEventArgs e) //border around picturebox
        {
            ControlPaint.DrawBorder(e.Graphics, result.ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e) //draw in bitmap with mouse
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
                    if (draw_mode == 1)
                    {
                        g.DrawLine(new Pen(Color.Black, (int)draw_tool_size.Value), prev_point, e.Location);
                        pictureBox1.Invalidate();
                        prev_point = e.Location;
                        calculate.Enabled = true;
                        label1.Text = "";
                    }
                    else if(draw_mode == 0)
                    {
                        g.DrawLine(new Pen(Color.White, (int)draw_tool_size.Value), prev_point, e.Location);
                        pictureBox1.Invalidate();
                        prev_point = e.Location;
                        calculate.Enabled = true;
                        label1.Text = "";
                    }
                    
                }
               
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            mouse_status = true;
            prev_point = e.Location;

            if (pictureBox1.Image == null)
            {
                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                pictureBox1.Image = bmp;
            }

            using (Graphics g = Graphics.FromImage(pictureBox1.Image))
            {

                if (draw_mode == 3)
                {
                    g.DrawEllipse(new Pen(Color.Black, (int)draw_tool_size.Value), e.Location.X - (int)radius.Value/2, e.Location.Y - (int)radius.Value/2, (int)radius.Value, (int)radius.Value);
                    pictureBox1.Invalidate();
                    calculate.Enabled = true;
                    label1.Text = "";
                }
                if (draw_mode == 4)
                {
                    g.DrawRectangle(new Pen(Color.Black, (int)draw_tool_size.Value), e.Location.X, e.Location.Y, (int)width.Value, (int)height.Value);
                   pictureBox1.Invalidate();
                    calculate.Enabled = true;
                    label1.Text = "";
                }
                if (draw_mode == 6)
                {
                   
                    g.DrawString(Text_draw.Text, new Font("Arial", (int)draw_tool_size.Value), new SolidBrush(System.Drawing.Color.Black),e.Location.X,e.Location.Y);
                    pictureBox1.Invalidate();
                    calculate.Enabled = true;
                    label1.Text = "";
                }
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
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

                    if (draw_mode == 2)
                    {
                        
                        g.DrawLine(new Pen(Color.Black, (int)draw_tool_size.Value), prev_point, e.Location);
                        pictureBox1.Invalidate();
                        calculate.Enabled = true;
                        label1.Text = "";
                    }
                }
            }
            mouse_status = false;
        }

        private void Selected_image_x_ValueChanged(object sender, EventArgs e)
        {
               
            // clear previous drawed
              for (int y = 0; y < temp.Height; y++)
              {
                  for (int x = 0; x < temp.Width; x++)
                  {
                      if (x + image_x < image.Width && y + image_y < image.Height && temp.GetPixel(x, y).Name != "ffffffff" && prev_image.GetPixel(x, y).Name == "ffffffff")
                          image.SetPixel(x + image_x, y + image_y, Color.White);
                  }
              }

              image_x = (int)Selected_image_x.Value; //update x value

                //draw temp bitmap on new position
              for (int y = 0; y < temp.Height; y++)
              {
                  for (int x = 0; x < temp.Width; x++)
                  {
                      if (x + image_x < image.Width && y + image_y < image.Height && temp.GetPixel(x, y).Name != "ffffffff")
                          image.SetPixel(x + image_x, y + image_y, Color.Black);
                  }
              }
             pictureBox1.Image = image; //display image in picturebox
            
        }

        private void Selected_image_y_ValueChanged(object sender, EventArgs e)
        {
            //clear previous drawed bitmap
            for (int y = 0; y < temp.Height; y++)
            {
                for (int x = 0; x < temp.Width; x++)
                {
                    if (x + image_x < image.Width && y + image_y < image.Height && temp.GetPixel(x, y).Name != "ffffffff" && prev_image.GetPixel(x, y).Name == "ffffffff")
                        image.SetPixel(x + image_x, y + image_y, Color.White);
                }
            }
            
            image_y = (int)Selected_image_y.Value; //change y value

            //draw bitmap on new position
            for (int y = 0; y < temp.Height; y++)
            {
                for (int x = 0; x < temp.Width; x++)
                {
                    if (x + image_x < image.Width && y + image_y < image.Height && temp.GetPixel(x, y).Name != "ffffffff")
                        image.SetPixel(x + image_x, y + image_y, Color.Black);
                }
            }
            pictureBox1.Image = image; //display bitmap in picturebox
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            //clear previous drawed image
            for (int y = 0; y < temp.Height; y++)
            {
                for (int x = 0; x < temp.Width; x++)
                {
                    if (x + image_x < image.Width && y + image_y < image.Height && temp.GetPixel(x, y).Name != "ffffffff" && prev_image.GetPixel(x, y).Name == "ffffffff")
                        image.SetPixel(x + image_x, y + image_y, Color.White);
                }
            }

            //change size of bitmap
            temp = new Bitmap(temp_org, new Size((int)(temp_width_org *( (float)numericUpDown1.Value /100)),(int)( temp_height_org *( (float)numericUpDown1.Value /100))));

            //draw resizid bitmap on image
            for (int y = 0; y < temp.Height; y++)
            {
                for (int x = 0; x < temp.Width; x++)
                {
                    if (x + image_x < image.Width && y + image_y < image.Height && temp.GetPixel(x, y).Name != "ffffffff")
                        image.SetPixel(x + image_x, y + image_y, Color.Black);
                }
            }

            pictureBox1.Image = image; //display bitmap in picturebox
        }

        private void Selected_image_remove_Click(object sender, EventArgs e)
        {
            //clear drawed image
            for (int y = 0; y < temp.Height; y++)
            {
                for (int x = 0; x < temp.Width; x++)
                {
                    if (x + image_x < image.Width && y + image_y < image.Height && temp.GetPixel(x, y).Name != "ffffffff" && prev_image.GetPixel(x, y).Name == "ffffffff")
                        image.SetPixel(x + image_x, y + image_y, Color.White);
                }
            }

            //clear temp bitmap
            for (int y = 0; y < temp.Height; y++)
            {
                for (int x = 0; x < temp.Width; x++)
                {
                    temp.SetPixel(x, y, Color.White);
                }
            }

            pictureBox1.Image = image; // display bitmap in picturebox

            //set some vars
            numericUpDown1.Enabled = false;
            Selected_image_x.Enabled = false;
            Selected_image_y.Enabled = false;
            Selected_image_remove.Enabled = false;
            

        }

        private void Clean_Click(object sender, EventArgs e)
        {
            myport.WriteLine(pen_up);
            myport.WriteLine("G0 X5 Y20");
                                
        }
             

        private void X_add_Click(object sender, EventArgs e)
        {
            myport.WriteLine("G0 X" + Step_size + " F2400");
        }

        private void X_min_Click(object sender, EventArgs e)
        {
            myport.WriteLine("G0 X-" + Step_size + " F2400");
        }

        private void Y_add_Click(object sender, EventArgs e)
        {
            myport.WriteLine("G0 Y" + Step_size + " F2400");
        }

        private void Y_min_Click(object sender, EventArgs e)
        {
            myport.WriteLine("G0 Y-" + Step_size + " F2400");
        }

        private void Pen_down_button_Click(object sender, EventArgs e)
        {
            myport.WriteLine(pen_down);
        }

        private void pen_up_button_Click(object sender, EventArgs e)
        {
            myport.WriteLine(pen_up);
        }

        private void home_Click(object sender, EventArgs e)
        {
            myport.WriteLine("$H");
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            calculte_gcode();
        }

        private void backgroundWorker1_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

    

        private void Tool_select_SelectedIndexChanged(object sender, EventArgs e)
        {
            radius.Visible = false;
            Radius_label.Visible = false;
            width.Visible = false;
            width_label.Visible = false;
            height.Visible = false;
            height_label.Visible = false;
            Text_draw.Visible = false;
            text_label.Visible = false;
            function_a.Visible = false;
            function_b.Visible = false;
            function_c.Visible = false;
            function_button.Visible = false;
            function_label.Visible = false;
            draw_tool_size.Value = 1;

            switch (Tool_select.Text)
            {
                case "Pen":
                    draw_mode = 1;
                    break;

                case "Gum":
                    draw_mode = 0;
                    break;

                case "Line":
                    draw_mode = 2;
                    break;

                case "Circle":
                    draw_mode = 3;
                    Radius_label.Visible = true;
                    radius.Visible = true;
                    break;

                case "Rectangle":
                    draw_mode = 4;
                    width.Visible = true;
                    width_label.Visible = true;
                    height.Visible = true;
                    height_label.Visible = true;
                    break;

                case "Function":
                    function_a.Visible = true;
                    function_b.Visible = true;
                    function_c.Visible = true;
                    function_button.Visible = true;
                    function_label.Visible = true;
                    break;

                case "Text":
                    draw_mode = 6;
                    Text_draw.Visible = true;
                    text_label.Visible = true;
                    draw_tool_size.Value = 10;
                    break;
            }
        }

        private void function_button_Click(object sender, EventArgs e)
        {
            float a = -1*(float)function_a.Value;
            float b = -1*(float)function_b.Value;
            float c = -1*(float)function_c.Value;

            temp = new Bitmap(image);
            temp_org = new Bitmap(image);

            prev_image = new Bitmap(image);

            float i = -1 * pictureBox1.Width / 2;
            int fx = (int)Math.Floor(a * i * i + b * i + c) + pictureBox1.Height / 2;
            prev_point = new Point(0 , fx);
            using (Graphics g = Graphics.FromImage(temp) )
            {
                for (i = -1 * pictureBox1.Width / 2; i < pictureBox1.Width / 2; i= i + (float)0.1)
                {
                    fx = (int)Math.Floor(a * i * i + b * i + c) + pictureBox1.Height / 2;
                    if (fx < image.Height && fx >= 0)
                    {
                        // temp.SetPixel((int)i + pictureBox1.Width / 2, fx, Color.Black);
                        Point current = new Point((int)i + pictureBox1.Width / 2, fx);

                        g.DrawLine(new Pen(Color.Black, (int)draw_tool_size.Value), prev_point, current);
                        prev_point = current;
                    }
                }
            }

            fx = (int)Math.Floor(a * i * i + b * i + c) + pictureBox1.Height / 2;
            prev_point = new Point(0, fx);
            using (Graphics g = Graphics.FromImage(temp_org))
            {
                for (i = -1 * pictureBox1.Width / 2; i < pictureBox1.Width / 2; i = i + (float)0.1)
                {
                    fx = (int)Math.Floor(a * i * i + b * i + c) + pictureBox1.Height / 2;
                    if (fx < image.Height && fx >= 0)
                    {
                        // temp.SetPixel((int)i + pictureBox1.Width / 2, fx, Color.Black);
                        Point current = new Point((int)i + pictureBox1.Width / 2, fx);

                        g.DrawLine(new Pen(Color.Black, (int)draw_tool_size.Value), prev_point, current);
                        prev_point = current;
                    }
                }
            }

            fx = (int)Math.Floor(a * i * i + b * i + c) + pictureBox1.Height / 2;
            prev_point = new Point(0, fx);
            using (Graphics g = Graphics.FromImage(image) )
            {
                for (i = -1 * pictureBox1.Width / 2; i < pictureBox1.Width / 2; i = i + (float)0.1)
                {
                    fx = (int)Math.Floor(a * i * i + b * i + c) + pictureBox1.Height / 2;
                    if (fx < image.Height && fx >= 0)
                    {
                        // temp.SetPixel((int)i + pictureBox1.Width / 2, fx, Color.Black);
                        Point current = new Point((int)i + pictureBox1.Width / 2, fx);

                        g.DrawLine(new Pen(Color.Black, (int)draw_tool_size.Value), prev_point, current);
                        prev_point = current;
                    }
                }
            }

           
            pictureBox1.Image =image; //display bitmap in picturebox

            //set some vars
            temp_height_org = temp.Height;
            temp_width_org = temp.Width;
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
}
