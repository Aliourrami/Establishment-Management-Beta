namespace Establishment_Management
{
    partial class F_EFM_Planification
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
            this.cmb_module = new System.Windows.Forms.ComboBox();
            this.cmb_NumFiliere = new System.Windows.Forms.ComboBox();
            this.cmb_groupe = new System.Windows.Forms.ComboBox();
            this.dtp_date_prévue = new System.Windows.Forms.DateTimePicker();
            this.dgv_Efm_Plan = new System.Windows.Forms.DataGridView();
            this.tb_Search = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.dtp_date_effective = new System.Windows.Forms.DateTimePicker();
            this.dfds = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.last = new MaterialSkin.Controls.MaterialRaisedButton();
            this.next = new MaterialSkin.Controls.MaterialRaisedButton();
            this.previous = new MaterialSkin.Controls.MaterialRaisedButton();
            this.first = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_search = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_Nouveau = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_Supprimer = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_Modifier = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_Ajouter = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Efm_Plan)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_module
            // 
            this.cmb_module.FormattingEnabled = true;
            this.cmb_module.Location = new System.Drawing.Point(194, 109);
            this.cmb_module.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmb_module.Name = "cmb_module";
            this.cmb_module.Size = new System.Drawing.Size(136, 21);
            this.cmb_module.TabIndex = 0;
            // 
            // cmb_NumFiliere
            // 
            this.cmb_NumFiliere.FormattingEnabled = true;
            this.cmb_NumFiliere.Location = new System.Drawing.Point(194, 160);
            this.cmb_NumFiliere.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmb_NumFiliere.Name = "cmb_NumFiliere";
            this.cmb_NumFiliere.Size = new System.Drawing.Size(136, 21);
            this.cmb_NumFiliere.TabIndex = 1;
            // 
            // cmb_groupe
            // 
            this.cmb_groupe.FormattingEnabled = true;
            this.cmb_groupe.Location = new System.Drawing.Point(194, 211);
            this.cmb_groupe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmb_groupe.Name = "cmb_groupe";
            this.cmb_groupe.Size = new System.Drawing.Size(136, 21);
            this.cmb_groupe.TabIndex = 3;
            // 
            // dtp_date_prévue
            // 
            this.dtp_date_prévue.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_date_prévue.Location = new System.Drawing.Point(194, 262);
            this.dtp_date_prévue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtp_date_prévue.Name = "dtp_date_prévue";
            this.dtp_date_prévue.Size = new System.Drawing.Size(136, 20);
            this.dtp_date_prévue.TabIndex = 4;
            // 
            // dgv_Efm_Plan
            // 
            this.dgv_Efm_Plan.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_Efm_Plan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Efm_Plan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Efm_Plan.GridColor = System.Drawing.Color.Maroon;
            this.dgv_Efm_Plan.Location = new System.Drawing.Point(32, 405);
            this.dgv_Efm_Plan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_Efm_Plan.Name = "dgv_Efm_Plan";
            this.dgv_Efm_Plan.RowTemplate.Height = 24;
            this.dgv_Efm_Plan.Size = new System.Drawing.Size(537, 200);
            this.dgv_Efm_Plan.TabIndex = 33;
            // 
            // tb_Search
            // 
            this.tb_Search.Depth = 0;
            this.tb_Search.Hint = "Search";
            this.tb_Search.Location = new System.Drawing.Point(410, 322);
            this.tb_Search.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_Search.MaxLength = 32767;
            this.tb_Search.MouseState = MaterialSkin.MouseState.HOVER;
            this.tb_Search.Name = "tb_Search";
            this.tb_Search.PasswordChar = '\0';
            this.tb_Search.SelectedText = "";
            this.tb_Search.SelectionLength = 0;
            this.tb_Search.SelectionStart = 0;
            this.tb_Search.Size = new System.Drawing.Size(144, 23);
            this.tb_Search.TabIndex = 27;
            this.tb_Search.TabStop = false;
            this.tb_Search.UseSystemPasswordChar = false;
            // 
            // dtp_date_effective
            // 
            this.dtp_date_effective.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_date_effective.Location = new System.Drawing.Point(194, 312);
            this.dtp_date_effective.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtp_date_effective.Name = "dtp_date_effective";
            this.dtp_date_effective.Size = new System.Drawing.Size(136, 20);
            this.dtp_date_effective.TabIndex = 39;
            // 
            // dfds
            // 
            this.dfds.AutoSize = true;
            this.dfds.Depth = 0;
            this.dfds.Font = new System.Drawing.Font("Roboto", 11F);
            this.dfds.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dfds.Location = new System.Drawing.Point(240, 32);
            this.dfds.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dfds.MouseState = MaterialSkin.MouseState.HOVER;
            this.dfds.Name = "dfds";
            this.dfds.Size = new System.Drawing.Size(127, 19);
            this.dfds.TabIndex = 41;
            this.dfds.Text = "EFM Planification";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(70, 107);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(67, 19);
            this.materialLabel2.TabIndex = 41;
            this.materialLabel2.Text = "Module :";
            this.materialLabel2.Click += new System.EventHandler(this.materialLabel2_Click);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(79, 154);
            this.materialLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(58, 19);
            this.materialLabel3.TabIndex = 41;
            this.materialLabel3.Text = "Filiére :";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(72, 208);
            this.materialLabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(65, 19);
            this.materialLabel4.TabIndex = 41;
            this.materialLabel4.Text = "Groupe :";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(43, 259);
            this.materialLabel5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(97, 19);
            this.materialLabel5.TabIndex = 41;
            this.materialLabel5.Text = "Date Prévue :";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(28, 309);
            this.materialLabel6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(112, 19);
            this.materialLabel6.TabIndex = 41;
            this.materialLabel6.Text = "Date Affective :";
            // 
            // last
            // 
            this.last.AutoSize = true;
            this.last.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.last.Depth = 0;
            this.last.Icon = null;
            this.last.Location = new System.Drawing.Point(286, 358);
            this.last.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.last.MouseState = MaterialSkin.MouseState.HOVER;
            this.last.Name = "last";
            this.last.Primary = true;
            this.last.Size = new System.Drawing.Size(35, 36);
            this.last.TabIndex = 145;
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
            this.next.Location = new System.Drawing.Point(216, 358);
            this.next.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.next.MouseState = MaterialSkin.MouseState.HOVER;
            this.next.Name = "next";
            this.next.Primary = true;
            this.next.Size = new System.Drawing.Size(32, 36);
            this.next.TabIndex = 146;
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
            this.previous.Location = new System.Drawing.Point(146, 358);
            this.previous.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.previous.MouseState = MaterialSkin.MouseState.HOVER;
            this.previous.Name = "previous";
            this.previous.Primary = true;
            this.previous.Size = new System.Drawing.Size(31, 36);
            this.previous.TabIndex = 147;
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
            this.first.Location = new System.Drawing.Point(80, 358);
            this.first.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.first.MouseState = MaterialSkin.MouseState.HOVER;
            this.first.Name = "first";
            this.first.Primary = true;
            this.first.Size = new System.Drawing.Size(35, 36);
            this.first.TabIndex = 148;
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
            this.btn_search.Location = new System.Drawing.Point(439, 349);
            this.btn_search.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_search.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_search.Name = "btn_search";
            this.btn_search.Primary = true;
            this.btn_search.Size = new System.Drawing.Size(73, 36);
            this.btn_search.TabIndex = 149;
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
            this.btn_Nouveau.Location = new System.Drawing.Point(428, 98);
            this.btn_Nouveau.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Nouveau.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Nouveau.Name = "btn_Nouveau";
            this.btn_Nouveau.Primary = true;
            this.btn_Nouveau.Size = new System.Drawing.Size(84, 36);
            this.btn_Nouveau.TabIndex = 150;
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
            this.btn_Supprimer.Location = new System.Drawing.Point(428, 242);
            this.btn_Supprimer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Supprimer.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Supprimer.Name = "btn_Supprimer";
            this.btn_Supprimer.Primary = true;
            this.btn_Supprimer.Size = new System.Drawing.Size(97, 36);
            this.btn_Supprimer.TabIndex = 151;
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
            this.btn_Modifier.Location = new System.Drawing.Point(428, 198);
            this.btn_Modifier.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Modifier.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Modifier.Name = "btn_Modifier";
            this.btn_Modifier.Primary = true;
            this.btn_Modifier.Size = new System.Drawing.Size(83, 36);
            this.btn_Modifier.TabIndex = 152;
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
            this.btn_Ajouter.Location = new System.Drawing.Point(428, 149);
            this.btn_Ajouter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Ajouter.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Ajouter.Name = "btn_Ajouter";
            this.btn_Ajouter.Primary = true;
            this.btn_Ajouter.Size = new System.Drawing.Size(81, 36);
            this.btn_Ajouter.TabIndex = 153;
            this.btn_Ajouter.Text = "Ajouter";
            this.btn_Ajouter.UseVisualStyleBackColor = true;
            this.btn_Ajouter.Click += new System.EventHandler(this.btn_Ajouter_Click);
            // 
            // F_EFM_Planification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 640);
            this.Controls.Add(this.last);
            this.Controls.Add(this.next);
            this.Controls.Add(this.previous);
            this.Controls.Add(this.first);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_Nouveau);
            this.Controls.Add(this.btn_Supprimer);
            this.Controls.Add(this.btn_Modifier);
            this.Controls.Add(this.btn_Ajouter);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.dfds);
            this.Controls.Add(this.dtp_date_effective);
            this.Controls.Add(this.dgv_Efm_Plan);
            this.Controls.Add(this.tb_Search);
            this.Controls.Add(this.dtp_date_prévue);
            this.Controls.Add(this.cmb_groupe);
            this.Controls.Add(this.cmb_NumFiliere);
            this.Controls.Add(this.cmb_module);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "F_EFM_Planification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_EFM_Planification";
            this.Load += new System.EventHandler(this.F_EFM_Planification_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Efm_Plan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_module;
        private System.Windows.Forms.ComboBox cmb_NumFiliere;
        private System.Windows.Forms.ComboBox cmb_groupe;
        private System.Windows.Forms.DateTimePicker dtp_date_prévue;
        private System.Windows.Forms.DataGridView dgv_Efm_Plan;
        private MaterialSkin.Controls.MaterialSingleLineTextField tb_Search;
        private System.Windows.Forms.DateTimePicker dtp_date_effective;
        private MaterialSkin.Controls.MaterialLabel dfds;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialRaisedButton last;
        private MaterialSkin.Controls.MaterialRaisedButton next;
        private MaterialSkin.Controls.MaterialRaisedButton previous;
        private MaterialSkin.Controls.MaterialRaisedButton first;
        private MaterialSkin.Controls.MaterialRaisedButton btn_search;
        private MaterialSkin.Controls.MaterialRaisedButton btn_Nouveau;
        private MaterialSkin.Controls.MaterialRaisedButton btn_Supprimer;
        private MaterialSkin.Controls.MaterialRaisedButton btn_Modifier;
        private MaterialSkin.Controls.MaterialRaisedButton btn_Ajouter;
    }
}