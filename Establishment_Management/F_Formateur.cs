using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using MaterialSkin;


namespace Establishment_Management
{
    public partial class F_Formateur : MaterialSkin.Controls.MaterialForm
    {
        public F_Formateur()
        {
            //Thread t = new Thread(new ThreadStart(F_S));
            //t.Start();
            //Thread.Sleep(2000);
            InitializeComponent();
            //using MaterialSkin;
            var ms = MaterialSkinManager.Instance;
            ms.AddFormToManage(this);
            ms.Theme = MaterialSkinManager.Themes.LIGHT;
            ms.ColorScheme = new ColorScheme(Primary.Teal400, Primary.BlueGrey900, Primary.BlueGrey900, Accent.Orange700, TextShade.BLACK);            //t.Abort();
        }
        //public void F_S()
        //{
        //    Application.Run(new F_Start());
        //}
        BindingSource bs = new BindingSource();
        public void MAJ_DGV()
        {
            dgv_frm.DataSource = Program.exec_select("select * from Formateur");
        }
        private void F_Formateur_Load(object sender, EventArgs e)
        {
            MAJ_DGV();
            bs.DataSource = Program.exec_select("select * from Formateur");
            tbx_NumFrm.DataBindings.Add("text", bs, "numfrm");
            tbx_MatriculeFrm.DataBindings.Add("text", bs, "matricule");
            tbx_Cin.DataBindings.Add("text", bs, "cin");
            tbx_Nom.DataBindings.Add("text", bs, "nomfrm");
            tbx_Prenom.DataBindings.Add("text", bs, "prenomfrm");
            dtp_Date_Naissance.DataBindings.Add("text", bs, "dateN");
            dtp_Date_Embauche.DataBindings.Add("text", bs, "dateEmbauche");
            tbx_Grade.DataBindings.Add("text", bs, "grade");
            tbx_Statut.DataBindings.Add("text", bs, "statut");
        }
        private void btn_Nouveau_Click(object sender, EventArgs e)
        {
            foreach (Control c in Controls)
            {
                if (c is TextBox)
                    (c as TextBox).Clear();
                if(c is DateTimePicker)
                    (c as DateTimePicker).Value = DateTime.Today;
            }
        }

        private void btn_Ajouter_Click(object sender, EventArgs e)
        {
            try
            {
                string req = string.Format("insert into Formateur values({0},'{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')",
                tbx_NumFrm.Text, tbx_MatriculeFrm.Text, tbx_Cin.Text, tbx_Nom.Text, tbx_Prenom.Text, dtp_Date_Naissance.Value, dtp_Date_Embauche.Value, tbx_Grade.Text, tbx_Statut.Text);
                Program.exec_maj(req);
                MAJ_DGV();
            }
            catch (Exception me) { MessageBox.Show(me.Message); }

        }

        private void btn_Modifier_Click(object sender, EventArgs e)
        {
            try
            {
            string req = string.Format(@"update Formateur
                            set matricule = '{0}', cin = '{1}', nomfrm = '{2}', prenomfrm = '{3}', dateN = '{4}', dateEmbauche = '{5}', grade = '{6}', statut = '{7}'
                            where numfrm = {8}",
                            tbx_MatriculeFrm.Text, tbx_Cin.Text, tbx_Nom.Text, tbx_Prenom.Text, dtp_Date_Naissance.Value, dtp_Date_Embauche.Value, tbx_Grade.Text, tbx_Statut.Text, tbx_NumFrm.Text);
            Program.exec_maj(req);
            MAJ_DGV();

            }
            catch (Exception me) { MessageBox.Show(me.Message); }

        }

        private void btn_Supprimer_Click(object sender, EventArgs e)
        {
            try
            {
                string req = string.Format(@"delete Formateur where numfrm = {0}", tbx_NumFrm.Text);
                Program.exec_maj(req);
                MAJ_DGV();
            }
            catch (Exception me) { MessageBox.Show(me.Message); }

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            try
            {
                bs.Position = bs.Find("numfrm", tb_Search.Text);
            }
            catch (Exception me) { MessageBox.Show(me.Message); }
        }

    private void first_Click(object sender, EventArgs e)
        {
            bs.MoveFirst();
        }

        private void Previous_Click(object sender, EventArgs e)
        {
            bs.MovePrevious();
        }

        private void Next_Click(object sender, EventArgs e)
        {
            bs.MoveNext();
        }

        private void Last_Click(object sender, EventArgs e)
        {
            bs.MoveLast();
        }

        private void F_Formateur_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
