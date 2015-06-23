using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExtensionGrabber {
    public partial class MainForm : Form {
        EG eg;

        public MainForm() {
            InitializeComponent();
            eg = new EG();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void butSource_Click(object sender, EventArgs e) {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowDialog();
            if (fbd.SelectedPath == string.Empty)
                return;
            else
                txtSource.Text = fbd.SelectedPath;
            eg.SourceDirectory = txtSource.Text;
        }

        private void butDest_Click(object sender, EventArgs e) {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowDialog();
            if (fbd.SelectedPath == string.Empty)
                return;
            else
                txtDest.Text = fbd.SelectedPath;
            eg.DestinationDirectory = txtDest.Text;
        }
        bool validate() {
            return txtSource.Text.Length > 0 && txtDest.Text.Length > 0 && txtExt.Text.Length > 0;
        }
        private void txtExt_TextChanged(object sender, EventArgs e) {
            butGo.Enabled = validate();
        }

        private void txtExt_Leave(object sender, EventArgs e) {
            txtExt.Text = txtExt.Text.ToUpper();
        }

        private void butGo_Click(object sender, EventArgs e) {
            eg.Extension = txtExt.Text;
            //MessageBox.Show(eg.NumberOfFiles().Length.ToString());
            eg.Copy(chkAutoOW.Checked);
            Application.Exit();
        }

        private void txtDest_TextChanged(object sender, EventArgs e) {
            butGo.Enabled = validate();
        }

        private void txtSource_TextChanged(object sender, EventArgs e) {
            butGo.Enabled = validate();
        }

    }
}
