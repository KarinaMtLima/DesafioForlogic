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
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();
        }

        private void btnSairCust_Click(object sender, EventArgs e)
        {
            frmLogin log = new frmLogin();
            log.Show();
            this.Visible = false;
        }

        private void btnAddCus_Click(object sender, EventArgs e)
        {

            SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=testeforlogic;Data Source=KARINA-PC");
            SqlCommand command = new SqlCommand("insert into cadastroUsu(tipoUsu,idUsu, nomeUsu, emailUsu, telefoneUsu, usuarioUsu, senhaUsu) values (@tipoUsu,@idCust, @nome,@email,@telefone,@usuario,@senha)", sql);
            command.Parameters.Add("@tipoUsu", SqlDbType.VarChar).Value = "Customer";
            command.Parameters.Add("@idCust", SqlDbType.Int).Value = txtIdCust.Text;
            command.Parameters.Add("@nome", SqlDbType.VarChar).Value = txtNomeCust.Text;
            command.Parameters.Add("@email", SqlDbType.VarChar).Value = txtEmailCust.Text;
            command.Parameters.Add("@telefone", SqlDbType.VarChar).Value = txtTelCust.Text;
            command.Parameters.Add("@usuario", SqlDbType.VarChar).Value = txtLogCust.Text;
            command.Parameters.Add("@senha", SqlDbType.VarChar).Value = txtSenhaCust.Text;


            if (txtIdCust.Text != "" & txtNomeCust.Text != "" & txtTelCust.Text != "" & txtLogCust.Text != "" & txtSenhaCust.Text != "")
            {

                try
                {
                    sql.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Cadastro efetuado com Sucesso", "Sistema ForlogVideos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtIdCust.Text = "";
                    txtNomeCust.Text = "";
                    txtEmailCust.Text = "";
                    txtTelCust.Text = "";
                    txtLogCust.Text = "";
                    txtSenhaCust.Text = "";
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

        private void frmCadastro_Load(object sender, EventArgs e)
        {

        }
    }
}
