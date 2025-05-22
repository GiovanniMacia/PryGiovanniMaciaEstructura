namespace PryGiovanniMaciaEstructura
{
    partial class frmBaseDatosMostrarTabla
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
            this.btnMostrar = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.cmbCargar = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(736, 466);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 23);
            this.btnMostrar.TabIndex = 3;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(59, 23);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.Size = new System.Drawing.Size(729, 426);
            this.dgv.TabIndex = 2;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // cmbCargar
            // 
            this.cmbCargar.FormattingEnabled = true;
            this.cmbCargar.Items.AddRange(new object[] {
            "Autor",
            "Pais",
            "Libro",
            "Idioma"});
            this.cmbCargar.Location = new System.Drawing.Point(598, 469);
            this.cmbCargar.Name = "cmbCargar";
            this.cmbCargar.Size = new System.Drawing.Size(121, 21);
            this.cmbCargar.TabIndex = 4;
            // 
            // frmBaseDatosMostrarTabla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 499);
            this.Controls.Add(this.cmbCargar);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.dgv);
            this.Name = "frmBaseDatosMostrarTabla";
            this.Text = "Base Datos Mostrar Tabla";
            this.Load += new System.EventHandler(this.frmBaseDatosMostrarTabla_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.ComboBox cmbCargar;
    }
}