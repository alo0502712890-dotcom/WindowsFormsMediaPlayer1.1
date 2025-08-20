using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsMediaPlayer
{
    public partial class CreateUodatePlayListForm : Form
    {
        private string _playlistName;
        public string PlayListName
        {
            get => _playlistName;
            private set => _playlistName = value;
        }

        public CreateUodatePlayListForm()
        {
            InitializeComponent();
        }

        public CreateUodatePlayListForm(string name) : this()
        {
            textBox_PlayListName.Text = name;
        }

        private void button_Censel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void button_Confirm_Click(object sender, EventArgs e)
        {
            if (textBox_PlayListName.Text.Length >= 3)
            {
                PlayListName = textBox_PlayListName.Text.Trim();
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                //toolStripStatusLabel_Info.BackColor = Color.Red;
                //toolStripStatusLabel_Info.Text = "Enter Please playlist name";
            }
        }
    }
}