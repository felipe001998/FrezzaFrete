namespace FrezzaFrete
{
    partial class frmLancarFrete
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
            this.btnDeletar = new System.Windows.Forms.Button();
            this.mskTotalFrete = new System.Windows.Forms.MaskedTextBox();
            this.mskComissao = new System.Windows.Forms.MaskedTextBox();
            this.txtMotorista = new System.Windows.Forms.TextBox();
            this.txtRemetente = new System.Windows.Forms.TextBox();
            this.txtDestinatario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnCalcularComissao = new System.Windows.Forms.Button();
            this.mskCarreta = new System.Windows.Forms.MaskedTextBox();
            this.lblPLacaCarreta = new System.Windows.Forms.Label();
            this.mskCavalo = new System.Windows.Forms.MaskedTextBox();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.txtNF = new System.Windows.Forms.TextBox();
            this.txtVolume = new System.Windows.Forms.TextBox();
            this.txtVale = new System.Windows.Forms.TextBox();
            this.btnBuscarViagem = new System.Windows.Forms.Button();
            this.btnPesquisarMotorista = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblPlacaCavalo = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblVolume = new System.Windows.Forms.Label();
            this.lblVale = new System.Windows.Forms.Label();
            this.lblMotorista = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDeletar);
            this.groupBox1.Controls.Add(this.mskTotalFrete);
            this.groupBox1.Controls.Add(this.mskComissao);
            this.groupBox1.Controls.Add(this.txtMotorista);
            this.groupBox1.Controls.Add(this.txtRemetente);
            this.groupBox1.Controls.Add(this.txtDestinatario);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnSalvar);
            this.groupBox1.Controls.Add(this.btnSair);
            this.groupBox1.Controls.Add(this.btnCalcularComissao);
            this.groupBox1.Controls.Add(this.mskCarreta);
            this.groupBox1.Controls.Add(this.lblPLacaCarreta);
            this.groupBox1.Controls.Add(this.mskCavalo);
            this.groupBox1.Controls.Add(this.dtpData);
            this.groupBox1.Controls.Add(this.txtNF);
            this.groupBox1.Controls.Add(this.txtVolume);
            this.groupBox1.Controls.Add(this.txtVale);
            this.groupBox1.Controls.Add(this.btnBuscarViagem);
            this.groupBox1.Controls.Add(this.btnPesquisarMotorista);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lblPlacaCavalo);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblVolume);
            this.groupBox1.Controls.Add(this.lblVale);
            this.groupBox1.Controls.Add(this.lblMotorista);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(743, 206);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lançar Frete";
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(532, 110);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(92, 35);
            this.btnDeletar.TabIndex = 38;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // mskTotalFrete
            // 
            this.mskTotalFrete.Location = new System.Drawing.Point(266, 165);
            this.mskTotalFrete.Mask = "$ 9.999.00";
            this.mskTotalFrete.Name = "mskTotalFrete";
            this.mskTotalFrete.Size = new System.Drawing.Size(100, 20);
            this.mskTotalFrete.TabIndex = 37;
            // 
            // mskComissao
            // 
            this.mskComissao.Location = new System.Drawing.Point(381, 166);
            this.mskComissao.Mask = "$ 99.00";
            this.mskComissao.Name = "mskComissao";
            this.mskComissao.Size = new System.Drawing.Size(100, 20);
            this.mskComissao.TabIndex = 36;
            // 
            // txtMotorista
            // 
            this.txtMotorista.Enabled = false;
            this.txtMotorista.Location = new System.Drawing.Point(19, 44);
            this.txtMotorista.Name = "txtMotorista";
            this.txtMotorista.ReadOnly = true;
            this.txtMotorista.Size = new System.Drawing.Size(154, 20);
            this.txtMotorista.TabIndex = 34;
            // 
            // txtRemetente
            // 
            this.txtRemetente.Enabled = false;
            this.txtRemetente.Location = new System.Drawing.Point(266, 44);
            this.txtRemetente.Name = "txtRemetente";
            this.txtRemetente.ReadOnly = true;
            this.txtRemetente.Size = new System.Drawing.Size(175, 20);
            this.txtRemetente.TabIndex = 33;
            // 
            // txtDestinatario
            // 
            this.txtDestinatario.Enabled = false;
            this.txtDestinatario.Location = new System.Drawing.Point(450, 47);
            this.txtDestinatario.Name = "txtDestinatario";
            this.txtDestinatario.ReadOnly = true;
            this.txtDestinatario.Size = new System.Drawing.Size(174, 20);
            this.txtDestinatario.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Remetente *";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(447, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Destinatario *";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(532, 151);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(92, 35);
            this.btnSalvar.TabIndex = 8;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(630, 150);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(92, 35);
            this.btnSair.TabIndex = 9;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnCalcularComissao
            // 
            this.btnCalcularComissao.Location = new System.Drawing.Point(134, 160);
            this.btnCalcularComissao.Name = "btnCalcularComissao";
            this.btnCalcularComissao.Size = new System.Drawing.Size(114, 25);
            this.btnCalcularComissao.TabIndex = 7;
            this.btnCalcularComissao.Text = "Calcular comissão";
            this.btnCalcularComissao.UseVisualStyleBackColor = true;
            this.btnCalcularComissao.Click += new System.EventHandler(this.btnCalcularComissao_Click);
            // 
            // mskCarreta
            // 
            this.mskCarreta.Location = new System.Drawing.Point(134, 102);
            this.mskCarreta.Mask = "AAA-0000";
            this.mskCarreta.Name = "mskCarreta";
            this.mskCarreta.Size = new System.Drawing.Size(100, 20);
            this.mskCarreta.TabIndex = 3;
            // 
            // lblPLacaCarreta
            // 
            this.lblPLacaCarreta.AutoSize = true;
            this.lblPLacaCarreta.Location = new System.Drawing.Point(131, 86);
            this.lblPLacaCarreta.Name = "lblPLacaCarreta";
            this.lblPLacaCarreta.Size = new System.Drawing.Size(71, 13);
            this.lblPLacaCarreta.TabIndex = 20;
            this.lblPLacaCarreta.Text = "Placa Carreta";
            // 
            // mskCavalo
            // 
            this.mskCavalo.Location = new System.Drawing.Point(19, 102);
            this.mskCavalo.Mask = "AAA-0000";
            this.mskCavalo.Name = "mskCavalo";
            this.mskCavalo.Size = new System.Drawing.Size(100, 20);
            this.mskCavalo.TabIndex = 2;
            // 
            // dtpData
            // 
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(386, 102);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(103, 20);
            this.dtpData.TabIndex = 9;
            // 
            // txtNF
            // 
            this.txtNF.Location = new System.Drawing.Point(313, 102);
            this.txtNF.Name = "txtNF";
            this.txtNF.Size = new System.Drawing.Size(67, 20);
            this.txtNF.TabIndex = 5;
            // 
            // txtVolume
            // 
            this.txtVolume.Location = new System.Drawing.Point(19, 165);
            this.txtVolume.Name = "txtVolume";
            this.txtVolume.Size = new System.Drawing.Size(100, 20);
            this.txtVolume.TabIndex = 6;
            this.txtVolume.TextChanged += new System.EventHandler(this.txtVolume_TextChanged);
            this.txtVolume.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVolume_KeyPress);
            // 
            // txtVale
            // 
            this.txtVale.Location = new System.Drawing.Point(240, 102);
            this.txtVale.Name = "txtVale";
            this.txtVale.Size = new System.Drawing.Size(67, 20);
            this.txtVale.TabIndex = 4;
            // 
            // btnBuscarViagem
            // 
            this.btnBuscarViagem.Location = new System.Drawing.Point(639, 46);
            this.btnBuscarViagem.Name = "btnBuscarViagem";
            this.btnBuscarViagem.Size = new System.Drawing.Size(84, 23);
            this.btnBuscarViagem.TabIndex = 1;
            this.btnBuscarViagem.Text = "Viagem";
            this.btnBuscarViagem.UseVisualStyleBackColor = true;
            this.btnBuscarViagem.Click += new System.EventHandler(this.btnBuscarViagem_Click);
            // 
            // btnPesquisarMotorista
            // 
            this.btnPesquisarMotorista.Location = new System.Drawing.Point(190, 44);
            this.btnPesquisarMotorista.Name = "btnPesquisarMotorista";
            this.btnPesquisarMotorista.Size = new System.Drawing.Size(58, 23);
            this.btnPesquisarMotorista.TabIndex = 0;
            this.btnPesquisarMotorista.Text = "Motorista";
            this.btnPesquisarMotorista.UseVisualStyleBackColor = true;
            this.btnPesquisarMotorista.Click += new System.EventHandler(this.btnPesquisarMotorista_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(263, 150);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Frete Total";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(378, 150);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Valor da Comissão";
            // 
            // lblPlacaCavalo
            // 
            this.lblPlacaCavalo.AutoSize = true;
            this.lblPlacaCavalo.Location = new System.Drawing.Point(16, 86);
            this.lblPlacaCavalo.Name = "lblPlacaCavalo";
            this.lblPlacaCavalo.Size = new System.Drawing.Size(70, 13);
            this.lblPlacaCavalo.TabIndex = 7;
            this.lblPlacaCavalo.Text = "Placa Cavalo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(383, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Data";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(313, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "NF";
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Location = new System.Drawing.Point(16, 150);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(49, 13);
            this.lblVolume.TabIndex = 4;
            this.lblVolume.Text = "Volume *";
            // 
            // lblVale
            // 
            this.lblVale.AutoSize = true;
            this.lblVale.Location = new System.Drawing.Point(240, 89);
            this.lblVale.Name = "lblVale";
            this.lblVale.Size = new System.Drawing.Size(43, 13);
            this.lblVale.TabIndex = 3;
            this.lblVale.Text = "Nº Vale";
            // 
            // lblMotorista
            // 
            this.lblMotorista.AutoSize = true;
            this.lblMotorista.Location = new System.Drawing.Point(16, 29);
            this.lblMotorista.Name = "lblMotorista";
            this.lblMotorista.Size = new System.Drawing.Size(57, 13);
            this.lblMotorista.TabIndex = 0;
            this.lblMotorista.Text = "Motorista *";
            // 
            // frmLancarFrete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 227);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Name = "frmLancarFrete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lançar Frete";
            this.Load += new System.EventHandler(this.frmLancarFrete_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnCalcularComissao;
        private System.Windows.Forms.MaskedTextBox mskCarreta;
        private System.Windows.Forms.Label lblPLacaCarreta;
        private System.Windows.Forms.MaskedTextBox mskCavalo;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.TextBox txtNF;
        private System.Windows.Forms.TextBox txtVolume;
        private System.Windows.Forms.TextBox txtVale;
        private System.Windows.Forms.Button btnBuscarViagem;
        private System.Windows.Forms.Button btnPesquisarMotorista;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblPlacaCavalo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.Label lblVale;
        private System.Windows.Forms.Label lblMotorista;
        private System.Windows.Forms.TextBox txtRemetente;
        private System.Windows.Forms.TextBox txtDestinatario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMotorista;
        private System.Windows.Forms.MaskedTextBox mskComissao;
        private System.Windows.Forms.MaskedTextBox mskTotalFrete;
        private System.Windows.Forms.Button btnDeletar;
    }
}