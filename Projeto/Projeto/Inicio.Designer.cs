namespace Projeto
{
    partial class Inicio
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
            this.LabelEscolha = new System.Windows.Forms.Label();
            this.ButtonGestaoVendas = new System.Windows.Forms.Button();
            this.ButtonGestaoAluguer = new System.Windows.Forms.Button();
            this.ButtonGestaoOficina = new System.Windows.Forms.Button();
            this.ButtonGestaoClientes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelEscolha
            // 
            this.LabelEscolha.AutoSize = true;
            this.LabelEscolha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelEscolha.Location = new System.Drawing.Point(41, 80);
            this.LabelEscolha.Name = "LabelEscolha";
            this.LabelEscolha.Size = new System.Drawing.Size(194, 25);
            this.LabelEscolha.TabIndex = 6;
            this.LabelEscolha.Text = "Escolha a sua opção";
            // 
            // ButtonGestaoVendas
            // 
            this.ButtonGestaoVendas.BackgroundImage = global::Projeto.Properties.Resources.icon_buy;
            this.ButtonGestaoVendas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonGestaoVendas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonGestaoVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonGestaoVendas.Location = new System.Drawing.Point(596, 130);
            this.ButtonGestaoVendas.Name = "ButtonGestaoVendas";
            this.ButtonGestaoVendas.Size = new System.Drawing.Size(146, 133);
            this.ButtonGestaoVendas.TabIndex = 10;
            this.ButtonGestaoVendas.Text = "Gestão de Vendas";
            this.ButtonGestaoVendas.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ButtonGestaoVendas.UseVisualStyleBackColor = true;
            // 
            // ButtonGestaoAluguer
            // 
            this.ButtonGestaoAluguer.BackgroundImage = global::Projeto.Properties.Resources.depositphotos_101779230_stock_illustration_rent_buy_a_car_icon;
            this.ButtonGestaoAluguer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonGestaoAluguer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonGestaoAluguer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonGestaoAluguer.Location = new System.Drawing.Point(423, 130);
            this.ButtonGestaoAluguer.Name = "ButtonGestaoAluguer";
            this.ButtonGestaoAluguer.Size = new System.Drawing.Size(146, 133);
            this.ButtonGestaoAluguer.TabIndex = 9;
            this.ButtonGestaoAluguer.Text = "Gestão de Aluguer";
            this.ButtonGestaoAluguer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ButtonGestaoAluguer.UseVisualStyleBackColor = true;
            // 
            // ButtonGestaoOficina
            // 
            this.ButtonGestaoOficina.BackgroundImage = global::Projeto.Properties.Resources.kit_de_ferramentas_para_informática_500x500;
            this.ButtonGestaoOficina.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonGestaoOficina.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonGestaoOficina.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonGestaoOficina.Location = new System.Drawing.Point(250, 130);
            this.ButtonGestaoOficina.Name = "ButtonGestaoOficina";
            this.ButtonGestaoOficina.Size = new System.Drawing.Size(146, 133);
            this.ButtonGestaoOficina.TabIndex = 8;
            this.ButtonGestaoOficina.Text = "Gestão de Oficina";
            this.ButtonGestaoOficina.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ButtonGestaoOficina.UseVisualStyleBackColor = true;
            // 
            // ButtonGestaoClientes
            // 
            this.ButtonGestaoClientes.BackgroundImage = global::Projeto.Properties.Resources.User_Customers2;
            this.ButtonGestaoClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonGestaoClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonGestaoClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonGestaoClientes.Location = new System.Drawing.Point(77, 130);
            this.ButtonGestaoClientes.Name = "ButtonGestaoClientes";
            this.ButtonGestaoClientes.Size = new System.Drawing.Size(146, 133);
            this.ButtonGestaoClientes.TabIndex = 7;
            this.ButtonGestaoClientes.Text = "Gestão de Clientes";
            this.ButtonGestaoClientes.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ButtonGestaoClientes.UseVisualStyleBackColor = true;
            this.ButtonGestaoClientes.Click += new System.EventHandler(this.ButtonGestaoClientes_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 353);
            this.Controls.Add(this.ButtonGestaoVendas);
            this.Controls.Add(this.ButtonGestaoAluguer);
            this.Controls.Add(this.ButtonGestaoOficina);
            this.Controls.Add(this.ButtonGestaoClientes);
            this.Controls.Add(this.LabelEscolha);
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonGestaoVendas;
        private System.Windows.Forms.Button ButtonGestaoAluguer;
        private System.Windows.Forms.Button ButtonGestaoOficina;
        private System.Windows.Forms.Button ButtonGestaoClientes;
        private System.Windows.Forms.Label LabelEscolha;
    }
}