using System;
using System.Windows.Forms;
using MP3Player.Presenters;

namespace MP3Player
{
    public partial class NewNamePLForm : Form
    {
        private readonly Presenter _presenter;

        public NewNamePLForm(Presenter presenter)
        {
            _presenter = presenter;
            InitializeComponent();
        }

        private string NamePL => textBox.Text;

        private void okButton_Click(object sender, EventArgs e)
        {
            _presenter.NameOfNewPL = NamePL;
            Dispose(true);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Dispose(true);
        }
    }
}