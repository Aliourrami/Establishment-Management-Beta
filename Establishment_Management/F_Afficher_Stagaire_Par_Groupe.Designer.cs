namespace Establishment_Management
{
    partial class F_Afficher_Stagaire_Par_Groupe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grv_stagaire = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.tb_NomGroupe = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Groupe = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_nbr = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.grv_stagaire)).BeginInit();
            this.SuspendLayout();
            // 
            // grv_stagaire
            // 
            this.grv_stagaire.AllowUserToAddRows = false;
            this.grv_stagaire.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grv_stagaire.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grv_stagaire.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.grv_stagaire.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grv_stagaire.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSalmon;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grv_stagaire.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grv_stagaire.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grv_stagaire.DoubleBuffered = true;
            this.grv_stagaire.EnableHeadersVisualStyles = false;
            this.grv_stagaire.HeaderBgColor = System.Drawing.Color.LightSalmon;
            this.grv_stagaire.HeaderForeColor = System.Drawing.Color.Black;
            this.grv_stagaire.Location = new System.Drawing.Point(9, 212);
            this.grv_stagaire.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grv_stagaire.Name = "grv_stagaire";
            this.grv_stagaire.ReadOnly = true;
            this.grv_stagaire.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grv_stagaire.RowTemplate.Height = 24;
            this.grv_stagaire.Size = new System.Drawing.Size(582, 259);
            this.grv_stagaire.TabIndex = 0;
            // 
            // tb_NomGroupe
            // 
            this.tb_NomGroupe.Depth = 0;
            this.tb_NomGroupe.Hint = "";
            this.tb_NomGroupe.Location = new System.Drawing.Point(79, 176);
            this.tb_NomGroupe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_NomGroupe.MaxLength = 32767;
            this.tb_NomGroupe.MouseState = MaterialSkin.MouseState.HOVER;
            this.tb_NomGroupe.Name = "tb_NomGroupe";
            this.tb_NomGroupe.PasswordChar = '\0';
            this.tb_NomGroupe.SelectedText = "";
            this.tb_NomGroupe.SelectionLength = 0;
            this.tb_NomGroupe.SelectionStart = 0;
            this.tb_NomGroupe.Size = new System.Drawing.Size(176, 23);
            this.tb_NomGroupe.TabIndex = 1;
            this.tb_NomGroupe.TabStop = false;
            this.tb_NomGroupe.UseSystemPasswordChar = false;
            this.tb_NomGroupe.TextChanged += new System.EventHandler(this.tb_NomGroupe_TextChanged);
            // 
            // Groupe
            // 
            this.Groupe.AutoSize = true;
            this.Groupe.Depth = 0;
            this.Groupe.Font = new System.Drawing.Font("Roboto", 11F);
            this.Groupe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Groupe.Location = new System.Drawing.Point(30, 143);
            this.Groupe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Groupe.MouseState = MaterialSkin.MouseState.HOVER;
            this.Groupe.Name = "Groupe";
            this.Groupe.Size = new System.Drawing.Size(102, 19);
            this.Groupe.TabIndex = 2;
            this.Groupe.Text = "Nom Groupe :";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(112, 492);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(198, 19);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "Nomber Stagaire in Groupe :\r\n";
            // 
            // lbl_nbr
            // 
            this.lbl_nbr.AutoSize = true;
            this.lbl_nbr.Depth = 0;
            this.lbl_nbr.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_nbr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_nbr.Location = new System.Drawing.Point(330, 492);
            this.lbl_nbr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_nbr.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_nbr.Name = "lbl_nbr";
            this.lbl_nbr.Size = new System.Drawing.Size(30, 19);
            this.lbl_nbr.TabIndex = 3;
            this.lbl_nbr.Text = "nbr";
            this.lbl_nbr.TextChanged += new System.EventHandler(this.lbl_nbr_TextChanged);
            // 
            // F_Afficher_Stagaire_Par_Groupe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 578);
            this.Controls.Add(this.lbl_nbr);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.Groupe);
            this.Controls.Add(this.tb_NomGroupe);
            this.Controls.Add(this.grv_stagaire);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "F_Afficher_Stagaire_Par_Groupe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_Afficher_Stagaire_Par_Groupe";
            this.Load += new System.EventHandler(this.F_Afficher_Stagaire_Par_Groupe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grv_stagaire)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid grv_stagaire;
        private MaterialSkin.Controls.MaterialSingleLineTextField tb_NomGroupe;
        private MaterialSkin.Controls.MaterialLabel Groupe;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel lbl_nbr;
    }
}