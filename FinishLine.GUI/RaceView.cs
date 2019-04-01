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
            if (RunnerViewModel.Runners.Count > 0)
            {
                txtLapCount.Enabled = false;
                txtLapLenght.Enabled = false;
                txtReward.Enabled = false;
                txtRunnerNumber.Enabled = true;
                btnLapFinished.Enabled = true;
                btnStart.Enabled = false;
            }
            else
            {
                MessageBox.Show("you dont have runners");
                return;
            }
            RaceViewModel = new RaceViewModel(RunnerViewModel);

            finishedLapBindingSource.DataSource = RaceViewModel.LapGridData;
            resultBindingSource.DataSource = RaceViewModel.RaceGridData;


            RaceViewModel.Race.RaceDate = DateTime.Now;

            RaceViewModel.Race.LapCount = GetIntInput(txtLapCount.Text);
            RaceViewModel.Race.LapLenght = GetIntInput(txtLapLenght.Text);

            lblTime.Text = RaceViewModel.Race.RaceDate.ToLongTimeString();
            lblTime.Visible = true;
            RaceViewModel.RaceStart(RaceViewModel.Race.RaceDate);
            
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

        private void saveAsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.RootFolder = Environment.SpecialFolder.Desktop;
            fbd.Description = "Select directory to save race";
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                string path = fbd.SelectedPath;
                Save save = new Save(RaceViewModel, RunnerViewModel);
                save.SaveRace(path);
            }
            
        }

        private void btnLapFinished_Click_1(object sender, EventArgs e)
        {
            if(RunnerViewModel.GetRunnerById(GetIntInput(txtRunnerNumber.Text)) != null)
            {
                if (RaceViewModel.RaceGridData.Count == GetIntInput(txtReward.Text))
                {
                    btnLapFinished.Enabled = false;
                }
                else
                {
                    int id = GetIntInput(txtRunnerNumber.Text);
                    DateTime dateTime = DateTime.Now;
                    RaceViewModel.FinishLap(id, dateTime);
                    lblErrorId.Visible = false;
                }
            }
            else
            {
                lblErrorId.Text = "That runner dont exist";
                lblErrorId.Visible = true;
            }
            
            
        }

        private void loadToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.RootFolder = Environment.SpecialFolder.MyComputer;
            fbd.Description = "Choose directory with .race and .";
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                string path = fbd.SelectedPath;
                finishedLapBindingSource.DataSource = Core.Repository.Load.LoadFinishedLap(path);
                gridLapOverview.Columns[1].Visible = false;
                resultBindingSource.DataSource = Core.Repository.Load.LoadRaceResult(path);
                txtLapCount.Enabled = false;
                txtLapLenght.Enabled = false;
                txtReward.Enabled = false;
                txtRunnerNumber.Enabled = true;
                btnLapFinished.Enabled = true;
                btnStart.Enabled = false;
                txtRunnerNumber.Enabled = false;
                btnLapFinished.Enabled = false;
                runnersToolStripMenuItem.Enabled = false;
                saveAsToolStripMenuItem1.Enabled = false;
            }
        }
    }
}
