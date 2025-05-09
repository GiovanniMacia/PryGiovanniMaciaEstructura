namespace PryGiovanniMaciaEstructura
{
    partial class frmListaSimple
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
            System.Windows.Forms.PictureBox pictureBox1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaSimple));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbDatosLista = new System.Windows.Forms.ComboBox();
            this.lstDatosLista = new System.Windows.Forms.ListBox();
            this.dgvDatosLista = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTramiteEliminar = new System.Windows.Forms.Label();
            this.lblNombreEliminar = new System.Windows.Forms.Label();
            this.lblCodigoEliminar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTrámiteLista = new System.Windows.Forms.TextBox();
            this.lblTrámite = new System.Windows.Forms.Label();
            this.txtNombreLista = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtCódigoLista = new System.Windows.Forms.TextBox();
            this.lblCódigo = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosLista)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            pictureBox1.Location = new System.Drawing.Point(25, 24);
            pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(271, 236);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbDatosLista);
            this.groupBox3.Controls.Add(this.lstDatosLista);
            this.groupBox3.Controls.Add(this.dgvDatosLista);
            this.groupBox3.Location = new System.Drawing.Point(39, 288);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(885, 281);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Listado en una Lista y una Grilla";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // cmbDatosLista
            // 
            this.cmbDatosLista.FormattingEnabled = true;
            this.cmbDatosLista.Location = new System.Drawing.Point(27, 218);
            this.cmbDatosLista.Margin = new System.Windows.Forms.Padding(4);
            this.cmbDatosLista.Name = "cmbDatosLista";
            this.cmbDatosLista.Size = new System.Drawing.Size(299, 24);
            this.cmbDatosLista.TabIndex = 2;
            this.cmbDatosLista.SelectedIndexChanged += new System.EventHandler(this.cmbDatosLista_SelectedIndexChanged);
            // 
            // lstDatosLista
            // 
            this.lstDatosLista.FormattingEnabled = true;
            this.lstDatosLista.ItemHeight = 16;
            this.lstDatosLista.Location = new System.Drawing.Point(27, 23);
            this.lstDatosLista.Margin = new System.Windows.Forms.Padding(4);
            this.lstDatosLista.Name = "lstDatosLista";
            this.lstDatosLista.Size = new System.Drawing.Size(299, 164);
            this.lstDatosLista.TabIndex = 1;
            // 
            // dgvDatosLista
            // 
            this.dgvDatosLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvDatosLista.Location = new System.Drawing.Point(352, 15);
            this.dgvDatosLista.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDatosLista.Name = "dgvDatosLista";
            this.dgvDatosLista.RowHeadersWidth = 51;
            this.dgvDatosLista.Size = new System.Drawing.Size(525, 229);
            this.dgvDatosLista.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Código";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Trámite";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblTramiteEliminar);
            this.groupBox2.Controls.Add(this.lblNombreEliminar);
            this.groupBox2.Controls.Add(this.lblCodigoEliminar);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnEliminar);
            this.groupBox2.Location = new System.Drawing.Point(645, 13);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(289, 266);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Elemento Eliminado";
            // 
            // lblTramiteEliminar
            // 
            this.lblTramiteEliminar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTramiteEliminar.Location = new System.Drawing.Point(115, 146);
            this.lblTramiteEliminar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTramiteEliminar.Name = "lblTramiteEliminar";
            this.lblTramiteEliminar.Size = new System.Drawing.Size(111, 25);
            this.lblTramiteEliminar.TabIndex = 8;
            // 
            // lblNombreEliminar
            // 
            this.lblNombreEliminar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNombreEliminar.Location = new System.Drawing.Point(115, 100);
            this.lblNombreEliminar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreEliminar.Name = "lblNombreEliminar";
            this.lblNombreEliminar.Size = new System.Drawing.Size(111, 25);
            this.lblNombreEliminar.TabIndex = 7;
            // 
            // lblCodigoEliminar
            // 
            this.lblCodigoEliminar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCodigoEliminar.Location = new System.Drawing.Point(115, 42);
            this.lblCodigoEliminar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigoEliminar.Name = "lblCodigoEliminar";
            this.lblCodigoEliminar.Size = new System.Drawing.Size(111, 25);
            this.lblCodigoEliminar.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 155);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Trámite:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 50);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Código:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(40, 207);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(224, 31);
            this.btnEliminar.TabIndex = 0;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTrámiteLista);
            this.groupBox1.Controls.Add(this.lblTrámite);
            this.groupBox1.Controls.Add(this.txtNombreLista);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Controls.Add(this.txtCódigoLista);
            this.groupBox1.Controls.Add(this.lblCódigo);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Location = new System.Drawing.Point(318, 24);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(289, 266);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nuevo Elemento";
            // 
            // txtTrámiteLista
            // 
            this.txtTrámiteLista.Location = new System.Drawing.Point(128, 151);
            this.txtTrámiteLista.Margin = new System.Windows.Forms.Padding(4);
            this.txtTrámiteLista.Name = "txtTrámiteLista";
            this.txtTrámiteLista.Size = new System.Drawing.Size(124, 22);
            this.txtTrámiteLista.TabIndex = 6;
            this.txtTrámiteLista.TextChanged += new System.EventHandler(this.txtTrámiteLista_TextChanged);
            // 
            // lblTrámite
            // 
            this.lblTrámite.AutoSize = true;
            this.lblTrámite.Location = new System.Drawing.Point(36, 155);
            this.lblTrámite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTrámite.Name = "lblTrámite";
            this.lblTrámite.Size = new System.Drawing.Size(56, 16);
            this.lblTrámite.TabIndex = 5;
            this.lblTrámite.Text = "Trámite:";
            // 
            // txtNombreLista
            // 
            this.txtNombreLista.Location = new System.Drawing.Point(128, 100);
            this.txtNombreLista.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreLista.Name = "txtNombreLista";
            this.txtNombreLista.Size = new System.Drawing.Size(124, 22);
            this.txtNombreLista.TabIndex = 4;
            this.txtNombreLista.TextChanged += new System.EventHandler(this.txtNombreLista_TextChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(36, 103);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(59, 16);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtCódigoLista
            // 
            this.txtCódigoLista.Location = new System.Drawing.Point(128, 47);
            this.txtCódigoLista.Margin = new System.Windows.Forms.Padding(4);
            this.txtCódigoLista.Name = "txtCódigoLista";
            this.txtCódigoLista.Size = new System.Drawing.Size(92, 22);
            this.txtCódigoLista.TabIndex = 2;
            this.txtCódigoLista.TextChanged += new System.EventHandler(this.txtCódigoLista_TextChanged);
            // 
            // lblCódigo
            // 
            this.lblCódigo.AutoSize = true;
            this.lblCódigo.Location = new System.Drawing.Point(36, 50);
            this.lblCódigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCódigo.Name = "lblCódigo";
            this.lblCódigo.Size = new System.Drawing.Size(54, 16);
            this.lblCódigo.TabIndex = 1;
            this.lblCódigo.Text = "Código:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(40, 207);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(224, 31);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // frmListaSimple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 580);
            this.Controls.Add(pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmListaSimple";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estructura Lista Simple";
            this.Load += new System.EventHandler(this.frmListaSimple_Load);
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosLista)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmbDatosLista;
        private System.Windows.Forms.ListBox lstDatosLista;
        private System.Windows.Forms.DataGridView dgvDatosLista;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblTramiteEliminar;
        private System.Windows.Forms.Label lblNombreEliminar;
        private System.Windows.Forms.Label lblCodigoEliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTrámiteLista;
        private System.Windows.Forms.Label lblTrámite;
        private System.Windows.Forms.TextBox txtNombreLista;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtCódigoLista;
        private System.Windows.Forms.Label lblCódigo;
        private System.Windows.Forms.Button btnAgregar;
    }
}