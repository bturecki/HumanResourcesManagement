
namespace HumanResourcesManagement.View
{
    partial class FrmExportData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmExportData));
            this.cePeople = new System.Windows.Forms.CheckBox();
            this.ceDepartaments = new System.Windows.Forms.CheckBox();
            this.btnGeneratePdf = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cePeople
            // 
            this.cePeople.AutoSize = true;
            this.cePeople.BackColor = System.Drawing.Color.Transparent;
            this.cePeople.Checked = true;
            this.cePeople.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cePeople.Location = new System.Drawing.Point(12, 12);
            this.cePeople.Name = "cePeople";
            this.cePeople.Size = new System.Drawing.Size(59, 17);
            this.cePeople.TabIndex = 0;
            this.cePeople.Text = "People";
            this.cePeople.UseVisualStyleBackColor = false;
            // 
            // ceDepartaments
            // 
            this.ceDepartaments.AutoSize = true;
            this.ceDepartaments.BackColor = System.Drawing.Color.Transparent;
            this.ceDepartaments.Checked = true;
            this.ceDepartaments.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ceDepartaments.Location = new System.Drawing.Point(12, 35);
            this.ceDepartaments.Name = "ceDepartaments";
            this.ceDepartaments.Size = new System.Drawing.Size(92, 17);
            this.ceDepartaments.TabIndex = 1;
            this.ceDepartaments.Text = "Departaments";
            this.ceDepartaments.UseVisualStyleBackColor = false;
            // 
            // btnGeneratePdf
            // 
            this.btnGeneratePdf.Location = new System.Drawing.Point(12, 58);
            this.btnGeneratePdf.Name = "btnGeneratePdf";
            this.btnGeneratePdf.Size = new System.Drawing.Size(92, 23);
            this.btnGeneratePdf.TabIndex = 2;
            this.btnGeneratePdf.Text = "Generate PDF";
            this.btnGeneratePdf.UseVisualStyleBackColor = true;
            this.btnGeneratePdf.Click += new System.EventHandler(this.btnGeneratePdf_Click);
            // 
            // FrmExportData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(549, 248);
            this.Controls.Add(this.btnGeneratePdf);
            this.Controls.Add(this.ceDepartaments);
            this.Controls.Add(this.cePeople);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmExportData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Export data";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cePeople;
        private System.Windows.Forms.CheckBox ceDepartaments;
        private System.Windows.Forms.Button btnGeneratePdf;
    }
}