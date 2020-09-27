using Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public static class PessoaContatoDAL
    {
        public static PessoaContato Get(int id)
        {
            using (Context context = new Context())
            {
                return context.PessoaContatos.FirstOrDefault(c => c.Id == id);
            }
        }

        public static PessoaContato Add(PessoaContato pessoa)
        {
            using (Context context = new Context())
            {
                context.PessoaContatos.Add(pessoa);
                context.SaveChanges();
                return pessoa;
            }
        }

        public static PessoaContato Update(PessoaContato pessoa)
        {
            using (Context context = new Context())
            {
                context.PessoaContatos.Update(pessoa);
                context.SaveChanges();
                return pessoa;
            }
        }

        public static List<PessoaContato> GetAllCliente(int cliente)
        {
            using (Context context = new Context())
            {
                return context.PessoaContatos.Where(c => c.IdCliente == cliente).ToList();
            }
        }

        public static bool Remove(PessoaContato pessoaContato)
        {
            using (Context context = new Context())
            {
                context.PessoaContatos.Remove(pessoaContato);
                return context.SaveChanges() > 1;
            }
        }
    }
}
