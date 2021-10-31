using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BibliotecaDesktop
{
    public partial class frmEmprestimo : Form
    {
        public frmEmprestimo()
        {
            InitializeComponent();
        }

        private void frmEmprestimo_Load(object sender, EventArgs e)
        {
            //chama a função pra carregar os dados do banco de dados
            fnCarrega();
        }
        private void fnCarrega()
        {
            MySqlDataAdapter grdlivros = new MySqlDataAdapter("SELECT LIVCODIGO ,LIVNOME, (LIVQUANTIDADE - COUNT(EMPCODIGO)) QUANTIDADE FROM livro LEFT JOIN emprestimo ON LIVCODIGO = EMPLIVRO GROUP BY LIVNOME, LIVQUANTIDADE, LIVCODIGO", frmPrincipal.oCon);
            DataTable oAux = new DataTable();
            grdlivros.Fill(oAux);
            grdLivros.DataSource = oAux;

            MySqlDataAdapter oCliente = new MySqlDataAdapter("SELECT CLICODIGO CODIGO, CLINOME NOME FROM cliente", frmPrincipal.oCon);
            DataTable oAux2 = new DataTable();
            oCliente.Fill(oAux2);
            grdCliente.DataSource = oAux2;
        }

        private void btnEmprestar_Click(object sender, EventArgs e)
        {
            string sEntrega = dtpEntrega.Value.Year.ToString() + "-" + dtpEntrega.Value.Month.ToString() + "-" + dtpEntrega.Value.Day.ToString();

            MySqlCommand oComando = new MySqlCommand("INSERT INTO emprestimo(EMPLIVRO, EMPCLIENTE, EMPDTRETIRADA, EMPDTVENCIMENTO) VALUES( @LIVRO, @CLIENTE, NOW(), @VENCIMENTO)", frmPrincipal.oCon);
            oComando.Parameters.AddWithValue("@LIVRO", grdLivros.SelectedRows[00].Cells[0].Value);
            oComando.Parameters.AddWithValue("@CLIENTE", grdCliente.SelectedRows[00].Cells[0].Value);
            oComando.Parameters.AddWithValue("@VENCIMENTO", sEntrega);
            oComando.ExecuteNonQuery();
        }
    }
}
