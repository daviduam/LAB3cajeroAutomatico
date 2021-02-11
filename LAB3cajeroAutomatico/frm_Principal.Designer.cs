
namespace LAB3cajeroAutomatico
{
    partial class frm_Principal
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
            this.gbx_Ingreso = new System.Windows.Forms.GroupBox();
            this.btl_Ingresar = new System.Windows.Forms.Button();
            this.msk_NumTarjeta = new System.Windows.Forms.MaskedTextBox();
            this.txb_Pin = new System.Windows.Forms.TextBox();
            this.lb_Pin = new System.Windows.Forms.Label();
            this.lb_Numtarjeta = new System.Windows.Forms.Label();
            this.gbx_Ingreso.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbx_Ingreso
            // 
            this.gbx_Ingreso.Controls.Add(this.btl_Ingresar);
            this.gbx_Ingreso.Controls.Add(this.msk_NumTarjeta);
            this.gbx_Ingreso.Controls.Add(this.txb_Pin);
            this.gbx_Ingreso.Controls.Add(this.lb_Pin);
            this.gbx_Ingreso.Controls.Add(this.lb_Numtarjeta);
            this.gbx_Ingreso.Location = new System.Drawing.Point(114, 39);
            this.gbx_Ingreso.Name = "gbx_Ingreso";
            this.gbx_Ingreso.Size = new System.Drawing.Size(397, 231);
            this.gbx_Ingreso.TabIndex = 0;
            this.gbx_Ingreso.TabStop = false;
            this.gbx_Ingreso.Text = "Cajero Automatico";
            this.gbx_Ingreso.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btl_Ingresar
            // 
            this.btl_Ingresar.Enabled = false;
            this.btl_Ingresar.Location = new System.Drawing.Point(180, 167);
            this.btl_Ingresar.Name = "btl_Ingresar";
            this.btl_Ingresar.Size = new System.Drawing.Size(95, 31);
            this.btl_Ingresar.TabIndex = 4;
            this.btl_Ingresar.Text = "Acceder";
            this.btl_Ingresar.UseVisualStyleBackColor = true;
            this.btl_Ingresar.Click += new System.EventHandler(this.button1_Click);
            // 
            // msk_NumTarjeta
            // 
            this.msk_NumTarjeta.Location = new System.Drawing.Point(139, 47);
            this.msk_NumTarjeta.Mask = "0000-0000-0000-0000";
            this.msk_NumTarjeta.Name = "msk_NumTarjeta";
            this.msk_NumTarjeta.Size = new System.Drawing.Size(120, 20);
            this.msk_NumTarjeta.TabIndex = 3;
            // 
            // txb_Pin
            // 
            this.txb_Pin.Location = new System.Drawing.Point(131, 112);
            this.txb_Pin.Name = "txb_Pin";
            this.txb_Pin.Size = new System.Drawing.Size(171, 20);
            this.txb_Pin.TabIndex = 2;
            // 
            // lb_Pin
            // 
            this.lb_Pin.AutoSize = true;
            this.lb_Pin.Location = new System.Drawing.Point(38, 115);
            this.lb_Pin.Name = "lb_Pin";
            this.lb_Pin.Size = new System.Drawing.Size(22, 13);
            this.lb_Pin.TabIndex = 1;
            this.lb_Pin.Text = "Pin";
            // 
            // lb_Numtarjeta
            // 
            this.lb_Numtarjeta.AutoSize = true;
            this.lb_Numtarjeta.Location = new System.Drawing.Point(38, 50);
            this.lb_Numtarjeta.Name = "lb_Numtarjeta";
            this.lb_Numtarjeta.Size = new System.Drawing.Size(95, 13);
            this.lb_Numtarjeta.TabIndex = 0;
            this.lb_Numtarjeta.Text = "Numero de Tarjeta";
            // 
            // frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbx_Ingreso);
            this.Name = "frm_Principal";
            this.Text = "frm_Principal";
            this.gbx_Ingreso.ResumeLayout(false);
            this.gbx_Ingreso.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbx_Ingreso;
        private System.Windows.Forms.MaskedTextBox msk_NumTarjeta;
        private System.Windows.Forms.TextBox txb_Pin;
        private System.Windows.Forms.Label lb_Pin;
        private System.Windows.Forms.Label lb_Numtarjeta;
        private System.Windows.Forms.Button btl_Ingresar;
    }
}