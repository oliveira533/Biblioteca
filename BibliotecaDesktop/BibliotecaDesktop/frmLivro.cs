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
    public partial class frmLivro : Form
    {
        public frmLivro()
        {
            InitializeComponent();
        }

        private void frmLivro_Load(object sender, EventArgs e)
        {
            MySqlDataAdapter oEscritor = new MySqlDataAdapter("SELECT * FROM escritor", frmPrincipal.oCon);
            DataTable oAux = new DataTable();
            oEscritor.Fill(oAux);
            cbmEscritor.DataSource = oAux;
            cbmEscritor.DisplayMember = "ESCNOME";
            cbmEscritor.ValueMember = "ESCCODIGO";

            MySqlDataAdapter oGenero = new MySqlDataAdapter("SELECT * FROM genero", frmPrincipal.oCon);
            DataTable oAux2 = new DataTable();
            oGenero.Fill(oAux2);
            cbmGenero.DataSource = oAux2;
            cbmGenero.ValueMember = "GNRCODIGO";
            cbmGenero.DisplayMember = "GNRNOME";
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            string sLancamento = dtpLancamento.Value.Year.ToString() + "-" + dtpLancamento.Value.Month.ToString() + "-" + dtpLancamento.Value.Day.ToString();

            MySqlCommand oCmd = new MySqlCommand("INSERT INTO livro(LIVNOME, LIVRESUMO, LIVGENERO, LIVESCRITOR, LIVDTLANCAMENTO, LIVQUANTIDADE) VALUES(@NOME, @RESUMO, @GENERO, @ESCRITOR, @LANCAMENTO, @QUANTIDADE)", frmPrincipal.oCon);
            oCmd.Parameters.AddWithValue("@NOME", txbNome.Text);
            oCmd.Parameters.AddWithValue("@RESUMO", txaResumo.Text);
            oCmd.Parameters.AddWithValue("@GENERO", cbmGenero.SelectedValue);
            oCmd.Parameters.AddWithValue("@ESCRITOR", cbmEscritor.SelectedValue);
            oCmd.Parameters.AddWithValue("@LANCAMENTO", sLancamento);
            oCmd.Parameters.AddWithValue("@QUANTIDADE",txbQtdLivro.Value);
            oCmd.ExecuteNonQuery();
        }
    }
}
