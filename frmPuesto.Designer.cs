
namespace proyecto
{
    partial class frmPuesto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPuesto));
            this.lblCodugopuesto = new System.Windows.Forms.Label();
            this.lblDescripcionpuesto = new System.Windows.Forms.Label();
            this.txtCodigopuesto = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.grbModpuesto = new System.Windows.Forms.GroupBox();
            this.btninicio = new System.Windows.Forms.Button();
            this.btnGuardarpusto = new System.Windows.Forms.Button();
            this.grbModpuesto.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCodugopuesto
            // 
            this.lblCodugopuesto.AutoSize = true;
            this.lblCodugopuesto.Location = new System.Drawing.Point(27, 40);
            this.lblCodugopuesto.Name = "lblCodugopuesto";
            this.lblCodugopuesto.Size = new System.Drawing.Size(145, 20);
            this.lblCodugopuesto.TabIndex = 0;
            this.lblCodugopuesto.Text = "Código del partido :";
            // 
            // lblDescripcionpuesto
            // 
            this.lblDescripcionpuesto.AutoSize = true;
            this.lblDescripcionpuesto.Location = new System.Drawing.Point(27, 142);
            this.lblDescripcionpuesto.Name = "lblDescripcionpuesto";
            this.lblDescripcionpuesto.Size = new System.Drawing.Size(100, 20);
            this.lblDescripcionpuesto.TabIndex = 1;
            this.lblDescripcionpuesto.Text = "Descripción :";
            // 
            // txtCodigopuesto
            // 
            this.txtCodigopuesto.Location = new System.Drawing.Point(224, 40);
            this.txtCodigopuesto.Name = "txtCodigopuesto";
            this.txtCodigopuesto.Size = new System.Drawing.Size(100, 26);
            this.txtCodigopuesto.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(224, 139);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(397, 169);
            this.textBox2.TabIndex = 3;
            // 
            // grbModpuesto
            // 
            this.grbModpuesto.Controls.Add(this.lblCodugopuesto);
            this.grbModpuesto.Controls.Add(this.textBox2);
            this.grbModpuesto.Controls.Add(this.txtCodigopuesto);
            this.grbModpuesto.Controls.Add(this.lblDescripcionpuesto);
            this.grbModpuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbModpuesto.Location = new System.Drawing.Point(142, 82);
            this.grbModpuesto.Name = "grbModpuesto";
            this.grbModpuesto.Size = new System.Drawing.Size(707, 358);
            this.grbModpuesto.TabIndex = 4;
            this.grbModpuesto.TabStop = false;
            this.grbModpuesto.Text = "Datos del puesto :";
            // 
            // btninicio
            // 
            this.btninicio.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btninicio.Image = ((System.Drawing.Image)(resources.GetObject("btninicio.Image")));
            this.btninicio.Location = new System.Drawing.Point(32, 22);
            this.btninicio.Name = "btninicio";
            this.btninicio.Size = new System.Drawing.Size(62, 54);
            this.btninicio.TabIndex = 7;
            this.btninicio.UseVisualStyleBackColor = false;
            this.btninicio.Click += new System.EventHandler(this.btninicio_Click);
            // 
            // btnGuardarpusto
            // 
            this.btnGuardarpusto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarpusto.Location = new System.Drawing.Point(425, 477);
            this.btnGuardarpusto.Name = "btnGuardarpusto";
            this.btnGuardarpusto.Size = new System.Drawing.Size(131, 53);
            this.btnGuardarpusto.TabIndex = 8;
            this.btnGuardarpusto.Text = "Gardar Datos";
            this.btnGuardarpusto.UseVisualStyleBackColor = true;
            // 
            // frmPuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(971, 584);
            this.Controls.Add(this.btnGuardarpusto);
            this.Controls.Add(this.btninicio);
            this.Controls.Add(this.grbModpuesto);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Name = "frmPuesto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificacion Puesto";
            this.Load += new System.EventHandler(this.frmPuesto_Load);
            this.grbModpuesto.ResumeLayout(false);
            this.grbModpuesto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCodugopuesto;
        private System.Windows.Forms.Label lblDescripcionpuesto;
        private System.Windows.Forms.TextBox txtCodigopuesto;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox grbModpuesto;
        private System.Windows.Forms.Button btninicio;
        private System.Windows.Forms.Button btnGuardarpusto;
    }
}