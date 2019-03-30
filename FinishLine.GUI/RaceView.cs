using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinishLine.Core;

namespace FinishLine
{
    public partial class RaceView : Form
    {
        public RaceViewModel RaceViewModel { get; set; }
        public RunnerViewModel RunnerViewModel { get; set; }
        public RaceView()
        {
            InitializeComponent();
            RunnerViewModel = new RunnerViewModel();

        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void runnersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RunnersView runners = new RunnersView(RunnerViewModel);
            using (runners)
            {
                var dialogResult = runners.ShowDialog();
                if(dialogResult == DialogResult.OK)
                {
                }

            }
        }

        private bool ValidateIntInput(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            return e.Handled;
        }
        private int GetIntInput(string text)
        {
            if (text.Equals(""))
            {
                return 0;
            }
            return int.Parse(text);
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            lblTime.Text = dateTime.ToLongTimeString();
            lblTime.Visible = true;
            RaceViewModel = new RaceViewModel(
                RunnerViewModel.Runners,
                GetIntInput(txtLapCount.Text),
                GetIntInput(txtReward.Text),
                dateTime,
                GetIntInput(txtLapLenght.Text));

            RaceViewModel.Race.Runners = RunnerViewModel.Runners;

            if (RunnerViewModel.Runners.Count > 0)
            {
                txtLapCount.Enabled = false;
                txtLapLenght.Enabled = false;
            }
        }

        private string GetStringFromLabel(Label label)
        {
            return label.Text;
        }
        private void txtReward_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateIntInput(sender, e);
        }
        private void txtLapLenght_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateIntInput(sender, e);
        }
        private void txtLapCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateIntInput(sender, e);
        }
        private void btnLapFinished_Click(object sender, EventArgs e)
        {
            TimeSpan time = DateTime.Now.Subtract(RaceViewModel.Race.Date);
            int id = GetIntInput(txtRunnerNumber.Text);

            RaceViewModel.Race.FinishedRunners.Add(id, RaceViewModel.Race.Runners[id]);
            RaceViewModel.Race.Runners[id].FinishedLaps++;


            gridLapOverview.Rows.Add(
                id,
                RaceViewModel.Race.Runners[id].Position,
                RaceViewModel.Race.Runners[id].Name,
                RaceViewModel.Race.Runners[id].Country,
                RaceViewModel.Race.Runners[id].FinishedLaps,
                time,
                RaceViewModel.Race.LapLenght);
            //gridLapOverview[0, gridLapOverview.RowCount].Value = id;
            //gridLapOverview[1, gridLapOverview.RowCount].Value = RaceViewModel.Race.Runners;

            

        }
    }
}
