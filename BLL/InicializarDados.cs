using System;
using DAL;
using Model;

namespace BLL
{
    public static class InicializarDados
    {
        public static void Carrega()
        {
            DadosParaLogin();
            DadosCliente();
            DadosPessoaContato();
            DadosTarefa();
        }

        private static void DadosTarefa()
        {
            TarefaDAL.Add(new Tarefa
            {
                cliente = 1,
                DataConclusao = DateTime.Now.AddDays(-1),
                DataCriacao = DateTime.Now.AddDays(-10),
                DataVencimento = DateTime.Now.AddDays(-8),
                Titulo = "Atividade Teste 1 - Concluida",
                PessoaContato = "Eu mesmo",
                Descricao = "Fiz para testes",
            });

            TarefaDAL.Add(new Tarefa
            {
                cliente = 1,
                DataCriacao = DateTime.Now.AddDays(-1),
                Titulo = "Atividade Teste 1 - Aberta",
                PessoaContato = "Eu mesmo 2",
                Descricao = "Fiz para testes 2",
            });
        }

        private static void DadosParaLogin()
        {
            LoginDAL.Add(new Login { Email = "Helio", Senha = "123" });
            LoginDAL.Add(new Login { Email = "Victor", Senha = "123" });
            LoginDAL.Add(new Login { Email = "Giovani", Senha = "123" });
            LoginDAL.Add(new Login { Email = "Professor", Senha = "123" });
        }

        private static void DadosCliente()
        {
            ClienteDAL.Add(new Cliente { 
                NomeCliente = "Helio Lidoni", 
                NomeFantasia = "Empresa Teste", 
                Adicional = "Apto xx", 
                Bairro = "Ariribá", 
                Celular = "479961588330", 
                CEP = "88338560",
                Cidade = "Balneario Camboriu",
                CNPJ = "24716724000102",
                CPF = "",
                Endereco = "Teste",
                Estado = "SC",
                Numero = "123",
                ObsCliente = "Trabalho Hands On Work",
                Pais = "Brasil",
                Telefone = "4733418830",
            });

            ClienteDAL.Add(new Cliente
            {
                NomeCliente = "Gio",
                NomeFantasia = "Empresa Teste 2",
                Adicional = "Apto xx",
                Bairro = "Centro",
                Celular = "47996699669",
                CEP = "88300000",
                Cidade = "Balneario Camboriu",
                CNPJ = "55482272000167",
                CPF = "",
                Endereco = "Teste",
                Estado = "SC",
                Numero = "123",
                ObsCliente = "Trabalho Hands On Work",
                Pais = "Brasil",
                Telefone = "4733410030",
            });
        }

        private static void DadosPessoaContato()
        {
            PessoaContatoDAL.Add(new PessoaContato { Nome = "Helio", Email = "Teste", Telefone = "", Celular = "47999999999", IdCliente = 1 });
            PessoaContatoDAL.Add(new PessoaContato { Nome = "Junior", Email = "Teste", Telefone = "", Celular = "47999999999", IdCliente = 1 });
            PessoaContatoDAL.Add(new PessoaContato { Nome = "Giovani", Email = "Teste", Telefone = "", Celular = "47999999999", IdCliente = 2 });
        }
    }
}
