namespace DrawingFractals
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelRecur = new System.Windows.Forms.Label();
            this.trackBarDepth = new System.Windows.Forms.TrackBar();
            this.buttonSave = new System.Windows.Forms.Button();
            this.trackBarScale = new System.Windows.Forms.TrackBar();
            this.labelScale = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.pictBoxMain = new System.Windows.Forms.PictureBox();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.buttonStartCol = new System.Windows.Forms.Button();
            this.labelStartCol = new System.Windows.Forms.Label();
            this.pictBoxStartCol = new System.Windows.Forms.PictureBox();
            this.buttonEndCol = new System.Windows.Forms.Button();
            this.labelEndCol = new System.Windows.Forms.Label();
            this.pictBoxEndCol = new System.Windows.Forms.PictureBox();
            this.pictBoxSave = new System.Windows.Forms.PictureBox();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.labelNameFractal = new System.Windows.Forms.Label();
            this.labelMinDepth = new System.Windows.Forms.Label();
            this.labelMaxDepth = new System.Windows.Forms.Label();
            this.labelMinScale = new System.Windows.Forms.Label();
            this.labelMaxScale = new System.Windows.Forms.Label();
            this.checkBoxCurve = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDepth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarScale)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxStartCol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxEndCol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxSave)).BeginInit();
            this.SuspendLayout();
            // 
            // labelRecur
            // 
            this.labelRecur.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRecur.AutoSize = true;
            this.labelRecur.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.labelRecur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRecur.Location = new System.Drawing.Point(950, 157);
            this.labelRecur.Name = "labelRecur";
            this.labelRecur.Size = new System.Drawing.Size(133, 18);
            this.labelRecur.TabIndex = 2;
            this.labelRecur.Text = "Глубина рекурсии";
            // 
            // trackBarDepth
            // 
            this.trackBarDepth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarDepth.BackColor = System.Drawing.SystemColors.HighlightText;
            this.trackBarDepth.Location = new System.Drawing.Point(900, 178);
            this.trackBarDepth.Maximum = 13;
            this.trackBarDepth.Name = "trackBarDepth";
            this.trackBarDepth.Size = new System.Drawing.Size(350, 56);
            this.trackBarDepth.TabIndex = 7;
            this.trackBarDepth.Scroll += new System.EventHandler(this.trackBarDepth_Scroll);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Location = new System.Drawing.Point(1055, 494);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(152, 37);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // trackBarScale
            // 
            this.trackBarScale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarScale.BackColor = System.Drawing.SystemColors.HighlightText;
            this.trackBarScale.Location = new System.Drawing.Point(900, 258);
            this.trackBarScale.Maximum = 5;
            this.trackBarScale.Minimum = 1;
            this.trackBarScale.Name = "trackBarScale";
            this.trackBarScale.Size = new System.Drawing.Size(217, 56);
            this.trackBarScale.TabIndex = 10;
            this.trackBarScale.Value = 1;
            this.trackBarScale.Scroll += new System.EventHandler(this.trackBarScale_Scroll);
            // 
            // labelScale
            // 
            this.labelScale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelScale.AutoSize = true;
            this.labelScale.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.labelScale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelScale.Location = new System.Drawing.Point(926, 237);
            this.labelScale.Name = "labelScale";
            this.labelScale.Size = new System.Drawing.Size(72, 18);
            this.labelScale.TabIndex = 12;
            this.labelScale.Text = "Масштаб";
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.AutoScroll = true;
            this.panel.BackColor = System.Drawing.SystemColors.Control;
            this.panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel.Controls.Add(this.pictBoxMain);
            this.panel.Location = new System.Drawing.Point(71, 24);
            this.panel.MinimumSize = new System.Drawing.Size(350, 300);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(602, 543);
            this.panel.TabIndex = 16;
            // 
            // pictBoxMain
            // 
            this.pictBoxMain.BackColor = System.Drawing.SystemColors.Control;
            this.pictBoxMain.Location = new System.Drawing.Point(50, 15);
            this.pictBoxMain.MinimumSize = new System.Drawing.Size(200, 200);
            this.pictBoxMain.Name = "pictBoxMain";
            this.pictBoxMain.Size = new System.Drawing.Size(512, 512);
            this.pictBoxMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictBoxMain.TabIndex = 0;
            this.pictBoxMain.TabStop = false;
            this.pictBoxMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pictBoxMain_Paint);
            // 
            // buttonStartCol
            // 
            this.buttonStartCol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStartCol.Location = new System.Drawing.Point(953, 357);
            this.buttonStartCol.Name = "buttonStartCol";
            this.buttonStartCol.Size = new System.Drawing.Size(194, 40);
            this.buttonStartCol.TabIndex = 17;
            this.buttonStartCol.Text = "Выбрать начальный цвет";
            this.buttonStartCol.UseVisualStyleBackColor = true;
            this.buttonStartCol.Click += new System.EventHandler(this.buttonStartCol_Click);
            // 
            // labelStartCol
            // 
            this.labelStartCol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelStartCol.AutoSize = true;
            this.labelStartCol.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.labelStartCol.Location = new System.Drawing.Point(1153, 337);
            this.labelStartCol.Name = "labelStartCol";
            this.labelStartCol.Size = new System.Drawing.Size(69, 17);
            this.labelStartCol.TabIndex = 18;
            this.labelStartCol.Text = "startColor";
            // 
            // pictBoxStartCol
            // 
            this.pictBoxStartCol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictBoxStartCol.Location = new System.Drawing.Point(1156, 357);
            this.pictBoxStartCol.Name = "pictBoxStartCol";
            this.pictBoxStartCol.Size = new System.Drawing.Size(77, 33);
            this.pictBoxStartCol.TabIndex = 19;
            this.pictBoxStartCol.TabStop = false;
            // 
            // buttonEndCol
            // 
            this.buttonEndCol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEndCol.Location = new System.Drawing.Point(953, 424);
            this.buttonEndCol.Name = "buttonEndCol";
            this.buttonEndCol.Size = new System.Drawing.Size(194, 40);
            this.buttonEndCol.TabIndex = 20;
            this.buttonEndCol.Text = "Выбрать конечный цвет";
            this.buttonEndCol.UseVisualStyleBackColor = true;
            this.buttonEndCol.Click += new System.EventHandler(this.buttonEndCol_Click);
            // 
            // labelEndCol
            // 
            this.labelEndCol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelEndCol.AutoSize = true;
            this.labelEndCol.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.labelEndCol.Location = new System.Drawing.Point(1159, 411);
            this.labelEndCol.Name = "labelEndCol";
            this.labelEndCol.Size = new System.Drawing.Size(65, 17);
            this.labelEndCol.TabIndex = 21;
            this.labelEndCol.Text = "endColor";
            // 
            // pictBoxEndCol
            // 
            this.pictBoxEndCol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictBoxEndCol.Location = new System.Drawing.Point(1159, 431);
            this.pictBoxEndCol.Name = "pictBoxEndCol";
            this.pictBoxEndCol.Size = new System.Drawing.Size(77, 33);
            this.pictBoxEndCol.TabIndex = 22;
            this.pictBoxEndCol.TabStop = false;
            // 
            // pictBoxSave
            // 
            this.pictBoxSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictBoxSave.Location = new System.Drawing.Point(64, 24);
            this.pictBoxSave.Name = "pictBoxSave";
            this.pictBoxSave.Size = new System.Drawing.Size(619, 529);
            this.pictBoxSave.TabIndex = 24;
            this.pictBoxSave.TabStop = false;
            // 
            // comboBox
            // 
            this.comboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(939, 52);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(268, 30);
            this.comboBox.TabIndex = 25;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_KeyPress);
            // 
            // labelNameFractal
            // 
            this.labelNameFractal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNameFractal.AutoSize = true;
            this.labelNameFractal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNameFractal.Location = new System.Drawing.Point(968, 24);
            this.labelNameFractal.Name = "labelNameFractal";
            this.labelNameFractal.Size = new System.Drawing.Size(196, 25);
            this.labelNameFractal.TabIndex = 26;
            this.labelNameFractal.Text = "Рисуемый фрактал";
            // 
            // labelMinDepth
            // 
            this.labelMinDepth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMinDepth.AutoSize = true;
            this.labelMinDepth.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.labelMinDepth.Location = new System.Drawing.Point(909, 216);
            this.labelMinDepth.Name = "labelMinDepth";
            this.labelMinDepth.Size = new System.Drawing.Size(30, 17);
            this.labelMinDepth.TabIndex = 27;
            this.labelMinDepth.Text = "min";
            // 
            // labelMaxDepth
            // 
            this.labelMaxDepth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMaxDepth.AutoSize = true;
            this.labelMaxDepth.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.labelMaxDepth.Location = new System.Drawing.Point(1226, 216);
            this.labelMaxDepth.Name = "labelMaxDepth";
            this.labelMaxDepth.Size = new System.Drawing.Size(33, 17);
            this.labelMaxDepth.TabIndex = 28;
            this.labelMaxDepth.Text = "max";
            // 
            // labelMinScale
            // 
            this.labelMinScale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMinScale.AutoSize = true;
            this.labelMinScale.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.labelMinScale.Location = new System.Drawing.Point(909, 296);
            this.labelMinScale.Name = "labelMinScale";
            this.labelMinScale.Size = new System.Drawing.Size(30, 17);
            this.labelMinScale.TabIndex = 29;
            this.labelMinScale.Text = "min";
            // 
            // labelMaxScale
            // 
            this.labelMaxScale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMaxScale.AutoSize = true;
            this.labelMaxScale.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.labelMaxScale.Location = new System.Drawing.Point(1093, 296);
            this.labelMaxScale.Name = "labelMaxScale";
            this.labelMaxScale.Size = new System.Drawing.Size(33, 17);
            this.labelMaxScale.TabIndex = 30;
            this.labelMaxScale.Text = "max";
            // 
            // checkBoxCurve
            // 
            this.checkBoxCurve.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxCurve.AutoSize = true;
            this.checkBoxCurve.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxCurve.Location = new System.Drawing.Point(1005, 103);
            this.checkBoxCurve.Name = "checkBoxCurve";
            this.checkBoxCurve.Size = new System.Drawing.Size(202, 21);
            this.checkBoxCurve.TabIndex = 31;
            this.checkBoxCurve.Text = "Красивая С-кривая Леви: ";
            this.checkBoxCurve.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxCurve.UseVisualStyleBackColor = true;
            this.checkBoxCurve.Visible = false;
            this.checkBoxCurve.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1262, 617);
            this.Controls.Add(this.checkBoxCurve);
            this.Controls.Add(this.labelMaxScale);
            this.Controls.Add(this.labelMinScale);
            this.Controls.Add(this.labelMaxDepth);
            this.Controls.Add(this.labelMinDepth);
            this.Controls.Add(this.labelNameFractal);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.pictBoxEndCol);
            this.Controls.Add(this.labelEndCol);
            this.Controls.Add(this.buttonEndCol);
            this.Controls.Add(this.pictBoxStartCol);
            this.Controls.Add(this.labelStartCol);
            this.Controls.Add(this.buttonStartCol);
            this.Controls.Add(this.labelScale);
            this.Controls.Add(this.trackBarScale);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelRecur);
            this.Controls.Add(this.trackBarDepth);
            this.Controls.Add(this.pictBoxSave);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Построитель фракталов";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDepth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarScale)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxStartCol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxEndCol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxSave)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelRecur;
        private System.Windows.Forms.TrackBar trackBarDepth;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TrackBar trackBarScale;
        private System.Windows.Forms.Label labelScale;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button buttonStartCol;
        private System.Windows.Forms.Label labelStartCol;
        private System.Windows.Forms.PictureBox pictBoxStartCol;
        private System.Windows.Forms.Button buttonEndCol;
        private System.Windows.Forms.Label labelEndCol;
        private System.Windows.Forms.PictureBox pictBoxEndCol;
        private System.Windows.Forms.PictureBox pictBoxSave;
        private System.Windows.Forms.PictureBox pictBoxMain;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Label labelNameFractal;
        private System.Windows.Forms.Label labelMinDepth;
        private System.Windows.Forms.Label labelMaxDepth;
        private System.Windows.Forms.Label labelMinScale;
        private System.Windows.Forms.Label labelMaxScale;
        private System.Windows.Forms.CheckBox checkBoxCurve;
    }
}

