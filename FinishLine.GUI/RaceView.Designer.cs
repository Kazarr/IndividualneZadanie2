﻿namespace FinishLine
{
    partial class RaceView
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
            this.gridLapOverview = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finishedLapsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finishedLapTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AverageSpeed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finishedLapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridRaceOverview = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bestLapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.raceTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnStart = new System.Windows.Forms.Button();
            this.menuStripFile = new System.Windows.Forms.MenuStrip();
            this.trackToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.runnersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lblLapLenght = new System.Windows.Forms.Label();
            this.txtLapCount = new System.Windows.Forms.TextBox();
            this.lblLapCount = new System.Windows.Forms.Label();
            this.txtLapLenght = new System.Windows.Forms.TextBox();
            this.lblReward = new System.Windows.Forms.Label();
            this.txtReward = new System.Windows.Forms.TextBox();
            this.lblCurrentTime = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblRunnerFinished = new System.Windows.Forms.Label();
            this.txtRunnerNumber = new System.Windows.Forms.TextBox();
            this.btnLapFinished = new System.Windows.Forms.Button();
            this.GrouperLap = new Subro.Controls.DataGridViewGrouper(this.components);
            this.lblErrorId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridLapOverview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finishedLapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridRaceOverview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultBindingSource)).BeginInit();
            this.menuStripFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridLapOverview
            // 
            this.gridLapOverview.AllowUserToAddRows = false;
            this.gridLapOverview.AllowUserToDeleteRows = false;
            this.gridLapOverview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gridLapOverview.AutoGenerateColumns = false;
            this.gridLapOverview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridLapOverview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.countryDataGridViewTextBoxColumn,
            this.finishedLapsDataGridViewTextBoxColumn,
            this.finishedLapTimeDataGridViewTextBoxColumn,
            this.AverageSpeed});
            this.gridLapOverview.DataSource = this.finishedLapBindingSource;
            this.gridLapOverview.Location = new System.Drawing.Point(14, 166);
            this.gridLapOverview.Name = "gridLapOverview";
            this.gridLapOverview.ReadOnly = true;
            this.gridLapOverview.Size = new System.Drawing.Size(421, 272);
            this.gridLapOverview.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // countryDataGridViewTextBoxColumn
            // 
            this.countryDataGridViewTextBoxColumn.DataPropertyName = "Country";
            this.countryDataGridViewTextBoxColumn.HeaderText = "Country";
            this.countryDataGridViewTextBoxColumn.Name = "countryDataGridViewTextBoxColumn";
            this.countryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // finishedLapsDataGridViewTextBoxColumn
            // 
            this.finishedLapsDataGridViewTextBoxColumn.DataPropertyName = "FinishedLaps";
            this.finishedLapsDataGridViewTextBoxColumn.HeaderText = "FinishedLaps";
            this.finishedLapsDataGridViewTextBoxColumn.Name = "finishedLapsDataGridViewTextBoxColumn";
            this.finishedLapsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // finishedLapTimeDataGridViewTextBoxColumn
            // 
            this.finishedLapTimeDataGridViewTextBoxColumn.DataPropertyName = "FinishedLapTime";
            this.finishedLapTimeDataGridViewTextBoxColumn.HeaderText = "FinishedLapTime";
            this.finishedLapTimeDataGridViewTextBoxColumn.Name = "finishedLapTimeDataGridViewTextBoxColumn";
            this.finishedLapTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // AverageSpeed
            // 
            this.AverageSpeed.DataPropertyName = "AverageSpeed";
            this.AverageSpeed.HeaderText = "AverageSpeed";
            this.AverageSpeed.Name = "AverageSpeed";
            this.AverageSpeed.ReadOnly = true;
            // 
            // finishedLapBindingSource
            // 
            this.finishedLapBindingSource.DataSource = typeof(FinishLine.Core.FinishedLap);
            // 
            // gridRaceOverview
            // 
            this.gridRaceOverview.AllowUserToAddRows = false;
            this.gridRaceOverview.AllowUserToDeleteRows = false;
            this.gridRaceOverview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.gridRaceOverview.AutoGenerateColumns = false;
            this.gridRaceOverview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridRaceOverview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.positionDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn1,
            this.bestLapDataGridViewTextBoxColumn,
            this.raceTimeDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1});
            this.gridRaceOverview.DataSource = this.resultBindingSource;
            this.gridRaceOverview.Location = new System.Drawing.Point(457, 166);
            this.gridRaceOverview.Name = "gridRaceOverview";
            this.gridRaceOverview.ReadOnly = true;
            this.gridRaceOverview.Size = new System.Drawing.Size(403, 272);
            this.gridRaceOverview.TabIndex = 2;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // positionDataGridViewTextBoxColumn1
            // 
            this.positionDataGridViewTextBoxColumn1.DataPropertyName = "Position";
            this.positionDataGridViewTextBoxColumn1.HeaderText = "Position";
            this.positionDataGridViewTextBoxColumn1.Name = "positionDataGridViewTextBoxColumn1";
            this.positionDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // bestLapDataGridViewTextBoxColumn
            // 
            this.bestLapDataGridViewTextBoxColumn.DataPropertyName = "BestLap";
            this.bestLapDataGridViewTextBoxColumn.HeaderText = "BestLap";
            this.bestLapDataGridViewTextBoxColumn.Name = "bestLapDataGridViewTextBoxColumn";
            this.bestLapDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // raceTimeDataGridViewTextBoxColumn
            // 
            this.raceTimeDataGridViewTextBoxColumn.DataPropertyName = "RaceTime";
            this.raceTimeDataGridViewTextBoxColumn.HeaderText = "RaceTime";
            this.raceTimeDataGridViewTextBoxColumn.Name = "raceTimeDataGridViewTextBoxColumn";
            this.raceTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "AverageSpeed";
            this.dataGridViewTextBoxColumn1.HeaderText = "AverageSpeed";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // resultBindingSource
            // 
            this.resultBindingSource.DataSource = typeof(FinishLine.Core.RaceResult);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(15, 137);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start race";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // menuStripFile
            // 
            this.menuStripFile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trackToolStripMenuItem1});
            this.menuStripFile.Location = new System.Drawing.Point(0, 0);
            this.menuStripFile.Name = "menuStripFile";
            this.menuStripFile.Size = new System.Drawing.Size(939, 24);
            this.menuStripFile.TabIndex = 4;
            this.menuStripFile.Text = "menuStrip1";
            // 
            // trackToolStripMenuItem1
            // 
            this.trackToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runnersToolStripMenuItem,
            this.loadToolStripMenuItem1,
            this.saveAsToolStripMenuItem1,
            this.exitToolStripMenuItem1});
            this.trackToolStripMenuItem1.Name = "trackToolStripMenuItem1";
            this.trackToolStripMenuItem1.Size = new System.Drawing.Size(50, 20);
            this.trackToolStripMenuItem1.Text = "Menu";
            // 
            // runnersToolStripMenuItem
            // 
            this.runnersToolStripMenuItem.Name = "runnersToolStripMenuItem";
            this.runnersToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.runnersToolStripMenuItem.Text = "Runners";
            this.runnersToolStripMenuItem.Click += new System.EventHandler(this.runnersToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem1
            // 
            this.loadToolStripMenuItem1.Name = "loadToolStripMenuItem1";
            this.loadToolStripMenuItem1.Size = new System.Drawing.Size(127, 22);
            this.loadToolStripMenuItem1.Text = "Load stats";
            this.loadToolStripMenuItem1.Click += new System.EventHandler(this.loadToolStripMenuItem1_Click);
            // 
            // saveAsToolStripMenuItem1
            // 
            this.saveAsToolStripMenuItem1.Name = "saveAsToolStripMenuItem1";
            this.saveAsToolStripMenuItem1.Size = new System.Drawing.Size(127, 22);
            this.saveAsToolStripMenuItem1.Text = "Save as...";
            this.saveAsToolStripMenuItem1.Click += new System.EventHandler(this.saveAsToolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(127, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // lblLapLenght
            // 
            this.lblLapLenght.AutoSize = true;
            this.lblLapLenght.Location = new System.Drawing.Point(9, 24);
            this.lblLapLenght.Name = "lblLapLenght";
            this.lblLapLenght.Size = new System.Drawing.Size(56, 13);
            this.lblLapLenght.TabIndex = 5;
            this.lblLapLenght.Text = "Lap Count";
            // 
            // txtLapCount
            // 
            this.txtLapCount.Location = new System.Drawing.Point(76, 21);
            this.txtLapCount.Name = "txtLapCount";
            this.txtLapCount.Size = new System.Drawing.Size(100, 20);
            this.txtLapCount.TabIndex = 6;
            this.txtLapCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLapCount_KeyPress);
            // 
            // lblLapCount
            // 
            this.lblLapCount.AutoSize = true;
            this.lblLapCount.Location = new System.Drawing.Point(9, 50);
            this.lblLapCount.Name = "lblLapCount";
            this.lblLapCount.Size = new System.Drawing.Size(61, 13);
            this.lblLapCount.TabIndex = 7;
            this.lblLapCount.Text = "Lap Lenght";
            // 
            // txtLapLenght
            // 
            this.txtLapLenght.Location = new System.Drawing.Point(76, 47);
            this.txtLapLenght.Name = "txtLapLenght";
            this.txtLapLenght.Size = new System.Drawing.Size(100, 20);
            this.txtLapLenght.TabIndex = 8;
            this.txtLapLenght.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLapLenght_KeyPress);
            // 
            // lblReward
            // 
            this.lblReward.AutoSize = true;
            this.lblReward.Location = new System.Drawing.Point(12, 76);
            this.lblReward.Name = "lblReward";
            this.lblReward.Size = new System.Drawing.Size(44, 13);
            this.lblReward.TabIndex = 9;
            this.lblReward.Text = "Reward";
            // 
            // txtReward
            // 
            this.txtReward.Location = new System.Drawing.Point(76, 73);
            this.txtReward.Name = "txtReward";
            this.txtReward.Size = new System.Drawing.Size(100, 20);
            this.txtReward.TabIndex = 10;
            this.txtReward.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtReward_KeyPress);
            // 
            // lblCurrentTime
            // 
            this.lblCurrentTime.AutoSize = true;
            this.lblCurrentTime.Location = new System.Drawing.Point(96, 121);
            this.lblCurrentTime.Name = "lblCurrentTime";
            this.lblCurrentTime.Size = new System.Drawing.Size(78, 13);
            this.lblCurrentTime.TabIndex = 11;
            this.lblCurrentTime.Text = "Race start time";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(96, 142);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(35, 13);
            this.lblTime.TabIndex = 12;
            this.lblTime.Text = "label1";
            this.lblTime.Visible = false;
            // 
            // lblRunnerFinished
            // 
            this.lblRunnerFinished.AutoSize = true;
            this.lblRunnerFinished.Location = new System.Drawing.Point(224, 121);
            this.lblRunnerFinished.Name = "lblRunnerFinished";
            this.lblRunnerFinished.Size = new System.Drawing.Size(80, 13);
            this.lblRunnerFinished.TabIndex = 13;
            this.lblRunnerFinished.Text = "Runner number";
            // 
            // txtRunnerNumber
            // 
            this.txtRunnerNumber.Enabled = false;
            this.txtRunnerNumber.Location = new System.Drawing.Point(227, 142);
            this.txtRunnerNumber.Name = "txtRunnerNumber";
            this.txtRunnerNumber.Size = new System.Drawing.Size(100, 20);
            this.txtRunnerNumber.TabIndex = 14;
            // 
            // btnLapFinished
            // 
            this.btnLapFinished.Enabled = false;
            this.btnLapFinished.Location = new System.Drawing.Point(333, 142);
            this.btnLapFinished.Name = "btnLapFinished";
            this.btnLapFinished.Size = new System.Drawing.Size(61, 23);
            this.btnLapFinished.TabIndex = 15;
            this.btnLapFinished.Text = "Finish lap";
            this.btnLapFinished.UseVisualStyleBackColor = true;
            this.btnLapFinished.Click += new System.EventHandler(this.btnLapFinished_Click_1);
            // 
            // lblErrorId
            // 
            this.lblErrorId.AutoSize = true;
            this.lblErrorId.Location = new System.Drawing.Point(310, 121);
            this.lblErrorId.Name = "lblErrorId";
            this.lblErrorId.Size = new System.Drawing.Size(35, 13);
            this.lblErrorId.TabIndex = 16;
            this.lblErrorId.Text = "label1";
            this.lblErrorId.Visible = false;
            // 
            // RaceView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 450);
            this.Controls.Add(this.lblErrorId);
            this.Controls.Add(this.btnLapFinished);
            this.Controls.Add(this.txtRunnerNumber);
            this.Controls.Add(this.lblRunnerFinished);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblCurrentTime);
            this.Controls.Add(this.txtReward);
            this.Controls.Add(this.lblReward);
            this.Controls.Add(this.txtLapLenght);
            this.Controls.Add(this.lblLapCount);
            this.Controls.Add(this.txtLapCount);
            this.Controls.Add(this.lblLapLenght);
            this.Controls.Add(this.menuStripFile);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.gridRaceOverview);
            this.Controls.Add(this.gridLapOverview);
            this.MainMenuStrip = this.menuStripFile;
            this.Name = "RaceView";
            this.Text = "RaceView";
            ((System.ComponentModel.ISupportInitialize)(this.gridLapOverview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finishedLapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridRaceOverview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultBindingSource)).EndInit();
            this.menuStripFile.ResumeLayout(false);
            this.menuStripFile.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView gridLapOverview;
        private System.Windows.Forms.DataGridView gridRaceOverview;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.MenuStrip menuStripFile;
        private System.Windows.Forms.ToolStripMenuItem trackToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem runnersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.Label lblLapLenght;
        private System.Windows.Forms.TextBox txtLapCount;
        private System.Windows.Forms.Label lblLapCount;
        private System.Windows.Forms.TextBox txtLapLenght;
        private System.Windows.Forms.Label lblReward;
        private System.Windows.Forms.TextBox txtReward;
        private System.Windows.Forms.Label lblCurrentTime;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblRunnerFinished;
        private System.Windows.Forms.TextBox txtRunnerNumber;
        private System.Windows.Forms.Button btnLapFinished;
        private Subro.Controls.DataGridViewGrouper GrouperLap;
        private System.Windows.Forms.BindingSource finishedLapBindingSource;
        private System.Windows.Forms.BindingSource resultBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn finishedLapsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn finishedLapTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AverageSpeed;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bestLapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn raceTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label lblErrorId;
    }
}

