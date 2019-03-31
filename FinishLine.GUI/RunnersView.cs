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
            if (RunnerViewModel.Runners.Count > 0)
            {
                //int counter = 0;
                foreach (int i in RunnerViewModel.Runners.Keys)
                {
                    gridRunners.Rows.Add(RunnerViewModel.Runners[i].Id,
                                        RunnerViewModel.Runners[i].Name,
                                        RunnerViewModel.Runners[i].Country,
                                        RunnerViewModel.Runners[i].Age,
                                        RunnerViewModel.Runners[i].Sex);
                    //dataGridView1.Rows[0].Cells[1].Value = "second";
                    //counter++;
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
            //int i = gridRunners.RowCount - 2;
            //for(int i = 0; i < gridRunners.RowCount-1; i++)
            //{
            //    //int id = int.Parse((string)gridRunners[0, i].Value);
            //    //int age = int.Parse((string)gridRunners[0, i].Value);
            //    RunnerViewModel.SaveRunners(GetIntInput((string)gridRunners[0, i].Value),
            //        (string)gridRunners[1, i].Value,
            //        (Country)gridRunners[2, i].Value,
            //        //(Country)countryBindingSource.Current,
            //        GetIntInput((string)gridRunners[3, i].Value), 
            //        (string)gridRunners[4, i].Value);
            //    //RunnerViewModel.Runners.Add(int.Parse((string)gridRunners[0, i].Value), r);
            //}
            //RunnerViewModel.SaveRunners(GetIntInput((string)gridRunners[0, i].Value),
            //      (string)gridRunners[1, i].Value,
            //      //(Country)gridRunners[2, i].Value,
            //      (Country)countryBindingSource.Current,
            //      GetIntInput((string)gridRunners[3, i].Value),
            //      (string)gridRunners[4, i].Value);
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

        private void countryBindingSource_CurrentChanged(object sender, EventArgs e)
        {
        }

        //private void gridRunners_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        //{
        //    int i = gridRunners.RowCount -3;
        //    if ( gridRunners.RowCount >= 3)
        //    {
        //        RunnerViewModel.SaveRunners(GetIntInput((string)gridRunners[0, i].Value),
        //          (string)gridRunners[1, i].Value,
        //          //(Country)gridRunners[2, i].Value,
        //          (Country)countryBindingSource.Current,
        //          GetIntInput((string)gridRunners[3, i].Value),
        //          (string)gridRunners[4, i].Value);
        //        i++;
        //    }
        //}

        private void gridRunners_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (!gridRunners.Rows[e.RowIndex].IsNewRow)
            {
                if (gridRunners.IsCurrentCellInEditMode)
                {
                    RunnerViewModel.SaveRunners(GetIntInput(gridRunners.EditingControl.Text),
                  gridRunners.EditingControl.Text,
                  //(Country)gridRunners[2, i].Value,
                  (Country)countryBindingSource.Current,
                  GetIntInput(gridRunners.EditingControl.Text),
                  gridRunners.EditingControl.Text);
                }
                
            }
        }
    }
}
