
namespace DLWMS.WinForms.P4
{
    partial class frmIgraci
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
            this.btnPokreni = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrviIgrac = new System.Windows.Forms.TextBox();
            this.txtDrugiIgrac = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnPokreni
            // 
            this.btnPokreni.Location = new System.Drawing.Point(209, 89);
            this.btnPokreni.Name = "btnPokreni";
            this.btnPokreni.Size = new System.Drawing.Size(75, 23);
            this.btnPokreni.TabIndex = 2;
            this.btnPokreni.Text = "Pokreni";
            this.btnPokreni.UseVisualStyleBackColor = true;
            this.btnPokreni.Click += new System.EventHandler(this.btnPokreni_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Prvi igrač:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Drugi igrač:";
            // 
            // txtPrviIgrac
            // 
            this.txtPrviIgrac.Location = new System.Drawing.Point(95, 25);
            this.txtPrviIgrac.Name = "txtPrviIgrac";
            this.txtPrviIgrac.Size = new System.Drawing.Size(189, 20);
            this.txtPrviIgrac.TabIndex = 0;
            this.txtPrviIgrac.Text = "Denis";
            // 
            // txtDrugiIgrac
            // 
            this.txtDrugiIgrac.Location = new System.Drawing.Point(95, 59);
            this.txtDrugiIgrac.Name = "txtDrugiIgrac";
            this.txtDrugiIgrac.Size = new System.Drawing.Size(189, 20);
            this.txtDrugiIgrac.TabIndex = 1;
            this.txtDrugiIgrac.Text = "Jasmin";
            // 
            // frmIgraci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 121);
            this.Controls.Add(this.txtDrugiIgrac);
            this.Controls.Add(this.txtPrviIgrac);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPokreni);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmIgraci";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Igrači";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPokreni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrviIgrac;
        private System.Windows.Forms.TextBox txtDrugiIgrac;
    }
}