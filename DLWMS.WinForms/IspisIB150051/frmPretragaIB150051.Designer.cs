
namespace DLWMS.WinForms.IspisIB150051
{
    partial class frmPretragaIB150051
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
            this.txtNazivPredmeta = new System.Windows.Forms.TextBox();
            this.dgvPolozeniPredmeti = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.lblProsjek = new System.Windows.Forms.Label();
            this.Student = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Predmet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ocjena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Poruke = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtN = new System.Windows.Forms.TextBox();
            this.btnSumiraj = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSuma = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolozeniPredmeti)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv predmeta:";
            // 
            // txtNazivPredmeta
            // 
            this.txtNazivPredmeta.Location = new System.Drawing.Point(102, 21);
            this.txtNazivPredmeta.Name = "txtNazivPredmeta";
            this.txtNazivPredmeta.Size = new System.Drawing.Size(577, 20);
            this.txtNazivPredmeta.TabIndex = 1;
            this.txtNazivPredmeta.TextChanged += new System.EventHandler(this.txtNazivPredmeta_TextChanged);
            // 
            // dgvPolozeniPredmeti
            // 
            this.dgvPolozeniPredmeti.AllowUserToAddRows = false;
            this.dgvPolozeniPredmeti.AllowUserToDeleteRows = false;
            this.dgvPolozeniPredmeti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPolozeniPredmeti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Student,
            this.Predmet,
            this.Ocjena,
            this.Datum,
            this.Poruke});
            this.dgvPolozeniPredmeti.Location = new System.Drawing.Point(15, 45);
            this.dgvPolozeniPredmeti.Name = "dgvPolozeniPredmeti";
            this.dgvPolozeniPredmeti.ReadOnly = true;
            this.dgvPolozeniPredmeti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPolozeniPredmeti.Size = new System.Drawing.Size(664, 237);
            this.dgvPolozeniPredmeti.TabIndex = 2;
            this.dgvPolozeniPredmeti.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPolozeniPredmeti_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prosjek prikazanih ocjena:";
            // 
            // lblProsjek
            // 
            this.lblProsjek.Location = new System.Drawing.Point(149, 297);
            this.lblProsjek.Name = "lblProsjek";
            this.lblProsjek.Size = new System.Drawing.Size(46, 13);
            this.lblProsjek.TabIndex = 4;
            // 
            // Student
            // 
            this.Student.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Student.DataPropertyName = "Student";
            this.Student.HeaderText = "Student";
            this.Student.Name = "Student";
            this.Student.ReadOnly = true;
            // 
            // Predmet
            // 
            this.Predmet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Predmet.DataPropertyName = "Predmet";
            this.Predmet.HeaderText = "Predmet";
            this.Predmet.Name = "Predmet";
            this.Predmet.ReadOnly = true;
            // 
            // Ocjena
            // 
            this.Ocjena.DataPropertyName = "Ocjena";
            this.Ocjena.HeaderText = "Ocjena";
            this.Ocjena.Name = "Ocjena";
            this.Ocjena.ReadOnly = true;
            // 
            // Datum
            // 
            this.Datum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Datum.DataPropertyName = "Datum";
            this.Datum.HeaderText = "Datum";
            this.Datum.Name = "Datum";
            this.Datum.ReadOnly = true;
            // 
            // Poruke
            // 
            this.Poruke.HeaderText = "Poruke";
            this.Poruke.Name = "Poruke";
            this.Poruke.ReadOnly = true;
            this.Poruke.Text = "Poruke";
            this.Poruke.UseColumnTextForButtonValue = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSuma);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnSumiraj);
            this.groupBox1.Controls.Add(this.txtN);
            this.groupBox1.Location = new System.Drawing.Point(381, 297);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 131);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Threading";
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(23, 35);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(161, 20);
            this.txtN.TabIndex = 0;
            this.txtN.Text = "968455668";
            // 
            // btnSumiraj
            // 
            this.btnSumiraj.Location = new System.Drawing.Point(202, 33);
            this.btnSumiraj.Name = "btnSumiraj";
            this.btnSumiraj.Size = new System.Drawing.Size(75, 23);
            this.btnSumiraj.TabIndex = 1;
            this.btnSumiraj.Text = "Sumiraj";
            this.btnSumiraj.UseVisualStyleBackColor = true;
            this.btnSumiraj.Click += new System.EventHandler(this.btnSumiraj_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Suma:";
            // 
            // lblSuma
            // 
            this.lblSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuma.Location = new System.Drawing.Point(20, 98);
            this.lblSuma.Name = "lblSuma";
            this.lblSuma.Size = new System.Drawing.Size(257, 20);
            this.lblSuma.TabIndex = 3;
            // 
            // frmPretragaIB150051
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 440);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblProsjek);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvPolozeniPredmeti);
            this.Controls.Add(this.txtNazivPredmeta);
            this.Controls.Add(this.label1);
            this.Name = "frmPretragaIB150051";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPretragaIB150051";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolozeniPredmeti)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNazivPredmeta;
        private System.Windows.Forms.DataGridView dgvPolozeniPredmeti;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblProsjek;
        private System.Windows.Forms.DataGridViewTextBoxColumn Student;
        private System.Windows.Forms.DataGridViewTextBoxColumn Predmet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ocjena;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewButtonColumn Poruke;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblSuma;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSumiraj;
        private System.Windows.Forms.TextBox txtN;
    }
}