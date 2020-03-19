using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forlogicTeste
{
    public partial class frmSelEmpCust : Form
    {
        public frmSelEmpCust()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

            frmMenuCust meCust = new frmMenuCust();
            meCust.Show();
            this.Visible = false;


        }

        private void btnNovoEmp_Click(object sender, EventArgs e)
        {
            frmNovoEmp nvEmpC = new frmNovoEmp();
            nvEmpC.Show();
            this.Visible = false;
        }

        private void btnConsulEmp_Click(object sender, EventArgs e)
        {
            frmConsulEmp custCons = new frmConsulEmp();
            custCons.Show();
            this.Visible = false;

        }
    }
}
