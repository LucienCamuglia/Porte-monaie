namespace Porte_monnaie
{
    partial class FrmColor
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
            this.lblBackcolor = new System.Windows.Forms.Label();
            this.btnBackColor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Btnlegendcolor = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.clrDefaut = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbPalette = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblBackcolor
            // 
            this.lblBackcolor.AutoSize = true;
            this.lblBackcolor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBackcolor.Location = new System.Drawing.Point(12, 28);
            this.lblBackcolor.Name = "lblBackcolor";
            this.lblBackcolor.Size = new System.Drawing.Size(229, 25);
            this.lblBackcolor.TabIndex = 0;
            this.lblBackcolor.Text = "Couleur de l\'arrière plan :";
            // 
            // btnBackColor
            // 
            this.btnBackColor.Location = new System.Drawing.Point(248, 29);
            this.btnBackColor.Name = "btnBackColor";
            this.btnBackColor.Size = new System.Drawing.Size(75, 23);
            this.btnBackColor.TabIndex = 2;
            this.btnBackColor.Text = "Choisir";
            this.btnBackColor.UseVisualStyleBackColor = true;
            this.btnBackColor.Click += new System.EventHandler(this.btnBackColor_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Couleur de la légende :";
            // 
            // Btnlegendcolor
            // 
            this.Btnlegendcolor.Location = new System.Drawing.Point(248, 72);
            this.Btnlegendcolor.Name = "Btnlegendcolor";
            this.Btnlegendcolor.Size = new System.Drawing.Size(75, 23);
            this.Btnlegendcolor.TabIndex = 4;
            this.Btnlegendcolor.Text = "Choisir";
            this.Btnlegendcolor.UseVisualStyleBackColor = true;
            this.Btnlegendcolor.Click += new System.EventHandler(this.btnBackColor_Click_1);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(268, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // clrDefaut
            // 
            this.clrDefaut.Location = new System.Drawing.Point(17, 227);
            this.clrDefaut.Name = "clrDefaut";
            this.clrDefaut.Size = new System.Drawing.Size(112, 23);
            this.clrDefaut.TabIndex = 7;
            this.clrDefaut.Text = "Couleur par défaut";
            this.clrDefaut.UseVisualStyleBackColor = true;
            this.clrDefaut.Click += new System.EventHandler(this.clrDefaut_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Style du graphique :";
            // 
            // cmbPalette
            // 
            this.cmbPalette.FormattingEnabled = true;
            this.cmbPalette.Location = new System.Drawing.Point(210, 119);
            this.cmbPalette.Name = "cmbPalette";
            this.cmbPalette.Size = new System.Drawing.Size(121, 21);
            this.cmbPalette.TabIndex = 9;
            // 
            // FrmColor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 262);
            this.Controls.Add(this.cmbPalette);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.clrDefaut);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Btnlegendcolor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBackColor);
            this.Controls.Add(this.lblBackcolor);
            this.Name = "FrmColor";
            this.Text = "FrmColor";
            this.Load += new System.EventHandler(this.FrmColor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBackcolor;
        public System.Windows.Forms.Button btnBackColor;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button Btnlegendcolor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button clrDefaut;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox cmbPalette;
    }
}