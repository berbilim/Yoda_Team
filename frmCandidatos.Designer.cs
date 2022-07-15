
namespace proyecto
{
    partial class frmCandidatos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCandidatos));
            this.lblcodigocandidato = new System.Windows.Forms.Label();
            this.lblCedulacandidato = new System.Windows.Forms.Label();
            this.lblCodigopartidopolitico = new System.Windows.Forms.Label();
            this.lblTipodepuesto = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.grbCandidatos = new System.Windows.Forms.GroupBox();
            this.btnGuardarcatalogocandidato = new System.Windows.Forms.Button();
            this.btninicio = new System.Windows.Forms.Button();
            this.grbCandidatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblcodigocandidato
            // 
            this.lblcodigocandidato.AutoSize = true;
            this.lblcodigocandidato.Location = new System.Drawing.Point(17, 74);
            this.lblcodigocandidato.Name = "lblcodigocandidato";
            this.lblcodigocandidato.Size = new System.Drawing.Size(163, 20);
            this.lblcodigocandidato.TabIndex = 0;
            this.lblcodigocandidato.Text = "Código de candidato :";
            // 
            // lblCedulacandidato
            // 
            this.lblCedulacandidato.AutoSize = true;
            this.lblCedulacandidato.Location = new System.Drawing.Point(17, 125);
            this.lblCedulacandidato.Name = "lblCedulacandidato";
            this.lblCedulacandidato.Size = new System.Drawing.Size(67, 20);
            this.lblCedulacandidato.TabIndex = 1;
            this.lblCedulacandidato.Text = "Cédula :";
            // 
            // lblCodigopartidopolitico
            // 
            this.lblCodigopartidopolitico.AutoSize = true;
            this.lblCodigopartidopolitico.Location = new System.Drawing.Point(17, 178);
            this.lblCodigopartidopolitico.Name = "lblCodigopartidopolitico";
            this.lblCodigopartidopolitico.Size = new System.Drawing.Size(173, 20);
            this.lblCodigopartidopolitico.TabIndex = 2;
            this.lblCodigopartidopolitico.Text = "Código partido politico :";
            // 
            // lblTipodepuesto
            // 
            this.lblTipodepuesto.AutoSize = true;
            this.lblTipodepuesto.Location = new System.Drawing.Point(6, 235);
            this.lblTipodepuesto.Name = "lblTipodepuesto";
            this.lblTipodepuesto.Size = new System.Drawing.Size(172, 20);
            this.lblTipodepuesto.TabIndex = 3;
            this.lblTipodepuesto.Text = "Código tipo de puesto :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(208, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(208, 122);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 26);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(208, 172);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 26);
            this.textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(208, 229);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 26);
            this.textBox4.TabIndex = 7;
            // 
            // grbCandidatos
            // 
            this.grbCandidatos.Controls.Add(this.lblcodigocandidato);
            this.grbCandidatos.Controls.Add(this.textBox4);
            this.grbCandidatos.Controls.Add(this.lblCedulacandidato);
            this.grbCandidatos.Controls.Add(this.textBox3);
            this.grbCandidatos.Controls.Add(this.lblCodigopartidopolitico);
            this.grbCandidatos.Controls.Add(this.textBox2);
            this.grbCandidatos.Controls.Add(this.lblTipodepuesto);
            this.grbCandidatos.Controls.Add(this.textBox1);
            this.grbCandidatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbCandidatos.Location = new System.Drawing.Point(106, 65);
            this.grbCandidatos.Name = "grbCandidatos";
            this.grbCandidatos.Size = new System.Drawing.Size(361, 300);
            this.grbCandidatos.TabIndex = 8;
            this.grbCandidatos.TabStop = false;
            this.grbCandidatos.Text = "Datos Catalogo Candidato :";
            // 
            // btnGuardarcatalogocandidato
            // 
            this.btnGuardarcatalogocandidato.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarcatalogocandidato.Location = new System.Drawing.Point(227, 395);
            this.btnGuardarcatalogocandidato.Name = "btnGuardarcatalogocandidato";
            this.btnGuardarcatalogocandidato.Size = new System.Drawing.Size(126, 43);
            this.btnGuardarcatalogocandidato.TabIndex = 9;
            this.btnGuardarcatalogocandidato.Text = "Guardar Datos";
            this.btnGuardarcatalogocandidato.UseVisualStyleBackColor = true;
            // 
            // btninicio
            // 
            this.btninicio.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btninicio.Image = ((System.Drawing.Image)(resources.GetObject("btninicio.Image")));
            this.btninicio.Location = new System.Drawing.Point(12, 12);
            this.btninicio.Name = "btninicio";
            this.btninicio.Size = new System.Drawing.Size(53, 54);
            this.btninicio.TabIndex = 10;
            this.btninicio.UseVisualStyleBackColor = false;
            this.btninicio.Click += new System.EventHandler(this.btninicio_Click);
            // 
            // frmCandidatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(588, 450);
            this.Controls.Add(this.btninicio);
            this.Controls.Add(this.btnGuardarcatalogocandidato);
            this.Controls.Add(this.grbCandidatos);
            this.Name = "frmCandidatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificación Candidatos";
            this.grbCandidatos.ResumeLayout(false);
            this.grbCandidatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblcodigocandidato;
        private System.Windows.Forms.Label lblCedulacandidato;
        private System.Windows.Forms.Label lblCodigopartidopolitico;
        private System.Windows.Forms.Label lblTipodepuesto;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.GroupBox grbCandidatos;
        private System.Windows.Forms.Button btnGuardarcatalogocandidato;
        private System.Windows.Forms.Button btninicio;
    }
}