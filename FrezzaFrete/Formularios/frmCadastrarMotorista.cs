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

namespace FrezzaFrete
{
    public partial class frmCadastrarMotorista : Form
    {
        public static string idMotorista { get; set; }
        public static string nome { get; set; }
        public static string cnh { get; set; }
        public static string telefone { get; set; }

        public frmCadastrarMotorista()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            if (txtNome.Text == "")
            {
                MessageBox.Show("Insira um nome", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //instancia a classe clBarbearias
            clMotorista clMotorista = new clMotorista();

            //carrega as propriedades


            clMotorista.Nome = txtNome.Text;
            clMotorista.Telefone = mskTelefone.Text;
            clMotorista.CNH = txtCNH.Text;

            //variável com a string de conexão com o banco
            clMotorista.banco = Properties.Settings.Default.conexaoDB;
            if (idMotorista == null)
            {
                clMotorista.Gravar();
                //mensagem de confirmação da inclusão
                MessageBox.Show("Motorista Incluído com Sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForms(this);
            }
            else
            {
                clMotorista.idMotorista = Convert.ToInt32(idMotorista);
                clMotorista.Alterar();
                //mensagem de confirmação da inclusão
                MessageBox.Show("Motorista Alterado com Sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForms(this);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void frmCadastrarMotorista_Load(object sender, EventArgs e)
        {
            txtNome.Text = nome;
            txtCNH.Text = cnh;
            mskTelefone.Text = telefone;
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
            idMotorista = "";
            nome = "";
            telefone = "";
            cnh = "";
            new fmrInicio().Show();
            this.Close();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            //validaçao do conteudo
            if (idMotorista == "")
            {
                return;
            }
            //pergunta para o usuario se ele confirma exclusão de cdastro
            DialogResult resposta;
            resposta = MessageBox.Show("Confirma a Exclusão do Motorista?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (resposta.Equals(DialogResult.No))
            {
                return;
            }
            //instancia a classe do negocio
            clMotorista clMotorista = new clMotorista();

            //variavel com string de conexao com o banco
            clMotorista.banco = Properties.Settings.Default.conexaoDB;
            clMotorista.idMotorista = Convert.ToInt32(idMotorista);
            clMotorista.Excluir();


            //mensagem de configuraçãode exclusão
            MessageBox.Show("Motorista excluido com sucesso", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearForms(this);
            idMotorista = "";
            nome = "";
            telefone = "";
            cnh = "";
        }
    }
}
