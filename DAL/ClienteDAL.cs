using Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public static class ClienteDAL
    {
        public static Cliente Get(int id)
        {
            using (Context context = new Context())
            {
                var cliente = context.Clientes.FirstOrDefault(c => c.Id == id);
                if (cliente != null)
                {
                    cliente.pessoaContatos = PessoaContatoDAL.GetAllCliente(cliente.Id);
                    cliente.tarefas = TarefaDAL.GetAllTarefas(cliente.Id);
                }
                return cliente;
            }
        }

        public static Cliente Add(Cliente cliente)
        {
            using (Context context = new Context())
            {
                context.Clientes.Add(cliente);
                context.SaveChanges();
                return cliente;
            }
        }

        public static Cliente Update(Cliente cliente)
        {
            using (Context context = new Context())
            {
                context.Clientes.Update(cliente);
                context.SaveChanges();
                return cliente;
            }
        }

        public static Cliente GetFirst()
        {
            using (Context context = new Context())
            {
                var cliente =  context.Clientes.FirstOrDefault();
                if (cliente != null)
                {
                    cliente.pessoaContatos = PessoaContatoDAL.GetAllCliente(cliente.Id);
                    cliente.tarefas = TarefaDAL.GetAllTarefas(cliente.Id);
                }
                return cliente;
            }
        }

        public static List<Cliente> LerCNPJCPF(string documento)
        {
            using (Context context = new Context())
            {
                return context.Clientes.Where(c => c.CNPJ.Equals(documento) || c.CPF.Equals(documento)).ToList();
            }
        }

        public static Cliente GetLast()
        {
            using (Context context = new Context())
            {
                var cliente = context.Clientes.LastOrDefault();
                if (cliente != null)
                {
                    cliente.pessoaContatos = PessoaContatoDAL.GetAllCliente(cliente.Id);
                    cliente.tarefas = TarefaDAL.GetAllTarefas(cliente.Id);
                }
                return cliente;
            }
        }

        public static List<Cliente> GetAll()
        {
            using (Context context = new Context())
            {
                return context.Clientes.ToList();
            }
        }

        public static bool Delete(Cliente cli)
        {
            if (cli != null)
            {
                using (Context context = new Context())
                {
                    context.Clientes.Remove(cli);
                    return context.SaveChanges() > 0;
                }
            }

            return false;
        }
    }
}
