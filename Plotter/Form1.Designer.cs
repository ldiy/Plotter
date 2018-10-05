namespace Plotter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.function_button = new System.Windows.Forms.Button();
            this.function_c = new System.Windows.Forms.NumericUpDown();
            this.function_b = new System.Windows.Forms.NumericUpDown();
            this.function_a = new System.Windows.Forms.NumericUpDown();
            this.Text_draw = new System.Windows.Forms.TextBox();
            this.height = new System.Windows.Forms.NumericUpDown();
            this.height_label = new System.Windows.Forms.Label();
            this.width = new System.Windows.Forms.NumericUpDown();
            this.radius = new System.Windows.Forms.NumericUpDown();
            this.Tool_select = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.draw_tool_size = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.text_label = new System.Windows.Forms.Label();
            this.width_label = new System.Windows.Forms.Label();
            this.Radius_label = new System.Windows.Forms.Label();
            this.function_label = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.COM_port = new System.Windows.Forms.ComboBox();
            this.Actions = new System.Windows.Forms.GroupBox();
            this.Step_size = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.pen_up_button = new System.Windows.Forms.Button();
            this.Pen_down_button = new System.Windows.Forms.Button();
            this.Y_min = new System.Windows.Forms.Button();
            this.Y_add = new System.Windows.Forms.Button();
            this.home = new System.Windows.Forms.Button();
            this.X_min = new System.Windows.Forms.Button();
            this.X_add = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Serial_box = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.result)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Selected_image_x)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Selected_image_y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.function_c)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.function_b)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.function_a)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.height)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.draw_tool_size)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.Actions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Step_size)).BeginInit();
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
            this.print.Location = new System.Drawing.Point(12, 467);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(1091, 29);
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
            this.calculate.Location = new System.Drawing.Point(615, 193);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(106, 23);
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
            this.result.Location = new System.Drawing.Point(615, 237);
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
            this.label2.Location = new System.Drawing.Point(618, 219);
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
            this.Clean.Location = new System.Drawing.Point(6, 103);
            this.Clean.Name = "Clean";
            this.Clean.Size = new System.Drawing.Size(89, 23);
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
            this.groupBox2.Controls.Add(this.function_button);
            this.groupBox2.Controls.Add(this.function_c);
            this.groupBox2.Controls.Add(this.function_b);
            this.groupBox2.Controls.Add(this.function_a);
            this.groupBox2.Controls.Add(this.Text_draw);
            this.groupBox2.Controls.Add(this.height);
            this.groupBox2.Controls.Add(this.height_label);
            this.groupBox2.Controls.Add(this.width);
            this.groupBox2.Controls.Add(this.radius);
            this.groupBox2.Controls.Add(this.Tool_select);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.draw_tool_size);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.text_label);
            this.groupBox2.Controls.Add(this.width_label);
            this.groupBox2.Controls.Add(this.Radius_label);
            this.groupBox2.Controls.Add(this.function_label);
            this.groupBox2.Location = new System.Drawing.Point(619, 99);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(296, 88);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Draw";
            // 
            // function_button
            // 
            this.function_button.Location = new System.Drawing.Point(219, 53);
            this.function_button.Name = "function_button";
            this.function_button.Size = new System.Drawing.Size(65, 23);
            this.function_button.TabIndex = 18;
            this.function_button.Text = "Draw";
            this.function_button.UseVisualStyleBackColor = true;
            this.function_button.Visible = false;
            this.function_button.Click += new System.EventHandler(this.function_button_Click);
            // 
            // function_c
            // 
            this.function_c.DecimalPlaces = 2;
            this.function_c.Location = new System.Drawing.Point(168, 55);
            this.function_c.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.function_c.Name = "function_c";
            this.function_c.Size = new System.Drawing.Size(45, 20);
            this.function_c.TabIndex = 17;
            this.function_c.Visible = false;
            // 
            // function_b
            // 
            this.function_b.DecimalPlaces = 2;
            this.function_b.Location = new System.Drawing.Point(103, 55);
            this.function_b.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.function_b.Name = "function_b";
            this.function_b.Size = new System.Drawing.Size(45, 20);
            this.function_b.TabIndex = 16;
            this.function_b.Visible = false;
            // 
            // function_a
            // 
            this.function_a.DecimalPlaces = 2;
            this.function_a.Location = new System.Drawing.Point(36, 55);
            this.function_a.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.function_a.Name = "function_a";
            this.function_a.Size = new System.Drawing.Size(45, 20);
            this.function_a.TabIndex = 15;
            this.function_a.Visible = false;
            // 
            // Text_draw
            // 
            this.Text_draw.Location = new System.Drawing.Point(46, 55);
            this.Text_draw.Name = "Text_draw";
            this.Text_draw.Size = new System.Drawing.Size(238, 20);
            this.Text_draw.TabIndex = 14;
            this.Text_draw.Visible = false;
            // 
            // height
            // 
            this.height.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.height.Location = new System.Drawing.Point(209, 56);
            this.height.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.height.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(75, 20);
            this.height.TabIndex = 12;
            this.height.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.height.Visible = false;
            // 
            // height_label
            // 
            this.height_label.AutoSize = true;
            this.height_label.Location = new System.Drawing.Point(165, 58);
            this.height_label.Name = "height_label";
            this.height_label.Size = new System.Drawing.Size(41, 13);
            this.height_label.TabIndex = 11;
            this.height_label.Text = "Height:";
            this.height_label.Visible = false;
            // 
            // width
            // 
            this.width.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.width.Location = new System.Drawing.Point(51, 56);
            this.width.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.width.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.width.Name = "width";
            this.width.Size = new System.Drawing.Size(75, 20);
            this.width.TabIndex = 10;
            this.width.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.width.Visible = false;
            // 
            // radius
            // 
            this.radius.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.radius.Location = new System.Drawing.Point(54, 52);
            this.radius.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.radius.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.radius.Name = "radius";
            this.radius.Size = new System.Drawing.Size(58, 20);
            this.radius.TabIndex = 8;
            this.radius.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.radius.Visible = false;
            // 
            // Tool_select
            // 
            this.Tool_select.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Tool_select.FormattingEnabled = true;
            this.Tool_select.Items.AddRange(new object[] {
            "Pen",
            "Gum",
            "Line",
            "Circle",
            "Rectangle",
            "Text",
            "Function"});
            this.Tool_select.Location = new System.Drawing.Point(6, 19);
            this.Tool_select.Name = "Tool_select";
            this.Tool_select.Size = new System.Drawing.Size(121, 21);
            this.Tool_select.TabIndex = 6;
            this.Tool_select.SelectedIndexChanged += new System.EventHandler(this.Tool_select_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(272, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "px";
            // 
            // draw_tool_size
            // 
            this.draw_tool_size.Location = new System.Drawing.Point(209, 20);
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(173, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Size:";
            // 
            // text_label
            // 
            this.text_label.AutoSize = true;
            this.text_label.Location = new System.Drawing.Point(9, 58);
            this.text_label.Name = "text_label";
            this.text_label.Size = new System.Drawing.Size(31, 13);
            this.text_label.TabIndex = 13;
            this.text_label.Text = "Text:";
            this.text_label.Visible = false;
            // 
            // width_label
            // 
            this.width_label.AutoSize = true;
            this.width_label.Location = new System.Drawing.Point(7, 58);
            this.width_label.Name = "width_label";
            this.width_label.Size = new System.Drawing.Size(38, 13);
            this.width_label.TabIndex = 9;
            this.width_label.Text = "Width:";
            this.width_label.Visible = false;
            // 
            // Radius_label
            // 
            this.Radius_label.AutoSize = true;
            this.Radius_label.Location = new System.Drawing.Point(7, 58);
            this.Radius_label.Name = "Radius_label";
            this.Radius_label.Size = new System.Drawing.Size(43, 13);
            this.Radius_label.TabIndex = 7;
            this.Radius_label.Text = "Radius:";
            this.Radius_label.Visible = false;
            // 
            // function_label
            // 
            this.function_label.AutoSize = true;
            this.function_label.BackColor = System.Drawing.Color.Transparent;
            this.function_label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.function_label.Location = new System.Drawing.Point(9, 59);
            this.function_label.Name = "function_label";
            this.function_label.Size = new System.Drawing.Size(155, 13);
            this.function_label.TabIndex = 19;
            this.function_label.Text = "fx=                    X²                   X";
            this.function_label.Visible = false;
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Port:";
            // 
            // COM_port
            // 
            this.COM_port.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.COM_port.FormattingEnabled = true;
            this.COM_port.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9",
            "COM10"});
            this.COM_port.Location = new System.Drawing.Point(49, 17);
            this.COM_port.Name = "COM_port";
            this.COM_port.Size = new System.Drawing.Size(121, 21);
            this.COM_port.TabIndex = 6;
            // 
            // Actions
            // 
            this.Actions.Controls.Add(this.Step_size);
            this.Actions.Controls.Add(this.label10);
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
            // Step_size
            // 
            this.Step_size.Location = new System.Drawing.Point(49, 78);
            this.Step_size.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.Step_size.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Step_size.Name = "Step_size";
            this.Step_size.Size = new System.Drawing.Size(46, 20);
            this.Step_size.TabIndex = 25;
            this.Step_size.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(0, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 14);
            this.label10.TabIndex = 26;
            this.label10.Text = "Step size:";
            // 
            // pen_up_button
            // 
            this.pen_up_button.Location = new System.Drawing.Point(101, 103);
            this.pen_up_button.Name = "pen_up_button";
            this.pen_up_button.Size = new System.Drawing.Size(75, 23);
            this.pen_up_button.TabIndex = 24;
            this.pen_up_button.Text = "Pen Up";
            this.pen_up_button.UseVisualStyleBackColor = true;
            this.pen_up_button.Click += new System.EventHandler(this.pen_up_button_Click);
            // 
            // Pen_down_button
            // 
            this.Pen_down_button.Location = new System.Drawing.Point(101, 77);
            this.Pen_down_button.Name = "Pen_down_button";
            this.Pen_down_button.Size = new System.Drawing.Size(75, 23);
            this.Pen_down_button.TabIndex = 23;
            this.Pen_down_button.Text = "Pen Down";
            this.Pen_down_button.UseVisualStyleBackColor = true;
            this.Pen_down_button.Click += new System.EventHandler(this.Pen_down_button_Click);
            // 
            // Y_min
            // 
            this.Y_min.Location = new System.Drawing.Point(125, 48);
            this.Y_min.Name = "Y_min";
            this.Y_min.Size = new System.Drawing.Size(45, 23);
            this.Y_min.TabIndex = 22;
            this.Y_min.Text = "Y -";
            this.Y_min.UseVisualStyleBackColor = true;
            this.Y_min.Click += new System.EventHandler(this.Y_min_Click);
            // 
            // Y_add
            // 
            this.Y_add.Location = new System.Drawing.Point(10, 48);
            this.Y_add.Name = "Y_add";
            this.Y_add.Size = new System.Drawing.Size(52, 23);
            this.Y_add.TabIndex = 21;
            this.Y_add.Text = "Y +";
            this.Y_add.UseVisualStyleBackColor = true;
            this.Y_add.Click += new System.EventHandler(this.Y_add_Click);
            // 
            // home
            // 
            this.home.Location = new System.Drawing.Point(68, 19);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(51, 52);
            this.home.TabIndex = 20;
            this.home.Text = "Home";
            this.home.UseVisualStyleBackColor = true;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // X_min
            // 
            this.X_min.Location = new System.Drawing.Point(125, 19);
            this.X_min.Name = "X_min";
            this.X_min.Size = new System.Drawing.Size(45, 23);
            this.X_min.TabIndex = 19;
            this.X_min.Text = "X -";
            this.X_min.UseVisualStyleBackColor = true;
            this.X_min.Click += new System.EventHandler(this.X_min_Click);
            // 
            // X_add
            // 
            this.X_add.Location = new System.Drawing.Point(10, 19);
            this.X_add.Name = "X_add";
            this.X_add.Size = new System.Drawing.Size(52, 23);
            this.X_add.TabIndex = 18;
            this.X_add.Text = "X +";
            this.X_add.UseVisualStyleBackColor = true;
            this.X_add.Click += new System.EventHandler(this.X_add_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Serial_box);
            this.groupBox4.Location = new System.Drawing.Point(921, 240);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(182, 221);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Serial";
            // 
            // Serial_box
            // 
            this.Serial_box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Serial_box.Location = new System.Drawing.Point(3, 16);
            this.Serial_box.Multiline = true;
            this.Serial_box.Name = "Serial_box";
            this.Serial_box.ReadOnly = true;
            this.Serial_box.Size = new System.Drawing.Size(176, 202);
            this.Serial_box.TabIndex = 0;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(731, 193);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(184, 23);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 23;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1108, 498);
            this.Controls.Add(this.progressBar1);
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
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
            ((System.ComponentModel.ISupportInitialize)(this.function_c)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.function_b)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.function_a)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.height)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.width)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.draw_tool_size)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.Actions.ResumeLayout(false);
            this.Actions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Step_size)).EndInit();
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
        private System.Windows.Forms.TextBox Serial_box;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown Step_size;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox Tool_select;
        private System.Windows.Forms.NumericUpDown radius;
        private System.Windows.Forms.Label Radius_label;
        private System.Windows.Forms.NumericUpDown height;
        private System.Windows.Forms.Label height_label;
        private System.Windows.Forms.NumericUpDown width;
        private System.Windows.Forms.Label width_label;
        private System.Windows.Forms.TextBox Text_draw;
        private System.Windows.Forms.Label text_label;
        private System.Windows.Forms.Label function_label;
        private System.Windows.Forms.Button function_button;
        private System.Windows.Forms.NumericUpDown function_c;
        private System.Windows.Forms.NumericUpDown function_b;
        private System.Windows.Forms.NumericUpDown function_a;
    }
}

