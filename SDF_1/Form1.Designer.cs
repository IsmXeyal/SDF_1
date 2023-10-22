namespace SDF_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            shapes = new Label();
            shapeBox = new ComboBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.shapes4;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(784, 562);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // shapes
            // 
            shapes.BackColor = Color.Indigo;
            shapes.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            shapes.ForeColor = Color.Ivory;
            shapes.Location = new Point(343, 190);
            shapes.Name = "shapes";
            shapes.Size = new Size(116, 42);
            shapes.TabIndex = 1;
            shapes.Text = "Shapes";
            shapes.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // shapeBox
            // 
            shapeBox.DropDownStyle = ComboBoxStyle.DropDownList;
            shapeBox.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            shapeBox.FormattingEnabled = true;
            shapeBox.ItemHeight = 18;
            shapeBox.Location = new Point(407, 279);
            shapeBox.Name = "shapeBox";
            shapeBox.Size = new Size(116, 26);
            shapeBox.TabIndex = 2;
            shapeBox.KeyUp += shapeBox_KeyUp;
            // 
            // label1
            // 
            label1.BackColor = Color.Purple;
            label1.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Ivory;
            label1.Location = new Point(274, 279);
            label1.Name = "label1";
            label1.Size = new Size(116, 26);
            label1.TabIndex = 3;
            label1.Text = "Figures";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(label1);
            Controls.Add(shapeBox);
            Controls.Add(shapes);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Shape";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label shapes;
        private ComboBox shapeBox;
        private Label label1;
    }
}