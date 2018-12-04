using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public static int scaleIm = 1;
        private bool isChanged = false;
        private int initialWidth, initialHeight;
        private string colorNotSelected = "Вы не выбрали цвет!";

        Bitmap btm, btm2;
        Graphics gr2, g;
        Triangle triangle = new Triangle();

        public override System.Drawing.Size MinimumSize { get; set; }
        public override System.Drawing.Size MaximumSize { get; set; }

        public Form1()
        {
            InitializeComponent();
            InitializeValues();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Хотите покинуть меня?",
                "Печалька :с", MessageBoxButtons.YesNo) == DialogResult.No)
                e.Cancel = true;

        }

        private void InitializeValues()
        {
            triangle.InitializeTriangle();
            trackBarDepth.Maximum = triangle.MaxDepthInt; // maximum depth of triangle on the trackbar
            comboBox1.Items.AddRange(new string[] {"Треугольник Серпинского",
            "Т-квадрат", "С-Кривая Леви"});
            comboBox1.SelectedItem = comboBox1.Items[0];
            comboBox1.DropDownStyle = ComboBoxStyle.DropDown;

            btm = new Bitmap(pictBoxMain.Width, pictBoxMain.Height);
            pictBoxMain.Image = btm;
            g = Graphics.FromImage(btm);
            btm2 = new Bitmap(pictBoxSave.Width, pictBoxSave.Height);
            pictBoxSave.Image = btm2;
            gr2 = Graphics.FromImage(btm2);

            initialWidth = pictBoxMain.Width - Triangle.correlation;
            initialHeight = pictBoxMain.Height - Triangle.correlation;
            MinimumSize = new Size(SystemInformation.VirtualScreen.Width / 2,
                SystemInformation.VirtualScreen.Height / 2);
            MaximumSize = new Size(SystemInformation.VirtualScreen.Width,
                SystemInformation.VirtualScreen.Height);
            pictBoxStartCol.BackColor = triangle.StartColor;
            pictBoxEndCol.BackColor = triangle.EndColor;
        }
        private void trackBarDepth_Scroll(object sender, EventArgs e)
        {
            if (isChanged)
            {
                trackBarDepth.Value = triangle.DepthInt;
                isChanged = false;
            }
            TrackBarChange(false);
        }
        private void pictBoxMain_Paint(object sender, PaintEventArgs e)
        {
            var timer = Stopwatch.StartNew();
            timer.Start();
            triangle.CalculateInitialCoordinates();
            triangle.CalculatePoints();
            // if don't declare it, then the triangles are superimposed on each other
            var gr = e.Graphics;
            triangle.Draw(gr);
            if (timer.Elapsed >= new TimeSpan(0, 0, 0, 0, 700))
            {
                MessageBox.Show($"Фрактал рисовался слишком долго: " +
                    $"{String.Format("{0:0.00} c", ((float)timer.ElapsedMilliseconds) / 1000)}" +
                    $"\nМаксимальная глубина рекурсии будет уменьшена.", "Лимит времени!");
                triangle.MaxDepthInt -= 2;
                TrackBarChange(true);
            }
            timer.Reset();
        }
        private void TrackBarChange(bool changed)
        {
            if (changed)
                trackBarDepth.Maximum = triangle.MaxDepthInt;
            triangle.DepthInt = trackBarDepth.Value;
            labelRecur.Text = string.Format("Текущее значение глубины: {0}", triangle.DepthInt);
            pictBoxMain.Invalidate();
            pictBoxMain.Image = btm;
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (pictBoxMain.Image != null)
            {
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.Title = "Сохранить изображение как ...";
                saveFile.OverwritePrompt = true; // does the name exist
                saveFile.CheckPathExists = true; // does the path exist
                saveFile.Filter = "Image Files(*.JPG)|*.JPG|Image Files(*.BMP)|*.BMP|" +
                    "Image Files(*.PNG)|*.PNG|All files (*.*)|*.*";
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        if (pictBoxSave.Image != null)
                        {
                            triangle.CalculateInitialCoordinates();
                            triangle.CalculatePoints(); 
                            triangle.Draw(gr2);
                            btm2.Save(saveFile.FileName);
                            gr2.FillRectangle(new SolidBrush(Form1.DefaultBackColor),
                                0, 0, pictBoxSave.Width, pictBoxSave.Height);
                        }
                    }
                    catch (ArgumentNullException err)
                    {
                        MessageBox.Show($"Невозможно сохранить! {err.Message}",
                            "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }    

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string pickedFractal = comboBox1.SelectedItem.ToString();
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // to prevent entry of incorrect values
            e.Handled = true;
        }

        private void trackBarScale_Scroll(object sender, EventArgs e)
        {
            labelScale.Text = String.Format("Текущее значение масштаба: {0}", trackBarScale.Value);
            scaleIm = trackBarScale.Value;
            btm = new Bitmap(initialWidth * (1 + scaleIm / 3), initialHeight * (1 + scaleIm / 3));
            pictBoxMain.Image = btm;
            pictBoxMain.Invalidate();
        }

        private void buttonStartCol_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pictBoxStartCol.BackColor = colorDialog1.Color;
                triangle.StartColor = pictBoxStartCol.BackColor;
                pictBoxMain.Image = btm;
                pictBoxMain.Invalidate();
            }
            else
                MessageBox.Show(colorNotSelected);
        }
        private void buttonEndCol_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pictBoxEndCol.BackColor = colorDialog1.Color;
                triangle.EndColor = pictBoxEndCol.BackColor;
                pictBoxMain.Image = btm;
                pictBoxMain.Invalidate();
            }
            else
                MessageBox.Show(colorNotSelected);
        }
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
        }
*/

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

/* создание новой формы
     private void button1_Click(object sender, EventArgs e)
        {
            Form1 newForm1 = new Form1();
            newForm1.Show();
            Form2 newForm2 = new Form2(newForm1);
            newForm2.Show();
        }
 */
/* двигать кнопку в каком-либо направлении
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
 */
// Нарисуем треугольник между точками.
/*Co
private void DrawTriangle(Graphics gr, int level, PointF top_point, PointF left_point, PointF right_point)
{
    try
    {
        Color colorCol = Gradient(triangle.startColor, triangle.endColor, depthInt + 2, level);
        Brush colorBrush = new SolidBrush(colorCol);
        if (level == 0)
        {
            PointF[] points = { top_point, right_point, left_point };
            gr.FillPolygon(new SolidBrush(triangle.startColor), points);
        }
        else
        {
            // Найти граничные точки треугольника
            PointF left_mid = new PointF((top_point.X + left_point.X) / 2f, (top_point.Y + left_point.Y) / 2f);
            PointF right_mid = new PointF((top_point.X + right_point.X) / 2f, (top_point.Y + right_point.Y) / 2f);
            PointF bottom_mid = new PointF((left_point.X + right_point.X) / 2f, (left_point.Y + right_point.Y) / 2f);

            // Рекурсивно рисуем три меньших треугольника
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
} */
/*private void buttonSave_Click(object sender, EventArgs e)
{
    if (pictBoxMain.Image != null)
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
                if (pictBoxSave.Image != null)
                {
                    CalculateInitialCoordinates(ref bx, ref cx, ref ay, ref bc_y);
                    CalculatePoints(ref top_point, ref right_point, ref left_point);
                    PointF[] points = { top_point, right_point, left_point };
                    Brush color = new SolidBrush(Gradient(triangle.startColor, triangle.endColor, depthInt + 2, depthInt));
                    gr2.FillPolygon(color, points);
                    DrawTriangle(gr2, depthInt, top_point, left_point, right_point);
                    bitmap2.Save(saveFile.FileName);
                    gr2.FillRectangle(new SolidBrush(Form1.DefaultBackColor), 0, 0, pictBoxSave.Width, pictBoxSave.Height);
                }
            }
            catch (ArgumentNullException err)
            {
                MessageBox.Show($"Невозможно сохранить! {err.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}*/

/*private void pictBoxMain_Paint(object sender, PaintEventArgs e)
{
    CalculateInitialCoordinates(ref bx, ref cx, ref ay, ref bc_y);
    CalculatePoints(ref top_point, ref right_point, ref left_point);

    var gr = e.Graphics; // если не объявить, то треугольники накладываются друг на друга
    PointF[] points = { top_point, right_point, left_point };
    Brush color = new SolidBrush(Gradient(triangle.startColor, triangle.endColor, depthInt + 2, depthInt));
    gr.FillPolygon(color, points);
    DrawTriangle(gr, depthInt, top_point, left_point, right_point);
    //triangle.Draw(gr, depthInt, top_point, left_point, right_point);
}*/
// расчёт градиента
/*private Color Gradient(Color startColor, Color endColor, int size, int j)
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
}*/
/*private void CalculatePoints(ref PointF top_point, ref PointF right_point, ref PointF left_point)
{
    top_point = new PointF((cx + bx) / 2 * scaleIm, ay * scaleIm);
    right_point = new PointF(bx * scaleIm, bc_y * scaleIm);
    left_point = new PointF(cx * scaleIm, bc_y * scaleIm);
}*/
/*private void trackBarDepth_Scroll(object sender, EventArgs e)
{
    if (isChanged)
    {
        trackBarDepth.Value = depthInt;
        isChanged = false;
    }
    depthInt = trackBarDepth.Value;
    labelRecur.Text = string.Format("Текущее значение глубины: {0}", depthInt);
    pictBoxMain.Invalidate();
    pictBoxMain.Image = btm;
}*/
