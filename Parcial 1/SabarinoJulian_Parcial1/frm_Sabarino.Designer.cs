namespace SabarinoJulian_Parcial1
{
    partial class frm_Sabarino
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
            this.lstMedicos = new System.Windows.Forms.ListBox();
            this.lstPacientes = new System.Windows.Forms.ListBox();
            this.btn_atender = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.rtb_infoMedicos = new System.Windows.Forms.RichTextBox();
            this.lblMedicos = new System.Windows.Forms.Label();
            this.lblPacientes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstMedicos
            // 
            this.lstMedicos.FormattingEnabled = true;
            this.lstMedicos.ItemHeight = 15;
            this.lstMedicos.Location = new System.Drawing.Point(12, 42);
            this.lstMedicos.Name = "lstMedicos";
            this.lstMedicos.Size = new System.Drawing.Size(186, 214);
            this.lstMedicos.TabIndex = 0;
            this.lstMedicos.SelectedIndexChanged += new System.EventHandler(this.lstMedicos_SelectedIndexChanged);
            // 
            // lstPacientes
            // 
            this.lstPacientes.FormattingEnabled = true;
            this.lstPacientes.ItemHeight = 15;
            this.lstPacientes.Location = new System.Drawing.Point(204, 42);
            this.lstPacientes.Name = "lstPacientes";
            this.lstPacientes.Size = new System.Drawing.Size(186, 214);
            this.lstPacientes.TabIndex = 1;
            // 
            // btn_atender
            // 
            this.btn_atender.Location = new System.Drawing.Point(396, 42);
            this.btn_atender.Name = "btn_atender";
            this.btn_atender.Size = new System.Drawing.Size(100, 48);
            this.btn_atender.TabIndex = 2;
            this.btn_atender.Text = "Atender";
            this.btn_atender.UseVisualStyleBackColor = true;
            this.btn_atender.Click += new System.EventHandler(this.btn_atender_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(394, 428);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(100, 48);
            this.btn_salir.TabIndex = 3;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // rtb_infoMedicos
            // 
            this.rtb_infoMedicos.Location = new System.Drawing.Point(12, 262);
            this.rtb_infoMedicos.Name = "rtb_infoMedicos";
            this.rtb_infoMedicos.Size = new System.Drawing.Size(378, 214);
            this.rtb_infoMedicos.TabIndex = 4;
            this.rtb_infoMedicos.Text = "";
            // 
            // lblMedicos
            // 
            this.lblMedicos.AutoSize = true;
            this.lblMedicos.Location = new System.Drawing.Point(12, 24);
            this.lblMedicos.Name = "lblMedicos";
            this.lblMedicos.Size = new System.Drawing.Size(95, 15);
            this.lblMedicos.TabIndex = 5;
            this.lblMedicos.Text = "Personal Medico";
            // 
            // lblPacientes
            // 
            this.lblPacientes.AutoSize = true;
            this.lblPacientes.Location = new System.Drawing.Point(204, 24);
            this.lblPacientes.Name = "lblPacientes";
            this.lblPacientes.Size = new System.Drawing.Size(57, 15);
            this.lblPacientes.TabIndex = 6;
            this.lblPacientes.Text = "Pacientes";
            // 
            // frm_Sabarino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 488);
            this.Controls.Add(this.lblPacientes);
            this.Controls.Add(this.lblMedicos);
            this.Controls.Add(this.rtb_infoMedicos);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_atender);
            this.Controls.Add(this.lstPacientes);
            this.Controls.Add(this.lstMedicos);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Sabarino";
            this.Text = "Julian Sabarino Atencion Pacientes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Sabarino_FormClosing);
            this.Load += new System.EventHandler(this.frm_Sabarino_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstMedicos;
        private System.Windows.Forms.ListBox lstPacientes;
        private System.Windows.Forms.Button btn_atender;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.RichTextBox rtb_infoMedicos;
        private System.Windows.Forms.Label lblMedicos;
        private System.Windows.Forms.Label lblPacientes;
    }
}
