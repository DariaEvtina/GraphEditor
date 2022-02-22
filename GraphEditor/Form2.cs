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
        Form1 f = new Form1();
        Color colorResult = Color.Black;
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
            UpdateColor();
        }

        private void GreenBarr_ValueChanged(object sender, EventArgs e)
        {
            ScrollBar scrl = (ScrollBar)sender;
            NumericUpDown nmrUpDown = (NumericUpDown)scrl.Tag;
            nmrUpDown.Value = scrl.Value;
            UpdateColor();
        }

        private void BlueBarr_ValueChanged(object sender, EventArgs e)
        {
            ScrollBar scrl = (ScrollBar)sender;
            NumericUpDown nmrUpDown = (NumericUpDown)scrl.Tag;
            nmrUpDown.Value = scrl.Value;
            UpdateColor();
        }

        private void numericUpDownRed_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown nmrUpDown = (NumericUpDown)sender;
            ScrollBar scrl = (ScrollBar)nmrUpDown.Tag;
            scrl.Value = (int)nmrUpDown.Value;
            UpdateColor();
        }

        private void numericUpDownGreen_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown nmrUpDown = (NumericUpDown)sender;
            ScrollBar scrl = (ScrollBar)nmrUpDown.Tag;
            scrl.Value = (int)nmrUpDown.Value;
            UpdateColor();
        }

        private void numericUpDownBlue_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown nmrUpDown = (NumericUpDown)sender;
            ScrollBar scrl = (ScrollBar)nmrUpDown.Tag;
            scrl.Value = (int)nmrUpDown.Value;
            UpdateColor();
        }
        private void UpdateColor()
        {
            colorResult = Color.FromArgb(RedBarr.Value, GreenBarr.Value, BlueBarr.Value);
            Color_Pic.BackColor = colorResult;
        }

        private void OtherColors_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                RedBarr.Value = colorDialog.Color.R;
                GreenBarr.Value = colorDialog.Color.G; 
                BlueBarr.Value = colorDialog.Color.B;
                colorResult = colorDialog.Color;
                UpdateColor();
            }
        }
        public Color Data
        {
            get
            {
                return colorResult;
            }
        }

        private void Ok_btn_Click(object sender, EventArgs e)
        {

            f.currentPen.Color = colorResult;
            this.Hide();
        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
