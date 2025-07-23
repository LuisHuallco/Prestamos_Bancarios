namespace PrestamosBanco.Views
{
    partial class frm_Clientes
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
            lblNombre = new Label();
            txtNombre = new TextBox();
            txtTelefono = new TextBox();
            lblTelefono = new Label();
            btnGuardar = new Button();
            btnLimpiar = new Button();
            btnEliminar = new Button();
            btnCancelar = new Button();
            dgvClientes = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.ForeColor = SystemColors.ActiveCaptionText;
            lblNombre.Location = new Point(46, 104);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(115, 31);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(46, 139);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(335, 39);
            txtNombre.TabIndex = 1;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(46, 244);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(335, 39);
            txtTelefono.TabIndex = 3;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTelefono.Location = new Point(46, 209);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(123, 31);
            lblTelefono.TabIndex = 2;
            lblTelefono.Text = "Teléfono:";
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnGuardar.Location = new Point(192, 368);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(167, 62);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnLimpiar.Location = new Point(711, 368);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(167, 62);
            btnLimpiar.TabIndex = 5;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnEliminar.Location = new Point(365, 368);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(167, 62);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnCancelar.Location = new Point(538, 368);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(167, 62);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click_1;
            // 
            // dgvClientes
            // 
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClientes.BackgroundColor = Color.Gray;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(400, 87);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.Size = new Size(574, 242);
            dgvClientes.TabIndex = 8;
            dgvClientes.CellClick += dgvClientes_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(400, 18);
            label1.Name = "label1";
            label1.Size = new Size(306, 45);
            label1.TabIndex = 9;
            label1.Text = "Gestion de Clientes";
            // 
            // frm_Clientes
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1041, 466);
            Controls.Add(label1);
            Controls.Add(dgvClientes);
            Controls.Add(btnCancelar);
            Controls.Add(btnEliminar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnGuardar);
            Controls.Add(txtTelefono);
            Controls.Add(lblTelefono);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Font = new Font("Segoe UI", 14F);
            ForeColor = SystemColors.ActiveCaptionText;
            Margin = new Padding(5);
            Name = "frm_Clientes";
            Text = "frm_Clientes";
            Load += frm_Clientes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private TextBox txtNombre;
        private TextBox txtTelefono;
        private Label lblTelefono;
        private Button btnGuardar;
        private Button btnLimpiar;
        private Button btnEliminar;
        private Button btnCancelar;
        private DataGridView dgvClientes;
        private Label label1;
    }
}