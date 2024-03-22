using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModernGUI_V3
{
    public partial class Output : Form
    {
        public Output()
        {
            InitializeComponent();
        }

        private void btnsi_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            FormPrincipal form1 = new FormPrincipal();
            form1.Show();
        }
    }
}
