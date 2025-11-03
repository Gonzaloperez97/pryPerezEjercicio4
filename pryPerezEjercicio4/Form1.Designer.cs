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
            colMozos = new DataGridViewTextBoxColumn();
            colComida = new DataGridViewTextBoxColumn();
            colBebidaSin = new DataGridViewTextBoxColumn();
            colBebidas = new DataGridViewTextBoxColumn();
            colPostres = new DataGridViewTextBoxColumn();
            btnCerrar = new Button();
            btnValidar = new Button();
            btnMozoDelDia = new Button();
            btnTotales = new Button();
            lblImportesVentas = new Label();
            lblMozoDelDia = new Label();
            lblTotalGeneral = new Label();
            lblMozoResultado = new Label();
            txtTotalGeneral = new TextBox();
            lblTotalComidas = new Label();
            label2 = new Label();
            lblBebidasSinAlcohol = new Label();
            lblPostres = new Label();
            lblBebidasConAlcohol = new Label();
            txtTotalComidas = new TextBox();
            txtTotalBebidasCon = new TextBox();
            txtTotalBebidasSin = new TextBox();
            txtTotalPostres = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            SuspendLayout();
            // 
            // dgvVentas
            // 
            dgvVentas.AllowUserToAddRows = false;
            dgvVentas.AllowUserToDeleteRows = false;
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentas.Columns.AddRange(new DataGridViewColumn[] { colMozos, colComida, colBebidaSin, colBebidas, colPostres });
            dgvVentas.Location = new Point(12, 23);
            dgvVentas.Name = "dgvVentas";
            dgvVentas.Size = new Size(521, 256);
            dgvVentas.TabIndex = 0;
            // 
            // colMozos
            // 
            colMozos.HeaderText = "Mozos";
            colMozos.Name = "colMozos";
            colMozos.ReadOnly = true;
            // 
            // colComida
            // 
            colComida.HeaderText = "Comida";
            colComida.Name = "colComida";
            // 
            // colBebidaSin
            // 
            colBebidaSin.HeaderText = "Bebida sin alcohol";
            colBebidaSin.Name = "colBebidaSin";
            // 
            // colBebidas
            // 
            colBebidas.HeaderText = "Bebidas";
            colBebidas.Name = "colBebidas";
            // 
            // colPostres
            // 
            colPostres.HeaderText = "Postres";
            colPostres.Name = "colPostres";
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(458, 446);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(75, 23);
            btnCerrar.TabIndex = 1;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnValidar
            // 
            btnValidar.Location = new Point(12, 285);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(75, 23);
            btnValidar.TabIndex = 2;
            btnValidar.Text = "Validar Datos";
            btnValidar.UseVisualStyleBackColor = true;
            btnValidar.Click += btnValidar_Click;
            // 
            // btnMozoDelDia
            // 
            btnMozoDelDia.Location = new Point(445, 285);
            btnMozoDelDia.Name = "btnMozoDelDia";
            btnMozoDelDia.Size = new Size(88, 23);
            btnMozoDelDia.TabIndex = 3;
            btnMozoDelDia.Text = "Mozo del Día";
            btnMozoDelDia.UseVisualStyleBackColor = true;
            btnMozoDelDia.Click += btnMozoDelDia_Click;
            // 
            // btnTotales
            // 
            btnTotales.Location = new Point(98, 285);
            btnTotales.Name = "btnTotales";
            btnTotales.Size = new Size(75, 23);
            btnTotales.TabIndex = 4;
            btnTotales.Text = "Totales";
            btnTotales.UseVisualStyleBackColor = true;
            btnTotales.Click += btnTotales_Click;
            // 
            // lblImportesVentas
            // 
            lblImportesVentas.AutoSize = true;
            lblImportesVentas.Location = new Point(12, 5);
            lblImportesVentas.Name = "lblImportesVentas";
            lblImportesVentas.Size = new Size(161, 15);
            lblImportesVentas.TabIndex = 5;
            lblImportesVentas.Text = "Ingrese los importes de venta";
            // 
            // lblMozoDelDia
            // 
            lblMozoDelDia.AutoSize = true;
            lblMozoDelDia.Location = new Point(422, 340);
            lblMozoDelDia.Name = "lblMozoDelDia";
            lblMozoDelDia.Size = new Size(76, 15);
            lblMozoDelDia.TabIndex = 6;
            lblMozoDelDia.Text = "Mozo del Día";
            // 
            // lblTotalGeneral
            // 
            lblTotalGeneral.AutoSize = true;
            lblTotalGeneral.Location = new Point(15, 454);
            lblTotalGeneral.Name = "lblTotalGeneral";
            lblTotalGeneral.Size = new Size(75, 15);
            lblTotalGeneral.TabIndex = 7;
            lblTotalGeneral.Text = "Total General";
            // 
            // lblMozoResultado
            // 
            lblMozoResultado.AutoSize = true;
            lblMozoResultado.Location = new Point(504, 340);
            lblMozoResultado.Name = "lblMozoResultado";
            lblMozoResultado.Size = new Size(38, 15);
            lblMozoResultado.TabIndex = 8;
            lblMozoResultado.Text = "\"...... \"";
            // 
            // txtTotalGeneral
            // 
            txtTotalGeneral.Location = new Point(153, 451);
            txtTotalGeneral.Name = "txtTotalGeneral";
            txtTotalGeneral.ReadOnly = true;
            txtTotalGeneral.Size = new Size(100, 23);
            txtTotalGeneral.TabIndex = 9;
            // 
            // lblTotalComidas
            // 
            lblTotalComidas.AutoSize = true;
            lblTotalComidas.Location = new Point(15, 340);
            lblTotalComidas.Name = "lblTotalComidas";
            lblTotalComidas.Size = new Size(82, 15);
            lblTotalComidas.TabIndex = 10;
            lblTotalComidas.Text = "Total Comidas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 358);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 11;
            // 
            // lblBebidasSinAlcohol
            // 
            lblBebidasSinAlcohol.AutoSize = true;
            lblBebidasSinAlcohol.Location = new Point(15, 396);
            lblBebidasSinAlcohol.Name = "lblBebidasSinAlcohol";
            lblBebidasSinAlcohol.Size = new Size(111, 15);
            lblBebidasSinAlcohol.TabIndex = 12;
            lblBebidasSinAlcohol.Text = "Bebidas Sin Alcohol";
            // 
            // lblPostres
            // 
            lblPostres.AutoSize = true;
            lblPostres.Location = new Point(15, 425);
            lblPostres.Name = "lblPostres";
            lblPostres.Size = new Size(45, 15);
            lblPostres.TabIndex = 13;
            lblPostres.Text = "Postres";
            // 
            // lblBebidasConAlcohol
            // 
            lblBebidasConAlcohol.AutoSize = true;
            lblBebidasConAlcohol.Location = new Point(15, 369);
            lblBebidasConAlcohol.Name = "lblBebidasConAlcohol";
            lblBebidasConAlcohol.Size = new Size(115, 15);
            lblBebidasConAlcohol.TabIndex = 14;
            lblBebidasConAlcohol.Text = "Bebidas con Alcohol";
            // 
            // txtTotalComidas
            // 
            txtTotalComidas.Location = new Point(153, 337);
            txtTotalComidas.Name = "txtTotalComidas";
            txtTotalComidas.ReadOnly = true;
            txtTotalComidas.Size = new Size(100, 23);
            txtTotalComidas.TabIndex = 15;
            // 
            // txtTotalBebidasCon
            // 
            txtTotalBebidasCon.Location = new Point(153, 366);
            txtTotalBebidasCon.Name = "txtTotalBebidasCon";
            txtTotalBebidasCon.ReadOnly = true;
            txtTotalBebidasCon.Size = new Size(100, 23);
            txtTotalBebidasCon.TabIndex = 16;
            // 
            // txtTotalBebidasSin
            // 
            txtTotalBebidasSin.Location = new Point(153, 393);
            txtTotalBebidasSin.Name = "txtTotalBebidasSin";
            txtTotalBebidasSin.ReadOnly = true;
            txtTotalBebidasSin.Size = new Size(100, 23);
            txtTotalBebidasSin.TabIndex = 17;
            // 
            // txtTotalPostres
            // 
            txtTotalPostres.Location = new Point(153, 422);
            txtTotalPostres.Name = "txtTotalPostres";
            txtTotalPostres.ReadOnly = true;
            txtTotalPostres.Size = new Size(100, 23);
            txtTotalPostres.TabIndex = 18;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 497);
            Controls.Add(txtTotalPostres);
            Controls.Add(txtTotalBebidasSin);
            Controls.Add(txtTotalBebidasCon);
            Controls.Add(txtTotalComidas);
            Controls.Add(lblBebidasConAlcohol);
            Controls.Add(lblPostres);
            Controls.Add(lblBebidasSinAlcohol);
            Controls.Add(label2);
            Controls.Add(lblTotalComidas);
            Controls.Add(txtTotalGeneral);
            Controls.Add(lblMozoResultado);
            Controls.Add(lblTotalGeneral);
            Controls.Add(lblMozoDelDia);
            Controls.Add(lblImportesVentas);
            Controls.Add(btnTotales);
            Controls.Add(btnMozoDelDia);
            Controls.Add(btnValidar);
            Controls.Add(btnCerrar);
            Controls.Add(dgvVentas);
            Name = "Form1";
            Text = "Ventas La Milanga";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvVentas;
        private Button btnCerrar;
        private Button btnValidar;
        private Button btnMozoDelDia;
        private Button btnTotales;
        private Label lblImportesVentas;
        private Label lblMozoDelDia;
        private Label lblTotalGeneral;
        private Label lblMozoResultado;
        private TextBox txtTotalGeneral;
        private DataGridViewTextBoxColumn colMozos;
        private DataGridViewTextBoxColumn colComida;
        private DataGridViewTextBoxColumn colBebidaSin;
        private DataGridViewTextBoxColumn colBebidas;
        private DataGridViewTextBoxColumn colPostres;
        private Label lblTotalComidas;
        private Label label2;
        private Label lblBebidasSinAlcohol;
        private Label lblPostres;
        private Label lblBebidasConAlcohol;
        private TextBox txtTotalComidas;
        private TextBox txtTotalBebidasCon;
        private TextBox txtTotalBebidasSin;
        private TextBox txtTotalPostres;
    }
}
