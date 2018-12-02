using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public int scaleIm = 1;
        private bool isChanged = false;
        private Point mouseDownPosition = Point.Empty;
        private Point mouseMovePosition = Point.Empty;
        private static int depthInt;
        private float trS;
        private float bx, cx;
        private float ay;
        private float bc_y;
        private int initialWidth, initialHeight;
        private int currentWidth, currentHeight;
        const int correlation = 150;
        PointF top_point, right_point, left_point;
        Graphics gr2, g;
        Bitmap bitmap2, btm;
        Fractal triangle = new Fractal();
        Random rnd = new Random();

        public override System.Drawing.Size MinimumSize { get; set; }
        public override System.Drawing.Size MaximumSize { get; set; }

        public Form1()
        {
            InitializeComponent();
            bitmap2 = new Bitmap(pictureBox2.Width, pictureBox2.Height);
            pictureBox2.Image = bitmap2;
            gr2 = Graphics.FromImage(bitmap2);

            btm = new Bitmap(pictureBox5.Width, pictureBox5.Height);
            pictureBox5.Image = btm;
            g = Graphics.FromImage(btm);

            initialWidth = currentWidth = pictureBox5.Width - correlation;
            initialHeight = currentHeight = pictureBox5.Height - correlation;

            MinimumSize = new Size(SystemInformation.VirtualScreen.Width / 2, SystemInformation.VirtualScreen.Height / 2);
            MaximumSize = new Size(SystemInformation.VirtualScreen.Width, SystemInformation.VirtualScreen.Height);
            triangle.startColor = Color.Yellow;
            triangle.endColor = Color.Blue;
            pictureBox3.BackColor = triangle.startColor;
            pictureBox4.BackColor = triangle.endColor;
            triangle.sideF = 128f;

            trackBar1.Maximum = 11; // максимум для треугольника Серпинского на trackbare
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 newForm1 = new Form1();
            newForm1.Show();
            /*Form2 newForm2 = new Form2(newForm1);
            newForm2.Show();*/
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        int x, y, xC, yC;

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Хотите покинуть меня?", "Печалька :с", MessageBoxButtons.YesNo) == DialogResult.No)
                e.Cancel = true;

        }
        // расчёт градиента
        private Color Gradient(Color startColor, Color endColor, int size, int j)
        {
            int rMax = startColor.R;
            int rMin = endColor.R;
            int gMax = startColor.G;
            int gMin = endColor.G;
            int bMax = startColor.B;
            int bMin = endColor.B;

            var colorList = new List<Color>();
            for (int i = 0; i < size; i++)
            {
                var rAverage = rMin + (rMax - rMin) * i / size;
                var gAverage = gMin + (gMax - gMin) * i / size;
                var bAverage = bMin + (bMax - bMin) * i / size;
                colorList.Add(Color.FromArgb(rAverage, gAverage, bAverage));
            }
            return colorList[j];
        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            CalculateInitialCoordinates(ref bx, ref cx, ref ay, ref bc_y);
            CalculatePoints(ref top_point, ref right_point, ref left_point);

            var gr = e.Graphics; // если не объявить, то треугольники накладываются друг на друга
            PointF[] points = { top_point, right_point, left_point };
            //Brush color = new SolidBrush(Gradient(triangle.startColor, triangle.endColor, depthInt + 2, depthInt));
            gr.FillPolygon(new SolidBrush(Gradient(triangle.startColor, triangle.endColor, depthInt + 2, depthInt)), points);
            DrawTriangle(gr, depthInt, top_point, left_point, right_point);
        }

        private void CalculatePoints(ref PointF top_point, ref PointF right_point, ref PointF left_point)
        {
            top_point = new PointF((cx + bx) / 2 * scaleIm, ay * scaleIm);
            right_point = new PointF(bx * scaleIm, bc_y * scaleIm);
            left_point = new PointF(cx * scaleIm, bc_y * scaleIm);
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (isChanged)
            {
                trackBar1.Value = depthInt;
                isChanged = false;
            }
            depthInt = trackBar1.Value;
            label1.Text = string.Format("Текущее значение глубины: {0}", depthInt);
            //pictureBox2.Invalidate();
            //pictureBox2.Image = bitmap2;
            pictureBox5.Invalidate();
            pictureBox5.Image = btm;
        }

        private void pictureBox5_Paint(object sender, PaintEventArgs e)
        {
            CalculateInitialCoordinates(ref bx, ref cx, ref ay, ref bc_y);
            CalculatePoints(ref top_point, ref right_point, ref left_point);

            var gr = e.Graphics; // если не объявить, то треугольники накладываются друг на друга
            PointF[] points = { top_point, right_point, left_point };
            Brush color = new SolidBrush(Gradient(triangle.startColor, triangle.endColor, depthInt + 2, depthInt));
            gr.FillPolygon(color, points);
            DrawTriangle(gr, depthInt, top_point, left_point, right_point);
        }       

        // Нарисуем треугольник между точками.
        private void DrawTriangle(Graphics gr, int level, PointF top_point, PointF left_point, PointF right_point)
        {
            try
            {
                Color colorCol = Gradient(triangle.startColor, triangle.endColor, depthInt + 2, level);
                Brush colorBrush = new SolidBrush(colorCol);
                // Посмотрим, остановимся ли мы.
                if (level == 0)
                {
                    // Заполните треугольник.
                    PointF[] points = { top_point, right_point, left_point };
                    gr.FillPolygon(new SolidBrush(triangle.startColor), points);
                }
                else
                {
                    // Найти граничные точки.
                    PointF left_mid = new PointF((top_point.X + left_point.X) / 2f, (top_point.Y + left_point.Y) / 2f);
                    PointF right_mid = new PointF((top_point.X + right_point.X) / 2f, (top_point.Y + right_point.Y) / 2f);
                    PointF bottom_mid = new PointF((left_point.X + right_point.X) / 2f, (left_point.Y + right_point.Y) / 2f);

                    // Рекурсивно рисуем меньшие треугольники.
                    DrawTriangle(gr, level - 1, right_mid, bottom_mid, right_point);
                    DrawTriangle(gr, level - 1, left_mid, left_point, bottom_mid);
                    DrawTriangle(gr, level - 1, top_point, left_mid, right_mid);
                    gr.FillPolygon(colorBrush, new PointF[] { left_mid, right_mid, bottom_mid });
                }
            }
            catch (StackOverflowException err)
            {
                MessageBox.Show($"Невозможно построить! {err.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CalculateInitialCoordinates(ref float bx, ref float cx, ref float ay, ref float bc_y)
        {
            trS = triangle.sideF;
            bx = 5;
            cx = bx + trS;
            ay = 1;
            bc_y = ay + (float)Math.Sqrt(trS * trS - trS * trS / 4);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (pictureBox5.Image != null)
            {
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.Title = "Сохранить изображение как ...";
                saveFile.OverwritePrompt = true; // существует ли указанное имя
                saveFile.CheckPathExists = true; // существует ли указанный путь
                saveFile.Filter = "Image Files(*.JPG)|*.JPG|Image Files(*.BMP)|*.BMP|Image Files(*.PNG)|*.PNG|All files (*.*)|*.*";
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        if (pictureBox2.Image != null)
                        {
                            CalculateInitialCoordinates(ref bx, ref cx, ref ay, ref bc_y);
                            CalculatePoints(ref top_point, ref right_point, ref left_point);

                            PointF[] points = { top_point, right_point, left_point };
                            Brush color = new SolidBrush(Gradient(triangle.startColor, triangle.endColor, depthInt + 2, depthInt));
                            gr2.FillPolygon(color, points);
                            DrawTriangle(gr2, depthInt, top_point, left_point, right_point);
                            bitmap2.Save(saveFile.FileName);
                            gr2.FillRectangle(new SolidBrush(Form1.DefaultBackColor), 0, 0, pictureBox2.Width, pictureBox2.Height);
                        }
                    }
                    catch (ArgumentNullException err)
                    {
                        MessageBox.Show($"Невозможно сохранить! {err.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {           
            label3.Text = String.Format("Текущее значение масштаба: {0}", trackBar2.Value);
            scaleIm = trackBar2.Value;        
            btm = new Bitmap(initialWidth * (1 + scaleIm / 3), initialHeight * (1 + scaleIm / 3));
            pictureBox5.Image = btm;
            pictureBox5.Invalidate();
            //Form2 newForm2 = new Form2();
            //newForm2.Show();
        }
        string colorNotSelected = "Вы не выбрали цвет! \nYou didn't select the color!";
        private void button6_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox3.BackColor = colorDialog1.Color;
                //label2.Visible = false;
                //pictureBox3.Visible = true;
                triangle.startColor = pictureBox3.BackColor;
                pictureBox5.Image = btm;
                pictureBox5.Invalidate();
            }
            else
                MessageBox.Show(colorNotSelected);
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox4.BackColor = colorDialog1.Color;
                //label4.Visible = false;
                //pictureBox4.Visible = true;
                triangle.endColor = pictureBox4.BackColor;
                pictureBox5.Image = btm;
                pictureBox5.Invalidate();
            }
            else
                MessageBox.Show(colorNotSelected);
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            Button button = new Button();
            int dx = e.X - xC;
            int dy = e.Y - yC;
            button1.Location = new Point(x + dx, y + dy);
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            Button button = (Button)sender;
            x = button.Location.X;
            y = button.Location.Y;
            xC = e.X;
            yC = e.Y;
        }
    }
    public class Fractal
    {
        public Color startColor, endColor;
        protected internal float sideF;
        public virtual void Draw() { }
    }
}
/*
         Image Zoom(Image img, Size size)
        {
            bitmap = new Bitmap(img, img.Width + (img.Width * 2 / 100), img.Height + (img.Height * 2 / 100));
            gr = Graphics.FromImage(bitmap);
            gr.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            return bitmap;
        }
        */

// загрузка изображений
/*using (OpenFileDialog openFile = new OpenFileDialog() { Multiselect = false, ValidateNames = true, Filter = "JPEG|*.jpg" })
        {
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFile.FileName);  
            }
        }*/

// ввод значения глубины фрактала
/*
    private bool isChanged = false;

    depth = maskedTextBox1.Text;
    depthInt = Convert.ToInt32(depth);
    label1.Text = String.Format("Текущее значение: {0}", depthInt);
    pictureBox1.Invalidate();
    //MessageBox.Show(depth);
 */
// поменять цвет фона
/*int r = rnd.Next(256),
           g = rnd.Next(256),
           b = rnd.Next(256);
       BackColor = Color.FromArgb(r, g, b);
 */
