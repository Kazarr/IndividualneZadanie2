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
        public RunnersView()
        {
            InitializeComponent();
            RunnerViewModel = new RunnerViewModel();
            
            countryBindingSource.DataSource = Core.Repository.Load.LoadOrderedCountries("countries.csv");
            RunnerViewModel = new RunnerViewModel();

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
            for(int i = 0; i < gridRunners.Columns.Count; i++)
            {
                for(int j = 0; j < gridRunners.RowCount; j++)
                {
                    RunnerViewModel.Runners.Add((int)gridRunners[0, j].Value, 
                        Factory.CreateRunner((string)gridRunners[i,j].Value, 
                        (Country)gridRunners[i, j].Value, 
                        (int)gridRunners[i, j].Value, 
                        (string)gridRunners[i, j].Value));
                    //RunnerViewModel.Runners.Add(gridRunners.Columns[0], Factory.CreateRunner(gridRunners.Columns[0]., gridRunners.Columns[1], gridRunners.Columns[2], gridRunners.Columns[3]))
                }
                
            }
            
        }
    }
}
