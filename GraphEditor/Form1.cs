using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphEditor
{
    public partial class Form1 : Form
    {
        public Color color = Color.Black;
        public Color Backcolor=Color.White;
        bool drawing;
        int historyCounter;
        GraphicsPath currentPath;
        Point oldLocation;
        public Pen currentPen;
        List<Image> History;
        Form2 f;
        EditCanvas edit;
        public Form1()
        {
            Program.f1 = this; // теперь f1 будет ссылкой на форму Form1
            InitializeComponent();
            drawing = false;
            currentPen = new Pen(color);
            History = new List<Image>();
        }
        /*public Form1(Size size, Color pic,Color pen)
        {
            InitializeComponent();
            drawing = false;
            currentPen = new Pen(pen);
            color = pen;
            History = new List<Image>();
            picDrawingSurface.BackColor = pic;
            picDrawingSurface.Size = size;
            Backcolor = pic;
            //picDrawingSurface.Location = location;
        }*/
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (picDrawingSurface.Image == null)
            {
                History.Clear();
                historyCounter = 0;
                Bitmap pic = new Bitmap(737, 430);
                picDrawingSurface.Image = pic;
                History.Add(new Bitmap(picDrawingSurface.Image));
                Graphics g = Graphics.FromImage(picDrawingSurface.Image);
                g.Clear(Backcolor);
                g.DrawImage(picDrawingSurface.Image, 0, 0, 737, 430);
            }
            if (picDrawingSurface.Image != null)
            {
                var result = MessageBox.Show("Do you want to save an image after create a new file?", "Warning", MessageBoxButtons.YesNoCancel);
                switch (result)
                {
                    case DialogResult.No: break;
                    case DialogResult.Yes: saveToolStripMenuItem_Click(sender, e); break;
                    case DialogResult.Cancel: return;
                }
            }
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog SaveDlg = new SaveFileDialog();
            SaveDlg.Filter = "JPEG Image|*.jpg|Bitmap Image|*.bmp|GIF Image|*.gif|PNG Image|*.png";
            SaveDlg.Title = "Save an image file";
            SaveDlg.FilterIndex = 4;
            SaveDlg.ShowDialog();
            if (SaveDlg.FileName != "")
            {
                System.IO.FileStream fs = (System.IO.FileStream)SaveDlg.OpenFile();
                switch (SaveDlg.FilterIndex)
                {
                    case 1:
                        this.picDrawingSurface.Image.Save(fs, ImageFormat.Jpeg);
                        break;
                    case 2:
                        this.picDrawingSurface.Image.Save(fs, ImageFormat.Bmp);
                        break;
                    case 3:
                        this.picDrawingSurface.Image.Save(fs, ImageFormat.Gif);
                        break;
                    case 4:
                        this.picDrawingSurface.Image.Save(fs, ImageFormat.Png);
                        break;
                }
                fs.Close();
            }
        }
        

        private void picDrawingSurface_MouseDown(object sender, MouseEventArgs e)
        {
            if (picDrawingSurface.Image == null)
            {
                MessageBox.Show("Create a new file first!");
                return;
            }
            if (e.Button==MouseButtons.Left)
            {
                drawing = true;
                oldLocation = e.Location;
                currentPath = new GraphicsPath();
                currentPen.Color = color;
            }
            else if (e.Button == MouseButtons.Right)
            {
                drawing = true;
                oldLocation = e.Location;
                currentPath = new GraphicsPath();
                currentPen.Color = Backcolor;
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog OP = new OpenFileDialog();
            OP.Filter = "JPEG Image|*.jpg|Bitmap Image|*.bmp|GIF Image|*.gif|PNG Image|*.png";
            OP.Title = "Open an image file";
            OP.FilterIndex = 4;
            if (OP.ShowDialog() != DialogResult.Cancel)
            {
                picDrawingSurface.Load(OP.FileName);
                picDrawingSurface.AutoSize = true;
                History.Clear();
                historyCounter = 0;
                History.Add(new Bitmap(picDrawingSurface.Image));
            }
            
        }

        private void toolStripbtn1_Click(object sender, EventArgs e)
        {
            newToolStripMenuItem_Click(sender, e);
        }

        private void toolStripbtn2_Click(object sender, EventArgs e)
        {
            openToolStripMenuItem_Click(sender, e);
        }

        private void toolStripbtn3_Click(object sender, EventArgs e)
        {
            saveToolStripMenuItem_Click(sender, e);
        }

        private void picDrawingSurface_MouseUp(object sender, MouseEventArgs e)
        {
            History.RemoveRange(historyCounter + 1, History.Count - historyCounter - 1);
            History.Add(new Bitmap(picDrawingSurface.Image));
            if (historyCounter+1<10){ historyCounter++; }
            if (History.Count - 1==10) { History.RemoveAt(0); }
            drawing = false;
            try
            {
                currentPath.Dispose();
            }
            catch { };
        }

        private void picDrawingSurface_MouseMove(object sender, MouseEventArgs e)
        {
            labe_XY.Text = e.X.ToString() + " ; " + e.Y.ToString();
            if (drawing)
            {
                Graphics g = Graphics.FromImage(picDrawingSurface.Image);
                currentPath.AddLine(oldLocation, e.Location);
                g.DrawPath(currentPen, currentPath);
                oldLocation = e.Location;
                g.Dispose();
                picDrawingSurface.Invalidate();
            }
        }

        private void trackBar_Scroll(object sender, EventArgs e)
        {
            currentPen.Width = trackBar.Value;
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (History.Count != 0 && historyCounter != 0)
            {
                picDrawingSurface.Image = new Bitmap(History[--historyCounter]);
            }
            else{ MessageBox.Show("History is empty"); }
        }

        private void renoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (historyCounter<History.Count-1)
            {
                picDrawingSurface.Image = new Bitmap(History[++historyCounter]);
            }
            else { MessageBox.Show("History is empty"); }
        }

        private void solidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentPen.DashStyle = DashStyle.Solid;
            solidToolStripMenuItem.Checked = true;
            dotToolStripMenuItem.Checked = false;
            dashdotdotToolStripMenuItem.Checked = false;
        }

        private void dotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentPen.DashStyle = DashStyle.Dot;
            solidToolStripMenuItem.Checked = false;
            dotToolStripMenuItem.Checked = true;
            dashdotdotToolStripMenuItem.Checked = false;
        }
        public PictureBox Data
        {
            get
            {
                return picDrawingSurface;
            }
        }
        private void dashdotdotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentPen.DashStyle = DashStyle.DashDotDot;
            solidToolStripMenuItem.Checked = false;
            dotToolStripMenuItem.Checked = false;
            dashdotdotToolStripMenuItem.Checked = true;
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f = new Form2(currentPen.Color);
            f.ShowDialog();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripbtn5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripbtn4_Click(object sender, EventArgs e)
        {
            edit = new EditCanvas(Color.White);
            edit.Show();
        }
    }
}
