namespace Traffic
{
    partial class Menu
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
            layoutMenu = new TableLayoutPanel();
            gotоStops = new LinkLabel();
            button1 = new Button();
            PurchaseTicketButton = new Button();
            menuHeading = new Label();
            layoutMenu.SuspendLayout();
            SuspendLayout();
            // 
            // layoutMenu
            // 
            layoutMenu.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            layoutMenu.ColumnCount = 1;
            layoutMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            layoutMenu.Controls.Add(gotоStops, 0, 3);
            layoutMenu.Controls.Add(button1, 0, 2);
            layoutMenu.Controls.Add(PurchaseTicketButton, 0, 1);
            layoutMenu.Controls.Add(menuHeading, 0, 0);
            layoutMenu.Dock = DockStyle.Fill;
            layoutMenu.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            layoutMenu.Location = new Point(0, 0);
            layoutMenu.Name = "layoutMenu";
            layoutMenu.RowCount = 4;
            layoutMenu.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            layoutMenu.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            layoutMenu.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            layoutMenu.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            layoutMenu.Size = new Size(275, 230);
            layoutMenu.TabIndex = 0;
            // 
            // gotоStops
            // 
            gotоStops.ActiveLinkColor = Color.White;
            gotоStops.Anchor = AnchorStyles.None;
            gotоStops.AutoSize = true;
            gotоStops.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            gotоStops.LinkBehavior = LinkBehavior.NeverUnderline;
            gotоStops.LinkColor = Color.White;
            gotоStops.Location = new Point(82, 197);
            gotоStops.Name = "gotоStops";
            gotоStops.Size = new Size(111, 20);
            gotоStops.TabIndex = 8;
            gotоStops.TabStop = true;
            gotоStops.Text = "Върни се назад";
            gotоStops.VisitedLinkColor = Color.White;
            gotоStops.LinkClicked += GotоStops_LinkClicked;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button1.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(30, 133);
            button1.Name = "button1";
            button1.Size = new Size(215, 32);
            button1.TabIndex = 7;
            button1.Text = "ЗАКУПУВАНЕ НА АБОНАМЕНТ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += PurchaseSubscriptionButton_Click;
            // 
            // PurchaseTicketButton
            // 
            PurchaseTicketButton.Anchor = AnchorStyles.None;
            PurchaseTicketButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            PurchaseTicketButton.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            PurchaseTicketButton.Location = new Point(30, 64);
            PurchaseTicketButton.Name = "PurchaseTicketButton";
            PurchaseTicketButton.Size = new Size(215, 32);
            PurchaseTicketButton.TabIndex = 6;
            PurchaseTicketButton.Text = "ЗАКУПУВАНЕ НА БИЛЕТ";
            PurchaseTicketButton.UseVisualStyleBackColor = true;
            PurchaseTicketButton.Click += PurchaseTicketButton_Click;
            // 
            // menuHeading
            // 
            menuHeading.Anchor = AnchorStyles.None;
            menuHeading.AutoSize = true;
            menuHeading.Font = new Font("Arial Black", 18F, FontStyle.Bold, GraphicsUnit.Point);
            menuHeading.ForeColor = Color.White;
            menuHeading.Location = new Point(86, 6);
            menuHeading.Name = "menuHeading";
            menuHeading.Size = new Size(103, 33);
            menuHeading.TabIndex = 5;
            menuHeading.Text = "МЕНЮ";
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(48, 132, 212);
            ClientSize = new Size(275, 230);
            Controls.Add(layoutMenu);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Menu";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Меню";
            FormClosed += Menu_FormClosed;
            layoutMenu.ResumeLayout(false);
            layoutMenu.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel layoutMenu;
        private Label menuHeading;
        private Button PurchaseTicketButton;
        private Button button1;
        private LinkLabel gotоStops;
    }
}