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
    public partial class frmPrincipal : Form
    {
        //variável de conexão
        public static MySqlConnection oCon = new MySqlConnection("SERVER=remotemysql.com; UID=3QsQG7lKpx; PWD=UdPYkmGR2U; DATABASE=3QsQG7lKpx");
        
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            //abrindo conexão 
            oCon.Open();
            //chamando a função que carrega os dados
            fnCarrega();
        }

        //função que carrega os dados
        private void fnCarrega()
        {
            MySqlDataAdapter grdlivros = new MySqlDataAdapter("SELECT LIVCODIGO CODIGO, LIVNOME TITULO, ESCNOME ESCRITOR, LIVDTLANCAMENTO LANÇAMENTO FROM livro  LEFT JOIN escritor ON LIVESCRITOR = ESCCODIGO", oCon);
            DataTable oAux = new DataTable();
            grdlivros.Fill(oAux);
            grdLivros.DataSource = oAux;

            MySqlDataAdapter grdemprestimo = new MySqlDataAdapter("SELECT EMPCODIGO CODIGO, CLINOME CLIENTE, LIVNOME LIVRO, EMPDTRETIRADA RETIRADA, EMPDTVENCIMENTO FROM emprestimo  LEFT JOIN cliente  ON EMPCLIENTE = CLICODIGO LEFT JOIN livro ON EMPLIVRO = LIVCODIGO", oCon);
            DataTable oAux2 = new DataTable();
            grdemprestimo.Fill(oAux2);
            grdEmprestimo.DataSource = oAux2;

            MySqlDataAdapter grdescritor = new MySqlDataAdapter("SELECT ESCNOME, COUNT(LIVCODIGO) FROM escritor LEFT JOIN livro ON ESCCODIGO = LIVESCRITOR GROUP BY(ESCNOME)", oCon);
            DataTable oAux3 = new DataTable();
            grdescritor.Fill(oAux3);
            grdEscritor.DataSource = oAux3;

            MySqlDataAdapter oDadosCliente = new MySqlDataAdapter("SELECT CLICODIGO CODIGO, CLINOME NOME, CLICPF CPF, CLICEP CEP FROM cliente", oCon);
            DataTable oAux4 = new DataTable();
            oDadosCliente.Fill(oAux4);
            grdCliente.DataSource = oAux4;
        }

        private void btnEmprestimo_Click(object sender, EventArgs e)
        {
            new frmEmprestimo().ShowDialog();
        }


        //deleta o empréstimo de livro
        private void btnEntregar_Click(object sender, EventArgs e)
        {
            MySqlCommand oComando = new MySqlCommand("", oCon);

            //comando pra deletar o empréstimo
            oComando.CommandText = "DELETE FROM emprestimo WHERE EMPCODIGO = " + grdEmprestimo.SelectedRows[00].Cells[0].Value;
            //teste pra saber se o livro foi entregue
            if (MessageBox.Show("Tem certeza de que o livro foi entegue?", "Atenção", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                oComando.ExecuteNonQuery();
                fnCarrega();
            }

        }

        private void btnAtualiza_Click(object sender, EventArgs e)
        {
            fnCarrega();
        }

        private void btnLivro_Click(object sender, EventArgs e)
        {
            new frmLivro().ShowDialog();
        }

        private void btnEscritor_Click(object sender, EventArgs e)
        {
            new frmEscritor().ShowDialog();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            new frmCliente().ShowDialog();
        }
    }
}
