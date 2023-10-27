using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

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

            //Conexao com o Banco de Dados
            string strconexao = "";
            //String de Conexao com o Banco de Dados
            strconexao = "server=localhost;userid=professor;password=professor@;database=bdcensopet";
            //Criação do Canal de Comunicação
            MySqlConnection con = new MySqlConnection(strconexao);
            //O canal é criado fechado, para usarmos devemos abrí-lo
            con.Open();
            if (con.State == ConnectionState.Open)
            {
                MessageBox.Show("Coexão Aberta");
            }
        }

        private void toolStripBtnNovo_Click(object sender, EventArgs e)
        {
            TxtNome.Text = "";
            TxtEndereco.Text = "";
            TxtNumero.Text = "";
            TxtCep.Text = "";
            //Colocamos o foco na caixa de texto do nome do condominio
            TxtNome.Focus();
        }
    }
}
