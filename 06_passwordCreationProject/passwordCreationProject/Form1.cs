using System;
using System.Drawing;
using System.Windows.Forms;

namespace passwordCreationProject
{
    public partial class frmMain : Form
    {
        public frmMain()

        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

            setCheckBoxes();
            lblPasswordLenght.Text = tbPasswordLenght.Value.ToString();
            displayPassword();


        }

        byte numberOfCheckCheckBoxes()
        {
            byte counter = 0;
            foreach (CheckBox item in panel1.Controls)
            {
                if (item.Checked)
                    counter++;

            }
            return counter;
        }
   
        void setCheckBoxes()
        {
            bool enableCheckBox = false;
            if (numberOfCheckCheckBoxes()>1)
            {
              enableCheckBox = true;
            }
            else
            {
                enableCheckBox = false;
            }
            foreach (CheckBox item in panel1.Controls)
            {
                if (item.Checked)
                {
                    item.Enabled = enableCheckBox;
                }
            }
        }

        private void checkBoxChecked(object sender, EventArgs e)
        {
            setCheckBoxes();
            displayPassword();
        }

        private void tbPasswordLenght_Scroll(object sender, ScrollEventArgs e)
        {
            lblPasswordLenght.Text = tbPasswordLenght.Value.ToString(); ;
            displayPassword();
        }

     
        
        private void btnCopy_Click(object sender, EventArgs e)
        {
            btnCopy.Text = "Copied!";
            btnCopy.FillColor = Color.DarkKhaki;
            timer1.Start();
        }

        byte counter =0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;
            if (counter == 1)
            {
                btnCopy.Text = "Copy to clipboard";
                btnCopy.FillColor = Color.FromArgb(128,64,64);
                timer1.Stop();
                counter = 0;

            }

            
        }
  


        public struct stPasswordCharFeatures
        {

            public bool capitalLetter;
            public bool smallLetter;
            public bool digit;
            public bool specialCharacter;



        }

       string generateChars(stPasswordCharFeatures passwordCharFeatures)
        {

            string chars = "";

            if (passwordCharFeatures.capitalLetter)
            {
                chars = "ABCDEFGTIJKLMNOPQRSTUWXYZ";
            }
            if (passwordCharFeatures.smallLetter)
            {
                chars += "abcdefghijklmnopqrstuwxyz";
            }
            if (passwordCharFeatures.digit)
            {
                chars += "0123456789";
            }
            if (passwordCharFeatures.specialCharacter)
            {
                chars += "!@#$%^&*";
            }

            
            return chars;
        }
        string generatePassword(int passwordLength,stPasswordCharFeatures passwordCharFeatures)
        {
            string password = "";
            string passwordChars = generateChars(passwordCharFeatures);
            Random rnd= new Random();
       
            for (int i = 0; i < passwordLength; i++)
            {
                password += passwordChars[rnd.Next(0,passwordChars.Length )];
            }
            
            return password;

        }



        void displayPassword()
        {
            stPasswordCharFeatures pf = new stPasswordCharFeatures();

            pf.capitalLetter = cbCapitalLetters.Checked;
            pf.smallLetter = cbSmallLetters.Checked;
            pf.digit = cbDigit.Checked;
            pf.specialCharacter = cbSpecialChars.Checked;
            txtPassword.Text = generatePassword(tbPasswordLenght.Value,pf);
            setCrakeTimeScore();


        }
   

        private void btnRegenerate_Click(object sender, EventArgs e)
        {
           
            displayPassword();

        }
    

        void setCrakeTimeScore()
        {

            switch (tbPasswordLenght.Value)
            {
                case 5:
                    lblEstimateTimeToCrack.ForeColor = Color.Red;
                    lblPasswordScore.Text = "very week";
                    lblPasswordScore.ForeColor = Color.Red;
                    lblEstimateTimeToCrack.Text = "seconds";
                    break;
                case 6:

                    lblEstimateTimeToCrack.ForeColor = Color.Red;
                    lblPasswordScore.Text = "very week";
                    lblPasswordScore.ForeColor = Color.Red;
                    lblEstimateTimeToCrack.Text = "2 minutes";
                    break;
                case 7:
                    lblEstimateTimeToCrack.ForeColor = Color.DarkOrange;
                    lblPasswordScore.Text = "week";
                    lblPasswordScore.ForeColor = Color.DarkOrange;
                    lblEstimateTimeToCrack.Text = "17 minutes";
                    break;
                case 8:
                    lblEstimateTimeToCrack.ForeColor = Color.DarkOrange;
                    lblPasswordScore.Text = "week";
                    lblPasswordScore.ForeColor = Color.DarkOrange;
                    lblEstimateTimeToCrack.Text = "3 hours";
                    break;
                case 9:
                    lblEstimateTimeToCrack.ForeColor = Color.DarkGreen;
                    lblPasswordScore.Text = "good";
                    lblPasswordScore.ForeColor = Color.DarkGreen;
                    lblEstimateTimeToCrack.Text = "1 day";
                    break;
                case 10:
                    lblEstimateTimeToCrack.ForeColor = Color.DarkGreen;
                    lblPasswordScore.Text = "good";
                    lblPasswordScore.ForeColor = Color.DarkGreen;
                    lblEstimateTimeToCrack.Text = "12 day";
                    break;
                case 11:
                    lblEstimateTimeToCrack.ForeColor = Color.Blue;
                    lblPasswordScore.Text = "strong";
                    lblPasswordScore.ForeColor = Color.Blue;
                    lblEstimateTimeToCrack.Text = "4 months";
                    break;
                case 12:
                    lblEstimateTimeToCrack.ForeColor = Color.Blue;
                    lblPasswordScore.Text = "strong";
                    lblPasswordScore.ForeColor = Color.Blue;
                    lblEstimateTimeToCrack.Text = "3 years";
                    break;
                case 13:
                    lblEstimateTimeToCrack.ForeColor = Color.Blue;
                    lblPasswordScore.Text = "strong";
                    lblEstimateTimeToCrack.ForeColor = Color.Blue;
                    lblEstimateTimeToCrack.Text = "31 years";
                    break;
                default:

                    lblEstimateTimeToCrack.ForeColor = Color.Blue;
                    lblPasswordScore.Text = "strong";
                    lblPasswordScore.ForeColor = Color.Blue;
                    lblEstimateTimeToCrack.Text = "centuries";
                    break;
            }
        }
    
    
    
    }
}
