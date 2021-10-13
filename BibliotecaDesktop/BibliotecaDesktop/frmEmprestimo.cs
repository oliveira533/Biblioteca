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
            fnCarrega();
        }
        private void fnCarrega()
        {
            MySqlDataAdapter oLivro = new MySqlDataAdapter("SELECT * FROM livro", frmPrincipal.oCon);
            DataTable oAux = new DataTable();
            oLivro.Fill(oAux);
            cbmLivro.DataSource = oAux;

            cbmLivro.DisplayMember = "LIVNOME";
            cbmLivro.ValueMember = "LIVCODIGO";

            MySqlDataAdapter oCliente = new MySqlDataAdapter("SELECT * FROM cliente", frmPrincipal.oCon);
            DataTable oAux2 = new DataTable();
            oCliente.Fill(oAux2);
            cbmCliente.DataSource = oAux2;

            cbmCliente.DisplayMember = "CLINOME";
            cbmCliente.ValueMember = "CLICODIGO";
        }

        private void btnEmprestar_Click(object sender, EventArgs e)
        {
            string sEntrega = dtpEntrega.Value.Year.ToString() + "-" + dtpEntrega.Value.Month.ToString() + "-" + dtpEntrega.Value.Day.ToString();

            MySqlCommand oComando = new MySqlCommand("INSERT INTO emprestimo(EMPLIVRO, EMPCLIENTE, EMPDTRETIRADA, EMPDTVENCIMENTO) VALUES( @LIVRO, @CLIENTE, NOW(), @VENCIMENTO)", frmPrincipal.oCon);
            oComando.Parameters.AddWithValue("@LIVRO", cbmLivro.SelectedValue);
            oComando.Parameters.AddWithValue("@CLIENTE", cbmCliente.SelectedValue);
            oComando.Parameters.AddWithValue("@VENCIMENTO", sEntrega);
            oComando.ExecuteNonQuery();
        }
    }
}
