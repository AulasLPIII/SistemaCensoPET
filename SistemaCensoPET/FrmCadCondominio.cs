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

            //Conexao com o Banco de Dados
            string strconexao = "";
            //String de Conexao com o Banco de Dados
            strconexao = "server=localhost;userid=professor;password=professor@;database=bdcensopet";
            //Criação do Canal de Comunicação
            MySqlConnection con = new MySqlConnection(strconexao);
            //O canal é criado fechado, para usarmos devemos abrí-lo
            con.Open();
            //Comando SQL (insert)
            string comandosql = "insert into condominio (nome, endereco, numero, cep) values (@nome,@endereco,@numero,@cep)";
            //Criacao do objeto de comando (envelope)
            MySqlCommand envelope = new MySqlCommand();
            //Indica ao envelope por qual canal de comunicacao ele será enviado
            envelope.Connection = con;
            //Coloca o comando SQL dentro do envelope
            envelope.CommandText = comandosql;
            //Neste ponto estamos dando ao parâmetro "@nome" o valor da variável "nome"
            envelope.Parameters.AddWithValue("@nome", nome);
            //As três linhas abaixo (comentadas) fazem a mesma ação da unica linha acima
            //MySqlParameter parameter = new MySqlParameter();
            //parameter.ParameterName = "@nome";
            //parameter.Value = nome;
            //Neste ponto estamos dando ao parâmetro "@endereco" o valor da variável "endereco"
            envelope.Parameters.AddWithValue("@endereco", endereco);
            //Neste ponto estamos dando ao parâmetro "@numero" o valor da variável "numero_num"
            envelope.Parameters.AddWithValue("@numero", numero_num);
            //Neste ponto estamos dando ao parâmetro "@cep" o valor da variável "cep"
            envelope.Parameters.AddWithValue("@cep", cep);
            //Cria uma versão preparada do comando em uma instância do SQL Server.
            envelope.Prepare();
            //Executa o comando SQL na instância apontada
            //Ele retorna um valor inteiro que representa a quantidade de linhas afetadas
            int retorno = envelope.ExecuteNonQuery();
            if (retorno > 0) 
            {
                MessageBox.Show("Dados salvos com Sucesso!!!");
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
