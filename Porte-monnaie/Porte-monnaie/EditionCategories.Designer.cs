namespace Porte_monnaie
{
    partial class EditionCategories
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
            this.lbxCategoriesCredit = new System.Windows.Forms.ListBox();
            this.lbxCategoriesDebit = new System.Windows.Forms.ListBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxCategoriesCredit
            // 
            this.lbxCategoriesCredit.FormattingEnabled = true;
            this.lbxCategoriesCredit.Location = new System.Drawing.Point(12, 12);
            this.lbxCategoriesCredit.Name = "lbxCategoriesCredit";
            this.lbxCategoriesCredit.Size = new System.Drawing.Size(265, 342);
            this.lbxCategoriesCredit.TabIndex = 0;
            // 
            // lbxCategoriesDebit
            // 
            this.lbxCategoriesDebit.FormattingEnabled = true;
            this.lbxCategoriesDebit.Location = new System.Drawing.Point(293, 12);
            this.lbxCategoriesDebit.Name = "lbxCategoriesDebit";
            this.lbxCategoriesDebit.Size = new System.Drawing.Size(265, 342);
            this.lbxCategoriesDebit.TabIndex = 1;
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(12, 360);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(74, 28);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // EditionCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 401);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lbxCategoriesDebit);
            this.Controls.Add(this.lbxCategoriesCredit);
            this.Name = "EditionCategories";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EditionCategories";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbxCategoriesCredit;
        private System.Windows.Forms.ListBox lbxCategoriesDebit;
        private System.Windows.Forms.Button btnOk;
    }
}