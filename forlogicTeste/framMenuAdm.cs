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
    public partial class framMenuAdm : Form
    {
        public framMenuAdm()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //botao Usuários

            frmCadastroUsuAdmin cadUsu = new frmCadastroUsuAdmin();
            cadUsu.Show();
            this.Visible = false;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            frmLogin log = new frmLogin();
            log.Show();
            this.Visible = false;
        }

        private void btnFilmes_Click(object sender, EventArgs e)
        {
            frmListaFilmes listFil = new frmListaFilmes();
            listFil.Show();
            this.Visible = false;
        }

        private void btnEmprest_Click(object sender, EventArgs e)
        {
            frmSelEmp selectEmp = new frmSelEmp();
            selectEmp.Show();
            this.Visible = false;

        }

        private void btnGeneros_Click(object sender, EventArgs e)
        {
            frmGeneros gen = new frmGeneros();
            gen.Show();
            this.Visible = false;
        }
    }
}
