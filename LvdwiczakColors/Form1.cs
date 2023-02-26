namespace LvdwiczakColors
{
    public partial class Colors : Form
    {
        public Colors()
        {
            InitializeComponent();
        }

        private void BlueValue_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            redTrackBar.Value = 128;
            greenTrackBar.Value = 128;
            blueTrackBar.Value = 128;

            redValue.Text = redTrackBar.Value.ToString();
            greenValue.Text = greenTrackBar.Value.ToString();
            blueValue.Text = blueTrackBar.Value.ToString();

            colorPanel.BackColor = Color.FromArgb(redTrackBar.Value, greenTrackBar.Value, blueTrackBar.Value);
        }

        private void RedTrackBar_Scroll(object sender, EventArgs e)
        {
            colorPanel.BackColor = Color.FromArgb(redTrackBar.Value, greenTrackBar.Value, blueTrackBar.Value);
            redValue.Text = redTrackBar.Value.ToString();

        }

        private void GreenTrackBar_Scroll(object sender, EventArgs e)
        {
            colorPanel.BackColor = Color.FromArgb(redTrackBar.Value, greenTrackBar.Value, blueTrackBar.Value);
            greenValue.Text = greenTrackBar.Value.ToString();

        }

        private void BlueTrackBar_Scroll(object sender, EventArgs e)
        {
            colorPanel.BackColor = Color.FromArgb(redTrackBar.Value, greenTrackBar.Value, blueTrackBar.Value);
            blueValue.Text = blueTrackBar.Value.ToString();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}