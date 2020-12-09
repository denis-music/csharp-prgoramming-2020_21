
namespace DLWMS.WinForms.P10
{
    partial class frmSQLite
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
            this.dgvPrisustva = new System.Windows.Forms.DataGridView();
            this.btnDodajPrisustvo = new System.Windows.Forms.Button();
            this.btnStudenti = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrisustva)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPrisustva
            // 
            this.dgvPrisustva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrisustva.Location = new System.Drawing.Point(13, 63);
            this.dgvPrisustva.Name = "dgvPrisustva";
            this.dgvPrisustva.Size = new System.Drawing.Size(520, 231);
            this.dgvPrisustva.TabIndex = 0;
            // 
            // btnDodajPrisustvo
            // 
            this.btnDodajPrisustvo.Location = new System.Drawing.Point(437, 34);
            this.btnDodajPrisustvo.Name = "btnDodajPrisustvo";
            this.btnDodajPrisustvo.Size = new System.Drawing.Size(96, 23);
            this.btnDodajPrisustvo.TabIndex = 1;
            this.btnDodajPrisustvo.Text = "Dodaj prisustvo";
            this.btnDodajPrisustvo.UseVisualStyleBackColor = true;
            this.btnDodajPrisustvo.Click += new System.EventHandler(this.btnDodajPrisustvo_Click);
            // 
            // btnStudenti
            // 
            this.btnStudenti.Location = new System.Drawing.Point(437, 5);
            this.btnStudenti.Name = "btnStudenti";
            this.btnStudenti.Size = new System.Drawing.Size(96, 23);
            this.btnStudenti.TabIndex = 2;
            this.btnStudenti.Text = "Studenti";
            this.btnStudenti.UseVisualStyleBackColor = true;
            this.btnStudenti.Click += new System.EventHandler(this.btnStudenti_Click);
            // 
            // frmSQLite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 297);
            this.Controls.Add(this.btnStudenti);
            this.Controls.Add(this.btnDodajPrisustvo);
            this.Controls.Add(this.dgvPrisustva);
            this.Name = "frmSQLite";
            this.Text = "frmSQLite";
            this.Load += new System.EventHandler(this.frmSQLite_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrisustva)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPrisustva;
        private System.Windows.Forms.Button btnDodajPrisustvo;
        private System.Windows.Forms.Button btnStudenti;
    }
}