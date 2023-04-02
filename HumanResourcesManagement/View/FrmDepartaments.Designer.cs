
namespace HumanResourcesManagement.View
{
    partial class FrmDepartaments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDepartaments));
            this.gridDepartaments = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.iDepartamentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAddNewDepartament = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridDepartaments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iDepartamentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridDepartaments
            // 
            this.gridDepartaments.AllowUserToAddRows = false;
            this.gridDepartaments.AllowUserToDeleteRows = false;
            this.gridDepartaments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridDepartaments.AutoGenerateColumns = false;
            this.gridDepartaments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridDepartaments.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridDepartaments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDepartaments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.colEdit,
            this.colDelete});
            this.gridDepartaments.DataSource = this.iDepartamentBindingSource;
            this.gridDepartaments.Location = new System.Drawing.Point(12, 12);
            this.gridDepartaments.MultiSelect = false;
            this.gridDepartaments.Name = "gridDepartaments";
            this.gridDepartaments.ReadOnly = true;
            this.gridDepartaments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridDepartaments.Size = new System.Drawing.Size(886, 499);
            this.gridDepartaments.TabIndex = 0;
            this.gridDepartaments.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridDepartaments_CellContentClick);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Edit
            // 
            this.colEdit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colEdit.HeaderText = "Edit";
            this.colEdit.Name = "Edit";
            this.colEdit.ReadOnly = true;
            this.colEdit.Text = "Edit";
            this.colEdit.ToolTipText = "Edit";
            this.colEdit.UseColumnTextForButtonValue = true;
            this.colEdit.Width = 31;
            // 
            // Delete
            // 
            this.colDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colDelete.HeaderText = "Delete";
            this.colDelete.Name = "Delete";
            this.colDelete.ReadOnly = true;
            this.colDelete.Text = "Delete";
            this.colDelete.ToolTipText = "Delete";
            this.colDelete.UseColumnTextForButtonValue = true;
            this.colDelete.Width = 44;
            // 
            // iDepartamentBindingSource
            // 
            this.iDepartamentBindingSource.DataSource = typeof(DataLibrary.Abstract.IDepartament);
            // 
            // btnAddNewDepartament
            // 
            this.btnAddNewDepartament.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNewDepartament.Location = new System.Drawing.Point(12, 517);
            this.btnAddNewDepartament.Name = "btnAddNewDepartament";
            this.btnAddNewDepartament.Size = new System.Drawing.Size(886, 29);
            this.btnAddNewDepartament.TabIndex = 1;
            this.btnAddNewDepartament.Text = "Add new departament";
            this.btnAddNewDepartament.UseVisualStyleBackColor = true;
            this.btnAddNewDepartament.Click += new System.EventHandler(this.btnAddNewPerson_Click);
            // 
            // FrmDepartaments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(910, 562);
            this.Controls.Add(this.btnAddNewDepartament);
            this.Controls.Add(this.gridDepartaments);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmDepartaments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List of departaments";
            this.Shown += new System.EventHandler(this.FrmPeople_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.gridDepartaments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iDepartamentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView gridDepartaments;
        private System.Windows.Forms.Button btnAddNewDepartament;
        private System.Windows.Forms.BindingSource iDepartamentBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn colEdit;
        private System.Windows.Forms.DataGridViewButtonColumn colDelete;
    }
}