using SistemaCensoPET.DAO;
using SistemaCensoPET.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCensoPET.Controller
{
    public class CondominioController
    {
        public int SalvarCondominio(string nome, string endereco, int numero, string cep)
        {
            //Controller se comunicando com o DTO
            CondominioDTO condominiodto = new CondominioDTO(nome, endereco, numero, cep);   
            //Controller se comunicando com o DAO
            CondominioDAO condominiodao = new CondominioDAO();
            //DAO se comunicando com o Controller
            int retorno = condominiodao.salvar(condominiodto);
            return retorno;
        }
    }
}
