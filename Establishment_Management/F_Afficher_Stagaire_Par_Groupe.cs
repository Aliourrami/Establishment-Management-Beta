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
    public partial class F_Afficher_Stagaire_Par_Groupe : MaterialSkin.Controls.MaterialForm
    {
        public F_Afficher_Stagaire_Par_Groupe()
        {
            InitializeComponent();
            var ms = MaterialSkinManager.Instance;
            ms.AddFormToManage(this);
            ms.Theme = MaterialSkinManager.Themes.LIGHT;
            ms.ColorScheme = new ColorScheme(Primary.Teal400, Primary.BlueGrey900, Primary.BlueGrey900, Accent.Orange700, TextShade.BLACK);
        }

        private void F_Afficher_Stagaire_Par_Groupe_Load(object sender, EventArgs e)
        {
           
        }

        private void tb_NomGroupe_TextChanged(object sender, EventArgs e)
        {
            string req = @"select stg.nomStg,stg.prenomStg,stg.cin,stg.dateNStg from stagaire stg join groupe gp on stg.numGrp=gp.numGrp 
                    where gp.nomGrp = '" + tb_NomGroupe.Text + "'";
            grv_stagaire.DataSource = Program.exec_select(req);
            for (int i = 1; i <= grv_stagaire.Rows.Count; i++)
            {
                lbl_nbr.Text = i.ToString();
            }
        }

        private void lbl_nbr_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
