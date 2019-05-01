using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class clMotorista
    {
        public string banco { get; set; }
        public int idMotorista { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string CNH { get; set; }


        public void Gravar()
        {
            //variável utilizada para  "concatenar" texto
            //de forma estruturada
            StringBuilder strQuery = new StringBuilder();

            //montagem do insert
            strQuery.Append(" INSERT INTO tbMotorista");

            strQuery.Append(" ( ");

            strQuery.Append(" Nome ");
            strQuery.Append(", Telefone ");
            strQuery.Append(", CNH ");

            strQuery.Append(" ) ");

            strQuery.Append(" VALUES ( ");

            strQuery.Append(" '" + Nome + "'");
            strQuery.Append(", '" + Telefone + "'");
            strQuery.Append(", '" + CNH + "'");

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
            strQuery.Append(" UPDATE tbMotorista");

            strQuery.Append(" SET ");

            strQuery.Append(" Nome = '" + Nome + "'");
            strQuery.Append(", Telefone = '" + Telefone + "'");
            strQuery.Append(", CNH = '" + CNH + "'");



            strQuery.Append(" WHERE ");

            strQuery.Append("IdMotorista=" + idMotorista);
            //INSTANCIA A CLASSE clAcessoDB e executa o comando
            clAcessoDB clAcessoDB = new clAcessoDB();
            clAcessoDB.vConexao = banco;
            clAcessoDB.ExecutaComando(strQuery.ToString());
        }

        public void Excluir()
        {
            StringBuilder strQuery = new StringBuilder();
            //montagem de delete
            strQuery.Append(" DELETE FROM tbMotorista ");
            strQuery.Append(" WHERE ");
            strQuery.Append(" idMotorista = " + idMotorista);

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
            strQuery.Append(" SELECT idMotorista, Nome");
            strQuery.Append(" FROM tbMotorista");

            //EXECUTA O COMANDO
            clAcessoDB clAcessoDB = new clAcessoDB();
            clAcessoDB.vConexao = banco;
            return clAcessoDB.RetornaDataSet(strQuery.ToString());
        }
        public OleDbDataReader PesquisarCodigo(int codMotorista)
        {
            StringBuilder strQuery = new StringBuilder();
            //montagem do select
            strQuery.Append(" SELECT * ");
            strQuery.Append(" FROM tbMotorista ");
            strQuery.Append(" WHERE ");
            strQuery.Append(" idMotorista = " + codMotorista);
            //executa oo comando
            clAcessoDB clAcessoDB = new clAcessoDB();
            clAcessoDB.vConexao = banco;
            return clAcessoDB.RetornaDataReader(strQuery.ToString());
        }
        public OleDbDataReader PesquisarNome()
        {
            StringBuilder strQuery = new StringBuilder();
            //montagem do select
            strQuery.Append(" SELECT * ");
            strQuery.Append(" FROM tbMotorista ");
            //executa oo comando
            clAcessoDB clAcessoDB = new clAcessoDB();
            clAcessoDB.vConexao = banco;
            return clAcessoDB.RetornaDataReader(strQuery.ToString());
        }


    }
}
