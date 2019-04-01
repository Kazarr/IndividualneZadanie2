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
using FinishLine.Core.Factory;
using FinishLine.Core.Repository;

namespace FinishLine
{
    public partial class RunnersView : Form
    {
        public RunnerViewModel RunnerViewModel { get; set; }

        public RunnersView(RunnerViewModel runnerViewModel)
        {
            InitializeComponent();
            RunnerViewModel = runnerViewModel;
            gridRunners.DataSource = RunnerViewModel.Runners;
            FillGrid();
        }

        private void FillGrid()
        {
        }

        private int GetDataGridViewComboBoxCellSelectedIndex(DataGridViewCell d)
        {
            return ((DataGridViewComboBoxCell)d).Items.IndexOf(d.Value);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();


            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Save save = new Save(RunnerViewModel);
                if (saveFileDialog1.CheckPathExists)
                {
                    File.Delete(saveFileDialog1.FileName);
                    save.SaveRunners(saveFileDialog1.FileName);
                }
                else
                {
                    save.SaveRunners(saveFileDialog1.FileName);
                }
            }
            Close();
        }

        private int GetIntInput(string text)
        {
            int ret = 0;
            if(int.TryParse(text, out ret))
            {
                return ret;
            }
            else
            {
                return ret;
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            NewRunnerView newRunnerView = new NewRunnerView(RunnerViewModel);
            newRunnerView.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            NewRunnerView newRunnerView = new NewRunnerView(RunnerViewModel, gridRunners.CurrentRow.Index);
            newRunnerView.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            RunnerViewModel.RemoveRunners(gridRunners.CurrentRow.Index);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                RunnerViewModel.Runners = Core.Repository.Load.LoadRunners(openFileDialog.FileName);
            }
            gridRunners.DataSource = RunnerViewModel.Runners;
            //gridRunners.Refresh();
            //gridRunners.Update();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
