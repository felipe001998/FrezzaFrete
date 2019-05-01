using iTextSharp.text;
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
using iTextSharp.text.pdf;
using System.IO;
using System.Diagnostics;
using System.Threading;

namespace FrezzaFrete
{
    public partial class frmGerarRel : Form
    {
        public static string nome { get; set; }
        public static string idMotorista { get; set; }
        public frmGerarRel()
        {
            InitializeComponent();
        }

        private void BtnMotorista_Click(object sender, EventArgs e)
        {
            frmPesquisarMotoristacs frmPesquisarMotoristacs = new frmPesquisarMotoristacs();
            frmPesquisarMotoristacs.Funcao = "relatorio";
            new frmPesquisarMotoristacs().Show();
            this.Close();
        }

        private void FrmGerarRel_Load(object sender, EventArgs e)
        {
            txtMotorista.Text = nome;
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            new fmrInicio().Show();
            this.Close();
        }
        public void pdfRel()
        {
            Paragraph p = new Paragraph();
            double c = 0;
            Document doc = new Document(PageSize.A4);//criando e estipulando o tipo da folha usada
            doc.SetPageSize(PageSize.A4.Rotate());
            doc.SetMargins(40, 40, 40, 40);//estibulando o espaçamento das margens que queremos
            doc.AddCreationDate();//adicionando as configuracoes
            var write = PdfWriter.GetInstance(doc, new FileStream(@"C:\FrezzaFrete\rel.pdf", FileMode.Create));

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

            float[] wid = new float[] { 40f, 20f };

            table2.SetWidths(wid);

            table2.HorizontalAlignment = 0;


            valor.Colspan = 2;

            table2.AddCell(valor);
            table2.AddCell("Total da Comissão:");
            table2.AddCell(Convert.ToString(c));


            doc.Add(table);
            doc.Add(table2);
            doc.Close();
            printPDFWithAcrobat();

        }

        private void BtnGerarRel_Click(object sender, EventArgs e)
        {
            if (txtMotorista.Text == "")
            {
                MessageBox.Show("Selecione o Motorista", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            pdfRel();
        }
        // string Filepath = @"C:\teste\teste.pdf";
        public void printPDFWithAcrobat()
        {
            ProcessStartInfo info = new ProcessStartInfo();
            info.Verb = "print";
            info.FileName = @"C:\FrezzaFrete\rel.pdf";
            info.CreateNoWindow = true;
            info.WindowStyle = ProcessWindowStyle.Hidden;

            Process p = new Process();
            p.StartInfo = info;
            p.Start();

            p.WaitForInputIdle();
            System.Threading.Thread.Sleep(3000);
            if (false == p.CloseMainWindow())
                p.Kill();
        }
    }
}
