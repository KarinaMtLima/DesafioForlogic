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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
           

            frmCadastro cad = new frmCadastro();
            cad.Show();
            this.Visible = false;
        }

        private void btnEntar_Click(object sender, EventArgs e)
        {

            SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=testeforlogic;Data Source=KARINA-PC");
            SqlCommand command = new SqlCommand("select * from cadastroUsu where usuarioUsu=@usuario and senhaUsu=@senha ", sql);
            command.Parameters.Add("@usuario", SqlDbType.VarChar).Value = txtLogUsu.Text;
            command.Parameters.Add("@senha", SqlDbType.VarChar).Value = txtSenhaLog.Text;

            try
            {

                sql.Open();
                SqlDataReader drms = command.ExecuteReader();

                if (drms.HasRows == false)
                {
                    throw new Exception("Usuário ou senha incorreto!");

                }

                drms.Read();
                MessageBox.Show("Login efetuado com sucesso! Seja bem vindo ao ForLogicVideos", "Sistema ForlogVideos ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                               

                string tipoUsu = Convert.ToString (drms["tipoUsu"]);

                if(tipoUsu.Equals("Administrador"))
                {
                    framMenuAdm admin = new framMenuAdm();
                    admin.Show();
                    this.Visible = false;
                }else
                {
                    frmMenuCust custM = new frmMenuCust();
                    custM.Show();
                    this.Visible = false;


                }



            
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
    }
}
