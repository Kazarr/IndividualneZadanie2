namespace FinishLine
{
    partial class LapView
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
            this.txtLapCount = new System.Windows.Forms.TextBox();
            this.lblLapCount = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblLapLenght = new System.Windows.Forms.Label();
            this.txtRunnersRewarded = new System.Windows.Forms.TextBox();
            this.lblReward = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtLapCount
            // 
            this.txtLapCount.Location = new System.Drawing.Point(15, 25);
            this.txtLapCount.Name = "txtLapCount";
            this.txtLapCount.Size = new System.Drawing.Size(53, 20);
            this.txtLapCount.TabIndex = 0;
            // 
            // lblLapCount
            // 
            this.lblLapCount.AutoSize = true;
            this.lblLapCount.Location = new System.Drawing.Point(12, 9);
            this.lblLapCount.Name = "lblLapCount";
            this.lblLapCount.Size = new System.Drawing.Size(56, 13);
            this.lblLapCount.TabIndex = 1;
            this.lblLapCount.Text = "Lap Count";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 87);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(56, 20);
            this.textBox1.TabIndex = 2;
            // 
            // lblLapLenght
            // 
            this.lblLapLenght.AutoSize = true;
            this.lblLapLenght.Location = new System.Drawing.Point(13, 71);
            this.lblLapLenght.Name = "lblLapLenght";
            this.lblLapLenght.Size = new System.Drawing.Size(61, 13);
            this.lblLapLenght.TabIndex = 3;
            this.lblLapLenght.Text = "Lap Lenght";
            // 
            // txtRunnersRewarded
            // 
            this.txtRunnersRewarded.Location = new System.Drawing.Point(12, 140);
            this.txtRunnersRewarded.Name = "txtRunnersRewarded";
            this.txtRunnersRewarded.Size = new System.Drawing.Size(56, 20);
            this.txtRunnersRewarded.TabIndex = 4;
            // 
            // lblReward
            // 
            this.lblReward.AutoSize = true;
            this.lblReward.Location = new System.Drawing.Point(12, 124);
            this.lblReward.Name = "lblReward";
            this.lblReward.Size = new System.Drawing.Size(94, 13);
            this.lblReward.TabIndex = 5;
            this.lblReward.Text = "Runners rewarded";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(242, 182);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(12, 182);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // LapView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 217);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblReward);
            this.Controls.Add(this.txtRunnersRewarded);
            this.Controls.Add(this.lblLapLenght);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblLapCount);
            this.Controls.Add(this.txtLapCount);
            this.Name = "LapView";
            this.Text = "Track";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLapCount;
        private System.Windows.Forms.Label lblLapCount;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblLapLenght;
        private System.Windows.Forms.TextBox txtRunnersRewarded;
        private System.Windows.Forms.Label lblReward;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}