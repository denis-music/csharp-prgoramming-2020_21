
namespace DLWMS.WinForms.IspisIB150051
{
    partial class frmPorukeIB150051
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
            this.lblStudent = new System.Windows.Forms.Label();
            this.dgvPoruke = new System.Windows.Forms.DataGridView();
            this.btnNovaPoruka = new System.Windows.Forms.Button();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sadrzaj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Slika = new System.Windows.Forms.DataGridViewImageColumn();
            this.Brisi = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnPrinaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoruke)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Komunikacija sa:";
            // 
            // lblStudent
            // 
            this.lblStudent.AutoSize = true;
            this.lblStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudent.Location = new System.Drawing.Point(105, 12);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(0, 25);
            this.lblStudent.TabIndex = 1;
            // 
            // dgvPoruke
            // 
            this.dgvPoruke.AllowUserToAddRows = false;
            this.dgvPoruke.AllowUserToDeleteRows = false;
            this.dgvPoruke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPoruke.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Datum,
            this.Sadrzaj,
            this.Slika,
            this.Brisi});
            this.dgvPoruke.Location = new System.Drawing.Point(15, 41);
            this.dgvPoruke.Name = "dgvPoruke";
            this.dgvPoruke.ReadOnly = true;
            this.dgvPoruke.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPoruke.Size = new System.Drawing.Size(587, 150);
            this.dgvPoruke.TabIndex = 2;
            this.dgvPoruke.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPoruke_CellContentClick);
            // 
            // btnNovaPoruka
            // 
            this.btnNovaPoruka.Location = new System.Drawing.Point(498, 12);
            this.btnNovaPoruka.Name = "btnNovaPoruka";
            this.btnNovaPoruka.Size = new System.Drawing.Size(109, 23);
            this.btnNovaPoruka.TabIndex = 3;
            this.btnNovaPoruka.Text = "Nova poruka";
            this.btnNovaPoruka.UseVisualStyleBackColor = true;
            this.btnNovaPoruka.Click += new System.EventHandler(this.btnNovaPoruka_Click);
            // 
            // Datum
            // 
            this.Datum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Datum.DataPropertyName = "DatumVrijeme";
            this.Datum.HeaderText = "Datum";
            this.Datum.Name = "Datum";
            this.Datum.ReadOnly = true;
            this.Datum.Width = 172;
            // 
            // Sadrzaj
            // 
            this.Sadrzaj.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Sadrzaj.DataPropertyName = "Poruka";
            this.Sadrzaj.HeaderText = "Sadrzaj";
            this.Sadrzaj.Name = "Sadrzaj";
            this.Sadrzaj.ReadOnly = true;
            // 
            // Slika
            // 
            this.Slika.DataPropertyName = "Slika";
            this.Slika.HeaderText = "Slika";
            this.Slika.Name = "Slika";
            this.Slika.ReadOnly = true;
            this.Slika.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Slika.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Brisi
            // 
            this.Brisi.HeaderText = "Brisi";
            this.Brisi.Name = "Brisi";
            this.Brisi.ReadOnly = true;
            this.Brisi.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Brisi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Brisi.Text = "Brisi";
            this.Brisi.UseColumnTextForButtonValue = true;
            // 
            // btnPrinaj
            // 
            this.btnPrinaj.Location = new System.Drawing.Point(493, 203);
            this.btnPrinaj.Name = "btnPrinaj";
            this.btnPrinaj.Size = new System.Drawing.Size(109, 23);
            this.btnPrinaj.TabIndex = 4;
            this.btnPrinaj.Text = "Printaj";
            this.btnPrinaj.UseVisualStyleBackColor = true;
            this.btnPrinaj.Click += new System.EventHandler(this.btnPrinaj_Click);
            // 
            // frmPorukeIB150051
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 238);
            this.Controls.Add(this.btnPrinaj);
            this.Controls.Add(this.btnNovaPoruka);
            this.Controls.Add(this.dgvPoruke);
            this.Controls.Add(this.lblStudent);
            this.Controls.Add(this.label1);
            this.Name = "frmPorukeIB150051";
            this.Text = "frmPorukeIB150051";
            this.Load += new System.EventHandler(this.frmPorukeIB150051_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoruke)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.DataGridView dgvPoruke;
        private System.Windows.Forms.Button btnNovaPoruka;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sadrzaj;
        private System.Windows.Forms.DataGridViewImageColumn Slika;
        private System.Windows.Forms.DataGridViewButtonColumn Brisi;
        private System.Windows.Forms.Button btnPrinaj;
    }
}