namespace Establishment_Management
{
    partial class F_Groupe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Groupe));
            this.tb_numGrp = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tb_nomGrp = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tb_Search = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tb_anneeGrp = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.dgv_grp = new System.Windows.Forms.DataGridView();
            this.cbx_filiere = new System.Windows.Forms.ComboBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_grp)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_numGrp
            // 
            this.tb_numGrp.Depth = 0;
            this.tb_numGrp.Hint = "Numéro Groupe";
            resources.ApplyResources(this.tb_numGrp, "tb_numGrp");
            this.tb_numGrp.MaxLength = 32767;
            this.tb_numGrp.MouseState = MaterialSkin.MouseState.HOVER;
            this.tb_numGrp.Name = "tb_numGrp";
            this.tb_numGrp.PasswordChar = '\0';
            this.tb_numGrp.SelectedText = "";
            this.tb_numGrp.SelectionLength = 0;
            this.tb_numGrp.SelectionStart = 0;
            this.tb_numGrp.TabStop = false;
            this.tb_numGrp.UseSystemPasswordChar = false;
            // 
            // tb_nomGrp
            // 
            this.tb_nomGrp.Depth = 0;
            this.tb_nomGrp.Hint = "Nom Groupe";
            resources.ApplyResources(this.tb_nomGrp, "tb_nomGrp");
            this.tb_nomGrp.MaxLength = 32767;
            this.tb_nomGrp.MouseState = MaterialSkin.MouseState.HOVER;
            this.tb_nomGrp.Name = "tb_nomGrp";
            this.tb_nomGrp.PasswordChar = '\0';
            this.tb_nomGrp.SelectedText = "";
            this.tb_nomGrp.SelectionLength = 0;
            this.tb_nomGrp.SelectionStart = 0;
            this.tb_nomGrp.TabStop = false;
            this.tb_nomGrp.UseSystemPasswordChar = false;
            // 
            // tb_Search
            // 
            this.tb_Search.Depth = 0;
            this.tb_Search.Hint = "Search";
            resources.ApplyResources(this.tb_Search, "tb_Search");
            this.tb_Search.MaxLength = 32767;
            this.tb_Search.MouseState = MaterialSkin.MouseState.HOVER;
            this.tb_Search.Name = "tb_Search";
            this.tb_Search.PasswordChar = '\0';
            this.tb_Search.SelectedText = "";
            this.tb_Search.SelectionLength = 0;
            this.tb_Search.SelectionStart = 0;
            this.tb_Search.TabStop = false;
            this.tb_Search.UseSystemPasswordChar = false;
            // 
            // tb_anneeGrp
            // 
            this.tb_anneeGrp.Depth = 0;
            this.tb_anneeGrp.Hint = "Année Groupe";
            resources.ApplyResources(this.tb_anneeGrp, "tb_anneeGrp");
            this.tb_anneeGrp.MaxLength = 32767;
            this.tb_anneeGrp.MouseState = MaterialSkin.MouseState.HOVER;
            this.tb_anneeGrp.Name = "tb_anneeGrp";
            this.tb_anneeGrp.PasswordChar = '\0';
            this.tb_anneeGrp.SelectedText = "";
            this.tb_anneeGrp.SelectionLength = 0;
            this.tb_anneeGrp.SelectionStart = 0;
            this.tb_anneeGrp.TabStop = false;
            this.tb_anneeGrp.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            resources.ApplyResources(this.materialLabel1, "materialLabel1");
            this.materialLabel1.Depth = 0;
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            // 
            // dgv_grp
            // 
            this.dgv_grp.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_grp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_grp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_grp.GridColor = System.Drawing.Color.Maroon;
            resources.ApplyResources(this.dgv_grp, "dgv_grp");
            this.dgv_grp.Name = "dgv_grp";
            this.dgv_grp.RowTemplate.Height = 24;
            // 
            // cbx_filiere
            // 
            this.cbx_filiere.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbx_filiere.DropDownHeight = 200;
            this.cbx_filiere.DropDownWidth = 200;
            resources.ApplyResources(this.cbx_filiere, "cbx_filiere");
            this.cbx_filiere.FormattingEnabled = true;
            this.cbx_filiere.Name = "cbx_filiere";
            // 
            // last
            // 
            resources.ApplyResources(this.last, "last");
            this.last.Depth = 0;
            this.last.Icon = null;
            this.last.MouseState = MaterialSkin.MouseState.HOVER;
            this.last.Name = "last";
            this.last.Primary = true;
            this.last.UseVisualStyleBackColor = true;
            this.last.Click += new System.EventHandler(this.last_Click);
            // 
            // next
            // 
            resources.ApplyResources(this.next, "next");
            this.next.Depth = 0;
            this.next.Icon = null;
            this.next.MouseState = MaterialSkin.MouseState.HOVER;
            this.next.Name = "next";
            this.next.Primary = true;
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // previous
            // 
            resources.ApplyResources(this.previous, "previous");
            this.previous.Depth = 0;
            this.previous.Icon = null;
            this.previous.MouseState = MaterialSkin.MouseState.HOVER;
            this.previous.Name = "previous";
            this.previous.Primary = true;
            this.previous.UseVisualStyleBackColor = true;
            this.previous.Click += new System.EventHandler(this.previous_Click);
            // 
            // first
            // 
            resources.ApplyResources(this.first, "first");
            this.first.Depth = 0;
            this.first.Icon = null;
            this.first.MouseState = MaterialSkin.MouseState.HOVER;
            this.first.Name = "first";
            this.first.Primary = true;
            this.first.UseVisualStyleBackColor = true;
            this.first.Click += new System.EventHandler(this.first_Click);
            // 
            // btn_search
            // 
            resources.ApplyResources(this.btn_search, "btn_search");
            this.btn_search.Depth = 0;
            this.btn_search.Icon = null;
            this.btn_search.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_search.Name = "btn_search";
            this.btn_search.Primary = true;
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_Nouveau
            // 
            resources.ApplyResources(this.btn_Nouveau, "btn_Nouveau");
            this.btn_Nouveau.Depth = 0;
            this.btn_Nouveau.Icon = null;
            this.btn_Nouveau.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Nouveau.Name = "btn_Nouveau";
            this.btn_Nouveau.Primary = true;
            this.btn_Nouveau.UseVisualStyleBackColor = true;
            this.btn_Nouveau.Click += new System.EventHandler(this.btn_Nouveau_Click);
            // 
            // btn_Supprimer
            // 
            resources.ApplyResources(this.btn_Supprimer, "btn_Supprimer");
            this.btn_Supprimer.Depth = 0;
            this.btn_Supprimer.Icon = null;
            this.btn_Supprimer.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Supprimer.Name = "btn_Supprimer";
            this.btn_Supprimer.Primary = true;
            this.btn_Supprimer.UseVisualStyleBackColor = true;
            this.btn_Supprimer.Click += new System.EventHandler(this.btn_Supprimer_Click);
            // 
            // btn_Modifier
            // 
            resources.ApplyResources(this.btn_Modifier, "btn_Modifier");
            this.btn_Modifier.Depth = 0;
            this.btn_Modifier.Icon = null;
            this.btn_Modifier.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Modifier.Name = "btn_Modifier";
            this.btn_Modifier.Primary = true;
            this.btn_Modifier.UseVisualStyleBackColor = true;
            this.btn_Modifier.Click += new System.EventHandler(this.btn_Modifier_Click);
            // 
            // btn_Ajouter
            // 
            resources.ApplyResources(this.btn_Ajouter, "btn_Ajouter");
            this.btn_Ajouter.Depth = 0;
            this.btn_Ajouter.Icon = null;
            this.btn_Ajouter.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Ajouter.Name = "btn_Ajouter";
            this.btn_Ajouter.Primary = true;
            this.btn_Ajouter.UseVisualStyleBackColor = true;
            this.btn_Ajouter.Click += new System.EventHandler(this.btn_Ajouter_Click);
            // 
            // materialRaisedButton1
            // 
            resources.ApplyResources(this.materialRaisedButton1, "materialRaisedButton1");
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Icon = null;
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // F_Groupe
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.Controls.Add(this.cbx_filiere);
            this.Controls.Add(this.dgv_grp);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.tb_anneeGrp);
            this.Controls.Add(this.tb_Search);
            this.Controls.Add(this.tb_nomGrp);
            this.Controls.Add(this.tb_numGrp);
            this.Name = "F_Groupe";
            this.Load += new System.EventHandler(this.F_Groupe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_grp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField tb_numGrp;
        private MaterialSkin.Controls.MaterialSingleLineTextField tb_nomGrp;
        private MaterialSkin.Controls.MaterialSingleLineTextField tb_Search;
        private MaterialSkin.Controls.MaterialSingleLineTextField tb_anneeGrp;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.DataGridView dgv_grp;
        private System.Windows.Forms.ComboBox cbx_filiere;
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