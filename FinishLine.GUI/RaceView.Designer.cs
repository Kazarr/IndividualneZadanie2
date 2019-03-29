namespace FinishLine
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.menuStripFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(380, 342);
            this.dataGridView1.TabIndex = 1;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(415, 96);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(380, 342);
            this.dataGridView2.TabIndex = 2;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(366, 67);
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
            this.menuStripFile.Size = new System.Drawing.Size(807, 24);
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
            this.runnersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.runnersToolStripMenuItem.Text = "Runners";
            this.runnersToolStripMenuItem.Click += new System.EventHandler(this.runnersToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem1
            // 
            this.loadToolStripMenuItem1.Name = "loadToolStripMenuItem1";
            this.loadToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.loadToolStripMenuItem1.Text = "Load";
            // 
            // saveAsToolStripMenuItem1
            // 
            this.saveAsToolStripMenuItem1.Name = "saveAsToolStripMenuItem1";
            this.saveAsToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.saveAsToolStripMenuItem1.Text = "Save as...";
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // lblLapLenght
            // 
            this.lblLapLenght.AutoSize = true;
            this.lblLapLenght.Location = new System.Drawing.Point(9, 24);
            this.lblLapLenght.Name = "lblLapLenght";
            this.lblLapLenght.Size = new System.Drawing.Size(61, 13);
            this.lblLapLenght.TabIndex = 5;
            this.lblLapLenght.Text = "Lap Lenght";
            // 
            // txtLapCount
            // 
            this.txtLapCount.Location = new System.Drawing.Point(76, 21);
            this.txtLapCount.Name = "txtLapCount";
            this.txtLapCount.Size = new System.Drawing.Size(100, 20);
            this.txtLapCount.TabIndex = 6;
            // 
            // lblLapCount
            // 
            this.lblLapCount.AutoSize = true;
            this.lblLapCount.Location = new System.Drawing.Point(9, 47);
            this.lblLapCount.Name = "lblLapCount";
            this.lblLapCount.Size = new System.Drawing.Size(56, 13);
            this.lblLapCount.TabIndex = 7;
            this.lblLapCount.Text = "Lap Count";
            // 
            // txtLapLenght
            // 
            this.txtLapLenght.Location = new System.Drawing.Point(75, 44);
            this.txtLapLenght.Name = "txtLapLenght";
            this.txtLapLenght.Size = new System.Drawing.Size(100, 20);
            this.txtLapLenght.TabIndex = 8;
            // 
            // RaceView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 450);
            this.Controls.Add(this.txtLapLenght);
            this.Controls.Add(this.lblLapCount);
            this.Controls.Add(this.txtLapCount);
            this.Controls.Add(this.lblLapLenght);
            this.Controls.Add(this.menuStripFile);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.MainMenuStrip = this.menuStripFile;
            this.Name = "RaceView";
            this.Text = "RaceView";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.menuStripFile.ResumeLayout(false);
            this.menuStripFile.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
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
    }
}

