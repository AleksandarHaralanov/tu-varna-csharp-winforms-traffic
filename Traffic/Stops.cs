namespace Traffic
{
    public partial class Stops : Form
    {
        public Stops()
        {
            InitializeComponent();
            listStops.ExpandAll();
        }

        private void ListStops_DoubleClick(object sender, EventArgs e)
        {
            TreeNode selectedNode = listStops.SelectedNode;

            switch (selectedNode.Tag.ToString())
            {
                case "Bus20":
                    this.Hide();
                    new Lines("20").Show();
                    break;
                case "Bus148":
                    this.Hide();
                    new Lines("148").Show();
                    break;
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

        private void OpenLines_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new Lines("").Show();
        }

        private void OpenMenu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new Menu().Show();
        }

        private void Stops_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
