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
            RaceViewModel = new RaceViewModel(RunnerViewModel);

            finishedLapBindingSource.DataSource = RaceViewModel.LapGridData;
            resultBindingSource.DataSource = RaceViewModel.RaceGridData;

            RaceViewModel.Race.RaceDate = DateTime.Now;

            RaceViewModel.Race.LapCount = GetIntInput(txtLapCount.Text);

            lblTime.Text = RaceViewModel.Race.RaceDate.ToShortDateString();
            lblTime.Visible = true;
            RaceViewModel.RaceStart(RaceViewModel.Race.RaceDate);
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

        private void btnLapFinished_Click_1(object sender, EventArgs e)
        {
            int id = GetIntInput(txtRunnerNumber.Text);
            DateTime dateTime = DateTime.Now;
            //RunnerViewModel.Runners.Where(x => x.Id == id).First().TotalTime = dateTime;
            RaceViewModel.FinishLap(id, dateTime);
        }
    }
}
