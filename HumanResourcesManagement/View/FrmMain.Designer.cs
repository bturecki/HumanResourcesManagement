
namespace HumanResourcesManagement
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.btnPeople = new System.Windows.Forms.Button();
            this.btnShowDepartaments = new System.Windows.Forms.Button();
            this.lblCreator = new System.Windows.Forms.Label();
            this.btnManageVacations = new System.Windows.Forms.Button();
            this.btnWorkingHours = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPeople
            // 
            this.btnPeople.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPeople.Location = new System.Drawing.Point(12, 12);
            this.btnPeople.Name = "btnPeople";
            this.btnPeople.Size = new System.Drawing.Size(631, 33);
            this.btnPeople.TabIndex = 2;
            this.btnPeople.Text = "Manage people";
            this.btnPeople.UseVisualStyleBackColor = true;
            this.btnPeople.Click += new System.EventHandler(this.btnPeople_Click_1);
            // 
            // btnShowDepartaments
            // 
            this.btnShowDepartaments.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowDepartaments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnShowDepartaments.Location = new System.Drawing.Point(12, 51);
            this.btnShowDepartaments.Name = "btnShowDepartaments";
            this.btnShowDepartaments.Size = new System.Drawing.Size(631, 33);
            this.btnShowDepartaments.TabIndex = 3;
            this.btnShowDepartaments.Text = "Manage departaments";
            this.btnShowDepartaments.UseVisualStyleBackColor = true;
            this.btnShowDepartaments.Click += new System.EventHandler(this.btnShowDepartaments_Click_1);
            // 
            // lblCreator
            // 
            this.lblCreator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCreator.AutoSize = true;
            this.lblCreator.BackColor = System.Drawing.Color.Transparent;
            this.lblCreator.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreator.Location = new System.Drawing.Point(9, 349);
            this.lblCreator.Name = "lblCreator";
            this.lblCreator.Size = new System.Drawing.Size(0, 16);
            this.lblCreator.TabIndex = 4;
            // 
            // btnManageVacations
            // 
            this.btnManageVacations.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnManageVacations.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnManageVacations.Location = new System.Drawing.Point(12, 90);
            this.btnManageVacations.Name = "btnManageVacations";
            this.btnManageVacations.Size = new System.Drawing.Size(631, 33);
            this.btnManageVacations.TabIndex = 5;
            this.btnManageVacations.Text = "Manage vacations";
            this.btnManageVacations.UseVisualStyleBackColor = true;
            this.btnManageVacations.Click += new System.EventHandler(this.btnManageVacations_Click);
            // 
            // btnWorkingHours
            // 
            this.btnWorkingHours.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWorkingHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWorkingHours.Location = new System.Drawing.Point(12, 129);
            this.btnWorkingHours.Name = "btnWorkingHours";
            this.btnWorkingHours.Size = new System.Drawing.Size(631, 33);
            this.btnWorkingHours.TabIndex = 6;
            this.btnWorkingHours.Text = "Manage working hours";
            this.btnWorkingHours.UseVisualStyleBackColor = true;
            this.btnWorkingHours.Click += new System.EventHandler(this.btnWorkingHours_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(655, 371);
            this.Controls.Add(this.btnWorkingHours);
            this.Controls.Add(this.btnManageVacations);
            this.Controls.Add(this.lblCreator);
            this.Controls.Add(this.btnShowDepartaments);
            this.Controls.Add(this.btnPeople);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Human resource management system";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPeople;
        private System.Windows.Forms.Button btnShowDepartaments;
        private System.Windows.Forms.Label lblCreator;
        private System.Windows.Forms.Button btnManageVacations;
        private System.Windows.Forms.Button btnWorkingHours;
    }
}

