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
    }
}
