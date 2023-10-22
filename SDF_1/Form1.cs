namespace SDF_1;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        shapeBox.Items.Add("Circle");
        shapeBox.Items.Add("Rectangle");
        shapeBox.Items.Add("Square");
        shapeBox.SelectedIndex = 0;
    }

    private void shapeBox_KeyUp(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            this.Hide();
            string? selectedShape = shapeBox.SelectedItem as string;
            Form2 form2 = new(selectedShape);
            form2.Show();
        }
    }
    protected override void OnFormClosing(FormClosingEventArgs e)
    {
        base.OnFormClosing(e);

        if (e.CloseReason == CloseReason.UserClosing)
            Application.Exit();
    }
}