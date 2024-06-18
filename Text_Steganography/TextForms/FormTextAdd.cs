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

namespace Text_Steganography.TextForms
{
    public partial class FormTextAdd : Form
    {
        DataBase dataBase = new DataBase();

        public FormTextAdd()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterParent;
        }

        //Сохранение в БД текста
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {   
                dataBase.openConnection();
                var name = txtName_2.Text; //Название
                var text = txtText_2.Text; //Сам текст

                var addQuery = $"insert into text_db (name_text, the_text) values ('{name}','{text}')"; //Наименование данных атрибутов в БД
                var command = new SqlCommand(addQuery, dataBase.getConnection());
                command.ExecuteNonQuery();
                MessageBox.Show("Текст успешно добавлен.","", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }

            dataBase.closeConnection();
        }

    }
}
