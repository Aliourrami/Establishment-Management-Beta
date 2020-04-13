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
using MaterialSkin.Animations;
using MaterialSkin.Controls;
using MaterialSkin;

namespace Establishment_Management
{
    public partial class F_Stagaire : MaterialForm
    {
        public F_Stagaire()
        {
            InitializeComponent();
            //using MaterialSkin;
            var ms = MaterialSkinManager.Instance;
            ms.AddFormToManage(this);
            ms.Theme = MaterialSkinManager.Themes.LIGHT;
            ms.ColorScheme = new ColorScheme(Primary.Teal400, Primary.BlueGrey900, Primary.BlueGrey900, Accent.Orange700, TextShade.BLACK);
        }
        BindingSource bs = new BindingSource();
        public void BS()
        {
            bs.DataSource = Program.ds.Tables["Stagaire"];
            tb_NumStg.DataBindings.Add("text", bs, "numStg",true);
            tb_NomStg.DataBindings.Add("text", bs, "nomStg", true);
            tb_PrenomStg.DataBindings.Add("text", bs, "prenomStg", true);
            dtp_DN.DataBindings.Add("text", bs, "dateNStg", true);
            cbx_Grp.DataBindings.Add("SelectedValue", bs, "numGrp", true);
            tb_CInStg.DataBindings.Add("Text", bs, "Cin", true);
        }
        public void Act_DGV()
        {
            //dgv_Stg.DataSource = Program.ds.Tables["Stagaire"];
            dgv_Stg.DataSource = bs;
        }
        private void F_Stagaire_Load(object sender, EventArgs e)
        {
            Program.DS();
            BS();
            Act_DGV();
            cbx_Grp.DisplayMember = "nomgrp";
            cbx_Grp.ValueMember = "numgrp";
            cbx_Grp.DataSource = Program.ds.Tables["Groupe"];

        }

        private void btn_Ajouter_Click(object sender, EventArgs e)
        {
            DataRow dr = Program.ds.Tables["Stagaire"].NewRow();
            dr["NumStg"] = tb_NumStg.Text;
            dr["NomStg"] = tb_NomStg.Text;
            dr["PrenomStg"] = tb_PrenomStg.Text;
            dr["dateNStg"] = (DateTime)dtp_DN.Value;
            dr["numGrp"] = cbx_Grp.SelectedValue;
            dr["Cin"] = tb_CInStg.Text;
            Program.ds.Tables["Stagaire"].Rows.Add(dr);
            btn_Save.PerformClick();
            Act_DGV();

        }

        private void btn_Modifier_Click(object sender, EventArgs e)
        {
            DataRow dr = Program.ds.Tables["Stagaire"].Rows.Find(tb_NumStg.Text);
            dr["NomStg"] = tb_NomStg.Text;
            dr["PrenomStg"] = tb_PrenomStg.Text;
            dr["dateNStg"] = (DateTime)dtp_DN.Value;
            dr["numGrp"] = cbx_Grp.SelectedValue;
            dr["Cin"] = tb_CInStg.Text;
            btn_Save.PerformClick();
            Act_DGV();
        }

        private void btn_Supprimer_Click(object sender, EventArgs e)
        {
            DataRow dr = Program.ds.Tables["Stagaire"].Rows.Find(tb_NumStg.Text);
            dr.Delete();
            btn_Save.PerformClick();
            Act_DGV();
        }

        private void btn_Nouveau_Click(object sender, EventArgs e)
        {
            //foreach (Control c in Controls)
            //    if (c is TextBox)
            //        c.Text = ""; 
            bs.AddNew();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            DataRow dr = Program.ds.Tables["Stagaire"].Rows.Find(tb_Search.Text);
            tb_NumStg.Text = dr["NumStg"].ToString();
            tb_NomStg.Text = dr["nomStg"].ToString();
            tb_PrenomStg.Text = dr["prenomStg"].ToString();
            dtp_DN.Value = (DateTime)dr["dateNStg"];
            cbx_Grp.Text = dr["numGrp"].ToString();
            tb_CInStg.Text = dr["Cin"].ToString();
        }

        private void first_Click(object sender, EventArgs e)
        {
            //BS();
            bs.MoveFirst();
        }

        private void previous_Click(object sender, EventArgs e)
        {
            //BS();
            bs.MovePrevious();
        }

        private void next_Click(object sender, EventArgs e)
        {
            //BS();
            bs.MoveNext();
        }

        private void last_Click(object sender, EventArgs e)
        {
            //BS();
            bs.MoveLast();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder cb = new SqlCommandBuilder(Program.da_stg);
            Program.da_stg.Update(Program.ds.Tables["Stagaire"]);
        }
    }
}
