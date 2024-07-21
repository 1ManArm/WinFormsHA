namespace WinFormsHA
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    textBoxRead.Text = File.ReadAllText(filePath);
                    buttonEdit.Enabled = true;
                }
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            EditForm editForm = new EditForm(this, textBoxRead.Text);
            editForm.Show();
        }
    }
}
