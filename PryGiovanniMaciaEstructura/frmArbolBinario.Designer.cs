namespace PryGiovanniMaciaEstructura
{
    partial class frmArbolBinario
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
            this.tvArbol = new System.Windows.Forms.TreeView();
            this.btnEquilibrar = new System.Windows.Forms.Button();
            this.mrcListado = new System.Windows.Forms.GroupBox();
            this.optPostOrden = new System.Windows.Forms.RadioButton();
            this.optPreOrden = new System.Windows.Forms.RadioButton();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.Col1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.optInOrden = new System.Windows.Forms.RadioButton();
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
            this.mrcListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.mrcEliminar.SuspendLayout();
            this.mrcNuevoElem.SuspendLayout();
            this.SuspendLayout();
            // 
            // tvArbol
            // 
            this.tvArbol.Location = new System.Drawing.Point(3, 42);
            this.tvArbol.Margin = new System.Windows.Forms.Padding(4);
            this.tvArbol.Name = "tvArbol";
            this.tvArbol.Size = new System.Drawing.Size(308, 260);
            this.tvArbol.TabIndex = 35;
            // 
            // btnEquilibrar
            // 
            this.btnEquilibrar.Location = new System.Drawing.Point(660, 259);
            this.btnEquilibrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEquilibrar.Name = "btnEquilibrar";
            this.btnEquilibrar.Size = new System.Drawing.Size(233, 43);
            this.btnEquilibrar.TabIndex = 36;
            this.btnEquilibrar.Text = "Equilibrar";
            this.btnEquilibrar.UseVisualStyleBackColor = true;
            this.btnEquilibrar.Click += new System.EventHandler(this.btnEquilibrar_Click_1);
            // 
            // mrcListado
            // 
            this.mrcListado.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.mrcListado.Controls.Add(this.optPostOrden);
            this.mrcListado.Controls.Add(this.optPreOrden);
            this.mrcListado.Controls.Add(this.dgvDatos);
            this.mrcListado.Controls.Add(this.optInOrden);
            this.mrcListado.Location = new System.Drawing.Point(3, 345);
            this.mrcListado.Margin = new System.Windows.Forms.Padding(4);
            this.mrcListado.Name = "mrcListado";
            this.mrcListado.Padding = new System.Windows.Forms.Padding(4);
            this.mrcListado.Size = new System.Drawing.Size(911, 229);
            this.mrcListado.TabIndex = 39;
            this.mrcListado.TabStop = false;
            this.mrcListado.Text = "Listado en una Lista y una Grilla";
            // 
            // optPostOrden
            // 
            this.optPostOrden.AutoSize = true;
            this.optPostOrden.Location = new System.Drawing.Point(40, 154);
            this.optPostOrden.Margin = new System.Windows.Forms.Padding(4);
            this.optPostOrden.Name = "optPostOrden";
            this.optPostOrden.Size = new System.Drawing.Size(96, 20);
            this.optPostOrden.TabIndex = 10;
            this.optPostOrden.TabStop = true;
            this.optPostOrden.Text = "Post-Orden";
            this.optPostOrden.UseVisualStyleBackColor = true;
            this.optPostOrden.CheckedChanged += new System.EventHandler(this.optPostOrden_CheckedChanged_1);
            // 
            // optPreOrden
            // 
            this.optPreOrden.AutoSize = true;
            this.optPreOrden.Location = new System.Drawing.Point(40, 100);
            this.optPreOrden.Margin = new System.Windows.Forms.Padding(4);
            this.optPreOrden.Name = "optPreOrden";
            this.optPreOrden.Size = new System.Drawing.Size(90, 20);
            this.optPreOrden.TabIndex = 1;
            this.optPreOrden.TabStop = true;
            this.optPreOrden.Text = "Pre-Orden";
            this.optPreOrden.UseVisualStyleBackColor = true;
            this.optPreOrden.CheckedChanged += new System.EventHandler(this.optPreOrden_CheckedChanged_1);
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col1,
            this.Col2,
            this.Col3});
            this.dgvDatos.Location = new System.Drawing.Point(343, 23);
            this.dgvDatos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.RowHeadersWidth = 51;
            this.dgvDatos.Size = new System.Drawing.Size(460, 180);
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
            // optInOrden
            // 
            this.optInOrden.AutoSize = true;
            this.optInOrden.Location = new System.Drawing.Point(40, 49);
            this.optInOrden.Margin = new System.Windows.Forms.Padding(4);
            this.optInOrden.Name = "optInOrden";
            this.optInOrden.Size = new System.Drawing.Size(79, 20);
            this.optInOrden.TabIndex = 0;
            this.optInOrden.TabStop = true;
            this.optInOrden.Text = "In-Orden";
            this.optInOrden.UseVisualStyleBackColor = true;
            this.optInOrden.CheckedChanged += new System.EventHandler(this.optInOrden_CheckedChanged_1);
            // 
            // mrcEliminar
            // 
            this.mrcEliminar.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.mrcEliminar.Controls.Add(this.cmbCodigo);
            this.mrcEliminar.Controls.Add(this.btnEliminar);
            this.mrcEliminar.Controls.Add(this.label3);
            this.mrcEliminar.Location = new System.Drawing.Point(637, 42);
            this.mrcEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.mrcEliminar.Name = "mrcEliminar";
            this.mrcEliminar.Padding = new System.Windows.Forms.Padding(4);
            this.mrcEliminar.Size = new System.Drawing.Size(277, 166);
            this.mrcEliminar.TabIndex = 38;
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
            this.cmbCodigo.SelectedIndexChanged += new System.EventHandler(this.cmbCodigo_SelectedIndexChanged);
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
            this.mrcNuevoElem.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.mrcNuevoElem.Controls.Add(this.btnAgregar);
            this.mrcNuevoElem.Controls.Add(this.txtTramite);
            this.mrcNuevoElem.Controls.Add(this.txtNombre);
            this.mrcNuevoElem.Controls.Add(this.txtCodigo);
            this.mrcNuevoElem.Controls.Add(this.lblTramite);
            this.mrcNuevoElem.Controls.Add(this.lblNombre);
            this.mrcNuevoElem.Controls.Add(this.lblCodigo);
            this.mrcNuevoElem.Location = new System.Drawing.Point(341, 42);
            this.mrcNuevoElem.Margin = new System.Windows.Forms.Padding(4);
            this.mrcNuevoElem.Name = "mrcNuevoElem";
            this.mrcNuevoElem.Padding = new System.Windows.Forms.Padding(4);
            this.mrcNuevoElem.Size = new System.Drawing.Size(277, 261);
            this.mrcNuevoElem.TabIndex = 37;
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
            this.txtTramite.TextChanged += new System.EventHandler(this.txtTramite_TextChanged_1);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(87, 76);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(165, 22);
            this.txtNombre.TabIndex = 4;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged_1);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(87, 33);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(165, 22);
            this.txtCodigo.TabIndex = 3;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged_1);
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
            // frmArbolBinario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 587);
            this.Controls.Add(this.tvArbol);
            this.Controls.Add(this.btnEquilibrar);
            this.Controls.Add(this.mrcListado);
            this.Controls.Add(this.mrcEliminar);
            this.Controls.Add(this.mrcNuevoElem);
            this.Name = "frmArbolBinario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estructura Arbol Binario";
            this.Load += new System.EventHandler(this.frmArbolBinario_Load);
            this.mrcListado.ResumeLayout(false);
            this.mrcListado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.mrcEliminar.ResumeLayout(false);
            this.mrcEliminar.PerformLayout();
            this.mrcNuevoElem.ResumeLayout(false);
            this.mrcNuevoElem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tvArbol;
        private System.Windows.Forms.Button btnEquilibrar;
        private System.Windows.Forms.GroupBox mrcListado;
        private System.Windows.Forms.RadioButton optPostOrden;
        private System.Windows.Forms.RadioButton optPreOrden;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col3;
        private System.Windows.Forms.RadioButton optInOrden;
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