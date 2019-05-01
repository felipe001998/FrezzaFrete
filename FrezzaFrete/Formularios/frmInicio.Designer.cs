namespace FrezzaFrete
{
    partial class fmrInicio
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnGerarRelatorio = new System.Windows.Forms.Button();
            this.btnEditarViagem = new System.Windows.Forms.Button();
            this.btnEditarMotorista = new System.Windows.Forms.Button();
            this.btnEditarFrete = new System.Windows.Forms.Button();
            this.btnLancarFrete = new System.Windows.Forms.Button();
            this.btnCadastrarViagem = new System.Windows.Forms.Button();
            this.btnCadastrarMotorista = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSair);
            this.groupBox1.Controls.Add(this.btnGerarRelatorio);
            this.groupBox1.Controls.Add(this.btnEditarViagem);
            this.groupBox1.Controls.Add(this.btnEditarMotorista);
            this.groupBox1.Controls.Add(this.btnEditarFrete);
            this.groupBox1.Controls.Add(this.btnLancarFrete);
            this.groupBox1.Controls.Add(this.btnCadastrarViagem);
            this.groupBox1.Controls.Add(this.btnCadastrarMotorista);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 218);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inicio";
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(241, 150);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(105, 55);
            this.btnSair.TabIndex = 8;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // btnGerarRelatorio
            // 
            this.btnGerarRelatorio.Location = new System.Drawing.Point(19, 150);
            this.btnGerarRelatorio.Name = "btnGerarRelatorio";
            this.btnGerarRelatorio.Size = new System.Drawing.Size(105, 55);
            this.btnGerarRelatorio.TabIndex = 7;
            this.btnGerarRelatorio.Text = "Gerar Relatorio";
            this.btnGerarRelatorio.UseVisualStyleBackColor = true;
            this.btnGerarRelatorio.Click += new System.EventHandler(this.BtnGerarRelatorio_Click);
            // 
            // btnEditarViagem
            // 
            this.btnEditarViagem.Location = new System.Drawing.Point(130, 89);
            this.btnEditarViagem.Name = "btnEditarViagem";
            this.btnEditarViagem.Size = new System.Drawing.Size(105, 55);
            this.btnEditarViagem.TabIndex = 6;
            this.btnEditarViagem.Text = "Editar/Deletar Viagem";
            this.btnEditarViagem.UseVisualStyleBackColor = true;
            this.btnEditarViagem.Click += new System.EventHandler(this.btnEditarViagem_Click);
            // 
            // btnEditarMotorista
            // 
            this.btnEditarMotorista.Location = new System.Drawing.Point(19, 89);
            this.btnEditarMotorista.Name = "btnEditarMotorista";
            this.btnEditarMotorista.Size = new System.Drawing.Size(105, 55);
            this.btnEditarMotorista.TabIndex = 5;
            this.btnEditarMotorista.Text = "Editar/Deletar Motorista";
            this.btnEditarMotorista.UseVisualStyleBackColor = true;
            this.btnEditarMotorista.Click += new System.EventHandler(this.btnEditarMotorista_Click);
            // 
            // btnEditarFrete
            // 
            this.btnEditarFrete.Location = new System.Drawing.Point(241, 89);
            this.btnEditarFrete.Name = "btnEditarFrete";
            this.btnEditarFrete.Size = new System.Drawing.Size(105, 55);
            this.btnEditarFrete.TabIndex = 4;
            this.btnEditarFrete.Text = "Editar/Deletar Frete";
            this.btnEditarFrete.UseVisualStyleBackColor = true;
            this.btnEditarFrete.Click += new System.EventHandler(this.btnEditarFrete_Click);
            // 
            // btnLancarFrete
            // 
            this.btnLancarFrete.Location = new System.Drawing.Point(241, 28);
            this.btnLancarFrete.Name = "btnLancarFrete";
            this.btnLancarFrete.Size = new System.Drawing.Size(105, 55);
            this.btnLancarFrete.TabIndex = 3;
            this.btnLancarFrete.Text = "Lançar Frete";
            this.btnLancarFrete.UseVisualStyleBackColor = true;
            this.btnLancarFrete.Click += new System.EventHandler(this.btnLancarFrete_Click);
            // 
            // btnCadastrarViagem
            // 
            this.btnCadastrarViagem.Location = new System.Drawing.Point(130, 28);
            this.btnCadastrarViagem.Name = "btnCadastrarViagem";
            this.btnCadastrarViagem.Size = new System.Drawing.Size(105, 55);
            this.btnCadastrarViagem.TabIndex = 2;
            this.btnCadastrarViagem.Text = "Cadastrar Viagem";
            this.btnCadastrarViagem.UseVisualStyleBackColor = true;
            this.btnCadastrarViagem.Click += new System.EventHandler(this.btnCadastrarViagem_Click);
            // 
            // btnCadastrarMotorista
            // 
            this.btnCadastrarMotorista.Location = new System.Drawing.Point(19, 28);
            this.btnCadastrarMotorista.Name = "btnCadastrarMotorista";
            this.btnCadastrarMotorista.Size = new System.Drawing.Size(105, 55);
            this.btnCadastrarMotorista.TabIndex = 1;
            this.btnCadastrarMotorista.Text = "Cadastrar Motorista";
            this.btnCadastrarMotorista.UseVisualStyleBackColor = true;
            this.btnCadastrarMotorista.Click += new System.EventHandler(this.btnCadastrarMotorista_Click);
            // 
            // fmrInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 234);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Name = "fmrInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calcular Frete";
            this.Load += new System.EventHandler(this.fmrInicio_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCadastrarMotorista;
        private System.Windows.Forms.Button btnCadastrarViagem;
        private System.Windows.Forms.Button btnLancarFrete;
        private System.Windows.Forms.Button btnEditarViagem;
        private System.Windows.Forms.Button btnEditarMotorista;
        private System.Windows.Forms.Button btnEditarFrete;
        private System.Windows.Forms.Button btnGerarRelatorio;
        private System.Windows.Forms.Button btnSair;
    }
}

