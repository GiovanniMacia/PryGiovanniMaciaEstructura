namespace PryGiovanniMaciaEstructura
{
    partial class frmVariasOperaciones
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
            this.dgvOperaciones = new System.Windows.Forms.DataGridView();
            this.txtOperacionResultado = new System.Windows.Forms.TextBox();
            this.lblOperaciones = new System.Windows.Forms.Label();
            this.cmbOperacion = new System.Windows.Forms.ComboBox();
            this.btnListar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOperaciones
            // 
            this.dgvOperaciones.AllowUserToAddRows = false;
            this.dgvOperaciones.AllowUserToDeleteRows = false;
            this.dgvOperaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOperaciones.Location = new System.Drawing.Point(52, 251);
            this.dgvOperaciones.Name = "dgvOperaciones";
            this.dgvOperaciones.ReadOnly = true;
            this.dgvOperaciones.RowHeadersWidth = 51;
            this.dgvOperaciones.RowTemplate.Height = 24;
            this.dgvOperaciones.Size = new System.Drawing.Size(1115, 397);
            this.dgvOperaciones.TabIndex = 9;
            // 
            // txtOperacionResultado
            // 
            this.txtOperacionResultado.Location = new System.Drawing.Point(52, 64);
            this.txtOperacionResultado.Multiline = true;
            this.txtOperacionResultado.Name = "txtOperacionResultado";
            this.txtOperacionResultado.ReadOnly = true;
            this.txtOperacionResultado.Size = new System.Drawing.Size(1115, 162);
            this.txtOperacionResultado.TabIndex = 8;
            // 
            // lblOperaciones
            // 
            this.lblOperaciones.AutoSize = true;
            this.lblOperaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperaciones.Location = new System.Drawing.Point(5, 16);
            this.lblOperaciones.Name = "lblOperaciones";
            this.lblOperaciones.Size = new System.Drawing.Size(368, 25);
            this.lblOperaciones.TabIndex = 7;
            this.lblOperaciones.Text = "Operación a realizar en la base de datos:";
            // 
            // cmbOperacion
            // 
            this.cmbOperacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOperacion.FormattingEnabled = true;
            this.cmbOperacion.Location = new System.Drawing.Point(444, 16);
            this.cmbOperacion.Name = "cmbOperacion";
            this.cmbOperacion.Size = new System.Drawing.Size(524, 24);
            this.cmbOperacion.TabIndex = 6;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(1022, 16);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(103, 25);
            this.btnListar.TabIndex = 5;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            // 
            // frmVariasOperaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 717);
            this.Controls.Add(this.dgvOperaciones);
            this.Controls.Add(this.txtOperacionResultado);
            this.Controls.Add(this.lblOperaciones);
            this.Controls.Add(this.cmbOperacion);
            this.Controls.Add(this.btnListar);
            this.Name = "frmVariasOperaciones";
            this.Text = "frmVariasOperaciones";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOperaciones;
        private System.Windows.Forms.TextBox txtOperacionResultado;
        private System.Windows.Forms.Label lblOperaciones;
        private System.Windows.Forms.ComboBox cmbOperacion;
        private System.Windows.Forms.Button btnListar;
    }
}