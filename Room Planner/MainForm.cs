using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Room_Planner
{
    public partial class MainForm : Form
    {
        private Bitmap bitmap;
        private Button selectedBtn;
        public MainForm()
        {
            InitializeComponent();
            this.MinimumSize = new Size(400, 300);
        }

        private void newBluToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F2}");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (selectedBtn != null)
                selectedBtn.BackColor = Color.White;
            selectedBtn = button1;
            selectedBtn.BackColor = Color.Yellow;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (selectedBtn != null)
                selectedBtn.BackColor = Color.White;
            selectedBtn = button2;
            selectedBtn.BackColor = Color.Yellow;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (selectedBtn != null)
                selectedBtn.BackColor = Color.White;
            selectedBtn = button3;
            selectedBtn.BackColor = Color.Yellow;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (selectedBtn != null)
                selectedBtn.BackColor = Color.White;
            selectedBtn = button4;
            selectedBtn.BackColor = Color.Yellow;
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (bitmap != null && selectedBtn != null)
            {
                using (Graphics graphics = Graphics.FromImage(bitmap))
                {
                    Bitmap graph = new Bitmap(selectedBtn.Image);
                    graphics.DrawImage(graph, e.Location.X - selectedBtn.Image.Width/2,
                        e.Location.Y - selectedBtn.Image.Height/2);
                    pictureBox.Refresh();
                    string name = selectedBtn.Name.ToString();
                    string position = "{X="+e.Location.X.ToString().Trim() + ", Y=" + e.Location.Y.ToString().Trim()+"}";
                    ListViewItem newItem = new ListViewItem(new[] { name, position });
                    listFurniture.Items.Add(newItem);
                    selectedBtn = null;
                }
            }
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
                pictureBox.Image = bitmap;
                this.DoubleBuffered = true;
                Graphics graphics = Graphics.FromImage(bitmap);
                int white = 11;
                graphics.FillRectangle(Brushes.White, 0, white, pictureBox.Width, pictureBox.Height);
                pictureBox.Image = bitmap;
            }
        }
    }
}
