namespace Establishment_Management
{
    partial class F_Affectation
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
            this.label1 = new System.Windows.Forms.Label();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.dgv_Aff = new System.Windows.Forms.DataGridView();
            this.tb_Search = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.cmb_filiere = new System.Windows.Forms.ComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.tb_numaff = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.dtp_date_aff = new System.Windows.Forms.DateTimePicker();
            this.cmb_groupe = new System.Windows.Forms.ComboBox();
            this.cmb_Formateur = new System.Windows.Forms.ComboBox();
            this.cmb_mdl = new System.Windows.Forms.ComboBox();
            this.last = new MaterialSkin.Controls.MaterialRaisedButton();
            this.next = new MaterialSkin.Controls.MaterialRaisedButton();
            this.previous = new MaterialSkin.Controls.MaterialRaisedButton();
            this.first = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_search = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_Nouveau = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_Supprimer = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_Modifier = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_Ajouter = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Aff)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(214, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Affectation";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(66, 333);
            this.materialLabel5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(127, 19);
            this.materialLabel5.TabIndex = 81;
            this.materialLabel5.Text = "Date Affectation :";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(66, 197);
            this.materialLabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(65, 19);
            this.materialLabel4.TabIndex = 80;
            this.materialLabel4.Text = "Groupe :";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(66, 151);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(94, 19);
            this.materialLabel2.TabIndex = 78;
            this.materialLabel2.Text = "Num Filiére :";
            // 
            // dgv_Aff
            // 
            this.dgv_Aff.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_Aff.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Aff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Aff.GridColor = System.Drawing.Color.Maroon;
            this.dgv_Aff.Location = new System.Drawing.Point(34, 415);
            this.dgv_Aff.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_Aff.Name = "dgv_Aff";
            this.dgv_Aff.RowTemplate.Height = 24;
            this.dgv_Aff.Size = new System.Drawing.Size(537, 193);
            this.dgv_Aff.TabIndex = 72;
            // 
            // tb_Search
            // 
            this.tb_Search.Depth = 0;
            this.tb_Search.Hint = "Search";
            this.tb_Search.Location = new System.Drawing.Point(416, 303);
            this.tb_Search.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_Search.MaxLength = 32767;
            this.tb_Search.MouseState = MaterialSkin.MouseState.HOVER;
            this.tb_Search.Name = "tb_Search";
            this.tb_Search.PasswordChar = '\0';
            this.tb_Search.SelectedText = "";
            this.tb_Search.SelectionLength = 0;
            this.tb_Search.SelectionStart = 0;
            this.tb_Search.Size = new System.Drawing.Size(144, 23);
            this.tb_Search.TabIndex = 66;
            this.tb_Search.TabStop = false;
            this.tb_Search.UseSystemPasswordChar = false;
            // 
            // cmb_filiere
            // 
            this.cmb_filiere.FormattingEnabled = true;
            this.cmb_filiere.Location = new System.Drawing.Point(212, 151);
            this.cmb_filiere.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmb_filiere.Name = "cmb_filiere";
            this.cmb_filiere.Size = new System.Drawing.Size(136, 21);
            this.cmb_filiere.TabIndex = 62;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(66, 106);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(128, 19);
            this.materialLabel1.TabIndex = 78;
            this.materialLabel1.Text = "Num Affectation :";
            // 
            // tb_numaff
            // 
            this.tb_numaff.Depth = 0;
            this.tb_numaff.Hint = "";
            this.tb_numaff.Location = new System.Drawing.Point(212, 102);
            this.tb_numaff.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_numaff.MaxLength = 32767;
            this.tb_numaff.MouseState = MaterialSkin.MouseState.HOVER;
            this.tb_numaff.Name = "tb_numaff";
            this.tb_numaff.PasswordChar = '\0';
            this.tb_numaff.SelectedText = "";
            this.tb_numaff.SelectionLength = 0;
            this.tb_numaff.SelectionStart = 0;
            this.tb_numaff.Size = new System.Drawing.Size(135, 23);
            this.tb_numaff.TabIndex = 83;
            this.tb_numaff.TabStop = false;
            this.tb_numaff.Text = "Numéro Affectation";
            this.tb_numaff.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(66, 288);
            this.materialLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(86, 19);
            this.materialLabel3.TabIndex = 80;
            this.materialLabel3.Text = "Formateur :";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(66, 242);
            this.materialLabel6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(67, 19);
            this.materialLabel6.TabIndex = 80;
            this.materialLabel6.Text = "Module :";
            // 
            // dtp_date_aff
            // 
            this.dtp_date_aff.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_date_aff.Location = new System.Drawing.Point(212, 333);
            this.dtp_date_aff.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtp_date_aff.Name = "dtp_date_aff";
            this.dtp_date_aff.Size = new System.Drawing.Size(136, 20);
            this.dtp_date_aff.TabIndex = 65;
            // 
            // cmb_groupe
            // 
            this.cmb_groupe.FormattingEnabled = true;
            this.cmb_groupe.Location = new System.Drawing.Point(212, 197);
            this.cmb_groupe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmb_groupe.Name = "cmb_groupe";
            this.cmb_groupe.Size = new System.Drawing.Size(136, 21);
            this.cmb_groupe.TabIndex = 64;
            // 
            // cmb_Formateur
            // 
            this.cmb_Formateur.FormattingEnabled = true;
            this.cmb_Formateur.Location = new System.Drawing.Point(212, 288);
            this.cmb_Formateur.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmb_Formateur.Name = "cmb_Formateur";
            this.cmb_Formateur.Size = new System.Drawing.Size(136, 21);
            this.cmb_Formateur.TabIndex = 64;
            // 
            // cmb_mdl
            // 
            this.cmb_mdl.FormattingEnabled = true;
            this.cmb_mdl.Location = new System.Drawing.Point(212, 242);
            this.cmb_mdl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmb_mdl.Name = "cmb_mdl";
            this.cmb_mdl.Size = new System.Drawing.Size(136, 21);
            this.cmb_mdl.TabIndex = 84;
            // 
            // last
            // 
            this.last.AutoSize = true;
            this.last.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.last.Depth = 0;
            this.last.Icon = null;
            this.last.Location = new System.Drawing.Point(304, 367);
            this.last.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.last.MouseState = MaterialSkin.MouseState.HOVER;
            this.last.Name = "last";
            this.last.Primary = true;
            this.last.Size = new System.Drawing.Size(35, 36);
            this.last.TabIndex = 136;
            this.last.Text = ">>";
            this.last.UseVisualStyleBackColor = true;
            this.last.Click += new System.EventHandler(this.last_Click);
            // 
            // next
            // 
            this.next.AutoSize = true;
            this.next.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.next.Depth = 0;
            this.next.Icon = null;
            this.next.Location = new System.Drawing.Point(234, 367);
            this.next.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.next.MouseState = MaterialSkin.MouseState.HOVER;
            this.next.Name = "next";
            this.next.Primary = true;
            this.next.Size = new System.Drawing.Size(32, 36);
            this.next.TabIndex = 137;
            this.next.Text = ">|";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // previous
            // 
            this.previous.AutoSize = true;
            this.previous.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.previous.Depth = 0;
            this.previous.Icon = null;
            this.previous.Location = new System.Drawing.Point(164, 367);
            this.previous.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.previous.MouseState = MaterialSkin.MouseState.HOVER;
            this.previous.Name = "previous";
            this.previous.Primary = true;
            this.previous.Size = new System.Drawing.Size(31, 36);
            this.previous.TabIndex = 138;
            this.previous.Text = "|<";
            this.previous.UseVisualStyleBackColor = true;
            this.previous.Click += new System.EventHandler(this.previous_Click);
            // 
            // first
            // 
            this.first.AutoSize = true;
            this.first.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.first.Depth = 0;
            this.first.Icon = null;
            this.first.Location = new System.Drawing.Point(98, 367);
            this.first.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.first.MouseState = MaterialSkin.MouseState.HOVER;
            this.first.Name = "first";
            this.first.Primary = true;
            this.first.Size = new System.Drawing.Size(35, 36);
            this.first.TabIndex = 139;
            this.first.Text = "<<";
            this.first.UseVisualStyleBackColor = true;
            this.first.Click += new System.EventHandler(this.first_Click);
            // 
            // btn_search
            // 
            this.btn_search.AutoSize = true;
            this.btn_search.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_search.Depth = 0;
            this.btn_search.Icon = null;
            this.btn_search.Location = new System.Drawing.Point(453, 335);
            this.btn_search.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_search.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_search.Name = "btn_search";
            this.btn_search.Primary = true;
            this.btn_search.Size = new System.Drawing.Size(73, 36);
            this.btn_search.TabIndex = 140;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_Nouveau
            // 
            this.btn_Nouveau.AutoSize = true;
            this.btn_Nouveau.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Nouveau.Depth = 0;
            this.btn_Nouveau.Icon = null;
            this.btn_Nouveau.Location = new System.Drawing.Point(448, 96);
            this.btn_Nouveau.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Nouveau.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Nouveau.Name = "btn_Nouveau";
            this.btn_Nouveau.Primary = true;
            this.btn_Nouveau.Size = new System.Drawing.Size(84, 36);
            this.btn_Nouveau.TabIndex = 141;
            this.btn_Nouveau.Text = "Nouveau";
            this.btn_Nouveau.UseVisualStyleBackColor = true;
            this.btn_Nouveau.Click += new System.EventHandler(this.btn_Nouveau_Click);
            // 
            // btn_Supprimer
            // 
            this.btn_Supprimer.AutoSize = true;
            this.btn_Supprimer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Supprimer.Depth = 0;
            this.btn_Supprimer.Icon = null;
            this.btn_Supprimer.Location = new System.Drawing.Point(448, 242);
            this.btn_Supprimer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Supprimer.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Supprimer.Name = "btn_Supprimer";
            this.btn_Supprimer.Primary = true;
            this.btn_Supprimer.Size = new System.Drawing.Size(97, 36);
            this.btn_Supprimer.TabIndex = 142;
            this.btn_Supprimer.Text = "Supprimer";
            this.btn_Supprimer.UseVisualStyleBackColor = true;
            this.btn_Supprimer.Click += new System.EventHandler(this.btn_Supprimer_Click);
            // 
            // btn_Modifier
            // 
            this.btn_Modifier.AutoSize = true;
            this.btn_Modifier.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Modifier.Depth = 0;
            this.btn_Modifier.Icon = null;
            this.btn_Modifier.Location = new System.Drawing.Point(448, 197);
            this.btn_Modifier.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Modifier.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Modifier.Name = "btn_Modifier";
            this.btn_Modifier.Primary = true;
            this.btn_Modifier.Size = new System.Drawing.Size(83, 36);
            this.btn_Modifier.TabIndex = 143;
            this.btn_Modifier.Text = "Modifier";
            this.btn_Modifier.UseVisualStyleBackColor = true;
            this.btn_Modifier.Click += new System.EventHandler(this.btn_Modifier_Click);
            // 
            // btn_Ajouter
            // 
            this.btn_Ajouter.AutoSize = true;
            this.btn_Ajouter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Ajouter.Depth = 0;
            this.btn_Ajouter.Icon = null;
            this.btn_Ajouter.Location = new System.Drawing.Point(448, 147);
            this.btn_Ajouter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Ajouter.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Ajouter.Name = "btn_Ajouter";
            this.btn_Ajouter.Primary = true;
            this.btn_Ajouter.Size = new System.Drawing.Size(81, 36);
            this.btn_Ajouter.TabIndex = 144;
            this.btn_Ajouter.Text = "Ajouter";
            this.btn_Ajouter.UseVisualStyleBackColor = true;
            this.btn_Ajouter.Click += new System.EventHandler(this.btn_Ajouter_Click);
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.AutoSize = true;
            this.materialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Icon = null;
            this.materialRaisedButton1.Location = new System.Drawing.Point(219, 621);
            this.materialRaisedButton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(140, 36);
            this.materialRaisedButton1.TabIndex = 141;
            this.materialRaisedButton1.Text = "Form Recherche";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // F_Affectation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 640);
            this.Controls.Add(this.last);
            this.Controls.Add(this.next);
            this.Controls.Add(this.previous);
            this.Controls.Add(this.first);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.btn_Nouveau);
            this.Controls.Add(this.btn_Supprimer);
            this.Controls.Add(this.btn_Modifier);
            this.Controls.Add(this.btn_Ajouter);
            this.Controls.Add(this.cmb_mdl);
            this.Controls.Add(this.tb_numaff);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.dgv_Aff);
            this.Controls.Add(this.tb_Search);
            this.Controls.Add(this.dtp_date_aff);
            this.Controls.Add(this.cmb_Formateur);
            this.Controls.Add(this.cmb_groupe);
            this.Controls.Add(this.cmb_filiere);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "F_Affectation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.F_Affectation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Aff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.DataGridView dgv_Aff;
        private MaterialSkin.Controls.MaterialSingleLineTextField tb_Search;
        private System.Windows.Forms.ComboBox cmb_filiere;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField tb_numaff;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private System.Windows.Forms.DateTimePicker dtp_date_aff;
        private System.Windows.Forms.ComboBox cmb_groupe;
        private System.Windows.Forms.ComboBox cmb_Formateur;
        private System.Windows.Forms.ComboBox cmb_mdl;
        private MaterialSkin.Controls.MaterialRaisedButton last;
        private MaterialSkin.Controls.MaterialRaisedButton next;
        private MaterialSkin.Controls.MaterialRaisedButton previous;
        private MaterialSkin.Controls.MaterialRaisedButton first;
        private MaterialSkin.Controls.MaterialRaisedButton btn_search;
        private MaterialSkin.Controls.MaterialRaisedButton btn_Nouveau;
        private MaterialSkin.Controls.MaterialRaisedButton btn_Supprimer;
        private MaterialSkin.Controls.MaterialRaisedButton btn_Modifier;
        private MaterialSkin.Controls.MaterialRaisedButton btn_Ajouter;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
    }
}