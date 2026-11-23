namespace cadastro_de_veiculos
{
    partial class FormListagem
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
            lbTitulo = new Label();
            dgvVeiculos = new DataGridView();
            lbTotal = new Label();
            btnAtualizar = new Button();
            btnFechar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvVeiculos).BeginInit();
            SuspendLayout();
            // 
            // lbTitulo
            // 
            lbTitulo.AutoSize = true;
            lbTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTitulo.Location = new Point(20, 15);
            lbTitulo.Name = "lbTitulo";
            lbTitulo.Size = new Size(207, 28);
            lbTitulo.TabIndex = 0;
            lbTitulo.Text = "Veículos Cadastrados";
            // 
            // dgvVeiculos
            // 
            dgvVeiculos.AllowUserToAddRows = false;
            dgvVeiculos.AllowUserToDeleteRows = false;
            dgvVeiculos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvVeiculos.BackgroundColor = SystemColors.Window;
            dgvVeiculos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVeiculos.Location = new Point(20, 55);
            dgvVeiculos.MultiSelect = false;
            dgvVeiculos.Name = "dgvVeiculos";
            dgvVeiculos.ReadOnly = true;
            dgvVeiculos.RowHeadersWidth = 51;
            dgvVeiculos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVeiculos.Size = new Size(740, 310);
            dgvVeiculos.TabIndex = 1;
            // 
            // lbTotal
            // 
            lbTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lbTotal.AutoSize = true;
            lbTotal.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbTotal.Location = new Point(20, 385);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new Size(134, 20);
            lbTotal.TabIndex = 2;
            lbTotal.Text = "Total de veículos: 0";
            // 
            // btnAtualizar
            // 
            btnAtualizar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAtualizar.Location = new Point(530, 380);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(110, 32);
            btnAtualizar.TabIndex = 3;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // btnFechar
            // 
            btnFechar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnFechar.Location = new Point(650, 380);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(110, 32);
            btnFechar.TabIndex = 4;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // FormListagem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 430);
            Controls.Add(btnFechar);
            Controls.Add(btnAtualizar);
            Controls.Add(lbTotal);
            Controls.Add(dgvVeiculos);
            Controls.Add(lbTitulo);
            Name = "FormListagem";
            Text = "Listagem de Veículos";
            Load += FormListagem_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVeiculos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTitulo;
        private DataGridView dgvVeiculos;
        private Label lbTotal;
        private Button btnAtualizar;
        private Button btnFechar;
    }
}

