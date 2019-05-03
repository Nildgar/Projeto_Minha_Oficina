namespace Projeto
{
    partial class Gestao_de_Oficina
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItemFicheiro = new System.Windows.Forms.ToolStripMenuItem();
            this.GroupBoxListaClientes = new System.Windows.Forms.GroupBox();
            this.TextBoxPesquisa = new System.Windows.Forms.TextBox();
            this.ButtonPesquisa = new System.Windows.Forms.Button();
            this.ListBoxClientes = new System.Windows.Forms.ListBox();
            this.GroupBoxCarro = new System.Windows.Forms.GroupBox();
            this.GroupBoxServiço = new System.Windows.Forms.GroupBox();
            this.GroupBoxParcela = new System.Windows.Forms.GroupBox();
            this.GroupBoxCliente = new System.Windows.Forms.GroupBox();
            this.LabelNomeCliente = new System.Windows.Forms.Label();
            this.LabelNifCliente = new System.Windows.Forms.Label();
            this.LabelMoradaCliente = new System.Windows.Forms.Label();
            this.LabelTotalCliente = new System.Windows.Forms.Label();
            this.ListBoxCarros = new System.Windows.Forms.ListBox();
            this.ListBoxServicos = new System.Windows.Forms.ListBox();
            this.LabelTotalServico = new System.Windows.Forms.Label();
            this.ButtonAdicionaCarro = new System.Windows.Forms.Button();
            this.ButtonAdicionaServico = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.ListBoxParcela = new System.Windows.Forms.ListBox();
            this.ButtonRemoveParcela = new System.Windows.Forms.Button();
            this.ButtonAlteraParcela = new System.Windows.Forms.Button();
            this.ButtonAdicionaParcela = new System.Windows.Forms.Button();
            this.TextBoxDescricao = new System.Windows.Forms.TextBox();
            this.TextBoxValor = new System.Windows.Forms.TextBox();
            this.LabelDescricaoParcela = new System.Windows.Forms.Label();
            this.LabelValorParcela = new System.Windows.Forms.Label();
            this.ToolStripMenuItemSair = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemImprimir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.GroupBoxListaClientes.SuspendLayout();
            this.GroupBoxCarro.SuspendLayout();
            this.GroupBoxServiço.SuspendLayout();
            this.GroupBoxParcela.SuspendLayout();
            this.GroupBoxCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemFicheiro});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1081, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItemFicheiro
            // 
            this.ToolStripMenuItemFicheiro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemImprimir,
            this.ToolStripMenuItemSair});
            this.ToolStripMenuItemFicheiro.Name = "ToolStripMenuItemFicheiro";
            this.ToolStripMenuItemFicheiro.Size = new System.Drawing.Size(61, 20);
            this.ToolStripMenuItemFicheiro.Text = "Ficheiro";
            // 
            // GroupBoxListaClientes
            // 
            this.GroupBoxListaClientes.Controls.Add(this.ListBoxClientes);
            this.GroupBoxListaClientes.Controls.Add(this.ButtonPesquisa);
            this.GroupBoxListaClientes.Controls.Add(this.TextBoxPesquisa);
            this.GroupBoxListaClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBoxListaClientes.Location = new System.Drawing.Point(12, 27);
            this.GroupBoxListaClientes.Name = "GroupBoxListaClientes";
            this.GroupBoxListaClientes.Size = new System.Drawing.Size(259, 591);
            this.GroupBoxListaClientes.TabIndex = 1;
            this.GroupBoxListaClientes.TabStop = false;
            this.GroupBoxListaClientes.Text = "Lista Clientes";
            // 
            // TextBoxPesquisa
            // 
            this.TextBoxPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxPesquisa.Location = new System.Drawing.Point(6, 41);
            this.TextBoxPesquisa.Name = "TextBoxPesquisa";
            this.TextBoxPesquisa.Size = new System.Drawing.Size(160, 23);
            this.TextBoxPesquisa.TabIndex = 0;
            // 
            // ButtonPesquisa
            // 
            this.ButtonPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonPesquisa.Location = new System.Drawing.Point(172, 38);
            this.ButtonPesquisa.Name = "ButtonPesquisa";
            this.ButtonPesquisa.Size = new System.Drawing.Size(81, 29);
            this.ButtonPesquisa.TabIndex = 1;
            this.ButtonPesquisa.Text = "Pesquisar";
            this.ButtonPesquisa.UseVisualStyleBackColor = true;
            // 
            // ListBoxClientes
            // 
            this.ListBoxClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBoxClientes.FormattingEnabled = true;
            this.ListBoxClientes.ItemHeight = 20;
            this.ListBoxClientes.Location = new System.Drawing.Point(6, 73);
            this.ListBoxClientes.Name = "ListBoxClientes";
            this.ListBoxClientes.Size = new System.Drawing.Size(247, 504);
            this.ListBoxClientes.TabIndex = 2;
            // 
            // GroupBoxCarro
            // 
            this.GroupBoxCarro.Controls.Add(this.ButtonAdicionaCarro);
            this.GroupBoxCarro.Controls.Add(this.ListBoxCarros);
            this.GroupBoxCarro.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBoxCarro.Location = new System.Drawing.Point(277, 216);
            this.GroupBoxCarro.Name = "GroupBoxCarro";
            this.GroupBoxCarro.Size = new System.Drawing.Size(259, 402);
            this.GroupBoxCarro.TabIndex = 2;
            this.GroupBoxCarro.TabStop = false;
            this.GroupBoxCarro.Text = "Carro";
            // 
            // GroupBoxServiço
            // 
            this.GroupBoxServiço.Controls.Add(this.button5);
            this.GroupBoxServiço.Controls.Add(this.ButtonAdicionaServico);
            this.GroupBoxServiço.Controls.Add(this.LabelTotalServico);
            this.GroupBoxServiço.Controls.Add(this.ListBoxServicos);
            this.GroupBoxServiço.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBoxServiço.Location = new System.Drawing.Point(542, 216);
            this.GroupBoxServiço.Name = "GroupBoxServiço";
            this.GroupBoxServiço.Size = new System.Drawing.Size(259, 402);
            this.GroupBoxServiço.TabIndex = 3;
            this.GroupBoxServiço.TabStop = false;
            this.GroupBoxServiço.Text = "Serviço";
            // 
            // GroupBoxParcela
            // 
            this.GroupBoxParcela.Controls.Add(this.LabelValorParcela);
            this.GroupBoxParcela.Controls.Add(this.LabelDescricaoParcela);
            this.GroupBoxParcela.Controls.Add(this.TextBoxValor);
            this.GroupBoxParcela.Controls.Add(this.TextBoxDescricao);
            this.GroupBoxParcela.Controls.Add(this.ButtonRemoveParcela);
            this.GroupBoxParcela.Controls.Add(this.ButtonAlteraParcela);
            this.GroupBoxParcela.Controls.Add(this.ButtonAdicionaParcela);
            this.GroupBoxParcela.Controls.Add(this.ListBoxParcela);
            this.GroupBoxParcela.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBoxParcela.Location = new System.Drawing.Point(807, 216);
            this.GroupBoxParcela.Name = "GroupBoxParcela";
            this.GroupBoxParcela.Size = new System.Drawing.Size(259, 402);
            this.GroupBoxParcela.TabIndex = 4;
            this.GroupBoxParcela.TabStop = false;
            this.GroupBoxParcela.Text = "Parcela";
            // 
            // GroupBoxCliente
            // 
            this.GroupBoxCliente.Controls.Add(this.LabelTotalCliente);
            this.GroupBoxCliente.Controls.Add(this.LabelMoradaCliente);
            this.GroupBoxCliente.Controls.Add(this.LabelNifCliente);
            this.GroupBoxCliente.Controls.Add(this.LabelNomeCliente);
            this.GroupBoxCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBoxCliente.Location = new System.Drawing.Point(277, 27);
            this.GroupBoxCliente.Name = "GroupBoxCliente";
            this.GroupBoxCliente.Size = new System.Drawing.Size(789, 183);
            this.GroupBoxCliente.TabIndex = 5;
            this.GroupBoxCliente.TabStop = false;
            this.GroupBoxCliente.Text = "Cliente";
            // 
            // LabelNomeCliente
            // 
            this.LabelNomeCliente.AutoSize = true;
            this.LabelNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNomeCliente.Location = new System.Drawing.Point(82, 44);
            this.LabelNomeCliente.Name = "LabelNomeCliente";
            this.LabelNomeCliente.Size = new System.Drawing.Size(70, 25);
            this.LabelNomeCliente.TabIndex = 0;
            this.LabelNomeCliente.Text = "Nome:";
            // 
            // LabelNifCliente
            // 
            this.LabelNifCliente.AutoSize = true;
            this.LabelNifCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNifCliente.Location = new System.Drawing.Point(82, 137);
            this.LabelNifCliente.Name = "LabelNifCliente";
            this.LabelNifCliente.Size = new System.Drawing.Size(49, 25);
            this.LabelNifCliente.TabIndex = 1;
            this.LabelNifCliente.Text = "NIF:";
            // 
            // LabelMoradaCliente
            // 
            this.LabelMoradaCliente.AutoSize = true;
            this.LabelMoradaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMoradaCliente.Location = new System.Drawing.Point(82, 91);
            this.LabelMoradaCliente.Name = "LabelMoradaCliente";
            this.LabelMoradaCliente.Size = new System.Drawing.Size(85, 25);
            this.LabelMoradaCliente.TabIndex = 2;
            this.LabelMoradaCliente.Text = "Morada:";
            // 
            // LabelTotalCliente
            // 
            this.LabelTotalCliente.AutoSize = true;
            this.LabelTotalCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTotalCliente.Location = new System.Drawing.Point(525, 137);
            this.LabelTotalCliente.Name = "LabelTotalCliente";
            this.LabelTotalCliente.Size = new System.Drawing.Size(104, 25);
            this.LabelTotalCliente.TabIndex = 4;
            this.LabelTotalCliente.Text = "Total: -,--€";
            // 
            // ListBoxCarros
            // 
            this.ListBoxCarros.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBoxCarros.FormattingEnabled = true;
            this.ListBoxCarros.ItemHeight = 20;
            this.ListBoxCarros.Location = new System.Drawing.Point(6, 38);
            this.ListBoxCarros.Name = "ListBoxCarros";
            this.ListBoxCarros.Size = new System.Drawing.Size(247, 304);
            this.ListBoxCarros.TabIndex = 0;
            // 
            // ListBoxServicos
            // 
            this.ListBoxServicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBoxServicos.FormattingEnabled = true;
            this.ListBoxServicos.ItemHeight = 20;
            this.ListBoxServicos.Location = new System.Drawing.Point(6, 38);
            this.ListBoxServicos.Name = "ListBoxServicos";
            this.ListBoxServicos.Size = new System.Drawing.Size(247, 244);
            this.ListBoxServicos.TabIndex = 2;
            // 
            // LabelTotalServico
            // 
            this.LabelTotalServico.AutoSize = true;
            this.LabelTotalServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTotalServico.Location = new System.Drawing.Point(6, 288);
            this.LabelTotalServico.Name = "LabelTotalServico";
            this.LabelTotalServico.Size = new System.Drawing.Size(156, 22);
            this.LabelTotalServico.TabIndex = 5;
            this.LabelTotalServico.Text = "Total serviço: -,--€";
            // 
            // ButtonAdicionaCarro
            // 
            this.ButtonAdicionaCarro.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAdicionaCarro.Location = new System.Drawing.Point(6, 359);
            this.ButtonAdicionaCarro.Name = "ButtonAdicionaCarro";
            this.ButtonAdicionaCarro.Size = new System.Drawing.Size(247, 37);
            this.ButtonAdicionaCarro.TabIndex = 2;
            this.ButtonAdicionaCarro.Text = "Adicionar Carro";
            this.ButtonAdicionaCarro.UseVisualStyleBackColor = true;
            // 
            // ButtonAdicionaServico
            // 
            this.ButtonAdicionaServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAdicionaServico.Location = new System.Drawing.Point(6, 316);
            this.ButtonAdicionaServico.Name = "ButtonAdicionaServico";
            this.ButtonAdicionaServico.Size = new System.Drawing.Size(119, 80);
            this.ButtonAdicionaServico.TabIndex = 3;
            this.ButtonAdicionaServico.Text = "Adicionar Serviço";
            this.ButtonAdicionaServico.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(134, 316);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(119, 80);
            this.button5.TabIndex = 6;
            this.button5.Text = "Remover Serviço";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // ListBoxParcela
            // 
            this.ListBoxParcela.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBoxParcela.FormattingEnabled = true;
            this.ListBoxParcela.ItemHeight = 20;
            this.ListBoxParcela.Location = new System.Drawing.Point(6, 38);
            this.ListBoxParcela.Name = "ListBoxParcela";
            this.ListBoxParcela.Size = new System.Drawing.Size(247, 204);
            this.ListBoxParcela.TabIndex = 7;
            // 
            // ButtonRemoveParcela
            // 
            this.ButtonRemoveParcela.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonRemoveParcela.Location = new System.Drawing.Point(134, 359);
            this.ButtonRemoveParcela.Name = "ButtonRemoveParcela";
            this.ButtonRemoveParcela.Size = new System.Drawing.Size(119, 37);
            this.ButtonRemoveParcela.TabIndex = 7;
            this.ButtonRemoveParcela.Text = "Remover";
            this.ButtonRemoveParcela.UseVisualStyleBackColor = true;
            // 
            // ButtonAlteraParcela
            // 
            this.ButtonAlteraParcela.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAlteraParcela.Location = new System.Drawing.Point(6, 359);
            this.ButtonAlteraParcela.Name = "ButtonAlteraParcela";
            this.ButtonAlteraParcela.Size = new System.Drawing.Size(119, 37);
            this.ButtonAlteraParcela.TabIndex = 8;
            this.ButtonAlteraParcela.Text = "Alterar";
            this.ButtonAlteraParcela.UseVisualStyleBackColor = true;
            // 
            // ButtonAdicionaParcela
            // 
            this.ButtonAdicionaParcela.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAdicionaParcela.Location = new System.Drawing.Point(6, 316);
            this.ButtonAdicionaParcela.Name = "ButtonAdicionaParcela";
            this.ButtonAdicionaParcela.Size = new System.Drawing.Size(247, 37);
            this.ButtonAdicionaParcela.TabIndex = 9;
            this.ButtonAdicionaParcela.Text = "Adicionar";
            this.ButtonAdicionaParcela.UseVisualStyleBackColor = true;
            // 
            // TextBoxDescricao
            // 
            this.TextBoxDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxDescricao.Location = new System.Drawing.Point(107, 250);
            this.TextBoxDescricao.Name = "TextBoxDescricao";
            this.TextBoxDescricao.Size = new System.Drawing.Size(146, 27);
            this.TextBoxDescricao.TabIndex = 10;
            // 
            // TextBoxValor
            // 
            this.TextBoxValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxValor.Location = new System.Drawing.Point(107, 283);
            this.TextBoxValor.Name = "TextBoxValor";
            this.TextBoxValor.Size = new System.Drawing.Size(146, 27);
            this.TextBoxValor.TabIndex = 11;
            // 
            // LabelDescricaoParcela
            // 
            this.LabelDescricaoParcela.AutoSize = true;
            this.LabelDescricaoParcela.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDescricaoParcela.Location = new System.Drawing.Point(6, 253);
            this.LabelDescricaoParcela.Name = "LabelDescricaoParcela";
            this.LabelDescricaoParcela.Size = new System.Drawing.Size(95, 22);
            this.LabelDescricaoParcela.TabIndex = 7;
            this.LabelDescricaoParcela.Text = "Descrição:";
            // 
            // LabelValorParcela
            // 
            this.LabelValorParcela.AutoSize = true;
            this.LabelValorParcela.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelValorParcela.Location = new System.Drawing.Point(6, 286);
            this.LabelValorParcela.Name = "LabelValorParcela";
            this.LabelValorParcela.Size = new System.Drawing.Size(57, 22);
            this.LabelValorParcela.TabIndex = 12;
            this.LabelValorParcela.Text = "Valor:";
            // 
            // ToolStripMenuItemSair
            // 
            this.ToolStripMenuItemSair.Name = "ToolStripMenuItemSair";
            this.ToolStripMenuItemSair.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItemSair.Text = "Sair";
            // 
            // ToolStripMenuItemImprimir
            // 
            this.ToolStripMenuItemImprimir.Name = "ToolStripMenuItemImprimir";
            this.ToolStripMenuItemImprimir.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItemImprimir.Text = "Imprimir";
            // 
            // Gestao_de_Oficina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 630);
            this.Controls.Add(this.GroupBoxCliente);
            this.Controls.Add(this.GroupBoxParcela);
            this.Controls.Add(this.GroupBoxServiço);
            this.Controls.Add(this.GroupBoxCarro);
            this.Controls.Add(this.GroupBoxListaClientes);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Gestao_de_Oficina";
            this.Text = "Gestao_de_Oficina";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.GroupBoxListaClientes.ResumeLayout(false);
            this.GroupBoxListaClientes.PerformLayout();
            this.GroupBoxCarro.ResumeLayout(false);
            this.GroupBoxServiço.ResumeLayout(false);
            this.GroupBoxServiço.PerformLayout();
            this.GroupBoxParcela.ResumeLayout(false);
            this.GroupBoxParcela.PerformLayout();
            this.GroupBoxCliente.ResumeLayout(false);
            this.GroupBoxCliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemFicheiro;
        private System.Windows.Forms.GroupBox GroupBoxListaClientes;
        private System.Windows.Forms.ListBox ListBoxClientes;
        private System.Windows.Forms.Button ButtonPesquisa;
        private System.Windows.Forms.TextBox TextBoxPesquisa;
        private System.Windows.Forms.GroupBox GroupBoxCarro;
        private System.Windows.Forms.GroupBox GroupBoxServiço;
        private System.Windows.Forms.GroupBox GroupBoxParcela;
        private System.Windows.Forms.GroupBox GroupBoxCliente;
        private System.Windows.Forms.Label LabelMoradaCliente;
        private System.Windows.Forms.Label LabelNifCliente;
        private System.Windows.Forms.Label LabelNomeCliente;
        private System.Windows.Forms.Button ButtonAdicionaCarro;
        private System.Windows.Forms.ListBox ListBoxCarros;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button ButtonAdicionaServico;
        private System.Windows.Forms.Label LabelTotalServico;
        private System.Windows.Forms.ListBox ListBoxServicos;
        private System.Windows.Forms.Label LabelValorParcela;
        private System.Windows.Forms.Label LabelDescricaoParcela;
        private System.Windows.Forms.TextBox TextBoxValor;
        private System.Windows.Forms.TextBox TextBoxDescricao;
        private System.Windows.Forms.Button ButtonRemoveParcela;
        private System.Windows.Forms.Button ButtonAlteraParcela;
        private System.Windows.Forms.Button ButtonAdicionaParcela;
        private System.Windows.Forms.ListBox ListBoxParcela;
        private System.Windows.Forms.Label LabelTotalCliente;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSair;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemImprimir;
    }
}