using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;


namespace Establishment_Management
{
    static class Program
    {
        public static DataSet ds = new DataSet(); // Mode DeConnecter
        public static string con = @"data source=DESKTOP-8PDF6KH\SQLEXPRESS; database=EFP_Final; integrated security=true;";
        public static SqlConnection cnx = new SqlConnection(con);// Mode Connecter
        public static SqlCommand cmd = new SqlCommand("",cnx);// Mode Connecter
        public static SqlDataReader dr;// Mode Connecter
        public static SqlDataAdapter da_stg; // Mode DeConnecter
        public static SqlDataAdapter da_grp; // Mode DeConnecter
        public static SqlDataAdapter da_aff; // Mode DeConnecter
        public static SqlDataAdapter da_abs; // Mode DeConnecter
        public static SqlDataAdapter da_Sc; // Mode DeConnecter
        

        // Mode DeConnecter
        public static void DS()
        {
            da_Sc = new SqlDataAdapter("select * from Seance", con);
            da_Sc.Fill(ds, "Seance");
            ds.Tables["Seance"].PrimaryKey = new DataColumn[] { ds.Tables["Seance"].Columns[0] };

            da_abs = new SqlDataAdapter("select * from Absence", con);
            da_abs.Fill(ds, "Absence");
            ds.Tables["Absence"].PrimaryKey = new DataColumn[] { ds.Tables["Absence"].Columns[0], ds.Tables["Absence"].Columns[1] };

            da_stg = new SqlDataAdapter("select * from Stagaire", con);
            da_stg.Fill(ds, "Stagaire");
            ds.Tables["Stagaire"].PrimaryKey = new DataColumn[] { ds.Tables["Stagaire"].Columns[0] };

            da_grp = new SqlDataAdapter("select * from Groupe", con);
            da_grp.Fill(ds, "Groupe");
            ds.Tables["Groupe"].PrimaryKey = new DataColumn[] { ds.Tables["Groupe"].Columns[0] };

            da_aff = new SqlDataAdapter("select * from Affectation", con);
            da_aff.Fill(ds, "Affectation");
            ds.Tables["Affectation"].PrimaryKey = new DataColumn[] { ds.Tables["Affectation"].Columns[0] };

        }
        // Mode Connecter
        public static void exec_maj(string req)
        {
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                cmd.CommandText = req;
                cmd.ExecuteNonQuery();
            }
            catch
            { throw; }
            finally { cnx.Close(); }

        }

        public static DataTable exec_select(string req)
        {
            try
            {
                DataTable dt = new DataTable();
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                cmd.CommandText = req;
                dr = cmd.ExecuteReader();
                dt.Load(dr);
                dr.Close();
                return dt;
            }
            catch 
            { throw; }
            finally { cnx.Close(); }


        }

        public static object exec_scalar(string req)
        {
            try
            {
                object o;
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                cmd.CommandText = req;
                o = cmd.ExecuteScalar();
                return o;
            }
            catch
            { throw; }
            finally { cnx.Close(); }
        }
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Imprimer.FCR_Attestation());
            //Application.Run(new F_FiliereEtGroupeParFormateur());
            //Application.Run(new F_Main());
            //Application.Run(new F_Module());
            //Application.Run(new F_Absence());4
            //Application.Run(new F_Filiere());
            //Application.Run(new F_Affectation());
            //Application.Run(new F_EFM_Planification());
            Application.Run(new F_Main());
            //Application.Run(new Emploi_Temps());
            //Application.Run(new F_Afficher_Stagaire_Par_Groupe());
            //Application.Run(new F_Stagaire());
            //Application.Run(new F_Groupe());
            //Application.Run(new F_Start());
            //Application.Run(new F_Formateur());
            //Application.Run(new F_Filiere());
        }
    }
}
