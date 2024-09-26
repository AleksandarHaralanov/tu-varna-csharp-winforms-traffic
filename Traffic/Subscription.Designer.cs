namespace Traffic
{
    partial class Subscription
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
            layoutSubscription = new TableLayoutPanel();
            PurchaseSubscriptionButton3 = new Button();
            gotoStops = new LinkLabel();
            PurchaseSubscriptionButton2 = new Button();
            PurchaseSubscriptionButton = new Button();
            subscriptionHeading = new Label();
            layoutSubscription.SuspendLayout();
            SuspendLayout();
            // 
            // layoutSubscription
            // 
            layoutSubscription.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            layoutSubscription.ColumnCount = 1;
            layoutSubscription.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            layoutSubscription.Controls.Add(PurchaseSubscriptionButton3, 0, 3);
            layoutSubscription.Controls.Add(gotoStops, 0, 4);
            layoutSubscription.Controls.Add(PurchaseSubscriptionButton2, 0, 2);
            layoutSubscription.Controls.Add(PurchaseSubscriptionButton, 0, 1);
            layoutSubscription.Controls.Add(subscriptionHeading, 0, 0);
            layoutSubscription.Dock = DockStyle.Fill;
            layoutSubscription.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            layoutSubscription.Location = new Point(0, 0);
            layoutSubscription.Name = "layoutSubscription";
            layoutSubscription.RowCount = 5;
            layoutSubscription.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            layoutSubscription.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            layoutSubscription.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            layoutSubscription.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            layoutSubscription.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            layoutSubscription.Size = new Size(305, 312);
            layoutSubscription.TabIndex = 1;
            // 
            // PurchaseSubscriptionButton3
            // 
            PurchaseSubscriptionButton3.Anchor = AnchorStyles.None;
            PurchaseSubscriptionButton3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            PurchaseSubscriptionButton3.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            PurchaseSubscriptionButton3.Location = new Point(45, 201);
            PurchaseSubscriptionButton3.Name = "PurchaseSubscriptionButton3";
            PurchaseSubscriptionButton3.Size = new Size(215, 32);
            PurchaseSubscriptionButton3.TabIndex = 10;
            PurchaseSubscriptionButton3.Text = "1 ГОДИНА";
            PurchaseSubscriptionButton3.UseVisualStyleBackColor = true;
            PurchaseSubscriptionButton3.Click += PurchaseSubscriptionButton_Click;
            // 
            // gotoStops
            // 
            gotoStops.ActiveLinkColor = Color.White;
            gotoStops.Anchor = AnchorStyles.None;
            gotoStops.AutoSize = true;
            gotoStops.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            gotoStops.LinkBehavior = LinkBehavior.NeverUnderline;
            gotoStops.LinkColor = Color.White;
            gotoStops.Location = new Point(97, 270);
            gotoStops.Name = "gotoStops";
            gotoStops.Size = new Size(111, 20);
            gotoStops.TabIndex = 9;
            gotoStops.TabStop = true;
            gotoStops.Text = "Върни се назад";
            gotoStops.TextAlign = ContentAlignment.MiddleCenter;
            gotoStops.VisitedLinkColor = Color.White;
            gotoStops.LinkClicked += GotoStops_LinkClicked;
            // 
            // PurchaseSubscriptionButton2
            // 
            PurchaseSubscriptionButton2.Anchor = AnchorStyles.None;
            PurchaseSubscriptionButton2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            PurchaseSubscriptionButton2.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            PurchaseSubscriptionButton2.Location = new Point(45, 139);
            PurchaseSubscriptionButton2.Name = "PurchaseSubscriptionButton2";
            PurchaseSubscriptionButton2.Size = new Size(215, 32);
            PurchaseSubscriptionButton2.TabIndex = 8;
            PurchaseSubscriptionButton2.Text = "6 МЕСЕЦА";
            PurchaseSubscriptionButton2.UseVisualStyleBackColor = true;
            PurchaseSubscriptionButton2.Click += PurchaseSubscriptionButton_Click;
            // 
            // PurchaseSubscriptionButton
            // 
            PurchaseSubscriptionButton.Anchor = AnchorStyles.None;
            PurchaseSubscriptionButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            PurchaseSubscriptionButton.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            PurchaseSubscriptionButton.Location = new Point(45, 77);
            PurchaseSubscriptionButton.Name = "PurchaseSubscriptionButton";
            PurchaseSubscriptionButton.Size = new Size(215, 32);
            PurchaseSubscriptionButton.TabIndex = 7;
            PurchaseSubscriptionButton.Text = "1 МЕСЕЦ";
            PurchaseSubscriptionButton.UseVisualStyleBackColor = true;
            PurchaseSubscriptionButton.Click += PurchaseSubscriptionButton_Click;
            // 
            // subscriptionHeading
            // 
            subscriptionHeading.Anchor = AnchorStyles.None;
            subscriptionHeading.AutoSize = true;
            subscriptionHeading.Font = new Font("Arial Black", 14F, FontStyle.Bold, GraphicsUnit.Point);
            subscriptionHeading.ForeColor = Color.White;
            subscriptionHeading.Location = new Point(22, 17);
            subscriptionHeading.Name = "subscriptionHeading";
            subscriptionHeading.Size = new Size(260, 27);
            subscriptionHeading.TabIndex = 5;
            subscriptionHeading.Text = "АБОНАМЕНТНА КАРТА";
            subscriptionHeading.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Subscription
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(48, 132, 212);
            ClientSize = new Size(305, 312);
            Controls.Add(layoutSubscription);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Subscription";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Абонаментна карта";
            FormClosed += Subscription_FormClosed;
            layoutSubscription.ResumeLayout(false);
            layoutSubscription.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel layoutSubscription;
        private LinkLabel gotoStops;
        private Button PurchaseSubscriptionButton2;
        private Button PurchaseSubscriptionButton;
        private Label subscriptionHeading;
        private Button PurchaseSubscriptionButton3;
    }
}