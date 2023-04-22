
namespace HumanResourcesManagement.View
{
    partial class FrmLoginLogs
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLoginLogs));
            this.gridLoginLogs = new System.Windows.Forms.DataGridView();
            this.iLoginLogsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LogTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridLoginLogs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iLoginLogsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridLoginLogs
            // 
            this.gridLoginLogs.AllowUserToAddRows = false;
            this.gridLoginLogs.AllowUserToDeleteRows = false;
            this.gridLoginLogs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridLoginLogs.AutoGenerateColumns = false;
            this.gridLoginLogs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridLoginLogs.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridLoginLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridLoginLogs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.loginDataGridViewTextBoxColumn,
            this.dateTimeDataGridViewTextBoxColumn,
            this.LogTypeDataGridViewTextBoxColumn});
            this.gridLoginLogs.DataSource = this.iLoginLogsBindingSource;
            this.gridLoginLogs.Location = new System.Drawing.Point(12, 12);
            this.gridLoginLogs.MultiSelect = false;
            this.gridLoginLogs.Name = "gridLoginLogs";
            this.gridLoginLogs.ReadOnly = true;
            this.gridLoginLogs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridLoginLogs.Size = new System.Drawing.Size(452, 216);
            this.gridLoginLogs.TabIndex = 4;
            // 
            // iLoginLogsBindingSource
            // 
            this.iLoginLogsBindingSource.DataSource = typeof(DataLibrary.Abstract.ILoginLogs);
            // 
            // loginDataGridViewTextBoxColumn
            // 
            this.loginDataGridViewTextBoxColumn.DataPropertyName = "Login";
            this.loginDataGridViewTextBoxColumn.HeaderText = "Login";
            this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            this.loginDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateTimeDataGridViewTextBoxColumn
            // 
            this.dateTimeDataGridViewTextBoxColumn.DataPropertyName = "DateTime";
            this.dateTimeDataGridViewTextBoxColumn.HeaderText = "Date and time";
            this.dateTimeDataGridViewTextBoxColumn.Name = "dateTimeDataGridViewTextBoxColumn";
            this.dateTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // LogTypeDataGridViewTextBoxColumn
            // 
            this.LogTypeDataGridViewTextBoxColumn.DataPropertyName = "LogType";
            this.LogTypeDataGridViewTextBoxColumn.HeaderText = "Log type";
            this.LogTypeDataGridViewTextBoxColumn.Name = "LogTypeDataGridViewTextBoxColumn";
            this.LogTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FrmLoginLogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(476, 240);
            this.Controls.Add(this.gridLoginLogs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLoginLogs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login logs";
            this.Shown += new System.EventHandler(this.FrmLoginLogs_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.gridLoginLogs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iLoginLogsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewButtonColumn colEdit;
        private System.Windows.Forms.DataGridViewButtonColumn colDelete;
        private System.Windows.Forms.DataGridView gridLoginLogs;
        private System.Windows.Forms.BindingSource iLoginLogsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LogTypeDataGridViewTextBoxColumn;
    }
}