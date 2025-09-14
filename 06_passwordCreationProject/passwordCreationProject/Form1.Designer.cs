namespace passwordCreationProject
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.cbCapitalLetters = new Guna.UI2.WinForms.Guna2CheckBox();
            this.cbSpecialChars = new Guna.UI2.WinForms.Guna2CheckBox();
            this.cbDigit = new Guna.UI2.WinForms.Guna2CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbSmallLetters = new Guna.UI2.WinForms.Guna2CheckBox();
            this.btnRegenerate = new Guna.UI2.WinForms.Guna2Button();
            this.btnCopy = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel8 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblEstimateTimeToCrack = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.tbPasswordLenght = new Guna.UI2.WinForms.Guna2TrackBar();
            this.lblPasswordScore = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblPasswordLenght = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbCapitalLetters
            // 
            this.cbCapitalLetters.AutoSize = true;
            this.cbCapitalLetters.Checked = true;
            this.cbCapitalLetters.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCapitalLetters.CheckedState.BorderRadius = 0;
            this.cbCapitalLetters.CheckedState.BorderThickness = 0;
            this.cbCapitalLetters.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCapitalLetters.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbCapitalLetters.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cbCapitalLetters.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbCapitalLetters.Location = new System.Drawing.Point(3, 17);
            this.cbCapitalLetters.Name = "cbCapitalLetters";
            this.cbCapitalLetters.Size = new System.Drawing.Size(66, 32);
            this.cbCapitalLetters.TabIndex = 15;
            this.cbCapitalLetters.Tag = "1";
            this.cbCapitalLetters.Text = "A-Z";
            this.cbCapitalLetters.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbCapitalLetters.UncheckedState.BorderRadius = 0;
            this.cbCapitalLetters.UncheckedState.BorderThickness = 0;
            this.cbCapitalLetters.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbCapitalLetters.CheckedChanged += new System.EventHandler(this.checkBoxChecked);
            // 
            // cbSpecialChars
            // 
            this.cbSpecialChars.AutoSize = true;
            this.cbSpecialChars.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSpecialChars.CheckedState.BorderRadius = 0;
            this.cbSpecialChars.CheckedState.BorderThickness = 0;
            this.cbSpecialChars.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSpecialChars.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbSpecialChars.Location = new System.Drawing.Point(245, 17);
            this.cbSpecialChars.Name = "cbSpecialChars";
            this.cbSpecialChars.Size = new System.Drawing.Size(120, 32);
            this.cbSpecialChars.TabIndex = 17;
            this.cbSpecialChars.Tag = "4";
            this.cbSpecialChars.Text = "!@#$%^&*";
            this.cbSpecialChars.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbSpecialChars.UncheckedState.BorderRadius = 0;
            this.cbSpecialChars.UncheckedState.BorderThickness = 0;
            this.cbSpecialChars.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbSpecialChars.CheckedChanged += new System.EventHandler(this.checkBoxChecked);
            // 
            // cbDigit
            // 
            this.cbDigit.AutoSize = true;
            this.cbDigit.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.cbDigit.Checked = true;
            this.cbDigit.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbDigit.CheckedState.BorderRadius = 0;
            this.cbDigit.CheckedState.BorderThickness = 0;
            this.cbDigit.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbDigit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDigit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbDigit.Location = new System.Drawing.Point(164, 17);
            this.cbDigit.Name = "cbDigit";
            this.cbDigit.Size = new System.Drawing.Size(64, 32);
            this.cbDigit.TabIndex = 16;
            this.cbDigit.Tag = "3";
            this.cbDigit.Text = "0-9";
            this.cbDigit.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbDigit.UncheckedState.BorderRadius = 0;
            this.cbDigit.UncheckedState.BorderThickness = 0;
            this.cbDigit.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbDigit.CheckedChanged += new System.EventHandler(this.checkBoxChecked);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbCapitalLetters);
            this.panel1.Controls.Add(this.cbSmallLetters);
            this.panel1.Controls.Add(this.cbSpecialChars);
            this.panel1.Controls.Add(this.cbDigit);
            this.panel1.Location = new System.Drawing.Point(101, 482);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(395, 63);
            this.panel1.TabIndex = 38;
            // 
            // cbSmallLetters
            // 
            this.cbSmallLetters.AutoSize = true;
            this.cbSmallLetters.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSmallLetters.CheckedState.BorderRadius = 0;
            this.cbSmallLetters.CheckedState.BorderThickness = 0;
            this.cbSmallLetters.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSmallLetters.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbSmallLetters.Location = new System.Drawing.Point(84, 17);
            this.cbSmallLetters.Name = "cbSmallLetters";
            this.cbSmallLetters.Size = new System.Drawing.Size(61, 32);
            this.cbSmallLetters.TabIndex = 14;
            this.cbSmallLetters.Tag = "2";
            this.cbSmallLetters.Text = "a-z";
            this.cbSmallLetters.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbSmallLetters.UncheckedState.BorderRadius = 0;
            this.cbSmallLetters.UncheckedState.BorderThickness = 0;
            this.cbSmallLetters.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbSmallLetters.CheckedChanged += new System.EventHandler(this.checkBoxChecked);
            // 
            // btnRegenerate
            // 
            this.btnRegenerate.BorderRadius = 22;
            this.btnRegenerate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRegenerate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRegenerate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRegenerate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRegenerate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRegenerate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnRegenerate.ForeColor = System.Drawing.Color.White;
            this.btnRegenerate.Image = global::passwordCreationProject.Properties.Resources.icons8_refresh_128;
            this.btnRegenerate.Location = new System.Drawing.Point(545, 378);
            this.btnRegenerate.Name = "btnRegenerate";
            this.btnRegenerate.PressedColor = System.Drawing.Color.Brown;
            this.btnRegenerate.Size = new System.Drawing.Size(422, 59);
            this.btnRegenerate.TabIndex = 36;
            this.btnRegenerate.Text = "Regenerate";
            this.btnRegenerate.Click += new System.EventHandler(this.btnRegenerate_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.BorderRadius = 24;
            this.btnCopy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCopy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCopy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCopy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCopy.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCopy.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCopy.ForeColor = System.Drawing.Color.White;
            this.btnCopy.Image = global::passwordCreationProject.Properties.Resources.icons8_copy_48;
            this.btnCopy.Location = new System.Drawing.Point(101, 378);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.PressedColor = System.Drawing.Color.Brown;
            this.btnCopy.Size = new System.Drawing.Size(422, 59);
            this.btnCopy.TabIndex = 37;
            this.btnCopy.Text = "Copy to clipboard";
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // guna2HtmlLabel8
            // 
            this.guna2HtmlLabel8.AutoSize = false;
            this.guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guna2HtmlLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2HtmlLabel8.Location = new System.Drawing.Point(116, 456);
            this.guna2HtmlLabel8.Name = "guna2HtmlLabel8";
            this.guna2HtmlLabel8.Size = new System.Drawing.Size(257, 31);
            this.guna2HtmlLabel8.TabIndex = 35;
            this.guna2HtmlLabel8.Text = "Additional options";
            // 
            // txtPassword
            // 
            this.txtPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPassword.BorderRadius = 25;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FillColor = System.Drawing.SystemColors.Window;
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Location = new System.Drawing.Point(101, 252);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PlaceholderText = "";
            this.txtPassword.ReadOnly = true;
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(866, 108);
            this.txtPassword.TabIndex = 34;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblEstimateTimeToCrack
            // 
            this.lblEstimateTimeToCrack.AutoSize = false;
            this.lblEstimateTimeToCrack.BackColor = System.Drawing.Color.Transparent;
            this.lblEstimateTimeToCrack.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEstimateTimeToCrack.ForeColor = System.Drawing.Color.Red;
            this.lblEstimateTimeToCrack.Location = new System.Drawing.Point(829, 196);
            this.lblEstimateTimeToCrack.Name = "lblEstimateTimeToCrack";
            this.lblEstimateTimeToCrack.Size = new System.Drawing.Size(191, 31);
            this.lblEstimateTimeToCrack.TabIndex = 33;
            this.lblEstimateTimeToCrack.Text = "3 years";
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.AutoSize = false;
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guna2HtmlLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(566, 196);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(257, 31);
            this.guna2HtmlLabel7.TabIndex = 32;
            this.guna2HtmlLabel7.Text = "Estimated time to crack:";
            // 
            // tbPasswordLenght
            // 
            this.tbPasswordLenght.Location = new System.Drawing.Point(545, 499);
            this.tbPasswordLenght.Maximum = 35;
            this.tbPasswordLenght.Minimum = 5;
            this.tbPasswordLenght.Name = "tbPasswordLenght";
            this.tbPasswordLenght.Size = new System.Drawing.Size(422, 23);
            this.tbPasswordLenght.TabIndex = 25;
            this.tbPasswordLenght.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbPasswordLenght.Value = 10;
            this.tbPasswordLenght.Scroll += new System.Windows.Forms.ScrollEventHandler(this.tbPasswordLenght_Scroll);
            // 
            // lblPasswordScore
            // 
            this.lblPasswordScore.AutoSize = false;
            this.lblPasswordScore.BackColor = System.Drawing.Color.Transparent;
            this.lblPasswordScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPasswordScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPasswordScore.Location = new System.Drawing.Point(395, 196);
            this.lblPasswordScore.Name = "lblPasswordScore";
            this.lblPasswordScore.Size = new System.Drawing.Size(151, 31);
            this.lblPasswordScore.TabIndex = 31;
            this.lblPasswordScore.Text = "strong";
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.AutoSize = false;
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(136, 196);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(253, 31);
            this.guna2HtmlLabel4.TabIndex = 30;
            this.guna2HtmlLabel4.Text = "Your password\'s score: ";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.AutoSize = false;
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(234, 33);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(688, 52);
            this.guna2HtmlLabel3.TabIndex = 29;
            this.guna2HtmlLabel3.Text = "Secure Password Generator          ";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.AutoSize = false;
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(296, 91);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(483, 25);
            this.guna2HtmlLabel2.TabIndex = 28;
            this.guna2HtmlLabel2.Text = "Generate  secure password to stay safe online ";
            // 
            // lblPasswordLenght
            // 
            this.lblPasswordLenght.BackColor = System.Drawing.Color.Transparent;
            this.lblPasswordLenght.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPasswordLenght.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPasswordLenght.Location = new System.Drawing.Point(676, 456);
            this.lblPasswordLenght.Name = "lblPasswordLenght";
            this.lblPasswordLenght.Size = new System.Drawing.Size(16, 31);
            this.lblPasswordLenght.TabIndex = 27;
            this.lblPasswordLenght.Text = "0";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(545, 456);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(125, 31);
            this.guna2HtmlLabel1.TabIndex = 26;
            this.guna2HtmlLabel1.Text = "Characters: ";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(1069, 588);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRegenerate);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.guna2HtmlLabel8);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblEstimateTimeToCrack);
            this.Controls.Add(this.guna2HtmlLabel7);
            this.Controls.Add(this.tbPasswordLenght);
            this.Controls.Add(this.lblPasswordScore);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.lblPasswordLenght);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Secure Password";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CheckBox cbCapitalLetters;
        private Guna.UI2.WinForms.Guna2CheckBox cbSpecialChars;
        private Guna.UI2.WinForms.Guna2CheckBox cbDigit;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2CheckBox cbSmallLetters;
        private Guna.UI2.WinForms.Guna2Button btnRegenerate;
        private Guna.UI2.WinForms.Guna2Button btnCopy;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel8;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblEstimateTimeToCrack;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2TrackBar tbPasswordLenght;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPasswordScore;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPasswordLenght;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private System.Windows.Forms.Timer timer1;
    }
}

