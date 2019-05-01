namespace FrezzaFrete
{
    partial class frmPesquisarFrete
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
            this.btnPesquiar = new System.Windows.Forms.Button();
            this.btnMotorista = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.chbMotorista = new System.Windows.Forms.CheckBox();
            this.dgvFrete = new System.Windows.Forms.DataGridView();
            this.dtpFinal = new System.Windows.Forms.DateTimePicker();
            this.dtpInicial = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMotorista = new System.Windows.Forms.TextBox();
            this.cmbFiltro = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFrete)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPesquiar);
            this.groupBox1.Controls.Add(this.btnMotorista);
            this.groupBox1.Controls.Add(this.btnSair);
            this.groupBox1.Controls.Add(this.chbMotorista);
            this.groupBox1.Controls.Add(this.dgvFrete);
            this.groupBox1.Controls.Add(this.dtpFinal);
            this.groupBox1.Controls.Add(this.dtpInicial);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtMotorista);
            this.groupBox1.Controls.Add(this.cmbFiltro);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(778, 637);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisar";
            // 
            // btnPesquiar
            // 
            this.btnPesquiar.Location = new System.Drawing.Point(697, 23);
            this.btnPesquiar.Name = "btnPesquiar";
            this.btnPesquiar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquiar.TabIndex = 12;
            this.btnPesquiar.Text = "Pesquisar";
            this.btnPesquiar.UseVisualStyleBackColor = true;
            this.btnPesquiar.Click += new System.EventHandler(this.BtnPesquiar_Click);
            // 
            // btnMotorista
            // 
            this.btnMotorista.Location = new System.Drawing.Point(275, 26);
            this.btnMotorista.Name = "btnMotorista";
            this.btnMotorista.Size = new System.Drawing.Size(75, 23);
            this.btnMotorista.TabIndex = 11;
            this.btnMotorista.Text = "Motorista";
            this.btnMotorista.UseVisualStyleBackColor = true;
            this.btnMotorista.Click += new System.EventHandler(this.BtnMotorista_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(632, 580);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(138, 51);
            this.btnSair.TabIndex = 10;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // chbMotorista
            // 
            this.chbMotorista.AutoSize = true;
            this.chbMotorista.Location = new System.Drawing.Point(356, 31);
            this.chbMotorista.Name = "chbMotorista";
            this.chbMotorista.Size = new System.Drawing.Size(56, 17);
            this.chbMotorista.TabIndex = 9;
            this.chbMotorista.Text = "Todos";
            this.chbMotorista.UseVisualStyleBackColor = true;
            this.chbMotorista.CheckedChanged += new System.EventHandler(this.ChbMotorista_CheckedChanged);
            // 
            // dgvFrete
            // 
            this.dgvFrete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFrete.Location = new System.Drawing.Point(6, 58);
            this.dgvFrete.Name = "dgvFrete";
            this.dgvFrete.Size = new System.Drawing.Size(764, 516);
            this.dgvFrete.TabIndex = 6;
            this.dgvFrete.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFrete_CellDoubleClick);
            // 
            // dtpFinal
            // 
            this.dtpFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFinal.Location = new System.Drawing.Point(557, 26);
            this.dtpFinal.Name = "dtpFinal";
            this.dtpFinal.Size = new System.Drawing.Size(125, 20);
            this.dtpFinal.TabIndex = 5;
            this.dtpFinal.ValueChanged += new System.EventHandler(this.DtpFinal_ValueChanged);
            // 
            // dtpInicial
            // 
            this.dtpInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicial.Location = new System.Drawing.Point(427, 26);
            this.dtpInicial.Name = "dtpInicial";
            this.dtpInicial.Size = new System.Drawing.Size(124, 20);
            this.dtpInicial.TabIndex = 4;
            this.dtpInicial.ValueChanged += new System.EventHandler(this.DtpInicial_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(424, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Data Inicial";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(554, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Data Final";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // txtMotorista
            // 
            this.txtMotorista.Location = new System.Drawing.Point(6, 25);
            this.txtMotorista.Name = "txtMotorista";
            this.txtMotorista.ReadOnly = true;
            this.txtMotorista.Size = new System.Drawing.Size(263, 20);
            this.txtMotorista.TabIndex = 1;
            this.txtMotorista.TextChanged += new System.EventHandler(this.TxtMotorista_TextChanged);
            // 
            // cmbFiltro
            // 
            this.cmbFiltro.FormattingEnabled = true;
            this.cmbFiltro.Items.AddRange(new object[] {
            "Motorista"});
            this.cmbFiltro.Location = new System.Drawing.Point(118, 279);
            this.cmbFiltro.Name = "cmbFiltro";
            this.cmbFiltro.Size = new System.Drawing.Size(138, 21);
            this.cmbFiltro.TabIndex = 0;
            this.cmbFiltro.Text = "Motorista";
            // 
            // frmPesquisarFrete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 661);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmPesquisarFrete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisar Frete";
            this.Load += new System.EventHandler(this.frmPesquisarFrete_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFrete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvFrete;
        private System.Windows.Forms.DateTimePicker dtpFinal;
        private System.Windows.Forms.DateTimePicker dtpInicial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMotorista;
        private System.Windows.Forms.ComboBox cmbFiltro;
        private System.Windows.Forms.CheckBox chbMotorista;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnPesquiar;
        private System.Windows.Forms.Button btnMotorista;
    }
}