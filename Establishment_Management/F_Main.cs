using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using MaterialSkin.Animations;
using MaterialSkin.Controls;
using MaterialSkin;



namespace Establishment_Management
{
    public partial class F_Main : MaterialForm
    {
        public F_Main()
        {
            Thread t = new Thread(new ThreadStart(F_S));
            t.Start();
            Thread.Sleep(2000);
            t.Abort();
            InitializeComponent();
            //using MaterialSkin;
            var ms = MaterialSkinManager.Instance;
            ms.AddFormToManage(this);
            ms.Theme = MaterialSkinManager.Themes.LIGHT;
            ms.ColorScheme = new ColorScheme(Primary.Teal400, Primary.BlueGrey900, Primary.BlueGrey900, Accent.Orange700, TextShade.BLACK);
        }
        public void F_S()
        {
            //Application.Run(new F_Start());
            Application.Run(new Spalsh());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            //this.Close();
            F_Formateur ff = new F_Formateur();
            ff.Show();
        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            F_Filiere ff = new F_Filiere();
            ff.Show();
        }

        private void bunifuTileButton3_Click(object sender, EventArgs e)
        {
            F_Module fm = new F_Module();
            fm.Show();
        }

        private void bunifuTileButton4_Click(object sender, EventArgs e)
        {
            F_Groupe fg = new F_Groupe();
            fg.Show();
        }

        private void bunifuTileButton5_Click(object sender, EventArgs e)
        {
            F_Stagaire fs = new F_Stagaire();
            fs.Show();
        }

        private void bunifuTileButton6_Click(object sender, EventArgs e)
        {
            F_EFM_Planification fp = new F_EFM_Planification();
            fp.Show();
        }

        private void bunifuTileButton7_Click(object sender, EventArgs e)
        {
            F_Affectation fa = new F_Affectation();
            fa.Show();
        }

        private void bunifuTileButton8_Click(object sender, EventArgs e)
        {
            F_Seance fs = new F_Seance();
            fs.Show();
        }

        private void bunifuTileButton9_Click(object sender, EventArgs e)
        {
            F_Absence fa = new F_Absence();
            fa.Show();

        }

        private void btn_Imprimer_Click(object sender, EventArgs e)
        {
            F_Imprimer fi = new F_Imprimer();
            fi.Show();
        }
    }
}
