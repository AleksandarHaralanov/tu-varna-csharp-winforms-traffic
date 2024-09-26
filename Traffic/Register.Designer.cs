namespace Traffic
{
    partial class Register
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
            usernameField = new TextBox();
            emailField = new TextBox();
            passwordField = new TextBox();
            CreateAccountButton = new Button();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            gotoLogin = new LinkLabel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // usernameField
            // 
            usernameField.Anchor = AnchorStyles.None;
            usernameField.Location = new Point(52, 58);
            usernameField.MaxLength = 24;
            usernameField.Name = "usernameField";
            usernameField.PlaceholderText = "Username";
            usernameField.Size = new Size(176, 23);
            usernameField.TabIndex = 0;
            // 
            // emailField
            // 
            emailField.Anchor = AnchorStyles.None;
            emailField.Location = new Point(52, 102);
            emailField.MaxLength = 50;
            emailField.Name = "emailField";
            emailField.PlaceholderText = "E-mail";
            emailField.Size = new Size(176, 23);
            emailField.TabIndex = 1;
            // 
            // passwordField
            // 
            passwordField.Anchor = AnchorStyles.None;
            passwordField.Location = new Point(52, 146);
            passwordField.MaxLength = 30;
            passwordField.Name = "passwordField";
            passwordField.PlaceholderText = "Password";
            passwordField.Size = new Size(176, 23);
            passwordField.TabIndex = 2;
            passwordField.UseSystemPasswordChar = true;
            // 
            // CreateAccountButton
            // 
            CreateAccountButton.Anchor = AnchorStyles.None;
            CreateAccountButton.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            CreateAccountButton.Location = new Point(88, 183);
            CreateAccountButton.Name = "CreateAccountButton";
            CreateAccountButton.Size = new Size(104, 30);
            CreateAccountButton.TabIndex = 3;
            CreateAccountButton.Text = "РЕГИСТРИРАЙ";
            CreateAccountButton.UseVisualStyleBackColor = true;
            CreateAccountButton.Click += CreateAccountButton_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(39, 9);
            label1.Name = "label1";
            label1.Size = new Size(203, 30);
            label1.TabIndex = 4;
            label1.Text = "РЕГИСТРИРАНЕ";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(CreateAccountButton, 0, 4);
            tableLayoutPanel1.Controls.Add(usernameField, 0, 1);
            tableLayoutPanel1.Controls.Add(passwordField, 0, 3);
            tableLayoutPanel1.Controls.Add(emailField, 0, 2);
            tableLayoutPanel1.Controls.Add(gotoLogin, 0, 5);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20.0019989F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 18.3318329F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 18.3318329F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 18.3318329F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15.0014992F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.0009995F));
            tableLayoutPanel1.Size = new Size(281, 244);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // gotoLogin
            // 
            gotoLogin.ActiveLinkColor = Color.White;
            gotoLogin.Anchor = AnchorStyles.Top;
            gotoLogin.AutoSize = true;
            gotoLogin.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            gotoLogin.LinkBehavior = LinkBehavior.NeverUnderline;
            gotoLogin.LinkColor = Color.White;
            gotoLogin.Location = new Point(85, 216);
            gotoLogin.Name = "gotoLogin";
            gotoLogin.Size = new Size(111, 20);
            gotoLogin.TabIndex = 5;
            gotoLogin.TabStop = true;
            gotoLogin.Text = "Върни се назад";
            gotoLogin.VisitedLinkColor = Color.White;
            gotoLogin.LinkClicked += GotoLogin_LinkClicked;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(48, 132, 212);
            ClientSize = new Size(281, 244);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Register";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Регистриране";
            FormClosed += Register_FormClosed;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox usernameField;
        private TextBox emailField;
        private TextBox passwordField;
        private Button CreateAccountButton;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private LinkLabel gotoLogin;
    }
}