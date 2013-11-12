namespace Obfuscator
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SingleLineComment = new System.Windows.Forms.CheckBox();
            this.paramObf = new System.Windows.Forms.GroupBox();
            this.MultiLineComment = new System.Windows.Forms.CheckBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabRename = new System.Windows.Forms.TabPage();
            this.tabComment = new System.Windows.Forms.TabPage();
            this.tabWiew = new System.Windows.Forms.TabPage();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape2 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.replaceSingle = new System.Windows.Forms.CheckBox();
            this.replaceMulti = new System.Windows.Forms.CheckBox();
            this.accessDeleteComment = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.paramObf.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabComment.SuspendLayout();
            this.tabWiew.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1197, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьФайлToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // открытьФайлToolStripMenuItem
            // 
            this.открытьФайлToolStripMenuItem.Name = "открытьФайлToolStripMenuItem";
            this.открытьФайлToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.открытьФайлToolStripMenuItem.Text = "Открыть файл";
            this.открытьФайлToolStripMenuItem.Click += new System.EventHandler(this.OpenFile);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(50, 31);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(370, 356);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(827, 538);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SingleLineComment
            // 
            this.SingleLineComment.AutoSize = true;
            this.SingleLineComment.Location = new System.Drawing.Point(6, 29);
            this.SingleLineComment.Name = "SingleLineComment";
            this.SingleLineComment.Size = new System.Drawing.Size(216, 17);
            this.SingleLineComment.TabIndex = 3;
            this.SingleLineComment.Text = "Удалять однострочные комментарии";
            this.SingleLineComment.UseVisualStyleBackColor = true;
            // 
            // paramObf
            // 
            this.paramObf.Controls.Add(this.replaceMulti);
            this.paramObf.Controls.Add(this.replaceSingle);
            this.paramObf.Controls.Add(this.MultiLineComment);
            this.paramObf.Controls.Add(this.SingleLineComment);
            this.paramObf.Enabled = false;
            this.paramObf.Location = new System.Drawing.Point(33, 134);
            this.paramObf.Name = "paramObf";
            this.paramObf.Size = new System.Drawing.Size(321, 130);
            this.paramObf.TabIndex = 4;
            this.paramObf.TabStop = false;
            this.paramObf.Text = "Выбрать параметры";
            // 
            // MultiLineComment
            // 
            this.MultiLineComment.AutoSize = true;
            this.MultiLineComment.Location = new System.Drawing.Point(6, 52);
            this.MultiLineComment.Name = "MultiLineComment";
            this.MultiLineComment.Size = new System.Drawing.Size(223, 17);
            this.MultiLineComment.TabIndex = 4;
            this.MultiLineComment.Text = "Удалять многострочные комментарии";
            this.MultiLineComment.UseVisualStyleBackColor = true;
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.richTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox2.Location = new System.Drawing.Point(458, 31);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(377, 356);
            this.richTextBox2.TabIndex = 5;
            this.richTextBox2.Text = "";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1197, 566);
            this.shapeContainer1.TabIndex = 6;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 0;
            this.lineShape2.X2 = 1184;
            this.lineShape2.Y1 = 93;
            this.lineShape2.Y2 = 93;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 98;
            this.lineShape1.X2 = 98;
            this.lineShape1.Y1 = 93;
            this.lineShape1.Y2 = 512;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabRename);
            this.tabControl1.Controls.Add(this.tabComment);
            this.tabControl1.Controls.Add(this.tabWiew);
            this.tabControl1.Location = new System.Drawing.Point(112, 104);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(867, 428);
            this.tabControl1.TabIndex = 8;
            // 
            // tabRename
            // 
            this.tabRename.BackColor = System.Drawing.SystemColors.Control;
            this.tabRename.Location = new System.Drawing.Point(4, 22);
            this.tabRename.Name = "tabRename";
            this.tabRename.Padding = new System.Windows.Forms.Padding(3);
            this.tabRename.Size = new System.Drawing.Size(859, 402);
            this.tabRename.TabIndex = 0;
            this.tabRename.Text = "Переименование";
            // 
            // tabComment
            // 
            this.tabComment.BackColor = System.Drawing.SystemColors.Control;
            this.tabComment.Controls.Add(this.accessDeleteComment);
            this.tabComment.Controls.Add(this.paramObf);
            this.tabComment.Controls.Add(this.shapeContainer2);
            this.tabComment.Location = new System.Drawing.Point(4, 22);
            this.tabComment.Name = "tabComment";
            this.tabComment.Padding = new System.Windows.Forms.Padding(3);
            this.tabComment.Size = new System.Drawing.Size(859, 402);
            this.tabComment.TabIndex = 1;
            this.tabComment.Text = "Комментарии";
            // 
            // tabWiew
            // 
            this.tabWiew.BackColor = System.Drawing.SystemColors.Control;
            this.tabWiew.Controls.Add(this.richTextBox1);
            this.tabWiew.Controls.Add(this.richTextBox2);
            this.tabWiew.Location = new System.Drawing.Point(4, 22);
            this.tabWiew.Name = "tabWiew";
            this.tabWiew.Padding = new System.Windows.Forms.Padding(3);
            this.tabWiew.Size = new System.Drawing.Size(859, 402);
            this.tabWiew.TabIndex = 2;
            this.tabWiew.Text = "Предварительный просмотр";
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(3, 3);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape2,
            this.rectangleShape1});
            this.shapeContainer2.Size = new System.Drawing.Size(853, 396);
            this.shapeContainer2.TabIndex = 5;
            this.shapeContainer2.TabStop = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.Location = new System.Drawing.Point(9, 10);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(836, 85);
            // 
            // rectangleShape2
            // 
            this.rectangleShape2.Location = new System.Drawing.Point(10, 109);
            this.rectangleShape2.Name = "rectangleShape2";
            this.rectangleShape2.Size = new System.Drawing.Size(835, 180);
            // 
            // replaceSingle
            // 
            this.replaceSingle.AutoSize = true;
            this.replaceSingle.Location = new System.Drawing.Point(6, 75);
            this.replaceSingle.Name = "replaceSingle";
            this.replaceSingle.Size = new System.Drawing.Size(297, 17);
            this.replaceSingle.TabIndex = 5;
            this.replaceSingle.Text = "Замена однострочных комментариев на нечитаемые";
            this.replaceSingle.UseVisualStyleBackColor = true;
            // 
            // replaceMulti
            // 
            this.replaceMulti.AutoSize = true;
            this.replaceMulti.Location = new System.Drawing.Point(6, 99);
            this.replaceMulti.Name = "replaceMulti";
            this.replaceMulti.Size = new System.Drawing.Size(304, 17);
            this.replaceMulti.TabIndex = 6;
            this.replaceMulti.Text = "Замена многострочных комментариев на нечитаемые";
            this.replaceMulti.UseVisualStyleBackColor = true;
            // 
            // accessDeleteComment
            // 
            this.accessDeleteComment.AutoSize = true;
            this.accessDeleteComment.Location = new System.Drawing.Point(39, 47);
            this.accessDeleteComment.Name = "accessDeleteComment";
            this.accessDeleteComment.Size = new System.Drawing.Size(210, 17);
            this.accessDeleteComment.TabIndex = 6;
            this.accessDeleteComment.Text = "Разрешить удаление комментариев";
            this.accessDeleteComment.UseVisualStyleBackColor = true;
            this.accessDeleteComment.CheckedChanged += new System.EventHandler(this.accessDeleteComment_EnabledChanged);
            // 
            // button2
            // 
            this.button2.Image = global::Obfuscator.Properties.Resources.openFolder;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(3, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 58);
            this.button2.TabIndex = 9;
            this.button2.Text = "Открыть";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Image = global::Obfuscator.Properties.Resources.save;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.Location = new System.Drawing.Point(95, 27);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 58);
            this.button3.TabIndex = 10;
            this.button3.Text = "Сохранить";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Image = global::Obfuscator.Properties.Resources.about;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.Location = new System.Drawing.Point(187, 27);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(86, 58);
            this.button4.TabIndex = 11;
            this.button4.Text = "О программе";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Image = global::Obfuscator.Properties.Resources.obfuscat;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button5.Location = new System.Drawing.Point(3, 104);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(86, 58);
            this.button5.TabIndex = 12;
            this.button5.Text = "Обфускация";
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 566);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.shapeContainer1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.paramObf.ResumeLayout(false);
            this.paramObf.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabComment.ResumeLayout(false);
            this.tabComment.PerformLayout();
            this.tabWiew.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьФайлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox paramObf;
        public System.Windows.Forms.CheckBox SingleLineComment;
        public System.Windows.Forms.CheckBox MultiLineComment;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabRename;
        private System.Windows.Forms.TabPage tabComment;
        private System.Windows.Forms.TabPage tabWiew;
        private System.Windows.Forms.CheckBox replaceMulti;
        private System.Windows.Forms.CheckBox replaceSingle;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape2;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.CheckBox accessDeleteComment;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

