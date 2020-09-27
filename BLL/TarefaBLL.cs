using DAL;
using Model;
using System;
using System.Collections.Generic;

namespace BLL
{
    public static class TarefaBLL
    {
        public static Tarefa Get(int id)
        {
            var tarefa = TarefaDAL.Get(id);
            if (tarefa != null)
            {
                tarefa.DataConclusao = tarefa.DataConclusao > Convert.ToDateTime("01/01/1970") ? tarefa.DataConclusao : null;
                tarefa.DataVencimento = tarefa.DataVencimento > Convert.ToDateTime("01/01/1970") ? tarefa.DataVencimento : null;
                tarefa.DataCriacao = tarefa.DataCriacao > Convert.ToDateTime("01/01/1970") ? tarefa.DataCriacao : null;
                tarefa.Status = tarefa.DataConclusao == null ? "Aberta" : "Concluída";
            }
            return tarefa;
        }

        public static Tarefa SalvarTarefa(Tarefa tarefa)
        {
            if (tarefa.Id > 0)
            {
                return Get(TarefaDAL.Update(tarefa).Id);
            }
            else
            {
                return Get(TarefaDAL.Add(tarefa).Id);
            }
            
        }

        internal static List<Tarefa> GetTarefas(int id)
        {
            var tarefas = TarefaDAL.GetAllTarefas(id);
            List<Tarefa> retorno = new List<Tarefa>();

            foreach (var item in tarefas)
            {
                retorno.Add(Get(item.Id));
            }

            return retorno;
        }

        public static Tarefa CarregaPrimeiraTarefa()
        {
            return Get(TarefaDAL.GetFirst().Id);
        }

        public static List<Tarefa> RetornaTarefas()
        {
            var lista = TarefaDAL.GetAll();
            List<Tarefa> listaRetorno = new List<Tarefa>();

            foreach (var item in lista)
            {
                listaRetorno.Add(Get(item.Id));
            }

            return listaRetorno;
        }

        public static Tarefa CarregaUltimaTarefa()
        {
            return Get(TarefaDAL.GetLast().Id);
        }

        public static bool DeleteTarefa(Tarefa tarefa)
        {
            return TarefaDAL.Remove(tarefa);
        }
    }
}
