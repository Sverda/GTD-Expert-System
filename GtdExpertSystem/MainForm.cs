using System;
using MaterialSkin;
using MaterialSkin.Controls;

namespace GtdExpertSystem
{
    public partial class MainForm : MaterialForm
    {
        private readonly MaterialSkinManager _skimManager;

        public MainForm()
        {
            InitializeComponent();
            _skimManager = MaterialSkinManager.Instance;
            _skimManager.AddFormToManage(this);
            _skimManager.Theme = MaterialSkinManager.Themes.LIGHT;
            _skimManager.ColorScheme = new ColorScheme(Primary.Green600, Primary.Green600, Primary.Green900, Accent.LightBlue200, TextShade.WHITE);
        }

        private void yesButton1_Click(object sender, EventArgs e)
        {
            materialTabControl1.SelectedIndex = 3;
        }

        private void noButton1_Click(object sender, EventArgs e)
        {
            materialTabControl1.SelectedIndex = 1;
        }

        private void yesButton2_Click(object sender, EventArgs e)
        {
            materialTabControl1.SelectedIndex = 2;
        }

        private void noButton2_Click(object sender, EventArgs e)
        {
            materialTabControl1.SelectedIndex = 7;
        }

        private void yesButton3_Click(object sender, EventArgs e)
        {
            materialTabControl1.SelectedIndex = 7;
        }

        private void noButton3_Click(object sender, EventArgs e)
        {
            materialTabControl1.SelectedIndex = 7;
        }

        private void yesButton4_Click(object sender, EventArgs e)
        {
            materialTabControl1.SelectedIndex = 7;
        }

        private void noButton4_Click(object sender, EventArgs e)
        {
            materialTabControl1.SelectedIndex = 4;
        }

        private void yesButton5_Click(object sender, EventArgs e)
        {
            materialTabControl1.SelectedIndex = 7;
        }

        private void noButton5_Click(object sender, EventArgs e)
        {
            materialTabControl1.SelectedIndex = 5;
        }

        private void noButton6_Click(object sender, EventArgs e)
        {
            materialTabControl1.SelectedIndex = 7;
        }

        private void yesButton6_Click(object sender, EventArgs e)
        {
            materialTabControl1.SelectedIndex = 6;
        }

        private void yesButton7_Click(object sender, EventArgs e)
        {
            materialTabControl1.SelectedIndex = 7;
        }

        private void noButton7_Click(object sender, EventArgs e)
        {
            materialTabControl1.SelectedIndex = 7;
        }
    }
}
