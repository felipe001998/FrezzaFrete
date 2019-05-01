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
using System.IO;// A BIBLIOTECA DE ENTRADA E SAIDA DE ARQUIVOS
using iTextSharp;//E A BIBLIOTECA ITEXTSHARP E SUAS EXTENÇÕES
using iTextSharp.text;//ESTENSAO 1 (TEXT)
using iTextSharp.text.pdf;//ESTENSAO 2 (PDF)

namespace FrezzaFrete
{
    public partial class frmPesquisarFrete : Form
    {
        public static string nome { get; set; }
        public static string idMotorista { get; set; }
        public static string Funcao { get; set; }

        public frmPesquisarFrete()
        {
            InitializeComponent();
        }
        public void pdfRel()
        {
            Paragraph p = new Paragraph();
            double c = 0;
            Document doc = new Document(PageSize.A4);//criando e estipulando o tipo da folha usada
            doc.SetPageSize(PageSize.A4.Rotate());
            doc.SetMargins(40, 40, 40, 40);//estibulando o espaçamento das margens que queremos
            doc.AddCreationDate();//adicionando as configuracoes
            var write = PdfWriter.GetInstance(doc, new FileStream(@"c:\teste\teste.pdf", FileMode.Create));

            doc.Open();

            PdfPTable table = new PdfPTable(8);

            PdfPCell header = new PdfPCell();

            float[] widths = new float[] { 90f, 110f, 110f, 90f, 90f, 90f, 90f, 90f };

            table.SetWidths(widths);

            table.HorizontalAlignment = 0;

            header.Colspan = 8;

            table.AddCell(header);
            table.AddCell("Motorista");
            table.AddCell("Remetente");
            table.AddCell("Destinatario");
            table.AddCell("Data");
            table.AddCell("Volume");
            table.AddCell("Comissão");
            table.AddCell("Placa carreta");
            table.AddCell("Placa Cavalo");

            OleDbDataReader drReader;
 
            clFrete clFrete = new clFrete();
            clFrete.banco = Properties.Settings.Default.conexaoDB;
            drReader = clFrete.RelMoto(dtpInicial.Text, dtpFinal.Text, idMotorista);
            while (drReader.Read())
            {

                table.AddCell(new Paragraph(drReader["Nome"].ToString()));
                table.AddCell(new Paragraph(drReader["Remetente"].ToString()));
                table.AddCell(new Paragraph(drReader["Destinatario"].ToString()));
                table.AddCell(new Paragraph(drReader["Data"].ToString()));
                table.AddCell(new Paragraph(drReader["Volume"].ToString()));
                table.AddCell(new Paragraph(drReader["TotalComissao"].ToString()));
                table.AddCell(new Paragraph(drReader["PlacaCarreta"].ToString()));
                table.AddCell(new Paragraph(drReader["PlacaCavalo"].ToString()));

                string comissao = drReader["TotalComissao"].ToString();
                double comissaovalor = Convert.ToDouble(comissao);
                c = comissaovalor + c;

            }

            PdfPTable table2 = new PdfPTable(2);
            PdfPCell valor = new PdfPCell();

            float[] wid = new float[] { 40f, 20f};

            table2.SetWidths(wid);

            table2.HorizontalAlignment = 0;


            valor.Colspan = 2;

            table2.AddCell(valor);
            table2.AddCell("Total da Comissão:");
            table2.AddCell(Convert.ToString(c));


            doc.Add(table);
            doc.Add(table2);
            doc.Close();

        }

        private void frmPesquisarFrete_Load(object sender, EventArgs e)
        {
            if (nome == "")
            {
                nome = null;
            }
            txtMotorista.Text = nome;
        }
        public void PesquisarLoad()
        {
            //dtpFinal.Value = DateTime.Now;
            //dtpInicial.Value = dtpFinal.Value.AddDays(-60);
            //carrega o datagridview com os clientes cadastrados
            clFrete clFrete = new clFrete();
            clFrete.banco = Properties.Settings.Default.conexaoDB;
            dgvFrete.DataSource = clFrete.PesquisaLoad(dtpInicial.Text, dtpFinal.Text).Tables[0];
            //comando utilizado pra gerar um efeito "zebrado" no datagridview
            dgvFrete.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
        }
        public void PesquisarMoto()
        {
            //dtpFinal.Value = DateTime.Now;
            //dtpInicial.Value = dtpFinal.Value.AddDays(-60);
            //carrega o datagridview com os clientes cadastrados
            clFrete clFrete = new clFrete();
            clFrete.banco = Properties.Settings.Default.conexaoDB;
            dgvFrete.DataSource = clFrete.PesquisaMoto(dtpInicial.Text, dtpFinal.Text, idMotorista).Tables[0];
            //comando utilizado pra gerar um efeito "zebrado" no datagridview
            dgvFrete.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
        }
        public void PesquisarData()
        {
            //carrega o datagridview com os clientes cadastrados
            clFrete clFrete = new clFrete();
            clFrete.banco = Properties.Settings.Default.conexaoDB;
            dgvFrete.DataSource = clFrete.PesquisaLoad(dtpFinal.Text, dtpInicial.Text).Tables[0];
            //comando utilizado pra gerar um efeito "zebrado" no datagridview
            dgvFrete.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
        }


        private void dgvFrete_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //verifica se existe itens na grid
            if (dgvFrete.RowCount == 0)
            {
                return;
            }
            //carrega a tela com todos os dados do cliente
            OleDbDataReader drReader;
            clFrete clFrete = new clFrete();

            clFrete.banco = Properties.Settings.Default.conexaoDB;
            drReader = clFrete.PesquisarDGVClick(Convert.ToInt32(dgvFrete.CurrentRow.Cells[8].Value));
            if (Funcao == "inicio")
            {
                if (drReader.Read())
                {
                    frmLancarFrete frmLancar = new frmLancarFrete();

                    frmLancarFrete.nome = drReader["Nome"].ToString();
                    frmLancarFrete.idMotorista = drReader["idMotorista"].ToString();
                    frmLancarFrete.idViagem = drReader["idViagem"].ToString();
                    frmLancarFrete.idFrete = drReader["idFrete"].ToString();
                    frmLancarFrete.Vale = drReader["Vale"].ToString();
                    frmLancarFrete.Volume = drReader["Volume"].ToString();
                    frmLancarFrete.Data = drReader["Data"].ToString();
                    frmLancarFrete.TotalComissao = drReader["TotalComissao"].ToString();
                    frmLancarFrete.NF = drReader["NF"].ToString();
                    frmLancarFrete.FreteTotal = drReader["FreteTotal"].ToString();
                    frmLancarFrete.PCarreta = drReader["PlacaCarreta"].ToString();
                    frmLancarFrete.PCavalo = drReader["PlacaCavalo"].ToString();
                    frmLancarFrete.remetente = drReader["Remetente"].ToString();
                    frmLancarFrete.destinatario = drReader["Destinatario"].ToString();
                    frmLancarFrete.valorfrete = drReader["ValorFrete"].ToString();
                    frmLancarFrete.nome = drReader["Nome"].ToString();
                    frmLancarFrete.Funcao = "Alterar";
                    drReader.Close();
                    new frmLancarFrete().Show();
                    this.Close();
                }
            }
            else
            {
                /*if (drReader.Read())
                {
                    frmLancarFrete frmLancarFrete = new frmLancarFrete();
                    frmLancarFrete.nome = drReader["Nome"].ToString();
                    frmLancarFrete.idMotorista = drReader["idMotorista"].ToString();
                    drReader.Close();
                    new frmLancarFrete().Show();
                    this.Close();
                }*/
            }
        }

        private void DtpFinal_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void DtpInicial_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void BtnPesquiar_Click(object sender, EventArgs e)
        {
            if (chbMotorista.Checked == true)
            {
                PesquisarLoad();
                return;
            }
            if (txtMotorista.Text != "")
            {
                PesquisarMoto();
                return;
            }
            if (txtMotorista.Text == null || chbMotorista.Checked == false)
            {
                MessageBox.Show("Selecione um ou todos Motoristas.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
        }

        private void BtnMotorista_Click(object sender, EventArgs e)
        {
            frmPesquisarMotoristacs frmPesquisarMotoristacs = new frmPesquisarMotoristacs();
            frmPesquisarMotoristacs.Funcao = "editar";
            new frmPesquisarMotoristacs().Show();
            this.Close();
        }

        private void ChbMotorista_CheckedChanged(object sender, EventArgs e)
        {
            if (chbMotorista.Checked == true)
            {
                nome =null;
                idMotorista = null;
                txtMotorista.Text = "";
                btnMotorista.Enabled = false;
            }
            if (chbMotorista.Checked == false)
            {
                btnMotorista.Enabled = true;
            }

        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            new fmrInicio().Show();
            this.Close();
        }

        private void BtnGerarRel_Click(object sender, EventArgs e)
        {
            pdfRel();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TxtMotorista_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
