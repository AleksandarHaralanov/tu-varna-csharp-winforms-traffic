namespace Traffic
{
    public partial class Lines : Form
    {
        public Lines(string bus)
        {
            InitializeComponent();
            switch (bus)
            {
                case "20":
                    changeLine.SelectedIndex = 0;
                    break;
                case "148":
                    changeLine.SelectedIndex = 1;
                    break;
                default:
                    break;
            }
        }

        private void ChangeLine_SelectedIndexChanged(object sender, EventArgs e)
        {
            listStops.Nodes.Clear();
            switch (changeLine.SelectedIndex)
            {
                case 0:
                    TreeNode RootNode1 = new("Спирки");

                    TreeNode A1 = new("ПОБЕДА") { Tag = "16" };
                    TreeNode A2 = new("СТРУГА") { Tag = "15" };
                    TreeNode A3 = new("ПРОЕКТАНТСКА") { Tag = "14" };
                    TreeNode A4 = new("ОКР. БОЛНИЦА") { Tag = "13" };
                    TreeNode A5 = new("Пл. СЪЕДИНЕНИЕ") { Tag = "12" };
                    TreeNode A6 = new("АКАДЕМИЯТА") { Tag = "11" };
                    TreeNode A7 = new("ФЕС. КОМПЛЕКС") { Tag = "10" };
                    TreeNode A8 = new("БАСЕЙНА") { Tag = "9" };
                    TreeNode A9 = new("ЖП. ГАРА-3") { Tag = "8" };

                    RootNode1.Nodes.AddRange(new[] { A1, A2, A3, A4, A5, A6, A7, A8, A9 });
                    listStops.Nodes.Add(RootNode1);

                    listStops.ExpandAll();
                    break;
                case 1:
                    TreeNode RootNode2 = new("Спирки");

                    TreeNode B1 = new("РОДИНА") { Tag = "1" };
                    TreeNode B2 = new("ПАТРИАРХ ЕВТИМИЙ") { Tag = "2" };
                    TreeNode B3 = new("ТРАКИЯ") { Tag = "3" };
                    TreeNode B4 = new("КАТЕДРАЛАТА") { Tag = "4" };
                    TreeNode B5 = new("Пл. СЪЕДИНЕНИЕ-2") { Tag = "5" };
                    TreeNode B6 = new("ПАМЕТНИКА-2") { Tag = "6" };
                    TreeNode B7 = new("ЯВОР") { Tag = "7" };

                    RootNode2.Nodes.AddRange(new[] { B1, B2, B3, B4, B5, B6, B7 });
                    listStops.Nodes.Add(RootNode2);

                    listStops.ExpandAll();
                    break;
                default:
                    break;
            }
        }

        private void ListStops_DoubleClick(object sender, EventArgs e)
        {
            TreeNode selectedNode = listStops.SelectedNode;

            switch (selectedNode.Tag.ToString())
            {
                case "1":
                    panelMap.AutoScrollPosition = new Point(222, 456);
                    break;
                case "2":
                    panelMap.AutoScrollPosition = new Point(387, 556);
                    break;
                case "3":
                    panelMap.AutoScrollPosition = new Point(532, 629);
                    break;
                case "4":
                    panelMap.AutoScrollPosition = new Point(597, 752);
                    break;
                case "5":
                    panelMap.AutoScrollPosition = new Point(831, 697);
                    break;
                case "6":
                    panelMap.AutoScrollPosition = new Point(1022, 506);
                    break;
                case "7":
                    panelMap.AutoScrollPosition = new Point(1145, 419);
                    break;
                case "8":
                    panelMap.AutoScrollPosition = new Point(662, 1044);
                    break;
                case "9":
                    panelMap.AutoScrollPosition = new Point(842, 1044);
                    break;
                case "10":
                    panelMap.AutoScrollPosition = new Point(869, 912);
                    break;
                case "11":
                    panelMap.AutoScrollPosition = new Point(927, 761);
                    break;
                case "12":
                    panelMap.AutoScrollPosition = new Point(831, 656);
                    break;
                case "13":
                    panelMap.AutoScrollPosition = new Point(735, 574);
                    break;
                case "14":
                    panelMap.AutoScrollPosition = new Point(655, 497);
                    break;
                case "15":
                    panelMap.AutoScrollPosition = new Point(525, 369);
                    break;
                case "16":
                    panelMap.AutoScrollPosition = new Point(460, 182);
                    break;
                default:
                    break;
            }
        }

        private void OpenStops_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new Stops().Show();
        }

        private void OpenMenu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new Menu().Show();
        }

        private void Line_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
