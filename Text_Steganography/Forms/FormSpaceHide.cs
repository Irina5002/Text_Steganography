using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Net.Mime.MediaTypeNames;

namespace Text_Steganography.Forms
{
    public partial class FormSpaceHide : Form
    {
        DataBase dataBase = new DataBase();
        string path = "";
        public FormSpaceHide()
        {
            InitializeComponent();
            //Используемые форматы для сохранения и открытия
            openFileDialog1.FileName = @"Новый файл.rtf";
            saveFileDialog1.Filter = "RTF Files(*.rtf)|*.rtf|All files(*.*)|*.*";
            openFileDialog1.Filter = "RTF Files(*.rtf)|*.rtf|Text File(*.txt)|*.txt|All files(*.*)|*.*";
        }

        //Обработка нажатия на кнопку "Скрыть текст".
        private void btnHide_Click(object sender, EventArgs e)
        {
            richTextBox3.Clear();


            string b = richTextBox1.Text;
            //Обработка ошибок. При отсутствии ошибок текст скрывается. 
            if (b.IndexOf("  ") > -1)
            {
                //Предложение изменения текста для корректной работы, если изначальный не соответствует требованиям.
                DialogResult result = MessageBox.Show("Больше одного пробела, программа не может продолжить работу. Изменить текст?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {

                    bool nonSpace = b.Any(cc => !char.IsWhiteSpace(cc));

                    if (!nonSpace)
                    {
                        MessageBox.Show("Текст состоит только из пробелов и не содержит знаков.");
                    }
                    else
                    {
                        char[] c = b.ToArray();
                        int j = 0;
                        for (int i = 0; i < c.Length - 1; i++)
                        {
                            if ((c[i] == ' ') && (c[i + 1] == ' ') && (j < c.Length))
                            {
                                continue;
                            }
                            c[j] = c[i];
                            j++;
                        }
                        Array.Resize(ref c, j);
                        richTextBox1.Clear();
                        for (int i = 0; i < c.Length; i++)
                        {
                            richTextBox1.Text += c[i].ToString();
                        }

                        MessageBox.Show("Текст изменен.");
                    }

                }
            }
            else if (richTextBox2.Text == "")
            {
                MessageBox.Show("Нет сообщения для скрытия.");
            }
            //Скрытие текста. Отображение измененного текста в третье тексотовое поле. 
            else
            {

                char[] c = b.ToArray();
                int sch = 0;
                string eb = bin(richTextBox2.Text);
                char[] d = eb.ToArray();
                string[] f = null;
                Array.Resize(ref f, c.Length);

                for (int i = 0; i < c.Length; i++)
                {
                    f[i] = new string(c[i], 1);
                }

                int j = -1;

                for (int i = 0; i < f.Length; i++)
                {
                    if (f[i] == " ")
                    {
                        sch++;
                        j++;
                        if ((j < d.Length) && (d[j] == '1'))
                        {
                            f[i] = "  ";

                        }
                        else if (j == d.Length)
                        {
                            break;
                        }
                    }
                }

                //Обработка ошибки, если пробелов не хватает для скрытия информации.
                if (d.Length > sch)
                {

                    DialogResult result = MessageBox.Show("Изначального текста не хватает для того, чтобы скрыть сообщение. Необходимое число пробелов: " + d.Length + ". На данный момент количество пробелов составляет: " + sch + ". Все равно продолжить?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        for (int i = 0; i < f.Length; i++)
                        {
                            richTextBox3.Text += f[i].ToString();
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < f.Length; i++)
                    {
                        richTextBox3.Text += f[i].ToString();
                    }
                }

            }

        }

        //Представление текста, который необходимо скрыть, в двоичной системе.
        public string bin(string inp)
        {
            StringBuilder sb = new StringBuilder();
            foreach (byte by in System.Text.Encoding.Default.GetBytes(richTextBox2.Text))
            {
                sb.Append(Convert.ToString(by, 2).PadLeft(8, '0'));
            }
            return sb.ToString();
        }

        //Обработка кнопки "Очистить текстовые поля".
        private void btnClear_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox2.Clear();
            richTextBox3.Clear();
        }

        //Обработка кнопки в меню "Открыть". Позволяет открыть текстовый файл, текст из которого записывается в первое текстовое поле.
        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                openFileDialog1.DefaultExt = "*.rtf";
                openFileDialog1.Filter = "All Files(*.*)|*.*|Text Files(*txt)|*.txt|Text Files(*rtf)|*.rtf";

                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
                   openFileDialog1.FileName.Length > 0)
                {
                    try
                    {
                        path = openFileDialog1.FileName;
                        richTextBox1.LoadFile(path, RichTextBoxStreamType.RichText);

                    }
                    catch
                    {
                        string ft = System.IO.File.ReadAllText(path);
                        richTextBox1.Text = ft;

                    }

                }
            }
        }

        //Обработка кнопки в меню "Сохранить". Позволяет сохранить измененный текст со скрытой информацией из третьего текстового поля.
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    path = saveFileDialog1.FileName;
                    richTextBox3.SaveFile(path);


                }
            }
            catch { }
        }

        private void обОкнеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Перед вами открылось окно с тремя полями для текста, двумя кнопками и меню в верхней части. Первое поле предназначено для текста, куда программа будет скрывать сообщение. Второе – для сообщения, которое вы хотите скрыть. После нажатия на кнопку «Скрыть текст» изначальный текст из первой формы перейдет в третью вместе со скрытым сообщением. При нажатии на кнопку «Очистить текстовые поля» очистятся все три текстовых поля.\r\nПри нажатии на «Файл» откроется меню, которое предложит вам несколько действий. «Открыть» – откроет текстовый файл в первое поле. «Сохранить» – предложит сохранить текст из третьего поля в файл. «Вставить текст» - добавит в первое поле текст, который выбран в базе данных. «Об окне» – вы уже тут.\r\nТакже для каждого текстового поля существует контекстное меню, которое можно вызвать нажатием на правую кнопку мыши.\r\nПосле нажатии на кнопку «Скрыть текст» программа проверит текст на наличие несоответствий условиям корректной работы программы и выведет сообщения при их наличии. \r\n ", "Об окне", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void копироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void вставитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void выделитьВсеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void копироватьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox2.Copy();
        }

        private void выделитьВсеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox2.SelectAll();
        }

        //Позволяет вставить в первое текстовое поле текст, который был до этого выбран из базы данных
        private void вставитьТекстToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                dataBase.openConnection();
                var chooseQuery = "SELECT the_text_choose FROM text_choose WHERE id = 1";
                var command = new SqlCommand(chooseQuery, dataBase.getConnection());
                var reader = command.ExecuteReader();

                if (reader.Read())
                {
                    var text = reader["the_text_choose"].ToString();
                    richTextBox1.Text = text;
                    MessageBox.Show("Текст успешно добавлен.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Запись не найдена.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
            dataBase.closeConnection();
        }

        private void вставитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox2.Paste();
        }

        private void копирToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox3.Copy();
        }

        private void выделитьВсеToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            richTextBox3.SelectAll();
        }

        private void обОкнеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Перед вами открылось окно с тремя полями для текста, двумя кнопками и меню в верхней части. Первое поле предназначено для текста, куда программа будет скрывать сообщение. Второе – для сообщения, которое вы хотите скрыть. После нажатия на кнопку «Скрыть текст» изначальный текст из первой формы перейдет в третью вместе со скрытым сообщением. При нажатии на кнопку «Очистить текстовые поля» очистятся все три текстовых поля.\r\nПри нажатии на «Файл» откроется меню, которое предложит вам несколько действий. «Открыть» – откроет текстовый файл в первое поле. «Сохранить» – предложит сохранить текст из третьего поля в файл. «Вставить текст» - добавит в первое поле текст, который выбран в базе данных. «Об окне» – вы уже тут.\r\nТакже для каждого текстового поля существует контекстное меню, которое можно вызвать нажатием на правую кнопку мыши.\r\nПосле нажатии на кнопку «Скрыть текст» программа проверит текст на наличие несоответствий условиям корректной работы программы и выведет сообщения при их наличии. \r\n ", "Об окне", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void оМетодеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Скрытие через метод пробелов представляет собой следующий алгоритм: скрытое сообщение переводится в двоичный код. У каждого символа есть свое представление в двоичном коде, которое состоит из восьми цифр. Так, каждый знак записывается чередой единиц и нулей. После чего рассматривается исходный текст, который имеется в первом текстовом поле, и затем каждый пробел сверяется с каждым значеним двочиного кода, в котором записано наше сообщение. Если значение является ноль, то одиночный пробел оставляется, если же значение равно единице, то одиночный пробел заменяется на двоичный и так до тех пор, пока не закончится сообщение. После чего измененный вариант исходного текста записывается в третье текстовое поле. \r\n ", "О методе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
