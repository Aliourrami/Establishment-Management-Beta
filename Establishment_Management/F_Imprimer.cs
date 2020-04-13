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
    public partial class F_Imprimer : MaterialSkin.Controls.MaterialForm
    {
        public F_Imprimer()
        {
            InitializeComponent();
            //
            var ms = MaterialSkinManager.Instance;
            ms.AddFormToManage(this);
            ms.Theme = MaterialSkinManager.Themes.DARK;
            ms.ColorScheme = new ColorScheme(Primary.Teal400, Primary.BlueGrey900, Primary.BlueGrey900, Accent.Orange700, TextShade.BLACK);
        }

        private void Imprimer_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Stg_Click(object sender, EventArgs e)
        {
            string req = @"select st.numStg,st.nomStg,st.prenomStg,st.dateNStg,gr.nomGrp,gr.annee,fl.nomFlr,fl.niveauFlr 
                from stagaire st join groupe gr on st.numGrp=gr.numGrp join Filiere fl on fl.numflr=gr.numflr 
                where numStg='" + cbx_stagaire.SelectedValue + "'";

            Imprimer.AttestationStagaire cr = new Imprimer.AttestationStagaire();
            cr.SetDataSource(Program.exec_select(req));
            crystalReportViewer4.ReportSource = cr;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string req = @"select st.cin,ab.numSc,ab.numStg,sc.salle,st.nomStg,st.prenomStg,sc.dateSc,sc.duree,gp.nomGrp
	                from Absence ab join Seance sc on ab.numSc=sc.numSc join Stagaire st on st.numStg=ab.NumStg join Groupe gp on st.numGrp=gp.numGrp 
	                where ab.numStg ='" + cmb_stagaire.SelectedValue + "'";
            Imprimer.AbsenceStagaire cr = new Imprimer.AbsenceStagaire();
            cr.SetDataSource(Program.exec_select(req));
            crystalReportViewer1.ReportSource = cr;

        }

        private void Absence1_InitReport(object sender, EventArgs e)
        {

        }

        private void crystalReportViewer4_Load(object sender, EventArgs e)
        {

        }

        private void tabPage3_efm_plan_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Absence_Click(object sender, EventArgs e)
        {


            //string req = @"select st.cin,ab.numSc,ab.numStg,sc.salle,st.nomStg,st.prenomStg,sc.dateSc,sc.duree,gp.nomGrp
	           //     from Absence ab join Seance sc on ab.numSc=sc.numSc join Stagaire st on st.numStg=ab.NumStg join Groupe gp on st.numGrp=gp.numGrp 
	           //     where st.nomStg ='" + cbx_stagaire.SelectedValue + "'";
            //Imprimer.Absence cr = new Imprimer.Absence();
            //cr.SetDataSource(Program.exec_select(req));
            //crystalReportViewer1.ReportSource = cr;

        }

        private void tabPage1_attestation_Click(object sender, EventArgs e)
        {
            
        }

        private void tabPage1_attestation_Enter(object sender, EventArgs e)
        {
            cbx_stagaire.DisplayMember = "NomStg";
            cbx_stagaire.ValueMember = "NumStg";
            cbx_stagaire.DataSource = Program.exec_select("select * from stagaire");


        }

        private void tabPage2_Absence_Enter(object sender, EventArgs e)
        {
            cmb_stagaire.DisplayMember = "NomStg";
            cmb_stagaire.ValueMember = "NumStg";
            cmb_stagaire.DataSource = Program.exec_select("select * from stagaire");
        }

        private void Attestation_Stg2_InitReport(object sender, EventArgs e)
        {

        }

        private void Attestation_Stg1_InitReport(object sender, EventArgs e)
        {

        }

        private void materialTabSelector1_Click(object sender, EventArgs e)
        {

        }
    }
}