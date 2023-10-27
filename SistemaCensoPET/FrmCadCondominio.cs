using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaCensoPET
{
    public partial class FrmCadCondominio : Form
    {
        public FrmCadCondominio()
        {
            InitializeComponent();
        }

        private void toolStripBtnSalvar_Click(object sender, EventArgs e)
        {
            string nome = "", endereco = "", numero = "", cep = "";
            int cep_num = 0, numero_num = 0;
            //Recuperação de Dados
            nome = TxtNome.Text;
            endereco = TxtEndereco.Text;
            numero = TxtNumero.Text;
            cep = TxtCep.Text;
            //Conversao dos Numeros
            cep_num = Convert.ToInt32(cep);
            numero_num = Convert.ToInt32(numero);

            //Saída de Dados
            MessageBox.Show(nome + "\n" + endereco + "\n" + numero + "\n" + cep);
        }
    }
}
