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
    public partial class F_Groupe : MaterialSkin.Controls.MaterialForm
    {
        public F_Groupe()
        {
            InitializeComponent();
            //using MaterialSkin;
            var ms = MaterialSkinManager.Instance;
            ms.AddFormToManage(this);
            ms.Theme = MaterialSkinManager.Themes.LIGHT;
            ms.ColorScheme = new ColorScheme(Primary.Teal400, Primary.BlueGrey900, Primary.BlueGrey900, Accent.Orange700, TextShade.BLACK);

        }
        EFP_FinalEntities gef = new EFP_FinalEntities();
        //GestionEFP_FinalEntities1 gef = new GestionEFP_FinalEntities1();
        BindingSource bs = new BindingSource();
        public void DGV_Act()
        {
            dgv_grp.DataSource = bs;
            //dgv_grp.DataSource = gef.Groupe.ToList();
            //bs.DataSource = gef.Groupe.ToList();
        }
        private void F_Groupe_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestionEFPDataSet.Filiere'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            //this.filiereTableAdapter.Fill(this.gestionEFPDataSet.Filiere);
            DGV_Act();
            cbx_filiere.DisplayMember = "nomflr";
            cbx_filiere.ValueMember = "numflr";
            cbx_filiere.DataSource = gef.Filiere.ToList();

            bs.DataSource = gef.Groupe.ToList();
            bs.DataSource = gef.Groupe.Local;
            tb_numGrp.DataBindings.Add("text", bs, "numgrp", true);
            tb_nomGrp.DataBindings.Add("text", bs, "nomgrp", true);
            cbx_filiere.DataBindings.Add("SelectedValue", bs, "numflr",true);
            tb_anneeGrp.DataBindings.Add("text", bs, "annee",true);
        }

        private void btn_Ajouter_Click(object sender, EventArgs e)
        {
            bs.EndEdit(); DGV_Act();
            gef.SaveChanges();
        }

        private void btn_Modifier_Click(object sender, EventArgs e)
        {
            bs.EndEdit(); DGV_Act(); gef.SaveChanges();
        }

        private void btn_Supprimer_Click(object sender, EventArgs e)
        {
            bs.RemoveCurrent(); DGV_Act(); gef.SaveChanges();
        }

        private void btn_Nouveau_Click(object sender, EventArgs e)
        {
            bs.AddNew();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            //S2
            var s = gef.Groupe.Find(int.Parse(tb_Search.Text));
            if (s != null)
            {
                bs.Position = bs.IndexOf(s);
            }
            else
                MessageBox.Show("Client inexistant");

            //S2
            //bs.Position = bs.IndexOf(gef.Groupe.Find(int.Parse(tb_Search.Text)));
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

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            F_Afficher_Stagaire_Par_Groupe fasg = new F_Afficher_Stagaire_Par_Groupe();
            fasg.Show();
        }
    }
}
