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
    public partial class F_FiliereEtGroupeParFormateur : MaterialSkin.Controls.MaterialForm
    {
        public F_FiliereEtGroupeParFormateur()
        {
            InitializeComponent();
            var ms = MaterialSkinManager.Instance;
            ms.AddFormToManage(this);
            ms.Theme = MaterialSkinManager.Themes.LIGHT;
            ms.ColorScheme = new ColorScheme(Primary.Teal400, Primary.BlueGrey900, Primary.BlueGrey900, Accent.Orange700, TextShade.BLACK);
        }

        private void F_FiliereEtGroupeParFormateur_Load(object sender, EventArgs e)
        {

        }

        private void bunifuCustomDataGrid1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void tb_formateur_TextChanged(object sender, EventArgs e)
        {
            string req = @"select fr.nomfrm, fr.cin, flr.nomFlr, gp.nomGrp from formateur fr join affectation aff on fr.numFrm=aff.numFrm join groupe gp on aff.numGrp=gp.numGrp join Filiere flr on aff.numFlr=flr.numFlr 
                        where fr.nomfrm='" + tb_formateur.Text + "'";
            bunifuCustomDataGrid1.DataSource = Program.exec_select(req);
        }
    }
}
