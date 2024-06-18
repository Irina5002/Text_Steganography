namespace Text_Steganography.Forms
{
    partial class FormTexts
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtText = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnRefr = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnChoose = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSaveTable = new System.Windows.Forms.Button();
            this.txtChoose = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(404, 269);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtID.Location = new System.Drawing.Point(60, 396);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(140, 26);
            this.txtID.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtName.Location = new System.Drawing.Point(317, 396);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(363, 26);
            this.txtName.TabIndex = 2;
            // 
            // txtText
            // 
            this.txtText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtText.Location = new System.Drawing.Point(22, 428);
            this.txtText.Multiline = true;
            this.txtText.Name = "txtText";
            this.txtText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtText.Size = new System.Drawing.Size(658, 187);
            this.txtText.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(127)))), ((int)(((byte)(149)))));
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.btnInfo);
            this.panel1.Controls.Add(this.btnRefr);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(731, 56);
            this.panel1.TabIndex = 4;
            // 
            // btnClear
            // 
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Image = global::Text_Steganography.Properties.Resources.icons8_ластик_24;
            this.btnClear.Location = new System.Drawing.Point(142, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(58, 50);
            this.btnClear.TabIndex = 4;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::Text_Steganography.Properties.Resources.icons8_лупа_24;
            this.button1.Location = new System.Drawing.Point(402, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 50);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSearch.Location = new System.Drawing.Point(466, 17);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(214, 26);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnInfo
            // 
            this.btnInfo.FlatAppearance.BorderSize = 0;
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Image = global::Text_Steganography.Properties.Resources.icons8_информация_24;
            this.btnInfo.Location = new System.Drawing.Point(12, 6);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(59, 44);
            this.btnInfo.TabIndex = 1;
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnRefr
            // 
            this.btnRefr.FlatAppearance.BorderSize = 0;
            this.btnRefr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefr.Image = global::Text_Steganography.Properties.Resources.icons8_обновление_24;
            this.btnRefr.Location = new System.Drawing.Point(77, 3);
            this.btnRefr.Name = "btnRefr";
            this.btnRefr.Size = new System.Drawing.Size(58, 50);
            this.btnRefr.TabIndex = 0;
            this.btnRefr.UseVisualStyleBackColor = true;
            this.btnRefr.Click += new System.EventHandler(this.btnRefr_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(24, 399);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(224, 399);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Название:";
            // 
            // btnChoose
            // 
            this.btnChoose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(172)))), ((int)(((byte)(189)))));
            this.btnChoose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnChoose.Location = new System.Drawing.Point(466, 69);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(214, 49);
            this.btnChoose.TabIndex = 7;
            this.btnChoose.Text = "Выбрать текст";
            this.btnChoose.UseVisualStyleBackColor = false;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(172)))), ((int)(((byte)(189)))));
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.Location = new System.Drawing.Point(466, 124);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(214, 49);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Добавить текст";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnChange
            // 
            this.btnChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(172)))), ((int)(((byte)(189)))));
            this.btnChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnChange.Location = new System.Drawing.Point(466, 179);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(214, 49);
            this.btnChange.TabIndex = 9;
            this.btnChange.Text = "Изменить текст";
            this.btnChange.UseVisualStyleBackColor = false;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(172)))), ((int)(((byte)(189)))));
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelete.Location = new System.Drawing.Point(466, 234);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(214, 49);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Удалить текст";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSaveTable
            // 
            this.btnSaveTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(172)))), ((int)(((byte)(189)))));
            this.btnSaveTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSaveTable.Location = new System.Drawing.Point(466, 289);
            this.btnSaveTable.Name = "btnSaveTable";
            this.btnSaveTable.Size = new System.Drawing.Size(214, 49);
            this.btnSaveTable.TabIndex = 11;
            this.btnSaveTable.Text = "Сохранить таблицу";
            this.btnSaveTable.UseVisualStyleBackColor = false;
            this.btnSaveTable.Click += new System.EventHandler(this.btnSaveTable_Click);
            // 
            // txtChoose
            // 
            this.txtChoose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtChoose.Location = new System.Drawing.Point(317, 358);
            this.txtChoose.Name = "txtChoose";
            this.txtChoose.Size = new System.Drawing.Size(362, 26);
            this.txtChoose.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(168, 361);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Выбранный текст:";
            // 
            // FormTexts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 627);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtChoose);
            this.Controls.Add(this.btnSaveTable);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormTexts";
            this.Text = "База данных текстов";
            this.Load += new System.EventHandler(this.FormTexts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRefr;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSaveTable;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtChoose;
        private System.Windows.Forms.Label label3;
    }
}