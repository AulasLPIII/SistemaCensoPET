using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCensoPET.DTO
{
    public class CondominioDTO
    {
        private int id;
        private string nome;
        private string endereco;
        private int numero;
        private string cep;

        public CondominioDTO(string nome, string endereco, int numero, string cep)
        {
            this.nome = nome;
            this.endereco = endereco;
            this.numero = numero;
            this.cep = cep;
        }

        public CondominioDTO(int id, string nome, string endereco, int numero, string cep)
        {
            this.id = id;
            this.nome = nome;
            this.endereco = endereco;
            this.numero = numero;
            this.cep = cep;
        }

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public int Numero { get => numero; set => numero = value; }
        public string Cep { get => cep; set => cep = value; }
    }
}
