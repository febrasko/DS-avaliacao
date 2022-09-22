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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text == "" || txtSenha.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!");
            } else if (txtLogin.Text != "ETEC" && txtSenha.Text != "etec")
            {
                MessageBox.Show("Usuário ou senha inválidos.");
            } else
            {
                ConsultarAlunos tela = new ConsultarAlunos();
                tela.Show();
            }
        }
        private void btnAlunos_Click_1(object sender, EventArgs e)
        {
            if (txtLogin.Text == "" || txtSenha.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!");
            }
            else if (txtLogin.Text != "ETEC" || txtSenha.Text != "etec")
            {
                MessageBox.Show("Usuário ou senha inválidos.");
            }
            else
            {
                ConsultarAlunos tela = new ConsultarAlunos();
                tela.Show();
            }
        }

        private void btnProfessores_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text == "" || txtSenha.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!");
            }
            else if (txtLogin.Text != "ETEC" || txtSenha.Text != "etec")
            {
                MessageBox.Show("Usuário ou senha inválidos.");
            }
            else
            {
                ConsultarProfessores tela = new ConsultarProfessores();
                tela.Show();
            }
        }
    }
}
