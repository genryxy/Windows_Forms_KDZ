namespace WindowsFormsApp3
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
            this.labelRecur.Location = new System.Drawing.Point(794, 130);
            this.labelRecur.Name = "labelRecur";
            this.labelRecur.Size = new System.Drawing.Size(128, 17);
            this.labelRecur.TabIndex = 2;
            this.labelRecur.Text = "Глубина рекурсии";
            // 
            // trackBarDepth
            // 
            this.trackBarDepth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarDepth.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.trackBarDepth.Location = new System.Drawing.Point(760, 150);
            this.trackBarDepth.Maximum = 13;
            this.trackBarDepth.Name = "trackBarDepth";
            this.trackBarDepth.Size = new System.Drawing.Size(313, 56);
            this.trackBarDepth.TabIndex = 7;
            this.trackBarDepth.Scroll += new System.EventHandler(this.trackBarDepth_Scroll);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(770, 44);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(152, 37);
            this.button3.TabIndex = 8;
            this.button3.Text = "pcitureSave";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // trackBarScale
            // 
            this.trackBarScale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarScale.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.trackBarScale.Location = new System.Drawing.Point(760, 226);
            this.trackBarScale.Maximum = 5;
            this.trackBarScale.Minimum = 1;
            this.trackBarScale.Name = "trackBarScale";
            this.trackBarScale.Size = new System.Drawing.Size(201, 56);
            this.trackBarScale.TabIndex = 10;
            this.trackBarScale.Value = 1;
            this.trackBarScale.Scroll += new System.EventHandler(this.trackBarScale_Scroll);
            // 
            // labelScale
            // 
            this.labelScale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelScale.AutoSize = true;
            this.labelScale.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.labelScale.Location = new System.Drawing.Point(794, 209);
            this.labelScale.Name = "labelScale";
            this.labelScale.Size = new System.Drawing.Size(68, 17);
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
            this.panel1.Location = new System.Drawing.Point(44, 12);
            this.panel1.MinimumSize = new System.Drawing.Size(350, 400);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(636, 548);
            this.panel1.TabIndex = 16;
            // 
            // pictBoxMain
            // 
            this.pictBoxMain.BackColor = System.Drawing.SystemColors.Control;
            this.pictBoxMain.Location = new System.Drawing.Point(47, 17);
            this.pictBoxMain.MinimumSize = new System.Drawing.Size(200, 200);
            this.pictBoxMain.Name = "pictBoxMain";
            this.pictBoxMain.Size = new System.Drawing.Size(500, 500);
            this.pictBoxMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictBoxMain.TabIndex = 0;
            this.pictBoxMain.TabStop = false;
            this.pictBoxMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pictBoxMain_Paint);
            // 
            // buttonStartCol
            // 
            this.buttonStartCol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStartCol.Location = new System.Drawing.Point(1040, 226);
            this.buttonStartCol.Name = "buttonStartCol";
            this.buttonStartCol.Size = new System.Drawing.Size(153, 71);
            this.buttonStartCol.TabIndex = 17;
            this.buttonStartCol.Text = "Выбрать начальный цвет";
            this.buttonStartCol.UseVisualStyleBackColor = true;
            this.buttonStartCol.Click += new System.EventHandler(this.buttonStartCol_Click);
            // 
            // labelStartCol
            // 
            this.labelStartCol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelStartCol.AutoSize = true;
            this.labelStartCol.BackColor = System.Drawing.SystemColors.ControlDark;
            this.labelStartCol.Location = new System.Drawing.Point(1205, 226);
            this.labelStartCol.Name = "labelStartCol";
            this.labelStartCol.Size = new System.Drawing.Size(69, 17);
            this.labelStartCol.TabIndex = 18;
            this.labelStartCol.Text = "startColor";
            // 
            // pictBoxStartCol
            // 
            this.pictBoxStartCol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictBoxStartCol.Location = new System.Drawing.Point(1208, 248);
            this.pictBoxStartCol.Name = "pictBoxStartCol";
            this.pictBoxStartCol.Size = new System.Drawing.Size(77, 38);
            this.pictBoxStartCol.TabIndex = 19;
            this.pictBoxStartCol.TabStop = false;
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button7.Location = new System.Drawing.Point(1040, 336);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(153, 71);
            this.button7.TabIndex = 20;
            this.button7.Text = "Выбрать конечный цвет";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.buttonEndCol_Click);
            // 
            // labelEndCol
            // 
            this.labelEndCol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelEndCol.AutoSize = true;
            this.labelEndCol.BackColor = System.Drawing.SystemColors.ControlDark;
            this.labelEndCol.Location = new System.Drawing.Point(1205, 336);
            this.labelEndCol.Name = "labelEndCol";
            this.labelEndCol.Size = new System.Drawing.Size(65, 17);
            this.labelEndCol.TabIndex = 21;
            this.labelEndCol.Text = "endColor";
            // 
            // pictBoxEndCol
            // 
            this.pictBoxEndCol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictBoxEndCol.Location = new System.Drawing.Point(1208, 356);
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
            this.pictBoxSave.Size = new System.Drawing.Size(1062, 701);
            this.pictBoxSave.TabIndex = 24;
            this.pictBoxSave.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1335, 715);
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
    }
}

