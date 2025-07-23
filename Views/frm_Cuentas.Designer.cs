namespace PrestamosBanco.Views
{
    partial class frm_Cuentas
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
            lblSaldo = new Label();
            txtSaldo = new TextBox();
            btnCancelar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            btnGuardar = new Button();
            dgvCuentas = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCuentas).BeginInit();
            SuspendLayout();
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCliente.Location = new Point(29, 96);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(95, 31);
            lblCliente.TabIndex = 0;
            lblCliente.Tag = "";
            lblCliente.Text = "Cliente:";
            // 
            // cbClientes
            // 
            cbClientes.FormattingEnabled = true;
            cbClientes.Location = new Point(29, 131);
            cbClientes.Name = "cbClientes";
            cbClientes.Size = new Size(278, 39);
            cbClientes.TabIndex = 1;
            // 
            // lblSaldo
            // 
            lblSaldo.AutoSize = true;
            lblSaldo.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSaldo.Location = new Point(29, 221);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(80, 31);
            lblSaldo.TabIndex = 2;
            lblSaldo.Text = "Saldo:";
            // 
            // txtSaldo
            // 
            txtSaldo.Location = new Point(29, 256);
            txtSaldo.Name = "txtSaldo";
            txtSaldo.Size = new Size(278, 39);
            txtSaldo.TabIndex = 3;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnCancelar.Location = new Point(595, 393);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(232, 76);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnEliminar.Location = new Point(333, 393);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(232, 76);
            btnEliminar.TabIndex = 10;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnLimpiar.Location = new Point(858, 393);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(232, 76);
            btnLimpiar.TabIndex = 9;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnGuardar.Location = new Point(76, 393);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(232, 76);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // dgvCuentas
            // 
            dgvCuentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCuentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCuentas.Location = new Point(344, 70);
            dgvCuentas.Name = "dgvCuentas";
            dgvCuentas.RowHeadersWidth = 51;
            dgvCuentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCuentas.Size = new Size(810, 278);
            dgvCuentas.TabIndex = 12;
            dgvCuentas.CellClick += dgvCuentas_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(466, 9);
            label1.Name = "label1";
            label1.Size = new Size(287, 41);
            label1.TabIndex = 13;
            label1.Tag = "";
            label1.Text = "Gestion de Cuentas";
            // 
            // frm_Cuentas
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1166, 525);
            Controls.Add(label1);
            Controls.Add(dgvCuentas);
            Controls.Add(btnCancelar);
            Controls.Add(btnEliminar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnGuardar);
            Controls.Add(txtSaldo);
            Controls.Add(lblSaldo);
            Controls.Add(cbClientes);
            Controls.Add(lblCliente);
            Font = new Font("Segoe UI", 14F);
            Margin = new Padding(5);
            Name = "frm_Cuentas";
            Text = "frm_Cuentas";
            Load += frm_Cuentas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCuentas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCliente;
        private ComboBox cbClientes;
        private Label lblSaldo;
        private TextBox txtSaldo;
        private Button btnCancelar;
        private Button btnEliminar;
        private Button btnLimpiar;
        private Button btnGuardar;
        private DataGridView dgvCuentas;
        private Label label1;
    }
}