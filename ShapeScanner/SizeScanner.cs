using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShapeScanner
{
    public partial class SizeScanner : Form
    {
        public SizeScanner()
        {
            InitializeComponent();
        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            switch(fdSelectImage.ShowDialog())
            {
                case DialogResult.OK:
                    try
                    {
                        pbScannedImage.Load(fdSelectImage.FileName);
                    }
                    catch (ArgumentException)
                    {
                        MessageBox.Show("The specified image file is invalid.");
                    }
                    catch (FileNotFoundException)
                    {
                        MessageBox.Show("The path to image is invalid.");
                    }
                    btnAnalyze.Enabled = true;
                    break;
                case DialogResult.Cancel:
                    break;
                default:
                    break;
            }
            if (pbScannedImage.Image != null)
            {
                btnAnalyze.Enabled = true;
            }
            else
            {
                btnAnalyze.Enabled = false;
            }
        }

        private void btnAnalyze_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnSelectImage_Click(sender, e);
        }
    }
}
