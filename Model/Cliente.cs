using System.Collections.Generic;

namespace Model
{
    public class Cliente
    {
        public int Id { get; set; }
        public string NomeCliente { get; set; }
        public string NomeFantasia { get; set; }
        public string CNPJ { get; set; }
        public string CPF { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string CEP { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Adicional { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }
        public string ObsCliente { get; set; }
        public List<PessoaContato> pessoaContatos { get; set; }
        public List<Tarefa> tarefas { get; set; }
    }
}
