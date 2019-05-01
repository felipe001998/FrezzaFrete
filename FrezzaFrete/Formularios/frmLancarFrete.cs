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
    public partial class frmLancarFrete : Form
    {
        public static string Funcao { get; set; }
        public static string remetente { get; set; }
        public static string destinatario { get; set; }
        public static string valorfrete { get; set; }
        public static string nome { get; set; }
        public static string idMotorista { get; set; }
        public static string idViagem { get; set; }
        public static string idFrete { get; set; }
        public static string PCavalo { get; set; }
        public static string PCarreta { get; set; }
        public static string Vale { get; set; }
        public static string Volume { get; set; }
        public static string Data { get; set; }
        public static string TotalComissao { get; set; }
        public static string NF { get; set; }
        public static string FreteTotal { get; set; }


        public frmLancarFrete()
        {
            InitializeComponent();
        }
        

        private void btnBuscarViagem_Click(object sender, EventArgs e)
        {
            new frmPesquisarMotorista().Show();
            this.Hide();
        }

        private void frmLancarFrete_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'dBFreteDataSet.tbFrete' table. You can move, or remove it, as needed.

            //string frete = valorfrete;
            txtRemetente.Text = remetente;
            txtDestinatario.Text = destinatario;
            txtMotorista.Text = nome;
            txtNF.Text = NF;
            txtVale.Text = Vale;
            txtVolume.Text = Volume;
            mskCarreta.Text = PCarreta;
            mskCavalo.Text = PCavalo;
            mskComissao.Text = TotalComissao;
            mskTotalFrete.Text = FreteTotal;
            dtpData.Text = Data;

           // int corrida = Convert.ToInt32.(VL);

        }
       

        private void btnPesquisarMotorista_Click(object sender, EventArgs e)
        {
            frmPesquisarMotoristacs frmPesquisarMotoristacs = new frmPesquisarMotoristacs();
            frmPesquisarMotoristacs.Funcao = "lancar";
            new frmPesquisarMotoristacs().Show();
            this.Hide();
        }

        private void cbmMotorista_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*DataRowView drv = (DataRowView)cbmMotorista.SelectedItem;
            string a = drv.Row["Nome"].ToString();  // ou codLoja
            global.usuario.loja = a.Trim();*/
        }

        private void btnCalcularComissao_Click(object sender, EventArgs e)
        {
            double frete = Convert.ToDouble(valorfrete);
            double volume = Convert.ToDouble(txtVolume.Text);
            double valorviagem = 0;
            double totalcomissao = 0;
            valorviagem = frete * volume;
            totalcomissao = valorviagem * 5 / 100;            
            mskComissao.Text = Convert.ToString(totalcomissao);
            if (valorviagem < 1000)
            {
                this.mskTotalFrete.Mask = "$ 999.00";
                mskTotalFrete.Text = Convert.ToString(valorviagem);
            }
            else
            {
                this.mskTotalFrete.Mask = "$ 9.999.00";
                mskTotalFrete.Text = Convert.ToString(valorviagem);
            }
            

            /* double Porcentagem;
            Porcentagem = Custo * Desconto / 100;
            Total = Custo - Porcentagem;*/
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //instancia a classe clBarbearias
            clFrete clFrete = new clFrete();

            //carrega as propriedades
            int idMotoristaGravar = Convert.ToInt32(idMotorista);
            int idViagemGravar = Convert.ToInt32(idViagem);

            clFrete.idMotorista = idMotoristaGravar;
            clFrete.idViagem = idViagemGravar;
            clFrete.Vale = txtVale.Text;
            clFrete.Volume = txtVolume.Text;
            clFrete.Data = dtpData.Text;
            clFrete.TotalComissao = mskComissao.Text;
            clFrete.NF = txtNF.Text;
            clFrete.FreteTotal = mskTotalFrete.Text;
            clFrete.PlacaCarreta = mskCarreta.Text;
            clFrete.PlacaCavalo = mskCavalo.Text;

            //variável com a string de conexão com o banco
            clFrete.banco = Properties.Settings.Default.conexaoDB;

            if (Funcao == "Alterar")
            {
                clFrete.Alterar();
                //mensagem de confirmação da inclusão
                MessageBox.Show("Frete Alterado com Sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForms(this);
                txtMotorista.Text = nome;
            }
            else
            {
                clFrete.Gravar();
                //mensagem de confirmação da inclusão
                MessageBox.Show("Frete lançado com Sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForms(this);
                txtMotorista.Text = nome;
            }


        }

        void limpar()
        {
            remetente = "";
            destinatario = "";
            valorfrete = "";
            idViagem = "";

        }
        public static void ClearForms(System.Windows.Forms.Control parent)
        {
            foreach (System.Windows.Forms.Control ctrControl in parent.Controls)
            {
                //Loop through all controls 
                if (object.ReferenceEquals(ctrControl.GetType(), typeof(System.Windows.Forms.TextBox)))
                {
                    //Check to see if it's a textbox 
                    ((System.Windows.Forms.TextBox)ctrControl).Text = string.Empty;
                    //If it is then set the text to String.Empty (empty textbox) 
                }
                else if (object.ReferenceEquals(ctrControl.GetType(), typeof(System.Windows.Forms.RichTextBox)))
                {
                    //If its a RichTextBox clear the text
                    ((System.Windows.Forms.RichTextBox)ctrControl).Text = string.Empty;
                }
                else if (object.ReferenceEquals(ctrControl.GetType(), typeof(System.Windows.Forms.ComboBox)))
                {
                    //Next check if it's a dropdown list 
                    ((System.Windows.Forms.ComboBox)ctrControl).SelectedIndex = -1;
                    //If it is then set its SelectedIndex to 0 
                }
                else if (object.ReferenceEquals(ctrControl.GetType(), typeof(System.Windows.Forms.CheckBox)))
                {
                    //Next uncheck all checkboxes
                    ((System.Windows.Forms.CheckBox)ctrControl).Checked = false;
                }
                else if (object.ReferenceEquals(ctrControl.GetType(), typeof(System.Windows.Forms.RadioButton)))
                {
                    //Unselect all RadioButtons
                    ((System.Windows.Forms.RadioButton)ctrControl).Checked = false;
                }
                else if (object.ReferenceEquals(ctrControl.GetType(), typeof(System.Windows.Forms.MaskedTextBox)))
                {
                    //Unselect all RadioButtons
                    ((System.Windows.Forms.MaskedTextBox)ctrControl).Text = "";
                }
                else if (object.ReferenceEquals(ctrControl.GetType(), typeof(System.Windows.Forms.PictureBox)))
                {
                    //Unselect all RadioButtons

                }
                if (ctrControl.Controls.Count > 0)
                {
                    //Call itself to get all other controls in other containers 
                    ClearForms(ctrControl);
                }

            }

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            new fmrInicio().Show();
            this.Close();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            //validaçao do conteudo
            if (idFrete == "")
            {
                return;
            }
            //pergunta para o usuario se ele confirma exclusão de cdastro
            DialogResult resposta;
            resposta = MessageBox.Show("Confirma a Exclusão do Frete?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (resposta.Equals(DialogResult.No))
            {
                return;
            }
            //instancia a classe do negocio
            clFrete clFrete = new clFrete();

            //variavel com string de conexao com o banco
            clFrete.banco = Properties.Settings.Default.conexaoDB;
            clFrete.idFrete = Convert.ToInt32(idFrete);
            clFrete.Excluir();


            //mensagem de configuraçãode exclusão
            MessageBox.Show("Frete excluido com sucesso", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearForms(this);
            idMotorista = "";
            nome = "";

        }

        private void txtVolume_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtVolume_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita somente numeros e virgula");
            }
        }



        private void cmbMotorista_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void CmbMoto_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
    
}
