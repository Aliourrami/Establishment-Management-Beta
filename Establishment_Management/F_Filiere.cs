using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin.Animations;
using MaterialSkin;

namespace Establishment_Management
{
    public partial class F_Filiere : MaterialForm
    {
        public F_Filiere()
        {
            InitializeComponent();
            //using MaterialSkin;
            var ms = MaterialSkinManager.Instance;
            ms.AddFormToManage(this);
            ms.Theme = MaterialSkinManager.Themes.LIGHT;
            ms.ColorScheme = new ColorScheme(Primary.Teal400, Primary.BlueGrey900, Primary.BlueGrey900, Accent.Orange700, TextShade.BLACK);
        }
        BindingSource bs = new BindingSource();
        private void Filiere_Load(object sender, EventArgs e)
        {
            bs.DataSource = Program.exec_select("select * from Filiere");
            textBox_CodeF.DataBindings.Add("text", bs, "numFlr");
            textBox_nomF.DataBindings.Add("text", bs, "nomFlr");
            textBox_Nv.DataBindings.Add("text", bs, "niveauFlr");
            textBox_Type.DataBindings.Add("text", bs, "typeFlr");
            Actualiser_DGV();
        }
        public void Actualiser_DGV()
        {
            string req = "select * from Filiere";
            dataGridView1.DataSource = Program.exec_select(req);
            //dgv2.DataSource = Program.exec_select(req);
        }

        private void button_Nv_Click(object sender, EventArgs e)
        {
            textBox_CodeF.Clear();
            textBox_nomF.Clear();
            textBox_Nv.Clear();
            textBox_Type.Clear();
        }

        private void button_Ajouter_Click(object sender, EventArgs e)
        {
            try
            {
                string req = string.Format(@"insert into Filiere values('{0}','{1}','{2}','{3}')", textBox_CodeF.Text, textBox_nomF.Text, textBox_Nv.Text, textBox_Type.Text);
                Program.exec_maj(req);
                MessageBox.Show("bien ajouter");
                Actualiser_DGV();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_Modifier_Click(object sender, EventArgs e)
        {
            //bs.EndEdit();
            try
            {
                string req = string.Format(@"update Filiere
                            set nomFlr = '{0}', niveauFlr = '{1}', typeFlr = '{2}'
                            where numFlr = '{3}'",
                                textBox_CodeF.Text, textBox_nomF.Text, textBox_Nv.Text, textBox_Type.Text);
                Program.exec_maj(req);
                Actualiser_DGV();

            }
            catch (Exception me) { MessageBox.Show(me.Message); }
        }

        private void button_Supprimer_Click(object sender, EventArgs e)
        {
            try
            {
                string num = textBox_CodeF.Text;
                string req = "delete Filiere where numFlr=" + num;
                Program.exec_maj(req);
                Actualiser_DGV();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            bs.Position = bs.Find("numFlr", tb_Search.Text);
        }

        private void button_First_Click(object sender, EventArgs e)
        {
            bs.MoveFirst();
        }

        private void button_Previous_Click(object sender, EventArgs e)
        {
            bs.MovePrevious();
        }

        private void button_Next_Click(object sender, EventArgs e)
        {
            bs.MoveNext();
        }

        private void button_Last_Click(object sender, EventArgs e)
        {
            bs.MoveLast();
        }

        private void materialSingleLineTextField1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void next_Click(object sender, EventArgs e)
        {

        }
    }
}

