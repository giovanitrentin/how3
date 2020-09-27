namespace View
{
    partial class CadastroTarefa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroTarefa));
            this.Titulo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NomeCliente = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Descricao = new System.Windows.Forms.RichTextBox();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.btnNovo = new System.Windows.Forms.ToolStripButton();
            this.btnExcluir = new System.Windows.Forms.ToolStripButton();
            this.btnPrimeiro = new System.Windows.Forms.ToolStripButton();
            this.btnAnterior = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.btnProximo = new System.Windows.Forms.ToolStripButton();
            this.btnUltimo = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnEditar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.btnSalvar = new System.Windows.Forms.ToolStripButton();
            this.EdtPessoaContato = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.DataCriacao = new System.Windows.Forms.MaskedTextBox();
            this.DataConclusao = new System.Windows.Forms.MaskedTextBox();
            this.DataVencimento = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.StatusTarefa = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Titulo
            // 
            this.Titulo.Location = new System.Drawing.Point(125, 55);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(511, 20);
            this.Titulo.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Título";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Tarefa ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Cliente";
            // 
            // NomeCliente
            // 
            this.NomeCliente.AutoSize = true;
            this.NomeCliente.Location = new System.Drawing.Point(141, 31);
            this.NomeCliente.Name = "NomeCliente";
            this.NomeCliente.Size = new System.Drawing.Size(74, 13);
            this.NomeCliente.TabIndex = 24;
            this.NomeCliente.Text = "Xxxxxxxxxxxxx";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Data Criação";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(268, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Data Vencimento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Data Conclusão";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 134);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Descrição";
            // 
            // Descricao
            // 
            this.Descricao.Location = new System.Drawing.Point(16, 154);
            this.Descricao.Name = "Descricao";
            this.Descricao.Size = new System.Drawing.Size(620, 240);
            this.Descricao.TabIndex = 37;
            this.Descricao.Text = "";
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
            this.bindingNavigator1.Size = new System.Drawing.Size(653, 25);
            this.bindingNavigator1.TabIndex = 40;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // btnNovo
            // 
            this.btnNovo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.RightToLeftAutoMirrorImage = true;
            this.btnNovo.Size = new System.Drawing.Size(23, 22);
            this.btnNovo.Text = "Add new";
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
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
            // EdtPessoaContato
            // 
            this.EdtPessoaContato.Location = new System.Drawing.Point(380, 105);
            this.EdtPessoaContato.Name = "EdtPessoaContato";
            this.EdtPessoaContato.Size = new System.Drawing.Size(120, 20);
            this.EdtPessoaContato.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(268, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Pessoa Contato";
            // 
            // DataCriacao
            // 
            this.DataCriacao.Location = new System.Drawing.Point(125, 80);
            this.DataCriacao.Mask = "00/00/0000";
            this.DataCriacao.Name = "DataCriacao";
            this.DataCriacao.Size = new System.Drawing.Size(120, 20);
            this.DataCriacao.TabIndex = 41;
            this.DataCriacao.ValidatingType = typeof(System.DateTime);
            // 
            // DataConclusao
            // 
            this.DataConclusao.Location = new System.Drawing.Point(125, 105);
            this.DataConclusao.Mask = "00/00/0000";
            this.DataConclusao.Name = "DataConclusao";
            this.DataConclusao.Size = new System.Drawing.Size(120, 20);
            this.DataConclusao.TabIndex = 42;
            // 
            // DataVencimento
            // 
            this.DataVencimento.Location = new System.Drawing.Point(380, 81);
            this.DataVencimento.Mask = "00/00/0000";
            this.DataVencimento.Name = "DataVencimento";
            this.DataVencimento.Size = new System.Drawing.Size(120, 20);
            this.DataVencimento.TabIndex = 43;
            this.DataVencimento.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(377, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "Status";
            // 
            // StatusTarefa
            // 
            this.StatusTarefa.AutoSize = true;
            this.StatusTarefa.Location = new System.Drawing.Point(420, 31);
            this.StatusTarefa.Name = "StatusTarefa";
            this.StatusTarefa.Size = new System.Drawing.Size(107, 13);
            this.StatusTarefa.TabIndex = 45;
            this.StatusTarefa.Text = "xxxxxxxxxxxxxxxxxxxx";
            // 
            // CadastroTarefa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 412);
            this.Controls.Add(this.StatusTarefa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DataVencimento);
            this.Controls.Add(this.DataConclusao);
            this.Controls.Add(this.DataCriacao);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.Descricao);
            this.Controls.Add(this.EdtPessoaContato);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NomeCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CadastroTarefa";
            this.Text = "Tarefa";
            this.Load += new System.EventHandler(this.Tarefa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Titulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label NomeCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox Descricao;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton btnNovo;
        private System.Windows.Forms.ToolStripButton btnExcluir;
        private System.Windows.Forms.ToolStripButton btnPrimeiro;
        private System.Windows.Forms.ToolStripButton btnAnterior;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripButton btnProximo;
        private System.Windows.Forms.ToolStripButton btnUltimo;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton BtnEditar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.ToolStripButton btnSalvar;
        private System.Windows.Forms.TextBox EdtPessoaContato;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox DataCriacao;
        private System.Windows.Forms.MaskedTextBox DataConclusao;
        private System.Windows.Forms.MaskedTextBox DataVencimento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label StatusTarefa;
    }
}