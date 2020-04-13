namespace Establishment_Management
{
    partial class F_Seance
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
            this.tb_numSc = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.dgv_Sc = new System.Windows.Forms.DataGridView();
            this.tb_Search = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.dtp_date_Sc = new System.Windows.Forms.DateTimePicker();
            this.cmb_NumAff = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_durée = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tb_salle = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.last = new MaterialSkin.Controls.MaterialRaisedButton();
            this.next = new MaterialSkin.Controls.MaterialRaisedButton();
            this.previous = new MaterialSkin.Controls.MaterialRaisedButton();
            this.first = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_search = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_Nouveau = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_Supprimer = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_Modifier = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_Ajouter = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Sc)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_numSc
            // 
            this.tb_numSc.Depth = 0;
            this.tb_numSc.Hint = "Numéro Seance";
            this.tb_numSc.Location = new System.Drawing.Point(216, 100);
            this.tb_numSc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_numSc.MaxLength = 32767;
            this.tb_numSc.MouseState = MaterialSkin.MouseState.HOVER;
            this.tb_numSc.Name = "tb_numSc";
            this.tb_numSc.PasswordChar = '\0';
            this.tb_numSc.SelectedText = "";
            this.tb_numSc.SelectionLength = 0;
            this.tb_numSc.SelectionStart = 0;
            this.tb_numSc.Size = new System.Drawing.Size(166, 23);
            this.tb_numSc.TabIndex = 106;
            this.tb_numSc.TabStop = false;
            this.tb_numSc.UseSystemPasswordChar = false;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(146, 188);
            this.materialLabel5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(101, 19);
            this.materialLabel5.TabIndex = 105;
            this.materialLabel5.Text = "Date Seance :";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(123, 78);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(124, 19);
            this.materialLabel1.TabIndex = 102;
            this.materialLabel1.Text = "Numéro Seance :";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(98, 133);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(150, 19);
            this.materialLabel2.TabIndex = 101;
            this.materialLabel2.Text = "Numéro Affectation :";
            // 
            // dgv_Sc
            // 
            this.dgv_Sc.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_Sc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Sc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Sc.GridColor = System.Drawing.Color.Maroon;
            this.dgv_Sc.Location = new System.Drawing.Point(64, 406);
            this.dgv_Sc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_Sc.Name = "dgv_Sc";
            this.dgv_Sc.RowTemplate.Height = 24;
            this.dgv_Sc.Size = new System.Drawing.Size(537, 231);
            this.dgv_Sc.TabIndex = 95;
            // 
            // tb_Search
            // 
            this.tb_Search.Depth = 0;
            this.tb_Search.Hint = "Search";
            this.tb_Search.Location = new System.Drawing.Point(458, 308);
            this.tb_Search.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_Search.MaxLength = 32767;
            this.tb_Search.MouseState = MaterialSkin.MouseState.HOVER;
            this.tb_Search.Name = "tb_Search";
            this.tb_Search.PasswordChar = '\0';
            this.tb_Search.SelectedText = "";
            this.tb_Search.SelectionLength = 0;
            this.tb_Search.SelectionStart = 0;
            this.tb_Search.Size = new System.Drawing.Size(144, 23);
            this.tb_Search.TabIndex = 89;
            this.tb_Search.TabStop = false;
            this.tb_Search.UseSystemPasswordChar = false;
            // 
            // dtp_date_Sc
            // 
            this.dtp_date_Sc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_date_Sc.Location = new System.Drawing.Point(216, 212);
            this.dtp_date_Sc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtp_date_Sc.Name = "dtp_date_Sc";
            this.dtp_date_Sc.Size = new System.Drawing.Size(168, 20);
            this.dtp_date_Sc.TabIndex = 88;
            // 
            // cmb_NumAff
            // 
            this.cmb_NumAff.FormattingEnabled = true;
            this.cmb_NumAff.Location = new System.Drawing.Point(216, 158);
            this.cmb_NumAff.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmb_NumAff.Name = "cmb_NumAff";
            this.cmb_NumAff.Size = new System.Drawing.Size(168, 21);
            this.cmb_NumAff.TabIndex = 85;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(312, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 84;
            this.label1.Text = "Seance";
            // 
            // tb_durée
            // 
            this.tb_durée.Depth = 0;
            this.tb_durée.Hint = "Durée";
            this.tb_durée.Location = new System.Drawing.Point(216, 265);
            this.tb_durée.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_durée.MaxLength = 32767;
            this.tb_durée.MouseState = MaterialSkin.MouseState.HOVER;
            this.tb_durée.Name = "tb_durée";
            this.tb_durée.PasswordChar = '\0';
            this.tb_durée.SelectedText = "";
            this.tb_durée.SelectionLength = 0;
            this.tb_durée.SelectionStart = 0;
            this.tb_durée.Size = new System.Drawing.Size(166, 23);
            this.tb_durée.TabIndex = 107;
            this.tb_durée.TabStop = false;
            this.tb_durée.UseSystemPasswordChar = false;
            // 
            // tb_salle
            // 
            this.tb_salle.Depth = 0;
            this.tb_salle.Hint = "Salle";
            this.tb_salle.Location = new System.Drawing.Point(216, 323);
            this.tb_salle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_salle.MaxLength = 32767;
            this.tb_salle.MouseState = MaterialSkin.MouseState.HOVER;
            this.tb_salle.Name = "tb_salle";
            this.tb_salle.PasswordChar = '\0';
            this.tb_salle.SelectedText = "";
            this.tb_salle.SelectionLength = 0;
            this.tb_salle.SelectionStart = 0;
            this.tb_salle.Size = new System.Drawing.Size(166, 23);
            this.tb_salle.TabIndex = 107;
            this.tb_salle.TabStop = false;
            this.tb_salle.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(188, 244);
            this.materialLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(56, 19);
            this.materialLabel3.TabIndex = 105;
            this.materialLabel3.Text = "Durée :";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(193, 299);
            this.materialLabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(50, 19);
            this.materialLabel4.TabIndex = 105;
            this.materialLabel4.Text = "Salle :";
            // 
            // last
            // 
            this.last.AutoSize = true;
            this.last.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.last.Depth = 0;
            this.last.Icon = null;
            this.last.Location = new System.Drawing.Point(374, 358);
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
            this.next.Location = new System.Drawing.Point(303, 358);
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
            this.previous.Location = new System.Drawing.Point(233, 358);
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
            this.first.Location = new System.Drawing.Point(167, 358);
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
            this.btn_search.Location = new System.Drawing.Point(498, 336);
            this.btn_search.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_search.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_search.Name = "btn_search";
            this.btn_search.Primary = true;
            this.btn_search.Size = new System.Drawing.Size(73, 36);
            this.btn_search.TabIndex = 168;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            // 
            // btn_Nouveau
            // 
            this.btn_Nouveau.AutoSize = true;
            this.btn_Nouveau.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Nouveau.Depth = 0;
            this.btn_Nouveau.Icon = null;
            this.btn_Nouveau.Location = new System.Drawing.Point(488, 141);
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
            this.btn_Supprimer.Location = new System.Drawing.Point(488, 263);
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
            this.btn_Modifier.Location = new System.Drawing.Point(488, 223);
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
            this.btn_Ajouter.Location = new System.Drawing.Point(488, 182);
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
            // F_Seance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 640);
            this.Controls.Add(this.last);
            this.Controls.Add(this.next);
            this.Controls.Add(this.previous);
            this.Controls.Add(this.first);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_Nouveau);
            this.Controls.Add(this.btn_Supprimer);
            this.Controls.Add(this.btn_Modifier);
            this.Controls.Add(this.btn_Ajouter);
            this.Controls.Add(this.tb_salle);
            this.Controls.Add(this.tb_durée);
            this.Controls.Add(this.tb_numSc);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.dgv_Sc);
            this.Controls.Add(this.tb_Search);
            this.Controls.Add(this.dtp_date_Sc);
            this.Controls.Add(this.cmb_NumAff);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "F_Seance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_Seance";
            this.Load += new System.EventHandler(this.F_Seance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Sc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField tb_numSc;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.DataGridView dgv_Sc;
        private MaterialSkin.Controls.MaterialSingleLineTextField tb_Search;
        private System.Windows.Forms.DateTimePicker dtp_date_Sc;
        private System.Windows.Forms.ComboBox cmb_NumAff;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialSingleLineTextField tb_durée;
        private MaterialSkin.Controls.MaterialSingleLineTextField tb_salle;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
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