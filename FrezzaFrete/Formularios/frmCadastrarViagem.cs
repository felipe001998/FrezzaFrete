using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using System.Text.RegularExpressions;

namespace FrezzaFrete
{
    public partial class frmCadastrarViagem : Form
    {
        public static string idViagem { get; set; }
        public static string remetente { get; set; }
        public static string destinatario { get; set; }
        public static string valorfrete { get; set; }


        public frmCadastrarViagem()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtRemetente.Text == "")
            {
                MessageBox.Show("Insira um Remetente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtDestinatario.Text == "")
            {
                MessageBox.Show("Insira um Destinatario.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (mskValor.Text == "R$   ,")
            {
                MessageBox.Show("Insira um Valor.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //instancia a classe clBarbearias
            clViagem clViagem = new clViagem();

            //carrega as propriedades
            clViagem.Remetente = txtRemetente.Text;
            clViagem.Destinatario = txtDestinatario.Text;
            clViagem.ValorFrete = mskValor.Text;
            //variável com a string de conexão com o banco
            clViagem.banco = Properties.Settings.Default.conexaoDB;

            if (idViagem == null)

            {
                clViagem.Gravar();
                //mensagem de confirmação da inclusão
                MessageBox.Show("Viagem Incluída com Sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForms(this);
            }
            else
            {
                clViagem.idViagem = Convert.ToInt32(idViagem);
                clViagem.Alterar();
                //mensagem de confirmação da inclusão
                MessageBox.Show("Viagem Alterada com Sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForms(this);
            }

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

        private void btnsair_Click(object sender, EventArgs e)
        {
            idViagem = "";
            remetente = "";
            valorfrete = "";
            destinatario = "";
            new fmrInicio().Show();
            this.Close();
        }

        private void frmCadastrarViagem_Load(object sender, EventArgs e)
        {
            txtDestinatario.Text = destinatario;
            txtRemetente.Text = remetente;
            mskValor.Text = valorfrete;
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            //validaçao do conteudo
            if (idViagem == "")
            {
                return;
            }
            //pergunta para o usuario se ele confirma exclusão de cdastro
            DialogResult resposta;
            resposta = MessageBox.Show("Confirma a Exclusão da Viagem?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (resposta.Equals(DialogResult.No))
            {
                return;
            }
            //instancia a classe do negocio
            clViagem clViagem = new clViagem();

            //variavel com string de conexao com o banco
            clViagem.banco = Properties.Settings.Default.conexaoDB;
            clViagem.idViagem = Convert.ToInt32(idViagem);
            clViagem.Excluir();


            //mensagem de configuraçãode exclusão
            MessageBox.Show("Viagem excluida com sucesso", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearForms(this);
            idViagem = "";
            remetente = "";
            valorfrete = "";
            destinatario = "";
        }
    }
}
