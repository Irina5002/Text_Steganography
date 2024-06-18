using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Text_Steganography.TextForms;
using System.Xml.Linq;

namespace Text_Steganography.Forms
{
    //Для статуса строки в таблице
    enum RowState
    {
        Existed,
        New,
        Deleted,
        Modified,
        ModifiedNew
    }
    public partial class FormTexts : Form
    {

        DataBase dataBase = new DataBase();
        int selectedRow;
        string choose_text = "";

        public FormTexts()
        {
            InitializeComponent();
        }

        //То, как в таблице будут отображаться названия атрибутов
        private void CreateColumns()
        {
            dataGridView1.Columns.Add("id", "id");
            dataGridView1.Columns.Add("name_text", "Название");
            dataGridView1.Columns.Add("the_text", "Текст");
            dataGridView1.Columns.Add("IsNew", String.Empty);
        }

        //Очистка текстовых полей
        private void ClearFields()
        {
            txtID.Text = "";
            txtName.Text = "";
            txtText.Text = "";
        }
        private void ReadRow(DataGridView dgw, IDataRecord record) 
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), RowState.ModifiedNew);
        }

        //Обновление таблицы
        private void RefreshDGV(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string queryString = $"select * from text_db";
            SqlCommand command = new SqlCommand(queryString, dataBase.getConnection());
            dataBase.openConnection();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read()) 
            {
                ReadRow(dgw, reader);
            }
            reader.Close();
        }

        //При открытии этого окна отображается таблица
        private void FormTexts_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDGV(dataGridView1);
        }

        //При нажатии на строчку в таблице - передаются её данные в текстовые поля
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if(e.RowIndex >= 0) 
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];
                txtID.Text = row.Cells[0].Value.ToString();
                txtName.Text = row.Cells[1].Value.ToString();
                txtText.Text = row.Cells[2].Value.ToString();
            }
        }

        private void btnRefr_Click(object sender, EventArgs e)
        {
            RefreshDGV(dataGridView1);
            ClearFields();
        }

        //Открытие окна для добавления нового текста
        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormTextAdd textAdd = new FormTextAdd();
            textAdd.Show();
        }

        //Поиск
        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string searchString = $"select * from text_db where concat (id, name_text, the_text) like '%" + txtSearch.Text + "%'";
            SqlCommand com = new SqlCommand(searchString, dataBase.getConnection());
            dataBase.openConnection();
            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read()) 
            {
                ReadRow(dgw, reader);
            }
            reader.Close();
        }

        //Удаление текста
        private void DeleteRow()
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows[index].Visible = false;
            if (dataGridView1.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridView1.Rows[index].Cells[3].Value = RowState.Deleted;
            }
            dataGridView1.Rows[index].Cells[3].Value = RowState.Deleted;
        }

        //Обновление таблицы - необходимо при удалении и изменении текста
        private void Update()
        {
            dataBase.openConnection();
            for(int index = 0; index < dataGridView1.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridView1.Rows[index].Cells[3].Value;
                if (rowState == RowState.Existed)
                    continue;
                if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
                    var deleteQuery = $"delete from text_db where id = {id}";
                    var command = new SqlCommand(deleteQuery, dataBase.getConnection());
                    command.ExecuteNonQuery();
                }

                if(rowState == RowState.Modified)
                {
                    var id = dataGridView1.Rows[index].Cells[0].Value.ToString();
                    var name = dataGridView1.Rows[index].Cells[1].Value.ToString();
                    var text = dataGridView1.Rows[index].Cells[2].Value.ToString();

                    var changeQuery = $"update text_db set name_text = '{name}', the_text = '{text}' where id = '{id}'";
                    var command = new SqlCommand(changeQuery, dataBase.getConnection());
                    command.ExecuteNonQuery();
                }
            }
            dataBase.closeConnection();
        }

        //Изменение текста
        private void Change()
        {
            var selectedRowIndex = dataGridView1.CurrentCell.RowIndex;
            var id = txtID.Text;
            var name = txtName.Text;
            var text = txtText.Text;
            if (dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                dataGridView1.Rows[selectedRowIndex].SetValues(id, name, text);
                dataGridView1.Rows[selectedRowIndex].Cells[3].Value = RowState.Modified;
            }
            
        }

        //Отображение выбранного текста
        public void Choose() 
        {
            DataGridViewRow row = dataGridView1.Rows[selectedRow];
            choose_text = row.Cells[2].Value.ToString();
            txtChoose.Text = choose_text;
        }

        //Запоминание выбранного текста
        private void ChooseText()
        {
            dataBase.openConnection();
            var text = txtChoose.Text;
            var chooseQuery = $"update text_choose set the_text_choose = '{text}' where id = '{1}'";
            var command = new SqlCommand(chooseQuery, dataBase.getConnection());
            command.ExecuteNonQuery();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView1);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteRow();
            ClearFields();
        }

        private void btnSaveTable_Click(object sender, EventArgs e)
        {
            Update();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            Change();
            ClearFields();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        public void btnChoose_Click(object sender, EventArgs e)
        {
            Choose();
            ChooseText();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Перед вами открылось окно, где представлена база данных текстов, которые можно использовать при скртыии сообщения в обоих методов. Вы можете ознакомиться с каждым текстом, нажав на соответствующую строку в таблице. Вы так же можете изменить текст, удалить текст и добавть собственный. После удаления и изменения, необходимо нажать на кнопку сохранить, чтобы зафиксировать данные действия в БД, после чего обновить таблицу с помощью кнопки сверху в виде круговой стрелки. Вы так же можете очистить все текстовые поля после таблицы, нажав на иконку ластика в верхней части панели. При создании нового текста откроется новое окно, где вы можете ввести название этого текста и сам текст. Если вы хотите вставлять в методы какой-то другой текст из базы данных, то нажмите на соответствующий текс, после чего нажмите на кнопку Выбрать текст. Вы можете проверить это, посмотрев на самое верхнее текстовое поле, где отображается текущий выбранный текст. Так же вы можете воспользоваться поиском, для чего начните вводить искомые данные в текстовое поле на панели сверху.\r\n ", "Об окне", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

  
    }
}
