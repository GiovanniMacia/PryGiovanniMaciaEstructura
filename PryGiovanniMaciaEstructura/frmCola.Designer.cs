namespace PryGiovanniMaciaEstructura
{
    partial class frmCola
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCola));
            this.mrcListado = new System.Windows.Forms.GroupBox();
            this.cmbDatos = new System.Windows.Forms.ComboBox();
            this.lstDatos = new System.Windows.Forms.ListBox();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.Col1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mrcEliminar = new System.Windows.Forms.GroupBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblTra = new System.Windows.Forms.Label();
            this.lblCod = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.mrcNuevoElem = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtTramite = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblTramite = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.mrcListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.mrcEliminar.SuspendLayout();
            this.mrcNuevoElem.SuspendLayout();
            this.SuspendLayout();
            // 
            // mrcListado
            // 
            this.mrcListado.BackColor = System.Drawing.SystemColors.MenuBar;
            this.mrcListado.Controls.Add(this.cmbDatos);
            this.mrcListado.Controls.Add(this.lstDatos);
            this.mrcListado.Controls.Add(this.dgvDatos);
            this.mrcListado.Location = new System.Drawing.Point(13, 320);
            this.mrcListado.Margin = new System.Windows.Forms.Padding(4);
            this.mrcListado.Name = "mrcListado";
            this.mrcListado.Padding = new System.Windows.Forms.Padding(4);
            this.mrcListado.Size = new System.Drawing.Size(911, 319);
            this.mrcListado.TabIndex = 19;
            this.mrcListado.TabStop = false;
            this.mrcListado.Text = "Listado en una Lista y una Grilla";
            // 
            // cmbDatos
            // 
            this.cmbDatos.FormattingEnabled = true;
            this.cmbDatos.Location = new System.Drawing.Point(20, 266);
            this.cmbDatos.Margin = new System.Windows.Forms.Padding(4);
            this.cmbDatos.Name = "cmbDatos";
            this.cmbDatos.Size = new System.Drawing.Size(289, 24);
            this.cmbDatos.TabIndex = 10;
            // 
            // lstDatos
            // 
            this.lstDatos.FormattingEnabled = true;
            this.lstDatos.ItemHeight = 16;
            this.lstDatos.Location = new System.Drawing.Point(20, 47);
            this.lstDatos.Margin = new System.Windows.Forms.Padding(4);
            this.lstDatos.Name = "lstDatos";
            this.lstDatos.Size = new System.Drawing.Size(289, 196);
            this.lstDatos.TabIndex = 8;
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col1,
            this.Col2,
            this.Col3});
            this.dgvDatos.Location = new System.Drawing.Point(340, 47);
            this.dgvDatos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.RowHeadersWidth = 51;
            this.dgvDatos.Size = new System.Drawing.Size(547, 245);
            this.dgvDatos.TabIndex = 9;
            // 
            // Col1
            // 
            this.Col1.HeaderText = "Código";
            this.Col1.MinimumWidth = 6;
            this.Col1.Name = "Col1";
            this.Col1.Width = 125;
            // 
            // Col2
            // 
            this.Col2.HeaderText = "Nombre";
            this.Col2.MinimumWidth = 6;
            this.Col2.Name = "Col2";
            this.Col2.Width = 125;
            // 
            // Col3
            // 
            this.Col3.HeaderText = "Trámite";
            this.Col3.MinimumWidth = 6;
            this.Col3.Name = "Col3";
            this.Col3.Width = 125;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(42, 3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(295, 261);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // mrcEliminar
            // 
            this.mrcEliminar.BackColor = System.Drawing.SystemColors.MenuBar;
            this.mrcEliminar.Controls.Add(this.lblNom);
            this.mrcEliminar.Controls.Add(this.lblTra);
            this.mrcEliminar.Controls.Add(this.lblCod);
            this.mrcEliminar.Controls.Add(this.label1);
            this.mrcEliminar.Controls.Add(this.label2);
            this.mrcEliminar.Controls.Add(this.label3);
            this.mrcEliminar.Controls.Add(this.btnEliminar);
            this.mrcEliminar.Location = new System.Drawing.Point(659, 3);
            this.mrcEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.mrcEliminar.Name = "mrcEliminar";
            this.mrcEliminar.Padding = new System.Windows.Forms.Padding(4);
            this.mrcEliminar.Size = new System.Drawing.Size(277, 261);
            this.mrcEliminar.TabIndex = 17;
            this.mrcEliminar.TabStop = false;
            this.mrcEliminar.Text = "Elemento Eliminado";
            // 
            // lblNom
            // 
            this.lblNom.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblNom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNom.Location = new System.Drawing.Point(81, 78);
            this.lblNom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(133, 28);
            this.lblNom.TabIndex = 24;
            // 
            // lblTra
            // 
            this.lblTra.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblTra.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTra.Location = new System.Drawing.Point(81, 124);
            this.lblTra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTra.Name = "lblTra";
            this.lblTra.Size = new System.Drawing.Size(133, 28);
            this.lblTra.TabIndex = 23;
            // 
            // lblCod
            // 
            this.lblCod.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblCod.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCod.Location = new System.Drawing.Point(81, 38);
            this.lblCod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(133, 28);
            this.lblCod.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 132);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Trámite:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 42);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Código:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(20, 192);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(233, 43);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // mrcNuevoElem
            // 
            this.mrcNuevoElem.BackColor = System.Drawing.SystemColors.MenuBar;
            this.mrcNuevoElem.Controls.Add(this.btnAgregar);
            this.mrcNuevoElem.Controls.Add(this.txtTramite);
            this.mrcNuevoElem.Controls.Add(this.txtNombre);
            this.mrcNuevoElem.Controls.Add(this.txtCodigo);
            this.mrcNuevoElem.Controls.Add(this.lblTramite);
            this.mrcNuevoElem.Controls.Add(this.lblNombre);
            this.mrcNuevoElem.Controls.Add(this.lblCodigo);
            this.mrcNuevoElem.Location = new System.Drawing.Point(353, 3);
            this.mrcNuevoElem.Margin = new System.Windows.Forms.Padding(4);
            this.mrcNuevoElem.Name = "mrcNuevoElem";
            this.mrcNuevoElem.Padding = new System.Windows.Forms.Padding(4);
            this.mrcNuevoElem.Size = new System.Drawing.Size(277, 261);
            this.mrcNuevoElem.TabIndex = 16;
            this.mrcNuevoElem.TabStop = false;
            this.mrcNuevoElem.Text = "Nuevo Elemento";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(20, 192);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(233, 43);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtTramite
            // 
            this.txtTramite.Location = new System.Drawing.Point(87, 123);
            this.txtTramite.Margin = new System.Windows.Forms.Padding(4);
            this.txtTramite.Name = "txtTramite";
            this.txtTramite.Size = new System.Drawing.Size(165, 22);
            this.txtTramite.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(87, 76);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(165, 22);
            this.txtNombre.TabIndex = 4;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(87, 33);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(165, 22);
            this.txtCodigo.TabIndex = 3;
            // 
            // lblTramite
            // 
            this.lblTramite.AutoSize = true;
            this.lblTramite.Location = new System.Drawing.Point(16, 127);
            this.lblTramite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTramite.Name = "lblTramite";
            this.lblTramite.Size = new System.Drawing.Size(56, 16);
            this.lblTramite.TabIndex = 2;
            this.lblTramite.Text = "Trámite:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(16, 80);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(59, 16);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(21, 37);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(54, 16);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
            // 
            // frmCola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 639);
            this.Controls.Add(this.mrcListado);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mrcEliminar);
            this.Controls.Add(this.mrcNuevoElem);
            this.Name = "frmCola";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estructura Cola";
            this.Load += new System.EventHandler(this.frmCola_Load);
            this.mrcListado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.mrcEliminar.ResumeLayout(false);
            this.mrcEliminar.PerformLayout();
            this.mrcNuevoElem.ResumeLayout(false);
            this.mrcNuevoElem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mrcListado;
        private System.Windows.Forms.ComboBox cmbDatos;
        private System.Windows.Forms.ListBox lstDatos;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox mrcEliminar;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblTra;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.GroupBox mrcNuevoElem;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtTramite;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblTramite;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigo;
    }
}