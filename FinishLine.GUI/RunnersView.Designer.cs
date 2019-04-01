namespace FinishLine
{
    partial class RunnersView
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
            this.gridRunners = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.countryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.runnerViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.runnerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridRunners)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.runnerViewModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.runnerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridRunners
            // 
            this.gridRunners.AllowUserToAddRows = false;
            this.gridRunners.AllowUserToDeleteRows = false;
            this.gridRunners.AutoGenerateColumns = false;
            this.gridRunners.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridRunners.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colName,
            this.colCountry,
            this.colAge,
            this.colSex});
            this.gridRunners.DataSource = this.runnerViewModelBindingSource;
            this.gridRunners.Location = new System.Drawing.Point(13, 13);
            this.gridRunners.Name = "gridRunners";
            this.gridRunners.ReadOnly = true;
            this.gridRunners.Size = new System.Drawing.Size(558, 372);
            this.gridRunners.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(577, 415);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(13, 415);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(577, 13);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(94, 23);
            this.btnNew.TabIndex = 3;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(577, 42);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(94, 23);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(577, 71);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // countryBindingSource
            // 
            this.countryBindingSource.DataSource = typeof(FinishLine.Core.Country);
            // 
            // runnerViewModelBindingSource
            // 
            this.runnerViewModelBindingSource.DataSource = typeof(FinishLine.Core.RunnerViewModel);
            // 
            // runnerBindingSource
            // 
            this.runnerBindingSource.DataSource = typeof(FinishLine.Core.Runner);
            // 
            // colID
            // 
            this.colID.DataPropertyName = "Id";
            this.colID.HeaderText = "Id";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            // 
            // colName
            // 
            this.colName.DataPropertyName = "Name";
            this.colName.HeaderText = "Name";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colCountry
            // 
            this.colCountry.DataPropertyName = "Country";
            this.colCountry.HeaderText = "Country";
            this.colCountry.Name = "colCountry";
            this.colCountry.ReadOnly = true;
            this.colCountry.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colCountry.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colAge
            // 
            this.colAge.DataPropertyName = "Age";
            this.colAge.HeaderText = "Age";
            this.colAge.Name = "colAge";
            this.colAge.ReadOnly = true;
            // 
            // colSex
            // 
            this.colSex.DataPropertyName = "Sex";
            this.colSex.HeaderText = "Sex";
            this.colSex.Name = "colSex";
            this.colSex.ReadOnly = true;
            // 
            // RunnersView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gridRunners);
            this.Name = "RunnersView";
            this.Text = "Runners";
            ((System.ComponentModel.ISupportInitialize)(this.gridRunners)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.runnerViewModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.runnerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridRunners;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.BindingSource countryBindingSource;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.BindingSource runnerViewModelBindingSource;
        private System.Windows.Forms.BindingSource runnerBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCountry;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSex;
    }
}