
namespace proyecto
{
    partial class frmMenuadmin
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
            this.mnsMenuadmin = new System.Windows.Forms.MenuStrip();
            this.mantenimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesPorCandidatoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesPorPartidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarProvinciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarPartidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarPuestosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesPorCandidatoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesPorProvinciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsMenuadmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsMenuadmin
            // 
            this.mnsMenuadmin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnsMenuadmin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientosToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.inicioToolStripMenuItem,
            this.archivoToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.mnsMenuadmin.Location = new System.Drawing.Point(0, 0);
            this.mnsMenuadmin.Name = "mnsMenuadmin";
            this.mnsMenuadmin.Size = new System.Drawing.Size(840, 29);
            this.mnsMenuadmin.TabIndex = 0;
            this.mnsMenuadmin.Text = "menuStrip1";
            // 
            // mantenimientosToolStripMenuItem
            // 
            this.mantenimientosToolStripMenuItem.Name = "mantenimientosToolStripMenuItem";
            this.mantenimientosToolStripMenuItem.Size = new System.Drawing.Size(59, 25);
            this.mantenimientosToolStripMenuItem.Text = "Inicio";
            this.mantenimientosToolStripMenuItem.Click += new System.EventHandler(this.mantenimientosToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportesPorCandidatoToolStripMenuItem,
            this.reportesPorPartidoToolStripMenuItem,
            this.modificarProvinciaToolStripMenuItem,
            this.modificarPartidosToolStripMenuItem,
            this.modificarPuestosToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(128, 25);
            this.reportesToolStripMenuItem.Text = "Mantenimiento";
            // 
            // reportesPorCandidatoToolStripMenuItem
            // 
            this.reportesPorCandidatoToolStripMenuItem.Name = "reportesPorCandidatoToolStripMenuItem";
            this.reportesPorCandidatoToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.reportesPorCandidatoToolStripMenuItem.Text = "Modificar Padron";
            this.reportesPorCandidatoToolStripMenuItem.Click += new System.EventHandler(this.reportesPorCandidatoToolStripMenuItem_Click);
            // 
            // reportesPorPartidoToolStripMenuItem
            // 
            this.reportesPorPartidoToolStripMenuItem.Name = "reportesPorPartidoToolStripMenuItem";
            this.reportesPorPartidoToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.reportesPorPartidoToolStripMenuItem.Text = "Modificar Distritos";
            this.reportesPorPartidoToolStripMenuItem.Click += new System.EventHandler(this.reportesPorPartidoToolStripMenuItem_Click);
            // 
            // modificarProvinciaToolStripMenuItem
            // 
            this.modificarProvinciaToolStripMenuItem.Name = "modificarProvinciaToolStripMenuItem";
            this.modificarProvinciaToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.modificarProvinciaToolStripMenuItem.Text = "Modificar Candidatos";
            this.modificarProvinciaToolStripMenuItem.Click += new System.EventHandler(this.modificarProvinciaToolStripMenuItem_Click);
            // 
            // modificarPartidosToolStripMenuItem
            // 
            this.modificarPartidosToolStripMenuItem.Name = "modificarPartidosToolStripMenuItem";
            this.modificarPartidosToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.modificarPartidosToolStripMenuItem.Text = "Modificar Partidos";
            this.modificarPartidosToolStripMenuItem.Click += new System.EventHandler(this.modificarPartidosToolStripMenuItem_Click);
            // 
            // modificarPuestosToolStripMenuItem
            // 
            this.modificarPuestosToolStripMenuItem.Name = "modificarPuestosToolStripMenuItem";
            this.modificarPuestosToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.modificarPuestosToolStripMenuItem.Text = "Modificar Puestos";
            this.modificarPuestosToolStripMenuItem.Click += new System.EventHandler(this.modificarPuestosToolStripMenuItem_Click);
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportesPorCandidatoToolStripMenuItem1,
            this.reportesPorProvinciaToolStripMenuItem});
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(84, 25);
            this.inicioToolStripMenuItem.Text = "Reportes";
            // 
            // reportesPorCandidatoToolStripMenuItem1
            // 
            this.reportesPorCandidatoToolStripMenuItem1.Name = "reportesPorCandidatoToolStripMenuItem1";
            this.reportesPorCandidatoToolStripMenuItem1.Size = new System.Drawing.Size(242, 26);
            this.reportesPorCandidatoToolStripMenuItem1.Text = "Reportes por candidato";
            this.reportesPorCandidatoToolStripMenuItem1.Click += new System.EventHandler(this.reportesPorCandidatoToolStripMenuItem1_Click);
            // 
            // reportesPorProvinciaToolStripMenuItem
            // 
            this.reportesPorProvinciaToolStripMenuItem.Name = "reportesPorProvinciaToolStripMenuItem";
            this.reportesPorProvinciaToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.reportesPorProvinciaToolStripMenuItem.Text = "Reportes por provincia";
            this.reportesPorProvinciaToolStripMenuItem.Click += new System.EventHandler(this.reportesPorProvinciaToolStripMenuItem_Click);
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesionToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(75, 25);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar Sesion";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(89, 25);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // frmMenuadmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(840, 549);
            this.Controls.Add(this.mnsMenuadmin);
            this.MainMenuStrip = this.mnsMenuadmin;
            this.Name = "frmMenuadmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Administrador";
            this.Load += new System.EventHandler(this.frmMenuadmin_Load);
            this.mnsMenuadmin.ResumeLayout(false);
            this.mnsMenuadmin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsMenuadmin;
        private System.Windows.Forms.ToolStripMenuItem mantenimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesPorCandidatoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesPorPartidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarProvinciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesPorCandidatoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem reportesPorProvinciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarPartidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarPuestosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
    }
}