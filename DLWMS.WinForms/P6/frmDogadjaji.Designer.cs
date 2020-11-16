
namespace DLWMS.WinForms.P6
{
    partial class frmDogadjaji
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
            this.btn4GNedostupna = new System.Windows.Forms.Button();
            this.txtPoruka = new System.Windows.Forms.TextBox();
            this.cbBHTelcom = new System.Windows.Forms.CheckBox();
            this.cbHTEronet = new System.Windows.Forms.CheckBox();
            this.cbMTel = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPosalji = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPozovi = new System.Windows.Forms.Button();
            this.btnYield = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn4GNedostupna
            // 
            this.btn4GNedostupna.Location = new System.Drawing.Point(12, 85);
            this.btn4GNedostupna.Name = "btn4GNedostupna";
            this.btn4GNedostupna.Size = new System.Drawing.Size(103, 23);
            this.btn4GNedostupna.TabIndex = 0;
            this.btn4GNedostupna.Text = "4G nedostupna";
            this.btn4GNedostupna.UseVisualStyleBackColor = true;
            this.btn4GNedostupna.Click += new System.EventHandler(this.btn4GNedostupna_Click);
            // 
            // txtPoruka
            // 
            this.txtPoruka.Location = new System.Drawing.Point(160, 14);
            this.txtPoruka.Multiline = true;
            this.txtPoruka.Name = "txtPoruka";
            this.txtPoruka.Size = new System.Drawing.Size(261, 94);
            this.txtPoruka.TabIndex = 1;
            this.txtPoruka.TextChanged += new System.EventHandler(this.txtPoruka_TextChanged);
            // 
            // cbBHTelcom
            // 
            this.cbBHTelcom.AutoSize = true;
            this.cbBHTelcom.Location = new System.Drawing.Point(160, 114);
            this.cbBHTelcom.Name = "cbBHTelcom";
            this.cbBHTelcom.Size = new System.Drawing.Size(76, 17);
            this.cbBHTelcom.TabIndex = 2;
            this.cbBHTelcom.Text = "BHTelcom";
            this.cbBHTelcom.UseVisualStyleBackColor = true;
            this.cbBHTelcom.CheckedChanged += new System.EventHandler(this.cbBHTelcom_CheckedChanged);
            // 
            // cbHTEronet
            // 
            this.cbHTEronet.AutoSize = true;
            this.cbHTEronet.Location = new System.Drawing.Point(242, 114);
            this.cbHTEronet.Name = "cbHTEronet";
            this.cbHTEronet.Size = new System.Drawing.Size(72, 17);
            this.cbHTEronet.TabIndex = 3;
            this.cbHTEronet.Text = "HTEronet";
            this.cbHTEronet.UseVisualStyleBackColor = true;
            this.cbHTEronet.CheckedChanged += new System.EventHandler(this.cbHTEronet_CheckedChanged);
            // 
            // cbMTel
            // 
            this.cbMTel.AutoSize = true;
            this.cbMTel.Location = new System.Drawing.Point(320, 114);
            this.cbMTel.Name = "cbMTel";
            this.cbMTel.Size = new System.Drawing.Size(50, 17);
            this.cbMTel.TabIndex = 4;
            this.cbMTel.Text = "MTel";
            this.cbMTel.UseVisualStyleBackColor = true;
            this.cbMTel.CheckedChanged += new System.EventHandler(this.cbMTel_CheckedChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(136, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1, 150);
            this.label1.TabIndex = 5;
            // 
            // btnPosalji
            // 
            this.btnPosalji.Location = new System.Drawing.Point(356, 139);
            this.btnPosalji.Name = "btnPosalji";
            this.btnPosalji.Size = new System.Drawing.Size(65, 23);
            this.btnPosalji.TabIndex = 6;
            this.btnPosalji.Text = "Posalji";
            this.btnPosalji.UseVisualStyleBackColor = true;
            this.btnPosalji.Click += new System.EventHandler(this.btnPosalji_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(443, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1, 150);
            this.label2.TabIndex = 7;
            // 
            // btnPozovi
            // 
            this.btnPozovi.Location = new System.Drawing.Point(487, 44);
            this.btnPozovi.Name = "btnPozovi";
            this.btnPozovi.Size = new System.Drawing.Size(109, 23);
            this.btnPozovi.TabIndex = 8;
            this.btnPozovi.Text = "Pozovi";
            this.btnPozovi.UseVisualStyleBackColor = true;
            this.btnPozovi.Click += new System.EventHandler(this.btnPozovi_Click);
            // 
            // btnYield
            // 
            this.btnYield.Location = new System.Drawing.Point(487, 108);
            this.btnYield.Name = "btnYield";
            this.btnYield.Size = new System.Drawing.Size(109, 23);
            this.btnYield.TabIndex = 9;
            this.btnYield.Text = "Yield";
            this.btnYield.UseVisualStyleBackColor = true;
            this.btnYield.Click += new System.EventHandler(this.btnYield_Click);
            // 
            // frmDogadjaji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 171);
            this.Controls.Add(this.btnYield);
            this.Controls.Add(this.btnPozovi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPosalji);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbMTel);
            this.Controls.Add(this.cbHTEronet);
            this.Controls.Add(this.cbBHTelcom);
            this.Controls.Add(this.txtPoruka);
            this.Controls.Add(this.btn4GNedostupna);
            this.Name = "frmDogadjaji";
            this.Text = "frmDogadjaji";
            this.Load += new System.EventHandler(this.FormaUcitana);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn4GNedostupna;
        private System.Windows.Forms.TextBox txtPoruka;
        private System.Windows.Forms.CheckBox cbBHTelcom;
        private System.Windows.Forms.CheckBox cbHTEronet;
        private System.Windows.Forms.CheckBox cbMTel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPosalji;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPozovi;
        private System.Windows.Forms.Button btnYield;
    }
}