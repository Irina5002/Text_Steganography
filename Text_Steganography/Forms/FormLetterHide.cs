using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Text_Steganography.Forms
{
    public partial class FormLetterHide : Form
    {
        DataBase dataBase = new DataBase();
        string path = "";
        public FormLetterHide()
        {
            InitializeComponent();
            //Используемые форматы для сохранения и открытия
            openFileDialog1.FileName = @"Новый файл.rtf";
            saveFileDialog1.Filter = "RTF Files(*.rtf)|*.rtf|All files(*.*)|*.*";
            openFileDialog1.Filter = "RTF Files(*.rtf)|*.rtf|Text File(*.txt)|*.txt|All files(*.*)|*.*";
        }
        public static byte[] ConvertToByteArray(string a, Encoding encoding)
        {
            return encoding.GetBytes(a);
        }

        //Деление всего двоичного кода, который находится в одной строке, на октеты.
        public static String ToBinary(Byte[] data)
        {
            return string.Join(" ", data.Select(d => Convert.ToString(d, 2).PadLeft(8, '0')));
        }

        //Обработка нажатия на кнопку "Скрыть текст".
        private void btnHide_Click(object sender, EventArgs e)
        {
            richTextBox3.Clear();

            string b = richTextBox1.Text;
            string pattern = @"[aceopxABCEHKMOPTX]";

            //Обработка ошибок. При отсутствии ошибок текст скрывается. 
            if (Regex.IsMatch(b, pattern))
            {
                //Если в тексте имеются латинские буквы, которые используются для скрытия текста, программа предложит их заменить для корректной работы, иначе продолжить работу будет нельзя.
                DialogResult result = MessageBox.Show("Текст содержит латинские буквы. Хотите заменить их на русские, чтобы программа могла продолжить работу?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //Замена латинских букв на русские.
                if (result == DialogResult.Yes)
                {
                    b = b.Replace("a", "а");
                    b = b.Replace("c", "с");
                    b = b.Replace("e", "е");
                    b = b.Replace("o", "о");
                    b = b.Replace("p", "р");
                    b = b.Replace("x", "х");
                    b = b.Replace("A", "А");
                    b = b.Replace("B", "В");
                    b = b.Replace("C", "С");
                    b = b.Replace("E", "Е");
                    b = b.Replace("H", "Н");
                    b = b.Replace("K", "К");
                    b = b.Replace("M", "М");
                    b = b.Replace("O", "О");
                    b = b.Replace("P", "Р");
                    b = b.Replace("T", "Т");
                    b = b.Replace("X", "Х");
                    richTextBox1.Text = b;
                    MessageBox.Show("Текст изменен.");
                }
            }
            else if (richTextBox2.Text == "")
            {
                MessageBox.Show("Нет информации для скрытия.");
            }
            //Скрытие информации, измененный текст со скрытым сообщением появится в третьем текстовом поле. 
            else
            {

                char[] c = b.ToArray();
                int sch = 0;

                string eb = bin(richTextBox2.Text);
                char[] d = eb.ToArray();

                int j = -1;
                for (int i = 0; i < c.Length; i++)
                {
                    if (c[i] == 'а')
                    {
                        sch++;
                        j++;
                        if ((j < d.Length) && (d[j] == '1'))
                        {
                            c[i] = 'a';

                        }
                        else if (j == d.Length)
                        {
                            break;
                        }
                    }
                    else if (c[i] == 'с')
                    {
                        sch++;
                        j++;
                        if ((j < d.Length) && (d[j] == '1'))
                        {
                            c[i] = 'c';

                        }
                        else if (j == d.Length)
                        {
                            break;
                        }
                    }
                    else if (c[i] == 'о')
                    {
                        sch++;
                        j++;
                        if ((j < d.Length) && (d[j] == '1'))
                        {
                            c[i] = 'o';

                        }
                        else if (j == d.Length)
                        {
                            break;
                        }
                    }
                    else if (c[i] == 'е')
                    {
                        sch++;
                        j++;
                        if ((j < d.Length) && (d[j] == '1'))
                        {
                            c[i] = 'e';

                        }
                        else if (j == d.Length)
                        {
                            break;
                        }
                    }
                    else if (c[i] == 'р')
                    {
                        sch++;
                        j++;
                        if ((j < d.Length) && (d[j] == '1'))
                        {
                            c[i] = 'p';

                        }
                        else if (j == d.Length)
                        {
                            break;
                        }
                    }
                    else if (c[i] == 'х')
                    {
                        sch++;
                        j++;
                        if ((j < d.Length) && (d[j] == '1'))
                        {
                            c[i] = 'x';

                        }
                        else if (j == d.Length)
                        {
                            break;
                        }
                    }
                    else if (c[i] == 'А')
                    {
                        sch++;
                        j++;
                        if ((j < d.Length) && (d[j] == '1'))
                        {
                            c[i] = 'A';

                        }
                        else if (j == d.Length)
                        {
                            break;
                        }
                    }
                    else if (c[i] == 'В')
                    {
                        sch++;
                        j++;
                        if ((j < d.Length) && (d[j] == '1'))
                        {
                            c[i] = 'B';

                        }
                        else if (j == d.Length)
                        {
                            break;
                        }
                    }
                    else if (c[i] == 'С')
                    {
                        sch++;
                        j++;
                        if ((j < d.Length) && (d[j] == '1'))
                        {
                            c[i] = 'C';

                        }
                        else if (j == d.Length)
                        {
                            break;
                        }
                    }
                    else if (c[i] == 'Е')
                    {
                        sch++;
                        j++;
                        if ((j < d.Length) && (d[j] == '1'))
                        {
                            c[i] = 'E';

                        }
                        else if (j == d.Length)
                        {
                            break;
                        }
                    }
                    else if (c[i] == 'Н')
                    {
                        sch++;
                        j++;
                        if ((j < d.Length) && (d[j] == '1'))
                        {
                            c[i] = 'H';

                        }
                        else if (j == d.Length)
                        {
                            break;
                        }
                    }
                    else if (c[i] == 'К')
                    {
                        sch++;
                        j++;
                        if ((j < d.Length) && (d[j] == '1'))
                        {
                            c[i] = 'K';

                        }
                        else if (j == d.Length)
                        {
                            break;
                        }
                    }
                    else if (c[i] == 'М')
                    {
                        sch++;
                        j++;
                        if ((j < d.Length) && (d[j] == '1'))
                        {
                            c[i] = 'M';

                        }
                        else if (j == d.Length)
                        {
                            break;
                        }
                    }
                    else if (c[i] == 'О')
                    {
                        sch++;
                        j++;
                        if ((j < d.Length) && (d[j] == '1'))
                        {
                            c[i] = 'O';

                        }
                        else if (j == d.Length)
                        {
                            break;
                        }
                    }
                    else if (c[i] == 'Р')
                    {
                        sch++;
                        j++;
                        if ((j < d.Length) && (d[j] == '1'))
                        {
                            c[i] = 'P';

                        }
                        else if (j == d.Length)
                        {
                            break;
                        }
                    }
                    else if (c[i] == 'Т')
                    {
                        sch++;
                        j++;
                        if ((j < d.Length) && (d[j] == '1'))
                        {
                            c[i] = 'T';

                        }
                        else if (j == d.Length)
                        {
                            break;
                        }
                    }
                    else if (c[i] == 'Х')
                    {
                        sch++;
                        j++;
                        if ((j < d.Length) && (d[j] == '1'))
                        {
                            c[i] = 'X';

                        }
                        else if (j == d.Length)
                        {
                            break;
                        }
                    }
                }

                //Обработка ошибки, если знаков не хватает для скрытия информации.
                if (d.Length > sch)
                {

                    DialogResult result = MessageBox.Show("Изначального текста не хватает для того, чтобы скрыть сообщение. Необходимое число букв, используемых для замены: " + d.Length + ". На данный момент количество подобных букв составляет: " + sch + ". Все равно продолжить?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        for (int i = 0; i < c.Length; i++)
                        {
                            richTextBox3.Text += c[i].ToString();
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < c.Length; i++)
                    {
                        richTextBox3.Text += c[i].ToString();
                    }
                }
            }
        }

        //Представление сообщения, которое необходимо скрыть, в двоичной системе.
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
            richTextBox3.Clear();
            richTextBox1.Clear();
            richTextBox2.Clear();
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

        private void обОкнеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Перед вами открылось окно с тремя полями для текста, двумя кнопками и меню в верхней части. Первое поле предназначено для текста, куда программа будет скрывать сообщение. Второе – для сообщения, которое мы хотим скрыть. После нажатия на кнопку «Скрыть текст» изначальный текст из первой формы перейдет в третью вместе со спрятанным сообщением. При нажатии на кнопку «Очистить текстовые поля» очистятся все три текстовых поля.\r\nПри нажатии на «Файл» откроется меню, которое предложит вам несколько действий. «Открыть» – откроет текстовые файлы в первое поле. «Сохранить» – предложит сохранить текст из третьей формы в файл. «Вставить текст» - добавит в первое поле текст, который выбран в базе данных. «Об окне» – вы уже тут.\r\nТакже для каждого текстового поля существует контекстное меню, которое можно вызвать нажатием на правую кнопку мыши.\r\nПосле нажатии на кнопку «Скрыть текст» программа проверит текст на наличие несоответствий условиям корректной работы программы и выведет сообщения при их наличии. \r\nПри нажатии «Извлечь текст» откроется новое окно, которое позволяет увидеть спрятанное ранее сообщение. \r\n", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void вставитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox2.Paste();
        }

        private void выделитьВсеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox2.SelectAll();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox3.Copy();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            richTextBox3.SelectAll();
        }

        private void оМетодеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Скрытие через метод латинских букв представляет собой следующий алгоритм: сначала скрытое сообщение переводится в двоичный код. У каждого символа есть свое представление в двоичном коде, которое состоит из восьми цифр. Так, каждый знак записывается чередой единиц и нулей. После чего рассматривается исходный текст, который имеется в первом текстовом поле, и затем каждая из возможных 17 букв, которые взяты на основе одинаковой печати на кирилллице и на латинице, сверяется с каждым значеним двочиного кода, в котором записано наше сообщение. Если значение является ноль, то буква на кириллице оставляется, если же значение равно единице, то буква заменятеся на латинскую, согласно списку, и так до тех пор, пока не закончится сообщение. После чего измененный вариант исходного текста записывается в третье текстовое поле. \r\n ", "О методе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void обОкнеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Перед вами открылось окно с тремя полями для текста, двумя кнопками и меню в верхней части. Первое поле предназначено для текста, куда программа будет скрывать сообщение. Второе – для сообщения, которое мы хотим скрыть. После нажатия на кнопку «Скрыть текст» изначальный текст из первой формы перейдет в третью вместе со спрятанным сообщением. При нажатии на кнопку «Очистить текстовые поля» очистятся все три текстовых поля.\r\nПри нажатии на «Файл» откроется меню, которое предложит вам несколько действий. «Открыть» – откроет текстовые файлы в первое поле. «Сохранить» – предложит сохранить текст из третьей формы в файл. «Вставить текст» - добавит в первое поле текст, который выбран в базе данных. «Об окне» – вы уже тут.\r\nТакже для каждого текстового поля существует контекстное меню, которое можно вызвать нажатием на правую кнопку мыши.\r\nПосле нажатии на кнопку «Скрыть текст» программа проверит текст на наличие несоответствий условиям корректной работы программы и выведет сообщения при их наличии. \r\nПри нажатии «Извлечь текст» откроется новое окно, которое позволяет увидеть спрятанное ранее сообщение. \r\n", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
