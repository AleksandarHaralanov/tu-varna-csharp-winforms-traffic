namespace Traffic
{
    partial class Ticket
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
            layoutTicket = new TableLayoutPanel();
            gotoLogin = new LinkLabel();
            PurchaseTicketButton2 = new Button();
            PurchaseTicketButton = new Button();
            ticketHeading = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            loginHeading = new Label();
            layoutTicket.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // layoutTicket
            // 
            layoutTicket.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            layoutTicket.ColumnCount = 1;
            layoutTicket.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            layoutTicket.Controls.Add(gotoLogin, 0, 3);
            layoutTicket.Controls.Add(PurchaseTicketButton2, 0, 2);
            layoutTicket.Controls.Add(PurchaseTicketButton, 0, 1);
            layoutTicket.Controls.Add(ticketHeading, 0, 0);
            layoutTicket.Dock = DockStyle.Fill;
            layoutTicket.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            layoutTicket.Location = new Point(0, 0);
            layoutTicket.Name = "layoutTicket";
            layoutTicket.RowCount = 4;
            layoutTicket.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            layoutTicket.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            layoutTicket.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            layoutTicket.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            layoutTicket.Size = new Size(303, 263);
            layoutTicket.TabIndex = 0;
            // 
            // gotoLogin
            // 
            gotoLogin.ActiveLinkColor = Color.White;
            gotoLogin.Anchor = AnchorStyles.None;
            gotoLogin.AutoSize = true;
            gotoLogin.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            gotoLogin.LinkBehavior = LinkBehavior.NeverUnderline;
            gotoLogin.LinkColor = Color.White;
            gotoLogin.Location = new Point(96, 225);
            gotoLogin.Name = "gotoLogin";
            gotoLogin.Size = new Size(111, 20);
            gotoLogin.TabIndex = 9;
            gotoLogin.TabStop = true;
            gotoLogin.Text = "Върни се назад";
            gotoLogin.TextAlign = ContentAlignment.MiddleCenter;
            gotoLogin.VisitedLinkColor = Color.White;
            gotoLogin.LinkClicked += GotoStops_LinkClicked;
            // 
            // PurchaseTicketButton2
            // 
            PurchaseTicketButton2.Anchor = AnchorStyles.None;
            PurchaseTicketButton2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            PurchaseTicketButton2.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            PurchaseTicketButton2.Location = new Point(44, 153);
            PurchaseTicketButton2.Name = "PurchaseTicketButton2";
            PurchaseTicketButton2.Size = new Size(215, 32);
            PurchaseTicketButton2.TabIndex = 8;
            PurchaseTicketButton2.Text = "2 ПОЛЗВАНИЯ";
            PurchaseTicketButton2.UseVisualStyleBackColor = true;
            PurchaseTicketButton2.Click += PurchaseTicketButton_Click;
            // 
            // PurchaseTicketButton
            // 
            PurchaseTicketButton.Anchor = AnchorStyles.None;
            PurchaseTicketButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            PurchaseTicketButton.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            PurchaseTicketButton.Location = new Point(44, 75);
            PurchaseTicketButton.Name = "PurchaseTicketButton";
            PurchaseTicketButton.Size = new Size(215, 32);
            PurchaseTicketButton.TabIndex = 7;
            PurchaseTicketButton.Text = "1 ПОЛЗВАНЕ";
            PurchaseTicketButton.UseVisualStyleBackColor = true;
            PurchaseTicketButton.Click += PurchaseTicketButton_Click;
            // 
            // ticketHeading
            // 
            ticketHeading.Anchor = AnchorStyles.None;
            ticketHeading.AutoSize = true;
            ticketHeading.Font = new Font("Arial Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            ticketHeading.ForeColor = Color.White;
            ticketHeading.Location = new Point(104, 11);
            ticketHeading.Name = "ticketHeading";
            ticketHeading.Size = new Size(94, 30);
            ticketHeading.TabIndex = 5;
            ticketHeading.Text = "БИЛЕТ";
            ticketHeading.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(label1, 0, 3);
            tableLayoutPanel1.Controls.Add(loginHeading, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(200, 100);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(59, 65);
            label1.Name = "label1";
            label1.Size = new Size(81, 30);
            label1.TabIndex = 6;
            label1.Text = "ВХОД";
            // 
            // loginHeading
            // 
            loginHeading.Anchor = AnchorStyles.None;
            loginHeading.AutoSize = true;
            loginHeading.Font = new Font("Arial Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            loginHeading.ForeColor = Color.White;
            loginHeading.Location = new Point(59, 0);
            loginHeading.Name = "loginHeading";
            loginHeading.Size = new Size(81, 20);
            loginHeading.TabIndex = 5;
            loginHeading.Text = "ВХОД";
            // 
            // Ticket
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(48, 132, 212);
            ClientSize = new Size(303, 263);
            Controls.Add(layoutTicket);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Ticket";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Закупуване на билет";
            FormClosed += Ticket_FormClosed;
            layoutTicket.ResumeLayout(false);
            layoutTicket.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel layoutTicket;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label loginHeading;
        private Label ticketHeading;
        private Button PurchaseTicketButton2;
        private Button PurchaseTicketButton;
        private LinkLabel gotoLogin;
    }
}