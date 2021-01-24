
namespace DLWMS.WinForms.IspisIB150051
{
    partial class frmNovaPorukaIB150051
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
            this.components = new System.ComponentModel.Container();
            this.txtPrimalac = new System.Windows.Forms.TextBox();
            this.txtSadrzaj = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pbSlika = new System.Windows.Forms.PictureBox();
            this.btnSpasiPoruku = new System.Windows.Forms.Button();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPrimalac
            // 
            this.txtPrimalac.Location = new System.Drawing.Point(12, 35);
            this.txtPrimalac.Name = "txtPrimalac";
            this.txtPrimalac.ReadOnly = true;
            this.txtPrimalac.Size = new System.Drawing.Size(268, 20);
            this.txtPrimalac.TabIndex = 0;
            // 
            // txtSadrzaj
            // 
            this.txtSadrzaj.Location = new System.Drawing.Point(13, 76);
            this.txtSadrzaj.Multiline = true;
            this.txtSadrzaj.Name = "txtSadrzaj";
            this.txtSadrzaj.Size = new System.Drawing.Size(267, 193);
            this.txtSadrzaj.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Primalac:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sadržaj poruke:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(290, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Slika:";
            // 
            // pbSlika
            // 
            this.pbSlika.Location = new System.Drawing.Point(293, 35);
            this.pbSlika.Name = "pbSlika";
            this.pbSlika.Size = new System.Drawing.Size(262, 234);
            this.pbSlika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSlika.TabIndex = 5;
            this.pbSlika.TabStop = false;
            this.pbSlika.Click += new System.EventHandler(this.pbSlika_Click);
            // 
            // btnSpasiPoruku
            // 
            this.btnSpasiPoruku.Location = new System.Drawing.Point(480, 275);
            this.btnSpasiPoruku.Name = "btnSpasiPoruku";
            this.btnSpasiPoruku.Size = new System.Drawing.Size(75, 23);
            this.btnSpasiPoruku.TabIndex = 6;
            this.btnSpasiPoruku.Text = "Spasi";
            this.btnSpasiPoruku.UseVisualStyleBackColor = true;
            this.btnSpasiPoruku.Click += new System.EventHandler(this.btnSpasiPoruku_Click);
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmNovaPorukaIB150051
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 306);
            this.Controls.Add(this.btnSpasiPoruku);
            this.Controls.Add(this.pbSlika);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSadrzaj);
            this.Controls.Add(this.txtPrimalac);
            this.Name = "frmNovaPorukaIB150051";
            this.Text = "frmNovaPorukaIB150051";
            this.Load += new System.EventHandler(this.frmNovaPorukaIB150051_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPrimalac;
        private System.Windows.Forms.TextBox txtSadrzaj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbSlika;
        private System.Windows.Forms.Button btnSpasiPoruku;
        private System.Windows.Forms.ErrorProvider err;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}