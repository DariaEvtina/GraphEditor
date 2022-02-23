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
    public partial class EditCanvas : Form
    {
        int x;
        int y;
        Color colorResult;
        public EditCanvas(Color color)
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
        private void UpdateColor()
        {
            colorResult = Color.FromArgb(RedBarr.Value, GreenBarr.Value, BlueBarr.Value);
            Color_Pic.BackColor = colorResult;
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            x = 300;
            y = 300;
            pictureBox1.Size = new Size(x / 4, y / 4);
            //pictureBox1.Location=
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
            this.Hide();
            //Program.f1.picDrawingSurface.BackColor = colorResult;
            //Program.f1.EpicDrawingSurface.Size = new Size(x,y);
            //Program.f1.Backcolor= colorResult;
        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void w_ValueChanged(object sender, EventArgs e)
        {
            pictureBox1.Width = Convert.ToInt32(w.Value/4);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            x = 600;
            y = 400;
            pictureBox1.Size = new Size(x / 4, y / 4);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            x = 450;
            y = 200;
            pictureBox1.Size = new Size(x / 4, y / 4);
        }

        private void Color_Pic_Click(object sender, EventArgs e)
        {

        }

        private void h_ValueChanged(object sender, EventArgs e)
        {
            pictureBox1.Height = Convert.ToInt32(h.Value/4);
        }

        private void EditCanvas_Load(object sender, EventArgs e)
        {

        }
    }
}
