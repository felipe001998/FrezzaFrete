using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace FrezzaFrete
{
    public partial class frmPesquisarMotorista : Form
    {
        public static string Funcao { get; set; }

        public frmPesquisarMotorista()
        {
            InitializeComponent();
        }

        private void frmPesquisarViagem_Load(object sender, EventArgs e)
        {
            Pesquisar();
        }
        public void Pesquisar()
        {
            //carrega o datagridview com os clientes cadastrados
            clViagem clViagem = new clViagem();
            clViagem.banco = Properties.Settings.Default.conexaoDB;
            dgvViagem.DataSource = clViagem.Pesquisar2().Tables[0];
            //comando utilizado pra gerar um efeito "zebrado" no datagridview
            dgvViagem.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

        }

        private void dgvViagem_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            //verifica se existe itens na grid
            if (dgvViagem.RowCount == 0)
            {
                return;
            }
            //carrega a tela com todos os dados do cliente
            OleDbDataReader drReader;
            clViagem clViagem = new clViagem();
            
            clViagem.banco = Properties.Settings.Default.conexaoDB;
            drReader = clViagem.PesquisarCodigo(Convert.ToInt32(dgvViagem.CurrentRow.Cells[0].Value));

            if (Funcao =="inicio")
            {
                if (drReader.Read())
                {
                    frmCadastrarViagem frmCadastrar = new frmCadastrarViagem();
                    frmCadastrarViagem.remetente = drReader["Remetente"].ToString();
                    frmCadastrarViagem.destinatario = drReader["Destinatario"].ToString();
                    frmCadastrarViagem.valorfrete = drReader["ValorFrete"].ToString();
                    frmCadastrarViagem.idViagem = drReader["idViagem"].ToString();
                    drReader.Close();
                    new frmCadastrarViagem().Show();
                    this.Close();
                }
            }
            else
            {
                if (drReader.Read())
                {
                    frmLancarFrete frmLancarFrete = new frmLancarFrete();
                    frmLancarFrete.remetente = drReader["Remetente"].ToString();
                    frmLancarFrete.destinatario = drReader["Destinatario"].ToString();
                    frmLancarFrete.valorfrete = drReader["ValorFrete"].ToString();
                    frmLancarFrete.idViagem = drReader["idViagem"].ToString();
                    drReader.Close();
                    new frmLancarFrete().Show();
                    this.Close();
                }
            }
            
        }

        private void dgvViagem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
