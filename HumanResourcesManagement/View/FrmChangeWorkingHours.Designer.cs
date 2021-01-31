
namespace HumanResourcesManagement.View
{
    partial class FrmChangeWorkingHours
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChangeWorkingHours));
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.lblTimeFrom = new System.Windows.Forms.Label();
            this.lblTimeTo = new System.Windows.Forms.Label();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerFrom.Location = new System.Drawing.Point(12, 25);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.ShowUpDown = true;
            this.dateTimePickerFrom.Size = new System.Drawing.Size(209, 20);
            this.dateTimePickerFrom.TabIndex = 0;
            // 
            // lblTimeFrom
            // 
            this.lblTimeFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTimeFrom.AutoSize = true;
            this.lblTimeFrom.BackColor = System.Drawing.Color.Transparent;
            this.lblTimeFrom.Location = new System.Drawing.Point(12, 9);
            this.lblTimeFrom.Name = "lblTimeFrom";
            this.lblTimeFrom.Size = new System.Drawing.Size(53, 13);
            this.lblTimeFrom.TabIndex = 1;
            this.lblTimeFrom.Text = "Time from";
            // 
            // lblTimeTo
            // 
            this.lblTimeTo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTimeTo.AutoSize = true;
            this.lblTimeTo.BackColor = System.Drawing.Color.Transparent;
            this.lblTimeTo.Location = new System.Drawing.Point(12, 57);
            this.lblTimeTo.Name = "lblTimeTo";
            this.lblTimeTo.Size = new System.Drawing.Size(42, 13);
            this.lblTimeTo.TabIndex = 2;
            this.lblTimeTo.Text = "Time to";
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerTo.Location = new System.Drawing.Point(12, 73);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.ShowUpDown = true;
            this.dateTimePickerTo.Size = new System.Drawing.Size(209, 20);
            this.dateTimePickerTo.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(12, 110);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(209, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FrmChangeWorkingHours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(233, 155);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dateTimePickerTo);
            this.Controls.Add(this.lblTimeTo);
            this.Controls.Add(this.lblTimeFrom);
            this.Controls.Add(this.dateTimePickerFrom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmChangeWorkingHours";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.Label lblTimeFrom;
        private System.Windows.Forms.Label lblTimeTo;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.Button btnSave;
    }
}