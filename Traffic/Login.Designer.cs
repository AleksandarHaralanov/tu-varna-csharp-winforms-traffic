namespace Traffic
{
    partial class Login
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
            loginHeading = new Label();
            layoutLogin = new TableLayoutPanel();
            LoginButton = new Button();
            ForgottenPasswordLink = new LinkLabel();
            usernameField = new TextBox();
            passwordField = new TextBox();
            layoutLogin.SuspendLayout();
            SuspendLayout();
            // 
            // loginHeading
            // 
            loginHeading.Anchor = AnchorStyles.None;
            loginHeading.AutoSize = true;
            loginHeading.Font = new Font("Arial Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            loginHeading.ForeColor = Color.White;
            loginHeading.Location = new Point(80, 10);
            loginHeading.Name = "loginHeading";
            loginHeading.Size = new Size(81, 30);
            loginHeading.TabIndex = 4;
            loginHeading.Text = "ВХОД";
            loginHeading.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // layoutLogin
            // 
            layoutLogin.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            layoutLogin.BackColor = Color.FromArgb(48, 132, 212);
            layoutLogin.ColumnCount = 1;
            layoutLogin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            layoutLogin.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            layoutLogin.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            layoutLogin.Controls.Add(LoginButton, 0, 4);
            layoutLogin.Controls.Add(ForgottenPasswordLink, 0, 3);
            layoutLogin.Controls.Add(usernameField, 0, 1);
            layoutLogin.Controls.Add(passwordField, 0, 2);
            layoutLogin.Controls.Add(loginHeading, 0, 0);
            layoutLogin.Dock = DockStyle.Fill;
            layoutLogin.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            layoutLogin.Location = new Point(0, 0);
            layoutLogin.Name = "layoutLogin";
            layoutLogin.RowCount = 5;
            layoutLogin.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            layoutLogin.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            layoutLogin.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            layoutLogin.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            layoutLogin.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            layoutLogin.Size = new Size(242, 206);
            layoutLogin.TabIndex = 6;
            // 
            // LoginButton
            // 
            LoginButton.Anchor = AnchorStyles.None;
            LoginButton.BackColor = Color.White;
            LoginButton.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point);
            LoginButton.ForeColor = Color.Black;
            LoginButton.Location = new Point(83, 166);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(75, 26);
            LoginButton.TabIndex = 5;
            LoginButton.Text = "ВХОД";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // ForgottenPasswordLink
            // 
            ForgottenPasswordLink.ActiveLinkColor = Color.White;
            ForgottenPasswordLink.Anchor = AnchorStyles.Top;
            ForgottenPasswordLink.AutoSize = true;
            ForgottenPasswordLink.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ForgottenPasswordLink.LinkBehavior = LinkBehavior.NeverUnderline;
            ForgottenPasswordLink.LinkColor = Color.White;
            ForgottenPasswordLink.Location = new Point(40, 133);
            ForgottenPasswordLink.Name = "ForgottenPasswordLink";
            ForgottenPasswordLink.Size = new Size(162, 20);
            ForgottenPasswordLink.TabIndex = 3;
            ForgottenPasswordLink.TabStop = true;
            ForgottenPasswordLink.Text = "Регистриране на акаунт";
            ForgottenPasswordLink.TextAlign = ContentAlignment.MiddleCenter;
            ForgottenPasswordLink.VisitedLinkColor = Color.White;
            ForgottenPasswordLink.LinkClicked += RegisterAccountLink_LinkClicked;
            // 
            // usernameField
            // 
            usernameField.Anchor = AnchorStyles.None;
            usernameField.Location = new Point(45, 60);
            usernameField.MaxLength = 24;
            usernameField.Name = "usernameField";
            usernameField.PlaceholderText = "Username";
            usernameField.Size = new Size(152, 23);
            usernameField.TabIndex = 0;
            // 
            // passwordField
            // 
            passwordField.Anchor = AnchorStyles.None;
            passwordField.Location = new Point(45, 101);
            passwordField.MaxLength = 30;
            passwordField.Name = "passwordField";
            passwordField.PlaceholderText = "Password";
            passwordField.Size = new Size(152, 23);
            passwordField.TabIndex = 1;
            passwordField.UseSystemPasswordChar = true;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(242, 206);
            Controls.Add(layoutLogin);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Login";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Вход";
            FormClosed += Login_FormClosed;
            layoutLogin.ResumeLayout(false);
            layoutLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label loginHeading;
        private TableLayoutPanel layoutLogin;
        private Button LoginButton;
        private LinkLabel ForgottenPasswordLink;
        private TextBox usernameField;
        private TextBox passwordField;
    }
}