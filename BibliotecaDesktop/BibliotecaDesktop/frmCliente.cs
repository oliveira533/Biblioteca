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
    public partial class frmCliente : Form
    {
        bool bResponsavel = false;
        public frmCliente()
        {
            InitializeComponent();
        }

        private void dtpNascimento_ValueChanged(object sender, EventArgs e)
        {
            int nIdade = 2021 - dtpNascimento.Value.Year ;
            if(nIdade < 16)
            {
                lblResponsavel.Visible = true;
                txbCPFResponsavel.Visible = true;
                bResponsavel = true;
            }
            else
            {
                lblResponsavel.Visible = false;
                txbCPFResponsavel.Visible = false;
                bResponsavel = false;
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            MySqlCommand oCmd = new MySqlCommand("", frmPrincipal.oCon);

            string sNacimento = dtpNascimento.Value.Year + "-" + dtpNascimento.Value.Month + "-" + dtpNascimento.Value.Day;

            if(bResponsavel == false)
            {
                oCmd.CommandText = "INSERT INTO cliente(CLINOME, CLICPF, CLICEP, CLIDTNASCIMENTO) VALUES(@NOME, @CPF, @CEP, @NASCIMENTO)";
                oCmd.Parameters.AddWithValue("@NOME", txbNome.Text);
                oCmd.Parameters.AddWithValue("@CPF", txbCPF.Value);
                oCmd.Parameters.AddWithValue("@CEP", txbCEP.Value);
                oCmd.Parameters.AddWithValue("@NASCIMENTO", sNacimento);
                oCmd.ExecuteNonQuery();
            }
            else if(bResponsavel == true)
            {
                oCmd.CommandText = "INSERT INTO cliente(CLINOME, CLICPF, CLICEP, CLIDTNASCIMENTO, CLICPFRESPONSAVEL) VALUES(@NOME, @CPF, @CEP, @NASCIMENTO, @RESPONSAVEL)";
                oCmd.Parameters.AddWithValue("@NOME", txbNome.Text);
                oCmd.Parameters.AddWithValue("@CPF", txbCPF.Value);
                oCmd.Parameters.AddWithValue("@CEP", txbCEP.Value);
                oCmd.Parameters.AddWithValue("@NASCIMENTO", sNacimento);
                oCmd.Parameters.AddWithValue("@RESPONSAVEL", txbCPFResponsavel.Value);
                oCmd.ExecuteNonQuery();
            }
        }
    }
}
