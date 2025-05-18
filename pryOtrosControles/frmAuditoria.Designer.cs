namespace pryOtrosControles
{
    partial class frmAuditoria
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
            this.pnlPanel = new System.Windows.Forms.Panel();
            this.lblShowTiempo = new System.Windows.Forms.Label();
            this.lblShowLugares = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblLugares = new System.Windows.Forms.Label();
            this.btnAuditar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnlPanel
            // 
            this.pnlPanel.Location = new System.Drawing.Point(22, 26);
            this.pnlPanel.Name = "pnlPanel";
            this.pnlPanel.Size = new System.Drawing.Size(543, 322);
            this.pnlPanel.TabIndex = 0;
            // 
            // lblShowTiempo
            // 
            this.lblShowTiempo.AutoSize = true;
            this.lblShowTiempo.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowTiempo.Location = new System.Drawing.Point(19, 374);
            this.lblShowTiempo.Name = "lblShowTiempo";
            this.lblShowTiempo.Size = new System.Drawing.Size(107, 16);
            this.lblShowTiempo.TabIndex = 0;
            this.lblShowTiempo.Text = "Tiempo de Trabajo:";
            // 
            // lblShowLugares
            // 
            this.lblShowLugares.AutoSize = true;
            this.lblShowLugares.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowLugares.Location = new System.Drawing.Point(19, 406);
            this.lblShowLugares.Name = "lblShowLugares";
            this.lblShowLugares.Size = new System.Drawing.Size(51, 16);
            this.lblShowLugares.TabIndex = 1;
            this.lblShowLugares.Text = "Lugares:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(133, 374);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(12, 16);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "-";
            // 
            // lblLugares
            // 
            this.lblLugares.AutoSize = true;
            this.lblLugares.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLugares.Location = new System.Drawing.Point(133, 406);
            this.lblLugares.Name = "lblLugares";
            this.lblLugares.Size = new System.Drawing.Size(12, 16);
            this.lblLugares.TabIndex = 3;
            this.lblLugares.Text = "-";
            // 
            // btnAuditar
            // 
            this.btnAuditar.Location = new System.Drawing.Point(437, 383);
            this.btnAuditar.Name = "btnAuditar";
            this.btnAuditar.Size = new System.Drawing.Size(128, 39);
            this.btnAuditar.TabIndex = 4;
            this.btnAuditar.Text = "Auditar";
            this.btnAuditar.UseVisualStyleBackColor = true;
            // 
            // frmAuditoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 450);
            this.Controls.Add(this.btnAuditar);
            this.Controls.Add(this.lblLugares);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblShowLugares);
            this.Controls.Add(this.lblShowTiempo);
            this.Controls.Add(this.pnlPanel);
            this.Name = "frmAuditoria";
            this.Text = "frmAuditoria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlPanel;
        private System.Windows.Forms.Label lblShowTiempo;
        private System.Windows.Forms.Label lblShowLugares;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblLugares;
        private System.Windows.Forms.Button btnAuditar;
    }
}