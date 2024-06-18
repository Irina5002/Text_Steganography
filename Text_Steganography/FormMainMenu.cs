using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Text_Steganography.Forms;

namespace Text_Steganography
{
    public partial class FormMainMenu : Form
    {
        private Button currentButton;
        private Form activeForm;

        public FormMainMenu()
        {
            InitializeComponent();
        }

        //Изменение вида кнопки при её выборе
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null) 
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = Color.FromArgb(215, 216, 225);
                    currentButton.ForeColor = Color.Black;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                }
            }
        }

        //Возвращение кнопки в её первоначальный вид, если она не активна
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(170, 172, 189);
                    previousBtn.ForeColor = Color.Black;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                }
            }
        }

        //Для открытия дочернего окна на место панели 
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }


        private void btnSpace_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormSpaceHide(), sender);

        }

        private void btnSpaceExtr_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormSpaceExtr(), sender);
        }

        private void btnLetter_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormLetterHide(), sender);
        }

        private void btnLetterExtr_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormLetterExtr(), sender);
        }

        private void btnText_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormTexts(), sender);
        }

        private void btnStegano_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormStegano(), sender);
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormAbout(), sender);
        }

    }

}
