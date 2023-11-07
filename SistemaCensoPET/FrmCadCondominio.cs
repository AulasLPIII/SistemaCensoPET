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
using SistemaCensoPET.DTO;

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
            int numero_num = 0;

            //Recuperação de Dados
            nome = TxtNome.Text;
            endereco = TxtEndereco.Text;
            numero = TxtNumero.Text;
            cep = TxtCep.Text;
            //Conversao dos Numeros
            numero_num = Convert.ToInt32(numero);

            //Criando um objeto Condominio
            CondominioDTO condominiodto = new CondominioDTO(0, nome, endereco, numero_num, cep);
            //condominiodao.salvar(condominiodto);


            /*
            if (retorno > 0)
            {
                MessageBox.Show("Dados salvos com Sucesso!!!");
            }
            */
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

        private void toolStripBtnListar_Click(object sender, EventArgs e)
        {
            //String de Conexao com o Banco de Dados
            string strconexao = "server=localhost;userid=professor;password=professor@;database=bdcensopet";
            //Criação do Canal de Comunicação
            MySqlConnection con = new MySqlConnection(strconexao);
            //O canal é criado fechado, para usarmos devemos abrí-lo
            con.Open();
            //Comando SQL (SELECT)
            //Perceba que nosso comando não possui parâmetros
            string comandosql = "select * from condominio";
            //Criacao do objeto de comando (envelope)
            MySqlCommand envelope = new MySqlCommand();
            //Coloca o comando SQL dentro do envelope
            envelope.CommandText = comandosql;
            //Indica ao envelope por qual canal de comunicacao ele será enviado
            envelope.Connection = con;
            //Criação do nosso objeto cursor
            MySqlDataReader cursor = envelope.ExecuteReader();
            while (cursor.Read()) 
            {
                //Usamos o cursor para recuperar o conteúdo de cada coluna de uma linha de dados
                CondominioDTO condominiodto = new CondominioDTO(cursor.GetInt32("idcondominio"), cursor.GetString("nome"), cursor.GetString("endereco"), cursor.GetInt32("numero"), cursor.GetString("cep"));
                MessageBox.Show(condominiodto.Nome + "\n" + condominiodto.Endereco + "\n" + condominiodto.Numero + "\n" + condominiodto.Cep);
            }


        }
    }
}
