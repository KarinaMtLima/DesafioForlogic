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
    public partial class frmNovoEmp : Form
    {
        public frmNovoEmp()
        {
            InitializeComponent();
        }

        private void btnAddEmp_Click(object sender, EventArgs e)
        {

            SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=testeforlogic;Data Source=KARINA-PC");
            SqlCommand command = new SqlCommand("insert into emprestimos(idUsuEmp,data,tituloLocado,qtddLocado,valor,valorTotal,dataDevol,filmeStatus) values (@idUsuEmp,@data, @tituloLocado,@qtddLocado,@valor,@valorTotal,@dataDevol,@filmeStatus)", sql);

            command.Parameters.Add("@idUsuEmp", SqlDbType.Int).Value = txtIdNemp.Text;
            command.Parameters.Add("@data", SqlDbType.DateTime).Value = txtDataEmp.Text;
            command.Parameters.Add("@tituloLocado", SqlDbType.VarChar).Value = txtTituloEmpN.Text;
            command.Parameters.Add("@qtddLocado", SqlDbType.Int).Value = txtQtddEmp.Text;
            command.Parameters.Add("@valor", SqlDbType.Float).Value = txtValor1.Text;
            command.Parameters.Add("@valorTotal", SqlDbType.Float).Value = txtValor2.Text;
            command.Parameters.Add("@dataDevol", SqlDbType.DateTime).Value = txtDataDevol.Text;
            command.Parameters.Add("@filmeStatus", SqlDbType.DateTime).Value = cbStatusFil.Text;





            if (txtIdNemp.Text != "" & txtDataEmp.Text != "" & txtTituloEmpN.Text != "" & txtQtddEmp.Text != "" & txtValor1.Text != "" & txtValor2.Text != "" & txtDataDevol.Text != "" & cbStatusFil.Text != "")
            {
                
                try
                {
                    sql.Open();
                    command.ExecuteNonQuery();

                    MessageBox.Show("Emprestimo efetuado com Sucesso", "Sistema ForlogVideos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtIdNemp.Text = "";
                    txtDataEmp.Text = "";
                    txtTituloEmpN.Text = "";
                    txtQtddEmp.Text = "";
                    txtValor1.Text = "";
                    txtValor2.Text = "";
                    txtDataDevol.Text = "";
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
            else
            {

                MessageBox.Show("Por favor preencha todas os campos obrigatórios!", "Sistema ForlogVideos - CAMPOS OBRIGATÓRIOS", MessageBoxButtons.OK, MessageBoxIcon.Question);

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
