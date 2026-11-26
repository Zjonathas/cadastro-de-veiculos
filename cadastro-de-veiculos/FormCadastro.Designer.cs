namespace cadastro_de_veiculos
{
    partial class FormCadastro
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
            lbPlaca = new Label();
            lbMarca = new Label();
            lbModelo = new Label();
            lbAnoFab = new Label();
            lbCor = new Label();
            lbPreco = new Label();
            lbTipoComb = new Label();
            cbTipoComb = new ComboBox();
            txtPlaca = new TextBox();
            txtMarca = new TextBox();
            txtCor = new TextBox();
            txtModelo = new TextBox();
            txtAnoFab = new TextBox();
            txtPreco = new TextBox();
            btnCadastraVeiculo = new Button();
            btnCancelarCadastro = new Button();
            btnLimparForm = new Button();
            btnBuscar = new Button();
            btnExcluir = new Button();
            SuspendLayout();
            // 
            // lbPlaca
            // 
            lbPlaca.AutoSize = true;
            lbPlaca.Location = new Point(125, 34);
            lbPlaca.Name = "lbPlaca";
            lbPlaca.Size = new Size(47, 20);
            lbPlaca.TabIndex = 0;
            lbPlaca.Text = "Placa:";
            // 
            // lbMarca
            // 
            lbMarca.AutoSize = true;
            lbMarca.Location = new Point(125, 69);
            lbMarca.Name = "lbMarca";
            lbMarca.Size = new Size(53, 20);
            lbMarca.TabIndex = 1;
            lbMarca.Text = "Marca:";
            // 
            // lbModelo
            // 
            lbModelo.AutoSize = true;
            lbModelo.Location = new Point(412, 37);
            lbModelo.Name = "lbModelo";
            lbModelo.Size = new Size(64, 20);
            lbModelo.TabIndex = 2;
            lbModelo.Text = "Modelo:";
            // 
            // lbAnoFab
            // 
            lbAnoFab.AutoSize = true;
            lbAnoFab.Location = new Point(412, 69);
            lbAnoFab.Name = "lbAnoFab";
            lbAnoFab.Size = new Size(113, 20);
            lbAnoFab.TabIndex = 3;
            lbAnoFab.Text = "Ano fabricação:";
            // 
            // lbCor
            // 
            lbCor.AutoSize = true;
            lbCor.Location = new Point(125, 111);
            lbCor.Name = "lbCor";
            lbCor.Size = new Size(35, 20);
            lbCor.TabIndex = 4;
            lbCor.Text = "Cor:";
            // 
            // lbPreco
            // 
            lbPreco.AutoSize = true;
            lbPreco.Location = new Point(412, 111);
            lbPreco.Name = "lbPreco";
            lbPreco.Size = new Size(49, 20);
            lbPreco.TabIndex = 5;
            lbPreco.Text = "Preço:";
            // 
            // lbTipoComb
            // 
            lbTipoComb.AutoSize = true;
            lbTipoComb.Location = new Point(25, 156);
            lbTipoComb.Name = "lbTipoComb";
            lbTipoComb.Size = new Size(147, 20);
            lbTipoComb.TabIndex = 6;
            lbTipoComb.Text = "Tipo de combustível:";
            // 
            // cbTipoComb
            // 
            cbTipoComb.FormattingEnabled = true;
            cbTipoComb.Items.AddRange(new object[] { "Gasolina", "Flex", "Diesel", "Elétrico" });
            cbTipoComb.Location = new Point(178, 153);
            cbTipoComb.Name = "cbTipoComb";
            cbTipoComb.Size = new Size(151, 28);
            cbTipoComb.TabIndex = 4;
            // 
            // txtPlaca
            // 
            txtPlaca.Location = new Point(178, 31);
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(125, 27);
            txtPlaca.TabIndex = 1;
            txtPlaca.TextChanged += txtPlaca_TextChanged;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(178, 69);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(125, 27);
            txtMarca.TabIndex = 2;
            // 
            // txtCor
            // 
            txtCor.Location = new Point(178, 108);
            txtCor.Name = "txtCor";
            txtCor.Size = new Size(125, 27);
            txtCor.TabIndex = 3;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(530, 34);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(125, 27);
            txtModelo.TabIndex = 5;
            // 
            // txtAnoFab
            // 
            txtAnoFab.Location = new Point(530, 69);
            txtAnoFab.Name = "txtAnoFab";
            txtAnoFab.Size = new Size(125, 27);
            txtAnoFab.TabIndex = 6;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(530, 111);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(125, 27);
            txtPreco.TabIndex = 7;
            // 
            // btnCadastraVeiculo
            // 
            btnCadastraVeiculo.Location = new Point(65, 212);
            btnCadastraVeiculo.Name = "btnCadastraVeiculo";
            btnCadastraVeiculo.Size = new Size(150, 29);
            btnCadastraVeiculo.TabIndex = 8;
            btnCadastraVeiculo.Text = "Cadastrar veículo";
            btnCadastraVeiculo.UseVisualStyleBackColor = true;
            btnCadastraVeiculo.Click += btnCadastraVeiculo_Click;
            // 
            // btnCancelarCadastro
            // 
            btnCancelarCadastro.Location = new Point(556, 212);
            btnCancelarCadastro.Name = "btnCancelarCadastro";
            btnCancelarCadastro.Size = new Size(155, 29);
            btnCancelarCadastro.TabIndex = 11;
            btnCancelarCadastro.Text = "Cancelar cadastro";
            btnCancelarCadastro.UseVisualStyleBackColor = true;
            btnCancelarCadastro.Click += button2_Click;
            // 
            // btnLimparForm
            // 
            btnLimparForm.Location = new Point(390, 212);
            btnLimparForm.Name = "btnLimparForm";
            btnLimparForm.Size = new Size(151, 29);
            btnLimparForm.TabIndex = 10;
            btnLimparForm.Text = "Limpar formulário";
            btnLimparForm.UseVisualStyleBackColor = true;
            btnLimparForm.Click += btnLimparForm_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(309, 30);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(80, 29);
            btnBuscar.TabIndex = 12;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(230, 212);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(145, 29);
            btnExcluir.TabIndex = 9;
            btnExcluir.Text = "Excluir veículo";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // FormCadastro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExcluir);
            Controls.Add(btnBuscar);
            Controls.Add(btnLimparForm);
            Controls.Add(btnCancelarCadastro);
            Controls.Add(btnCadastraVeiculo);
            Controls.Add(txtPreco);
            Controls.Add(txtAnoFab);
            Controls.Add(txtModelo);
            Controls.Add(txtCor);
            Controls.Add(txtMarca);
            Controls.Add(txtPlaca);
            Controls.Add(cbTipoComb);
            Controls.Add(lbTipoComb);
            Controls.Add(lbPreco);
            Controls.Add(lbCor);
            Controls.Add(lbAnoFab);
            Controls.Add(lbModelo);
            Controls.Add(lbMarca);
            Controls.Add(lbPlaca);
            Name = "FormCadastro";
            Text = "Cadastro de Veículos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbPlaca;
        private Label lbMarca;
        private Label lbModelo;
        private Label lbAnoFab;
        private Label lbCor;
        private Label lbPreco;
        private Label lbTipoComb;
        private ComboBox cbTipoComb;
        private TextBox txtPlaca;
        private TextBox txtMarca;
        private TextBox txtCor;
        private TextBox txtModelo;
        private TextBox txtAnoFab;
        private TextBox txtPreco;
        private Button btnCadastraVeiculo;
        private Button btnCancelarCadastro;
        private Button btnLimparForm;
        private Button btnBuscar;
        private Button btnExcluir;
    }
}