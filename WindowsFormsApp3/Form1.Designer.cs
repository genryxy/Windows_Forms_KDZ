﻿namespace WindowsFormsApp3
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
            this.button3 = new System.Windows.Forms.Button();
            this.trackBarScale = new System.Windows.Forms.TrackBar();
            this.labelScale = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictBoxMain = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.buttonStartCol = new System.Windows.Forms.Button();
            this.labelStartCol = new System.Windows.Forms.Label();
            this.pictBoxStartCol = new System.Windows.Forms.PictureBox();
            this.button7 = new System.Windows.Forms.Button();
            this.labelEndCol = new System.Windows.Forms.Label();
            this.pictBoxEndCol = new System.Windows.Forms.PictureBox();
            this.pictBoxSave = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDepth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarScale)).BeginInit();
            this.panel1.SuspendLayout();
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
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(1042, 492);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(152, 37);
            this.button3.TabIndex = 8;
            this.button3.Text = "Сохранить картинку";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // trackBarScale
            // 
            this.trackBarScale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarScale.BackColor = System.Drawing.SystemColors.HighlightText;
            this.trackBarScale.Location = new System.Drawing.Point(900, 258);
            this.trackBarScale.Maximum = 5;
            this.trackBarScale.Minimum = 1;
            this.trackBarScale.Name = "trackBarScale";
            this.trackBarScale.Size = new System.Drawing.Size(230, 56);
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
            this.labelScale.Location = new System.Drawing.Point(950, 237);
            this.labelScale.Name = "labelScale";
            this.labelScale.Size = new System.Drawing.Size(72, 18);
            this.labelScale.TabIndex = 12;
            this.labelScale.Text = "Масштаб";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pictBoxMain);
            this.panel1.Location = new System.Drawing.Point(71, 24);
            this.panel1.MinimumSize = new System.Drawing.Size(300, 350);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(602, 543);
            this.panel1.TabIndex = 16;
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
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button7.Location = new System.Drawing.Point(953, 424);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(194, 40);
            this.button7.TabIndex = 20;
            this.button7.Text = "Выбрать конечный цвет";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.buttonEndCol_Click);
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
            this.pictBoxSave.Location = new System.Drawing.Point(32, 12);
            this.pictBoxSave.Name = "pictBoxSave";
            this.pictBoxSave.Size = new System.Drawing.Size(700, 600);
            this.pictBoxSave.TabIndex = 24;
            this.pictBoxSave.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(939, 52);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(268, 30);
            this.comboBox1.TabIndex = 25;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_KeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(968, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 25);
            this.label1.TabIndex = 26;
            this.label1.Text = "Рисуемый фрактал";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1262, 617);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictBoxEndCol);
            this.Controls.Add(this.labelEndCol);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.pictBoxStartCol);
            this.Controls.Add(this.labelStartCol);
            this.Controls.Add(this.buttonStartCol);
            this.Controls.Add(this.labelScale);
            this.Controls.Add(this.trackBarScale);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.labelRecur);
            this.Controls.Add(this.trackBarDepth);
            this.Controls.Add(this.pictBoxSave);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Построитель фракталов";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDepth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarScale)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TrackBar trackBarScale;
        private System.Windows.Forms.Label labelScale;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button buttonStartCol;
        private System.Windows.Forms.Label labelStartCol;
        private System.Windows.Forms.PictureBox pictBoxStartCol;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label labelEndCol;
        private System.Windows.Forms.PictureBox pictBoxEndCol;
        private System.Windows.Forms.PictureBox pictBoxSave;
        private System.Windows.Forms.PictureBox pictBoxMain;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
    }
}

