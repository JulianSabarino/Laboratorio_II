namespace Clase6
{
    partial class Introduccion
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
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.btn_name = new System.Windows.Forms.Button();
            this.lbl_name = new System.Windows.Forms.Label();
            this.rtxt_historial = new System.Windows.Forms.RichTextBox();
            this.lstb_historial = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fAQToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(12, 166);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.PlaceholderText = "Nombre";
            this.txt_nombre.Size = new System.Drawing.Size(100, 23);
            this.txt_nombre.TabIndex = 0;
            // 
            // btn_name
            // 
            this.btn_name.Location = new System.Drawing.Point(118, 168);
            this.btn_name.Name = "btn_name";
            this.btn_name.Size = new System.Drawing.Size(120, 23);
            this.btn_name.TabIndex = 1;
            this.btn_name.Text = "Push";
            this.btn_name.UseVisualStyleBackColor = true;
            this.btn_name.Click += new System.EventHandler(this.btn_name_Click);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(12, 148);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(0, 15);
            this.lbl_name.TabIndex = 2;
            // 
            // rtxt_historial
            // 
            this.rtxt_historial.Location = new System.Drawing.Point(12, 195);
            this.rtxt_historial.Name = "rtxt_historial";
            this.rtxt_historial.Size = new System.Drawing.Size(100, 96);
            this.rtxt_historial.TabIndex = 3;
            this.rtxt_historial.Text = "";
            // 
            // lstb_historial
            // 
            this.lstb_historial.FormattingEnabled = true;
            this.lstb_historial.ItemHeight = 15;
            this.lstb_historial.Location = new System.Drawing.Point(118, 197);
            this.lstb_historial.Name = "lstb_historial";
            this.lstb_historial.Size = new System.Drawing.Size(120, 94);
            this.lstb_historial.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuarioToolStripMenuItem,
            this.fAQToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            // 
            // fAQToolStripMenuItem
            // 
            this.fAQToolStripMenuItem.Name = "fAQToolStripMenuItem";
            this.fAQToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.fAQToolStripMenuItem.Text = "FAQ";
            this.fAQToolStripMenuItem.Click += new System.EventHandler(this.fAQToolStripMenuItem_Click);
            // 
            // Introduccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstb_historial);
            this.Controls.Add(this.rtxt_historial);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.btn_name);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Introduccion";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txt_nombre;
        private Button btn_name;
        private Label lbl_name;
        private RichTextBox rtxt_historial;
        private ListBox lstb_historial;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem usuarioToolStripMenuItem;
        private ToolStripMenuItem nuevoToolStripMenuItem;
        private ToolStripMenuItem eliminarToolStripMenuItem;
        private ToolStripMenuItem fAQToolStripMenuItem;
    }
}