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
    public partial class frmEscritor : Form
    {
        bool bVivo = true;
        public frmEscritor()
        {
            InitializeComponent();
        }

        private void rdbNao_CheckedChanged(object sender, EventArgs e)
        {
            lblFalecimento.Visible = true;
            dtpFalecimento.Visible = true;
            bVivo = false;
        }

        private void rdbSim_CheckedChanged(object sender, EventArgs e)
        {
            lblFalecimento.Visible = false;
            dtpFalecimento.Visible = false;
            bVivo = true;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            MySqlCommand oCmd = new MySqlCommand("", frmPrincipal.oCon);

            string sNascimento = dtpNascimento.Value.Year + "-" + dtpNascimento.Value.Month + "-" + dtpNascimento.Value.Day;
            string sFalecimento = dtpFalecimento.Value.Year + "-" + dtpFalecimento.Value.Month + "-" + dtpFalecimento.Value.Day;

            if (bVivo == true)
            {
                
                oCmd.CommandText = "INSERT INTO escritor(ESCNOME, ESCRESUMO, ESCDTNASCIMENTO) VALUES (@NOME, @RESUMO, @NASCIMENTO)";
                oCmd.Parameters.AddWithValue("@NOME", txbNome.Text);
                oCmd.Parameters.AddWithValue("@RESUMO", txaResumo.Text);
                oCmd.Parameters.AddWithValue("@NASCIMENTO", sNascimento);
                //MessageBox.Show(sNascimento);
                oCmd.ExecuteNonQuery();
            }
            else if(bVivo == false)
            {
                oCmd.CommandText = "INSERT INTO escritor(ESCNOME, ESCRESUMO, ESCDTNASCIMENTO, ESCFALECIMENTO) VALUES (@NOME, @RESUMO, @NASCIMENTO, @FALECIMENTO)";
                oCmd.Parameters.AddWithValue("@NOME", txbNome.Text);
                oCmd.Parameters.AddWithValue("@RESUMO", txaResumo.Text);
                oCmd.Parameters.AddWithValue("@NASCIMENTO", sNascimento);
                oCmd.Parameters.AddWithValue("@FALECIMENTO", sFalecimento);
                oCmd.ExecuteNonQuery();
            }
        }
    }
}
