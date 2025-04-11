namespace CAI_ejericico_login
{
    partial class FormEmpleados
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
            this.lblLegajo = new System.Windows.Forms.Label();
            this.lblFechaingr = new System.Windows.Forms.Label();
            this.lstEmpleados = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblLegajo
            // 
            this.lblLegajo.AutoSize = true;
            this.lblLegajo.Location = new System.Drawing.Point(38, 42);
            this.lblLegajo.Name = "lblLegajo";
            this.lblLegajo.Size = new System.Drawing.Size(57, 20);
            this.lblLegajo.TabIndex = 0;
            this.lblLegajo.Text = "Legajo";
            // 
            // lblFechaingr
            // 
            this.lblFechaingr.AutoSize = true;
            this.lblFechaingr.Location = new System.Drawing.Point(36, 84);
            this.lblFechaingr.Name = "lblFechaingr";
            this.lblFechaingr.Size = new System.Drawing.Size(112, 20);
            this.lblFechaingr.TabIndex = 1;
            this.lblFechaingr.Text = "Fecha Ingreso";
            // 
            // lstEmpleados
            // 
            this.lstEmpleados.FormattingEnabled = true;
            this.lstEmpleados.ItemHeight = 20;
            this.lstEmpleados.Location = new System.Drawing.Point(42, 140);
            this.lstEmpleados.Name = "lstEmpleados";
            this.lstEmpleados.Size = new System.Drawing.Size(106, 24);
            this.lstEmpleados.TabIndex = 2;
            this.lstEmpleados.Tag = "";
            // 
            // FormEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstEmpleados);
            this.Controls.Add(this.lblFechaingr);
            this.Controls.Add(this.lblLegajo);
            this.Name = "FormEmpleados";
            this.Text = "FormEmpleados";     
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLegajo;
        private System.Windows.Forms.Label lblFechaingr;
        private System.Windows.Forms.ListBox lstEmpleados;
    }
}