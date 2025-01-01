namespace Russian_Alphabet
{
    public partial class RussianAlphabetTrainer : Form
    {
        public RussianAlphabetTrainer()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ToggleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox toggle = sender as CheckBox;
            if (toggle.Checked)
            {
                toggle.Text = "Uppercase";
            }
            else
            {
                toggle.Text = "Lowercase";
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (!(ToggleCheck.Text == "Click me!"))
            {
                if (ToggleCheck.Checked)
                {
                    Uppercase newWindow = new Uppercase();
                    newWindow.ShowDialog();
                }
                else if (!ToggleCheck.Checked)
                {
                    Lowercase newWindow = new Lowercase();
                    newWindow.ShowDialog();
                }
            }
        }
    }
}
