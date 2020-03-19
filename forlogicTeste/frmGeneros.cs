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
    public partial class frmGeneros : Form
    {
        public frmGeneros()
        {
            InitializeComponent();
        }

        private void btnSairGen_Click(object sender, EventArgs e)
        {
            framMenuAdm menuAd = new framMenuAdm();
            menuAd.Show();
            this.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGenPes_Click(object sender, EventArgs e)
        {

            SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=testeforlogic;Data Source=KARINA-PC");
            SqlCommand command = new SqlCommand("select * from filmes where genero=@genero", sql);

            command.Parameters.Add("@genero", SqlDbType.VarChar).Value = cbSelG.Text;


            try
            {
                sql.Open();
                SqlDataReader drms = command.ExecuteReader();
                if (drms.HasRows == false)
                {
                    throw new Exception("Genero não encontrado!");
                }

                drms.Read();
                txtTituloG.Text = Convert.ToString(drms["titulo"]);
                txtDirG.Text = Convert.ToString(drms["diretor"]);
                txtAnoG.Text = Convert.ToString(drms["ano"]);
                txtGenG.Text = Convert.ToString(drms["genero"]);
                txtPaisG.Text = Convert.ToString(drms["pais"]);

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

        private void btnLimparG_Click(object sender, EventArgs e)
        {

            cbSelG.Text = "";
            txtTituloG.Text = "";
            txtDirG.Text = "";
            txtAnoG.Text = "";
            txtGenG.Text = "";
            txtPaisG.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmNovoEmp nvEmpg = new frmNovoEmp();
            nvEmpg.Show();
            this.Visible = false;
        }
    }
}
