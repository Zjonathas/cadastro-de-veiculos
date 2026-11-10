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
            label1 = new Label();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // lbPlaca
            // 
            lbPlaca.AutoSize = true;
            lbPlaca.Location = new Point(63, 34);
            lbPlaca.Name = "lbPlaca";
            lbPlaca.Size = new Size(47, 20);
            lbPlaca.TabIndex = 0;
            lbPlaca.Text = "Placa:";
            // 
            // lbMarca
            // 
            lbMarca.AutoSize = true;
            lbMarca.Location = new Point(63, 69);
            lbMarca.Name = "lbMarca";
            lbMarca.Size = new Size(53, 20);
            lbMarca.TabIndex = 1;
            lbMarca.Text = "Marca:";
            // 
            // lbModelo
            // 
            lbModelo.AutoSize = true;
            lbModelo.Location = new Point(388, 37);
            lbModelo.Name = "lbModelo";
            lbModelo.Size = new Size(64, 20);
            lbModelo.TabIndex = 2;
            lbModelo.Text = "Modelo:";
            // 
            // lbAnoFab
            // 
            lbAnoFab.AutoSize = true;
            lbAnoFab.Location = new Point(388, 69);
            lbAnoFab.Name = "lbAnoFab";
            lbAnoFab.Size = new Size(113, 20);
            lbAnoFab.TabIndex = 3;
            lbAnoFab.Text = "Ano fabricação:";
            // 
            // lbCor
            // 
            lbCor.AutoSize = true;
            lbCor.Location = new Point(63, 111);
            lbCor.Name = "lbCor";
            lbCor.Size = new Size(35, 20);
            lbCor.TabIndex = 4;
            lbCor.Text = "Cor:";
            // 
            // lbPreco
            // 
            lbPreco.AutoSize = true;
            lbPreco.Location = new Point(388, 111);
            lbPreco.Name = "lbPreco";
            lbPreco.Size = new Size(49, 20);
            lbPreco.TabIndex = 5;
            lbPreco.Text = "Preço:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 153);
            label1.Name = "label1";
            label1.Size = new Size(147, 20);
            label1.TabIndex = 6;
            label1.Text = "Tipo de combustível:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Gasolina", "Flex", "Diesel", "Elétrico" });
            comboBox1.Location = new Point(216, 153);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 7;
            // 
            // FormCadastro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(lbPreco);
            Controls.Add(lbCor);
            Controls.Add(lbAnoFab);
            Controls.Add(lbModelo);
            Controls.Add(lbMarca);
            Controls.Add(lbPlaca);
            Name = "FormCadastro";
            Text = "FormCadastro";
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
        private Label label1;
        private ComboBox comboBox1;
    }
}