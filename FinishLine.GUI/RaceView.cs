using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinishLine.Core;
using FinishLine.Core.Repository;

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
            RaceViewModel = new RaceViewModel(RunnerViewModel);
            RaceViewModel.RaceStart(
                RunnerViewModel.Runners.ToList(), 
                GetIntInput(txtLapCount.Text),
                GetIntInput(txtReward.Text),
                dateTime,
                GetIntInput(txtLapLenght.Text));
            if (RunnerViewModel.Runners.Count > 0)
            {
                txtLapCount.Enabled = false;
                txtLapLenght.Enabled = false;
                txtReward.Enabled = false;
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
            TimeSpan racetime = DateTime.Now.Subtract(RaceViewModel.Race.RaceDate);
            TimeSpan lapTime = DateTime.Now.Subtract(RaceViewModel.Race.LapDate);
            int id = GetIntInput(txtRunnerNumber.Text);

            RaceViewModel.FinishLap(id);
            //RaceViewModel.IsFinished(id, GetIntInput(txtLapCount.Text));

            if (!RaceViewModel.IsFinished(id, GetIntInput(txtLapCount.Text)))
            {
                gridLapOverview.Rows.Add(
                    id,
                    RaceViewModel.Race.Runners[id].Position,
                    RaceViewModel.Race.Runners[id].Name,
                    RaceViewModel.Race.Runners[id].Country,
                    RaceViewModel.Race.Runners[id].FinishedLaps,
                    lapTime,
                    RaceViewModel.Race.LapLenght);
            }
            else
            {
                gridLapOverview.Rows.Add(
                    id,
                    RaceViewModel.Race.Runners[id].Position,
                    RaceViewModel.Race.Runners[id].Name,
                    RaceViewModel.Race.Runners[id].Country,
                    RaceViewModel.Race.Runners[id].FinishedLaps,
                    lapTime,
                    RaceViewModel.Race.LapLenght);

                gridRaceOverview.Rows.Add(
                        id,
                        RaceViewModel.Race.Runners[id].Position,
                        RaceViewModel.Race.Runners[id].Name,
                        RaceViewModel.Race.Runners[id].Country,
                        1,
                        racetime,
                        RaceViewModel.Race.LapLenght);
            }
        }

        private void loadToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                RunnerViewModel.Runners = Core.Repository.Load.LoadRunners(openFileDialog.FileName);
            }

            
        }

        private void saveAsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Save save = new Save(RaceViewModel,RunnerViewModel);
                    
                save.SaveRunners(saveFileDialog1.FileName);
            }
        }
    }
}
