using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;

namespace Establishment_Management
{
    public partial class F_Seance : MaterialSkin.Controls.MaterialForm
    {
        public F_Seance()
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
            dgv_Sc.DataSource = bs;
            //dgv_Sc.DataSource = gef.Affectation.ToList();
        }
        private void F_Seance_Load(object sender, EventArgs e)
        {
            //cmb_NumAff.DisplayMember = "numAff";
            cmb_NumAff.ValueMember = "numAff";
            cmb_NumAff.DataSource = gef.Affectation.ToList();

            dgv();

            bs.DataSource = gef.Seance.ToList();
            bs.DataSource = gef.Seance.Local;
            tb_numSc.DataBindings.Add("text", bs, "numSc", true);
            cmb_NumAff.DataBindings.Add("SelectedValue", bs, "numAff", true);
            dtp_date_Sc.DataBindings.Add("text", bs, "dateSc", true);
            tb_durée.DataBindings.Add("text", bs, "duree", true);
            tb_salle.DataBindings.Add("text", bs, "salle", true);
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
