namespace TheDragonsLair
{
    partial class frm_newMovement
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
            this.cmb_originWH = new System.Windows.Forms.ComboBox();
            this.cmb_forwWH = new System.Windows.Forms.ComboBox();
            this.lbl_originWH = new System.Windows.Forms.Label();
            this.lbl_forwWH = new System.Windows.Forms.Label();
            this.lstb_product = new System.Windows.Forms.ListBox();
            this.btn_makeMovement = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_originWH
            // 
            this.cmb_originWH.FormattingEnabled = true;
            this.cmb_originWH.Location = new System.Drawing.Point(12, 27);
            this.cmb_originWH.Name = "cmb_originWH";
            this.cmb_originWH.Size = new System.Drawing.Size(121, 23);
            this.cmb_originWH.TabIndex = 0;
            // 
            // cmb_forwWH
            // 
            this.cmb_forwWH.FormattingEnabled = true;
            this.cmb_forwWH.Location = new System.Drawing.Point(12, 71);
            this.cmb_forwWH.Name = "cmb_forwWH";
            this.cmb_forwWH.Size = new System.Drawing.Size(121, 23);
            this.cmb_forwWH.TabIndex = 1;
            // 
            // lbl_originWH
            // 
            this.lbl_originWH.AutoSize = true;
            this.lbl_originWH.Location = new System.Drawing.Point(12, 9);
            this.lbl_originWH.Name = "lbl_originWH";
            this.lbl_originWH.Size = new System.Drawing.Size(40, 15);
            this.lbl_originWH.TabIndex = 2;
            this.lbl_originWH.Text = "Origin";
            // 
            // lbl_forwWH
            // 
            this.lbl_forwWH.AutoSize = true;
            this.lbl_forwWH.Location = new System.Drawing.Point(14, 53);
            this.lbl_forwWH.Name = "lbl_forwWH";
            this.lbl_forwWH.Size = new System.Drawing.Size(50, 15);
            this.lbl_forwWH.TabIndex = 3;
            this.lbl_forwWH.Text = "Forward";
            // 
            // lstb_product
            // 
            this.lstb_product.FormattingEnabled = true;
            this.lstb_product.ItemHeight = 15;
            this.lstb_product.Location = new System.Drawing.Point(13, 100);
            this.lstb_product.Name = "lstb_product";
            this.lstb_product.Size = new System.Drawing.Size(120, 94);
            this.lstb_product.TabIndex = 4;
            // 
            // btn_makeMovement
            // 
            this.btn_makeMovement.Location = new System.Drawing.Point(12, 233);
            this.btn_makeMovement.Name = "btn_makeMovement";
            this.btn_makeMovement.Size = new System.Drawing.Size(121, 23);
            this.btn_makeMovement.TabIndex = 6;
            this.btn_makeMovement.Text = "Make Movement";
            this.btn_makeMovement.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(14, 200);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 23);
            this.numericUpDown1.TabIndex = 7;
            // 
            // frm_newMovement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(148, 272);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.btn_makeMovement);
            this.Controls.Add(this.lstb_product);
            this.Controls.Add(this.lbl_forwWH);
            this.Controls.Add(this.lbl_originWH);
            this.Controls.Add(this.cmb_forwWH);
            this.Controls.Add(this.cmb_originWH);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_newMovement";
            this.Text = "New Movement";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_originWH;
        private System.Windows.Forms.ComboBox cmb_forwWH;
        private System.Windows.Forms.Label lbl_originWH;
        private System.Windows.Forms.Label lbl_forwWH;
        private System.Windows.Forms.ListBox lstb_product;
        private System.Windows.Forms.Button btn_makeMovement;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}