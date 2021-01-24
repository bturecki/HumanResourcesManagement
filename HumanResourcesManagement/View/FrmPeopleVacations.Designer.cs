
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iPersonVacationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personLastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateFromDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateToDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddNewVacation = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iPersonVacationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.personNameDataGridViewTextBoxColumn,
            this.personLastnameDataGridViewTextBoxColumn,
            this.personIDDataGridViewTextBoxColumn,
            this.dateFromDataGridViewTextBoxColumn,
            this.dateToDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.iPersonVacationBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(776, 443);
            this.dataGridView1.TabIndex = 0;
            // 
            // iPersonVacationBindingSource
            // 
            this.iPersonVacationBindingSource.DataSource = typeof(DataLibrary.Abstract.IPersonVacation);
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
            // FrmPeopleVacations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 509);
            this.Controls.Add(this.btnAddNewVacation);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPeopleVacations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "People vacations";
            this.Shown += new System.EventHandler(this.FrmPeopleVacations_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iPersonVacationBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource iPersonVacationBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn personNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personLastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateFromDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateToDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnAddNewVacation;
    }
}