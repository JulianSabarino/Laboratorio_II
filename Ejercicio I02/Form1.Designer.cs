namespace Ejercicio_I02
{
    partial class frm_ing
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
            this.components = new System.ComponentModel.Container();
            this.gpb_detalles = new System.Windows.Forms.GroupBox();
            this.cal_borndate = new System.Windows.Forms.MonthCalendar();
            this.txt_altura = new System.Windows.Forms.TextBox();
            this.txt_dir = new System.Windows.Forms.TextBox();
            this.txt_surname = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.gpb_genero = new System.Windows.Forms.GroupBox();
            this.grb_fem = new System.Windows.Forms.RadioButton();
            this.grb_masc = new System.Windows.Forms.RadioButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.gpb_cursos = new System.Windows.Forms.GroupBox();
            this.chb_js = new System.Windows.Forms.CheckBox();
            this.chb_cs = new System.Windows.Forms.CheckBox();
            this.chb_cpp = new System.Windows.Forms.CheckBox();
            this.chlb_ocourse = new System.Windows.Forms.CheckedListBox();
            this.gpb_pais = new System.Windows.Forms.GroupBox();
            this.lstb_paises = new System.Windows.Forms.ListBox();
            this.btn_ing = new System.Windows.Forms.Button();
            this.cmb_paises = new System.Windows.Forms.ComboBox();
            this.gpb_detalles.SuspendLayout();
            this.gpb_genero.SuspendLayout();
            this.gpb_cursos.SuspendLayout();
            this.gpb_pais.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpb_detalles
            // 
            this.gpb_detalles.Controls.Add(this.cal_borndate);
            this.gpb_detalles.Controls.Add(this.txt_altura);
            this.gpb_detalles.Controls.Add(this.txt_dir);
            this.gpb_detalles.Controls.Add(this.txt_surname);
            this.gpb_detalles.Controls.Add(this.txt_name);
            this.gpb_detalles.Location = new System.Drawing.Point(12, 12);
            this.gpb_detalles.Name = "gpb_detalles";
            this.gpb_detalles.Size = new System.Drawing.Size(238, 282);
            this.gpb_detalles.TabIndex = 0;
            this.gpb_detalles.TabStop = false;
            this.gpb_detalles.Text = "Detalles de Usuario";
            // 
            // cal_borndate
            // 
            this.cal_borndate.Location = new System.Drawing.Point(6, 115);
            this.cal_borndate.Name = "cal_borndate";
            this.cal_borndate.TabIndex = 4;
            // 
            // txt_altura
            // 
            this.txt_altura.Location = new System.Drawing.Point(152, 80);
            this.txt_altura.Name = "txt_altura";
            this.txt_altura.PlaceholderText = "Altura";
            this.txt_altura.Size = new System.Drawing.Size(80, 23);
            this.txt_altura.TabIndex = 3;
            // 
            // txt_dir
            // 
            this.txt_dir.Location = new System.Drawing.Point(6, 80);
            this.txt_dir.Name = "txt_dir";
            this.txt_dir.PlaceholderText = "Dirección";
            this.txt_dir.Size = new System.Drawing.Size(140, 23);
            this.txt_dir.TabIndex = 2;
            // 
            // txt_surname
            // 
            this.txt_surname.Location = new System.Drawing.Point(6, 51);
            this.txt_surname.Name = "txt_surname";
            this.txt_surname.PlaceholderText = "Apellido";
            this.txt_surname.Size = new System.Drawing.Size(226, 23);
            this.txt_surname.TabIndex = 1;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(6, 22);
            this.txt_name.Name = "txt_name";
            this.txt_name.PlaceholderText = "Nombre";
            this.txt_name.Size = new System.Drawing.Size(226, 23);
            this.txt_name.TabIndex = 0;
            this.txt_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_name_KeyPress);
            // 
            // gpb_genero
            // 
            this.gpb_genero.Controls.Add(this.grb_fem);
            this.gpb_genero.Controls.Add(this.grb_masc);
            this.gpb_genero.Location = new System.Drawing.Point(256, 12);
            this.gpb_genero.Name = "gpb_genero";
            this.gpb_genero.Size = new System.Drawing.Size(112, 74);
            this.gpb_genero.TabIndex = 1;
            this.gpb_genero.TabStop = false;
            this.gpb_genero.Text = "Genero";
            // 
            // grb_fem
            // 
            this.grb_fem.AutoSize = true;
            this.grb_fem.Location = new System.Drawing.Point(6, 51);
            this.grb_fem.Name = "grb_fem";
            this.grb_fem.Size = new System.Drawing.Size(78, 19);
            this.grb_fem.TabIndex = 1;
            this.grb_fem.TabStop = true;
            this.grb_fem.Text = "Femenino";
            this.grb_fem.UseVisualStyleBackColor = true;
            // 
            // grb_masc
            // 
            this.grb_masc.AutoSize = true;
            this.grb_masc.Location = new System.Drawing.Point(6, 26);
            this.grb_masc.Name = "grb_masc";
            this.grb_masc.Size = new System.Drawing.Size(80, 19);
            this.grb_masc.TabIndex = 0;
            this.grb_masc.TabStop = true;
            this.grb_masc.Text = "Masculino";
            this.grb_masc.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // gpb_cursos
            // 
            this.gpb_cursos.Controls.Add(this.chb_js);
            this.gpb_cursos.Controls.Add(this.chb_cs);
            this.gpb_cursos.Controls.Add(this.chb_cpp);
            this.gpb_cursos.Location = new System.Drawing.Point(262, 92);
            this.gpb_cursos.Name = "gpb_cursos";
            this.gpb_cursos.Size = new System.Drawing.Size(106, 96);
            this.gpb_cursos.TabIndex = 2;
            this.gpb_cursos.TabStop = false;
            this.gpb_cursos.Text = "Cursos";
            // 
            // chb_js
            // 
            this.chb_js.AutoSize = true;
            this.chb_js.Location = new System.Drawing.Point(6, 72);
            this.chb_js.Name = "chb_js";
            this.chb_js.Size = new System.Drawing.Size(77, 19);
            this.chb_js.TabIndex = 2;
            this.chb_js.Text = "Javascript";
            this.chb_js.UseVisualStyleBackColor = true;
            // 
            // chb_cs
            // 
            this.chb_cs.AutoSize = true;
            this.chb_cs.Location = new System.Drawing.Point(6, 47);
            this.chb_cs.Name = "chb_cs";
            this.chb_cs.Size = new System.Drawing.Size(41, 19);
            this.chb_cs.TabIndex = 1;
            this.chb_cs.Text = "C#";
            this.chb_cs.UseVisualStyleBackColor = true;
            // 
            // chb_cpp
            // 
            this.chb_cpp.AutoSize = true;
            this.chb_cpp.Location = new System.Drawing.Point(6, 22);
            this.chb_cpp.Name = "chb_cpp";
            this.chb_cpp.Size = new System.Drawing.Size(50, 19);
            this.chb_cpp.TabIndex = 0;
            this.chb_cpp.Text = "C++";
            this.chb_cpp.UseVisualStyleBackColor = true;
            // 
            // chlb_ocourse
            // 
            this.chlb_ocourse.FormattingEnabled = true;
            this.chlb_ocourse.Location = new System.Drawing.Point(262, 194);
            this.chlb_ocourse.Name = "chlb_ocourse";
            this.chlb_ocourse.Size = new System.Drawing.Size(106, 238);
            this.chlb_ocourse.TabIndex = 3;
            // 
            // gpb_pais
            // 
            this.gpb_pais.Controls.Add(this.cmb_paises);
            this.gpb_pais.Controls.Add(this.lstb_paises);
            this.gpb_pais.Location = new System.Drawing.Point(18, 299);
            this.gpb_pais.Name = "gpb_pais";
            this.gpb_pais.Size = new System.Drawing.Size(232, 198);
            this.gpb_pais.TabIndex = 4;
            this.gpb_pais.TabStop = false;
            this.gpb_pais.Text = "Paises";
            // 
            // lstb_paises
            // 
            this.lstb_paises.FormattingEnabled = true;
            this.lstb_paises.ItemHeight = 15;
            this.lstb_paises.Location = new System.Drawing.Point(7, 52);
            this.lstb_paises.Name = "lstb_paises";
            this.lstb_paises.Size = new System.Drawing.Size(220, 139);
            this.lstb_paises.TabIndex = 0;
            // 
            // btn_ing
            // 
            this.btn_ing.Location = new System.Drawing.Point(262, 438);
            this.btn_ing.Name = "btn_ing";
            this.btn_ing.Size = new System.Drawing.Size(106, 59);
            this.btn_ing.TabIndex = 6;
            this.btn_ing.Text = "Ingresar";
            this.btn_ing.UseVisualStyleBackColor = true;
            this.btn_ing.Click += new System.EventHandler(this.btn_ing_Click);
            // 
            // cmb_paises
            // 
            this.cmb_paises.FormattingEnabled = true;
            this.cmb_paises.Location = new System.Drawing.Point(7, 22);
            this.cmb_paises.Name = "cmb_paises";
            this.cmb_paises.Size = new System.Drawing.Size(219, 23);
            this.cmb_paises.TabIndex = 1;
            this.cmb_paises.SelectedIndexChanged += new System.EventHandler(this.cmb_paises_SelectedIndexChanged);
            // 
            // frm_ing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 504);
            this.Controls.Add(this.btn_ing);
            this.Controls.Add(this.gpb_pais);
            this.Controls.Add(this.chlb_ocourse);
            this.Controls.Add(this.gpb_cursos);
            this.Controls.Add(this.gpb_genero);
            this.Controls.Add(this.gpb_detalles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_ing";
            this.Text = "Ingreso";
            this.gpb_detalles.ResumeLayout(false);
            this.gpb_detalles.PerformLayout();
            this.gpb_genero.ResumeLayout(false);
            this.gpb_genero.PerformLayout();
            this.gpb_cursos.ResumeLayout(false);
            this.gpb_cursos.PerformLayout();
            this.gpb_pais.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpb_detalles;
        private System.Windows.Forms.TextBox txt_dir;
        private System.Windows.Forms.TextBox txt_surname;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.GroupBox gpb_genero;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txt_altura;
        private System.Windows.Forms.RadioButton grb_fem;
        private System.Windows.Forms.RadioButton grb_masc;
        private System.Windows.Forms.MonthCalendar cal_borndate;
        private System.Windows.Forms.GroupBox gpb_cursos;
        private System.Windows.Forms.CheckBox chb_js;
        private System.Windows.Forms.CheckBox chb_cs;
        private System.Windows.Forms.CheckBox chb_cpp;
        private System.Windows.Forms.CheckedListBox chlb_ocourse;
        private System.Windows.Forms.GroupBox gpb_pais;
        private System.Windows.Forms.ListBox lstb_paises;
        private System.Windows.Forms.Button btn_ing;
        private System.Windows.Forms.ComboBox cmb_paises;
    }
}
