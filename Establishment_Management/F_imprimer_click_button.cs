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

namespace Establishment_Management
{
    public partial class F_imprimer_click_button : MaterialSkin.Controls.MaterialForm
    {
        public F_imprimer_click_button()
        {
            InitializeComponent();
            var ms = MaterialSkinManager.Instance;
            ms.AddFormToManage(this);
            ms.Theme = MaterialSkinManager.Themes.LIGHT;
            ms.ColorScheme = new ColorScheme(Primary.Teal400, Primary.BlueGrey900, Primary.BlueGrey900, Accent.Orange700, TextShade.BLACK);
        }

        private void F_imprimer_click_button_Load(object sender, EventArgs e)
        {

        }
    }
}
