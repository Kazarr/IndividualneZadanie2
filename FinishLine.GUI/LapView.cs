using FinishLine.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinishLine
{
    public partial class LapView : Form
    {
        public LapViewModel LapViewModel { get; set; }
        public LapView()
        {
            InitializeComponent();
            LapViewModel = new LapViewModel();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
