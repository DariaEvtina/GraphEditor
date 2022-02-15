using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphEditor
{
    public partial class Form2 : Form
    {
        public Form2(Color color)
        {
            InitializeComponent();
            RedBarr.Tag = numericUpDownRed;
            GreenBarr.Tag = numericUpDownGreen;
            BlueBarr.Tag = numericUpDownBlue;

            numericUpDownRed.Tag = RedBarr;
            numericUpDownGreen.Tag = GreenBarr;
            numericUpDownBlue.Tag = BlueBarr;

            numericUpDownRed.Value = color.R;
            numericUpDownGreen.Value = color.G;
            numericUpDownBlue.Value = color.B;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void RedBarr_ValueChanged(object sender, EventArgs e)
        {
            ScrollBar scrl = (ScrollBar)sender;
            NumericUpDown nmrUpDown = (NumericUpDown)scrl.Tag;
            nmrUpDown.Value = scrl.Value;
        }

        private void GreenBarr_ValueChanged(object sender, EventArgs e)
        {
            ScrollBar scrl = (ScrollBar)sender;
            NumericUpDown nmrUpDown = (NumericUpDown)scrl.Tag;
            nmrUpDown.Value = scrl.Value;
        }

        private void BlueBarr_ValueChanged(object sender, EventArgs e)
        {
            ScrollBar scrl = (ScrollBar)sender;
            NumericUpDown nmrUpDown = (NumericUpDown)scrl.Tag;
            nmrUpDown.Value = scrl.Value;
        }
    }
}
