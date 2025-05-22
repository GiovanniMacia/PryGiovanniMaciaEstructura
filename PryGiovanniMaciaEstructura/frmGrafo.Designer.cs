namespace PryGiovanniMaciaEstructura
{
    partial class frmGrafo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGrafo));
            this.btnBorrar = new System.Windows.Forms.Button();
            this.mrcEliminar = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrecioConsulta = new System.Windows.Forms.TextBox();
            this.cmbDestinoConsulta = new System.Windows.Forms.ComboBox();
            this.cmbOrigenConsulta = new System.Windows.Forms.ComboBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.mrcNuevoElem = new System.Windows.Forms.GroupBox();
            this.cmbDestino = new System.Windows.Forms.ComboBox();
            this.cmbOrigen = new System.Windows.Forms.ComboBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnBorrarTodo = new System.Windows.Forms.Button();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnVerViajes = new System.Windows.Forms.Button();
            this.btnListarOrigenes = new System.Windows.Forms.Button();
            this.cmbHasta = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnListar = new System.Windows.Forms.Button();
            this.cmbDesde = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mrcEliminar.SuspendLayout();
            this.mrcNuevoElem.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(112, 156);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(64, 35);
            this.btnBorrar.TabIndex = 41;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // mrcEliminar
            // 
            this.mrcEliminar.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.mrcEliminar.Controls.Add(this.label5);
            this.mrcEliminar.Controls.Add(this.label4);
            this.mrcEliminar.Controls.Add(this.txtPrecioConsulta);
            this.mrcEliminar.Controls.Add(this.cmbDestinoConsulta);
            this.mrcEliminar.Controls.Add(this.cmbOrigenConsulta);
            this.mrcEliminar.Controls.Add(this.btnConsultar);
            this.mrcEliminar.Controls.Add(this.btnBorrar);
            this.mrcEliminar.Controls.Add(this.label3);
            this.mrcEliminar.Location = new System.Drawing.Point(495, 9);
            this.mrcEliminar.Name = "mrcEliminar";
            this.mrcEliminar.Size = new System.Drawing.Size(208, 212);
            this.mrcEliminar.TabIndex = 43;
            this.mrcEliminar.TabStop = false;
            this.mrcEliminar.Text = "Elemento Eliminado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "Precio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "Destino:";
            // 
            // txtPrecioConsulta
            // 
            this.txtPrecioConsulta.Location = new System.Drawing.Point(61, 98);
            this.txtPrecioConsulta.Name = "txtPrecioConsulta";
            this.txtPrecioConsulta.Size = new System.Drawing.Size(125, 20);
            this.txtPrecioConsulta.TabIndex = 8;
            // 
            // cmbDestinoConsulta
            // 
            this.cmbDestinoConsulta.FormattingEnabled = true;
            this.cmbDestinoConsulta.Location = new System.Drawing.Point(61, 65);
            this.cmbDestinoConsulta.Name = "cmbDestinoConsulta";
            this.cmbDestinoConsulta.Size = new System.Drawing.Size(129, 21);
            this.cmbDestinoConsulta.TabIndex = 42;
            // 
            // cmbOrigenConsulta
            // 
            this.cmbOrigenConsulta.FormattingEnabled = true;
            this.cmbOrigenConsulta.Location = new System.Drawing.Point(61, 30);
            this.cmbOrigenConsulta.Name = "cmbOrigenConsulta";
            this.cmbOrigenConsulta.Size = new System.Drawing.Size(129, 21);
            this.cmbOrigenConsulta.TabIndex = 7;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(22, 156);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(56, 35);
            this.btnConsultar.TabIndex = 6;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Origen:";
            // 
            // mrcNuevoElem
            // 
            this.mrcNuevoElem.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.mrcNuevoElem.Controls.Add(this.cmbDestino);
            this.mrcNuevoElem.Controls.Add(this.cmbOrigen);
            this.mrcNuevoElem.Controls.Add(this.btnCargar);
            this.mrcNuevoElem.Controls.Add(this.btnBorrarTodo);
            this.mrcNuevoElem.Controls.Add(this.txtPrecio);
            this.mrcNuevoElem.Controls.Add(this.lblPrecio);
            this.mrcNuevoElem.Controls.Add(this.lblNombre);
            this.mrcNuevoElem.Controls.Add(this.lblCodigo);
            this.mrcNuevoElem.Location = new System.Drawing.Point(273, 9);
            this.mrcNuevoElem.Name = "mrcNuevoElem";
            this.mrcNuevoElem.Size = new System.Drawing.Size(208, 212);
            this.mrcNuevoElem.TabIndex = 42;
            this.mrcNuevoElem.TabStop = false;
            this.mrcNuevoElem.Text = "Nuevo Elemento";
            // 
            // cmbDestino
            // 
            this.cmbDestino.FormattingEnabled = true;
            this.cmbDestino.Location = new System.Drawing.Point(76, 65);
            this.cmbDestino.Name = "cmbDestino";
            this.cmbDestino.Size = new System.Drawing.Size(129, 21);
            this.cmbDestino.TabIndex = 44;
            // 
            // cmbOrigen
            // 
            this.cmbOrigen.FormattingEnabled = true;
            this.cmbOrigen.Location = new System.Drawing.Point(76, 28);
            this.cmbOrigen.Name = "cmbOrigen";
            this.cmbOrigen.Size = new System.Drawing.Size(129, 21);
            this.cmbOrigen.TabIndex = 43;
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(110, 156);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(72, 36);
            this.btnCargar.TabIndex = 7;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnBorrarTodo
            // 
            this.btnBorrarTodo.Location = new System.Drawing.Point(15, 156);
            this.btnBorrarTodo.Name = "btnBorrarTodo";
            this.btnBorrarTodo.Size = new System.Drawing.Size(72, 36);
            this.btnBorrarTodo.TabIndex = 6;
            this.btnBorrarTodo.Text = "Borrar Todo";
            this.btnBorrarTodo.UseVisualStyleBackColor = true;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(65, 100);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(125, 20);
            this.txtPrecio.TabIndex = 5;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(12, 103);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(40, 13);
            this.lblPrecio.TabIndex = 2;
            this.lblPrecio.Text = "Precio:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 65);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(46, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Destino:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(16, 30);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(41, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Origen:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.btnVerViajes);
            this.groupBox1.Controls.Add(this.btnListarOrigenes);
            this.groupBox1.Controls.Add(this.cmbHasta);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnListar);
            this.groupBox1.Controls.Add(this.cmbDesde);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(9, 227);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(675, 277);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listar Viajes";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 93);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(632, 177);
            this.dataGridView1.TabIndex = 50;
            // 
            // btnVerViajes
            // 
            this.btnVerViajes.Location = new System.Drawing.Point(500, 23);
            this.btnVerViajes.Name = "btnVerViajes";
            this.btnVerViajes.Size = new System.Drawing.Size(142, 37);
            this.btnVerViajes.TabIndex = 49;
            this.btnVerViajes.Text = "Ver todos los viajes";
            this.btnVerViajes.UseVisualStyleBackColor = true;
            // 
            // btnListarOrigenes
            // 
            this.btnListarOrigenes.Location = new System.Drawing.Point(399, 20);
            this.btnListarOrigenes.Name = "btnListarOrigenes";
            this.btnListarOrigenes.Size = new System.Drawing.Size(82, 40);
            this.btnListarOrigenes.TabIndex = 48;
            this.btnListarOrigenes.Text = "Listar Origenes";
            this.btnListarOrigenes.UseVisualStyleBackColor = true;
            // 
            // cmbHasta
            // 
            this.cmbHasta.FormattingEnabled = true;
            this.cmbHasta.Location = new System.Drawing.Point(304, 32);
            this.cmbHasta.Name = "cmbHasta";
            this.cmbHasta.Size = new System.Drawing.Size(72, 21);
            this.cmbHasta.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "Hasta:";
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(155, 20);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(63, 40);
            this.btnListar.TabIndex = 45;
            this.btnListar.Text = "Listar Destinos";
            this.btnListar.UseVisualStyleBackColor = true;
            // 
            // cmbDesde
            // 
            this.cmbDesde.FormattingEnabled = true;
            this.cmbDesde.Location = new System.Drawing.Point(62, 28);
            this.cmbDesde.Name = "cmbDesde";
            this.cmbDesde.Size = new System.Drawing.Size(80, 21);
            this.cmbDesde.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Desde:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(9, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(243, 191);
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // frmGrafo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 506);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mrcEliminar);
            this.Controls.Add(this.mrcNuevoElem);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmGrafo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estructura Grafo";
            this.Load += new System.EventHandler(this.frmGrafo_Load);
            this.mrcEliminar.ResumeLayout(false);
            this.mrcEliminar.PerformLayout();
            this.mrcNuevoElem.ResumeLayout(false);
            this.mrcNuevoElem.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.GroupBox mrcEliminar;
        private System.Windows.Forms.ComboBox cmbOrigenConsulta;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox mrcNuevoElem;
        private System.Windows.Forms.Button btnBorrarTodo;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtPrecioConsulta;
        private System.Windows.Forms.ComboBox cmbDestinoConsulta;
        private System.Windows.Forms.ComboBox cmbDestino;
        private System.Windows.Forms.ComboBox cmbOrigen;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnVerViajes;
        private System.Windows.Forms.Button btnListarOrigenes;
        private System.Windows.Forms.ComboBox cmbHasta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.ComboBox cmbDesde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}