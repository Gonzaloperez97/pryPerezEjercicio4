namespace pryPerezEjercicio4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvVentas = new DataGridView();
            btnCerrar = new Button();
            btnValidar = new Button();
            MozoDelDia = new Button();
            btnTotales = new Button();
            lblImportesVentas = new Label();
            lblMozoDelDia = new Label();
            lblTotalGeneral = new Label();
            lblMozoResultado = new Label();
            txtTotalGeneral = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            SuspendLayout();
            // 
            // dgvVentas
            // 
            dgvVentas.AllowUserToAddRows = false;
            dgvVentas.AllowUserToDeleteRows = false;
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentas.Location = new Point(21, 43);
            dgvVentas.Name = "dgvVentas";
            dgvVentas.Size = new Size(521, 256);
            dgvVentas.TabIndex = 0;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(21, 390);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(75, 23);
            btnCerrar.TabIndex = 1;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            // 
            // btnValidar
            // 
            btnValidar.Location = new Point(161, 390);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(75, 23);
            btnValidar.TabIndex = 2;
            btnValidar.Text = "Validar Datos";
            btnValidar.UseVisualStyleBackColor = true;
            // 
            // MozoDelDia
            // 
            MozoDelDia.Location = new Point(306, 390);
            MozoDelDia.Name = "MozoDelDia";
            MozoDelDia.Size = new Size(88, 23);
            MozoDelDia.TabIndex = 3;
            MozoDelDia.Text = "Mozo del Día";
            MozoDelDia.UseVisualStyleBackColor = true;
            // 
            // btnTotales
            // 
            btnTotales.Location = new Point(467, 390);
            btnTotales.Name = "btnTotales";
            btnTotales.Size = new Size(75, 23);
            btnTotales.TabIndex = 4;
            btnTotales.Text = "Totales";
            btnTotales.UseVisualStyleBackColor = true;
            // 
            // lblImportesVentas
            // 
            lblImportesVentas.AutoSize = true;
            lblImportesVentas.Location = new Point(21, 25);
            lblImportesVentas.Name = "lblImportesVentas";
            lblImportesVentas.Size = new Size(161, 15);
            lblImportesVentas.TabIndex = 5;
            lblImportesVentas.Text = "Ingrese los importes de venta";
            // 
            // lblMozoDelDia
            // 
            lblMozoDelDia.AutoSize = true;
            lblMozoDelDia.Location = new Point(21, 314);
            lblMozoDelDia.Name = "lblMozoDelDia";
            lblMozoDelDia.Size = new Size(76, 15);
            lblMozoDelDia.TabIndex = 6;
            lblMozoDelDia.Text = "Mozo del Día";
            // 
            // lblTotalGeneral
            // 
            lblTotalGeneral.AutoSize = true;
            lblTotalGeneral.Location = new Point(21, 351);
            lblTotalGeneral.Name = "lblTotalGeneral";
            lblTotalGeneral.Size = new Size(75, 15);
            lblTotalGeneral.TabIndex = 7;
            lblTotalGeneral.Text = "Total General";
            // 
            // lblMozoResultado
            // 
            lblMozoResultado.AutoSize = true;
            lblMozoResultado.Location = new Point(112, 314);
            lblMozoResultado.Name = "lblMozoResultado";
            lblMozoResultado.Size = new Size(38, 15);
            lblMozoResultado.TabIndex = 8;
            lblMozoResultado.Text = "\"...... \"";
            // 
            // txtTotalGeneral
            // 
            txtTotalGeneral.Location = new Point(112, 348);
            txtTotalGeneral.Name = "txtTotalGeneral";
            txtTotalGeneral.ReadOnly = true;
            txtTotalGeneral.Size = new Size(100, 23);
            txtTotalGeneral.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtTotalGeneral);
            Controls.Add(lblMozoResultado);
            Controls.Add(lblTotalGeneral);
            Controls.Add(lblMozoDelDia);
            Controls.Add(lblImportesVentas);
            Controls.Add(btnTotales);
            Controls.Add(MozoDelDia);
            Controls.Add(btnValidar);
            Controls.Add(btnCerrar);
            Controls.Add(dgvVentas);
            Name = "Form1";
            Text = "Ventas La Milanga";
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvVentas;
        private Button btnCerrar;
        private Button btnValidar;
        private Button MozoDelDia;
        private Button btnTotales;
        private Label lblImportesVentas;
        private Label lblMozoDelDia;
        private Label lblTotalGeneral;
        private Label lblMozoResultado;
        private TextBox txtTotalGeneral;
    }
}
