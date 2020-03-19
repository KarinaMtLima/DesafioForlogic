using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forlogicTeste
{
    public partial class frmMenuCust : Form
    {
        public frmMenuCust()
        {
            InitializeComponent();
        }

        private void btnFilmes_Click(object sender, EventArgs e)
        {
            listarFilmesCust listFil = new listarFilmesCust();
            listFil.Show();
            this.Visible = false;
        }

        private void btnEmprest_Click(object sender, EventArgs e)
        {
            frmSelEmpCust selEmp = new frmSelEmpCust();
            selEmp.Show();
            this.Visible = false;

        }
    }
}
