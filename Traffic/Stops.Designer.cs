namespace Traffic
{
    partial class Stops
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
            TableLayoutPanel layoutBody;
            TreeNode treeNode1 = new TreeNode("20");
            TreeNode treeNode2 = new TreeNode("148");
            TreeNode treeNode3 = new TreeNode("Автобуси", new TreeNode[] { treeNode1, treeNode2 });
            TreeNode treeNode4 = new TreeNode("РОДИНА");
            TreeNode treeNode5 = new TreeNode("ПАТРИАРХ ЕВТИМИЙ");
            TreeNode treeNode6 = new TreeNode("ТРАКИЯ");
            TreeNode treeNode7 = new TreeNode("КАТЕДРАЛАТА");
            TreeNode treeNode8 = new TreeNode("Пл. СЪЕДИНЕНИЕ-2");
            TreeNode treeNode9 = new TreeNode("ПАМЕТНИКА-2");
            TreeNode treeNode10 = new TreeNode("ЯВОР");
            TreeNode treeNode11 = new TreeNode("ЖП. ГАРА-3");
            TreeNode treeNode12 = new TreeNode("БАСЕЙНА");
            TreeNode treeNode13 = new TreeNode("ФЕС. КОМПЛЕКС");
            TreeNode treeNode14 = new TreeNode("АКАДЕМИЯТА");
            TreeNode treeNode15 = new TreeNode("Пл. СЪЕДИНЕНИЕ");
            TreeNode treeNode16 = new TreeNode("ОКР. БОЛНИЦА");
            TreeNode treeNode17 = new TreeNode("ПРОЕКТАНТСКА");
            TreeNode treeNode18 = new TreeNode("СТРУГА");
            TreeNode treeNode19 = new TreeNode("ПОБЕДА");
            TreeNode treeNode20 = new TreeNode("Спирки", new TreeNode[] { treeNode4, treeNode5, treeNode6, treeNode7, treeNode8, treeNode9, treeNode10, treeNode11, treeNode12, treeNode13, treeNode14, treeNode15, treeNode16, treeNode17, treeNode18, treeNode19 });
            panelMap = new Panel();
            boxMap = new PictureBox();
            listStops = new TreeView();
            layoutStops = new TableLayoutPanel();
            layoutMenu = new TableLayoutPanel();
            openTickets = new LinkLabel();
            openStops = new LinkLabel();
            openLines = new LinkLabel();
            layoutBody = new TableLayoutPanel();
            layoutBody.SuspendLayout();
            panelMap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)boxMap).BeginInit();
            layoutStops.SuspendLayout();
            layoutMenu.SuspendLayout();
            SuspendLayout();
            // 
            // layoutBody
            // 
            layoutBody.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            layoutBody.BackColor = Color.FromArgb(94, 159, 221);
            layoutBody.ColumnCount = 2;
            layoutBody.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            layoutBody.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            layoutBody.Controls.Add(panelMap, 1, 0);
            layoutBody.Controls.Add(listStops, 0, 0);
            layoutBody.Dock = DockStyle.Fill;
            layoutBody.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            layoutBody.Location = new Point(3, 48);
            layoutBody.Name = "layoutBody";
            layoutBody.RowCount = 1;
            layoutBody.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            layoutBody.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            layoutBody.Size = new Size(794, 399);
            layoutBody.TabIndex = 1;
            // 
            // panelMap
            // 
            panelMap.AutoScroll = true;
            panelMap.BorderStyle = BorderStyle.Fixed3D;
            panelMap.Controls.Add(boxMap);
            panelMap.Dock = DockStyle.Fill;
            panelMap.Location = new Point(201, 3);
            panelMap.Name = "panelMap";
            panelMap.Size = new Size(590, 393);
            panelMap.TabIndex = 0;
            // 
            // boxMap
            // 
            boxMap.Image = Properties.Resources.map1;
            boxMap.Location = new Point(3, 3);
            boxMap.Name = "boxMap";
            boxMap.Size = new Size(2048, 1536);
            boxMap.SizeMode = PictureBoxSizeMode.Zoom;
            boxMap.TabIndex = 0;
            boxMap.TabStop = false;
            // 
            // listStops
            // 
            listStops.BackColor = Color.FromArgb(94, 159, 221);
            listStops.Cursor = Cursors.Hand;
            listStops.Dock = DockStyle.Fill;
            listStops.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            listStops.ForeColor = Color.White;
            listStops.Location = new Point(3, 3);
            listStops.Name = "listStops";
            treeNode1.Name = "NodeBus20";
            treeNode1.Tag = "Bus20";
            treeNode1.Text = "20";
            treeNode2.Name = "NodeBus148";
            treeNode2.Tag = "Bus148";
            treeNode2.Text = "148";
            treeNode3.Name = "NodeBuses";
            treeNode3.Text = "Автобуси";
            treeNode4.Name = "NodeStop1";
            treeNode4.Tag = "1";
            treeNode4.Text = "РОДИНА";
            treeNode5.Name = "NodeStop2";
            treeNode5.Tag = "2";
            treeNode5.Text = "ПАТРИАРХ ЕВТИМИЙ";
            treeNode6.Name = "NodeStop3";
            treeNode6.Tag = "3";
            treeNode6.Text = "ТРАКИЯ";
            treeNode7.Name = "NodeStop4";
            treeNode7.Tag = "4";
            treeNode7.Text = "КАТЕДРАЛАТА";
            treeNode8.Name = "NodeStop5";
            treeNode8.Tag = "5";
            treeNode8.Text = "Пл. СЪЕДИНЕНИЕ-2";
            treeNode9.Name = "NodeStop6";
            treeNode9.Tag = "6";
            treeNode9.Text = "ПАМЕТНИКА-2";
            treeNode10.Name = "NodeStop7";
            treeNode10.Tag = "7";
            treeNode10.Text = "ЯВОР";
            treeNode11.Name = "NodeStop8";
            treeNode11.Tag = "8";
            treeNode11.Text = "ЖП. ГАРА-3";
            treeNode12.Name = "NodeStop9";
            treeNode12.Tag = "9";
            treeNode12.Text = "БАСЕЙНА";
            treeNode13.Name = "NodeStop10";
            treeNode13.Tag = "10";
            treeNode13.Text = "ФЕС. КОМПЛЕКС";
            treeNode14.Name = "NodeStop11";
            treeNode14.Tag = "11";
            treeNode14.Text = "АКАДЕМИЯТА";
            treeNode15.Name = "NodeStop12";
            treeNode15.Tag = "12";
            treeNode15.Text = "Пл. СЪЕДИНЕНИЕ";
            treeNode16.Name = "NodeStop13";
            treeNode16.Tag = "13";
            treeNode16.Text = "ОКР. БОЛНИЦА";
            treeNode17.Name = "NodeStop14";
            treeNode17.Tag = "14";
            treeNode17.Text = "ПРОЕКТАНТСКА";
            treeNode18.Name = "NodeStop15";
            treeNode18.Tag = "15";
            treeNode18.Text = "СТРУГА";
            treeNode19.Name = "NodeStop16";
            treeNode19.Tag = "16";
            treeNode19.Text = "ПОБЕДА";
            treeNode20.Name = "NodeStops";
            treeNode20.Text = "Спирки";
            listStops.Nodes.AddRange(new TreeNode[] { treeNode3, treeNode20 });
            listStops.Size = new Size(192, 393);
            listStops.TabIndex = 1;
            listStops.DoubleClick += ListStops_DoubleClick;
            // 
            // layoutStops
            // 
            layoutStops.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            layoutStops.ColumnCount = 1;
            layoutStops.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            layoutStops.Controls.Add(layoutMenu, 0, 0);
            layoutStops.Controls.Add(layoutBody, 0, 1);
            layoutStops.Dock = DockStyle.Fill;
            layoutStops.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            layoutStops.Location = new Point(0, 0);
            layoutStops.Name = "layoutStops";
            layoutStops.RowCount = 2;
            layoutStops.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            layoutStops.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            layoutStops.Size = new Size(800, 450);
            layoutStops.TabIndex = 0;
            // 
            // layoutMenu
            // 
            layoutMenu.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            layoutMenu.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            layoutMenu.ColumnCount = 3;
            layoutMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            layoutMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            layoutMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            layoutMenu.Controls.Add(openTickets, 2, 0);
            layoutMenu.Controls.Add(openStops, 0, 0);
            layoutMenu.Controls.Add(openLines, 1, 0);
            layoutMenu.Dock = DockStyle.Fill;
            layoutMenu.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            layoutMenu.Location = new Point(3, 3);
            layoutMenu.Name = "layoutMenu";
            layoutMenu.RowCount = 1;
            layoutMenu.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            layoutMenu.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            layoutMenu.Size = new Size(794, 39);
            layoutMenu.TabIndex = 0;
            // 
            // openTickets
            // 
            openTickets.ActiveLinkColor = Color.White;
            openTickets.Anchor = AnchorStyles.None;
            openTickets.AutoSize = true;
            openTickets.Cursor = Cursors.Hand;
            openTickets.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            openTickets.LinkBehavior = LinkBehavior.NeverUnderline;
            openTickets.LinkColor = Color.White;
            openTickets.Location = new Point(566, 7);
            openTickets.Name = "openTickets";
            openTickets.Size = new Size(189, 24);
            openTickets.TabIndex = 2;
            openTickets.TabStop = true;
            openTickets.Text = "Купи билет/карта";
            openTickets.VisitedLinkColor = Color.White;
            openTickets.LinkClicked += OpenMenu_LinkClicked;
            // 
            // openStops
            // 
            openStops.ActiveLinkColor = Color.White;
            openStops.Anchor = AnchorStyles.None;
            openStops.AutoSize = true;
            openStops.Cursor = Cursors.Hand;
            openStops.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            openStops.LinkBehavior = LinkBehavior.AlwaysUnderline;
            openStops.LinkColor = Color.White;
            openStops.Location = new Point(88, 7);
            openStops.Name = "openStops";
            openStops.Size = new Size(88, 24);
            openStops.TabIndex = 0;
            openStops.TabStop = true;
            openStops.Text = "Спирки";
            openStops.VisitedLinkColor = Color.White;
            // 
            // openLines
            // 
            openLines.ActiveLinkColor = Color.White;
            openLines.Anchor = AnchorStyles.None;
            openLines.AutoSize = true;
            openLines.Cursor = Cursors.Hand;
            openLines.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            openLines.LinkBehavior = LinkBehavior.NeverUnderline;
            openLines.LinkColor = Color.White;
            openLines.Location = new Point(358, 7);
            openLines.Name = "openLines";
            openLines.Size = new Size(77, 24);
            openLines.TabIndex = 1;
            openLines.TabStop = true;
            openLines.Text = "Линии";
            openLines.VisitedLinkColor = Color.White;
            openLines.LinkClicked += OpenLines_LinkClicked;
            // 
            // Stops
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(48, 132, 212);
            ClientSize = new Size(800, 450);
            Controls.Add(layoutStops);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Stops";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спирки";
            FormClosed += Stops_FormClosed;
            layoutBody.ResumeLayout(false);
            panelMap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)boxMap).EndInit();
            layoutStops.ResumeLayout(false);
            layoutMenu.ResumeLayout(false);
            layoutMenu.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel layoutStops;
        private TableLayoutPanel layoutMenu;
        private TableLayoutPanel layoutBody;
        private Panel panelMap;
        private PictureBox boxMap;
        private TreeView listStops;
        private LinkLabel openStops;
        private LinkLabel openLines;
        private LinkLabel openTickets;
    }
}