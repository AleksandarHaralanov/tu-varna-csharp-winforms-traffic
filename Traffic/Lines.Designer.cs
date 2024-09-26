namespace Traffic
{
    partial class Lines
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
            panelMap = new Panel();
            boxMap = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            changeLine = new ComboBox();
            listStops = new TreeView();
            layoutStops = new TableLayoutPanel();
            layoutMenu = new TableLayoutPanel();
            OpenMenu = new LinkLabel();
            openStops = new LinkLabel();
            openLines = new LinkLabel();
            layoutBody = new TableLayoutPanel();
            layoutBody.SuspendLayout();
            panelMap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)boxMap).BeginInit();
            tableLayoutPanel1.SuspendLayout();
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
            layoutBody.Controls.Add(tableLayoutPanel1, 0, 0);
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
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(changeLine, 0, 0);
            tableLayoutPanel1.Controls.Add(listStops, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            tableLayoutPanel1.Size = new Size(192, 393);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // changeLine
            // 
            changeLine.Anchor = AnchorStyles.None;
            changeLine.DropDownStyle = ComboBoxStyle.DropDownList;
            changeLine.FormattingEnabled = true;
            changeLine.Items.AddRange(new object[] { "20", "148" });
            changeLine.Location = new Point(3, 8);
            changeLine.Name = "changeLine";
            changeLine.Size = new Size(186, 23);
            changeLine.TabIndex = 0;
            changeLine.SelectedIndexChanged += ChangeLine_SelectedIndexChanged;
            // 
            // listStops
            // 
            listStops.BackColor = Color.FromArgb(94, 159, 221);
            listStops.BorderStyle = BorderStyle.FixedSingle;
            listStops.Dock = DockStyle.Fill;
            listStops.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            listStops.ForeColor = Color.White;
            listStops.Location = new Point(3, 42);
            listStops.Name = "listStops";
            listStops.Size = new Size(186, 348);
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
            layoutStops.TabIndex = 1;
            // 
            // layoutMenu
            // 
            layoutMenu.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            layoutMenu.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            layoutMenu.ColumnCount = 3;
            layoutMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            layoutMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            layoutMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            layoutMenu.Controls.Add(OpenMenu, 2, 0);
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
            // OpenMenu
            // 
            OpenMenu.ActiveLinkColor = Color.White;
            OpenMenu.Anchor = AnchorStyles.None;
            OpenMenu.AutoSize = true;
            OpenMenu.Cursor = Cursors.Hand;
            OpenMenu.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            OpenMenu.LinkBehavior = LinkBehavior.NeverUnderline;
            OpenMenu.LinkColor = Color.White;
            OpenMenu.Location = new Point(566, 7);
            OpenMenu.Name = "OpenMenu";
            OpenMenu.Size = new Size(189, 24);
            OpenMenu.TabIndex = 3;
            OpenMenu.TabStop = true;
            OpenMenu.Text = "Купи билет/карта";
            OpenMenu.VisitedLinkColor = Color.White;
            OpenMenu.LinkClicked += OpenMenu_LinkClicked;
            // 
            // openStops
            // 
            openStops.ActiveLinkColor = Color.White;
            openStops.Anchor = AnchorStyles.None;
            openStops.AutoSize = true;
            openStops.Cursor = Cursors.Hand;
            openStops.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            openStops.LinkBehavior = LinkBehavior.NeverUnderline;
            openStops.LinkColor = Color.White;
            openStops.Location = new Point(88, 7);
            openStops.Name = "openStops";
            openStops.Size = new Size(88, 24);
            openStops.TabIndex = 0;
            openStops.TabStop = true;
            openStops.Text = "Спирки";
            openStops.VisitedLinkColor = Color.White;
            openStops.LinkClicked += OpenStops_LinkClicked;
            // 
            // openLines
            // 
            openLines.ActiveLinkColor = Color.White;
            openLines.Anchor = AnchorStyles.None;
            openLines.AutoSize = true;
            openLines.Cursor = Cursors.Hand;
            openLines.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            openLines.LinkBehavior = LinkBehavior.AlwaysUnderline;
            openLines.LinkColor = Color.White;
            openLines.Location = new Point(358, 7);
            openLines.Name = "openLines";
            openLines.Size = new Size(77, 24);
            openLines.TabIndex = 1;
            openLines.TabStop = true;
            openLines.Text = "Линии";
            openLines.VisitedLinkColor = Color.White;
            // 
            // Line
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(48, 132, 212);
            ClientSize = new Size(800, 450);
            Controls.Add(layoutStops);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Line";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Линии";
            FormClosed += Line_FormClosed;
            layoutBody.ResumeLayout(false);
            panelMap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)boxMap).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            layoutStops.ResumeLayout(false);
            layoutMenu.ResumeLayout(false);
            layoutMenu.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel layoutStops;
        private TableLayoutPanel layoutMenu;
        private LinkLabel openStops;
        private LinkLabel openLines;
        private Panel panelMap;
        private PictureBox boxMap;
        private TableLayoutPanel tableLayoutPanel1;
        private ComboBox changeLine;
        private TreeView listStops;
        private LinkLabel OpenMenu;
    }
}