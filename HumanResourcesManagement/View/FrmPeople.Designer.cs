
namespace HumanResourcesManagement.View
{
    partial class FrmPeople
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPeople));
            this.gridPeople = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartamentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.iPersonModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAddNewPerson = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridPeople)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iPersonModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridPeople
            // 
            this.gridPeople.AllowUserToAddRows = false;
            this.gridPeople.AllowUserToDeleteRows = false;
            this.gridPeople.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridPeople.AutoGenerateColumns = false;
            this.gridPeople.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridPeople.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPeople.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.Salary,
            this.DepartamentName,
            this.Email,
            this.colEdit,
            this.colDelete});
            this.gridPeople.DataSource = this.iPersonModelBindingSource;
            this.gridPeople.Location = new System.Drawing.Point(12, 12);
            this.gridPeople.MultiSelect = false;
            this.gridPeople.Name = "gridPeople";
            this.gridPeople.ReadOnly = true;
            this.gridPeople.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPeople.Size = new System.Drawing.Size(944, 494);
            this.gridPeople.TabIndex = 0;
            this.gridPeople.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridPeople_CellContentClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.FillWeight = 81.92348F;
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.FillWeight = 81.92348F;
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "First name";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.FillWeight = 81.92348F;
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Last name";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Salary
            // 
            this.Salary.DataPropertyName = "Salary";
            this.Salary.FillWeight = 81.92348F;
            this.Salary.HeaderText = "Salary";
            this.Salary.Name = "Salary";
            this.Salary.ReadOnly = true;
            // 
            // DepartamentName
            // 
            this.DepartamentName.DataPropertyName = "DepartamentName";
            this.DepartamentName.FillWeight = 81.92348F;
            this.DepartamentName.HeaderText = "Departament";
            this.DepartamentName.Name = "DepartamentName";
            this.DepartamentName.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.FillWeight = 81.92348F;
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Edit
            // 
            this.colEdit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colEdit.FillWeight = 167.1382F;
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
            this.colDelete.FillWeight = 89.64433F;
            this.colDelete.HeaderText = "Delete";
            this.colDelete.Name = "Delete";
            this.colDelete.ReadOnly = true;
            this.colDelete.Text = "Delete";
            this.colDelete.ToolTipText = "Delete";
            this.colDelete.UseColumnTextForButtonValue = true;
            this.colDelete.Width = 44;
            // 
            // iPersonModelBindingSource
            // 
            this.iPersonModelBindingSource.DataSource = typeof(DataLibrary.Abstract.IPersonModel);
            // 
            // btnAddNewPerson
            // 
            this.btnAddNewPerson.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNewPerson.Location = new System.Drawing.Point(12, 512);
            this.btnAddNewPerson.Name = "btnAddNewPerson";
            this.btnAddNewPerson.Size = new System.Drawing.Size(944, 29);
            this.btnAddNewPerson.TabIndex = 1;
            this.btnAddNewPerson.Text = "Add new person";
            this.btnAddNewPerson.UseVisualStyleBackColor = true;
            this.btnAddNewPerson.Click += new System.EventHandler(this.btnAddNewPerson_Click);
            // 
            // FrmPeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(968, 553);
            this.Controls.Add(this.btnAddNewPerson);
            this.Controls.Add(this.gridPeople);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPeople";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List of people";
            this.Shown += new System.EventHandler(this.FrmPeople_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.gridPeople)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iPersonModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView gridPeople;
        private System.Windows.Forms.BindingSource iPersonModelBindingSource;
        private System.Windows.Forms.Button btnAddNewPerson;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salary;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartamentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewButtonColumn colEdit;
        private System.Windows.Forms.DataGridViewButtonColumn colDelete;
    }
}