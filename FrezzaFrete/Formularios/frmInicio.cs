using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrezzaFrete
{
    public partial class fmrInicio : Form
    {
        public fmrInicio()
        {
            InitializeComponent();
        }

        private void btnCadastrarMotorista_Click(object sender, EventArgs e)
        {
            new frmCadastrarMotorista().Show();
            this.Hide();
        }

        private void fmrInicio_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrarViagem_Click(object sender, EventArgs e)
        {
            new frmCadastrarViagem().Show();
            this.Hide();
        }

        private void btnLancarFrete_Click(object sender, EventArgs e)
        {
            new frmLancarFrete().Show();
            this.Hide();
        }

        private void btnEditarMotorista_Click(object sender, EventArgs e)
        {
            frmPesquisarMotoristacs frmPesquisarMotoristacs = new frmPesquisarMotoristacs();
            frmPesquisarMotoristacs.Funcao = "inicio";
            new frmPesquisarMotoristacs().Show();
            this.Hide();
        }

        private void btnEditarViagem_Click(object sender, EventArgs e)
        {
            frmPesquisarMotorista frmPesquisarMotorista = new frmPesquisarMotorista();
            frmPesquisarMotorista.Funcao = "inicio";
            new frmPesquisarMotorista().Show();
            this.Hide();
        }

        private void btnEditarFrete_Click(object sender, EventArgs e)
        {
            frmPesquisarFrete frmPesquisarFrete = new frmPesquisarFrete();
            frmPesquisarFrete.Funcao = "inicio";
            new frmPesquisarFrete().Show();
            this.Hide();
        }

        private void BtnGerarRelatorio_Click(object sender, EventArgs e)
        {
            frmGerarRel frmGerar = new frmGerarRel();
            new frmGerarRel().Show();
            this.Hide();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
