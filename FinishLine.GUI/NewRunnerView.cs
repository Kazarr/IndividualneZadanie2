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

namespace FinishLine
{
    public partial class NewRunnerView : Form
    {
        public RunnerViewModel RunnerViewModel { get; set; }
        private bool _isEditing;
        private int _gridIndex;
        public NewRunnerView(RunnerViewModel runnerViewModel)
        {
            InitializeComponent();
            _isEditing = false;
            RunnerViewModel = runnerViewModel;
            countryBindingSource.DataSource = Core.Repository.Load.LoadOrderedCountries("countries.csv");
            cmbCounty.DataSource = countryBindingSource;
        }
        public NewRunnerView(RunnerViewModel runnerViewModel, int gridIndex)
        {
            InitializeComponent();
            _isEditing = true;
            _gridIndex = gridIndex;
            RunnerViewModel = runnerViewModel;
            
            countryBindingSource.DataSource = Core.Repository.Load.LoadOrderedCountries("countries.csv");
            cmbCounty.DataSource = countryBindingSource;
            FillValues(gridIndex);
            //txtId.Text = RunnerViewModel.Runners[gridIndex].Id.ToString();
            //txtName.Text = RunnerViewModel.Runners[gridIndex].Name;
            //cmbCounty.Text = RunnerViewModel.Runners[gridIndex].Country.ToString();
            //txtAge.Text = RunnerViewModel.Runners[gridIndex].Age.ToString();
            //txtSex.Text = RunnerViewModel.Runners[gridIndex].Sex;

            //List<Country> comboboXDatasource = Core.Repository.Load.LoadOrderedCountries("countries.csv");
            //List<string> comboboXDatasource = Core.Repository.Load.LoadEnglishShortName("countries.csv");
            //cmbCounty.DataSource = comboboXDatasource;

        }

        private void FillValues(int gridIndex)
        {
            txtId.Text = RunnerViewModel.Runners[gridIndex].Id.ToString();
            txtId.Enabled = false;
            txtName.Text = RunnerViewModel.Runners[gridIndex].Name;
            cmbCounty.SelectedValue = RunnerViewModel.Runners[gridIndex].Country.EnglishShortName;
            txtAge.Text = RunnerViewModel.Runners[gridIndex].Age.ToString();
            txtSex.Text = RunnerViewModel.Runners[gridIndex].Sex;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_isEditing)
            {
                RunnerViewModel.RemoveRunners(_gridIndex);
                RunnerViewModel.SaveRunners(
                GetIntInput(txtId.Text),
                txtName.Text,
                (Country)countryBindingSource.Current,
                GetIntInput(txtAge.Text),
                txtSex.Text);
            }
            else
            {
                RunnerViewModel.SaveRunners(
                GetIntInput(txtId.Text),
                txtName.Text,
                (Country)countryBindingSource.Current,
                GetIntInput(txtAge.Text),
                txtSex.Text);
            }
            
            DialogResult = DialogResult.OK;
        }
        private int GetIntInput(string text)
        {
            int ret = 0;
            if (int.TryParse(text, out ret))
            {
                return ret;
            }
            else
            {
                return ret;
            }
        }

        private bool ValidateInt(string text)
        {
            int i;
            return int.TryParse(text, out i);
        }
        private bool ValidateString(string text)
        {
            if(text != null && !text.Equals(""))
            {
                return true;
            }
            return false;
        }
        private Runner FindRunnerById(int id)
        {
            foreach(Runner r in RunnerViewModel.Runners)
            {
                if(r.Id == id)
                {
                    return r;
                }
            }
            return null;
        }

        private void txtId_Validating(object sender, CancelEventArgs e)
        {
            if (!_isEditing)
            {
                if (FindRunnerById(GetIntInput(txtId.Text)) != null)
                {
                    lblErrorId.Text = "You already have that id";
                    lblErrorId.Visible = true;
                    e.Cancel = true;
                }
                else
                {
                    if (!ValidateInt(txtId.Text))
                    {
                        lblErrorId.Text = "Thisi is not a number";
                        lblErrorId.Visible = true;
                        e.Cancel = true;
                    }

                }
            }
            else
            {
                if (!ValidateInt(txtId.Text))
                {

                    lblErrorId.Text = "Thisi is not a number";
                    lblErrorId.Visible = true;
                    e.Cancel = true;
                }
            }
            


        }

        private void txtAge_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidateInt(txtAge.Text))
            {
                e.Cancel = true; ;
            }
        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidateString(txtName.Text))
            {
                e.Cancel = true;
            }
        }

        private void txtSex_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidateString(txtSex.Text))
            {
                e.Cancel = true;
            }
        }

        private void btnCanel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
