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
    public partial class frmCadastroUsuAdmin : Form
    {
        public frmCadastroUsuAdmin()
        {
            InitializeComponent();
        }

        private void btnAddUsu_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=testeforlogic;Data Source=KARINA-PC");
            SqlCommand command = new SqlCommand("insert into cadastroUsu(tipoUsu,idUsu, nomeUsu, emailUsu, telefoneUsu, usuarioUsu, senhaUsu) values (@tipoUsu,@idCust, @nome,@email,@telefone,@usuario,@senha)", sql);

            command.Parameters.Add("@tipoUsu", SqlDbType.VarChar).Value = comboPerfilUsu.Text;
            command.Parameters.Add("@idCust", SqlDbType.Int).Value = txtIdCadUsu.Text;
            command.Parameters.Add("@nome", SqlDbType.VarChar).Value = txtNomeCdUsu.Text;
            command.Parameters.Add("@email", SqlDbType.VarChar).Value = txtEmaCdUsu.Text;
            command.Parameters.Add("@telefone", SqlDbType.VarChar).Value = txtFoneCdUsu.Text;
            command.Parameters.Add("@usuario", SqlDbType.VarChar).Value = txtLogCdUsu.Text;
            command.Parameters.Add("@senha", SqlDbType.VarChar).Value = txtSenhaCdUsu.Text;


            if (comboPerfilUsu.Text != "" & txtIdCadUsu.Text != "" & txtNomeCdUsu.Text != "" & txtFoneCdUsu.Text != "" & txtLogCdUsu.Text != "" & txtSenhaCdUsu.Text != "")
            {

                try
                {
                    sql.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Cadastro efetuado com Sucesso", "Sistema ForlogVideos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    comboPerfilUsu.Text = "";
                    txtIdCadUsu.Text = "";
                    txtNomeCdUsu.Text = "";
                    txtEmaCdUsu.Text = "";
                    txtFoneCdUsu.Text = "";
                    txtLogCdUsu.Text = "";
                    txtSenhaCdUsu.Text = "";
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

        private void btnSairUsu_Click(object sender, EventArgs e)
        {
            framMenuAdm menuAdm = new framMenuAdm();
            menuAdm.Show();
            this.Visible = false;
        }

        private void btnPesqUsu_Click(object sender, EventArgs e)
        {
            
            SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=testeforlogic;Data Source=KARINA-PC");
            SqlCommand command = new SqlCommand("select * from cadastroUsu where idUsu=@idUser", sql);


            command.Parameters.Add("@idUser", SqlDbType.Int).Value = txtIdCadUsu.Text;


            try
            {
                sql.Open();
                SqlDataReader drms = command.ExecuteReader();
                if (drms.HasRows == false)
                {
                    throw new Exception("ID não encontrado!");
                }

                drms.Read();
                txtIdCadUsu.Text = Convert.ToString(drms["idUsu"]);
                txtNomeCdUsu.Text = Convert.ToString(drms["nomeUsu"]);
                txtEmaCdUsu.Text = Convert.ToString(drms["emailUsu"]);
                txtFoneCdUsu.Text = Convert.ToString(drms["telefoneUsu"]);
                txtLogCdUsu.Text = Convert.ToString(drms["usuarioUsu"]);
                txtSenhaCdUsu.Text = Convert.ToString(drms["senhaUsu"]);
                comboPerfilUsu.Text = Convert.ToString(drms["tipoUsu"]);

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

        private void btnLimparUsu_Click(object sender, EventArgs e)
        {
            
            txtIdCadUsu.Text = "";
            txtNomeCdUsu.Text = "";
            txtEmaCdUsu.Text = "";
            txtFoneCdUsu.Text = "";
            txtLogCdUsu.Text = "";
            txtSenhaCdUsu.Text = "";
            comboPerfilUsu.Text = "";

        }

        private void btnEditUsu_Click(object sender, EventArgs e)
        {

            SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=testeforlogic;Data Source=KARINA-PC");
            SqlCommand command = new SqlCommand("update cadastroUsu set tipoUsu=@tipoUsu, nomeUsu=@nome, emailUsu=@email, telefoneUsu=@telefone, usuarioUsu=@usuario, senhaUsu=@senha where idUsu=@idUsu", sql);

            command.Parameters.Add("@tipoUsu", SqlDbType.VarChar).Value = comboPerfilUsu.Text;
            command.Parameters.Add("@idUsu", SqlDbType.Int).Value = txtIdCadUsu.Text;
            command.Parameters.Add("@nome", SqlDbType.VarChar).Value = txtNomeCdUsu.Text;
            command.Parameters.Add("@email", SqlDbType.VarChar).Value = txtEmaCdUsu.Text;
            command.Parameters.Add("@telefone", SqlDbType.VarChar).Value = txtFoneCdUsu.Text;
            command.Parameters.Add("@usuario", SqlDbType.VarChar).Value = txtLogCdUsu.Text;
            command.Parameters.Add("@senha", SqlDbType.VarChar).Value = txtSenhaCdUsu.Text;


            if (comboPerfilUsu.Text != "" & txtIdCadUsu.Text != "" & txtNomeCdUsu.Text != "" & txtFoneCdUsu.Text != "" & txtLogCdUsu.Text != "" & txtSenhaCdUsu.Text != "")
            {

                try
                {
                    sql.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Atualizado com Sucesso", "Sistema ForlogVideos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    comboPerfilUsu.Text = "";
                    txtIdCadUsu.Text = "";
                    txtNomeCdUsu.Text = "";
                    txtEmaCdUsu.Text = "";
                    txtFoneCdUsu.Text = "";
                    txtLogCdUsu.Text = "";
                    txtSenhaCdUsu.Text = "";
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

        private void btnExcluirUso_Click(object sender, EventArgs e)
        {


            SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=testeforlogic;Data Source=KARINA-PC");
            SqlCommand command = new SqlCommand("delete from cadastroUsu where idUsu=@idUser", sql);


            command.Parameters.Add("@idUser", SqlDbType.Int).Value = txtIdCadUsu.Text;


            try
            {
                sql.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Usuário excluído com Sucesso", "Sistema ForlogVideos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboPerfilUsu.Text = "";
                txtIdCadUsu.Text = "";
                txtNomeCdUsu.Text = "";
                txtEmaCdUsu.Text = "";
                txtFoneCdUsu.Text = "";
                txtLogCdUsu.Text = "";
                txtSenhaCdUsu.Text = "";


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