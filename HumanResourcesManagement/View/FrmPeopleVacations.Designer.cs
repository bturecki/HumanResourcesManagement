
namespace HumanResourcesManagement.View
{
    partial class FrmPeopleVacations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPeopleVacations));
            this.gridVacations = new System.Windows.Forms.DataGridView();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnAddNewVacation = new System.Windows.Forms.Button();
            this.personNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personLastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateFromDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateToDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iPersonVacationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridVacations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iPersonVacationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridVacations
            // 
            this.gridVacations.AllowUserToAddRows = false;
            this.gridVacations.AllowUserToDeleteRows = false;
            this.gridVacations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridVacations.AutoGenerateColumns = false;
            this.gridVacations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridVacations.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridVacations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridVacations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.personNameDataGridViewTextBoxColumn,
            this.personLastnameDataGridViewTextBoxColumn,
            this.personIDDataGridViewTextBoxColumn,
            this.dateFromDataGridViewTextBoxColumn,
            this.dateToDataGridViewTextBoxColumn,
            this.Delete});
            this.gridVacations.DataSource = this.iPersonVacationBindingSource;
            this.gridVacations.Location = new System.Drawing.Point(12, 12);
            this.gridVacations.MultiSelect = false;
            this.gridVacations.Name = "gridVacations";
            this.gridVacations.ReadOnly = true;
            this.gridVacations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridVacations.Size = new System.Drawing.Size(776, 443);
            this.gridVacations.TabIndex = 0;
            this.gridVacations.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Delete";
            this.Delete.ToolTipText = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // btnAddNewVacation
            // 
            this.btnAddNewVacation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNewVacation.Location = new System.Drawing.Point(12, 462);
            this.btnAddNewVacation.Name = "btnAddNewVacation";
            this.btnAddNewVacation.Size = new System.Drawing.Size(776, 35);
            this.btnAddNewVacation.TabIndex = 1;
            this.btnAddNewVacation.Text = "Add new vacation";
            this.btnAddNewVacation.UseVisualStyleBackColor = true;
            this.btnAddNewVacation.Click += new System.EventHandler(this.btnAddNewVacation_Click);
            // 
            // personNameDataGridViewTextBoxColumn
            // 
            this.personNameDataGridViewTextBoxColumn.DataPropertyName = "PersonName";
            this.personNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.personNameDataGridViewTextBoxColumn.Name = "personNameDataGridViewTextBoxColumn";
            this.personNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // personLastnameDataGridViewTextBoxColumn
            // 
            this.personLastnameDataGridViewTextBoxColumn.DataPropertyName = "PersonLastname";
            this.personLastnameDataGridViewTextBoxColumn.HeaderText = "Lastname";
            this.personLastnameDataGridViewTextBoxColumn.Name = "personLastnameDataGridViewTextBoxColumn";
            this.personLastnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // personIDDataGridViewTextBoxColumn
            // 
            this.personIDDataGridViewTextBoxColumn.DataPropertyName = "PersonID";
            this.personIDDataGridViewTextBoxColumn.HeaderText = "PersonID";
            this.personIDDataGridViewTextBoxColumn.Name = "personIDDataGridViewTextBoxColumn";
            this.personIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.personIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // dateFromDataGridViewTextBoxColumn
            // 
            this.dateFromDataGridViewTextBoxColumn.DataPropertyName = "DateFrom";
            this.dateFromDataGridViewTextBoxColumn.HeaderText = "Date from";
            this.dateFromDataGridViewTextBoxColumn.Name = "dateFromDataGridViewTextBoxColumn";
            this.dateFromDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateToDataGridViewTextBoxColumn
            // 
            this.dateToDataGridViewTextBoxColumn.DataPropertyName = "DateTo";
            this.dateToDataGridViewTextBoxColumn.HeaderText = "Date to";
            this.dateToDataGridViewTextBoxColumn.Name = "dateToDataGridViewTextBoxColumn";
            this.dateToDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iPersonVacationBindingSource
            // 
            this.iPersonVacationBindingSource.DataSource = typeof(DataLibrary.Abstract.IPersonVacation);
            // 
            // FrmPeopleVacations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 509);
            this.Controls.Add(this.btnAddNewVacation);
            this.Controls.Add(this.gridVacations);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPeopleVacations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "People vacations";
            this.Shown += new System.EventHandler(this.FrmPeopleVacations_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.gridVacations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iPersonVacationBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridVacations;
        private System.Windows.Forms.BindingSource iPersonVacationBindingSource;
        private System.Windows.Forms.Button btnAddNewVacation;
        private System.Windows.Forms.DataGridViewTextBoxColumn personNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personLastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateFromDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateToDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}