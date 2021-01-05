
namespace DLWMS.WinForms.P13
{
    partial class frmPredavanje13
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
            this.btnGlavna = new System.Windows.Forms.Button();
            this.btnUloge = new System.Windows.Forms.Button();
            this.btnSetup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGlavna
            // 
            this.btnGlavna.Location = new System.Drawing.Point(12, 24);
            this.btnGlavna.Name = "btnGlavna";
            this.btnGlavna.Size = new System.Drawing.Size(339, 34);
            this.btnGlavna.TabIndex = 0;
            this.btnGlavna.Text = "Implementirana glavna forma (frmGlavna)";
            this.btnGlavna.UseVisualStyleBackColor = true;
            this.btnGlavna.Click += new System.EventHandler(this.btnGlavna_Click);
            // 
            // btnUloge
            // 
            this.btnUloge.Location = new System.Drawing.Point(12, 64);
            this.btnUloge.Name = "btnUloge";
            this.btnUloge.Size = new System.Drawing.Size(339, 34);
            this.btnUloge.TabIndex = 1;
            this.btnUloge.Text = "Omogućena dodjela uloga studentima (frmNoviStudent)";
            this.btnUloge.UseVisualStyleBackColor = true;
            this.btnUloge.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSetup
            // 
            this.btnSetup.Location = new System.Drawing.Point(12, 104);
            this.btnSetup.Name = "btnSetup";
            this.btnSetup.Size = new System.Drawing.Size(339, 34);
            this.btnSetup.TabIndex = 2;
            this.btnSetup.Text = "Dodat Setup projekat (DLWMS.Setup)";
            this.btnSetup.UseVisualStyleBackColor = true;
            // 
            // frmPredavanje13
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 149);
            this.Controls.Add(this.btnSetup);
            this.Controls.Add(this.btnUloge);
            this.Controls.Add(this.btnGlavna);
            this.Name = "frmPredavanje13";
            this.Text = "frmPredavanje13";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGlavna;
        private System.Windows.Forms.Button btnUloge;
        private System.Windows.Forms.Button btnSetup;
    }
}