namespace PryGiovanniMaciaEstructura
{
    partial class frmListaDoble
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaDoble));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.optDescendente = new System.Windows.Forms.RadioButton();
            this.optAscendente = new System.Windows.Forms.RadioButton();
            this.mrcListado = new System.Windows.Forms.GroupBox();
            this.lstDatos = new System.Windows.Forms.ListBox();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.Col1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mrcEliminar = new System.Windows.Forms.GroupBox();
            this.cmbCodigo = new System.Windows.Forms.ComboBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.mrcNuevoElem = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtTramite = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblTramite = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.mrcListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.mrcEliminar.SuspendLayout();
            this.mrcNuevoElem.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.btnMostrar);
            this.groupBox1.Controls.Add(this.optDescendente);
            this.groupBox1.Controls.Add(this.optAscendente);
            this.groupBox1.Location = new System.Drawing.Point(666, 232);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(277, 105);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listar Datos";
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(156, 41);
            this.btnMostrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(113, 34);
            this.btnMostrar.TabIndex = 26;
            this.btnMostrar.Text = "Mostrar Datos";
            this.btnMostrar.UseVisualStyleBackColor = true;
            // 
            // optDescendente
            // 
            this.optDescendente.AutoSize = true;
            this.optDescendente.Location = new System.Drawing.Point(20, 66);
            this.optDescendente.Margin = new System.Windows.Forms.Padding(4);
            this.optDescendente.Name = "optDescendente";
            this.optDescendente.Size = new System.Drawing.Size(109, 20);
            this.optDescendente.TabIndex = 1;
            this.optDescendente.TabStop = true;
            this.optDescendente.Text = "Descendente";
            this.optDescendente.UseVisualStyleBackColor = true;
            this.optDescendente.CheckedChanged += new System.EventHandler(this.optDescendente_CheckedChanged);
            // 
            // optAscendente
            // 
            this.optAscendente.AutoSize = true;
            this.optAscendente.Location = new System.Drawing.Point(20, 30);
            this.optAscendente.Margin = new System.Windows.Forms.Padding(4);
            this.optAscendente.Name = "optAscendente";
            this.optAscendente.Size = new System.Drawing.Size(100, 20);
            this.optAscendente.TabIndex = 0;
            this.optAscendente.TabStop = true;
            this.optAscendente.Text = "Ascendente";
            this.optAscendente.UseVisualStyleBackColor = true;
            this.optAscendente.CheckedChanged += new System.EventHandler(this.optAscendente_CheckedChanged);
            // 
            // mrcListado
            // 
            this.mrcListado.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mrcListado.Controls.Add(this.lstDatos);
            this.mrcListado.Controls.Add(this.dgvDatos);
            this.mrcListado.Location = new System.Drawing.Point(13, 339);
            this.mrcListado.Margin = new System.Windows.Forms.Padding(4);
            this.mrcListado.Name = "mrcListado";
            this.mrcListado.Padding = new System.Windows.Forms.Padding(4);
            this.mrcListado.Size = new System.Drawing.Size(911, 319);
            this.mrcListado.TabIndex = 29;
            this.mrcListado.TabStop = false;
            this.mrcListado.Text = "Listado en una Lista y una Grilla";
            // 
            // lstDatos
            // 
            this.lstDatos.FormattingEnabled = true;
            this.lstDatos.ItemHeight = 16;
            this.lstDatos.Location = new System.Drawing.Point(20, 47);
            this.lstDatos.Margin = new System.Windows.Forms.Padding(4);
            this.lstDatos.Name = "lstDatos";
            this.lstDatos.Size = new System.Drawing.Size(289, 244);
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
            this.pictureBox1.Location = new System.Drawing.Point(33, 31);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(295, 261);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // mrcEliminar
            // 
            this.mrcEliminar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mrcEliminar.Controls.Add(this.cmbCodigo);
            this.mrcEliminar.Controls.Add(this.btnEliminar);
            this.mrcEliminar.Controls.Add(this.label3);
            this.mrcEliminar.Location = new System.Drawing.Point(666, 38);
            this.mrcEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.mrcEliminar.Name = "mrcEliminar";
            this.mrcEliminar.Padding = new System.Windows.Forms.Padding(4);
            this.mrcEliminar.Size = new System.Drawing.Size(277, 166);
            this.mrcEliminar.TabIndex = 27;
            this.mrcEliminar.TabStop = false;
            this.mrcEliminar.Text = "Elemento Eliminado";
            // 
            // cmbCodigo
            // 
            this.cmbCodigo.FormattingEnabled = true;
            this.cmbCodigo.Location = new System.Drawing.Point(81, 37);
            this.cmbCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCodigo.Name = "cmbCodigo";
            this.cmbCodigo.Size = new System.Drawing.Size(171, 24);
            this.cmbCodigo.TabIndex = 7;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(20, 100);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(233, 43);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 42);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Código:";
            // 
            // mrcNuevoElem
            // 
            this.mrcNuevoElem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mrcNuevoElem.Controls.Add(this.btnAgregar);
            this.mrcNuevoElem.Controls.Add(this.txtTramite);
            this.mrcNuevoElem.Controls.Add(this.txtNombre);
            this.mrcNuevoElem.Controls.Add(this.txtCodigo);
            this.mrcNuevoElem.Controls.Add(this.lblTramite);
            this.mrcNuevoElem.Controls.Add(this.lblNombre);
            this.mrcNuevoElem.Controls.Add(this.lblCodigo);
            this.mrcNuevoElem.Location = new System.Drawing.Point(353, 40);
            this.mrcNuevoElem.Margin = new System.Windows.Forms.Padding(4);
            this.mrcNuevoElem.Name = "mrcNuevoElem";
            this.mrcNuevoElem.Padding = new System.Windows.Forms.Padding(4);
            this.mrcNuevoElem.Size = new System.Drawing.Size(277, 261);
            this.mrcNuevoElem.TabIndex = 26;
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
            this.txtTramite.TextChanged += new System.EventHandler(this.txtTramite_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(87, 76);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(165, 22);
            this.txtNombre.TabIndex = 4;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(87, 33);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(165, 22);
            this.txtCodigo.TabIndex = 3;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
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
            // frmListaDoble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 671);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mrcListado);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mrcEliminar);
            this.Controls.Add(this.mrcNuevoElem);
            this.Name = "frmListaDoble";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estructura Lista Doble";
            this.Load += new System.EventHandler(this.frmListaDoble_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.RadioButton optDescendente;
        private System.Windows.Forms.RadioButton optAscendente;
        private System.Windows.Forms.GroupBox mrcListado;
        private System.Windows.Forms.ListBox lstDatos;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox mrcEliminar;
        private System.Windows.Forms.ComboBox cmbCodigo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label3;
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