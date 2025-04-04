namespace CAI_ejericico_login
{
    partial class formLogin
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
            this.lblUsua = new System.Windows.Forms.Label();
            this.lblContra = new System.Windows.Forms.Label();
            this.txtUsua = new System.Windows.Forms.TextBox();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.btnIngre = new System.Windows.Forms.Button();
            this.btnCrearcuenta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUsua
            // 
            this.lblUsua.AutoSize = true;
            this.lblUsua.Location = new System.Drawing.Point(54, 59);
            this.lblUsua.Name = "lblUsua";
            this.lblUsua.Size = new System.Drawing.Size(64, 20);
            this.lblUsua.TabIndex = 0;
            this.lblUsua.Text = "Usuario";
            // 
            // lblContra
            // 
            this.lblContra.AutoSize = true;
            this.lblContra.Location = new System.Drawing.Point(54, 102);
            this.lblContra.Name = "lblContra";
            this.lblContra.Size = new System.Drawing.Size(92, 20);
            this.lblContra.TabIndex = 1;
            this.lblContra.Text = "Contraseña";
            // 
            // txtUsua
            // 
            this.txtUsua.Location = new System.Drawing.Point(167, 61);
            this.txtUsua.Name = "txtUsua";
            this.txtUsua.Size = new System.Drawing.Size(187, 26);
            this.txtUsua.TabIndex = 2;
            // 
            // txtContra
            // 
            this.txtContra.Location = new System.Drawing.Point(165, 109);
            this.txtContra.Name = "txtContra";
            this.txtContra.Size = new System.Drawing.Size(188, 26);
            this.txtContra.TabIndex = 3;
            // 
            // btnIngre
            // 
            this.btnIngre.Location = new System.Drawing.Point(108, 165);
            this.btnIngre.Name = "btnIngre";
            this.btnIngre.Size = new System.Drawing.Size(155, 32);
            this.btnIngre.TabIndex = 4;
            this.btnIngre.Text = "Ingresar";
            this.btnIngre.UseVisualStyleBackColor = true;
            this.btnIngre.Click += new System.EventHandler(this.btnIniciarSes_Click);
            // 
            // btnCrearcuenta
            // 
            this.btnCrearcuenta.Location = new System.Drawing.Point(108, 203);
            this.btnCrearcuenta.Name = "btnCrearcuenta";
            this.btnCrearcuenta.Size = new System.Drawing.Size(154, 32);
            this.btnCrearcuenta.TabIndex = 5;
            this.btnCrearcuenta.Text = "Crear Cuenta";
            this.btnCrearcuenta.UseVisualStyleBackColor = true;
            // 
            // formLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 609);
            this.Controls.Add(this.btnCrearcuenta);
            this.Controls.Add(this.btnIngre);
            this.Controls.Add(this.txtContra);
            this.Controls.Add(this.txtUsua);
            this.Controls.Add(this.lblContra);
            this.Controls.Add(this.lblUsua);
            this.Name = "formLogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.formLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsua;
        private System.Windows.Forms.Label lblContra;
        private System.Windows.Forms.TextBox txtUsua;
        private System.Windows.Forms.TextBox txtContra;
        private System.Windows.Forms.Button btnIngre;
        private System.Windows.Forms.Button btnCrearcuenta;
    }
}

