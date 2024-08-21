namespace Basic_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnChangeText_Click(object sender, EventArgs e)
        {
            lblTitle.Text = tbInput.Text;
        }
    }
}
