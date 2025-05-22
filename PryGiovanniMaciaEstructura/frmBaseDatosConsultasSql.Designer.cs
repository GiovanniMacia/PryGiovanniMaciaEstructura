namespace PryGiovanniMaciaEstructura
{
    partial class frmBaseDatosConsultasSql
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
            this.dgvMostrarConsulta = new System.Windows.Forms.DataGridView();
            this.btnListar = new System.Windows.Forms.Button();
            this.txtQuery = new System.Windows.Forms.TextBox();
            this.lblConsultas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMostrarConsulta
            // 
            this.dgvMostrarConsulta.AllowUserToAddRows = false;
            this.dgvMostrarConsulta.AllowUserToDeleteRows = false;
            this.dgvMostrarConsulta.AllowUserToResizeColumns = false;
            this.dgvMostrarConsulta.AllowUserToResizeRows = false;
            this.dgvMostrarConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrarConsulta.Location = new System.Drawing.Point(54, 249);
            this.dgvMostrarConsulta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvMostrarConsulta.Name = "dgvMostrarConsulta";
            this.dgvMostrarConsulta.ReadOnly = true;
            this.dgvMostrarConsulta.RowHeadersWidth = 51;
            this.dgvMostrarConsulta.RowTemplate.Height = 24;
            this.dgvMostrarConsulta.Size = new System.Drawing.Size(835, 307);
            this.dgvMostrarConsulta.TabIndex = 7;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(808, 219);
            this.btnListar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(56, 26);
            this.btnListar.TabIndex = 6;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // txtQuery
            // 
            this.txtQuery.Location = new System.Drawing.Point(31, 49);
            this.txtQuery.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtQuery.Multiline = true;
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Size = new System.Drawing.Size(834, 166);
            this.txtQuery.TabIndex = 5;
            // 
            // lblConsultas
            // 
            this.lblConsultas.AutoSize = true;
            this.lblConsultas.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultas.Location = new System.Drawing.Point(26, 11);
            this.lblConsultas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblConsultas.Name = "lblConsultas";
            this.lblConsultas.Size = new System.Drawing.Size(204, 31);
            this.lblConsultas.TabIndex = 4;
            this.lblConsultas.Text = "Consulta SQL:";
            // 
            // frmBaseDatosConsultasSql
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 566);
            this.Controls.Add(this.dgvMostrarConsulta);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.txtQuery);
            this.Controls.Add(this.lblConsultas);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmBaseDatosConsultasSql";
            this.Text = "Base Datos Consultas Sql";
            this.Load += new System.EventHandler(this.frmBaseDatosConsultasSql_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMostrarConsulta;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.TextBox txtQuery;
        private System.Windows.Forms.Label lblConsultas;
    }
}