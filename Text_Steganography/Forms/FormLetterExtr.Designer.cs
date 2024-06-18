namespace Text_Steganography.Forms
{
    partial class FormLetterExtr
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExtr = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.копироватьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.выделитьВсеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.копироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вставитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выделитьВсеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оМетодеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обОкнеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.contextMenuStrip2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(29, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "Скрытое сообщение:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(29, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Текст со скрытым сообщением: ";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(172)))), ((int)(((byte)(189)))));
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnClear.Location = new System.Drawing.Point(451, 272);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(254, 52);
            this.btnClear.TabIndex = 23;
            this.btnClear.Text = "Очистить текстовые поля";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnExtr
            // 
            this.btnExtr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(172)))), ((int)(((byte)(189)))));
            this.btnExtr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnExtr.Location = new System.Drawing.Point(33, 272);
            this.btnExtr.Name = "btnExtr";
            this.btnExtr.Size = new System.Drawing.Size(254, 52);
            this.btnExtr.TabIndex = 22;
            this.btnExtr.Text = "Извлечь сообщение";
            this.btnExtr.UseVisualStyleBackColor = false;
            this.btnExtr.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.ContextMenuStrip = this.contextMenuStrip2;
            this.richTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.richTextBox2.Location = new System.Drawing.Point(33, 370);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(672, 89);
            this.richTextBox2.TabIndex = 21;
            this.richTextBox2.Text = "";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.копироватьToolStripMenuItem1,
            this.выделитьВсеToolStripMenuItem1});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(177, 56);
            // 
            // копироватьToolStripMenuItem1
            // 
            this.копироватьToolStripMenuItem1.Name = "копироватьToolStripMenuItem1";
            this.копироватьToolStripMenuItem1.Size = new System.Drawing.Size(176, 26);
            this.копироватьToolStripMenuItem1.Text = "Копировать";
            this.копироватьToolStripMenuItem1.Click += new System.EventHandler(this.копироватьToolStripMenuItem1_Click);
            // 
            // выделитьВсеToolStripMenuItem1
            // 
            this.выделитьВсеToolStripMenuItem1.Name = "выделитьВсеToolStripMenuItem1";
            this.выделитьВсеToolStripMenuItem1.Size = new System.Drawing.Size(176, 26);
            this.выделитьВсеToolStripMenuItem1.Text = "Выделить все";
            this.выделитьВсеToolStripMenuItem1.Click += new System.EventHandler(this.выделитьВсеToolStripMenuItem1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.richTextBox1.Location = new System.Drawing.Point(33, 80);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(672, 175);
            this.richTextBox1.TabIndex = 20;
            this.richTextBox1.Text = "";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.копироватьToolStripMenuItem,
            this.вставитьToolStripMenuItem,
            this.выделитьВсеToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(177, 82);
            // 
            // копироватьToolStripMenuItem
            // 
            this.копироватьToolStripMenuItem.Name = "копироватьToolStripMenuItem";
            this.копироватьToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.копироватьToolStripMenuItem.Text = "Копировать";
            this.копироватьToolStripMenuItem.Click += new System.EventHandler(this.копироватьToolStripMenuItem_Click);
            // 
            // вставитьToolStripMenuItem
            // 
            this.вставитьToolStripMenuItem.Name = "вставитьToolStripMenuItem";
            this.вставитьToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.вставитьToolStripMenuItem.Text = "Вставить";
            this.вставитьToolStripMenuItem.Click += new System.EventHandler(this.вставитьToolStripMenuItem_Click);
            // 
            // выделитьВсеToolStripMenuItem
            // 
            this.выделитьВсеToolStripMenuItem.Name = "выделитьВсеToolStripMenuItem";
            this.выделитьВсеToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.выделитьВсеToolStripMenuItem.Text = "Выделить все";
            this.выделитьВсеToolStripMenuItem.Click += new System.EventHandler(this.выделитьВсеToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.оМетодеToolStripMenuItem,
            this.обОкнеToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(731, 29);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem});
            this.файлToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 25);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // оМетодеToolStripMenuItem
            // 
            this.оМетодеToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.оМетодеToolStripMenuItem.Name = "оМетодеToolStripMenuItem";
            this.оМетодеToolStripMenuItem.Size = new System.Drawing.Size(90, 25);
            this.оМетодеToolStripMenuItem.Text = "О методе";
            this.оМетодеToolStripMenuItem.Click += new System.EventHandler(this.оМетодеToolStripMenuItem_Click);
            // 
            // обОкнеToolStripMenuItem1
            // 
            this.обОкнеToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.обОкнеToolStripMenuItem1.Name = "обОкнеToolStripMenuItem1";
            this.обОкнеToolStripMenuItem1.Size = new System.Drawing.Size(81, 25);
            this.обОкнеToolStripMenuItem1.Text = "Об окне";
            this.обОкнеToolStripMenuItem1.Click += new System.EventHandler(this.обОкнеToolStripMenuItem1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FormLetterExtr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(731, 597);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExtr);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FormLetterExtr";
            this.Text = "Извлечение методом латинских букв";
            this.contextMenuStrip2.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExtr;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem копироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вставитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выделитьВсеToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem копироватьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem выделитьВсеToolStripMenuItem1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem оМетодеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обОкнеToolStripMenuItem1;
    }
}