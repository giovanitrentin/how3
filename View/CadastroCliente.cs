using BLL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace View
{
    public partial class CadastroCliente : Form
    {
        Cliente cliente;
        List<Cliente> clientes;

        public CadastroCliente()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void CadastroCliente_Load(object sender, EventArgs e)
        {
            clientes = ClienteBLL.RetornaClientes();
            cliente = clientes.FirstOrDefault();
            CarregaDadosCliente();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            LimpaDadosTela();

            cliente = new Cliente();

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
            if (ClienteBLL.DeletarCliente(cliente.Id))
            {
                MessageBox.Show("Cliente Excluido");
                btnPrimeiro_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Falha ao Excluir");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (cliente != null && cliente.Id > 0)
            {
                CarregaDadosCliente();
            }
            else
            {
                LimpaDadosTela();
            }

            btnPrimeiro.Enabled = true;
            btnAnterior.Enabled = true;
            btnProximo.Enabled =  true;
            btnUltimo.Enabled =   true;
            btnNovo.Enabled =     true;
            BtnEditar.Enabled =   true;
            btnExcluir.Enabled =  true;
            btnCancelar.Enabled = false;
            btnSalvar.Enabled =   false;
        }

        private void LimpaDadosTela()
        {
            NomeCliente.Text = "";
            NomeFantasia.Text = "";
            cnpj.Text = "";
            CPF.Text = "";
            Telefone.Text = "";
            Celular.Text = "";
            CEP.Text = "";
            Endereco.Text = "";
            Numero.Text = "";
            Bairro.Text = "";
            Adicional.Text = "";
            Cidade.Text = "";
            Estado.Text = "";
            Pais.Text = "";
            ObsCliente.Text = "";
            NroCliente.Text = "0";

            ResumoTarefa.DataSource = new List<Tarefa>();
            GradePessoaContato.DataSource = new List<PessoaContato>();
        }

        private void CarregaDadosCliente()
        {
            clientes = ClienteBLL.RetornaClientes();

            if (cliente != null)
            {
                NomeCliente.Text = cliente.NomeCliente;
                NomeFantasia.Text = cliente.NomeFantasia;
                cnpj.Text = cliente.CNPJ;
                CPF.Text = cliente.CPF;
                Telefone.Text = cliente.Telefone;
                Celular.Text = cliente.Celular;
                CEP.Text = cliente.CEP;
                Endereco.Text = cliente.Endereco;
                Numero.Text = cliente.Numero;
                Bairro.Text = cliente.Bairro;
                Adicional.Text = cliente.Adicional;
                Cidade.Text = cliente.Cidade;
                Estado.Text = cliente.Estado;
                Pais.Text = cliente.Pais;
                ObsCliente.Text = cliente.ObsCliente;
                NroCliente.Text = Convert.ToString(cliente.Id);

                cliente.CarregaContatos();
                cliente.CarregaTarefas();

                ResumoTarefa.DataSource = cliente.tarefas;
                GradePessoaContato.DataSource = cliente.pessoaContatos;

                ResumoTarefa.AutoResizeColumns();
                GradePessoaContato.AutoResizeColumns();

                ResumoTarefa.Update();
                ResumoTarefa.Refresh();

                ResumoTarefa.ReadOnly = true;
                GradePessoaContato.ReadOnly = true;

                GradePessoaContato.Update();
                GradePessoaContato.Refresh();
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
            if (String.IsNullOrWhiteSpace(NomeCliente.Text) ||
                String.IsNullOrWhiteSpace(NomeFantasia.Text) ||
                (String.IsNullOrWhiteSpace(cnpj.Text) && String.IsNullOrWhiteSpace(cnpj.Text)) ||
                (String.IsNullOrWhiteSpace(Telefone.Text) && String.IsNullOrWhiteSpace(Celular.Text)) ||
                String.IsNullOrWhiteSpace(CEP.Text) ||
                String.IsNullOrWhiteSpace(Endereco.Text) ||
                String.IsNullOrWhiteSpace(Numero.Text) ||
                String.IsNullOrWhiteSpace(Bairro.Text) ||
                String.IsNullOrWhiteSpace(Cidade.Text) ||
                String.IsNullOrWhiteSpace(Estado.Text) ||
                String.IsNullOrWhiteSpace(Pais.Text))
            {
                if (String.IsNullOrWhiteSpace(NomeCliente.Text)) MessageBox.Show("Digite o Nome do Cliente");
                else if (String.IsNullOrWhiteSpace(NomeFantasia.Text)) MessageBox.Show("Digite o Nome Fantasia do Cliente");
                else if ((String.IsNullOrWhiteSpace(cnpj.Text)) && String.IsNullOrWhiteSpace(cnpj.Text)) MessageBox.Show("Digite o CNPJ ou o CPF do Cliente");
                else if ((String.IsNullOrWhiteSpace(Telefone.Text) && String.IsNullOrWhiteSpace(Celular.Text))) MessageBox.Show("Digite o Celular ou o Telefone do Cliente");
                else if (String.IsNullOrWhiteSpace(CEP.Text)) MessageBox.Show("Digite o CEP do cliente");
                else if (String.IsNullOrWhiteSpace(Endereco.Text)) MessageBox.Show("Digite o Endereço do Cliente");
                else if (String.IsNullOrWhiteSpace(Numero.Text)) MessageBox.Show("Digite o Número do endereço do Cliente");
                else if (String.IsNullOrWhiteSpace(Bairro.Text)) MessageBox.Show("Digite o Bairro do Cliente");
                else if (String.IsNullOrWhiteSpace(Cidade.Text)) MessageBox.Show("Digite a Cidade do Cliente");
                else if (String.IsNullOrWhiteSpace(Estado.Text)) MessageBox.Show("Digite o Estado do Cliente");
                else if (String.IsNullOrWhiteSpace(Pais.Text)) MessageBox.Show("Digite o País do Cliente");
            }
            else 
            {
                if (!ClienteBLL.VerificaExistenciaDocumentoDuplicado(cliente.Id, CPF.Text, cnpj.Text))
                {
                  //  MessageBox.Show("Documento já está em uso");
                }
                else
                {
                    cliente.NomeCliente = NomeCliente.Text;
                    cliente.NomeFantasia = NomeFantasia.Text;
                    cliente.CNPJ = cnpj.Text;
                    cliente.CPF = CPF.Text;
                    cliente.Telefone = Telefone.Text;
                    cliente.Celular = Celular.Text;
                    cliente.CEP = CEP.Text;
                    cliente.Endereco = Endereco.Text;
                    cliente.Numero = Numero.Text;
                    cliente.Bairro = Bairro.Text;
                    cliente.Adicional = Adicional.Text;
                    cliente.Cidade = Cidade.Text;
                    cliente.Estado = Estado.Text;
                    cliente.Pais = Pais.Text;
                    cliente.ObsCliente = ObsCliente.Text;

                    cliente = ClienteBLL.SalvarCliente(cliente);

                    CarregaDadosCliente();
                }
            }
        }

        private void btnPrimeiro_Click(object sender, EventArgs e)
        {
            cliente = ClienteBLL.CarregaPrimeiroCliente();
            CarregaDadosCliente();
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            cliente = ClienteBLL.CarregaUltimoCliente();
            CarregaDadosCliente();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (cliente != clientes.First())
            {
                int IdControle = cliente.Id;
                cliente = null;

                while(cliente == null && IdControle > 0)
                {
                    cliente = ClienteBLL.GetCliente(IdControle - 1);
                    IdControle--;
                }
                
                CarregaDadosCliente();
            }
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            if (cliente != null)
            {
                if (cliente != clientes.Last())
                {
                    int IdControle = cliente.Id;
                    int ultimoCliente = ClienteBLL.CarregaUltimoCliente().Id;
                    cliente = null;

                    while (cliente == null && IdControle <= ultimoCliente)
                    {
                        cliente = ClienteBLL.GetCliente(IdControle + 1);
                        IdControle++;
                    }

                    if (cliente == null)
                    {
                        cliente = ClienteBLL.CarregaUltimoCliente();
                    }

                    CarregaDadosCliente();
                }
            }
        }

        private void btnInserirContato_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(NomeContato.Text) ||
                String.IsNullOrEmpty(EmailContato.Text) ||
                (String.IsNullOrEmpty(CelularContato.Text) && String.IsNullOrEmpty(Telefonecontato.Text)))
            {
                MessageBox.Show("Nome, E-Mail e ao menos um contato telefonico são obrigatórios!");
            }
            else
            {
                var pessoaContato = new PessoaContato
                {
                    Nome = NomeContato.Text,
                    Email = EmailContato.Text,
                    Celular = CelularContato.Text,
                    Telefone = Telefonecontato.Text,
                    IdCliente = cliente.Id
                };

                PessoaContatoBLL.SalvarContato(pessoaContato);

                CarregaDadosCliente();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = new CadastroTarefa();
            form.SetaCliente(cliente.Id);
            form.ShowDialog();
        }

        private void btnAlterarContato_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(NomeContato.Text) ||
               String.IsNullOrEmpty(EmailContato.Text) ||
               (String.IsNullOrEmpty(CelularContato.Text) && String.IsNullOrEmpty(Telefonecontato.Text)))
            {
                MessageBox.Show("Nome, E-Mail e ao menos um contato telefonico são obrigatórios!");
            }
            else
            {
                if (GradePessoaContato.ColumnCount >= 0)
                {
                    int linhaSelec = GradePessoaContato.CurrentRow.Index;

                    if (linhaSelec >= 0)
                    {
                        int Codigo = int.Parse(GradePessoaContato.Rows[linhaSelec].Cells["Id"].Value.ToString());

                        var pessoaContato = PessoaContatoBLL.GetContato(Codigo);

                        pessoaContato.Nome = NomeContato.Text;
                        pessoaContato.Telefone = Telefonecontato.Text;
                        pessoaContato.Celular = CelularContato.Text;
                        pessoaContato.Email = EmailContato.Text;

                        PessoaContatoBLL.AtualizaPessoaContato(pessoaContato);

                        CarregaDadosCliente();
                    }
                }
            }
        }

        private void btnExcluirContato_Click(object sender, EventArgs e)
        {
            int linhaSelec = GradePessoaContato.CurrentRow.Index;

            int Codigo = int.Parse(GradePessoaContato.Rows[linhaSelec].Cells["Id"].Value.ToString());

            var pessoaContato = PessoaContatoBLL.GetContato(Codigo);

            if (PessoaContatoBLL.Remove(pessoaContato))
            {
                CarregaDadosCliente();
            }
            else
            {
                MessageBox.Show("Erro ao excluír!");
            }
        }

        private void CadastroCliente_Deactivate(object sender, EventArgs e)
        {
            var form = new EfetuarLogin();
            form.Close();
        }
    }
}
