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
    public partial class RaceView : Form
    {
        public RaceViewModel RaceViewModel { get; set; }
        public RaceView()
        {
            InitializeComponent();
        }

        private void trackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(LapView laps = new LapView())
            {
                var dialogResult = laps.ShowDialog();
            }
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void runnersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (RunnersView runners = new RunnersView())
            {
                var dialogResult = runners.ShowDialog();

            }
        }
    }
}
