
namespace HumanResourcesManagement.View
{
    partial class FrmLicenses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLicenses));
            this.teLogin = new System.Windows.Forms.TextBox();
            this.tePassword = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblIsAdmin = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.cbIsAdmin = new System.Windows.Forms.CheckBox();
            this.gridLicenses = new System.Windows.Forms.DataGridView();
            this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColIsAdmin = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.iCustomCredintialsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLicenses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iCustomCredintialsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // teLogin
            // 
            this.teLogin.Location = new System.Drawing.Point(62, 19);
            this.teLogin.Name = "teLogin";
            this.teLogin.Size = new System.Drawing.Size(161, 20);
            this.teLogin.TabIndex = 0;
            // 
            // tePassword
            // 
            this.tePassword.Location = new System.Drawing.Point(62, 46);
            this.tePassword.Name = "tePassword";
            this.tePassword.Size = new System.Drawing.Size(161, 20);
            this.tePassword.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.lblIsAdmin);
            this.groupBox1.Controls.Add(this.lblPassword);
            this.groupBox1.Controls.Add(this.lblLogin);
            this.groupBox1.Controls.Add(this.cbIsAdmin);
            this.groupBox1.Controls.Add(this.teLogin);
            this.groupBox1.Controls.Add(this.tePassword);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 131);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add a new license";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 89);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(211, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblIsAdmin
            // 
            this.lblIsAdmin.AutoSize = true;
            this.lblIsAdmin.Location = new System.Drawing.Point(9, 72);
            this.lblIsAdmin.Name = "lblIsAdmin";
            this.lblIsAdmin.Size = new System.Drawing.Size(46, 13);
            this.lblIsAdmin.TabIndex = 5;
            this.lblIsAdmin.Text = "Is admin";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(6, 50);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(6, 23);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(33, 13);
            this.lblLogin.TabIndex = 3;
            this.lblLogin.Text = "Login";
            // 
            // cbIsAdmin
            // 
            this.cbIsAdmin.AutoSize = true;
            this.cbIsAdmin.Location = new System.Drawing.Point(62, 72);
            this.cbIsAdmin.Name = "cbIsAdmin";
            this.cbIsAdmin.Size = new System.Drawing.Size(15, 14);
            this.cbIsAdmin.TabIndex = 2;
            this.cbIsAdmin.UseVisualStyleBackColor = true;
            // 
            // gridLicenses
            // 
            this.gridLicenses.AllowUserToAddRows = false;
            this.gridLicenses.AllowUserToDeleteRows = false;
            this.gridLicenses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridLicenses.AutoGenerateColumns = false;
            this.gridLicenses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridLicenses.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridLicenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridLicenses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.loginDataGridViewTextBoxColumn,
            this.ColIsAdmin,
            this.colDelete});
            this.gridLicenses.DataSource = this.iCustomCredintialsBindingSource;
            this.gridLicenses.Location = new System.Drawing.Point(12, 149);
            this.gridLicenses.MultiSelect = false;
            this.gridLicenses.Name = "gridLicenses";
            this.gridLicenses.ReadOnly = true;
            this.gridLicenses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridLicenses.Size = new System.Drawing.Size(229, 163);
            this.gridLicenses.TabIndex = 3;
            this.gridLicenses.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridLicenses_CellContentClick);
            // 
            // loginDataGridViewTextBoxColumn
            // 
            this.loginDataGridViewTextBoxColumn.DataPropertyName = "Login";
            this.loginDataGridViewTextBoxColumn.HeaderText = "Login";
            this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            this.loginDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ColIsAdmin
            // 
            this.ColIsAdmin.DataPropertyName = "IsAdmin";
            this.ColIsAdmin.HeaderText = "Is admin";
            this.ColIsAdmin.Name = "ColIsAdmin";
            this.ColIsAdmin.ReadOnly = true;
            // 
            // Delete
            // 
            this.colDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colDelete.HeaderText = "Delete";
            this.colDelete.Name = "colDelete";
            this.colDelete.ReadOnly = true;
            this.colDelete.Text = "Delete";
            this.colDelete.ToolTipText = "Delete";
            this.colDelete.UseColumnTextForButtonValue = true;
            this.colDelete.Width = 44;
            // 
            // iCustomCredintialsBindingSource
            // 
            this.iCustomCredintialsBindingSource.DataSource = typeof(DataLibrary.Abstract.ICustomCredintials);
            // 
            // FrmLicenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(253, 324);
            this.Controls.Add(this.gridLicenses);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLicenses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage licenses";
            this.Shown += new System.EventHandler(this.FrmLicenses_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLicenses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iCustomCredintialsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox teLogin;
        private System.Windows.Forms.TextBox tePassword;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblIsAdmin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.CheckBox cbIsAdmin;
        private System.Windows.Forms.DataGridView gridLicenses;
        private System.Windows.Forms.BindingSource iCustomCredintialsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColIsAdmin;
        private System.Windows.Forms.DataGridViewButtonColumn colDelete;
    }
}