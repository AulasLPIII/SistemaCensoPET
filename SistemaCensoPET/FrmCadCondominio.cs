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
using SistemaCensoPET.Controller;
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

            //View se comunicando com o Controller
            CondominioController condominioController = new CondominioController();
            //Controller se comunicando com a View
            int retorno = condominioController.SalvarCondominio(nome,endereco, numero_num, cep);
                        
            if (retorno > 0)
            {
                MessageBox.Show("Dados salvos com Sucesso!!!");
            }
            else
            {
                MessageBox.Show("Algo deu errado!!!");
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

        private void toolStripBtnListar_Click(object sender, EventArgs e)
        {
            //View se comunicando com o Controller
            CondominioController condominioController = new CondominioController();
            //Controller se comunicando com a View
            List<CondominioDTO> lista = condominioController.ListarTodosCondominios();
            //O foreach permite que possamos navegar na lista obtendo
            //os objetos presentes nela
            foreach (CondominioDTO condominiodto in lista)
            {
                MessageBox.Show(condominiodto.Nome);
            }

        }
    }
}
