using DAL;
using Model;
using System;
using System.Collections.Generic;

namespace BLL
{
    public static class ClienteBLL
    {
        public static Cliente CarregaContatos(this Cliente cliente)
        {
            cliente.pessoaContatos = PessoaContatoBLL.GetPessoaContato(cliente.Id);
            return cliente;
        }

        public static Cliente CarregaTarefas(this Cliente cliente)
        {
            cliente.tarefas = TarefaBLL.GetTarefas(cliente.Id);
            return cliente;
        }

        public static List<Cliente> RetornaClientes()
        {
            var clientes = ClienteDAL.GetAll();
            

            return clientes;
        }

        public static bool DeletarCliente(int v)
        {
            return ClienteDAL.Delete(ClienteDAL.Get(v));
        }

        public static Cliente GetCliente(int id)
        {
            return ClienteDAL.Get(id);
        }

        public static Cliente SalvarCliente(Cliente cliente)
        {
            if (cliente.Id > 0)
            {
                return ClienteDAL.Update(cliente);
            }
            else
            {
                return ClienteDAL.Add(cliente);
            }
            
        }

        public static Cliente CarregaPrimeiroCliente()
        {
            return ClienteDAL.GetFirst();
        }

        public static Cliente CarregaUltimoCliente()
        {
            return ClienteDAL.GetLast();
        }

        public static bool VerificaExistenciaDocumentoDuplicado(int id, string documento, string documento2)
        {
            if (id == 0)
            {
                var cliente = ClienteDAL.LerCNPJCPF(documento);
                cliente.AddRange(ClienteDAL.LerCNPJCPF(documento2));

                if (cliente == null || cliente.Count == 0)
                {
                    return true; 
                }
            }
            else
            {
                var cliente = ClienteDAL.LerCNPJCPF(documento);
                cliente.AddRange(ClienteDAL.LerCNPJCPF(documento2));

                if (cliente.Count == 1)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
