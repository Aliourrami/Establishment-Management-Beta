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
    public partial class F_Affectation : MaterialSkin.Controls.MaterialForm
    {
        public F_Affectation()
        {
            InitializeComponent();
            //using MaterialSkin;
            var ms = MaterialSkinManager.Instance;
            ms.AddFormToManage(this);
            ms.Theme = MaterialSkinManager.Themes.LIGHT;
            ms.ColorScheme = new ColorScheme(Primary.Teal400, Primary.BlueGrey900, Primary.BlueGrey900, Accent.Orange700, TextShade.BLACK);
        }
        BindingSource bs = new BindingSource();
        //GestionEFP_FinalEntities1 gef = new GestionEFP_FinalEntities1();
        EFP_FinalEntities gef = new EFP_FinalEntities();
        public void dgv()
        {

            dgv_Aff.DataSource = bs.DataSource = gef.Affectation.Select(aff => new { aff.numAff, aff.Groupe.nomGrp, aff.numFlr, aff.Module.nomMdl, aff.Formateur.nomfrm, aff.dateAff }).ToList();
            //dgv_Aff.DataSource = gef.Affectation.ToList();
            //dgv_Aff.DataSource = bs;
        }
        private void F_Affectation_Load(object sender, EventArgs e)
        {
            cmb_mdl.DisplayMember = "nomMdl";
            cmb_mdl.ValueMember = "numMdl";
            cmb_mdl.DataSource = gef.Module.ToList();

            cmb_filiere.DisplayMember = "nomflr";
            cmb_filiere.ValueMember = "numflr";
            cmb_filiere.DataSource = gef.Filiere.ToList();

            cmb_groupe.DisplayMember = "nomGrp";
            cmb_groupe.ValueMember = "numGrp";
            cmb_groupe.DataSource = gef.Groupe.ToList();

            cmb_Formateur.DisplayMember = "nomfrm";
            cmb_Formateur.ValueMember = "numfrm";
            cmb_Formateur.DataSource = gef.Formateur.ToList();
            //cmb_Formateur.DataSource=gef.Formateur.Select(f=>f.cin........)

            //Program.DS();
            dgv();
            //bs.DataSource = Program.ds.Tables["Affectation"];
            //bs.DataSource = gef.Affectation.Select(aff => new { aff.numAff, aff.Groupe.nomGrp, aff.numFlr, aff.Module.nomMdl, aff.Formateur.nomfrm, aff.dateAff }).ToList();
            bs.DataSource = gef.Affectation.ToList();
            bs.DataSource = gef.Affectation.Local;
            //bs.DataSource = gef.Affectation.Select(aff => new { aff.numAff, aff.Groupe.nomGrp, aff.numFlr, aff.Module.nomMdl, aff.Formateur.nomfrm, aff.dateAff }).l;
            tb_numaff.DataBindings.Add("text", bs, "numAff",true);
            cmb_groupe.DataBindings.Add("SelectedValue", bs, "numGrp", true);
            cmb_filiere.DataBindings.Add("SelectedValue", bs, "numFlr", true);
            cmb_mdl.DataBindings.Add("SelectedValue", bs, "numMdl", true);
            cmb_Formateur.DataBindings.Add("SelectedValue", bs, "numFrm", true);
            dtp_date_aff.DataBindings.Add("text", bs, "dateAff", true);
        }

        private void btn_Ajouter_Click(object sender, EventArgs e)
        {
            bs.EndEdit();
            gef.SaveChanges();
            dgv();
        }

        private void btn_Modifier_Click(object sender, EventArgs e)
        {
            bs.EndEdit();
            gef.SaveChanges();
            dgv();
        }

        private void btn_Supprimer_Click(object sender, EventArgs e)
        {
            bs.RemoveCurrent();
            gef.SaveChanges();
            dgv();
        }

        private void btn_Nouveau_Click(object sender, EventArgs e)
        {
            bs.AddNew();
        }

        private void first_Click(object sender, EventArgs e)
        {
            bs.MoveFirst();
        }

        private void previous_Click(object sender, EventArgs e)
        {
            bs.MovePrevious();
        }

        private void next_Click(object sender, EventArgs e)
        {
            bs.MoveNext();
        }

        private void last_Click(object sender, EventArgs e)
        {
            bs.MoveLast();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            F_FiliereEtGroupeParFormateur ffgf = new F_FiliereEtGroupeParFormateur();
            ffgf.Show();
        }
    }
}
