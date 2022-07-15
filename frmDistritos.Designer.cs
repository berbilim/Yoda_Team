
namespace proyecto
{
    partial class frmDistritos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDistritos));
            this.lblCodigoelectoraldistritos = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbcodigoelectoral = new System.Windows.Forms.ComboBox();
            this.cmbnombreprovincia = new System.Windows.Forms.ComboBox();
            this.cmbNombrecanton = new System.Windows.Forms.ComboBox();
            this.cmbNombreDistrito = new System.Windows.Forms.ComboBox();
            this.grbDatosdistroto = new System.Windows.Forms.GroupBox();
            this.btnGuardardistrito = new System.Windows.Forms.Button();
            this.btninicio = new System.Windows.Forms.Button();
            this.grbDatosdistroto.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCodigoelectoraldistritos
            // 
            this.lblCodigoelectoraldistritos.AutoSize = true;
            this.lblCodigoelectoraldistritos.Location = new System.Drawing.Point(48, 74);
            this.lblCodigoelectoraldistritos.Name = "lblCodigoelectoraldistritos";
            this.lblCodigoelectoraldistritos.Size = new System.Drawing.Size(128, 20);
            this.lblCodigoelectoraldistritos.TabIndex = 0;
            this.lblCodigoelectoraldistritos.Text = "Codigo electora :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre provincia :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre Cantón :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombre Distrito :";
            // 
            // cmbcodigoelectoral
            // 
            this.cmbcodigoelectoral.FormattingEnabled = true;
            this.cmbcodigoelectoral.Location = new System.Drawing.Point(202, 66);
            this.cmbcodigoelectoral.Name = "cmbcodigoelectoral";
            this.cmbcodigoelectoral.Size = new System.Drawing.Size(121, 28);
            this.cmbcodigoelectoral.TabIndex = 4;
            // 
            // cmbnombreprovincia
            // 
            this.cmbnombreprovincia.FormattingEnabled = true;
            this.cmbnombreprovincia.Location = new System.Drawing.Point(202, 122);
            this.cmbnombreprovincia.Name = "cmbnombreprovincia";
            this.cmbnombreprovincia.Size = new System.Drawing.Size(121, 28);
            this.cmbnombreprovincia.TabIndex = 5;
            // 
            // cmbNombrecanton
            // 
            this.cmbNombrecanton.FormattingEnabled = true;
            this.cmbNombrecanton.Location = new System.Drawing.Point(202, 175);
            this.cmbNombrecanton.Name = "cmbNombrecanton";
            this.cmbNombrecanton.Size = new System.Drawing.Size(121, 28);
            this.cmbNombrecanton.TabIndex = 6;
            // 
            // cmbNombreDistrito
            // 
            this.cmbNombreDistrito.FormattingEnabled = true;
            this.cmbNombreDistrito.Location = new System.Drawing.Point(202, 237);
            this.cmbNombreDistrito.Name = "cmbNombreDistrito";
            this.cmbNombreDistrito.Size = new System.Drawing.Size(121, 28);
            this.cmbNombreDistrito.TabIndex = 7;
            // 
            // grbDatosdistroto
            // 
            this.grbDatosdistroto.Controls.Add(this.label2);
            this.grbDatosdistroto.Controls.Add(this.cmbNombreDistrito);
            this.grbDatosdistroto.Controls.Add(this.lblCodigoelectoraldistritos);
            this.grbDatosdistroto.Controls.Add(this.cmbNombrecanton);
            this.grbDatosdistroto.Controls.Add(this.label3);
            this.grbDatosdistroto.Controls.Add(this.cmbnombreprovincia);
            this.grbDatosdistroto.Controls.Add(this.label4);
            this.grbDatosdistroto.Controls.Add(this.cmbcodigoelectoral);
            this.grbDatosdistroto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDatosdistroto.Location = new System.Drawing.Point(118, 74);
            this.grbDatosdistroto.Name = "grbDatosdistroto";
            this.grbDatosdistroto.Size = new System.Drawing.Size(425, 318);
            this.grbDatosdistroto.TabIndex = 8;
            this.grbDatosdistroto.TabStop = false;
            this.grbDatosdistroto.Text = "Catalogo Distrito :";
            // 
            // btnGuardardistrito
            // 
            this.btnGuardardistrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardardistrito.Location = new System.Drawing.Point(269, 431);
            this.btnGuardardistrito.Name = "btnGuardardistrito";
            this.btnGuardardistrito.Size = new System.Drawing.Size(133, 49);
            this.btnGuardardistrito.TabIndex = 9;
            this.btnGuardardistrito.Text = "Guardar Datos";
            this.btnGuardardistrito.UseVisualStyleBackColor = true;
            // 
            // btninicio
            // 
            this.btninicio.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btninicio.Image = ((System.Drawing.Image)(resources.GetObject("btninicio.Image")));
            this.btninicio.Location = new System.Drawing.Point(25, 12);
            this.btninicio.Name = "btninicio";
            this.btninicio.Size = new System.Drawing.Size(53, 54);
            this.btninicio.TabIndex = 17;
            this.btninicio.UseVisualStyleBackColor = false;
            this.btninicio.Click += new System.EventHandler(this.btninicio_Click);
            // 
            // frmDistritos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(667, 542);
            this.Controls.Add(this.btninicio);
            this.Controls.Add(this.btnGuardardistrito);
            this.Controls.Add(this.grbDatosdistroto);
            this.Name = "frmDistritos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificación Distritos";
            this.grbDatosdistroto.ResumeLayout(false);
            this.grbDatosdistroto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCodigoelectoraldistritos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbcodigoelectoral;
        private System.Windows.Forms.ComboBox cmbnombreprovincia;
        private System.Windows.Forms.ComboBox cmbNombrecanton;
        private System.Windows.Forms.ComboBox cmbNombreDistrito;
        private System.Windows.Forms.GroupBox grbDatosdistroto;
        private System.Windows.Forms.Button btnGuardardistrito;
        private System.Windows.Forms.Button btninicio;
    }
}