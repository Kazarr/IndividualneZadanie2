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
            
        }
    }
}
