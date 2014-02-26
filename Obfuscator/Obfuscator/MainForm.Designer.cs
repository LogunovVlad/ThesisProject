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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.таблицаСоответствийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.checkCycles = new System.Windows.Forms.CheckBox();
            this.buttonPrintMappin = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.GridVariable = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkRenameMethod = new System.Windows.Forms.CheckBox();
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
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
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem,
            this.таблицаСоответствийToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            resources.ApplyResources(this.менюToolStripMenuItem, "менюToolStripMenuItem");
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьФайлToolStripMenuItem,
            this.сохранитьToolStripMenuItem1,
            this.выходToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            // 
            // открытьФайлToolStripMenuItem
            // 
            resources.ApplyResources(this.открытьФайлToolStripMenuItem, "открытьФайлToolStripMenuItem");
            this.открытьФайлToolStripMenuItem.Name = "открытьФайлToolStripMenuItem";
            this.открытьФайлToolStripMenuItem.Click += new System.EventHandler(this.OpenFile);
            // 
            // сохранитьToolStripMenuItem1
            // 
            resources.ApplyResources(this.сохранитьToolStripMenuItem1, "сохранитьToolStripMenuItem1");
            this.сохранитьToolStripMenuItem1.Name = "сохранитьToolStripMenuItem1";
            this.сохранитьToolStripMenuItem1.Click += new System.EventHandler(this.сохранитьToolStripMenuItem1_Click);
            // 
            // выходToolStripMenuItem
            // 
            resources.ApplyResources(this.выходToolStripMenuItem, "выходToolStripMenuItem");
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            // 
            // таблицаСоответствийToolStripMenuItem
            // 
            resources.ApplyResources(this.таблицаСоответствийToolStripMenuItem, "таблицаСоответствийToolStripMenuItem");
            this.таблицаСоответствийToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.загрузитьToolStripMenuItem});
            this.таблицаСоответствийToolStripMenuItem.Name = "таблицаСоответствийToolStripMenuItem";
            // 
            // сохранитьToolStripMenuItem
            // 
            resources.ApplyResources(this.сохранитьToolStripMenuItem, "сохранитьToolStripMenuItem");
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // загрузитьToolStripMenuItem
            // 
            resources.ApplyResources(this.загрузитьToolStripMenuItem, "загрузитьToolStripMenuItem");
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            // 
            // richTextBox1
            // 
            resources.ApplyResources(this.richTextBox1, "richTextBox1");
            this.richTextBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SingleLineComment
            // 
            resources.ApplyResources(this.SingleLineComment, "SingleLineComment");
            this.SingleLineComment.Name = "SingleLineComment";
            this.SingleLineComment.UseVisualStyleBackColor = true;
            // 
            // paramObf
            // 
            resources.ApplyResources(this.paramObf, "paramObf");
            this.paramObf.Controls.Add(this.replaceMulti);
            this.paramObf.Controls.Add(this.replaceSingle);
            this.paramObf.Controls.Add(this.MultiLineComment);
            this.paramObf.Controls.Add(this.SingleLineComment);
            this.paramObf.Name = "paramObf";
            this.paramObf.TabStop = false;
            // 
            // replaceMulti
            // 
            resources.ApplyResources(this.replaceMulti, "replaceMulti");
            this.replaceMulti.Name = "replaceMulti";
            this.replaceMulti.UseVisualStyleBackColor = true;
            // 
            // replaceSingle
            // 
            resources.ApplyResources(this.replaceSingle, "replaceSingle");
            this.replaceSingle.Name = "replaceSingle";
            this.replaceSingle.UseVisualStyleBackColor = true;
            // 
            // MultiLineComment
            // 
            resources.ApplyResources(this.MultiLineComment, "MultiLineComment");
            this.MultiLineComment.Name = "MultiLineComment";
            this.MultiLineComment.UseVisualStyleBackColor = true;
            // 
            // richTextBox2
            // 
            resources.ApplyResources(this.richTextBox2, "richTextBox2");
            this.richTextBox2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            // 
            // shapeContainer1
            // 
            resources.ApplyResources(this.shapeContainer1, "shapeContainer1");
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape2
            // 
            resources.ApplyResources(this.lineShape2, "lineShape2");
            this.lineShape2.Name = "lineShape2";
            // 
            // lineShape1
            // 
            resources.ApplyResources(this.lineShape1, "lineShape1");
            this.lineShape1.Name = "lineShape1";
            // 
            // tabControl1
            // 
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Controls.Add(this.tabRename);
            this.tabControl1.Controls.Add(this.tabComment);
            this.tabControl1.Controls.Add(this.tabWiew);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // tabRename
            // 
            resources.ApplyResources(this.tabRename, "tabRename");
            this.tabRename.BackColor = System.Drawing.SystemColors.Control;
            this.tabRename.Controls.Add(this.checkCycles);
            this.tabRename.Controls.Add(this.buttonPrintMappin);
            this.tabRename.Controls.Add(this.groupBox2);
            this.tabRename.Controls.Add(this.groupBox1);
            this.tabRename.Controls.Add(this.checkTrueRename);
            this.tabRename.Controls.Add(this.shapeContainer3);
            this.tabRename.Name = "tabRename";
            // 
            // checkCycles
            // 
            resources.ApplyResources(this.checkCycles, "checkCycles");
            this.checkCycles.Name = "checkCycles";
            this.checkCycles.UseVisualStyleBackColor = true;
            // 
            // buttonPrintMappin
            // 
            resources.ApplyResources(this.buttonPrintMappin, "buttonPrintMappin");
            this.buttonPrintMappin.Name = "buttonPrintMappin";
            this.buttonPrintMappin.UseVisualStyleBackColor = true;
            this.buttonPrintMappin.Click += new System.EventHandler(this.buttonPrintMappin_Click);
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Controls.Add(this.GridVariable);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // GridVariable
            // 
            resources.ApplyResources(this.GridVariable, "GridVariable");
            this.GridVariable.AllowUserToDeleteRows = false;
            this.GridVariable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridVariable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.GridVariable.Name = "GridVariable";
            this.GridVariable.ReadOnly = true;
            this.GridVariable.RowHeadersVisible = false;
            // 
            // Column1
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Column1.DefaultCellStyle = dataGridViewCellStyle3;
            resources.ApplyResources(this.Column1, "Column1");
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Column2.DefaultCellStyle = dataGridViewCellStyle4;
            resources.ApplyResources(this.Column2, "Column2");
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.checkRenameMethod);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numericLengthVar);
            this.groupBox1.Controls.Add(this.checkRenameVariable);
            this.groupBox1.Controls.Add(this.checkEmptyLine);
            this.groupBox1.Controls.Add(this.checkReplace);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // checkRenameMethod
            // 
            resources.ApplyResources(this.checkRenameMethod, "checkRenameMethod");
            this.checkRenameMethod.Name = "checkRenameMethod";
            this.checkRenameMethod.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // numericLengthVar
            // 
            resources.ApplyResources(this.numericLengthVar, "numericLengthVar");
            this.numericLengthVar.Name = "numericLengthVar";
            this.numericLengthVar.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // checkRenameVariable
            // 
            resources.ApplyResources(this.checkRenameVariable, "checkRenameVariable");
            this.checkRenameVariable.Name = "checkRenameVariable";
            this.checkRenameVariable.UseVisualStyleBackColor = true;
            // 
            // checkEmptyLine
            // 
            resources.ApplyResources(this.checkEmptyLine, "checkEmptyLine");
            this.checkEmptyLine.Name = "checkEmptyLine";
            this.checkEmptyLine.UseVisualStyleBackColor = true;
            // 
            // checkReplace
            // 
            resources.ApplyResources(this.checkReplace, "checkReplace");
            this.checkReplace.Name = "checkReplace";
            this.checkReplace.UseVisualStyleBackColor = true;
            // 
            // checkTrueRename
            // 
            resources.ApplyResources(this.checkTrueRename, "checkTrueRename");
            this.checkTrueRename.Name = "checkTrueRename";
            this.checkTrueRename.UseVisualStyleBackColor = true;
            this.checkTrueRename.Click += new System.EventHandler(this.checkTrueRename_Click);
            // 
            // shapeContainer3
            // 
            resources.ApplyResources(this.shapeContainer3, "shapeContainer3");
            this.shapeContainer3.Name = "shapeContainer3";
            this.shapeContainer3.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.ы,
            this.rectangleShape3});
            this.shapeContainer3.TabStop = false;
            // 
            // ы
            // 
            resources.ApplyResources(this.ы, "ы");
            this.ы.Name = "ы";
            // 
            // rectangleShape3
            // 
            resources.ApplyResources(this.rectangleShape3, "rectangleShape3");
            this.rectangleShape3.Name = "rectangleShape3";
            // 
            // tabComment
            // 
            resources.ApplyResources(this.tabComment, "tabComment");
            this.tabComment.BackColor = System.Drawing.SystemColors.Control;
            this.tabComment.Controls.Add(this.accessDeleteComment);
            this.tabComment.Controls.Add(this.paramObf);
            this.tabComment.Controls.Add(this.shapeContainer2);
            this.tabComment.Name = "tabComment";
            // 
            // accessDeleteComment
            // 
            resources.ApplyResources(this.accessDeleteComment, "accessDeleteComment");
            this.accessDeleteComment.Name = "accessDeleteComment";
            this.accessDeleteComment.UseVisualStyleBackColor = true;
            this.accessDeleteComment.CheckedChanged += new System.EventHandler(this.accessDeleteComment_EnabledChanged);
            // 
            // shapeContainer2
            // 
            resources.ApplyResources(this.shapeContainer2, "shapeContainer2");
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape2,
            this.rectangleShape1});
            this.shapeContainer2.TabStop = false;
            // 
            // rectangleShape2
            // 
            resources.ApplyResources(this.rectangleShape2, "rectangleShape2");
            this.rectangleShape2.Name = "rectangleShape2";
            // 
            // rectangleShape1
            // 
            resources.ApplyResources(this.rectangleShape1, "rectangleShape1");
            this.rectangleShape1.Name = "rectangleShape1";
            // 
            // tabWiew
            // 
            resources.ApplyResources(this.tabWiew, "tabWiew");
            this.tabWiew.BackColor = System.Drawing.SystemColors.Control;
            this.tabWiew.Controls.Add(this.label3);
            this.tabWiew.Controls.Add(this.label2);
            this.tabWiew.Controls.Add(this.richTextBox1);
            this.tabWiew.Controls.Add(this.richTextBox2);
            this.tabWiew.Name = "tabWiew";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // button5
            // 
            resources.ApplyResources(this.button5, "button5");
            this.button5.Image = global::Obfuscator.Properties.Resources.obfuscat;
            this.button5.Name = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            resources.ApplyResources(this.button4, "button4");
            this.button4.Image = global::Obfuscator.Properties.Resources.about;
            this.button4.Name = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            resources.ApplyResources(this.button3, "button3");
            this.button3.Image = global::Obfuscator.Properties.Resources.save;
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.сохранитьToolStripMenuItem1_Click);
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Image = global::Obfuscator.Properties.Resources.openFolder;
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.OpenFile);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.tabWiew.PerformLayout();
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
        private System.Windows.Forms.CheckBox checkRenameMethod;
        private System.Windows.Forms.CheckBox checkCycles;
        private System.Windows.Forms.ToolStripMenuItem таблицаСоответствийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}

