using System;

namespace Model
{
    public class Tarefa
    {
        public string Status { get; set; }
        public string Titulo { get; set; }
        public DateTime? DataCriacao { get; set; }
        public DateTime? DataVencimento { get; set; }
        public DateTime? DataConclusao { get; set; }
        public string PessoaContato { get; set; }
        public string Descricao { get; set; }
        public int cliente { get; set; }
        public int Id { get; set; }
        public Cliente Cliente { get; set; }
    }
}
