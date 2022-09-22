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
    public partial class InserirDesempenhoAluno : Form
    {
        public InserirDesempenhoAluno()
        {
            InitializeComponent();
        }
        Util validacao = new Util();
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" || txtRM.Text == "" || txtFaltas.Text == "" || cbMI1.Text == "" || cbMF1.Text == "" || cbMI2.Text == "" || cbMF2.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!");
            } 
            else if (validacao.validarNumero(txtRM.Text) == false)
            {
                MessageBox.Show("RM deve conter apenas números");
            }
            else if (validacao.validarNumero(txtFaltas.Text) == false)
            {
                MessageBox.Show("Faltas deve conter apenas números");
            }
        }
    }
}
