using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escola
{
    public partial class CadastrarProfessor : Form
    {
        public CadastrarProfessor()
        {
            InitializeComponent();
        }
        Util validacao = new Util();
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" || txtRM.Text == "" || txtCPF.Text == "" || txtEmail.Text == "" || txtTelefone.Text == "" || txtDisciplina.Text == "" || txtSalario.Text == "" || txtEstado.Text == "" || txtCidade.Text == "" || txtBairro.Text == "" || txtRua.Text == "" || txtNumero.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!");
            }
            else if (validacao.validarNumero(txtRM.Text) == false)
            {
                MessageBox.Show("RM deve conter apenas números!");
            }
            else if (validacao.validarNumero(txtCPF.Text) == false)
            {
                MessageBox.Show("CPF deve conter apenas números!");
            }
            else if (validacao.validarNumero(txtTelefone.Text) == false)
            {
                MessageBox.Show("Telefone deve conter apenas números!");
            }
            else if (validacao.validarNumero(txtSalario.Text) == false)
            {
                MessageBox.Show("Salário deve conter apenas números!");
            }
        }
    }
}
