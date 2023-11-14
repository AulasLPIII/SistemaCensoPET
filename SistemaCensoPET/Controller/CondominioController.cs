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

        public List<CondominioDTO> ListarTodosCondominios()
        {
            //Controller se comunicando com o DAO
            CondominioDAO condominiodao = new CondominioDAO();
            //Recebendo a lista de condominios do DAO
            List<CondominioDTO> listacond = condominiodao.ListarTodos();
            //Retornando a lista obtida para a View
            return listacond;
        }
    }
}
