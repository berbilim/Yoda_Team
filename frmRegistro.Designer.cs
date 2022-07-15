
namespace proyecto
{
    partial class frmRegistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistro));
            this.lblRegistro = new System.Windows.Forms.Label();
            this.lblCedula = new System.Windows.Forms.Label();
            this.grpRegistro = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.lblFechavencimiento = new System.Windows.Forms.Label();
            this.cmbProvincia = new System.Windows.Forms.ComboBox();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.lblPreguntaseguridad = new System.Windows.Forms.Label();
            this.txtPregunta = new System.Windows.Forms.TextBox();
            this.lblRespuestaseguridad = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnGardarregistro = new System.Windows.Forms.Button();
            this.btninicio = new System.Windows.Forms.Button();
            this.grpRegistro.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRegistro
            // 
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistro.Location = new System.Drawing.Point(183, 37);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(253, 20);
            this.lblRegistro.TabIndex = 0;
            this.lblRegistro.Text = "Ingrese los datos para su registro :";
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Location = new System.Drawing.Point(20, 53);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(67, 20);
            this.lblCedula.TabIndex = 1;
            this.lblCedula.Text = "Cédula :";
            // 
            // grpRegistro
            // 
            this.grpRegistro.Controls.Add(this.textBox1);
            this.grpRegistro.Controls.Add(this.lblRespuestaseguridad);
            this.grpRegistro.Controls.Add(this.txtPregunta);
            this.grpRegistro.Controls.Add(this.lblPreguntaseguridad);
            this.grpRegistro.Controls.Add(this.lblProvincia);
            this.grpRegistro.Controls.Add(this.cmbProvincia);
            this.grpRegistro.Controls.Add(this.lblFechavencimiento);
            this.grpRegistro.Controls.Add(this.txtCedula);
            this.grpRegistro.Controls.Add(this.dateTimePicker1);
            this.grpRegistro.Controls.Add(this.lblCedula);
            this.grpRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpRegistro.Location = new System.Drawing.Point(88, 90);
            this.grpRegistro.Name = "grpRegistro";
            this.grpRegistro.Size = new System.Drawing.Size(475, 358);
            this.grpRegistro.TabIndex = 2;
            this.grpRegistro.TabStop = false;
            this.grpRegistro.Text = "Datos";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(227, 83);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(227, 47);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(100, 26);
            this.txtCedula.TabIndex = 3;
            // 
            // lblFechavencimiento
            // 
            this.lblFechavencimiento.AutoSize = true;
            this.lblFechavencimiento.Location = new System.Drawing.Point(20, 83);
            this.lblFechavencimiento.Name = "lblFechavencimiento";
            this.lblFechavencimiento.Size = new System.Drawing.Size(201, 20);
            this.lblFechavencimiento.TabIndex = 4;
            this.lblFechavencimiento.Text = "Fecha vencimiento cédula :";
            // 
            // cmbProvincia
            // 
            this.cmbProvincia.FormattingEnabled = true;
            this.cmbProvincia.Items.AddRange(new object[] {
            "San José",
            "Alajuela",
            "Heredia",
            "Cartago",
            "Puntarenas",
            "Guanacaste",
            "Limon"});
            this.cmbProvincia.Location = new System.Drawing.Point(227, 125);
            this.cmbProvincia.Name = "cmbProvincia";
            this.cmbProvincia.Size = new System.Drawing.Size(121, 28);
            this.cmbProvincia.TabIndex = 5;
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Location = new System.Drawing.Point(30, 133);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(80, 20);
            this.lblProvincia.TabIndex = 6;
            this.lblProvincia.Text = "Provincia :";
            // 
            // lblPreguntaseguridad
            // 
            this.lblPreguntaseguridad.AutoSize = true;
            this.lblPreguntaseguridad.Location = new System.Drawing.Point(31, 176);
            this.lblPreguntaseguridad.Name = "lblPreguntaseguridad";
            this.lblPreguntaseguridad.Size = new System.Drawing.Size(178, 20);
            this.lblPreguntaseguridad.TabIndex = 7;
            this.lblPreguntaseguridad.Text = "Pregunta de seguridad :";
            // 
            // txtPregunta
            // 
            this.txtPregunta.Location = new System.Drawing.Point(227, 176);
            this.txtPregunta.Name = "txtPregunta";
            this.txtPregunta.Size = new System.Drawing.Size(200, 26);
            this.txtPregunta.TabIndex = 8;
            // 
            // lblRespuestaseguridad
            // 
            this.lblRespuestaseguridad.AutoSize = true;
            this.lblRespuestaseguridad.Location = new System.Drawing.Point(33, 236);
            this.lblRespuestaseguridad.Name = "lblRespuestaseguridad";
            this.lblRespuestaseguridad.Size = new System.Drawing.Size(191, 20);
            this.lblRespuestaseguridad.TabIndex = 9;
            this.lblRespuestaseguridad.Text = "Respuesta de seguridad :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(227, 236);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 26);
            this.textBox1.TabIndex = 10;
            // 
            // btnGardarregistro
            // 
            this.btnGardarregistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGardarregistro.Location = new System.Drawing.Point(226, 472);
            this.btnGardarregistro.Name = "btnGardarregistro";
            this.btnGardarregistro.Size = new System.Drawing.Size(153, 39);
            this.btnGardarregistro.TabIndex = 3;
            this.btnGardarregistro.Text = "Guardar información";
            this.btnGardarregistro.UseVisualStyleBackColor = true;
            // 
            // btninicio
            // 
            this.btninicio.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btninicio.Image = ((System.Drawing.Image)(resources.GetObject("btninicio.Image")));
            this.btninicio.Location = new System.Drawing.Point(12, 12);
            this.btninicio.Name = "btninicio";
            this.btninicio.Size = new System.Drawing.Size(53, 54);
            this.btninicio.TabIndex = 7;
            this.btninicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btninicio.UseVisualStyleBackColor = false;
            this.btninicio.Click += new System.EventHandler(this.btninicio_Click);
            // 
            // frmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(632, 564);
            this.Controls.Add(this.btninicio);
            this.Controls.Add(this.btnGardarregistro);
            this.Controls.Add(this.grpRegistro);
            this.Controls.Add(this.lblRegistro);
            this.Name = "frmRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.grpRegistro.ResumeLayout(false);
            this.grpRegistro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRegistro;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.GroupBox grpRegistro;
        private System.Windows.Forms.ComboBox cmbProvincia;
        private System.Windows.Forms.Label lblFechavencimiento;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblRespuestaseguridad;
        private System.Windows.Forms.TextBox txtPregunta;
        private System.Windows.Forms.Label lblPreguntaseguridad;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.Button btnGardarregistro;
        private System.Windows.Forms.Button btninicio;
    }
}