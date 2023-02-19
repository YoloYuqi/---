using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 课程设计_药库管理
{
    public partial class frm_Manage : Form
    {
        public frm_Manage()
        {
            InitializeComponent();
        }

        private void 出入库导航ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnl_Navigation.Visible=true;
        }
    }
}
