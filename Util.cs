using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escola
{
    public class Util
    {
		public bool validarNumero(string numero)
		{
			try
			{
				float.Parse(numero);
				return true;
			}
			catch
			{
				return false;
			}
		}
		public bool validarLogin(string login, string senha)
        {
			if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(senha))
            {
				MessageBox.Show("Preencha todos os campos!");
				return false;
            }
			else if (login != "ETEC" || senha != "etec"){
				MessageBox.Show("Login ou Senha inválidos!");
				return false;
			}
			else
            {
				return true;
            }
        }
	}
}
