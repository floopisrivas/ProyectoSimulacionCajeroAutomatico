namespace Cajero
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.lblUsuarioLogin = new System.Windows.Forms.Label();
            this.flpMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDeposito = new System.Windows.Forms.Button();
            this.btnExtraccion = new System.Windows.Forms.Button();
            this.btnPagoServicio = new System.Windows.Forms.Button();
            this.btnRecargaTelefonica = new System.Windows.Forms.Button();
            this.btnMovimientos = new System.Windows.Forms.Button();
            this.btnTransferencia = new System.Windows.Forms.Button();
            this.pnlSuperior.SuspendLayout();
            this.flpMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSuperior
            // 
            this.pnlSuperior.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlSuperior.Controls.Add(this.lblUsuarioLogin);
            this.pnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Size = new System.Drawing.Size(787, 48);
            this.pnlSuperior.TabIndex = 0;
            // 
            // lblUsuarioLogin
            // 
            this.lblUsuarioLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsuarioLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioLogin.ForeColor = System.Drawing.Color.White;
            this.lblUsuarioLogin.Location = new System.Drawing.Point(12, 4);
            this.lblUsuarioLogin.Name = "lblUsuarioLogin";
            this.lblUsuarioLogin.Size = new System.Drawing.Size(763, 39);
            this.lblUsuarioLogin.TabIndex = 0;
            this.lblUsuarioLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // flpMenu
            // 
            this.flpMenu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flpMenu.Controls.Add(this.btnDeposito);
            this.flpMenu.Controls.Add(this.btnExtraccion);
            this.flpMenu.Controls.Add(this.btnPagoServicio);
            this.flpMenu.Controls.Add(this.btnRecargaTelefonica);
            this.flpMenu.Controls.Add(this.btnMovimientos);
            this.flpMenu.Controls.Add(this.btnTransferencia);
            this.flpMenu.Location = new System.Drawing.Point(5, 76);
            this.flpMenu.Name = "flpMenu";
            this.flpMenu.Size = new System.Drawing.Size(776, 570);
            this.flpMenu.TabIndex = 1;
            // 
            // btnDeposito
            // 
            this.btnDeposito.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeposito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeposito.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeposito.Image = ((System.Drawing.Image)(resources.GetObject("btnDeposito.Image")));
            this.btnDeposito.Location = new System.Drawing.Point(3, 3);
            this.btnDeposito.Name = "btnDeposito";
            this.btnDeposito.Size = new System.Drawing.Size(381, 184);
            this.btnDeposito.TabIndex = 0;
            this.btnDeposito.Text = "Depósito";
            this.btnDeposito.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDeposito.UseVisualStyleBackColor = true;
            this.btnDeposito.Click += new System.EventHandler(this.btnDeposito_Click);
            // 
            // btnExtraccion
            // 
            this.btnExtraccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExtraccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExtraccion.Image = ((System.Drawing.Image)(resources.GetObject("btnExtraccion.Image")));
            this.btnExtraccion.Location = new System.Drawing.Point(390, 3);
            this.btnExtraccion.Name = "btnExtraccion";
            this.btnExtraccion.Size = new System.Drawing.Size(381, 184);
            this.btnExtraccion.TabIndex = 1;
            this.btnExtraccion.Text = "Extracción";
            this.btnExtraccion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExtraccion.UseVisualStyleBackColor = true;
            this.btnExtraccion.Click += new System.EventHandler(this.btnExtraccion_Click);
            // 
            // btnPagoServicio
            // 
            this.btnPagoServicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagoServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagoServicio.Image = ((System.Drawing.Image)(resources.GetObject("btnPagoServicio.Image")));
            this.btnPagoServicio.Location = new System.Drawing.Point(3, 193);
            this.btnPagoServicio.Name = "btnPagoServicio";
            this.btnPagoServicio.Size = new System.Drawing.Size(381, 184);
            this.btnPagoServicio.TabIndex = 2;
            this.btnPagoServicio.Text = "Pago Servicios";
            this.btnPagoServicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPagoServicio.UseVisualStyleBackColor = true;
            this.btnPagoServicio.Click += new System.EventHandler(this.btnPagoServicio_Click);
            // 
            // btnRecargaTelefonica
            // 
            this.btnRecargaTelefonica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecargaTelefonica.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecargaTelefonica.Image = ((System.Drawing.Image)(resources.GetObject("btnRecargaTelefonica.Image")));
            this.btnRecargaTelefonica.Location = new System.Drawing.Point(390, 193);
            this.btnRecargaTelefonica.Name = "btnRecargaTelefonica";
            this.btnRecargaTelefonica.Size = new System.Drawing.Size(381, 184);
            this.btnRecargaTelefonica.TabIndex = 3;
            this.btnRecargaTelefonica.Text = "Recarca Telefónica";
            this.btnRecargaTelefonica.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRecargaTelefonica.UseVisualStyleBackColor = true;
            this.btnRecargaTelefonica.Click += new System.EventHandler(this.btnRecargaTelefonica_Click);
            // 
            // btnMovimientos
            // 
            this.btnMovimientos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMovimientos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMovimientos.Image = ((System.Drawing.Image)(resources.GetObject("btnMovimientos.Image")));
            this.btnMovimientos.Location = new System.Drawing.Point(3, 383);
            this.btnMovimientos.Name = "btnMovimientos";
            this.btnMovimientos.Size = new System.Drawing.Size(381, 184);
            this.btnMovimientos.TabIndex = 4;
            this.btnMovimientos.Text = "Movimientos";
            this.btnMovimientos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnMovimientos.UseVisualStyleBackColor = true;
            this.btnMovimientos.Click += new System.EventHandler(this.btnMovimientos_Click);
            // 
            // btnTransferencia
            // 
            this.btnTransferencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransferencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransferencia.Image = ((System.Drawing.Image)(resources.GetObject("btnTransferencia.Image")));
            this.btnTransferencia.Location = new System.Drawing.Point(390, 383);
            this.btnTransferencia.Name = "btnTransferencia";
            this.btnTransferencia.Size = new System.Drawing.Size(381, 184);
            this.btnTransferencia.TabIndex = 5;
            this.btnTransferencia.Text = "Transferencia";
            this.btnTransferencia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTransferencia.UseVisualStyleBackColor = true;
            this.btnTransferencia.Click += new System.EventHandler(this.btnTransferencia_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 660);
            this.Controls.Add(this.flpMenu);
            this.Controls.Add(this.pnlSuperior);
            this.MinimumSize = new System.Drawing.Size(809, 716);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banelco";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Principal_Load);
            this.pnlSuperior.ResumeLayout(false);
            this.flpMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSuperior;
        private System.Windows.Forms.Label lblUsuarioLogin;
        private System.Windows.Forms.FlowLayoutPanel flpMenu;
        private System.Windows.Forms.Button btnDeposito;
        private System.Windows.Forms.Button btnExtraccion;
        private System.Windows.Forms.Button btnPagoServicio;
        private System.Windows.Forms.Button btnRecargaTelefonica;
        private System.Windows.Forms.Button btnMovimientos;
        private System.Windows.Forms.Button btnTransferencia;
    }
}

