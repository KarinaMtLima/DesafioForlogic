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
    public partial class frmSelEmp : Form
    {
        public frmSelEmp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmNovoEmp novoEmp = new frmNovoEmp();
            novoEmp.Show();
            this.Visible = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            framMenuAdm menuAd = new framMenuAdm();
            menuAd.Show();
            this.Visible = false;




        }

        private void btnConsulEmp_Click(object sender, EventArgs e)
        {
            frmConsulEmp consulEmp = new frmConsulEmp();
            consulEmp.Show();
            this.Visible = false;
        }
    }
}
