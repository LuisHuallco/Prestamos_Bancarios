namespace PrestamosBanco.Views
{
    partial class frm_MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_MenuPrincipal));
            btnPrestamos = new Button();
            btnCuentas = new Button();
            btnClientes = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnPrestamos
            // 
            btnPrestamos.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrestamos.Location = new Point(721, 356);
            btnPrestamos.Margin = new Padding(5);
            btnPrestamos.Name = "btnPrestamos";
            btnPrestamos.Size = new Size(270, 90);
            btnPrestamos.TabIndex = 6;
            btnPrestamos.Text = "💰 Prestamos";
            btnPrestamos.UseVisualStyleBackColor = true;
            btnPrestamos.Click += btnPrestamos_Click;
            // 
            // btnCuentas
            // 
            btnCuentas.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCuentas.Location = new Point(388, 225);
            btnCuentas.Margin = new Padding(5);
            btnCuentas.Name = "btnCuentas";
            btnCuentas.Size = new Size(270, 90);
            btnCuentas.TabIndex = 5;
            btnCuentas.Text = "💼 Cuentas";
            btnCuentas.UseVisualStyleBackColor = true;
            btnCuentas.Click += btnCuentas_Click;
            // 
            // btnClientes
            // 
            btnClientes.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClientes.Location = new Point(62, 93);
            btnClientes.Margin = new Padding(5);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(270, 90);
            btnClientes.TabIndex = 4;
            btnClientes.Text = " 👥 Clientes";
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += btnClientes_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1114, 545);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // frm_MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1114, 545);
            Controls.Add(btnPrestamos);
            Controls.Add(btnCuentas);
            Controls.Add(btnClientes);
            Controls.Add(pictureBox1);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "frm_MenuPrincipal";
            Text = "frm_MenuPrincipal";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnPrestamos;
        private Button btnCuentas;
        private Button btnClientes;
        private PictureBox pictureBox1;
    }
}