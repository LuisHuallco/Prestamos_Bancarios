namespace PrestamosBanco.Views
{
    partial class frm_Prestamos
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
            lblCliente = new Label();
            cbClientes = new ComboBox();
            txtMonto = new TextBox();
            lblMonto = new Label();
            lblInteres = new Label();
            txtInteres = new TextBox();
            lblPlazo = new Label();
            txtPlazo = new TextBox();
            lblTotal = new Label();
            lblResultado = new Label();
            btnCancelar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            btnGuardar = new Button();
            dgvPrestamos = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPrestamos).BeginInit();
            SuspendLayout();
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCliente.Location = new Point(28, 45);
            lblCliente.Margin = new Padding(2, 0, 2, 0);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(83, 28);
            lblCliente.TabIndex = 0;
            lblCliente.Text = "Cliente:";
            // 
            // cbClientes
            // 
            cbClientes.Font = new Font("Segoe UI", 12F);
            cbClientes.FormattingEnabled = true;
            cbClientes.Location = new Point(28, 74);
            cbClientes.Margin = new Padding(2);
            cbClientes.Name = "cbClientes";
            cbClientes.Size = new Size(249, 36);
            cbClientes.TabIndex = 1;
            // 
            // txtMonto
            // 
            txtMonto.Font = new Font("Segoe UI", 12F);
            txtMonto.Location = new Point(28, 146);
            txtMonto.Margin = new Padding(2);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(249, 34);
            txtMonto.TabIndex = 2;
            txtMonto.TextChanged += txtMonto_TextChanged;
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMonto.Location = new Point(28, 116);
            lblMonto.Margin = new Padding(2, 0, 2, 0);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(80, 28);
            lblMonto.TabIndex = 3;
            lblMonto.Text = "Monto:";
            // 
            // lblInteres
            // 
            lblInteres.AutoSize = true;
            lblInteres.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInteres.Location = new Point(28, 191);
            lblInteres.Margin = new Padding(2, 0, 2, 0);
            lblInteres.Name = "lblInteres";
            lblInteres.Size = new Size(119, 28);
            lblInteres.TabIndex = 5;
            lblInteres.Text = "Interés (%):";
            // 
            // txtInteres
            // 
            txtInteres.Font = new Font("Segoe UI", 12F);
            txtInteres.Location = new Point(28, 221);
            txtInteres.Margin = new Padding(2);
            txtInteres.Name = "txtInteres";
            txtInteres.Size = new Size(249, 34);
            txtInteres.TabIndex = 4;
            txtInteres.TextChanged += txtInteres_TextChanged;
            // 
            // lblPlazo
            // 
            lblPlazo.AutoSize = true;
            lblPlazo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPlazo.Location = new Point(28, 264);
            lblPlazo.Margin = new Padding(2, 0, 2, 0);
            lblPlazo.Name = "lblPlazo";
            lblPlazo.Size = new Size(146, 28);
            lblPlazo.TabIndex = 7;
            lblPlazo.Text = "Plazo (meses):\n";
            // 
            // txtPlazo
            // 
            txtPlazo.Font = new Font("Segoe UI", 12F);
            txtPlazo.Location = new Point(28, 294);
            txtPlazo.Margin = new Padding(2);
            txtPlazo.Name = "txtPlazo";
            txtPlazo.Size = new Size(249, 34);
            txtPlazo.TabIndex = 6;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 12F);
            lblTotal.Location = new Point(40, 411);
            lblTotal.Margin = new Padding(2, 0, 2, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(129, 28);
            lblTotal.TabIndex = 8;
            lblTotal.Text = "Total a pagar:\n";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResultado.Location = new Point(173, 411);
            lblResultado.Margin = new Padding(2, 0, 2, 0);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(132, 31);
            lblResultado.TabIndex = 9;
            lblResultado.Text = "(se calcula)\n";
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCancelar.Location = new Point(766, 394);
            btnCancelar.Margin = new Padding(2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(153, 63);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnEliminar.Location = new Point(583, 394);
            btnEliminar.Margin = new Padding(2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(153, 63);
            btnEliminar.TabIndex = 14;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnLimpiar.Location = new Point(948, 394);
            btnLimpiar.Margin = new Padding(2);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(153, 63);
            btnLimpiar.TabIndex = 13;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnGuardar.Location = new Point(401, 394);
            btnGuardar.Margin = new Padding(2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(153, 63);
            btnGuardar.TabIndex = 12;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // dgvPrestamos
            // 
            dgvPrestamos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPrestamos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPrestamos.Location = new Point(292, 70);
            dgvPrestamos.Margin = new Padding(2);
            dgvPrestamos.Name = "dgvPrestamos";
            dgvPrestamos.RowHeadersWidth = 51;
            dgvPrestamos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPrestamos.Size = new Size(908, 304);
            dgvPrestamos.TabIndex = 16;
            dgvPrestamos.CellClick += dgvPrestamos_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(452, 9);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(333, 41);
            label1.TabIndex = 17;
            label1.Text = "Gestion de Prestamos";
            // 
            // frm_Prestamos
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1211, 482);
            Controls.Add(label1);
            Controls.Add(dgvPrestamos);
            Controls.Add(btnCancelar);
            Controls.Add(btnEliminar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnGuardar);
            Controls.Add(lblResultado);
            Controls.Add(lblTotal);
            Controls.Add(txtPlazo);
            Controls.Add(txtInteres);
            Controls.Add(txtMonto);
            Controls.Add(cbClientes);
            Controls.Add(lblMonto);
            Controls.Add(lblCliente);
            Controls.Add(lblInteres);
            Controls.Add(lblPlazo);
            Font = new Font("Segoe UI", 10F);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frm_Prestamos";
            Text = "frm_Prestamos";
            Load += frm_Prestamos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPrestamos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCliente;
        private ComboBox cbClientes;
        private TextBox txtMonto;
        private Label lblMonto;
        private Label lblInteres;
        private TextBox txtInteres;
        private Label lblPlazo;
        private TextBox txtPlazo;
        private Label lblTotal;
        private Label lblResultado;
        private Button btnCancelar;
        private Button btnEliminar;
        private Button btnLimpiar;
        private Button btnGuardar;
        private DataGridView dgvPrestamos;
        private Label label1;
    }
}