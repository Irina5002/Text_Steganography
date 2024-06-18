using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Text_Steganography.Forms
{
    public partial class FormSpaceExtr : Form
    {
        string path = "";

        public FormSpaceExtr()
        {
            InitializeComponent();
            //Используемые форматы для сохранения и открытия
            openFileDialog1.FileName = @"Новый файл.rtf";
            saveFileDialog1.Filter = "RTF Files(*.rtf)|*.rtf|All files(*.*)|*.*";
            openFileDialog1.Filter = "RTF Files(*.rtf)|*.rtf|Text File(*.txt)|*.txt|All files(*.*)|*.*";
        }

        //Обработка нажатия на кнопку "Извлечь текст".
        private void button1_Click(object sender, EventArgs e)
        {
            string b_2 = richTextBox1.Text;
            //Обработка ошибок. При отсутствии ошибок скрытое сообщение извлекается.
            if (b_2.IndexOf("   ") > -1)
            {
                MessageBox.Show("Больше двух пробелов. Замените или проверьте текст, после чего нажмите на кнопку еще раз для запуска программы.");
            }
            else
            {
                char[] c_2 = b_2.ToArray();
                string st_1 = "";
                string[] st_3 = null;
                int sch = 0;
                int sch_1 = 0;


                for (int i = 0; i < c_2.Length; i++)
                {
                    if (c_2[i] == ' ')
                    {
                        sch++;
                        if (c_2[i + 1] == ' ')
                        {
                            st_1 += 1;
                            i++;
                            sch_1++;
                        }
                        else if (c_2[i + 1] != ' ')
                        {
                            st_1 += 0;
                        }
                    }
                }

                if (sch < 8)
                {
                    MessageBox.Show("Недостаточно пробелов. Здесь нет скрытого сообщения. Программа не может продолжить работу.");
                }
                else if (sch_1 == 0)
                {
                    MessageBox.Show("Неверный исходный текст, в котором нет скрытого сообщения. Нет двойных пробелов.");
                }
                //Извлечение скрытой информации во второе текстовое поле. 
                else
                {

                    char[] st_2 = st_1.ToArray();
                    int kost = 8;
                    int j = 0;
                    Array.Resize(ref st_3, st_2.Length);
                    for (int i = 0; i < st_2.Length; i++)
                    {

                        if (kost != 0)
                        {
                            st_3[j] += st_2[i].ToString();
                            kost--;
                        }
                        else if (kost == 0)
                        {
                            kost = 8;
                            j++;
                            i--;
                        }
                    }

                    string[] st_4 = null;
                    Array.Resize(ref st_4, st_3.Length);

                    //Данная часть кода нужна для того, чтобы программа понимала, что здесь находится конец скрытой информации в заданном тексте, извлечение прерывается.
                    for (int i = 0; i < st_3.Length; i++)
                    {
                        if ((st_3[i] == "00000000") || (st_3[i].Length < 8))
                        {
                            break;
                        }
                        else
                        {
                            st_4[i] = st_3[i];
                        }
                    }
                    string res = "";
                    byte[] arr = new byte[st_4.Length];
                    for (int i = 0; i < st_4.Length; i++)
                    {

                        byte bv = Convert.ToByte(st_4[i], 2);
                        arr[i] = bv;

                    }

                    res = Encoding.GetEncoding(1251).GetString(arr);
                    richTextBox2.Text = res;
                }
            }
        }

        //Обработка кнопки "Очистить текстовые поля".
        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox2.Clear();
        }

        //Обработка кнопки в меню "Открыть". Позволяет открыть текстовый файл, текст из которого записывается в первое текстовое поле.
        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
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

        //Обработка кнопки в меню "Сохранить". Позволяет сохранить скрытую информацию из второго текстового поля.
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    path = saveFileDialog1.FileName;
                    richTextBox2.SaveFile(path);
                }
            }
            catch { }
        }

        private void обОкнеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Данное окно предназначено для раскрытия сообщения из текста. Оно включает в себя два текстовых поля, две кнопки и меню в верхней части. Первое поле служит для того, чтобы принять текст со скрытым сообщением. При нажатии на кнопку «Извлечь текст» – скрытое сообщение появится во втором поле. При нажатии на кнопку «Очистить» – очистятся все поля.\r\nПри нажатии на «Файл» откроется меню, которое предложит вам несколько действий. «Открыть» – откроет текстовые файлы в первое поле. «Сохранить» – предложит сохранить текст из второй формы в файл. «Об окне» – вы уже тут. \r\nТакже для каждого текстового поля существует контекстное меню, которое можно вызвать нажатием на правую кнопку мыши.\r\nПосле нажатии на кнопку «Извлечь текст» программа проверит текст на наличие несоответствий условиям корректной работы программы и выведет сообщения при их наличии.\r\n", "Об окне", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void обОкнеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Данное окно предназначено для раскрытия сообщения из текста. Оно включает в себя два текстовых поля, две кнопки и меню в верхней части. Первое поле служит для того, чтобы принять текст со скрытым сообщением. При нажатии на кнопку «Извлечь текст» – скрытое сообщение появится во втором поле. При нажатии на кнопку «Очистить» – очистятся все поля.\r\nПри нажатии на «Файл» откроется меню, которое предложит вам несколько действий. «Открыть» – откроет текстовые файлы в первое поле. «Сохранить» – предложит сохранить текст из второй формы в файл. «Об окне» – вы уже тут. \r\nТакже для каждого текстового поля существует контекстное меню, которое можно вызвать нажатием на правую кнопку мыши.\r\nПосле нажатии на кнопку «Извлечь текст» программа проверит текст на наличие несоответствий условиям корректной работы программы и выведет сообщения при их наличии.\r\n", "Об окне", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void оМетодеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Извлечение с помощью метода пробелов представляет собой то, что текст с уже скрытым сообщением содержит в себе одиночные и двоичные пробелы. По очереди рассматриваются данные пробелы, после чего, на основе их записывается двоичный код - если пробел одиночный, то записывается ноль, а если двоичный, то единица. После чего этот двоичный код делится на части из восемь цифр, а после чего преобразовывается в сообщение, согласно кодировке. И уже это сообщение появляется во втором текстовом поле  \r\n ", "О методе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
