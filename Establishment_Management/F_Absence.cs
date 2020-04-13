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
    public partial class F_Absence : MaterialSkin.Controls.MaterialForm
    {
        public F_Absence()
        {
            InitializeComponent();
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
            dgv_Abs.DataSource = bs;
        }
        private void F_Absence_Load(object sender, EventArgs e)
        {
            Program.DS();
            dgv();
            cmb_NumSc.ValueMember = "NumSc";
            cmb_NumSc.DataSource=Program.ds.Tables["Seance"];

            cmb_NumStg.DisplayMember = "nomStg";
            cmb_NumStg.ValueMember = "NumStg";
            cmb_NumStg.DataSource=Program.ds.Tables["Stagaire"];

            bs.DataSource = Program.ds.Tables["Absence"];
            cmb_NumSc.DataBindings.Add("SelectedValue", bs, "numSc", true);
            cmb_NumStg.DataBindings.Add("SelectedValue", bs, "numStg", true);

            //string reqDGV = @"select st.cin,ab.numSc,ab.numStg,sc.salle,st.nomStg,st.prenomStg,sc.dateSc,sc.duree,gp.nomGrp
	           //             from Absence ab join Seance sc on ab.numSc=sc.numSc join Stagaire st on st.numStg=ab.NumStg join Groupe gp on st.numGrp=gp.numGrp 
            //                 ";
            //dataGridView1.DataSource = Program.exec_select(reqDGV);

            string reqCbx = @"select * from Groupe";
            comboBox1.DisplayMember = "NomGrp";
            comboBox1.ValueMember = "NumGrp";
            comboBox1.DataSource= Program.exec_select(reqCbx);


        }

        private void btn_Ajouter_Click(object sender, EventArgs e)
        {
            bs.EndEdit();
            btn_Save.PerformClick();
            dgv();
        }

        private void btn_Modifier_Click(object sender, EventArgs e)
        {
            bs.EndEdit();
            btn_Save.PerformClick();
            dgv();
        }

        private void btn_Supprimer_Click(object sender, EventArgs e)
        {
            bs.RemoveCurrent();
            btn_Save.PerformClick();
            dgv();
        }

        private void btn_Nouveau_Click(object sender, EventArgs e)
        {
            bs.AddNew();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            bs.Position = bs.IndexOf(cmb_NumSc.SelectedValue);
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
            SqlCommandBuilder cb = new SqlCommandBuilder(Program.da_abs);
            Program.da_abs.Update(Program.ds.Tables["Absence"]);
        }

        private void CalAbs_Click(object sender, EventArgs e)
        {
        
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string req = "";
            if(textBox1.Text=="")
            {
                string req = string.Format(@"select st.cin,ab.numSc,ab.numStg,sc.salle,st.nomStg,st.prenomStg,sc.dateSc,sc.duree,gp.nomGrp
                 from Absence ab join Seance sc on ab.numSc=sc.numSc join Stagaire st on st.numStg=ab.NumStg join Groupe gp on st.numGrp=gp.numGrp 
                 where gp.NumGrp='{0}'", comboBox1.SelectedValue);

                dataGridView1.DataSource = Program.exec_select(req.Trim());
            }
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(req);
            ////string oldStr = "          *This is a test*               ";
            ////string newStr = oldStr.Trim();
            ////MessageBox.Show("(" + oldStr + ")" + "(" + newStr + ")");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void dataGridView1_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {

                int duree = 0;
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    duree += (int)(dataGridView1.Rows[i].Cells[7].Value);
                    lbl_TD.Text = duree + "H";
                }
        }

        private void lbl_TD_Click(object sender, EventArgs e)
        {

        }

        private void MajAbs_Click(object sender, EventArgs e)
        {

        }

        private void btn_search_Click_1(object sender, EventArgs e)
        {
            bs.Position = bs.Find("numSc", int.Parse(tb_Search.Text));
        }

        private void MajAbs_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            string req = string.Format(@"select st.cin,ab.numSc,ab.numStg,sc.salle,st.nomStg,st.prenomStg,sc.dateSc,sc.duree,gp.nomGrp
                 from Absence ab join Seance sc on ab.numSc=sc.numSc join Stagaire st on st.numStg=ab.NumStg join Groupe gp on st.numGrp=gp.numGrp 
                 where gp.NumGrp='{0}' and st.NomStg Like '{1}%'", comboBox1.SelectedValue, textBox1.Text.Trim());

            dataGridView1.DataSource = Program.exec_select(req.Trim());
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            string req = string.Format(@"select st.cin,ab.numSc,ab.numStg,sc.salle,st.nomStg,st.prenomStg,sc.dateSc,sc.duree,gp.nomGrp
                 from Absence ab join Seance sc on ab.numSc=sc.numSc join Stagaire st on st.numStg=ab.NumStg join Groupe gp on st.numGrp=gp.numGrp 
                 where gp.NumGrp='{0}' and st.CIN Like '{1}%'", comboBox1.SelectedValue, textBox2.Text.Trim());

            dataGridView1.DataSource = Program.exec_select(req.Trim());
        }
    }
}
