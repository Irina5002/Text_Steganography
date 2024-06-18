namespace Text_Steganography
{
    partial class FormMainMenu
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnStegano = new System.Windows.Forms.Button();
            this.btnText = new System.Windows.Forms.Button();
            this.btnLetterExtr = new System.Windows.Forms.Button();
            this.btnLetter = new System.Windows.Forms.Button();
            this.btnSpaceExtr = new System.Windows.Forms.Button();
            this.btnSpace = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(172)))), ((int)(((byte)(189)))));
            this.panelMenu.Controls.Add(this.btnAbout);
            this.panelMenu.Controls.Add(this.btnStegano);
            this.panelMenu.Controls.Add(this.btnText);
            this.panelMenu.Controls.Add(this.btnLetterExtr);
            this.panelMenu.Controls.Add(this.btnLetter);
            this.panelMenu.Controls.Add(this.btnSpaceExtr);
            this.panelMenu.Controls.Add(this.btnSpace);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(227, 726);
            this.panelMenu.TabIndex = 0;
            // 
            // btnAbout
            // 
            this.btnAbout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAbout.FlatAppearance.BorderSize = 0;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAbout.ForeColor = System.Drawing.Color.Black;
            this.btnAbout.Image = global::Text_Steganography.Properties.Resources.icons8_информация_50;
            this.btnAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbout.Location = new System.Drawing.Point(0, 435);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(227, 60);
            this.btnAbout.TabIndex = 7;
            this.btnAbout.Text = "О программе";
            this.btnAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnStegano
            // 
            this.btnStegano.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStegano.FlatAppearance.BorderSize = 0;
            this.btnStegano.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStegano.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStegano.ForeColor = System.Drawing.Color.Black;
            this.btnStegano.Image = global::Text_Steganography.Properties.Resources.icons8_открытая_книга_50;
            this.btnStegano.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStegano.Location = new System.Drawing.Point(0, 375);
            this.btnStegano.Name = "btnStegano";
            this.btnStegano.Size = new System.Drawing.Size(227, 60);
            this.btnStegano.TabIndex = 6;
            this.btnStegano.Text = "О стеганографии";
            this.btnStegano.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStegano.UseVisualStyleBackColor = true;
            this.btnStegano.Click += new System.EventHandler(this.btnStegano_Click);
            // 
            // btnText
            // 
            this.btnText.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnText.FlatAppearance.BorderSize = 0;
            this.btnText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnText.ForeColor = System.Drawing.Color.Black;
            this.btnText.Image = global::Text_Steganography.Properties.Resources.icons8_текст_50;
            this.btnText.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnText.Location = new System.Drawing.Point(0, 315);
            this.btnText.Name = "btnText";
            this.btnText.Size = new System.Drawing.Size(227, 60);
            this.btnText.TabIndex = 5;
            this.btnText.Text = "Тексты";
            this.btnText.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnText.UseVisualStyleBackColor = true;
            this.btnText.Click += new System.EventHandler(this.btnText_Click);
            // 
            // btnLetterExtr
            // 
            this.btnLetterExtr.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLetterExtr.FlatAppearance.BorderSize = 0;
            this.btnLetterExtr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLetterExtr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLetterExtr.ForeColor = System.Drawing.Color.Black;
            this.btnLetterExtr.Image = global::Text_Steganography.Properties.Resources.icons8_разблокировать_50;
            this.btnLetterExtr.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLetterExtr.Location = new System.Drawing.Point(0, 255);
            this.btnLetterExtr.Name = "btnLetterExtr";
            this.btnLetterExtr.Size = new System.Drawing.Size(227, 60);
            this.btnLetterExtr.TabIndex = 4;
            this.btnLetterExtr.Text = "Латиница";
            this.btnLetterExtr.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLetterExtr.UseVisualStyleBackColor = true;
            this.btnLetterExtr.Click += new System.EventHandler(this.btnLetterExtr_Click);
            // 
            // btnLetter
            // 
            this.btnLetter.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLetter.FlatAppearance.BorderSize = 0;
            this.btnLetter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLetter.ForeColor = System.Drawing.Color.Black;
            this.btnLetter.Image = global::Text_Steganography.Properties.Resources.icons8_замок_50__1_;
            this.btnLetter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLetter.Location = new System.Drawing.Point(0, 195);
            this.btnLetter.Name = "btnLetter";
            this.btnLetter.Size = new System.Drawing.Size(227, 60);
            this.btnLetter.TabIndex = 3;
            this.btnLetter.Text = "Латиница";
            this.btnLetter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLetter.UseVisualStyleBackColor = true;
            this.btnLetter.Click += new System.EventHandler(this.btnLetter_Click);
            // 
            // btnSpaceExtr
            // 
            this.btnSpaceExtr.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSpaceExtr.FlatAppearance.BorderSize = 0;
            this.btnSpaceExtr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpaceExtr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSpaceExtr.ForeColor = System.Drawing.Color.Black;
            this.btnSpaceExtr.Image = global::Text_Steganography.Properties.Resources.icons8_разблокировать_50;
            this.btnSpaceExtr.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSpaceExtr.Location = new System.Drawing.Point(0, 135);
            this.btnSpaceExtr.Name = "btnSpaceExtr";
            this.btnSpaceExtr.Size = new System.Drawing.Size(227, 60);
            this.btnSpaceExtr.TabIndex = 2;
            this.btnSpaceExtr.Text = "Пробелы";
            this.btnSpaceExtr.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSpaceExtr.UseVisualStyleBackColor = true;
            this.btnSpaceExtr.Click += new System.EventHandler(this.btnSpaceExtr_Click);
            // 
            // btnSpace
            // 
            this.btnSpace.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSpace.FlatAppearance.BorderSize = 0;
            this.btnSpace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSpace.ForeColor = System.Drawing.Color.Black;
            this.btnSpace.Image = global::Text_Steganography.Properties.Resources.icons8_замок_50__1_;
            this.btnSpace.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSpace.Location = new System.Drawing.Point(0, 75);
            this.btnSpace.Name = "btnSpace";
            this.btnSpace.Size = new System.Drawing.Size(227, 60);
            this.btnSpace.TabIndex = 1;
            this.btnSpace.Text = "Пробелы";
            this.btnSpace.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSpace.UseVisualStyleBackColor = true;
            this.btnSpace.Click += new System.EventHandler(this.btnSpace_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(127)))), ((int)(((byte)(149)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 75);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 75);
            this.label1.TabIndex = 0;
            this.label1.Text = "Текстовая стеганография";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelDesktop
            // 
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(227, 75);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(751, 651);
            this.panelDesktop.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(172)))), ((int)(((byte)(189)))));
            this.panel2.Controls.Add(this.lblTitle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(227, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(751, 75);
            this.panel2.TabIndex = 2;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(751, 75);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Добро пожаловать!";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 726);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelMenu);
            this.Name = "FormMainMenu";
            this.Text = "Текстовая стеганография";
            this.panelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnSpace;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnStegano;
        private System.Windows.Forms.Button btnText;
        private System.Windows.Forms.Button btnLetter;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnLetterExtr;
        private System.Windows.Forms.Button btnSpaceExtr;
        private System.Windows.Forms.Label label1;
    }
}

