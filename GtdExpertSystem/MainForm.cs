using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
    }
}
