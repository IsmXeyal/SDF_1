namespace SDF_1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            pictureBox1 = new PictureBox();
            labell = new Label();
            pictureBox2 = new PictureBox();
            Hide_box = new PictureBox();
            metric = new Label();
            width = new Label();
            length = new Label();
            metricbox = new ComboBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            calculate = new Button();
            panel1 = new Panel();
            per_met = new Label();
            met_area = new Label();
            pictureBox3 = new PictureBox();
            perim_ans = new Label();
            area_ans = new Label();
            perimeter = new Label();
            area = new Label();
            result = new Label();
            backBox = new PictureBox();
            panel2 = new Panel();
            info_box = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Hide_box).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)backBox).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)info_box).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Screenshot_2023_10_22_121833;
            pictureBox1.Location = new Point(567, 60);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(205, 119);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // labell
            // 
            labell.BackColor = Color.LightGray;
            labell.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labell.Location = new Point(342, 21);
            labell.Name = "labell";
            labell.Size = new Size(130, 29);
            labell.TabIndex = 1;
            labell.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.MenuHighlight;
            pictureBox2.Image = Properties.Resources.images;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(786, 567);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // Hide_box
            // 
            Hide_box.BackColor = Color.RoyalBlue;
            Hide_box.Image = Properties.Resources.Aniket_Suvarna_Box_Bxs_hide_48;
            Hide_box.Location = new Point(723, 21);
            Hide_box.Name = "Hide_box";
            Hide_box.Size = new Size(49, 29);
            Hide_box.SizeMode = PictureBoxSizeMode.Zoom;
            Hide_box.TabIndex = 3;
            Hide_box.TabStop = false;
            Hide_box.Click += HideBox_Click;
            // 
            // metric
            // 
            metric.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            metric.Location = new Point(26, 79);
            metric.Name = "metric";
            metric.Size = new Size(78, 26);
            metric.TabIndex = 4;
            metric.Text = "Metric";
            metric.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // width
            // 
            width.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            width.Location = new Point(26, 132);
            width.Name = "width";
            width.Size = new Size(78, 26);
            width.TabIndex = 5;
            width.Text = "Width";
            width.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // length
            // 
            length.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            length.Location = new Point(26, 184);
            length.Name = "length";
            length.Size = new Size(78, 26);
            length.TabIndex = 6;
            length.Text = "Length";
            length.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // metricbox
            // 
            metricbox.DropDownStyle = ComboBoxStyle.DropDownList;
            metricbox.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            metricbox.FormattingEnabled = true;
            metricbox.Location = new Point(148, 79);
            metricbox.Name = "metricbox";
            metricbox.Size = new Size(75, 26);
            metricbox.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(148, 132);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 26);
            textBox1.TabIndex = 8;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(148, 184);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 26);
            textBox2.TabIndex = 9;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // calculate
            // 
            calculate.BackColor = Color.OrangeRed;
            calculate.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            calculate.Location = new Point(26, 257);
            calculate.Name = "calculate";
            calculate.Size = new Size(232, 34);
            calculate.TabIndex = 10;
            calculate.Text = "Calculate";
            calculate.UseVisualStyleBackColor = false;
            calculate.Click += calculate_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.CornflowerBlue;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(per_met);
            panel1.Controls.Add(met_area);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(perim_ans);
            panel1.Controls.Add(area_ans);
            panel1.Controls.Add(perimeter);
            panel1.Controls.Add(area);
            panel1.Controls.Add(result);
            panel1.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.Location = new Point(264, 79);
            panel1.Name = "panel1";
            panel1.Size = new Size(287, 222);
            panel1.TabIndex = 11;
            // 
            // per_met
            // 
            per_met.BackColor = Color.AliceBlue;
            per_met.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            per_met.Location = new Point(231, 126);
            per_met.Name = "per_met";
            per_met.Size = new Size(40, 31);
            per_met.TabIndex = 19;
            per_met.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // met_area
            // 
            met_area.BackColor = Color.AliceBlue;
            met_area.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            met_area.Location = new Point(231, 67);
            met_area.Name = "met_area";
            met_area.Size = new Size(40, 30);
            met_area.TabIndex = 18;
            met_area.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Hopstarter_Sleek_Xp_Basic_Close_48;
            pictureBox3.Location = new Point(254, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(26, 25);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 17;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // perim_ans
            // 
            perim_ans.BackColor = Color.AliceBlue;
            perim_ans.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            perim_ans.Location = new Point(90, 126);
            perim_ans.Name = "perim_ans";
            perim_ans.Size = new Size(135, 31);
            perim_ans.TabIndex = 16;
            perim_ans.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // area_ans
            // 
            area_ans.BackColor = Color.AliceBlue;
            area_ans.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            area_ans.Location = new Point(90, 67);
            area_ans.Name = "area_ans";
            area_ans.Size = new Size(135, 30);
            area_ans.TabIndex = 15;
            area_ans.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // perimeter
            // 
            perimeter.BackColor = Color.OrangeRed;
            perimeter.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            perimeter.Location = new Point(3, 126);
            perimeter.Name = "perimeter";
            perimeter.Size = new Size(81, 31);
            perimeter.TabIndex = 14;
            perimeter.Text = "Perimeter";
            perimeter.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // area
            // 
            area.BackColor = Color.OrangeRed;
            area.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            area.ForeColor = Color.Black;
            area.ImageAlign = ContentAlignment.MiddleLeft;
            area.Location = new Point(3, 67);
            area.Name = "area";
            area.Size = new Size(48, 30);
            area.TabIndex = 13;
            area.Text = "Area";
            area.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // result
            // 
            result.BackColor = Color.LimeGreen;
            result.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            result.Location = new Point(87, 15);
            result.Name = "result";
            result.Size = new Size(108, 26);
            result.TabIndex = 12;
            result.Text = "Result";
            result.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // backBox
            // 
            backBox.BackColor = Color.SteelBlue;
            backBox.Image = Properties.Resources.Rafiqul_Hassan_Blogger_Arrow_Back_72;
            backBox.Location = new Point(0, 0);
            backBox.Name = "backBox";
            backBox.Size = new Size(42, 33);
            backBox.SizeMode = PictureBoxSizeMode.Zoom;
            backBox.TabIndex = 12;
            backBox.TabStop = false;
            backBox.Click += backBox_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(info_box);
            panel2.Location = new Point(12, 322);
            panel2.Name = "panel2";
            panel2.Size = new Size(760, 227);
            panel2.TabIndex = 13;
            // 
            // info_box
            // 
            info_box.Image = Properties.Resources.Oxygen_Icons_org_Oxygen_Status_dialog_information_64;
            info_box.Location = new Point(726, 3);
            info_box.Name = "info_box";
            info_box.Size = new Size(31, 30);
            info_box.SizeMode = PictureBoxSizeMode.StretchImage;
            info_box.TabIndex = 0;
            info_box.TabStop = false;
            info_box.Click += info_box_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(784, 561);
            Controls.Add(panel2);
            Controls.Add(backBox);
            Controls.Add(panel1);
            Controls.Add(calculate);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(metricbox);
            Controls.Add(length);
            Controls.Add(width);
            Controls.Add(metric);
            Controls.Add(Hide_box);
            Controls.Add(labell);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculate";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)Hide_box).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)backBox).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)info_box).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label labell;
        private PictureBox pictureBox2;
        private PictureBox Hide_box;
        private Label metric;
        private Label width;
        private Label length;
        private ComboBox metricbox;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button calculate;
        private Panel panel1;
        private Label result;
        private Label perimeter;
        private Label area;
        private Label perim_ans;
        private Label area_ans;
        private PictureBox pictureBox3;
        private PictureBox backBox;
        private Label per_met;
        private Label met_area;
        private Panel panel2;
        private PictureBox info_box;
    }
}