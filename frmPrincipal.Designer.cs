
namespace proyecto
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.label1 = new System.Windows.Forms.Label();
            this.grplogin = new System.Windows.Forms.GroupBox();
            this.btnIngresarvotante = new System.Windows.Forms.Button();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.lbldatos = new System.Windows.Forms.Label();
            this.txtcontrasena = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.grplogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(198, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Elleciones 2026, Bienvenido !!";
            // 
            // grplogin
            // 
            this.grplogin.Controls.Add(this.btnIngresarvotante);
            this.grplogin.Controls.Add(this.btnRegistro);
            this.grplogin.Controls.Add(this.lbldatos);
            this.grplogin.Controls.Add(this.txtcontrasena);
            this.grplogin.Controls.Add(this.txtCedula);
            this.grplogin.Controls.Add(this.label3);
            this.grplogin.Controls.Add(this.label2);
            this.grplogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grplogin.Location = new System.Drawing.Point(103, 121);
            this.grplogin.Name = "grplogin";
            this.grplogin.Size = new System.Drawing.Size(414, 347);
            this.grplogin.TabIndex = 3;
            this.grplogin.TabStop = false;
            // 
            // btnIngresarvotante
            // 
            this.btnIngresarvotante.Location = new System.Drawing.Point(171, 219);
            this.btnIngresarvotante.Name = "btnIngresarvotante";
            this.btnIngresarvotante.Size = new System.Drawing.Size(90, 31);
            this.btnIngresarvotante.TabIndex = 5;
            this.btnIngresarvotante.Text = "Ingresar";
            this.btnIngresarvotante.UseVisualStyleBackColor = true;
            this.btnIngresarvotante.Click += new System.EventHandler(this.btnIngresarvotante_Click);
            // 
            // btnRegistro
            // 
            this.btnRegistro.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnRegistro.Location = new System.Drawing.Point(160, 284);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(113, 33);
            this.btnRegistro.TabIndex = 4;
            this.btnRegistro.Text = "Registrarse";
            this.btnRegistro.UseVisualStyleBackColor = false;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // lbldatos
            // 
            this.lbldatos.AutoSize = true;
            this.lbldatos.Location = new System.Drawing.Point(116, 41);
            this.lbldatos.Name = "lbldatos";
            this.lbldatos.Size = new System.Drawing.Size(210, 20);
            this.lbldatos.TabIndex = 4;
            this.lbldatos.Text = "Ingrese sus datos por favor :";
            // 
            // txtcontrasena
            // 
            this.txtcontrasena.Location = new System.Drawing.Point(165, 160);
            this.txtcontrasena.Name = "txtcontrasena";
            this.txtcontrasena.PasswordChar = '*';
            this.txtcontrasena.Size = new System.Drawing.Size(100, 26);
            this.txtcontrasena.TabIndex = 3;
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(165, 110);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(100, 26);
            this.txtCedula.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Contraseña :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cédula :";
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnAdmin.Image = ((System.Drawing.Image)(resources.GetObject("btnAdmin.Image")));
            this.btnAdmin.Location = new System.Drawing.Point(12, 12);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(62, 54);
            this.btnAdmin.TabIndex = 1;
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(630, 549);
            this.Controls.Add(this.grplogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de votaciones";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.grplogin.ResumeLayout(false);
            this.grplogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grplogin;
        private System.Windows.Forms.Label lbldatos;
        private System.Windows.Forms.TextBox txtcontrasena;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRegistro;
        private System.Windows.Forms.Button btnIngresarvotante;
    }
}

