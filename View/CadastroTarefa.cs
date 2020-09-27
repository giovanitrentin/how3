using BLL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace View
{
    public partial class CadastroTarefa : Form
    {
        Tarefa tarefa;
        List<Tarefa> tarefas;
        public int cliente;

        public CadastroTarefa()
        {
            InitializeComponent();
        }

        private void Tarefa_Load(object sender, EventArgs e)
        {
            tarefas = TarefaBLL.RetornaTarefas();
            tarefa = tarefas.FirstOrDefault();
            CarregaDadosTarefa();
        }

        private void btnPrimeiro_Click(object sender, EventArgs e)
        {
            tarefa = TarefaBLL.CarregaPrimeiraTarefa();
            CarregaDadosTarefa();
        }

        private void CarregaDadosTarefa()
        {
            tarefas = TarefaBLL.RetornaTarefas();

            if (tarefa != null)
            {
                tarefa.Cliente = ClienteBLL.GetCliente(tarefa.cliente);
                NomeCliente.Text = tarefa.Cliente.NomeFantasia;
                Titulo.Text = tarefa.Titulo;
                DataCriacao.Text = Convert.ToDateTime(tarefa.DataCriacao) > Convert.ToDateTime("01/01/1970") ? Convert.ToDateTime(tarefa.DataCriacao).ToString("dd/MM/yyyy") : "";
                DataVencimento.Text = Convert.ToDateTime(tarefa.DataVencimento) > Convert.ToDateTime("01/01/1970") ? Convert.ToDateTime(tarefa.DataVencimento).ToString("dd/MM/yyyy") : "";
                DataConclusao.Text = Convert.ToDateTime(tarefa.DataConclusao) > Convert.ToDateTime("01/01/1970") ? Convert.ToDateTime(tarefa.DataConclusao).ToString("dd/MM/yyyy") : "";
                StatusTarefa.Text = tarefa.Status;
                EdtPessoaContato.Text = tarefa.PessoaContato;
            }

            btnPrimeiro.Enabled = true;
            btnAnterior.Enabled = true;
            btnProximo.Enabled = true;
            btnUltimo.Enabled = true;
            btnNovo.Enabled = true;
            BtnEditar.Enabled = true;
            btnExcluir.Enabled = true;
            btnCancelar.Enabled = false;
            btnSalvar.Enabled = false;
        }

        private void LimpaDadosTela()
        {
            NomeCliente.Text = "";
            Titulo.Text = "";
            DataCriacao.Text = "";
            DataVencimento.Text = "";
            DataConclusao.Text = "";
            EdtPessoaContato.Text = "";
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (tarefa != null)
            {
                if (tarefa != tarefas.First())
                {
                    int IdControle = tarefa.Id;
                    tarefa = null;

                    while (tarefa == null && IdControle > 0)
                    {
                        tarefa = TarefaBLL.Get(IdControle - 1);
                        IdControle--;
                    }

                    CarregaDadosTarefa();
                }
            }
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            if (tarefa != tarefas.Last())
            {
                int IdControle = tarefa.Id;
                int ultima = TarefaBLL.CarregaUltimaTarefa().Id;
                tarefa = null;

                while (tarefa == null && IdControle <= ultima)
                {
                    tarefa = TarefaBLL.Get(IdControle + 1);
                    IdControle++;
                }

                if (tarefa == null)
                {
                    tarefa = TarefaBLL.CarregaUltimaTarefa();
                }

                CarregaDadosTarefa();
            }
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            tarefa = TarefaBLL.CarregaUltimaTarefa();
            CarregaDadosTarefa();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimpaDadosTela();

            tarefa = new Tarefa();

            btnPrimeiro.Enabled = false;
            btnAnterior.Enabled = false;
            btnProximo.Enabled = false;
            btnUltimo.Enabled = false;
            btnNovo.Enabled = false;
            BtnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = true;
            btnSalvar.Enabled = true;
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            btnPrimeiro.Enabled = false;
            btnAnterior.Enabled = false;
            btnProximo.Enabled = false;
            btnUltimo.Enabled = false;
            btnNovo.Enabled = false;
            BtnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = true;
            btnSalvar.Enabled = true;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (TarefaBLL.DeleteTarefa(tarefa))
            {
                MessageBox.Show("Tarefa Excluída");
                btnPrimeiro_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Falha ao Excluir");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (tarefa != null && tarefa.Id > 0)
            {
                CarregaDadosTarefa();
            }
            else
            {
                LimpaDadosTela();
            }

            btnPrimeiro.Enabled = true;
            btnAnterior.Enabled = true;
            btnProximo.Enabled = true;
            btnUltimo.Enabled = true;
            btnNovo.Enabled = true;
            BtnEditar.Enabled = true;
            btnExcluir.Enabled = true;
            btnCancelar.Enabled = false;
            btnSalvar.Enabled = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(DataCriacao.Text) ||
                String.IsNullOrEmpty(DataVencimento.Text) ||
                String.IsNullOrEmpty(Titulo.Text))
            {
                MessageBox.Show("Data Criação, Data Vencimento e Título são obrigatórios!");
            }
            else
            {
                tarefa.PessoaContato = EdtPessoaContato.Text;
                DateTime.TryParse(DataCriacao.Text, out DateTime date);
                tarefa.DataCriacao = date;
                DateTime.TryParse(DataVencimento.Text, out date);
                tarefa.DataVencimento = date;
                DateTime.TryParse(DataConclusao.Text, out date);
                tarefa.DataConclusao = date;
                tarefa.Titulo = Titulo.Text;
                tarefa.Descricao = Descricao.Text;
                tarefa.cliente = cliente;
                tarefa.Cliente = ClienteBLL.GetCliente(tarefa.cliente);

                tarefa = TarefaBLL.SalvarTarefa(tarefa);

                CarregaDadosTarefa();
            }
        }

        internal void SetaCliente(int id)
        {
            cliente = id;
        }
    }
}
