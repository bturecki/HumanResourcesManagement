
namespace HumanResourcesManagement.View
{
    partial class FrmWorkingHours
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmWorkingHours));
            this.gvWorkingHours = new System.Windows.Forms.DataGridView();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departamentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hourFromDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hourToDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.iPersonWorkingHoursBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gvWorkingHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iPersonWorkingHoursBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gvWorkingHours
            // 
            this.gvWorkingHours.AllowUserToAddRows = false;
            this.gvWorkingHours.AllowUserToDeleteRows = false;
            this.gvWorkingHours.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvWorkingHours.AutoGenerateColumns = false;
            this.gvWorkingHours.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvWorkingHours.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gvWorkingHours.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvWorkingHours.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.departamentNameDataGridViewTextBoxColumn,
            this.hourFromDataGridViewTextBoxColumn,
            this.hourToDataGridViewTextBoxColumn,
            this.colEdit});
            this.gvWorkingHours.DataSource = this.iPersonWorkingHoursBindingSource;
            this.gvWorkingHours.Location = new System.Drawing.Point(12, 12);
            this.gvWorkingHours.MultiSelect = false;
            this.gvWorkingHours.Name = "gvWorkingHours";
            this.gvWorkingHours.ReadOnly = true;
            this.gvWorkingHours.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvWorkingHours.Size = new System.Drawing.Size(905, 532);
            this.gvWorkingHours.TabIndex = 0;
            this.gvWorkingHours.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvWorkingHours_CellContentClick);
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "First name";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Last name";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // departamentNameDataGridViewTextBoxColumn
            // 
            this.departamentNameDataGridViewTextBoxColumn.DataPropertyName = "DepartamentName";
            this.departamentNameDataGridViewTextBoxColumn.HeaderText = "Departament";
            this.departamentNameDataGridViewTextBoxColumn.Name = "departamentNameDataGridViewTextBoxColumn";
            this.departamentNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hourFromDataGridViewTextBoxColumn
            // 
            this.hourFromDataGridViewTextBoxColumn.DataPropertyName = "HourFrom";
            this.hourFromDataGridViewTextBoxColumn.HeaderText = "Hour from";
            this.hourFromDataGridViewTextBoxColumn.Name = "hourFromDataGridViewTextBoxColumn";
            this.hourFromDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hourToDataGridViewTextBoxColumn
            // 
            this.hourToDataGridViewTextBoxColumn.DataPropertyName = "HourTo";
            this.hourToDataGridViewTextBoxColumn.HeaderText = "Hour to";
            this.hourToDataGridViewTextBoxColumn.Name = "hourToDataGridViewTextBoxColumn";
            this.hourToDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // edit
            // 
            this.colEdit.HeaderText = "Edit";
            this.colEdit.Name = "edit";
            this.colEdit.ReadOnly = true;
            this.colEdit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colEdit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colEdit.Text = "Edit";
            this.colEdit.ToolTipText = "Edit";
            this.colEdit.UseColumnTextForButtonValue = true;
            // 
            // iPersonWorkingHoursBindingSource
            // 
            this.iPersonWorkingHoursBindingSource.DataSource = typeof(DataLibrary.Abstract.IPersonWorkingHours);
            // 
            // FrmWorkingHours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(929, 556);
            this.Controls.Add(this.gvWorkingHours);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmWorkingHours";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List of working hours";
            this.Shown += new System.EventHandler(this.FrmWorkingHours_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.gvWorkingHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iPersonWorkingHoursBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gvWorkingHours;
        private System.Windows.Forms.BindingSource iPersonWorkingHoursBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departamentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hourFromDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hourToDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn colEdit;
    }
}