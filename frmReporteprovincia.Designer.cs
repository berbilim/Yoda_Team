
namespace proyecto
{
    partial class frmReporteprovincia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteprovincia));
            this.btnGenerarreporteprovincia = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btninicio = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerarreporteprovincia
            // 
            this.btnGenerarreporteprovincia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarreporteprovincia.Location = new System.Drawing.Point(38, 152);
            this.btnGenerarreporteprovincia.Name = "btnGenerarreporteprovincia";
            this.btnGenerarreporteprovincia.Size = new System.Drawing.Size(108, 45);
            this.btnGenerarreporteprovincia.TabIndex = 8;
            this.btnGenerarreporteprovincia.Text = "Generar Reporte";
            this.btnGenerarreporteprovincia.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::proyecto.Properties.Resources.grafico2;
            this.pictureBox1.Location = new System.Drawing.Point(330, 101);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(322, 351);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btninicio
            // 
            this.btninicio.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btninicio.Image = ((System.Drawing.Image)(resources.GetObject("btninicio.Image")));
            this.btninicio.Location = new System.Drawing.Point(25, 12);
            this.btninicio.Name = "btninicio";
            this.btninicio.Size = new System.Drawing.Size(62, 54);
            this.btninicio.TabIndex = 6;
            this.btninicio.UseVisualStyleBackColor = false;
            this.btninicio.Click += new System.EventHandler(this.btninicio_Click);
            // 
            // frmReporteprovincia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(840, 549);
            this.Controls.Add(this.btnGenerarreporteprovincia);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btninicio);
            this.Name = "frmReporteprovincia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte por provincia";
            this.Load += new System.EventHandler(this.frmReporteprovincia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btninicio;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnGenerarreporteprovincia;
    }
}