
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
            this.gridDepartaments = new System.Windows.Forms.DataGridView();
            this.iDepartamentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAddNewDepartament = new System.Windows.Forms.Button();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridDepartaments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iDepartamentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridDepartaments
            // 
            this.gridDepartaments.AllowUserToAddRows = false;
            this.gridDepartaments.AllowUserToDeleteRows = false;
            this.gridDepartaments.AutoGenerateColumns = false;
            this.gridDepartaments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridDepartaments.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridDepartaments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDepartaments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.Edit});
            this.gridDepartaments.DataSource = this.iDepartamentBindingSource;
            this.gridDepartaments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridDepartaments.Location = new System.Drawing.Point(0, 0);
            this.gridDepartaments.Name = "gridDepartaments";
            this.gridDepartaments.ReadOnly = true;
            this.gridDepartaments.Size = new System.Drawing.Size(616, 485);
            this.gridDepartaments.TabIndex = 0;
            this.gridDepartaments.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridDepartaments_CellContentClick);
            // 
            // iDepartamentBindingSource
            // 
            this.iDepartamentBindingSource.DataSource = typeof(DataLibrary.Abstract.IDepartament);
            // 
            // btnAddNewDepartament
            // 
            this.btnAddNewDepartament.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNewDepartament.Location = new System.Drawing.Point(0, 462);
            this.btnAddNewDepartament.Name = "btnAddNewDepartament";
            this.btnAddNewDepartament.Size = new System.Drawing.Size(616, 23);
            this.btnAddNewDepartament.TabIndex = 1;
            this.btnAddNewDepartament.Text = "Add new departament";
            this.btnAddNewDepartament.UseVisualStyleBackColor = true;
            this.btnAddNewDepartament.Click += new System.EventHandler(this.btnAddNewPerson_Click);
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
            this.Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Text = "Edit";
            this.Edit.ToolTipText = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            this.Edit.Width = 31;
            // 
            // FrmDepartaments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 485);
            this.Controls.Add(this.btnAddNewDepartament);
            this.Controls.Add(this.gridDepartaments);
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
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
    }
}