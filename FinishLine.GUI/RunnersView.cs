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
                foreach (Runner i in RunnerViewModel.Runners)
                {
                    gridRunners.Rows.Add(i.Id,
                                        i.Name,
                                        i.Country.EnglishShortName,
                                        i.Age,
                                        i.Sex);
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
            if (e.ColumnIndex == 0)
            {
                for(int i = 0; i < gridRunners.RowCount; i++)
                {
                    if(e.FormattedValue.Equals(gridRunners[0,i].Value))
                    {
                        e.Cancel = true;
                        gridRunners.Rows[e.RowIndex].ErrorText = "you cant add same id";
                    }
                }
                
            }
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
            if(e.ColumnIndex == 1 || e.ColumnIndex == 4)
            {
                if (gridRunners.Rows[e.RowIndex].IsNewRow) { return; }
                if (e.FormattedValue.Equals(""))
                {
                    e.Cancel = true;
                    gridRunners.Rows[e.RowIndex].ErrorText = "the value must be string";
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
            gridRunners.Rows[e.RowIndex].ErrorText = "";
            if (gridRunners[0,e.RowIndex].Value == null ||
                gridRunners[1, e.RowIndex].Value == null ||
                gridRunners[2, e.RowIndex].Value == null ||
                gridRunners[3, e.RowIndex].Value == null ||
                gridRunners.EditingControl.Text == null)
            {
                gridRunners.CurrentCell = gridRunners[0, e.RowIndex];
                gridRunners.Rows[e.RowIndex].ErrorText = "didnt you forget something here?";
            }
            else
            {
                if (!gridRunners.Rows[e.RowIndex].IsNewRow)
                {
                    RunnerViewModel.SaveRunners(GetIntInput((string)gridRunners[0, e.RowIndex].Value),
                    (string)gridRunners[1, e.RowIndex].Value,
                    //(Country)gridRunners[2, i].Value,
                    (Country)countryBindingSource.Current,
                    GetIntInput((string)gridRunners[3,e.RowIndex].Value),
                    gridRunners.EditingControl.Text,  //lebo event rowleave sa vyvolá ešte skôr ako sa ukončí editovanie bunky, preto musím hodnotu získať z editing controlera
                    e.RowIndex);
                }
            }
            
        }

        private void gridRunners_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 0)
            {
                //RunnerViewModel.Runners.fi
            }
        }

        private void gridRunners_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            //for(int i = 0; i < gridRunners.ColumnCount; i++)
            //{
            //    if (gridRunners[e.RowIndex, i].Value.Equals(""))
            //    {
            //        gridRunners_CellValidating(sender, e);
            //    }
            //}
            
        }

        private void gridRunners_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.ColumnIndex != 0)
            //{
            //    if (gridRunners[0, e.RowIndex].Value == null)
            //    {
            //        gridRunners.CurrentCell = gridRunners[0, e.RowIndex];
            //    }
            //}
        }

        private void gridRunners_Click(object sender, EventArgs e)
        {
            //if (gridRunners.Columns[0]. == null)
            //{
            //    gridRunners.CurrentCell = gridRunners[0, e.RowIndex];
            //}
        }

        private void gridRunners_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            RunnerViewModel.RemoveRunners(e.RowIndex);
        }
    }
}
