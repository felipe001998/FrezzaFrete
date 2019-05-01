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
    public partial class frmPesquisarMotoristacs : Form
    {
        public static string Funcao { get; set; }

        public frmPesquisarMotoristacs()
        {
            InitializeComponent();
        }

        private void frmPesquisarMotoristacs_Load(object sender, EventArgs e)
        {
            Pesquisar();
        }
        public void Pesquisar()
        {
            //carrega o datagridview com os clientes cadastrados
            clMotorista clMotorista = new clMotorista();
            clMotorista.banco = Properties.Settings.Default.conexaoDB;
            dgvMoto.DataSource = clMotorista.Pesquisar2().Tables[0];
            //comando utilizado pra gerar um efeito "zebrado" no datagridview
            dgvMoto.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

        }

        private void dgvMoto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
            //verifica se existe itens na grid
            if (dgvMoto.RowCount == 0)
            {
                return;
            }
            //carrega a tela com todos os dados do cliente
            OleDbDataReader drReader;
            clMotorista clMotorista = new clMotorista();
            
            clMotorista.banco = Properties.Settings.Default.conexaoDB;
            drReader = clMotorista.PesquisarCodigo(Convert.ToInt32(dgvMoto.CurrentRow.Cells[0].Value));
            if (Funcao == "inicio")
            {
                if (drReader.Read())
                {
                    frmCadastrarMotorista frmCadastrarMotorista = new frmCadastrarMotorista();

                    frmCadastrarMotorista.nome = drReader["Nome"].ToString();
                    frmCadastrarMotorista.idMotorista = drReader["idMotorista"].ToString();
                    frmCadastrarMotorista.cnh = drReader["CNH"].ToString();
                    frmCadastrarMotorista.telefone = drReader["Telefone"].ToString();
                    drReader.Close();
                    new frmCadastrarMotorista().Show();
                    this.Close();
                }
            }
            if (Funcao == "lancar")
            {
                if (drReader.Read())
                {
                    frmLancarFrete frmLancarFrete = new frmLancarFrete();
                    frmLancarFrete.nome = drReader["Nome"].ToString();
                    frmLancarFrete.idMotorista = drReader["idMotorista"].ToString();
                    drReader.Close();
                    new frmLancarFrete().Show();
                    this.Close();
                }
            }
            if (Funcao == "editar")
            {
                if (drReader.Read())
                {
                    frmPesquisarFrete frmPesquisarFrete = new frmPesquisarFrete();
                    frmPesquisarFrete.nome = drReader["Nome"].ToString();
                    frmPesquisarFrete.idMotorista = drReader["idMotorista"].ToString();
                    drReader.Close();
                    new frmPesquisarFrete().Show();
                    this.Close();
                }
            }
            if (Funcao == "relatorio")
            {
                if (drReader.Read())
                {
                    frmGerarRel frmGerarRel = new frmGerarRel();
                    frmGerarRel.nome = drReader["Nome"].ToString();
                    frmGerarRel.idMotorista = drReader["idMotorista"].ToString();
                    drReader.Close();
                    new frmGerarRel().Show();
                    this.Close();
                }
            }

        }

        private void DgvMoto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
