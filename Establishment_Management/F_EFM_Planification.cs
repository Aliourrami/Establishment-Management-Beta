using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Animations;
using MaterialSkin.Controls;
using MaterialSkin;

namespace Establishment_Management
{
    public partial class F_EFM_Planification : MaterialForm
    {
        public F_EFM_Planification()
        {
            InitializeComponent();
            //using MaterialSkin;
            var ms = MaterialSkinManager.Instance;
            ms.AddFormToManage(this);
            ms.Theme = MaterialSkinManager.Themes.LIGHT;
            ms.ColorScheme = new ColorScheme(Primary.Teal400, Primary.BlueGrey900, Primary.BlueGrey900, Accent.Orange700, TextShade.BLACK);
        }
        BindingSource bs = new BindingSource();
        EFP_FinalEntities gef = new EFP_FinalEntities();
        //GestionEFP_FinalEntities1 gef = new GestionEFP_FinalEntities1();
        public void dgv()
        {
            dgv_Efm_Plan.DataSource = bs;
        }
        private void F_EFM_Planification_Load(object sender, EventArgs e)
        {
            cmb_module.DisplayMember = "nomMdl";
            cmb_module.ValueMember = "numMdl";
            cmb_module.DataSource = gef.Module.ToList();

            cmb_NumFiliere.DisplayMember = "nomflr";
            cmb_NumFiliere.ValueMember = "numflr";
            cmb_NumFiliere.DataSource = gef.Filiere.ToList();

            cmb_groupe.DisplayMember = "nomGrp";
            cmb_groupe.ValueMember = "numGrp";
            cmb_groupe.DataSource = gef.Groupe.ToList();
            dgv();
            bs.DataSource = gef.EFM_Planification.Local;
            bs.DataSource = gef.EFM_Planification.ToList();
            cmb_module.DataBindings.Add("SelectedValue", bs, "numMdl");
            cmb_NumFiliere.DataBindings.Add("SelectedValue", bs, "numflr");
            cmb_groupe.DataBindings.Add("SelectedValue", bs, "numGrp");
            dtp_date_prévue.DataBindings.Add("text", bs, "date_prevue");
            dtp_date_effective.DataBindings.Add("text", bs, "date_efective");
            
        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {

        }

        private void btn_Ajouter_Click(object sender, EventArgs e)
        {
            var efm = new EFM_Planification
            {
                numMdl = (int)cmb_module.SelectedValue,
                numFlr = cmb_NumFiliere.Text,
                numGrp = (int)cmb_groupe.SelectedValue,
                date_prevue = dtp_date_prévue.Value,
                date_efective = dtp_date_effective.Value
            };
            gef.EFM_Planification.Add(efm);
            gef.SaveChanges();
            dgv();

        }

        private void btn_Modifier_Click(object sender, EventArgs e)
        {
            var mdl = gef.EFM_Planification.Find(cmb_module.SelectedValue);
            if(mdl!=null)
            {
                mdl.numMdl = (int)cmb_module.SelectedValue;
                mdl.numFlr = (string)cmb_NumFiliere.SelectedValue;
                mdl.numGrp = (int)cmb_groupe.SelectedValue;
                mdl.date_prevue = dtp_date_prévue.Value;
                mdl.date_efective = dtp_date_effective.Value;
                gef.SaveChanges();
                dgv();
            };
            
        }

        private void btn_Supprimer_Click(object sender, EventArgs e)
        {
            var mdl = gef.EFM_Planification.Find(cmb_module.SelectedValue);
            if (mdl != null)
            {
                gef.EFM_Planification.Remove(mdl);
                gef.SaveChanges();
                dgv();
            }
        }

        private void btn_Nouveau_Click(object sender, EventArgs e)
        {
            bs.AddNew();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            var mdl = gef.EFM_Planification.Find(tb_Search.Text);
            if(mdl!=null)
            {
                cmb_module.Text = mdl.Module.ToString();
                cmb_NumFiliere.Text = mdl.numFlr.ToString();
                cmb_groupe.Text = mdl.Groupe.ToString();
                dtp_date_prévue.Text = mdl.date_prevue.ToString();
                dtp_date_effective.Text = mdl.date_efective.ToString();
            }
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
    }
}
