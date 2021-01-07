namespace Cajero
{
    partial class TecladoAlfaNumerico
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
            this.btnCerrarTeclado = new System.Windows.Forms.Button();
            this.flpTeclado = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // btnCerrarTeclado
            // 
            this.btnCerrarTeclado.BackColor = System.Drawing.Color.Maroon;
            this.btnCerrarTeclado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCerrarTeclado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarTeclado.ForeColor = System.Drawing.Color.White;
            this.btnCerrarTeclado.Location = new System.Drawing.Point(0, 202);
            this.btnCerrarTeclado.Name = "btnCerrarTeclado";
            this.btnCerrarTeclado.Size = new System.Drawing.Size(918, 67);
            this.btnCerrarTeclado.TabIndex = 0;
            this.btnCerrarTeclado.Text = "Cerrar Teclado";
            this.btnCerrarTeclado.UseVisualStyleBackColor = false;
            this.btnCerrarTeclado.Click += new System.EventHandler(this.btnCerrarTeclado_Click);
            // 
            // flpTeclado
            // 
            this.flpTeclado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpTeclado.Location = new System.Drawing.Point(0, 0);
            this.flpTeclado.Name = "flpTeclado";
            this.flpTeclado.Size = new System.Drawing.Size(918, 202);
            this.flpTeclado.TabIndex = 1;
            // 
            // TecladoAlfaNumerico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 269);
            this.Controls.Add(this.flpTeclado);
            this.Controls.Add(this.btnCerrarTeclado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(940, 325);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(940, 325);
            this.Name = "TecladoAlfaNumerico";
            this.Text = "Teclado";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCerrarTeclado;
        private System.Windows.Forms.FlowLayoutPanel flpTeclado;
    }
}