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
    public partial class frmConsulEmp : Form
    {
        public frmConsulEmp()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnPesEmp_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=testeforlogic;Data Source=KARINA-PC");
            SqlCommand command = new SqlCommand("select * from emprestimos where idUsuEmp=@idUserEmp", sql);


            command.Parameters.Add("@idUserEmp", SqlDbType.Int).Value = txtIdNConsEmp.Text;


            try
            {
                sql.Open();
                SqlDataReader drms = command.ExecuteReader();
                if (drms.HasRows == false)
                {
                    throw new Exception("ID não encontrado!");
                }

                drms.Read();
                txtIdNConsEmp.Text = Convert.ToString(drms["idUsuEmp"]);
                txtDataCon.Text = Convert.ToString(drms["data"]);
                txtTitCon.Text = Convert.ToString(drms["tituloLocado"]);
                txtQtddCon.Text = Convert.ToString(drms["qtddLocado"]);
                txtValorUn.Text = Convert.ToString(drms["valor"]);
                txtValorTt.Text = Convert.ToString(drms["valorTotal"]);
                txtDataDevol.Text = Convert.ToString(drms["dataDevol"]);
                cbStatusFil.Text = Convert.ToString(drms["filmeStatus"]);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {

                sql.Close();

            }




        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            frmLogin log = new frmLogin();
            log.Show();
            this.Visible = false;
        }
    }
}
