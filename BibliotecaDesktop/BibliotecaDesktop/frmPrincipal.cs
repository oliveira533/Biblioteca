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
        public static MySqlConnection oCon = new MySqlConnection("SERVER=remotemysql.com; UID=3QsQG7lKpx; PWD=UdPYkmGR2U; DATABASE=3QsQG7lKpx");
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            oCon.Open();
            fnCarrega(0);
        }
        private void fnCarrega(int nFiltro)
        {
            if (nFiltro == 0)
            {
                MySqlDataAdapter grdlivros = new MySqlDataAdapter("SELECT LIVCODIGO CODIGO, LIVNOME TITULO, ESCNOME ESCRITOR, LIVDTLANCAMENTO LANÇAMENTO FROM livro  LEFT JOIN escritor ON LIVESCRITOR = ESCCODIGO", oCon);
                DataTable oAux = new DataTable();
                grdlivros.Fill(oAux);
                grdLivros.DataSource = oAux;
            }
            else if (nFiltro == 1)
            {
                MySqlDataAdapter grdlivros = new MySqlDataAdapter("SELECT LIVCODIGO CODIGO, LIVNOME TITULO, ESCNOME ESCRITOR, LIVDTLANCAMENTO LANÇAMENTO FROM livro  LEFT JOIN escritor ON LIVESCRITOR = ESCCODIGO ORDER BY LIVNOME", oCon);
                DataTable oAux = new DataTable();
                grdlivros.Fill(oAux);
                grdLivros.DataSource = oAux;
                nFiltro = 0;
            }
            else if (nFiltro == 2)
            {
                MySqlDataAdapter grdlivros = new MySqlDataAdapter("SELECT LIVCODIGO CODIGO, LIVNOME TITULO, ESCNOME ESCRITOR, LIVDTLANCAMENTO LANÇAMENTO FROM livro  LEFT JOIN escritor ON LIVESCRITOR = ESCCODIGO ORDER BY ESCNOME", oCon);
                DataTable oAux = new DataTable();
                grdlivros.Fill(oAux);
                grdLivros.DataSource = oAux;
                nFiltro = 0;
            }
            else if (nFiltro == 3)
            {
                MySqlDataAdapter grdlivros = new MySqlDataAdapter("SELECT LIVCODIGO CODIGO, LIVNOME TITULO, ESCNOME ESCRITOR, LIVDTLANCAMENTO LANÇAMENTO FROM livro  LEFT JOIN escritor ON LIVESCRITOR = ESCCODIGO ORDER BY LIVDTLANCAMENTO", oCon);
                DataTable oAux = new DataTable();
                grdlivros.Fill(oAux);
                grdLivros.DataSource = oAux;
                nFiltro = 0;
            }

            MySqlDataAdapter grdemprestimo = new MySqlDataAdapter("SELECT EMPCODIGO CODIGO, CLINOME CLIENTE, LIVNOME LIVRO, EMPDTRETIRADA RETIRADA, EMPDTVENCIMENTO FROM emprestimo  LEFT JOIN cliente  ON EMPCLIENTE = CLICODIGO LEFT JOIN livro ON EMPLIVRO = LIVCODIGO", oCon);
            DataTable oAux2 = new DataTable();
            grdemprestimo.Fill(oAux2);
            grdEmprestimo.DataSource = oAux2;
            

        }

        private void btnEmprestimo_Click(object sender, EventArgs e)
        {
            new frmEmprestimo().ShowDialog();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            fnCarrega(1);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            fnCarrega(2);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            fnCarrega(3);
        }

        private void btnEntregar_Click(object sender, EventArgs e)
        {
            MySqlCommand oComando = new MySqlCommand("DELTE FROM EMPRESTIMO WHERE ", oCon);
        }
    }
}
