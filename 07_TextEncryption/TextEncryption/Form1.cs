using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace encryptionText
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //  ======================independent of UI========================
        static string encryptText(string text, int key = 5)
        {

            string encryptedText = "";

            foreach (char c in text.Reverse())
            {

                encryptedText += (char)(c + key);

            }

            return encryptedText;
        }
        static string decryptText(string text, int key = 5)
        {

            string decryptedText = "";

            foreach (char c in text.Reverse())
            {
                decryptedText += (char)(c - key);

            }

            return decryptedText;
        }

        //  ==============================================================

        private void clearContent(Control cntrl)
        {
            cntrl.Text=string.Empty;

        }

        private void btnDarkMode_Click(object sender, EventArgs e)
        {
            if (btnDarkMod.Tag.ToString()=="2")
            {
                btnDarkMod.FillColor = Color.Black;
                btnDarkMod.Tag = "1";
                this.BackColor = Color.NavajoWhite;

            }
            else
            {
                btnDarkMod.FillColor = Color.NavajoWhite;
                btnDarkMod.Tag = "2";
                this.BackColor = Color.Black;
            }
        }

        private void setErrorProvider(Control cntrl,string msg)
        {
            errorProvider1.SetError(cntrl, msg);
        }
        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (tbTextToEncrypt.Text=="")
            {
                setErrorProvider(tbTextToEncrypt, "Enter a text");
            }
            else
            {
                tbEncryptedText.Text = encryptText(tbTextToEncrypt.Text, (int)nudEncryptionkey.Value);
                setErrorProvider(tbTextToEncrypt, "");

            }

        }
        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (tbTextToDecrypt.Text == "")
            {
                setErrorProvider(tbTextToDecrypt, "Enter a text");
            }
            else
            {
                tbDecryptedText.Text = decryptText(tbTextToDecrypt.Text, (int)nudDecryptionkey.Value);
                setErrorProvider(tbTextToDecrypt, "");
            }


        }

        private void tmsClear_Click(object sender, EventArgs e)
        {
            clearContent(guna2ContextMenuStrip3.SourceControl);
        }

        private void encryptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnEncrypt.PerformClick();

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            btnDecrypt.PerformClick();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearContent(guna2ContextMenuStrip1.SourceControl);
        }

        private void clear_Click(object sender, EventArgs e)
        {
            clearContent(guna2ContextMenuStrip2.SourceControl);

        }
    }
}
