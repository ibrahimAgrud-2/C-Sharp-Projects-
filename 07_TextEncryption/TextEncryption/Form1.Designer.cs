namespace encryptionText
{
    partial class Form1
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
            this.guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.encryptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnDecrypt = new Guna.UI2.WinForms.Guna2Button();
            this.btnEncrypt = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ContextMenuStrip2 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clear = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDarkMod = new Guna.UI2.WinForms.Guna2CircleButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.nudEncryptionkey = new System.Windows.Forms.NumericUpDown();
            this.nudDecryptionkey = new System.Windows.Forms.NumericUpDown();
            this.tbTextToEncrypt = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbEncryptedText = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ContextMenuStrip3 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.tmsClear = new System.Windows.Forms.ToolStripMenuItem();
            this.tbTextToDecrypt = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbDecryptedText = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ContextMenuStrip1.SuspendLayout();
            this.guna2ContextMenuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEncryptionkey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDecryptionkey)).BeginInit();
            this.guna2ContextMenuStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2ContextMenuStrip1
            // 
            this.guna2ContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.guna2ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.encryptToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.guna2ContextMenuStrip1.Name = "guna2ContextMenuStrip1";
            this.guna2ContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.ColorTable = null;
            this.guna2ContextMenuStrip1.RenderStyle.RoundedEdges = true;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2ContextMenuStrip1.Size = new System.Drawing.Size(128, 52);
            // 
            // encryptToolStripMenuItem
            // 
            this.encryptToolStripMenuItem.Name = "encryptToolStripMenuItem";
            this.encryptToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.encryptToolStripMenuItem.Text = "Encrypt";
            this.encryptToolStripMenuItem.Click += new System.EventHandler(this.encryptToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label1.Location = new System.Drawing.Point(62, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 43);
            this.label1.TabIndex = 7;
            this.label1.Text = "Text Encryption";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label2.Location = new System.Drawing.Point(64, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(304, 26);
            this.label2.TabIndex = 8;
            this.label2.Text = "Enter any text to be Encrypted";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label3.Location = new System.Drawing.Point(601, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(320, 26);
            this.label3.TabIndex = 13;
            this.label3.Text = "Enter Encrypted Text to Decrypt";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label4.Location = new System.Drawing.Point(599, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(301, 43);
            this.label4.TabIndex = 12;
            this.label4.Text = "Text Decryption ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label5.Location = new System.Drawing.Point(64, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 26);
            this.label5.TabIndex = 14;
            this.label5.Text = "Enter Secret Key";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label6.Location = new System.Drawing.Point(621, 314);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 26);
            this.label6.TabIndex = 15;
            this.label6.Text = "Enter Secret Key";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label7.Location = new System.Drawing.Point(64, 511);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(181, 26);
            this.label7.TabIndex = 16;
            this.label7.Text = "Encrypted Output";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label8.Location = new System.Drawing.Point(621, 525);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 26);
            this.label8.TabIndex = 17;
            this.label8.Text = "Decrypted Text";
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.BorderRadius = 13;
            this.btnDecrypt.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDecrypt.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDecrypt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDecrypt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDecrypt.FillColor = System.Drawing.Color.White;
            this.btnDecrypt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDecrypt.ForeColor = System.Drawing.Color.Black;
            this.btnDecrypt.Location = new System.Drawing.Point(626, 425);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(383, 45);
            this.btnDecrypt.TabIndex = 18;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.BorderRadius = 13;
            this.btnEncrypt.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEncrypt.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEncrypt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEncrypt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEncrypt.FillColor = System.Drawing.Color.White;
            this.btnEncrypt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEncrypt.ForeColor = System.Drawing.Color.Black;
            this.btnEncrypt.Location = new System.Drawing.Point(69, 425);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(387, 45);
            this.btnEncrypt.TabIndex = 19;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // guna2ContextMenuStrip2
            // 
            this.guna2ContextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.guna2ContextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.clear});
            this.guna2ContextMenuStrip2.Name = "guna2ContextMenuStrip1";
            this.guna2ContextMenuStrip2.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip2.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip2.RenderStyle.ColorTable = null;
            this.guna2ContextMenuStrip2.RenderStyle.RoundedEdges = true;
            this.guna2ContextMenuStrip2.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip2.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip2.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip2.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip2.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2ContextMenuStrip2.Size = new System.Drawing.Size(131, 52);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(130, 24);
            this.toolStripMenuItem1.Text = "Decrypt";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // clear
            // 
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(130, 24);
            this.clear.Text = "Clear";
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // btnDarkMod
            // 
            this.btnDarkMod.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDarkMod.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDarkMod.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDarkMod.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDarkMod.FillColor = System.Drawing.Color.Black;
            this.btnDarkMod.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDarkMod.ForeColor = System.Drawing.Color.White;
            this.btnDarkMod.Location = new System.Drawing.Point(1023, 9);
            this.btnDarkMod.Name = "btnDarkMod";
            this.btnDarkMod.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnDarkMod.Size = new System.Drawing.Size(37, 38);
            this.btnDarkMod.TabIndex = 21;
            this.btnDarkMod.Tag = "1";
            this.btnDarkMod.Click += new System.EventHandler(this.btnDarkMode_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // nudEncryptionkey
            // 
            this.nudEncryptionkey.Location = new System.Drawing.Point(69, 359);
            this.nudEncryptionkey.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudEncryptionkey.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudEncryptionkey.Name = "nudEncryptionkey";
            this.nudEncryptionkey.Size = new System.Drawing.Size(120, 32);
            this.nudEncryptionkey.TabIndex = 22;
            this.nudEncryptionkey.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudDecryptionkey
            // 
            this.nudDecryptionkey.Location = new System.Drawing.Point(626, 359);
            this.nudDecryptionkey.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudDecryptionkey.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDecryptionkey.Name = "nudDecryptionkey";
            this.nudDecryptionkey.Size = new System.Drawing.Size(120, 32);
            this.nudDecryptionkey.TabIndex = 23;
            this.nudDecryptionkey.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tbTextToEncrypt
            // 
            this.tbTextToEncrypt.BorderColor = System.Drawing.Color.Black;
            this.tbTextToEncrypt.BorderRadius = 16;
            this.tbTextToEncrypt.ContextMenuStrip = this.guna2ContextMenuStrip1;
            this.tbTextToEncrypt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbTextToEncrypt.DefaultText = "";
            this.tbTextToEncrypt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbTextToEncrypt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbTextToEncrypt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbTextToEncrypt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbTextToEncrypt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbTextToEncrypt.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.tbTextToEncrypt.ForeColor = System.Drawing.Color.Black;
            this.tbTextToEncrypt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbTextToEncrypt.Location = new System.Drawing.Point(55, 117);
            this.tbTextToEncrypt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tbTextToEncrypt.Multiline = true;
            this.tbTextToEncrypt.Name = "tbTextToEncrypt";
            this.tbTextToEncrypt.PlaceholderText = "";
            this.tbTextToEncrypt.SelectedText = "";
            this.tbTextToEncrypt.Size = new System.Drawing.Size(410, 178);
            this.tbTextToEncrypt.TabIndex = 24;
            // 
            // tbEncryptedText
            // 
            this.tbEncryptedText.BorderColor = System.Drawing.Color.Black;
            this.tbEncryptedText.BorderRadius = 16;
            this.tbEncryptedText.ContextMenuStrip = this.guna2ContextMenuStrip3;
            this.tbEncryptedText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbEncryptedText.DefaultText = "";
            this.tbEncryptedText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbEncryptedText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbEncryptedText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbEncryptedText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbEncryptedText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbEncryptedText.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.tbEncryptedText.ForeColor = System.Drawing.Color.Black;
            this.tbEncryptedText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbEncryptedText.Location = new System.Drawing.Point(46, 543);
            this.tbEncryptedText.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tbEncryptedText.Multiline = true;
            this.tbEncryptedText.Name = "tbEncryptedText";
            this.tbEncryptedText.PlaceholderText = "";
            this.tbEncryptedText.SelectedText = "";
            this.tbEncryptedText.Size = new System.Drawing.Size(410, 178);
            this.tbEncryptedText.TabIndex = 25;
            // 
            // guna2ContextMenuStrip3
            // 
            this.guna2ContextMenuStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.guna2ContextMenuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmsClear});
            this.guna2ContextMenuStrip3.Name = "guna2ContextMenuStrip1";
            this.guna2ContextMenuStrip3.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip3.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip3.RenderStyle.ColorTable = null;
            this.guna2ContextMenuStrip3.RenderStyle.RoundedEdges = true;
            this.guna2ContextMenuStrip3.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip3.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip3.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip3.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip3.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2ContextMenuStrip3.Size = new System.Drawing.Size(113, 28);
            // 
            // tmsClear
            // 
            this.tmsClear.Name = "tmsClear";
            this.tmsClear.Size = new System.Drawing.Size(112, 24);
            this.tmsClear.Text = "Clear";
            this.tmsClear.Click += new System.EventHandler(this.tmsClear_Click);
            // 
            // tbTextToDecrypt
            // 
            this.tbTextToDecrypt.BorderColor = System.Drawing.Color.Black;
            this.tbTextToDecrypt.BorderRadius = 16;
            this.tbTextToDecrypt.ContextMenuStrip = this.guna2ContextMenuStrip2;
            this.tbTextToDecrypt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbTextToDecrypt.DefaultText = "";
            this.tbTextToDecrypt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbTextToDecrypt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbTextToDecrypt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbTextToDecrypt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbTextToDecrypt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbTextToDecrypt.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.tbTextToDecrypt.ForeColor = System.Drawing.Color.Black;
            this.tbTextToDecrypt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbTextToDecrypt.Location = new System.Drawing.Point(588, 117);
            this.tbTextToDecrypt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tbTextToDecrypt.Multiline = true;
            this.tbTextToDecrypt.Name = "tbTextToDecrypt";
            this.tbTextToDecrypt.PlaceholderText = "";
            this.tbTextToDecrypt.SelectedText = "";
            this.tbTextToDecrypt.Size = new System.Drawing.Size(410, 178);
            this.tbTextToDecrypt.TabIndex = 26;
            // 
            // tbDecryptedText
            // 
            this.tbDecryptedText.BorderColor = System.Drawing.Color.Black;
            this.tbDecryptedText.BorderRadius = 16;
            this.tbDecryptedText.ContextMenuStrip = this.guna2ContextMenuStrip3;
            this.tbDecryptedText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbDecryptedText.DefaultText = "";
            this.tbDecryptedText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbDecryptedText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbDecryptedText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbDecryptedText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbDecryptedText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbDecryptedText.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.tbDecryptedText.ForeColor = System.Drawing.Color.Black;
            this.tbDecryptedText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbDecryptedText.Location = new System.Drawing.Point(588, 557);
            this.tbDecryptedText.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tbDecryptedText.Multiline = true;
            this.tbDecryptedText.Name = "tbDecryptedText";
            this.tbDecryptedText.PlaceholderText = "";
            this.tbDecryptedText.SelectedText = "";
            this.tbDecryptedText.Size = new System.Drawing.Size(410, 178);
            this.tbDecryptedText.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(1061, 750);
            this.Controls.Add(this.tbDecryptedText);
            this.Controls.Add(this.tbTextToDecrypt);
            this.Controls.Add(this.tbEncryptedText);
            this.Controls.Add(this.tbTextToEncrypt);
            this.Controls.Add(this.nudDecryptionkey);
            this.Controls.Add(this.nudEncryptionkey);
            this.Controls.Add(this.btnDarkMod);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.DarkBlue;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.guna2ContextMenuStrip1.ResumeLayout(false);
            this.guna2ContextMenuStrip2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEncryptionkey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDecryptionkey)).EndInit();
            this.guna2ContextMenuStrip3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2Button btnDecrypt;
        private Guna.UI2.WinForms.Guna2Button btnEncrypt;
        private System.Windows.Forms.ToolStripMenuItem encryptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clear;
        private Guna.UI2.WinForms.Guna2CircleButton btnDarkMod;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.NumericUpDown nudEncryptionkey;
        private System.Windows.Forms.NumericUpDown nudDecryptionkey;
        private Guna.UI2.WinForms.Guna2TextBox tbTextToEncrypt;
        private Guna.UI2.WinForms.Guna2TextBox tbDecryptedText;
        private Guna.UI2.WinForms.Guna2TextBox tbTextToDecrypt;
        private Guna.UI2.WinForms.Guna2TextBox tbEncryptedText;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip3;
        private System.Windows.Forms.ToolStripMenuItem tmsClear;
    }
}

