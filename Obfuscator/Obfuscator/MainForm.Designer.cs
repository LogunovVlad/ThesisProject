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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SingleLineComment = new System.Windows.Forms.CheckBox();
            this.paramObf = new System.Windows.Forms.GroupBox();
            this.replaceMulti = new System.Windows.Forms.CheckBox();
            this.replaceSingle = new System.Windows.Forms.CheckBox();
            this.MultiLineComment = new System.Windows.Forms.CheckBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabRename = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.GridVariable = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericLengthVar = new System.Windows.Forms.NumericUpDown();
            this.checkRenameVariable = new System.Windows.Forms.CheckBox();
            this.checkEmptyLine = new System.Windows.Forms.CheckBox();
            this.checkReplace = new System.Windows.Forms.CheckBox();
            this.checkTrueRename = new System.Windows.Forms.CheckBox();
            this.shapeContainer3 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.ы = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape3 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.tabComment = new System.Windows.Forms.TabPage();
            this.accessDeleteComment = new System.Windows.Forms.CheckBox();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape2 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.tabWiew = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.buttonPrintMappin = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.paramObf.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabRename.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridVariable)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericLengthVar)).BeginInit();
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
            this.shapeContainer1.Size = new System.Drawing.Size(1197, 585);
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
            this.tabRename.Controls.Add(this.buttonPrintMappin);
            this.tabRename.Controls.Add(this.groupBox2);
            this.tabRename.Controls.Add(this.groupBox1);
            this.tabRename.Controls.Add(this.checkTrueRename);
            this.tabRename.Controls.Add(this.shapeContainer3);
            this.tabRename.Location = new System.Drawing.Point(4, 22);
            this.tabRename.Name = "tabRename";
            this.tabRename.Padding = new System.Windows.Forms.Padding(3);
            this.tabRename.Size = new System.Drawing.Size(859, 402);
            this.tabRename.TabIndex = 0;
            this.tabRename.Text = "Переименование";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.GridVariable);
            this.groupBox2.Location = new System.Drawing.Point(373, 129);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(447, 216);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Таблица переименований";
            // 
            // GridVariable
            // 
            this.GridVariable.AllowUserToDeleteRows = false;
            this.GridVariable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridVariable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.GridVariable.Location = new System.Drawing.Point(6, 19);
            this.GridVariable.Name = "GridVariable";
            this.GridVariable.ReadOnly = true;
            this.GridVariable.RowHeadersVisible = false;
            this.GridVariable.Size = new System.Drawing.Size(427, 191);
            this.GridVariable.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numericLengthVar);
            this.groupBox1.Controls.Add(this.checkRenameVariable);
            this.groupBox1.Controls.Add(this.checkEmptyLine);
            this.groupBox1.Controls.Add(this.checkReplace);
            this.groupBox1.Location = new System.Drawing.Point(39, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 216);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выберите параметры";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Длина переменных";
            // 
            // numericLengthVar
            // 
            this.numericLengthVar.Location = new System.Drawing.Point(6, 97);
            this.numericLengthVar.Name = "numericLengthVar";
            this.numericLengthVar.Size = new System.Drawing.Size(120, 20);
            this.numericLengthVar.TabIndex = 3;
            this.numericLengthVar.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // checkRenameVariable
            // 
            this.checkRenameVariable.AutoSize = true;
            this.checkRenameVariable.Location = new System.Drawing.Point(6, 56);
            this.checkRenameVariable.Name = "checkRenameVariable";
            this.checkRenameVariable.Size = new System.Drawing.Size(180, 17);
            this.checkRenameVariable.TabIndex = 2;
            this.checkRenameVariable.Text = "Переименование переменных";
            this.checkRenameVariable.UseVisualStyleBackColor = true;
            // 
            // checkEmptyLine
            // 
            this.checkEmptyLine.AutoSize = true;
            this.checkEmptyLine.Location = new System.Drawing.Point(6, 134);
            this.checkEmptyLine.Name = "checkEmptyLine";
            this.checkEmptyLine.Size = new System.Drawing.Size(151, 17);
            this.checkEmptyLine.TabIndex = 1;
            this.checkEmptyLine.Text = "Убрать лишние пробелы\r\n";
            this.checkEmptyLine.UseVisualStyleBackColor = true;
            // 
            // checkReplace
            // 
            this.checkReplace.AutoSize = true;
            this.checkReplace.Location = new System.Drawing.Point(6, 33);
            this.checkReplace.Name = "checkReplace";
            this.checkReplace.Size = new System.Drawing.Size(114, 17);
            this.checkReplace.TabIndex = 0;
            this.checkReplace.Text = "Замена констант";
            this.checkReplace.UseVisualStyleBackColor = true;
            // 
            // checkTrueRename
            // 
            this.checkTrueRename.AutoSize = true;
            this.checkTrueRename.Location = new System.Drawing.Point(39, 47);
            this.checkTrueRename.Name = "checkTrueRename";
            this.checkTrueRename.Size = new System.Drawing.Size(171, 17);
            this.checkTrueRename.TabIndex = 1;
            this.checkTrueRename.Text = "Разрешить переименование";
            this.checkTrueRename.UseVisualStyleBackColor = true;
            // 
            // shapeContainer3
            // 
            this.shapeContainer3.Location = new System.Drawing.Point(3, 3);
            this.shapeContainer3.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer3.Name = "shapeContainer3";
            this.shapeContainer3.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.ы,
            this.rectangleShape3});
            this.shapeContainer3.Size = new System.Drawing.Size(853, 396);
            this.shapeContainer3.TabIndex = 0;
            this.shapeContainer3.TabStop = false;
            // 
            // ы
            // 
            this.ы.Location = new System.Drawing.Point(10, 109);
            this.ы.Name = "ы";
            this.ы.Size = new System.Drawing.Size(835, 265);
            // 
            // rectangleShape3
            // 
            this.rectangleShape3.Location = new System.Drawing.Point(9, 10);
            this.rectangleShape3.Name = "rectangleShape3";
            this.rectangleShape3.Size = new System.Drawing.Size(836, 85);
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
            // rectangleShape2
            // 
            this.rectangleShape2.Location = new System.Drawing.Point(10, 109);
            this.rectangleShape2.Name = "rectangleShape2";
            this.rectangleShape2.Size = new System.Drawing.Size(835, 180);
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.Location = new System.Drawing.Point(9, 10);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(836, 85);
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
            this.button2.Click += new System.EventHandler(this.OpenFile);
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
            // buttonPrintMappin
            // 
            this.buttonPrintMappin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrintMappin.Location = new System.Drawing.Point(379, 352);
            this.buttonPrintMappin.Name = "buttonPrintMappin";
            this.buttonPrintMappin.Size = new System.Drawing.Size(213, 23);
            this.buttonPrintMappin.TabIndex = 5;
            this.buttonPrintMappin.Text = "Вывести таблицу переименований";
            this.buttonPrintMappin.UseVisualStyleBackColor = true;
            this.buttonPrintMappin.Click += new System.EventHandler(this.buttonPrintMappin_Click);
            // 
            // Column1
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Column1.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column1.HeaderText = "Имя до переименования";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 210;
            // 
            // Column2
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Column2.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column2.HeaderText = "Имя после переименования";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 210;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 585);
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
            this.tabRename.ResumeLayout(false);
            this.tabRename.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridVariable)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericLengthVar)).EndInit();
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
        private System.Windows.Forms.CheckBox checkTrueRename;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer3;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape ы;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkEmptyLine;
        private System.Windows.Forms.CheckBox checkReplace;
        private System.Windows.Forms.CheckBox checkRenameVariable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericLengthVar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView GridVariable;
        private System.Windows.Forms.Button buttonPrintMappin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}

