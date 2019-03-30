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
            RunnerViewModel = runnerViewModel;
            InitializeComponent();
            //RunnerViewModel = new RunnerViewModel();
            
            countryBindingSource.DataSource = Core.Repository.Load.LoadOrderedCountries("countries.csv");
            FillGrid();
        }

        private void FillGrid()
        {
            if (RunnerViewModel.Runners.Count >= 0)
            {
                foreach(int i in RunnerViewModel.Runners.Keys)
                {
                    int counter = 0;
                    gridRunners[0, counter].Value = RunnerViewModel.Runners[i].Id;
                    gridRunners[1, counter].Value = RunnerViewModel.Runners[i].Name;
                    //countryBindingSource.Insert(i, RunnerViewModel.Runners[i].Country);
                    countryBindingSource[i] = RunnerViewModel.Runners[i].Country;

                    string SelectedText = Convert.ToString((gridRunners.Rows[0].Cells[2] as DataGridViewComboBoxCell).FormattedValue.ToString());
                    int SelectedVal = Convert.ToInt32(gridRunners.Rows[0].Cells[2].Value);

                    GetDataGridViewComboBoxCellSelectedIndex(gridRunners.Rows[0].Cells[2]);

                    //gridRunners.Rows[counter].Cells[2].Value = 
                    //gridRunners[2, counter].Selected = RunnerViewModel.Runners[i].Country.EnglishShortName;
                    //countryBindingSource.Add(RunnerViewModel.Runners[i].Country); // this is not working repair it !!!
                    gridRunners[3, counter].Value = RunnerViewModel.Runners[i].Age;
                    gridRunners[4, counter].Value = RunnerViewModel.Runners[i].Sex;
                    counter++;
                }
                
            }
        }

        private int GetDataGridViewComboBoxCellSelectedIndex(DataGridViewCell d)
        {
            return ((DataGridViewComboBoxCell)d).Items.IndexOf(d.Value);
        }

        private void gridRunners_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            gridRunners.Rows[e.RowIndex].ErrorText = "";
            //int newInteger;
            if (e.ColumnIndex == 0 || e.ColumnIndex == 3)
            {
                int i;
                if (gridRunners.Rows[e.RowIndex].IsNewRow) { return; }
                if (!int.TryParse(Convert.ToString(e.FormattedValue), out i))
                {
                    e.Cancel = true;
                    gridRunners.Rows[e.RowIndex].ErrorText = "the value must be a number";
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < gridRunners.RowCount-1; i++)
            {
                //int id = int.Parse((string)gridRunners[0, i].Value);
                //int age = int.Parse((string)gridRunners[0, i].Value);
                Runner r = Factory.CreateRunner(int.Parse((string)gridRunners[0, i].Value), 
                    (string)gridRunners[1, i].Value, 
                    (Country)countryBindingSource.Current,
                    int.Parse((string)gridRunners[3, i].Value), 
                    (string)gridRunners[4, i].Value);
                RunnerViewModel.Runners.Add(int.Parse((string)gridRunners[0, i].Value), r);
            }
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
