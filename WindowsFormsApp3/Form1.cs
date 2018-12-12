using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        private const double zoomTr= 1.5;
        private const double zoomSq = 1.5;
        private const double zoomCur = 1;

        public static int scaleIm = 1;
        public static int curDepth = 0;
        private bool _isChangedDepth = false;
        private int _initialWidth, _initialHeight;
        private string _colorNotSelected = "Вы не выбрали цвет!";
        private string _mode;

        Bitmap btmTriangle, btmSquare, btmCurve;
        Graphics gTr, gSq, gCur, gSave;
        Triangle triangle = new Triangle();
        Square square = new Square();
        Curve curve = new Curve();

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
            _initialWidth = pictBoxMain.Width;
            _initialHeight = pictBoxMain.Height;
            square.InitializeTSquare();
            InitializeCombobox();
            trackBarDepth.Maximum = triangle.MaxDepthInt; // maximum depth of triangle on the trackbar            

            btmTriangle = NewBitmap(zoomTr, pictBoxMain);
            gTr = Graphics.FromImage(btmTriangle);
            btmSquare = NewBitmap(zoomSq, pictBoxMain);
            gSq = Graphics.FromImage(btmSquare);
            btmCurve = NewBitmap(zoomCur, pictBoxMain);
            gCur = Graphics.FromImage(btmCurve);
           
            MinimumSize = new Size(SystemInformation.VirtualScreen.Width / 2,
                SystemInformation.VirtualScreen.Height / 2);
            MaximumSize = new Size(SystemInformation.VirtualScreen.Width,
                SystemInformation.VirtualScreen.Height);
            pictBoxStartCol.BackColor = Fractal.StartColor;
            pictBoxEndCol.BackColor = Fractal.EndColor;

            labelMinDepth.Text = trackBarDepth.Minimum.ToString();
            labelMinScale.Text = trackBarScale.Minimum.ToString();
            labelMaxScale.Text = trackBarScale.Maximum.ToString();
        }

        private Bitmap NewBitmap(double zoom, PictureBox pictBox)
        {
            Bitmap btm;
            btm = new Bitmap(_initialWidth * (int)(1 + scaleIm / zoom), _initialHeight * (int)(1 + scaleIm / zoom));
            pictBox.Image = btm;
            return btm;
        }
        private void InitializeCombobox()
        {
            comboBox.Items.AddRange(new string[] { "Треугольник Серпинского", "Т-квадрат", "С-Кривая Леви" });
            comboBox.SelectedItem = comboBox.Items[0];
            comboBox.DropDownStyle = ComboBoxStyle.DropDown;
        }

        private void trackBarDepth_Scroll(object sender, EventArgs e)
        {
            if (_isChangedDepth)
            {
                trackBarDepth.Value = Fractal.DepthInt;
                _isChangedDepth = false;
            }
            TrackBarDepthChange();
        }

        private void pictBoxMain_Paint(object sender, PaintEventArgs e)
        {
            var timer = Stopwatch.StartNew();
            timer.Start();
            ChooseFractalDraw(_mode, e.Graphics);

            if (timer.Elapsed >= new TimeSpan(0, 0, 0, 0, 700))
            {
                MessageBox.Show($"Фрактал рисовался слишком долго: " +
                     $"{String.Format("{0:0.00} c", ((float)timer.ElapsedMilliseconds) / 1000)}" +
                     $"\nМаксимальная глубина рекурсии будет уменьшена.", "Лимит времени!");
                trackBarDepth.Maximum -= 2;
                labelMaxDepth.Text = trackBarDepth.Maximum.ToString();
                TrackBarDepthChange();
            }
            timer.Reset();
        }

        private void ChooseFractalDraw(string mode, Graphics g)
        {
            switch (mode)
            {
                case "Треугольник Серпинского":
                    triangle.CalculateCoordinates();
                    triangle.CalculatePoints();
                    // if don't declare it, then the triangles are superimposed on each other
                    triangle.Draw(g);
                    break;
                case "Т-квадрат":
                    square.DrawFirstTSquare(g);
                    square.Draw(g);
                    break;
                case "С-Кривая Леви":
                    curve.CalculateInitialCoordinates(pictBoxMain.Size.Width / 3);
                    curve.NumbColor = 0;
                    curve.Draw(g);
                    break;
            }
        }

        private void TrackBarDepthChange()
        {
            Fractal.DepthInt = trackBarDepth.Value;
            curDepth = trackBarDepth.Value;
            labelRecur.Text = string.Format("Текущее значение глубины: {0}", trackBarDepth.Value);
            pictBoxMain.Invalidate();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (pictBoxMain.Image != null)
            {
                SaveFileDialog saveFile = new SaveFileDialog
                {
                    Title = "Сохранить изображение как ...",
                    OverwritePrompt = true, // does the name exist
                    CheckPathExists = true, // does the path exist
                    Filter = "Image Files(*.JPG)|*.JPG|Image Files(*.BMP)|*.BMP|" +
                    "Image Files(*.PNG)|*.PNG|All files (*.*)|*.*"
                };
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        switch (_mode)
                        {
                            case "Треугольник Серпинского":
                                btmTriangle = NewBitmap(zoomTr, pictBoxSave);
                                gSave = Graphics.FromImage(btmTriangle);
                                // if don't declare it, then the triangles are superimposed on each other
                                triangle.Draw(gSave);
                                btmTriangle.Save(saveFile.FileName);
                                break;
                            case "Т-квадрат":
                                btmSquare = NewBitmap(zoomSq, pictBoxSave);
                                gSave = Graphics.FromImage(btmSquare);
                                square.DrawFirstTSquare(gSave);
                                square.Draw(gSave);
                                btmSquare.Save(saveFile.FileName);
                                break;
                            case "С-Кривая Леви":
                                btmCurve = NewBitmap(zoomCur, pictBoxSave);
                                gSave = Graphics.FromImage(btmCurve);
                                curve.NumbColor = 0;
                                curve.Draw(gSave);
                                btmCurve.Save(saveFile.FileName);
                                break;
                        }
                        gSave.FillRectangle(new SolidBrush(DefaultBackColor),
                            0, 0, pictBoxSave.Width, pictBoxSave.Height);

                    }
                    catch (NullReferenceException err)
                    {
                        MessageBox.Show($"Невозможно сохранить! {err.Message}",
                            "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            _mode = comboBox.SelectedItem.ToString();
            Fractal.DepthInt = trackBarDepth.Value;
            square.ChangeSquareSize(scaleIm);
            switch (_mode)
            {
                case "Треугольник Серпинского":
                    btmSquare = NewBitmap(zoomTr, pictBoxMain);
                    trackBarDepth.Maximum = Triangle.maxDepthTrDefault;
                    break;
                case "Т-квадрат":
                    square.ChangeSquareSize(scaleIm);
                    btmSquare = NewBitmap(zoomSq, pictBoxMain);
                    trackBarDepth.Maximum = Square.maxDepthSqDefault;
                    break;
                case "С-Кривая Леви":
                    btmCurve = NewBitmap(zoomCur, pictBoxMain);
                    trackBarDepth.Maximum = Curve.maxDepthCurveDefault;
                    break;
            }
            labelMaxDepth.Text = trackBarDepth.Maximum.ToString();
            pictBoxMain.Invalidate();
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // to prevent entry of incorrect values
            e.Handled = true;
        }

        private void trackBarScale_Scroll(object sender, EventArgs e)
        {
            labelScale.Text = String.Format("Текущий масштаб: {0}", trackBarScale.Value);
            scaleIm = trackBarScale.Value;
            switch (_mode)
            {
                case "Треугольник Серпинского":
                    btmSquare = NewBitmap(zoomTr, pictBoxMain);
                    break;
                case "Т-квадрат":
                    square.ChangeSquareSize(scaleIm);
                    btmSquare = NewBitmap(zoomSq, pictBoxMain);
                    break;
                case "С-Кривая Леви":
                    curve.CalculateInitialCoordinates(pictBoxMain.Size.Width / 3);
                    btmCurve = NewBitmap(zoomCur, pictBoxMain);
                    break;
            }
            pictBoxMain.Invalidate();
        }

        private void buttonStartCol_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                pictBoxStartCol.BackColor = colorDialog.Color;
                Fractal.StartColor = pictBoxStartCol.BackColor;
                pictBoxMain.Invalidate();
            }
            else
                MessageBox.Show(_colorNotSelected);
        }

        private void buttonEndCol_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                pictBoxEndCol.BackColor = colorDialog.Color;
                Fractal.EndColor = pictBoxEndCol.BackColor;
                pictBoxMain.Invalidate();
            }
            else
                MessageBox.Show(_colorNotSelected);
        }

    }
}

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
