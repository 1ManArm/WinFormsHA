using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsHA
{
    public partial class EditForm : Form
    {
        public EditForm(MainForm mainForm, string text)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            textBoxEdit.Text = text;
        }
        private MainForm mainForm;

        private void EditForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (mainForm != null)
            {
                mainForm.textBoxRead.Text = textBoxEdit.Text;
            }
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
