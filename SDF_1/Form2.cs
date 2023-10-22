using SDF_1.Models;
using SDF_1.Properties;
using System.Drawing.Drawing2D;

namespace SDF_1;
public partial class Form2 : Form
{
    public Point startLocation;
    public Form2()
    {
        InitializeComponent();
    }

    private Label? Labell;
    Color randomColor = Color.FromArgb(Random.Shared.Next(256), Random.Shared.Next(256), Random.Shared.Next(256));
    private Models.Rectangle? rectangle;
    private Circle? circle;
    private Square? square;
    public Form2(string selectedShape)
    {
        InitializeComponent();
        labell.Text = selectedShape;
        pictureBox1.Visible = false;
        panel1.Visible = false;
        metricbox.Items.Add("mm");
        metricbox.Items.Add("cm");
        metricbox.Items.Add("dm");
        metricbox.Items.Add("m");
        metricbox.Items.Add("km");
        metricbox.SelectedIndex = 0;
        if (selectedShape == "Circle")
        {
            length.Visible = false;
            width.Text = "Radius";
            textBox2.Visible = false;
            pictureBox1.Image = Resources.Screenshot_2023_10_22_133751;

        }
        else if (selectedShape == "Square")
        {
            length.Visible = false;
            width.Text = "Side";
            textBox2.Visible = false;
            pictureBox1.Size = new Size(200, 200);
            pictureBox1.Image = Resources.Screenshot_2023_10_22_133702;
        }
        calculate.Enabled = false;
        panel2.MouseDown += Panel2_MouseDown;
        panel2.MouseUp += Panel2_MouseUp;
    }

    private bool isPictureVisible = false;
    private void HideBox_Click(object sender, EventArgs e)
    {
        if (isPictureVisible)
        {
            Hide_box.Image = Resources.Aniket_Suvarna_Box_Bxs_hide_48;
            pictureBox1.Visible = false;
        }
        else
        {
            Hide_box.Image = Resources.Ionic_Ionicons_Eye_48;
            pictureBox1.Visible = true;
        }

        isPictureVisible = !isPictureVisible;
    }
    private void backBox_Click(object sender, EventArgs e)
    {
        this.Hide();
        Form1 form1 = new();
        form1.Show();
    }
    private void textBox1_TextChanged(object sender, EventArgs e)
    {
        EnableCalculateButton();
    }

    private void textBox2_TextChanged(object sender, EventArgs e)
    {
        EnableCalculateButton();
    }

    private void EnableCalculateButton()
    {
        if (labell.Text == "Rectangle")
        {
            bool isTextBox1Valid = double.TryParse(textBox1.Text, out _);
            bool isTextBox2Valid = double.TryParse(textBox2.Text, out _);

            calculate.Enabled = isTextBox1Valid && isTextBox2Valid;
        }
        else if (labell.Text == "Circle" || labell.Text == "Square")
        {
            bool isTextBox1Valid = double.TryParse(textBox1.Text, out _);

            calculate.Enabled = isTextBox1Valid;
        }
    }

    private void calculate_Click(object sender, EventArgs e)
    {
        string selectedShape = labell.Text;
        panel1.Visible = true;
        textBox1.Enabled = false;
        textBox2.Enabled = false;
        metricbox.Enabled = false;
        calculate.Enabled = false;
        Hide_box.Enabled = false;
        panel2.Enabled = false;

        string? selectedMetric = metricbox.SelectedItem as string;
        switch (selectedShape)
        {
            case "Rectangle":
                double width, height;
                if (double.TryParse(textBox1.Text, out width) && double.TryParse(textBox2.Text, out height))
                {
                    if (Labell != null)
                    {
                        panel2.Controls.Remove(Labell);
                        Labell.Dispose();
                    }

                    Labell = new Label()
                    {
                        Location = new Point((panel2.Width - (int)width) / 2, (panel2.Height - (int)height) / 2),
                        Size = new Size((int)width, (int)height),
                        BorderStyle = BorderStyle.FixedSingle,
                        BackColor = randomColor,
                    };

                    panel2.Controls.Add(Labell);
                    rectangle = new(randomColor, true, width, height);
                    area_ans.Text = rectangle.GetArea().ToString();
                    met_area.Text = $"{selectedMetric}²";
                    perim_ans.Text = rectangle.GetPerimeter().ToString();
                    per_met.Text = $"{selectedMetric}";
                }
                break;
            case "Circle":
                double radius;
                if (double.TryParse(textBox1.Text, out radius))
                {
                    if (Labell != null)
                    {
                        panel2.Controls.Remove(Labell);
                        Labell.Dispose();
                    }

                    Labell = new Label()
                    {
                        Location = new Point((panel2.Width - (int)(radius * 2)) / 2, (panel2.Height - (int)(radius * 2)) / 2),
                        Size = new Size((int)(radius * 2), (int)(radius * 2)),
                        BorderStyle = BorderStyle.FixedSingle,
                        BackColor = randomColor,
                    };

                    panel2.Controls.Add(Labell);

                    GraphicsPath gp = new();
                    gp.AddEllipse(0, 0, Labell.Width, Labell.Height);

                    Region rg = new(gp);
                    Labell.Region = rg;

                    circle = new(randomColor, true, radius);
                    area_ans.Text = Math.Round(circle.GetArea(), 2).ToString();
                    met_area.Text = $"{selectedMetric}²";
                    perim_ans.Text = Math.Round(circle.GetPerimeter(), 2).ToString();
                    per_met.Text = $"{selectedMetric}";
                }
                break;
            case "Square":
                double side;
                if (double.TryParse(textBox1.Text, out side))
                {
                    if (Labell != null)
                    {
                        panel2.Controls.Remove(Labell);
                        Labell.Dispose();
                    }

                    Labell = new Label()
                    {
                        Location = new Point((panel2.Width - (int)side) / 2, (panel2.Height - (int)side) / 2),
                        Size = new Size((int)side, (int)side),
                        BorderStyle = BorderStyle.FixedSingle,
                        BackColor = randomColor,
                    };
                    panel2.Controls.Add(Labell);
                    square = new(randomColor, true, side);
                    area_ans.Text = square.GetArea().ToString();
                    met_area.Text = $"{selectedMetric}²";
                    perim_ans.Text = square.GetPerimeter().ToString();
                    per_met.Text = $"{selectedMetric}";
                }
                break;
        }
    }

    private void pictureBox3_Click(object sender, EventArgs e)
    {
        panel1.Visible = false;
        textBox1.Enabled = true;
        textBox2.Enabled = true;
        metricbox.Enabled = true;
        calculate.Enabled = true;
        Hide_box.Enabled = true;
        panel2.Enabled = true;
    }

    private void Panel2_MouseDown(object? sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Left)
        {
            if (Labell != null)
            {
                panel2.Controls.Remove(Labell);
                Labell.Dispose();
            }
            startLocation = e.Location;
        }
    }

    private void Panel2_MouseUp(object? sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Left)
        {
            Point endLocation = e.Location;

            int x = Math.Min(startLocation.X, endLocation.X);
            int y = Math.Min(startLocation.Y, endLocation.Y);
            int width = Math.Abs(startLocation.X - endLocation.X);
            int height = Math.Abs(startLocation.Y - endLocation.Y);

            Labell = new Label()
            {
                Location = new Point(x, y),
                Size = new Size(Math.Max(10, width), Math.Max(10, height)),
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = randomColor,
            };

            panel2.Controls.Add(Labell);

            textBox1.Text = width.ToString();
            textBox2.Text = height.ToString();
        }
    }
    private void info_box_Click(object sender, EventArgs e)
    {

        string selectedShape = labell.Text;
        string shapeDetails = "";

        if (selectedShape == "Rectangle")
        {
            if (rectangle != null)
            {
                shapeDetails = rectangle.ToString();
            }
        }
        else if (selectedShape == "Circle")
        {
            if (circle != null)
            {
                shapeDetails = circle.ToString();
            }
        }
        else if (selectedShape == "Square")
        {
            if (square != null)
            {
                shapeDetails = square.ToString();
            }
        }

        if (!string.IsNullOrEmpty(shapeDetails))
        {
            MessageBox.Show(shapeDetails, "Shape Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    protected override void OnFormClosing(FormClosingEventArgs e)
    {
        base.OnFormClosing(e);

        if (e.CloseReason == CloseReason.UserClosing)
            Application.Exit();
    }
}
