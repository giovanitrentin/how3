using Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public static class TarefaDAL
    {
        public static Tarefa Get(int id)
        {
            using (Context context = new Context())
            {
                return context.Tarefas.FirstOrDefault(c => c.Id == id);
            }
        }

        public static Tarefa Add(Tarefa tarefa)
        {
            using (Context context = new Context())
            {
                context.Tarefas.Add(tarefa);
                context.SaveChanges();
                return tarefa;
            }
        }

        public static Tarefa GetFirst()
        {
            using (Context context = new Context())
            {
                return context.Tarefas.FirstOrDefault();
            }
        }

        public static List<Tarefa> GetAll()
        {
            using (Context context = new Context())
            {
                return context.Tarefas.ToList();
            }
        }

        public static bool Remove(Tarefa tarefa)
        {
            using (Context context = new Context())
            {
                context.Tarefas.Remove(tarefa);
                return context.SaveChanges() > 0;
            }
        }

        public static Tarefa Update(Tarefa tarefa)
        {
            using (Context context = new Context())
            {
                context.Tarefas.Update(tarefa);
                context.SaveChanges();
                return tarefa;
            }
        }

        public static Tarefa GetLast()
        {
            using (Context context = new Context())
            {
                return context.Tarefas.LastOrDefault();
            }
        }

        public static List<Tarefa> GetAllTarefas(int id)
        {
            using (Context context = new Context())
            {
                return context.Tarefas.Where(s => s.cliente == id).OrderBy(s => s.DataVencimento).ToList();
            }
        }
    }
}
