using DAL;
using Model;
using System;
using System.Collections.Generic;

namespace BLL
{
    public static class PessoaContatoBLL
    {
        public static PessoaContato SalvarContato(PessoaContato pessoa)
        {
            if (pessoa.Id > 0)
            {
                return PessoaContatoDAL.Update(pessoa);
            }
            else
            {
                return PessoaContatoDAL.Add(pessoa);
            }
        }

        public static List<PessoaContato> GetPessoaContato(int id)
        {
            return PessoaContatoDAL.GetAllCliente(id);
        }

        public static PessoaContato GetContato(int codigo)
        {
            return PessoaContatoDAL.Get(codigo);
        }

        public static PessoaContato AtualizaPessoaContato(PessoaContato pessoaContato)
        {
            return PessoaContatoDAL.Update(pessoaContato);
        }

        public static bool Remove(PessoaContato pessoaContato)
        {
            return PessoaContatoDAL.Remove(pessoaContato);
        }
    }
}
