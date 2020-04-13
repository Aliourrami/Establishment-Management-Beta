using Establishment_Management.Imprimer;

namespace Establishment_Management
{
    partial class F_Imprimer
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
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1_attestation = new System.Windows.Forms.TabPage();
            this.Btn_Stg = new System.Windows.Forms.Button();
            this.cbx_stagaire = new System.Windows.Forms.ComboBox();
            this.crystalReportViewer4 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.AttestationStagaire1 = new Establishment_Management.Imprimer.AttestationStagaire();
            this.tabPage2_Absence = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.cmb_stagaire = new System.Windows.Forms.ComboBox();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.AbsenceStagaire1 = new Establishment_Management.Imprimer.AbsenceStagaire();
            this.tabPage3_efm_plan = new System.Windows.Forms.TabPage();
            this.crystalReportViewer3 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.EFM_Plan2 = new Establishment_Management.Imprimer.EFM_Plan();
            this.EFM_Plan1 = new Establishment_Management.Imprimer.EFM_Plan();
            this.EFM_Plan3 = new Establishment_Management.Imprimer.EFM_Plan();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1_attestation.SuspendLayout();
            this.tabPage2_Absence.SuspendLayout();
            this.tabPage3_efm_plan.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(-1, 64);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(1066, 34);
            this.materialTabSelector1.TabIndex = 0;
            this.materialTabSelector1.Text = "materialTabSelector1";
            this.materialTabSelector1.Click += new System.EventHandler(this.materialTabSelector1_Click);
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.materialTabControl1.Controls.Add(this.tabPage1_attestation);
            this.materialTabControl1.Controls.Add(this.tabPage2_Absence);
            this.materialTabControl1.Controls.Add(this.tabPage3_efm_plan);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialTabControl1.Location = new System.Drawing.Point(-1, 99);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1066, 824);
            this.materialTabControl1.TabIndex = 1;
            // 
            // tabPage1_attestation
            // 
            this.tabPage1_attestation.Controls.Add(this.Btn_Stg);
            this.tabPage1_attestation.Controls.Add(this.cbx_stagaire);
            this.tabPage1_attestation.Controls.Add(this.crystalReportViewer4);
            this.tabPage1_attestation.Location = new System.Drawing.Point(4, 4);
            this.tabPage1_attestation.Name = "tabPage1_attestation";
            this.tabPage1_attestation.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1_attestation.Size = new System.Drawing.Size(1058, 778);
            this.tabPage1_attestation.TabIndex = 0;
            this.tabPage1_attestation.Text = "Attestation";
            this.tabPage1_attestation.UseVisualStyleBackColor = true;
            this.tabPage1_attestation.Click += new System.EventHandler(this.tabPage1_attestation_Click);
            this.tabPage1_attestation.Enter += new System.EventHandler(this.tabPage1_attestation_Enter);
            // 
            // Btn_Stg
            // 
            this.Btn_Stg.BackColor = System.Drawing.SystemColors.Info;
            this.Btn_Stg.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Stg.Location = new System.Drawing.Point(847, 6);
            this.Btn_Stg.Name = "Btn_Stg";
            this.Btn_Stg.Size = new System.Drawing.Size(215, 39);
            this.Btn_Stg.TabIndex = 7;
            this.Btn_Stg.Text = "Afficher Le Stagaire";
            this.Btn_Stg.UseVisualStyleBackColor = false;
            this.Btn_Stg.Click += new System.EventHandler(this.Btn_Stg_Click);
            // 
            // cbx_stagaire
            // 
            this.cbx_stagaire.FormattingEnabled = true;
            this.cbx_stagaire.Location = new System.Drawing.Point(648, 6);
            this.cbx_stagaire.Name = "cbx_stagaire";
            this.cbx_stagaire.Size = new System.Drawing.Size(178, 41);
            this.cbx_stagaire.TabIndex = 6;
            // 
            // crystalReportViewer4
            // 
            this.crystalReportViewer4.ActiveViewIndex = 0;
            this.crystalReportViewer4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer4.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer4.DisplayStatusBar = false;
            this.crystalReportViewer4.Location = new System.Drawing.Point(-4, 0);
            this.crystalReportViewer4.Name = "crystalReportViewer4";
            this.crystalReportViewer4.ReportSource = this.AttestationStagaire1;
            this.crystalReportViewer4.Size = new System.Drawing.Size(1066, 770);
            this.crystalReportViewer4.TabIndex = 5;
            this.crystalReportViewer4.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crystalReportViewer4.Load += new System.EventHandler(this.crystalReportViewer4_Load);
            // 
            // tabPage2_Absence
            // 
            this.tabPage2_Absence.Controls.Add(this.button1);
            this.tabPage2_Absence.Controls.Add(this.cmb_stagaire);
            this.tabPage2_Absence.Controls.Add(this.crystalReportViewer1);
            this.tabPage2_Absence.Location = new System.Drawing.Point(4, 4);
            this.tabPage2_Absence.Name = "tabPage2_Absence";
            this.tabPage2_Absence.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2_Absence.Size = new System.Drawing.Size(1058, 778);
            this.tabPage2_Absence.TabIndex = 1;
            this.tabPage2_Absence.Text = "Absence";
            this.tabPage2_Absence.UseVisualStyleBackColor = true;
            this.tabPage2_Absence.Click += new System.EventHandler(this.tabPage2_Absence_Click);
            this.tabPage2_Absence.Enter += new System.EventHandler(this.tabPage2_Absence_Enter);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Info;
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(832, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(219, 48);
            this.button1.TabIndex = 5;
            this.button1.Text = "Afficher Le Stagaire";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmb_stagaire
            // 
            this.cmb_stagaire.FormattingEnabled = true;
            this.cmb_stagaire.Location = new System.Drawing.Point(579, 14);
            this.cmb_stagaire.Name = "cmb_stagaire";
            this.cmb_stagaire.Size = new System.Drawing.Size(215, 41);
            this.cmb_stagaire.TabIndex = 4;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.DisplayStatusBar = false;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 1);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.AbsenceStagaire1;
            this.crystalReportViewer1.Size = new System.Drawing.Size(1058, 777);
            this.crystalReportViewer1.TabIndex = 3;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // tabPage3_efm_plan
            // 
            this.tabPage3_efm_plan.Controls.Add(this.crystalReportViewer3);
            this.tabPage3_efm_plan.Location = new System.Drawing.Point(4, 4);
            this.tabPage3_efm_plan.Name = "tabPage3_efm_plan";
            this.tabPage3_efm_plan.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3_efm_plan.Size = new System.Drawing.Size(1058, 778);
            this.tabPage3_efm_plan.TabIndex = 2;
            this.tabPage3_efm_plan.Text = "EFM Planification";
            this.tabPage3_efm_plan.UseVisualStyleBackColor = true;
            this.tabPage3_efm_plan.Click += new System.EventHandler(this.tabPage3_efm_plan_Click);
            // 
            // crystalReportViewer3
            // 
            this.crystalReportViewer3.ActiveViewIndex = 0;
            this.crystalReportViewer3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer3.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer3.DisplayStatusBar = false;
            this.crystalReportViewer3.Location = new System.Drawing.Point(3, 2);
            this.crystalReportViewer3.Name = "crystalReportViewer3";
            this.crystalReportViewer3.ReportSource = this.EFM_Plan3;
            this.crystalReportViewer3.Size = new System.Drawing.Size(1049, 773);
            this.crystalReportViewer3.TabIndex = 1;
            this.crystalReportViewer3.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // EFM_Plan2
            // 
            this.EFM_Plan2.FileName = "rassdk://C:\\Users\\jayda\\AppData\\Local\\Temp\\temp_765e521d-3c73-4013-86bb-dc59718f9" +
    "8a3.rpt";
            // 
            // EFM_Plan1
            // 
            this.EFM_Plan1.FileName = "rassdk://C:\\Users\\jayda\\AppData\\Local\\Temp\\temp_79ebc97a-cccc-403e-bb62-8897c0129" +
    "0c3.rpt";
            // 
            // F_Imprimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 924);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.materialTabSelector1);
            this.Name = "F_Imprimer";
            this.Text = "Imprimer";
            this.Load += new System.EventHandler(this.Imprimer_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1_attestation.ResumeLayout(false);
            this.tabPage2_Absence.ResumeLayout(false);
            this.tabPage3_efm_plan.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1_attestation;
        private System.Windows.Forms.TabPage tabPage2_Absence;
        private System.Windows.Forms.TabPage tabPage3_efm_plan;
        private System.Windows.Forms.ComboBox cbx_stagaire;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer4;
        private System.Windows.Forms.Button Btn_Stg;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmb_stagaire;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer3;
        private EFM_Plan EFM_Plan1;
        //private Absence Absence1;
        //private Absence Absence2;
        private EFM_Plan EFM_Plan2;
        private AttestationStagaire AttestationStagaire1;
        private AbsenceStagaire AbsenceStagaire1;
        private EFM_Plan EFM_Plan3;
    }
}