namespace TheDragonsLair
{
    partial class frm_dslair
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
            this.btn_load = new System.Windows.Forms.Button();
            this.lstb_primaryWH = new System.Windows.Forms.ListBox();
            this.lstb_secondaryWH = new System.Windows.Forms.ListBox();
            this.lstb_Prod = new System.Windows.Forms.ListBox();
            this.rtxtb_depDesc = new System.Windows.Forms.RichTextBox();
            this.btn_newWH = new System.Windows.Forms.Button();
            this.btn_newProdT = new System.Windows.Forms.Button();
            this.btn_newMovement = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(264, 332);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(106, 23);
            this.btn_load.TabIndex = 0;
            this.btn_load.Text = "Load";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // lstb_primaryWH
            // 
            this.lstb_primaryWH.FormattingEnabled = true;
            this.lstb_primaryWH.ItemHeight = 15;
            this.lstb_primaryWH.Location = new System.Drawing.Point(12, 12);
            this.lstb_primaryWH.Name = "lstb_primaryWH";
            this.lstb_primaryWH.Size = new System.Drawing.Size(120, 94);
            this.lstb_primaryWH.TabIndex = 1;
            this.lstb_primaryWH.Click += new System.EventHandler(this.lstb_primaryWH_Click);
            this.lstb_primaryWH.SelectedIndexChanged += new System.EventHandler(this.lstb_primaryWH_SelectedIndexChanged);
            // 
            // lstb_secondaryWH
            // 
            this.lstb_secondaryWH.FormattingEnabled = true;
            this.lstb_secondaryWH.ItemHeight = 15;
            this.lstb_secondaryWH.Location = new System.Drawing.Point(138, 12);
            this.lstb_secondaryWH.Name = "lstb_secondaryWH";
            this.lstb_secondaryWH.Size = new System.Drawing.Size(120, 94);
            this.lstb_secondaryWH.TabIndex = 2;
            this.lstb_secondaryWH.Click += new System.EventHandler(this.lstb_secondaryWH_Click);
            // 
            // lstb_Prod
            // 
            this.lstb_Prod.FormattingEnabled = true;
            this.lstb_Prod.ItemHeight = 15;
            this.lstb_Prod.Location = new System.Drawing.Point(12, 112);
            this.lstb_Prod.Name = "lstb_Prod";
            this.lstb_Prod.Size = new System.Drawing.Size(246, 94);
            this.lstb_Prod.TabIndex = 3;
            // 
            // rtxtb_depDesc
            // 
            this.rtxtb_depDesc.Location = new System.Drawing.Point(12, 212);
            this.rtxtb_depDesc.Name = "rtxtb_depDesc";
            this.rtxtb_depDesc.Size = new System.Drawing.Size(246, 201);
            this.rtxtb_depDesc.TabIndex = 4;
            this.rtxtb_depDesc.Text = "";
            // 
            // btn_newWH
            // 
            this.btn_newWH.Location = new System.Drawing.Point(264, 361);
            this.btn_newWH.Name = "btn_newWH";
            this.btn_newWH.Size = new System.Drawing.Size(106, 23);
            this.btn_newWH.TabIndex = 5;
            this.btn_newWH.Text = "New WH";
            this.btn_newWH.UseVisualStyleBackColor = true;
            // 
            // btn_newProdT
            // 
            this.btn_newProdT.Location = new System.Drawing.Point(264, 390);
            this.btn_newProdT.Name = "btn_newProdT";
            this.btn_newProdT.Size = new System.Drawing.Size(106, 23);
            this.btn_newProdT.TabIndex = 6;
            this.btn_newProdT.Text = "New Product";
            this.btn_newProdT.UseVisualStyleBackColor = true;
            // 
            // btn_newMovement
            // 
            this.btn_newMovement.Location = new System.Drawing.Point(264, 12);
            this.btn_newMovement.Name = "btn_newMovement";
            this.btn_newMovement.Size = new System.Drawing.Size(106, 23);
            this.btn_newMovement.TabIndex = 7;
            this.btn_newMovement.Text = "New Movement";
            this.btn_newMovement.UseVisualStyleBackColor = true;
            this.btn_newMovement.Click += new System.EventHandler(this.btn_newMovement_Click);
            // 
            // frm_dslair
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 425);
            this.Controls.Add(this.btn_newMovement);
            this.Controls.Add(this.btn_newProdT);
            this.Controls.Add(this.btn_newWH);
            this.Controls.Add(this.rtxtb_depDesc);
            this.Controls.Add(this.lstb_Prod);
            this.Controls.Add(this.lstb_secondaryWH);
            this.Controls.Add(this.lstb_primaryWH);
            this.Controls.Add(this.btn_load);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_dslair";
            this.Text = "Dragon\'s Lair";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.ListBox lstb_primaryWH;
        private System.Windows.Forms.ListBox lstb_secondaryWH;
        private System.Windows.Forms.ListBox lstb_Prod;
        private System.Windows.Forms.RichTextBox rtxtb_depDesc;
        private System.Windows.Forms.Button btn_newWH;
        private System.Windows.Forms.Button btn_newProdT;
        private System.Windows.Forms.Button btn_newMovement;
    }
}
