using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AxTerraExplorerX;
using TerraExplorerX;

namespace skyline_CS
{
    public partial class SouthRMS_Main : Form
    {
        public SouthRMS_Main()
        {
            InitializeComponent();
        }

        private void 打开OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.splitCMain.Panel2.Controls.Count > 0)
            {
                this.splitCMain.Panel2.Controls.Clear();
                Project newProject = new Project();
                Control TE3D = newProject.OpenProject();
                TE3D.Dock = DockStyle.Fill;
                this.splitCMain.Panel2.Controls.Add(TE3D);
            }
            else
            {
                Project newProject = new Project();
                Control TE3D = newProject.OpenProject();
                TE3D.Dock = DockStyle.Fill;
                this.splitCMain.Panel2.Controls.Add(TE3D);
            }
        }
    }
}
