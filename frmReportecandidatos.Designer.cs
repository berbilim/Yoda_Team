
namespace proyecto
{
    partial class frmReportecandidatos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportecandidatos));
            this.btnReportecandidatos = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btninicio = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReportecandidatos
            // 
            this.btnReportecandidatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportecandidatos.Location = new System.Drawing.Point(46, 165);
            this.btnReportecandidatos.Name = "btnReportecandidatos";
            this.btnReportecandidatos.Size = new System.Drawing.Size(108, 44);
            this.btnReportecandidatos.TabIndex = 0;
            this.btnReportecandidatos.Text = "Generar Reporte";
            this.btnReportecandidatos.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::proyecto.Properties.Resources.grafico2;
            this.pictureBox1.Location = new System.Drawing.Point(359, 98);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(322, 351);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btninicio
            // 
            this.btninicio.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btninicio.Image = ((System.Drawing.Image)(resources.GetObject("btninicio.Image")));
            this.btninicio.Location = new System.Drawing.Point(12, 24);
            this.btninicio.Name = "btninicio";
            this.btninicio.Size = new System.Drawing.Size(62, 54);
            this.btninicio.TabIndex = 6;
            this.btninicio.UseVisualStyleBackColor = false;
            this.btninicio.Click += new System.EventHandler(this.btninicio_Click);
            // 
            // frmReportecandidatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(840, 549);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btninicio);
            this.Controls.Add(this.btnReportecandidatos);
            this.Name = "frmReportecandidatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de Candidatos";
            this.Load += new System.EventHandler(this.frmReportecandidatos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReportecandidatos;
        private System.Windows.Forms.Button btninicio;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}