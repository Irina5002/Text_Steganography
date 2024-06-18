namespace Text_Steganography.Forms
{
    partial class FormSpaceHide
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вставтьТекстToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnHide = new System.Windows.Forms.Button();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.копирToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выделитьВсеToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.копироватьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.вставитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.выделитьВсеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.копироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вставитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выделитьВсеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.оМетодеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обОкнеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip3.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.оМетодеToolStripMenuItem,
            this.обОкнеToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(731, 29);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.вставтьТекстToolStripMenuItem});
            this.файлToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.файлToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 25);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // вставтьТекстToolStripMenuItem
            // 
            this.вставтьТекстToolStripMenuItem.Name = "вставтьТекстToolStripMenuItem";
            this.вставтьТекстToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.вставтьТекстToolStripMenuItem.Text = "Вставить текст";
            this.вставтьТекстToolStripMenuItem.Click += new System.EventHandler(this.вставитьТекстToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(30, 419);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(345, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Полученный текст со скрытым сообщением:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(30, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(324, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Сообщение, которое необходимо скрыть:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(30, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Текст, в котором будет скрываться сообщение: ";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(172)))), ((int)(((byte)(189)))));
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnClear.Location = new System.Drawing.Point(452, 354);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(254, 52);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Очистить текстовые поля";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnHide
            // 
            this.btnHide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(172)))), ((int)(((byte)(189)))));
            this.btnHide.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnHide.FlatAppearance.BorderSize = 0;
            this.btnHide.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnHide.Location = new System.Drawing.Point(30, 354);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(254, 52);
            this.btnHide.TabIndex = 13;
            this.btnHide.Text = "Скрыть сообщение";
            this.btnHide.UseVisualStyleBackColor = false;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // richTextBox3
            // 
            this.richTextBox3.ContextMenuStrip = this.contextMenuStrip3;
            this.richTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.richTextBox3.Location = new System.Drawing.Point(34, 442);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.ReadOnly = true;
            this.richTextBox3.Size = new System.Drawing.Size(675, 131);
            this.richTextBox3.TabIndex = 12;
            this.richTextBox3.Text = "";
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contextMenuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.копирToolStripMenuItem,
            this.выделитьВсеToolStripMenuItem2});
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new System.Drawing.Size(177, 56);
            // 
            // копирToolStripMenuItem
            // 
            this.копирToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.копирToolStripMenuItem.Name = "копирToolStripMenuItem";
            this.копирToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.копирToolStripMenuItem.Text = "Копировать";
            this.копирToolStripMenuItem.Click += new System.EventHandler(this.копирToolStripMenuItem_Click);
            // 
            // выделитьВсеToolStripMenuItem2
            // 
            this.выделитьВсеToolStripMenuItem2.Name = "выделитьВсеToolStripMenuItem2";
            this.выделитьВсеToolStripMenuItem2.Size = new System.Drawing.Size(176, 26);
            this.выделитьВсеToolStripMenuItem2.Text = "Выделить все";
            this.выделитьВсеToolStripMenuItem2.Click += new System.EventHandler(this.выделитьВсеToolStripMenuItem2_Click);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.копироватьToolStripMenuItem1,
            this.вставитьToolStripMenuItem1,
            this.выделитьВсеToolStripMenuItem1});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(177, 82);
            // 
            // копироватьToolStripMenuItem1
            // 
            this.копироватьToolStripMenuItem1.Name = "копироватьToolStripMenuItem1";
            this.копироватьToolStripMenuItem1.Size = new System.Drawing.Size(176, 26);
            this.копироватьToolStripMenuItem1.Text = "Копировать";
            this.копироватьToolStripMenuItem1.Click += new System.EventHandler(this.копироватьToolStripMenuItem1_Click);
            // 
            // вставитьToolStripMenuItem1
            // 
            this.вставитьToolStripMenuItem1.Name = "вставитьToolStripMenuItem1";
            this.вставитьToolStripMenuItem1.Size = new System.Drawing.Size(176, 26);
            this.вставитьToolStripMenuItem1.Text = "Вставить";
            this.вставитьToolStripMenuItem1.Click += new System.EventHandler(this.вставитьToolStripMenuItem1_Click);
            // 
            // выделитьВсеToolStripMenuItem1
            // 
            this.выделитьВсеToolStripMenuItem1.Name = "выделитьВсеToolStripMenuItem1";
            this.выделитьВсеToolStripMenuItem1.Size = new System.Drawing.Size(176, 26);
            this.выделитьВсеToolStripMenuItem1.Text = "Выделить все";
            this.выделитьВсеToolStripMenuItem1.Click += new System.EventHandler(this.выделитьВсеToolStripMenuItem1_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.ContextMenuStrip = this.contextMenuStrip2;
            this.richTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.richTextBox2.Location = new System.Drawing.Point(30, 245);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(676, 82);
            this.richTextBox2.TabIndex = 11;
            this.richTextBox2.Text = "";
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
            // richTextBox1
            // 
            this.richTextBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.richTextBox1.Location = new System.Drawing.Point(34, 71);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(672, 131);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
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
            // FormSpaceHide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(731, 597);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnHide);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormSpaceHide";
            this.Text = "Скрытие методом пробелов";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip3.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem копироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вставитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выделитьВсеToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem копироватьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem выделитьВсеToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem вставтьТекстToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вставитьToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
        private System.Windows.Forms.ToolStripMenuItem копирToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выделитьВсеToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem оМетодеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обОкнеToolStripMenuItem1;
    }
}