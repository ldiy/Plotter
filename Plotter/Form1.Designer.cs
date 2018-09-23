﻿namespace Plotter
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.print = new System.Windows.Forms.Button();
            this.SelectImage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.calculate = new System.Windows.Forms.Button();
            this.Connect = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Selected_image_x = new System.Windows.Forms.NumericUpDown();
            this.Selected_image_y = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Selected_image_remove = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Clean = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.COM_port = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Actions = new System.Windows.Forms.GroupBox();
            this.X_add = new System.Windows.Forms.Button();
            this.X_min = new System.Windows.Forms.Button();
            this.home = new System.Windows.Forms.Button();
            this.Y_add = new System.Windows.Forms.Button();
            this.Y_min = new System.Windows.Forms.Button();
            this.Pen_down_button = new System.Windows.Forms.Button();
            this.pen_up_button = new System.Windows.Forms.Button();
            this.Pen_button = new System.Windows.Forms.Button();
            this.Gum = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.draw_tool_size = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.result)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Selected_image_x)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Selected_image_y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.Actions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.draw_tool_size)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // print
            // 
            this.print.Location = new System.Drawing.Point(615, 434);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(300, 29);
            this.print.TabIndex = 1;
            this.print.Text = "Print";
            this.print.UseVisualStyleBackColor = true;
            this.print.Click += new System.EventHandler(this.print_Click);
            // 
            // SelectImage
            // 
            this.SelectImage.Location = new System.Drawing.Point(1, 16);
            this.SelectImage.Name = "SelectImage";
            this.SelectImage.Size = new System.Drawing.Size(102, 23);
            this.SelectImage.TabIndex = 2;
            this.SelectImage.Text = "Select Image";
            this.SelectImage.UseVisualStyleBackColor = true;
            this.SelectImage.Click += new System.EventHandler(this.SelectImage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(86, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Drag and Drop Image or click Select Image";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif;" +
    " *.png";
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(615, 159);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(174, 23);
            this.calculate.TabIndex = 4;
            this.calculate.Text = "Calclulate Gcode";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // Connect
            // 
            this.Connect.Location = new System.Drawing.Point(6, 44);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(164, 23);
            this.Connect.TabIndex = 5;
            this.Connect.Text = "Connect";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // result
            // 
            this.result.BackColor = System.Drawing.Color.White;
            this.result.Location = new System.Drawing.Point(615, 203);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(300, 225);
            this.result.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.result.TabIndex = 6;
            this.result.TabStop = false;
            this.result.Paint += new System.Windows.Forms.PaintEventHandler(this.result_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(618, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Preview:";
            // 
            // Selected_image_x
            // 
            this.Selected_image_x.Location = new System.Drawing.Point(146, 19);
            this.Selected_image_x.Name = "Selected_image_x";
            this.Selected_image_x.Size = new System.Drawing.Size(55, 20);
            this.Selected_image_x.TabIndex = 9;
            this.Selected_image_x.ValueChanged += new System.EventHandler(this.Selected_image_x_ValueChanged);
            // 
            // Selected_image_y
            // 
            this.Selected_image_y.Location = new System.Drawing.Point(227, 19);
            this.Selected_image_y.Name = "Selected_image_y";
            this.Selected_image_y.Size = new System.Drawing.Size(51, 20);
            this.Selected_image_y.TabIndex = 10;
            this.Selected_image_y.ValueChanged += new System.EventHandler(this.Selected_image_y_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "X:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(207, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Y:";
            // 
            // Selected_image_remove
            // 
            this.Selected_image_remove.Location = new System.Drawing.Point(1, 45);
            this.Selected_image_remove.Name = "Selected_image_remove";
            this.Selected_image_remove.Size = new System.Drawing.Size(102, 23);
            this.Selected_image_remove.TabIndex = 13;
            this.Selected_image_remove.Text = "Remove";
            this.Selected_image_remove.UseVisualStyleBackColor = true;
            this.Selected_image_remove.Click += new System.EventHandler(this.Selected_image_remove_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(146, 48);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(55, 20);
            this.numericUpDown1.TabIndex = 14;
            this.numericUpDown1.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(110, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Size:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(207, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "%";
            // 
            // Clean
            // 
            this.Clean.Location = new System.Drawing.Point(6, 77);
            this.Clean.Name = "Clean";
            this.Clean.Size = new System.Drawing.Size(75, 49);
            this.Clean.TabIndex = 17;
            this.Clean.Text = "Clean";
            this.Clean.UseVisualStyleBackColor = true;
            this.Clean.Click += new System.EventHandler(this.Clean_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Selected_image_y);
            this.groupBox1.Controls.Add(this.SelectImage);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.Selected_image_x);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Selected_image_remove);
            this.groupBox1.Location = new System.Drawing.Point(618, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 80);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Image";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.draw_tool_size);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.Gum);
            this.groupBox2.Controls.Add(this.Pen_button);
            this.groupBox2.Location = new System.Drawing.Point(619, 99);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(296, 54);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Draw";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.COM_port);
            this.groupBox3.Controls.Add(this.Connect);
            this.groupBox3.Location = new System.Drawing.Point(921, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(182, 80);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Connect";
            // 
            // COM_port
            // 
            this.COM_port.FormattingEnabled = true;
            this.COM_port.Location = new System.Drawing.Point(49, 17);
            this.COM_port.Name = "COM_port";
            this.COM_port.Size = new System.Drawing.Size(121, 21);
            this.COM_port.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Port:";
            // 
            // Actions
            // 
            this.Actions.Controls.Add(this.pen_up_button);
            this.Actions.Controls.Add(this.Pen_down_button);
            this.Actions.Controls.Add(this.Y_min);
            this.Actions.Controls.Add(this.Y_add);
            this.Actions.Controls.Add(this.home);
            this.Actions.Controls.Add(this.X_min);
            this.Actions.Controls.Add(this.X_add);
            this.Actions.Controls.Add(this.Clean);
            this.Actions.Location = new System.Drawing.Point(921, 100);
            this.Actions.Name = "Actions";
            this.Actions.Size = new System.Drawing.Size(182, 134);
            this.Actions.TabIndex = 21;
            this.Actions.TabStop = false;
            this.Actions.Text = "Actions";
            // 
            // X_add
            // 
            this.X_add.Location = new System.Drawing.Point(10, 19);
            this.X_add.Name = "X_add";
            this.X_add.Size = new System.Drawing.Size(52, 23);
            this.X_add.TabIndex = 18;
            this.X_add.Text = "X +";
            this.X_add.UseVisualStyleBackColor = true;
            // 
            // X_min
            // 
            this.X_min.Location = new System.Drawing.Point(125, 19);
            this.X_min.Name = "X_min";
            this.X_min.Size = new System.Drawing.Size(45, 23);
            this.X_min.TabIndex = 19;
            this.X_min.Text = "X -";
            this.X_min.UseVisualStyleBackColor = true;
            // 
            // home
            // 
            this.home.Location = new System.Drawing.Point(68, 19);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(51, 52);
            this.home.TabIndex = 20;
            this.home.Text = "Home";
            this.home.UseVisualStyleBackColor = true;
            // 
            // Y_add
            // 
            this.Y_add.Location = new System.Drawing.Point(10, 48);
            this.Y_add.Name = "Y_add";
            this.Y_add.Size = new System.Drawing.Size(52, 23);
            this.Y_add.TabIndex = 21;
            this.Y_add.Text = "Y +";
            this.Y_add.UseVisualStyleBackColor = true;
            // 
            // Y_min
            // 
            this.Y_min.Location = new System.Drawing.Point(125, 48);
            this.Y_min.Name = "Y_min";
            this.Y_min.Size = new System.Drawing.Size(45, 23);
            this.Y_min.TabIndex = 22;
            this.Y_min.Text = "Y -";
            this.Y_min.UseVisualStyleBackColor = true;
            // 
            // Pen_down_button
            // 
            this.Pen_down_button.Location = new System.Drawing.Point(101, 77);
            this.Pen_down_button.Name = "Pen_down_button";
            this.Pen_down_button.Size = new System.Drawing.Size(75, 23);
            this.Pen_down_button.TabIndex = 23;
            this.Pen_down_button.Text = "Pen Down";
            this.Pen_down_button.UseVisualStyleBackColor = true;
            // 
            // pen_up_button
            // 
            this.pen_up_button.Location = new System.Drawing.Point(101, 103);
            this.pen_up_button.Name = "pen_up_button";
            this.pen_up_button.Size = new System.Drawing.Size(75, 23);
            this.pen_up_button.TabIndex = 24;
            this.pen_up_button.Text = "Pen Up";
            this.pen_up_button.UseVisualStyleBackColor = true;
            // 
            // Pen_button
            // 
            this.Pen_button.Location = new System.Drawing.Point(6, 19);
            this.Pen_button.Name = "Pen_button";
            this.Pen_button.Size = new System.Drawing.Size(53, 23);
            this.Pen_button.TabIndex = 0;
            this.Pen_button.Text = "Pen";
            this.Pen_button.UseVisualStyleBackColor = true;
            this.Pen_button.Click += new System.EventHandler(this.Pen_button_Click);
            // 
            // Gum
            // 
            this.Gum.Location = new System.Drawing.Point(65, 19);
            this.Gum.Name = "Gum";
            this.Gum.Size = new System.Drawing.Size(59, 23);
            this.Gum.TabIndex = 1;
            this.Gum.Text = "Gum";
            this.Gum.UseVisualStyleBackColor = true;
            this.Gum.Click += new System.EventHandler(this.Gum_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(130, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Size:";
            // 
            // draw_tool_size
            // 
            this.draw_tool_size.Location = new System.Drawing.Point(166, 22);
            this.draw_tool_size.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.draw_tool_size.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.draw_tool_size.Name = "draw_tool_size";
            this.draw_tool_size.Size = new System.Drawing.Size(57, 20);
            this.draw_tool_size.TabIndex = 3;
            this.draw_tool_size.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(229, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "px";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Location = new System.Drawing.Point(921, 240);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(182, 221);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Serial";
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(3, 16);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(176, 202);
            this.textBox1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1108, 473);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.Actions);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.result);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.print);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Plotter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.result)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Selected_image_x)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Selected_image_y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.Actions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.draw_tool_size)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button print;
        private System.Windows.Forms.Button SelectImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.PictureBox result;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown Selected_image_x;
        private System.Windows.Forms.NumericUpDown Selected_image_y;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Selected_image_remove;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Clean;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown draw_tool_size;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Gum;
        private System.Windows.Forms.Button Pen_button;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox COM_port;
        private System.Windows.Forms.GroupBox Actions;
        private System.Windows.Forms.Button pen_up_button;
        private System.Windows.Forms.Button Pen_down_button;
        private System.Windows.Forms.Button Y_min;
        private System.Windows.Forms.Button Y_add;
        private System.Windows.Forms.Button home;
        private System.Windows.Forms.Button X_min;
        private System.Windows.Forms.Button X_add;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox1;
    }
}

