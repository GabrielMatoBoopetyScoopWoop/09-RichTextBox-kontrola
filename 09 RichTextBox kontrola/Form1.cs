using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09_RichTextBox_kontrola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SpremiButton_Click(object sender, EventArgs e)
        {
            RichBox.SaveFile(@"C:Tempproba.rtf");

            MessageBox.Show("Tekst spremljen");
        }

        private void CitajButton_Click(object sender, EventArgs e)
        {
            RichBox.LoadFile(@"C:Tempproba.rtf");
        }

        private void BrisiButton_Click(object sender, EventArgs e)
        {
            RichBox.Clear();
        }
    }
}
