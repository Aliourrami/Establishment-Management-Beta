namespace Establishment_Management
{
    partial class F_Stagaire
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
            this.tb_NumStg = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tb_NomStg = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tb_PrenomStg = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.cbx_Grp = new System.Windows.Forms.ComboBox();
            this.dgv_Stg = new System.Windows.Forms.DataGridView();
            this.tb_Search = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btn_Save = new MaterialSkin.Controls.MaterialRaisedButton();
            this.last = new MaterialSkin.Controls.MaterialRaisedButton();
            this.next = new MaterialSkin.Controls.MaterialRaisedButton();
            this.previous = new MaterialSkin.Controls.MaterialRaisedButton();
            this.first = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_search = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_Nouveau = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_Supprimer = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_Modifier = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_Ajouter = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dtp_DN = new System.Windows.Forms.DateTimePicker();
            this.tb_CInStg = new MaterialSkin.Controls.MaterialSingleLineTextField();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Stg)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_NumStg
            // 
            this.tb_NumStg.Depth = 0;
            this.tb_NumStg.Hint = "Code Stagaire";
            this.tb_NumStg.Location = new System.Drawing.Point(99, 102);
            this.tb_NumStg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_NumStg.MaxLength = 32767;
            this.tb_NumStg.MouseState = MaterialSkin.MouseState.HOVER;
            this.tb_NumStg.Name = "tb_NumStg";
            this.tb_NumStg.PasswordChar = '\0';
            this.tb_NumStg.SelectedText = "";
            this.tb_NumStg.SelectionLength = 0;
            this.tb_NumStg.SelectionStart = 0;
            this.tb_NumStg.Size = new System.Drawing.Size(200, 23);
            this.tb_NumStg.TabIndex = 0;
            this.tb_NumStg.TabStop = false;
            this.tb_NumStg.UseSystemPasswordChar = false;
            // 
            // tb_NomStg
            // 
            this.tb_NomStg.Depth = 0;
            this.tb_NomStg.Hint = "Nom Stg";
            this.tb_NomStg.Location = new System.Drawing.Point(99, 145);
            this.tb_NomStg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_NomStg.MaxLength = 32767;
            this.tb_NomStg.MouseState = MaterialSkin.MouseState.HOVER;
            this.tb_NomStg.Name = "tb_NomStg";
            this.tb_NomStg.PasswordChar = '\0';
            this.tb_NomStg.SelectedText = "";
            this.tb_NomStg.SelectionLength = 0;
            this.tb_NomStg.SelectionStart = 0;
            this.tb_NomStg.Size = new System.Drawing.Size(200, 23);
            this.tb_NomStg.TabIndex = 1;
            this.tb_NomStg.TabStop = false;
            this.tb_NomStg.UseSystemPasswordChar = false;
            // 
            // tb_PrenomStg
            // 
            this.tb_PrenomStg.Depth = 0;
            this.tb_PrenomStg.Hint = "Prenom Stg";
            this.tb_PrenomStg.Location = new System.Drawing.Point(99, 189);
            this.tb_PrenomStg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_PrenomStg.MaxLength = 32767;
            this.tb_PrenomStg.MouseState = MaterialSkin.MouseState.HOVER;
            this.tb_PrenomStg.Name = "tb_PrenomStg";
            this.tb_PrenomStg.PasswordChar = '\0';
            this.tb_PrenomStg.SelectedText = "";
            this.tb_PrenomStg.SelectionLength = 0;
            this.tb_PrenomStg.SelectionStart = 0;
            this.tb_PrenomStg.Size = new System.Drawing.Size(200, 23);
            this.tb_PrenomStg.TabIndex = 2;
            this.tb_PrenomStg.TabStop = false;
            this.tb_PrenomStg.UseSystemPasswordChar = false;
            // 
            // cbx_Grp
            // 
            this.cbx_Grp.Font = new System.Drawing.Font("Yandex-UI-Icons-Private", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_Grp.FormattingEnabled = true;
            this.cbx_Grp.Location = new System.Drawing.Point(99, 288);
            this.cbx_Grp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbx_Grp.Name = "cbx_Grp";
            this.cbx_Grp.Size = new System.Drawing.Size(200, 24);
            this.cbx_Grp.TabIndex = 4;
            this.cbx_Grp.Tag = "";
            this.cbx_Grp.Text = "Groupe";
            // 
            // dgv_Stg
            // 
            this.dgv_Stg.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_Stg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Stg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Stg.GridColor = System.Drawing.Color.Maroon;
            this.dgv_Stg.Location = new System.Drawing.Point(20, 434);
            this.dgv_Stg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_Stg.Name = "dgv_Stg";
            this.dgv_Stg.RowTemplate.Height = 24;
            this.dgv_Stg.Size = new System.Drawing.Size(537, 172);
            this.dgv_Stg.TabIndex = 19;
            // 
            // tb_Search
            // 
            this.tb_Search.Depth = 0;
            this.tb_Search.Hint = "Search";
            this.tb_Search.Location = new System.Drawing.Point(397, 303);
            this.tb_Search.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_Search.MaxLength = 32767;
            this.tb_Search.MouseState = MaterialSkin.MouseState.HOVER;
            this.tb_Search.Name = "tb_Search";
            this.tb_Search.PasswordChar = '\0';
            this.tb_Search.SelectedText = "";
            this.tb_Search.SelectionLength = 0;
            this.tb_Search.SelectionStart = 0;
            this.tb_Search.Size = new System.Drawing.Size(144, 23);
            this.tb_Search.TabIndex = 13;
            this.tb_Search.TabStop = false;
            this.tb_Search.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(233, 33);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(120, 19);
            this.materialLabel1.TabIndex = 24;
            this.materialLabel1.Text = "Gestion Stagaire";
            // 
            // btn_Save
            // 
            this.btn_Save.AutoSize = true;
            this.btn_Save.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Save.Depth = 0;
            this.btn_Save.Icon = null;
            this.btn_Save.Location = new System.Drawing.Point(265, 614);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Save.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Primary = true;
            this.btn_Save.Size = new System.Drawing.Size(55, 36);
            this.btn_Save.TabIndex = 26;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // last
            // 
            this.last.AutoSize = true;
            this.last.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.last.Depth = 0;
            this.last.Icon = null;
            this.last.Location = new System.Drawing.Point(305, 387);
            this.last.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.last.MouseState = MaterialSkin.MouseState.HOVER;
            this.last.Name = "last";
            this.last.Primary = true;
            this.last.Size = new System.Drawing.Size(35, 36);
            this.last.TabIndex = 164;
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
            this.next.Location = new System.Drawing.Point(235, 387);
            this.next.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.next.MouseState = MaterialSkin.MouseState.HOVER;
            this.next.Name = "next";
            this.next.Primary = true;
            this.next.Size = new System.Drawing.Size(32, 36);
            this.next.TabIndex = 165;
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
            this.previous.Location = new System.Drawing.Point(165, 387);
            this.previous.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.previous.MouseState = MaterialSkin.MouseState.HOVER;
            this.previous.Name = "previous";
            this.previous.Primary = true;
            this.previous.Size = new System.Drawing.Size(31, 36);
            this.previous.TabIndex = 166;
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
            this.first.Location = new System.Drawing.Point(99, 387);
            this.first.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.first.MouseState = MaterialSkin.MouseState.HOVER;
            this.first.Name = "first";
            this.first.Primary = true;
            this.first.Size = new System.Drawing.Size(35, 36);
            this.first.TabIndex = 167;
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
            this.btn_search.Location = new System.Drawing.Point(432, 331);
            this.btn_search.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_search.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_search.Name = "btn_search";
            this.btn_search.Primary = true;
            this.btn_search.Size = new System.Drawing.Size(73, 36);
            this.btn_search.TabIndex = 168;
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
            this.btn_Nouveau.Location = new System.Drawing.Point(423, 120);
            this.btn_Nouveau.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Nouveau.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Nouveau.Name = "btn_Nouveau";
            this.btn_Nouveau.Primary = true;
            this.btn_Nouveau.Size = new System.Drawing.Size(84, 36);
            this.btn_Nouveau.TabIndex = 169;
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
            this.btn_Supprimer.Location = new System.Drawing.Point(423, 243);
            this.btn_Supprimer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Supprimer.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Supprimer.Name = "btn_Supprimer";
            this.btn_Supprimer.Primary = true;
            this.btn_Supprimer.Size = new System.Drawing.Size(97, 36);
            this.btn_Supprimer.TabIndex = 170;
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
            this.btn_Modifier.Location = new System.Drawing.Point(423, 202);
            this.btn_Modifier.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Modifier.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Modifier.Name = "btn_Modifier";
            this.btn_Modifier.Primary = true;
            this.btn_Modifier.Size = new System.Drawing.Size(83, 36);
            this.btn_Modifier.TabIndex = 171;
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
            this.btn_Ajouter.Location = new System.Drawing.Point(423, 162);
            this.btn_Ajouter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Ajouter.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Ajouter.Name = "btn_Ajouter";
            this.btn_Ajouter.Primary = true;
            this.btn_Ajouter.Size = new System.Drawing.Size(81, 36);
            this.btn_Ajouter.TabIndex = 172;
            this.btn_Ajouter.Text = "Ajouter";
            this.btn_Ajouter.UseVisualStyleBackColor = true;
            this.btn_Ajouter.Click += new System.EventHandler(this.btn_Ajouter_Click);
            // 
            // dtp_DN
            // 
            this.dtp_DN.Location = new System.Drawing.Point(103, 242);
            this.dtp_DN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtp_DN.Name = "dtp_DN";
            this.dtp_DN.Size = new System.Drawing.Size(197, 20);
            this.dtp_DN.TabIndex = 173;
            // 
            // tb_CInStg
            // 
            this.tb_CInStg.Depth = 0;
            this.tb_CInStg.Hint = "Cin Stg";
            this.tb_CInStg.Location = new System.Drawing.Point(99, 337);
            this.tb_CInStg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_CInStg.MaxLength = 32767;
            this.tb_CInStg.MouseState = MaterialSkin.MouseState.HOVER;
            this.tb_CInStg.Name = "tb_CInStg";
            this.tb_CInStg.PasswordChar = '\0';
            this.tb_CInStg.SelectedText = "";
            this.tb_CInStg.SelectionLength = 0;
            this.tb_CInStg.SelectionStart = 0;
            this.tb_CInStg.Size = new System.Drawing.Size(200, 23);
            this.tb_CInStg.TabIndex = 1;
            this.tb_CInStg.TabStop = false;
            this.tb_CInStg.UseSystemPasswordChar = false;
            // 
            // F_Stagaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 640);
            this.Controls.Add(this.dtp_DN);
            this.Controls.Add(this.last);
            this.Controls.Add(this.next);
            this.Controls.Add(this.previous);
            this.Controls.Add(this.first);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_Nouveau);
            this.Controls.Add(this.btn_Supprimer);
            this.Controls.Add(this.btn_Modifier);
            this.Controls.Add(this.btn_Ajouter);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.dgv_Stg);
            this.Controls.Add(this.tb_Search);
            this.Controls.Add(this.cbx_Grp);
            this.Controls.Add(this.tb_PrenomStg);
            this.Controls.Add(this.tb_CInStg);
            this.Controls.Add(this.tb_NomStg);
            this.Controls.Add(this.tb_NumStg);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "F_Stagaire";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_Stagaire";
            this.Load += new System.EventHandler(this.F_Stagaire_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Stg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField tb_NumStg;
        private MaterialSkin.Controls.MaterialSingleLineTextField tb_NomStg;
        private MaterialSkin.Controls.MaterialSingleLineTextField tb_PrenomStg;
        private System.Windows.Forms.ComboBox cbx_Grp;
        private System.Windows.Forms.DataGridView dgv_Stg;
        private MaterialSkin.Controls.MaterialSingleLineTextField tb_Search;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialRaisedButton btn_Save;
        private MaterialSkin.Controls.MaterialRaisedButton last;
        private MaterialSkin.Controls.MaterialRaisedButton next;
        private MaterialSkin.Controls.MaterialRaisedButton previous;
        private MaterialSkin.Controls.MaterialRaisedButton first;
        private MaterialSkin.Controls.MaterialRaisedButton btn_search;
        private MaterialSkin.Controls.MaterialRaisedButton btn_Nouveau;
        private MaterialSkin.Controls.MaterialRaisedButton btn_Supprimer;
        private MaterialSkin.Controls.MaterialRaisedButton btn_Modifier;
        private MaterialSkin.Controls.MaterialRaisedButton btn_Ajouter;
        private System.Windows.Forms.DateTimePicker dtp_DN;
        private MaterialSkin.Controls.MaterialSingleLineTextField tb_CInStg;
    }
}