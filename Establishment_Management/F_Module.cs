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
    public partial class F_Module : MaterialSkin.Controls.MaterialForm
    {
        public F_Module()
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
            dgv_Mdl.DataSource = bs;
        }
        private void F_Module_Load(object sender, EventArgs e)
        {

            cmb_filiere.DisplayMember = "nomflr";
            cmb_filiere.ValueMember = "numflr";
            cmb_filiere.DataSource = gef.Filiere.ToList();

            dgv();

            bs.DataSource = gef.Module.ToList();
            bs.DataSource = gef.Module.Local;
            tb_numMdl.DataBindings.Add("text", bs, "numMdl", true);
            cmb_filiere.DataBindings.Add("SelectedValue", bs, "numflr", true);
            tb_Année.DataBindings.Add("text", bs, "anneeMdl", true);
            tb_nomMdl.DataBindings.Add("text", bs, "nomMdl", true);
            tb_MasseHoraire.DataBindings.Add("text", bs, "MH", true);
            tb_Coefficient.DataBindings.Add("text", bs, "coeficientMdl", true);
            tb_Semestre.DataBindings.Add("text", bs, "semestreMdl", true);
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

        private void btn_search_Click(object sender, EventArgs e)
        {
            //bs.Position = bs.Find("numMdl", tb_Search.Text);
            bs.Position = bs.IndexOf(tb_Search.Text);
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
    }
}
