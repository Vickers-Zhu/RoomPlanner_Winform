using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using System.Globalization;
using System.Threading;
using System.Resources;

namespace Room_Planner
{
    public partial class MainForm : Form
    {
        private static Bitmap bitmap;
        private static Button selectedBtn;
        private static int widthMap;
        private static int heightMap;
        private static List<Furniture> furnitures;
        private static int Count;
        private static bool oneSelected;
        private static bool dragFlag;
        private static Point mouseOffset;
        public string language = Properties.Settings.Default.Language;


        public MainForm()
        {
            Console.WriteLine(Thread.CurrentThread.CurrentUICulture.ToString());

            InitializeComponent();
            this.MinimumSize = new Size(400, 300);
            furnitures = new List<Furniture>();
            oneSelected = false;
            dragFlag = false;
            mouseOffset = new Point();
            Count = 0;
            this.MouseWheel += new MouseEventHandler(rotate_MouseWheel);
        }

        private void newBluToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F2}");
        }

        private void buttonCoffee_Click(object sender, EventArgs e)
        {
            if (selectedBtn != null)
                selectedBtn.BackColor = Color.White;
            if (selectedBtn == buttonCoffee)
            {
                selectedBtn.BackColor = Color.White;
                selectedBtn = null;
                return;
            }
            selectedBtn = buttonCoffee;
            selectedBtn.BackColor = Color.Yellow;
        }

        private void buttonTable_Click(object sender, EventArgs e)
        {
            if (selectedBtn != null)
                selectedBtn.BackColor = Color.White;
            if (selectedBtn == buttonTable)
            {
                selectedBtn.BackColor = Color.White;
                selectedBtn = null;
                return;
            }
            selectedBtn = buttonTable;
            selectedBtn.BackColor = Color.Yellow;
        }

        private void buttonSofa_Click(object sender, EventArgs e)
        {
            if (selectedBtn != null)
                selectedBtn.BackColor = Color.White;
            if (selectedBtn == buttonSofa)
            {
                selectedBtn.BackColor = Color.White;
                selectedBtn = null;
                return;
            }
            selectedBtn = buttonSofa;
            selectedBtn.BackColor = Color.Yellow;

        }

        private void buttonBed_Click(object sender, EventArgs e)
        {
            if (selectedBtn != null)
                selectedBtn.BackColor = Color.White;
            if (selectedBtn == buttonBed)
            {
                selectedBtn.BackColor = Color.White;
                selectedBtn = null;
                return;
            }
            selectedBtn = buttonBed;
            selectedBtn.BackColor = Color.Yellow;
        }

        private void buttonWalls_Click(object sender, EventArgs e)
        {
            if (selectedBtn != null)
            {
                selectedBtn.BackColor = Color.White;
                Count = 0;
            }
            if (selectedBtn == buttonWalls)
            {
                selectedBtn.BackColor = Color.White;
                selectedBtn = null;
                Count = 0;
                return;
            }
            selectedBtn = buttonWalls;
            selectedBtn.BackColor = Color.Yellow;
        }

        private void pictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (bitmap != null && selectedBtn != null)
            {
                //Size the map
                int newWidth = e.Location.X + selectedBtn.BackgroundImage.Width / 2;
                int newHeight = e.Location.Y + selectedBtn.BackgroundImage.Height / 2;
                widthMap = newWidth > widthMap ? newWidth : widthMap;
                heightMap = newHeight > heightMap ? newHeight : heightMap;
                if (widthMap > pictureBox.Width || heightMap > pictureBox.Height)
                    SizeMap(widthMap, heightMap);

                //Draw the furnitures
                string name = selectedBtn.Name.ToString().Substring(6);

                if (selectedBtn != buttonWalls)
                {
                    Count = 0;
                    Point point = new Point
                    (
                         e.Location.X - selectedBtn.BackgroundImage.Width / 2,
                         e.Location.Y - selectedBtn.BackgroundImage.Height / 2
                    );
                    furnitures.Add(new Furniture(selectedBtn.BackgroundImage,
                        new List<Point> { point }, name));

                    DrawFurnitures();

                    string position = "{X=" + e.Location.X + ", Y=" + e.Location.Y + "}";
                    ListViewItem newItem = new ListViewItem(new[] { name, position });
                    listFurniture.Items.Add(newItem);
                    selectedBtn.BackColor = Color.White;
                    selectedBtn = null;
                }
                else if (selectedBtn == buttonWalls && e.Button != MouseButtons.Right)
                {
                    Point point = new Point
                    (
                        e.Location.X,
                        e.Location.Y
                    );
                    Count++;
                    //DO only once
                    if (Count == 1)
                    {
                        furnitures.Add(new Furniture(selectedBtn.BackgroundImage,
                            new List<Point> { point }, name));
                        string position = "{X=" + point.X + ", Y=" + point.Y + "}";
                        ListViewItem newItem = new ListViewItem(new[] { name, position });
                        listFurniture.Items.Add(newItem);
                    }
                    furnitures.Last().Points.Add(point);
                    DrawFurnitures();
                }
                else if (selectedBtn == buttonWalls && e.Button == MouseButtons.Right)
                {
                    selectedBtn.BackColor = Color.White;
                    selectedBtn = null;
                    Count = 0;
                }
            }
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                furnitures = new List<Furniture>();
                selectedBtn = null;
                listFurniture.Items.Clear();
                listFurniture.Refresh();

                widthMap = flowLayoutPanelLeft.Width - 15;
                heightMap = flowLayoutPanelLeft.Height - 15;
                bitmap = new Bitmap(flowLayoutPanelLeft.Width - 15, flowLayoutPanelLeft.Height - 15);
                pictureBox.Image = bitmap;
                this.DoubleBuffered = true;
                Graphics graphics = Graphics.FromImage(bitmap);
                int white = 11;
                graphics.FillRectangle(Brushes.White, 0, white,
                    flowLayoutPanelLeft.Width - 15, flowLayoutPanelLeft.Height - 15);
                pictureBox.Image = bitmap;
            }
            if (e.KeyCode == Keys.Delete)
            {
                for (int i = 0; i < furnitures.Count; i++)
                {
                    if (furnitures[i].isSelected)
                    {
                        furnitures.RemoveAt(i);
                        listFurniture.Items.RemoveAt(i);
                        oneSelected = false;
                        DrawFurnitures();
                        listFurniture.Refresh();
                        break;
                    }
                }
            }
        }

        private void SizeMap(int width, int height)
        {
            Bitmap oldMap = (Bitmap)bitmap.Clone();
            bitmap = new Bitmap(width, height);
            pictureBox.Image = bitmap;
            Graphics graphics = Graphics.FromImage(bitmap);
            int white = 11;
            graphics.FillRectangle(Brushes.White, 0, white, width, height);
            graphics.DrawImage(oldMap, 0, 0);
            pictureBox.Refresh();
        }

        private void DrawFurnitures()
        {
            bitmap = new Bitmap(widthMap, heightMap);
            pictureBox.Image = bitmap;
            int white = 11;
            Pen pen = new Pen(Color.Black, 8);
            Pen selectPen = new Pen(Color.FromArgb(128, 0, 0, 0), 8);
            pen.DashCap = System.Drawing.Drawing2D.DashCap.Round;
            selectPen.DashCap = System.Drawing.Drawing2D.DashCap.Round;

            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                graphics.FillRectangle(Brushes.White, 0, white, widthMap, heightMap);
                graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
                foreach (Furniture furniture in furnitures)
                {
                    if (furniture.Image != buttonWalls.BackgroundImage)
                    {
                        Bitmap graph = RotateImage(furniture.Image, furniture.Angle);
                        if (furniture.isSelected)
                        {
                            graphics.DrawImage(SetSemi(graph, 128), furniture.Points.First());
                        }
                        else
                            graphics.DrawImage(SetSemi(graph, 255), furniture.Points.First());
                        pictureBox.Refresh();
                    }
                    if (furniture.Image == buttonWalls.BackgroundImage)
                    {
                        Point minPoint = new Point(furniture.Points.First().X, furniture.Points.First().Y);
                        Point maxPoint = new Point(furniture.Points.First().Y, furniture.Points.First().Y);
                        foreach (Point point in furniture.Points)
                        {
                            if (point.X < minPoint.X)
                                minPoint.X = point.X;
                            if (point.X > maxPoint.X)
                                maxPoint.X = point.X;
                            if (point.Y < minPoint.Y)
                                minPoint.Y = point.Y;
                            if (point.Y > maxPoint.Y)
                                maxPoint.Y = point.Y;
                        }
                        Point midPoint = new Point((minPoint.X + maxPoint.X)/2, 
                            (minPoint.Y + maxPoint.Y)/2);
                        Point oldPoint = new Point();
                        double angle = Math.PI * furniture.Angle / 180;
                        foreach (Point point in furniture.Points)
                        {
                            Point newPoint = new Point((int)((point.X - midPoint.X) * Math.Cos(angle) -
                                    (point.Y - midPoint.Y) * Math.Sin(angle) + midPoint.X),
                                    (int)((point.X - midPoint.X) * Math.Sin(angle) + 
                                    (point.Y - midPoint.Y) * Math.Cos(angle) + midPoint.Y));
                            graphics.FillEllipse(Brushes.Black,
                            newPoint.X - 3, newPoint.Y - 3, 5, 5);
                            if (!oldPoint.IsEmpty)
                            {
                                if (furniture.isSelected)
                                    graphics.DrawLine(selectPen, oldPoint, newPoint);
                                else
                                    graphics.DrawLine(pen, oldPoint, newPoint);
                            }
                            oldPoint = newPoint;
                        }
                        pictureBox.Refresh();
                    }
                }
            }
        }

        Bitmap SetSemi(Bitmap image, int Alpha)
        {
            Bitmap newImage = new Bitmap(image.Width, image.Height);

            for (int i = 0; i < image.Width; i++)
            {
                for (int j = 0; j < image.Height; j++)
                {

                    Color c = image.GetPixel(i, j);
                    if (c.A != 0)
                        newImage.SetPixel(i, j, Color.FromArgb(Alpha, c.R, c.G, c.B));
                }
            }
            return newImage;
        }

        private void flowLayoutPanelLeft_SizeChanged(object sender, EventArgs e)
        {
            if (bitmap != null)
            {
                if (widthMap >= flowLayoutPanelLeft.Width - 15 && heightMap >= flowLayoutPanelLeft.Height - 15) return;
                widthMap = flowLayoutPanelLeft.Width - 15 > widthMap ? flowLayoutPanelLeft.Width - 15 : widthMap;
                heightMap = flowLayoutPanelLeft.Height - 15 > heightMap ? flowLayoutPanelLeft.Height - 15 : heightMap;
                SizeMap(widthMap, heightMap);
            }
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (bitmap != null && selectedBtn == null && furnitures.Count > 0)
            {
                foreach (Furniture furniture in furnitures)
                {
                    if (furniture.Image != buttonWalls.BackgroundImage)
                    {
                        if (e.Location.X <= furniture.Points.First().X + 2 * (furniture.Image.Width / 2) &&
                            e.Location.X >= furniture.Points.First().X &&
                            e.Location.Y <= furniture.Points.First().Y + 2 * (furniture.Image.Height / 2) &&
                            e.Location.Y >= furniture.Points.First().Y)
                        {
                            if (furniture.isSelected == true)
                            {
                                furniture.isSelected = false;
                                oneSelected = false;
                            }
                            else
                            {
                                if (!oneSelected)
                                {
                                    furniture.isSelected = true;
                                    dragFlag = true;
                                    mouseOffset = new Point(e.Location.X, e.Location.Y);
                                    oneSelected = true;
                                    break;
                                }
                            }
                        }
                    }
                    if (furniture.Image == buttonWalls.BackgroundImage)
                    {
                        Point minPoint = new Point(furniture.Points.First().X, furniture.Points.First().Y);
                        Point maxPoint = new Point(furniture.Points.First().X, furniture.Points.First().Y);
                        foreach (Point point in furniture.Points)
                        {
                            if (point.X < minPoint.X)
                                minPoint.X = point.X;
                            if (point.X > maxPoint.X)
                                maxPoint.X = point.X;
                            if (point.Y < minPoint.Y)
                                minPoint.Y = point.Y;
                            if (point.Y > maxPoint.Y)
                                maxPoint.Y = point.Y;
                        }
                        if (e.Location.X <= maxPoint.X && e.Location.X >= minPoint.X &&
                            e.Location.Y <= maxPoint.Y && e.Location.Y >= minPoint.Y)
                        {
                            if (furniture.isSelected == true)
                            {
                                furniture.isSelected = false;
                                oneSelected = false;
                            }
                            else
                            {
                                if (!oneSelected)
                                {
                                    furniture.isSelected = true;
                                    dragFlag = true;
                                    mouseOffset = new Point(e.Location.X, e.Location.Y);
                                    oneSelected = true;
                                    break;
                                }
                            }
                        }
                    }
                }
                DrawFurnitures();
            }
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragFlag)
            {
                Point mouseSet = e.Location;
                mouseSet.Offset(-mouseOffset.X, -mouseOffset.Y);
                foreach (Furniture furniture in furnitures)
                {
                    if (furniture.isSelected)
                    {
                        for (int i = 0; i < furniture.Points.Count; i++)
                        {

                            furniture.Points[i] = new Point(furniture.Points[i].X + mouseSet.X,
                                furniture.Points[i].Y + mouseSet.Y);
                        }
                        string position = "{X=" + (furniture.Points[0].X + mouseSet.X) + ", Y=" +
                            (furniture.Points[0].Y + mouseSet.Y) + "}";
                        listFurniture.Items[furnitures.IndexOf(furniture)] =
                        new ListViewItem(new[] { furniture.Name, position });
                        listFurniture.Refresh();
                        break;
                    }
                }
                DrawFurnitures();
                mouseOffset = e.Location;
            }
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (dragFlag)
            {
                dragFlag = false;
                mouseOffset = new Point();
                DrawFurnitures();
            }
        }

        public static Bitmap RotateImage(Image image, float angle)
        {
            if (image == null)
                throw new ArgumentNullException("image");
            float dx = image.Width / 2.0f;
            float dy = image.Height / 2.0f;

            int resolu = (int)Math.Sqrt(image.Width * image.Width + image.Height * image.Height);

            Bitmap rotatedBmp = new Bitmap(resolu, resolu);
            rotatedBmp.SetResolution(image.HorizontalResolution, image.VerticalResolution);
            Graphics g = Graphics.FromImage(rotatedBmp);
            g.TranslateTransform(dx, dy);
            g.RotateTransform(angle);
            g.TranslateTransform(-dx, -dy);
            g.DrawImage(image, new PointF(0, 0));
            return rotatedBmp;
        }

        private void rotate_MouseWheel(object sender, MouseEventArgs e)
        {
            if (oneSelected)
            {
                const float angle = 15f / 120;
                foreach (Furniture furniture in furnitures)
                {
                    if (furniture.isSelected)
                    {
                        furniture.Angle += (int)(angle * e.Delta);
                        if (furniture.Angle >= 359) furniture.Angle = 0;
                        if (furniture.Angle < 0) furniture.Angle = 345;
                        break;
                    }
                }
                DrawFurnitures();
                return;
            }
            else
            {
                HandledMouseEventArgs h = e as HandledMouseEventArgs;
                if (h != null)
                {
                    h.Handled = true;
                }
            }

        }
        void cancel_MouseWheel(object sender, MouseEventArgs e)
        {
            HandledMouseEventArgs h = e as HandledMouseEventArgs;
            if (h != null)
            {
                h.Handled = true;
            }
        }

        private void openBluprintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SendKeys.SendWait("{F2}");
            string localFilePath = "";
            OpenFileDialog ofd = new OpenFileDialog();
            JsonSerializer serializer = new JsonSerializer();
            ofd.Filter = "bpp files (*.bpp)|*.bpp";
            ofd.FilterIndex = 1;
            ofd.RestoreDirectory = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                localFilePath = ofd.FileName.ToString();
                using (Stream s = File.Open(ofd.FileName, FileMode.Open))
                using (StreamReader sr = new StreamReader(s))
                {
                    string line = "";
                    oneSelected = Boolean.Parse(sr.ReadLine());
                    Console.WriteLine(oneSelected);
                    while (!sr.EndOfStream)
                    {
                        line = sr.ReadLine();
                        Furniture furniture = JsonConvert.DeserializeObject<Furniture>(line);
                        if (furniture.Name == "Coffee") furniture.Image = buttonCoffee.BackgroundImage;
                        if (furniture.Name == "Table") furniture.Image = buttonTable.BackgroundImage;
                        if (furniture.Name == "Sofa") furniture.Image = buttonSofa.BackgroundImage;
                        if (furniture.Name == "Bed") furniture.Image = buttonBed.BackgroundImage;
                        if (furniture.Name == "Walls") furniture.Image = buttonWalls.BackgroundImage;
                 
                        furnitures.Add(furniture);
                        string position = "{X=" + furniture.Points.First().X + ", Y=" + furniture.Points.First().Y + "}";
                        listFurniture.Items.Add(new ListViewItem(new[] { furniture.Name, position }));
                        listFurniture.Refresh();
                        DrawFurnitures();
                    }
                    MessageBox.Show("Load successfully!!!");
                }
            }

        }

        private void saveBlueprintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string localFilePath = "";
            SaveFileDialog sfd = new SaveFileDialog();
            JsonSerializer serializer = new JsonSerializer();
            sfd.Filter = "bpp files (*.bpp)|*.bpp";
            sfd.FilterIndex = 1;
            sfd.RestoreDirectory = true;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                localFilePath = sfd.FileName.ToString();
                using (Stream s = File.Open(sfd.FileName, FileMode.Create))
                using (StreamWriter sw = new StreamWriter(s))
                {
                    sw.WriteLine(oneSelected);
                    foreach(Furniture furniture in furnitures)
                    {
                        furniture.Image = null;
                        serializer.Serialize(sw, furniture);
                        sw.WriteLine();
                    }
                }
                MessageBox.Show("Saved Successfully");
            }
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeLanguage("en-US");
            Properties.Settings.Default.Language = "en";
            Properties.Settings.Default.Save();
            //InitializeComponent();
            //this.MinimumSize = new Size(400, 300);
            //furnitures = new List<Furniture>();
            //oneSelected = false;
            //dragFlag = false;
            //mouseOffset = new Point();
            //Count = 0;
            //this.MouseWheel += new MouseEventHandler(rotate_MouseWheel);


        }

        private void 简体中文ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeLanguage("zh-CN");
            Properties.Settings.Default.Language = "cn";
            Properties.Settings.Default.Save();
            //InitializeComponent();
            //this.MinimumSize = new Size(400, 300);
            //furnitures = new List<Furniture>();
            //oneSelected = false;
            //dragFlag = false;
            //mouseOffset = new Point();
            //Count = 0;
            //this.MouseWheel += new MouseEventHandler(rotate_MouseWheel);

        }

        private void ChangeLanguage(string lang) //A function called to change the language
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(lang);
            Thread.CurrentThread.CurrentCulture = new CultureInfo(lang);
    
            ComponentResourceManager resources = new ComponentResourceManager(typeof(MainForm));
            resources.ApplyResources(fileToolStripMenuItem, fileToolStripMenuItem.Name, new CultureInfo(lang));
            resources.ApplyResources(newBluToolStripMenuItem, newBluToolStripMenuItem.Name, new CultureInfo(lang));
            resources.ApplyResources(openBluprintToolStripMenuItem, openBluprintToolStripMenuItem.Name, new CultureInfo(lang));
            resources.ApplyResources(saveBlueprintToolStripMenuItem, saveBlueprintToolStripMenuItem.Name, new CultureInfo(lang));
            resources.ApplyResources(languageToolStripMenuItem, languageToolStripMenuItem.Name, new CultureInfo(lang));
                
            resources.ApplyResources(buttonCoffee, buttonCoffee.Name, new CultureInfo(lang));
            resources.ApplyResources(buttonBed, buttonBed.Name, new CultureInfo(lang));
            resources.ApplyResources(buttonSofa, buttonSofa.Name, new CultureInfo(lang));
            resources.ApplyResources(buttonTable, buttonTable.Name, new CultureInfo(lang));
            resources.ApplyResources(buttonWalls, buttonWalls.Name, new CultureInfo(lang));
            resources.ApplyResources(AddBox, AddBox.Name, new CultureInfo(lang));
            resources.ApplyResources(CreatedBox, CreatedBox.Name, new CultureInfo(lang));
        }
    }
}
