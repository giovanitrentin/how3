namespace View
{
    partial class CadastroCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroCliente));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.GradePessoaContato = new System.Windows.Forms.DataGridView();
            this.ResumoTarefa = new System.Windows.Forms.DataGridView();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.NomeCliente = new System.Windows.Forms.TextBox();
            this.Endereco = new System.Windows.Forms.TextBox();
            this.Bairro = new System.Windows.Forms.TextBox();
            this.Cidade = new System.Windows.Forms.TextBox();
            this.Pais = new System.Windows.Forms.TextBox();
            this.Estado = new System.Windows.Forms.TextBox();
            this.Adicional = new System.Windows.Forms.TextBox();
            this.Numero = new System.Windows.Forms.TextBox();
            this.NomeFantasia = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.ObsCliente = new System.Windows.Forms.RichTextBox();
            this.NroCliente = new System.Windows.Forms.Label();
            this.btnInserirContato = new System.Windows.Forms.Button();
            this.btnAlterarContato = new System.Windows.Forms.Button();
            this.btnExcluirContato = new System.Windows.Forms.Button();
            this.NomeContato = new System.Windows.Forms.TextBox();
            this.Telefonecontato = new System.Windows.Forms.TextBox();
            this.CelularContato = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnPrimeiro = new System.Windows.Forms.ToolStripButton();
            this.btnAnterior = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.btnProximo = new System.Windows.Forms.ToolStripButton();
            this.btnUltimo = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnNovo = new System.Windows.Forms.ToolStripButton();
            this.BtnEditar = new System.Windows.Forms.ToolStripButton();
            this.btnExcluir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.btnSalvar = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dsCliente = new System.Data.DataSet();
            this.Celular = new System.Windows.Forms.MaskedTextBox();
            this.Telefone = new System.Windows.Forms.MaskedTextBox();
            this.CEP = new System.Windows.Forms.MaskedTextBox();
            this.CPF = new System.Windows.Forms.MaskedTextBox();
            this.cnpj = new System.Windows.Forms.MaskedTextBox();
            this.EmailContato = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GradePessoaContato)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResumoTarefa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(230, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome Fantasia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "CNPJ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(230, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "CPF";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Telefone";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(231, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Celular";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "CEP";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 159);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Endereço";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(230, 158);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Número";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 184);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Bairro";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(230, 185);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Adicional";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(25, 209);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "Cidade";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(230, 212);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 13);
            this.label14.TabIndex = 13;
            this.label14.Text = "Estado";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(25, 234);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 13);
            this.label15.TabIndex = 14;
            this.label15.Text = "País";
            // 
            // GradePessoaContato
            // 
            this.GradePessoaContato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GradePessoaContato.Location = new System.Drawing.Point(12, 347);
            this.GradePessoaContato.Name = "GradePessoaContato";
            this.GradePessoaContato.Size = new System.Drawing.Size(444, 91);
            this.GradePessoaContato.TabIndex = 15;
            // 
            // ResumoTarefa
            // 
            this.ResumoTarefa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResumoTarefa.Location = new System.Drawing.Point(476, 59);
            this.ResumoTarefa.Name = "ResumoTarefa";
            this.ResumoTarefa.Size = new System.Drawing.Size(343, 159);
            this.ResumoTarefa.TabIndex = 16;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(24, 254);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(171, 20);
            this.label16.TabIndex = 17;
            this.label16.Text = "Pessoas de Contato";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(472, 36);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(175, 20);
            this.label17.TabIndex = 18;
            this.label17.Text = "Resumo das Tarefas";
            // 
            // NomeCliente
            // 
            this.NomeCliente.Location = new System.Drawing.Point(101, 56);
            this.NomeCliente.Name = "NomeCliente";
            this.NomeCliente.Size = new System.Drawing.Size(123, 20);
            this.NomeCliente.TabIndex = 19;
            // 
            // Endereco
            // 
            this.Endereco.Location = new System.Drawing.Point(101, 156);
            this.Endereco.Name = "Endereco";
            this.Endereco.Size = new System.Drawing.Size(123, 20);
            this.Endereco.TabIndex = 24;
            // 
            // Bairro
            // 
            this.Bairro.Location = new System.Drawing.Point(101, 181);
            this.Bairro.Name = "Bairro";
            this.Bairro.Size = new System.Drawing.Size(123, 20);
            this.Bairro.TabIndex = 25;
            // 
            // Cidade
            // 
            this.Cidade.Location = new System.Drawing.Point(101, 206);
            this.Cidade.Name = "Cidade";
            this.Cidade.Size = new System.Drawing.Size(123, 20);
            this.Cidade.TabIndex = 26;
            // 
            // Pais
            // 
            this.Pais.Location = new System.Drawing.Point(101, 231);
            this.Pais.Name = "Pais";
            this.Pais.Size = new System.Drawing.Size(123, 20);
            this.Pais.TabIndex = 27;
            // 
            // Estado
            // 
            this.Estado.Location = new System.Drawing.Point(314, 206);
            this.Estado.Name = "Estado";
            this.Estado.Size = new System.Drawing.Size(123, 20);
            this.Estado.TabIndex = 34;
            // 
            // Adicional
            // 
            this.Adicional.Location = new System.Drawing.Point(314, 181);
            this.Adicional.Name = "Adicional";
            this.Adicional.Size = new System.Drawing.Size(123, 20);
            this.Adicional.TabIndex = 33;
            // 
            // Numero
            // 
            this.Numero.Location = new System.Drawing.Point(314, 156);
            this.Numero.Name = "Numero";
            this.Numero.Size = new System.Drawing.Size(123, 20);
            this.Numero.TabIndex = 32;
            // 
            // NomeFantasia
            // 
            this.NomeFantasia.Location = new System.Drawing.Point(314, 56);
            this.NomeFantasia.Name = "NomeFantasia";
            this.NomeFantasia.Size = new System.Drawing.Size(123, 20);
            this.NomeFantasia.TabIndex = 28;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(472, 263);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(282, 20);
            this.label18.TabIndex = 35;
            this.label18.Text = "Informações Adicionais do Cliente";
            // 
            // ObsCliente
            // 
            this.ObsCliente.Location = new System.Drawing.Point(476, 293);
            this.ObsCliente.Name = "ObsCliente";
            this.ObsCliente.Size = new System.Drawing.Size(343, 145);
            this.ObsCliente.TabIndex = 36;
            this.ObsCliente.Text = "";
            // 
            // NroCliente
            // 
            this.NroCliente.AutoSize = true;
            this.NroCliente.Location = new System.Drawing.Point(117, 32);
            this.NroCliente.Name = "NroCliente";
            this.NroCliente.Size = new System.Drawing.Size(13, 13);
            this.NroCliente.TabIndex = 40;
            this.NroCliente.Text = "0";
            // 
            // btnInserirContato
            // 
            this.btnInserirContato.Location = new System.Drawing.Point(12, 318);
            this.btnInserirContato.Name = "btnInserirContato";
            this.btnInserirContato.Size = new System.Drawing.Size(75, 23);
            this.btnInserirContato.TabIndex = 41;
            this.btnInserirContato.Text = "Inserir";
            this.btnInserirContato.UseVisualStyleBackColor = true;
            this.btnInserirContato.Click += new System.EventHandler(this.btnInserirContato_Click);
            // 
            // btnAlterarContato
            // 
            this.btnAlterarContato.Location = new System.Drawing.Point(93, 318);
            this.btnAlterarContato.Name = "btnAlterarContato";
            this.btnAlterarContato.Size = new System.Drawing.Size(75, 23);
            this.btnAlterarContato.TabIndex = 42;
            this.btnAlterarContato.Text = "Atualizar";
            this.btnAlterarContato.UseVisualStyleBackColor = true;
            this.btnAlterarContato.Click += new System.EventHandler(this.btnAlterarContato_Click);
            // 
            // btnExcluirContato
            // 
            this.btnExcluirContato.Location = new System.Drawing.Point(174, 318);
            this.btnExcluirContato.Name = "btnExcluirContato";
            this.btnExcluirContato.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirContato.TabIndex = 43;
            this.btnExcluirContato.Text = "Excluir";
            this.btnExcluirContato.UseVisualStyleBackColor = true;
            this.btnExcluirContato.Click += new System.EventHandler(this.btnExcluirContato_Click);
            // 
            // NomeContato
            // 
            this.NomeContato.Location = new System.Drawing.Point(12, 293);
            this.NomeContato.Name = "NomeContato";
            this.NomeContato.Size = new System.Drawing.Size(107, 20);
            this.NomeContato.TabIndex = 44;
            // 
            // Telefonecontato
            // 
            this.Telefonecontato.Location = new System.Drawing.Point(238, 293);
            this.Telefonecontato.Name = "Telefonecontato";
            this.Telefonecontato.Size = new System.Drawing.Size(107, 20);
            this.Telefonecontato.TabIndex = 46;
            // 
            // CelularContato
            // 
            this.CelularContato.Location = new System.Drawing.Point(351, 293);
            this.CelularContato.Name = "CelularContato";
            this.CelularContato.Size = new System.Drawing.Size(107, 20);
            this.CelularContato.TabIndex = 47;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(12, 277);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(70, 13);
            this.label19.TabIndex = 48;
            this.label19.Text = "Nome Cliente";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(125, 277);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(71, 13);
            this.label20.TabIndex = 49;
            this.label20.Text = "E-Mail Cliente";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(237, 277);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(84, 13);
            this.label21.TabIndex = 50;
            this.label21.Text = "Telefone Cliente";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(348, 277);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(74, 13);
            this.label22.TabIndex = 51;
            this.label22.Text = "Celular Cliente";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(476, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(343, 23);
            this.button1.TabIndex = 52;
            this.button1.Text = "Abrir Cadastro de Tarefas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPrimeiro
            // 
            this.btnPrimeiro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPrimeiro.Image = ((System.Drawing.Image)(resources.GetObject("btnPrimeiro.Image")));
            this.btnPrimeiro.Name = "btnPrimeiro";
            this.btnPrimeiro.RightToLeftAutoMirrorImage = true;
            this.btnPrimeiro.Size = new System.Drawing.Size(23, 22);
            this.btnPrimeiro.Text = "Move first";
            this.btnPrimeiro.Click += new System.EventHandler(this.btnPrimeiro_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAnterior.Image = ((System.Drawing.Image)(resources.GetObject("btnAnterior.Image")));
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.RightToLeftAutoMirrorImage = true;
            this.btnAnterior.Size = new System.Drawing.Size(23, 22);
            this.btnAnterior.Text = "Move previous";
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // btnProximo
            // 
            this.btnProximo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnProximo.Image = ((System.Drawing.Image)(resources.GetObject("btnProximo.Image")));
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.RightToLeftAutoMirrorImage = true;
            this.btnProximo.Size = new System.Drawing.Size(23, 22);
            this.btnProximo.Text = "Move next";
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // btnUltimo
            // 
            this.btnUltimo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnUltimo.Image = ((System.Drawing.Image)(resources.GetObject("btnUltimo.Image")));
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.RightToLeftAutoMirrorImage = true;
            this.btnUltimo.Size = new System.Drawing.Size(23, 22);
            this.btnUltimo.Text = "Move last";
            this.btnUltimo.Click += new System.EventHandler(this.btnUltimo_Click);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnNovo
            // 
            this.btnNovo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.RightToLeftAutoMirrorImage = true;
            this.btnNovo.Size = new System.Drawing.Size(23, 22);
            this.btnNovo.Text = "Add new";
            this.btnNovo.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnEditar.Image = ((System.Drawing.Image)(resources.GetObject("BtnEditar.Image")));
            this.BtnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(23, 22);
            this.BtnEditar.Text = "toolStripButton1";
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.RightToLeftAutoMirrorImage = true;
            this.btnExcluir.Size = new System.Drawing.Size(23, 22);
            this.btnExcluir.Text = "Delete";
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(23, 22);
            this.btnCancelar.Text = "toolStripButton2";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSalvar.Enabled = false;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(23, 22);
            this.btnSalvar.Text = "toolStripButton3";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.btnNovo;
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = this.btnExcluir;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnPrimeiro,
            this.btnAnterior,
            this.bindingNavigatorSeparator,
            this.btnProximo,
            this.btnUltimo,
            this.bindingNavigatorSeparator2,
            this.btnNovo,
            this.BtnEditar,
            this.btnExcluir,
            this.toolStripSeparator1,
            this.btnCancelar,
            this.btnSalvar});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.btnPrimeiro;
            this.bindingNavigator1.MoveLastItem = this.btnUltimo;
            this.bindingNavigator1.MoveNextItem = this.btnProximo;
            this.bindingNavigator1.MovePreviousItem = this.btnAnterior;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(831, 25);
            this.bindingNavigator1.TabIndex = 39;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // dsCliente
            // 
            this.dsCliente.DataSetName = "NewDataSet";
            // 
            // Celular
            // 
            this.Celular.Location = new System.Drawing.Point(314, 106);
            this.Celular.Mask = "(99) 0 0000-0000";
            this.Celular.Name = "Celular";
            this.Celular.Size = new System.Drawing.Size(123, 20);
            this.Celular.TabIndex = 53;
            // 
            // Telefone
            // 
            this.Telefone.Location = new System.Drawing.Point(101, 106);
            this.Telefone.Mask = "(99) 0 0000-0000";
            this.Telefone.Name = "Telefone";
            this.Telefone.Size = new System.Drawing.Size(123, 20);
            this.Telefone.TabIndex = 54;
            // 
            // CEP
            // 
            this.CEP.Culture = new System.Globalization.CultureInfo("pt-MO");
            this.CEP.Location = new System.Drawing.Point(101, 131);
            this.CEP.Mask = "00000-999";
            this.CEP.Name = "CEP";
            this.CEP.Size = new System.Drawing.Size(123, 20);
            this.CEP.TabIndex = 55;
            // 
            // CPF
            // 
            this.CPF.Culture = new System.Globalization.CultureInfo("pt-MO");
            this.CPF.Location = new System.Drawing.Point(314, 81);
            this.CPF.Mask = "000.000.000-00";
            this.CPF.Name = "CPF";
            this.CPF.Size = new System.Drawing.Size(123, 20);
            this.CPF.TabIndex = 56;
            // 
            // cnpj
            // 
            this.cnpj.Culture = new System.Globalization.CultureInfo("pt-MO");
            this.cnpj.Location = new System.Drawing.Point(101, 80);
            this.cnpj.Mask = "00.000.000/0000-99";
            this.cnpj.Name = "cnpj";
            this.cnpj.Size = new System.Drawing.Size(123, 20);
            this.cnpj.TabIndex = 57;
            this.cnpj.ValidatingType = typeof(int);
            // 
            // EmailContato
            // 
            this.EmailContato.Location = new System.Drawing.Point(125, 293);
            this.EmailContato.Name = "EmailContato";
            this.EmailContato.Size = new System.Drawing.Size(107, 20);
            this.EmailContato.TabIndex = 45;
            // 
            // CadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 482);
            this.Controls.Add(this.cnpj);
            this.Controls.Add(this.CPF);
            this.Controls.Add(this.CEP);
            this.Controls.Add(this.Telefone);
            this.Controls.Add(this.Celular);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.CelularContato);
            this.Controls.Add(this.Telefonecontato);
            this.Controls.Add(this.EmailContato);
            this.Controls.Add(this.NomeContato);
            this.Controls.Add(this.btnExcluirContato);
            this.Controls.Add(this.btnAlterarContato);
            this.Controls.Add(this.btnInserirContato);
            this.Controls.Add(this.NroCliente);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.ObsCliente);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.Estado);
            this.Controls.Add(this.Adicional);
            this.Controls.Add(this.Numero);
            this.Controls.Add(this.NomeFantasia);
            this.Controls.Add(this.Pais);
            this.Controls.Add(this.Cidade);
            this.Controls.Add(this.Bairro);
            this.Controls.Add(this.Endereco);
            this.Controls.Add(this.NomeCliente);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.ResumoTarefa);
            this.Controls.Add(this.GradePessoaContato);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CadastroCliente";
            this.Text = "Cliente";
            this.Deactivate += new System.EventHandler(this.CadastroCliente_Deactivate);
            this.Load += new System.EventHandler(this.CadastroCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GradePessoaContato)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResumoTarefa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView GradePessoaContato;
        private System.Windows.Forms.DataGridView ResumoTarefa;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox NomeCliente;
        private System.Windows.Forms.TextBox Endereco;
        private System.Windows.Forms.TextBox Bairro;
        private System.Windows.Forms.TextBox Cidade;
        private System.Windows.Forms.TextBox Pais;
        private System.Windows.Forms.TextBox Estado;
        private System.Windows.Forms.TextBox Adicional;
        private System.Windows.Forms.TextBox Numero;
        private System.Windows.Forms.TextBox NomeFantasia;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.RichTextBox ObsCliente;
        private System.Windows.Forms.Label NroCliente;
        private System.Windows.Forms.Button btnInserirContato;
        private System.Windows.Forms.Button btnAlterarContato;
        private System.Windows.Forms.Button btnExcluirContato;
        private System.Windows.Forms.TextBox NomeContato;
        private System.Windows.Forms.TextBox Telefonecontato;
        private System.Windows.Forms.TextBox CelularContato;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripButton btnPrimeiro;
        private System.Windows.Forms.ToolStripButton btnAnterior;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripButton btnProximo;
        private System.Windows.Forms.ToolStripButton btnUltimo;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton btnNovo;
        private System.Windows.Forms.ToolStripButton BtnEditar;
        private System.Windows.Forms.ToolStripButton btnExcluir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.ToolStripButton btnSalvar;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Data.DataSet dsCliente;
        private System.Windows.Forms.MaskedTextBox Celular;
        private System.Windows.Forms.MaskedTextBox Telefone;
        private System.Windows.Forms.MaskedTextBox CEP;
        private System.Windows.Forms.MaskedTextBox CPF;
        private System.Windows.Forms.MaskedTextBox cnpj;
        private System.Windows.Forms.TextBox EmailContato;
    }
}