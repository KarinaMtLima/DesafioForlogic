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
    public partial class frmListaFilmes : Form
    {
         private string _stnConn = ( "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=testeforlogic;Data Source=KARINA-PC");
            

         SqlConnection objConnection = null;
         SqlCommand objCommand = null;


        public frmListaFilmes()
        {
            InitializeComponent();
        }

        public void listarGrid()
        {
            string strSQL = "SELECT * FROM FILMES";
            objConnection = new SqlConnection (_stnConn);
            objCommand = new SqlCommand(strSQL, objConnection);

            try
            {
                SqlDataAdapter objAdp = new SqlDataAdapter(objCommand);

                DataTable dtLista = new DataTable();

                objAdp.Fill(dtLista);

                dgDados.DataSource = dtLista;


            }
            catch
            {
                MessageBox.Show("Erro");
            }


        }

        private void frmListaFilmes_Load(object sender, EventArgs e)
        {
            listarGrid();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            framMenuAdm meAdm = new framMenuAdm();
            meAdm.Show();
            this.Visible = false;
        }


    }
}
