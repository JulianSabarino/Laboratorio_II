namespace Clase6
{
    partial class Introduccion_Alta
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
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.btn_cargar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(74, 25);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.PlaceholderText = "Nombre";
            this.txt_nombre.Size = new System.Drawing.Size(156, 23);
            this.txt_nombre.TabIndex = 0;
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(74, 54);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '*';
            this.txt_pass.PlaceholderText = "Contrasena";
            this.txt_pass.Size = new System.Drawing.Size(156, 23);
            this.txt_pass.TabIndex = 1;
            // 
            // btn_cargar
            // 
            this.btn_cargar.Location = new System.Drawing.Point(74, 83);
            this.btn_cargar.Name = "btn_cargar";
            this.btn_cargar.Size = new System.Drawing.Size(75, 23);
            this.btn_cargar.TabIndex = 2;
            this.btn_cargar.Text = "Cargar";
            this.btn_cargar.UseVisualStyleBackColor = true;
            this.btn_cargar.Click += new System.EventHandler(this.btn_cargar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(155, 83);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 3;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // Introduccion_Alta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_cargar);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_nombre);
            this.Name = "Introduccion_Alta";
            this.Text = "Alta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txt_nombre;
        private TextBox txt_pass;
        private Button btn_cargar;
        private Button btn_cancelar;
    }
}