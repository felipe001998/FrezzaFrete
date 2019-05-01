using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class clViagem
    {
        public string banco { get; set; }
        public int idViagem { get; set; }
        public string Remetente { get; set; }
        public string Destinatario { get; set; }
        public string ValorFrete { get; set; }

        public void Gravar()
        {
            //variável utilizada para  "concatenar" texto
            //de forma estruturada
            StringBuilder strQuery = new StringBuilder();

            //montagem do insert
            strQuery.Append(" INSERT INTO tbViagem");

            strQuery.Append(" ( ");

            strQuery.Append(" Remetente ");
            strQuery.Append(", Destinatario ");
            strQuery.Append(", ValorFrete ");

            strQuery.Append(" ) ");

            strQuery.Append(" VALUES ( ");

            strQuery.Append(" '" + Remetente + "'");
            strQuery.Append(", '" + Destinatario + "'");
            strQuery.Append(", '" + ValorFrete + "'");


            strQuery.Append(" );");

            //instancia a classe clAcessoDB e executa o comando
            clAcessoDB clAcessoDB = new clAcessoDB();
            clAcessoDB.vConexao = banco;
            clAcessoDB.ExecutaComando(strQuery.ToString());

        }

        public void Alterar()
        
        {
            StringBuilder strQuery = new StringBuilder();
            //montagem do UPDATE
            strQuery.Append(" UPDATE tbViagem");

            strQuery.Append(" SET ");

            strQuery.Append(" Remetente = '" + Remetente + "'");
            strQuery.Append(", Destinatario = '" + Destinatario + "'");
            strQuery.Append(", ValorFrete = '" + ValorFrete + "'");



            strQuery.Append(" WHERE ");

            strQuery.Append("idViagem=" + idViagem);
            //INSTANCIA A CLASSE clAcessoDB e executa o comando
            clAcessoDB clAcessoDB = new clAcessoDB();
            clAcessoDB.vConexao = banco;
            clAcessoDB.ExecutaComando(strQuery.ToString());
        }

        public void Excluir()
        {
            StringBuilder strQuery = new StringBuilder();
            //montagem de delete
            strQuery.Append(" DELETE FROM tbViagem ");
            strQuery.Append(" WHERE ");
            strQuery.Append(" idViagem = " + idViagem);

            //instancia a classe clAcessoDB e xecutar o comando
            clAcessoDB clAcessoDB = new clAcessoDB();
            clAcessoDB.vConexao = banco;
            clAcessoDB.ExecutaComando(strQuery.ToString());
        }


        public DataSet Pesquisar2()
        {
            StringBuilder strQuery = new StringBuilder();

            //montagem do select
            string aspas = "" + (char)34;
            strQuery.Append(" SELECT idViagem, Remetente, Destinatario, ValorFrete");
            strQuery.Append(" FROM tbViagem");

            //EXECUTA O COMANDO
            clAcessoDB clAcessoDB = new clAcessoDB();
            clAcessoDB.vConexao = banco;
            return clAcessoDB.RetornaDataSet(strQuery.ToString());
        }
        public OleDbDataReader PesquisarCodigo(int codViagem)
        {
            StringBuilder strQuery = new StringBuilder();
            //montagem do select
            strQuery.Append(" SELECT * ");
            strQuery.Append(" FROM tbViagem ");
            strQuery.Append(" WHERE ");
            strQuery.Append(" idViagem = " + codViagem);
            //executa oo comando
            clAcessoDB clAcessoDB = new clAcessoDB();
            clAcessoDB.vConexao = banco;
            return clAcessoDB.RetornaDataReader(strQuery.ToString());
        }
    }
}
