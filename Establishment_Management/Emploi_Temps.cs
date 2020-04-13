using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using System.Text.RegularExpressions;

namespace Establishment_Management
{
    public partial class Emploi_Temps : Form
    {

        public Emploi_Temps()
        {
            InitializeComponent();

            //var dt = new DataTable();
            //dt.Columns.Add("text", typeof(string));
            //dt.Rows.Add("test. test");
            //dt.Rows.Add("test");

            //var dg = new DataGridView
            //{
            //    Parent = this,
            //    Dock = DockStyle.Fill,
            //    DataSource = dt,
            //    AllowUserToAddRows = false
            //};
            //dg.RowTemplate.Height = 50;
            //dg.CellPainting += (s, e) =>
            //{
            //    var str = (e.FormattedValue as string);
            //    if (str != null && str.Contains("."))
            //    {
            //        e.PaintBackground(e.CellBounds, true);
            //        str = Regex.Replace(str, @"\.\s*", "\n");
            //        e.Graphics.DrawString(str, dg.Font, Brushes.Black, e.CellBounds);
            //        e.Handled = true;
            //    }
            //};
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Emploi_Temps_Load(object sender, EventArgs e)
        {
            //dataGridView1.Columns[2].HeaderCell.Size.Width.CompareTo(200);
            //dataGridView1.Rows[1].Cells[1].Size.Height.Equals();
            //dataGridView1.DataSource = Program.exec_select("select * from stagaire");
            //int i = 0;
            //for (i = 0; i <= dataGridView1.Columns.Count - 1; i++)
            //{
            //    dataGridView1.Columns[i].HeaderCell.Style.Font = new Font("tahoma", 20, FontStyle.Regular);
            //    dataGridView1.Columns[i].Width = 150;
            //    dataGridView1.Columns[i].HeaderCell.Style.ForeColor = Color.Red;
            //    dataGridView1.EnableHeadersVisualStyles = false;
            //}

            cbx_jours.Items.Add("LUNDI");
            cbx_jours.Items.Add("MARDI");
            cbx_jours.Items.Add("MERCREDI");
            cbx_jours.Items.Add("JEUDI");
            cbx_jours.Items.Add("VENDREDI");
            cbx_jours.Items.Add("SAMEDI");

            Cbx_Groups.DisplayMember = "NomGrp";
            Cbx_Groups.ValueMember = "NumGrp";
            Cbx_Groups.DataSource = Program.exec_select("select NomGrp from Groupe");

            cbx_Formateurs.DisplayMember = "NomFrm";
            cbx_Formateurs.ValueMember = "NumFrm";
            cbx_Formateurs.DataSource = Program.exec_select("select NomFrm from Formateur");

            cbx_salles.DisplayMember = "Salle";
            cbx_salles.ValueMember = "NumSc";
            cbx_salles.DataSource = Program.exec_select("select salle from Seance");
        }

        private void btn_Set_Click(object sender, EventArgs e)
        {
            // her i take the index of cbx selected 
            string j = (cbx_jours.SelectedIndex + 1).ToString();
            string g = (Cbx_Groups.SelectedIndex + 1).ToString();
            //MessageBox.Show(j + " + " + g);
            //MessageBox.Show(j.ToString());
            //MessageBox.Show(g.ToString());
            //if (cbx_jours.SelectedIndex == j && Cbx_Groups.SelectedIndex==g)
            //{
            //MessageBox.Show(cbx_jours.SelectedIndex.ToString());
            foreach (Control t in Tb.Controls)
            {   // this boucle searhed for texbox in the TableLayoutPanel
                if (t is TextBox || t is Panel)
                {
                    //MessageBox.Show(j + "_" + g);
                    // this condition searhed for in all texbox Name (jour(j) par groupe(g)) in the TableLayoutPanel in form
                    if (t.Name.Contains(j + "_" + g) == true)
                    {
                        //MessageBox.Show("j" + "_" + "g";
                        // this texbox text eqaule Name formateur
                        t.Text = cbx_Formateurs.Text+"      "+cbx_salles.Text;
                    }
                }
                // this condition for checkbox Matin are checked
                if (cbM.Checked == true)
                {
                    foreach (Control p in Tb.Controls)
                    {   // this Boucle for search the panel in TableLayoutPanel in form
                        if (p is Panel)
                        {   // this condition for search in the panel Name (jour(j) par groupe(g)) in the TableLayoutPanel in form
                            if (p.Name.Contains(j + "_" + g))
                            {
                                //tbM1_3
                                foreach (TextBox x in p.Controls)
                                {   // this Boucle for search in the all panel for Textbox
                                    //MessageBox.Show("i enter bro");

                                    if (x.Name.Contains("tbM" + j + "_" + g))
                                        x.Text = cbx_Formateurs.Text + "      " + cbx_salles.Text;
                                }                                                                                                 
                            }
                        }
                    }
                }
                // And this versus the bocle cbM.Checked == true li lfo9
                if (cbA.Checked == true)
                {
                    foreach (Control p in Tb.Controls)
                    {   // this Boucle for search the panel in TableLayoutPanel in form
                        if (p is Panel)
                        {   // this condition for search in the panel Name (jour(j) par groupe(g)) in the TableLayoutPanel in form
                            if (p.Name.Contains(j + "_" + g))
                            {
                                //tbM1_3
                                foreach (TextBox x in p.Controls)
                                {   // this Boucle for search in the all panel for Textbox
                                    //MessageBox.Show("i enter bro");

                                    if (x.Name.Contains("tbA" + j + "_" + g))
                                        x.Text = cbx_Formateurs.Text + "      " + cbx_salles.Text;
                                }
                            }
                        }
                    }
                }
                //if (cbM.Checked==true)
                //{
                //MessageBox.Show(j + "_" + g);

                //}
                //else if (t.Name.Contains("tbA" + j + "_" + g) && checkBox2.Checked)
                //{
                //    t.Text = cbx_Formateurs.Text;
                //}



            }



            //string r = "1";
            //if (cbx_jours.SelectedIndex == 1)
            //{
            //    //MessageBox.Show(cbx_jours.SelectedIndex.ToString());
            //    foreach(Control t in Tb.Controls)
            //    {
            //        if (t is TextBox)
            //        {

            //            if (t.Name.Contains(r + "_" + r) == true)
            //            {
            //                MessageBox.Show("r" + "_" + "1");
            //                t.Text = cbx_Formateurs.Text;
            //            }

            //        }

            //    }
            //}


            //int i = 0;
            //foreach (Control ctrl in Tb.Controls)
            //{
            //    if (ctrl is TextBox)
            //    {
            //        ctrl.Text = i.ToString() ;
            //    }
            //    i++;
            //}
        }

        private void btn_Set_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
