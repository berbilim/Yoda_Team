
namespace proyecto
{
    partial class frmPartido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPartido));
            this.label1 = new System.Windows.Forms.Label();
            this.lblDescripcionpartido = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.grbDatospartido = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnGardarpartidos = new System.Windows.Forms.Button();
            this.btninicio = new System.Windows.Forms.Button();
            this.grbDatospartido.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código partido politico :";
            // 
            // lblDescripcionpartido
            // 
            this.lblDescripcionpartido.AutoSize = true;
            this.lblDescripcionpartido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionpartido.Location = new System.Drawing.Point(60, 152);
            this.lblDescripcionpartido.Name = "lblDescripcionpartido";
            this.lblDescripcionpartido.Size = new System.Drawing.Size(178, 20);
            this.lblDescripcionpartido.TabIndex = 1;
            this.lblDescripcionpartido.Text = "Descripción del partido :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(277, 152);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(389, 166);
            this.textBox1.TabIndex = 2;
            // 
            // grbDatospartido
            // 
            this.grbDatospartido.Controls.Add(this.comboBox1);
            this.grbDatospartido.Controls.Add(this.textBox1);
            this.grbDatospartido.Controls.Add(this.lblDescripcionpartido);
            this.grbDatospartido.Controls.Add(this.label1);
            this.grbDatospartido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDatospartido.Location = new System.Drawing.Point(116, 95);
            this.grbDatospartido.Name = "grbDatospartido";
            this.grbDatospartido.Size = new System.Drawing.Size(723, 368);
            this.grbDatospartido.TabIndex = 3;
            this.grbDatospartido.TabStop = false;
            this.grbDatospartido.Text = "Detalles del partido :";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "PARTIDO PROGRESO SOCIAL DEMOCRATICO",
            "PARTIDO LIBERACION NACIONAL"});
            this.comboBox1.Location = new System.Drawing.Point(277, 60);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(389, 28);
            this.comboBox1.TabIndex = 3;
            // 
            // btnGardarpartidos
            // 
            this.btnGardarpartidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGardarpartidos.Location = new System.Drawing.Point(402, 489);
            this.btnGardarpartidos.Name = "btnGardarpartidos";
            this.btnGardarpartidos.Size = new System.Drawing.Size(156, 46);
            this.btnGardarpartidos.TabIndex = 4;
            this.btnGardarpartidos.Text = "Guardar Datos";
            this.btnGardarpartidos.UseVisualStyleBackColor = true;
            // 
            // btninicio
            // 
            this.btninicio.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btninicio.Image = ((System.Drawing.Image)(resources.GetObject("btninicio.Image")));
            this.btninicio.Location = new System.Drawing.Point(38, 26);
            this.btninicio.Name = "btninicio";
            this.btninicio.Size = new System.Drawing.Size(62, 54);
            this.btninicio.TabIndex = 7;
            this.btninicio.UseVisualStyleBackColor = false;
            this.btninicio.Click += new System.EventHandler(this.btninicio_Click);
            // 
            // frmPartido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(937, 602);
            this.Controls.Add(this.btninicio);
            this.Controls.Add(this.btnGardarpartidos);
            this.Controls.Add(this.grbDatospartido);
            this.Name = "frmPartido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificacion de Partido";
            this.grbDatospartido.ResumeLayout(false);
            this.grbDatospartido.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDescripcionpartido;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox grbDatospartido;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnGardarpartidos;
        private System.Windows.Forms.Button btninicio;
    }
}