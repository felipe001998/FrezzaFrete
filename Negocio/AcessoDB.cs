using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class clAcessoDB
    {
        //variável para receber a string de conexão
        public string vConexao = "";

        //método responsável por abrir a conexão com o banco de dados

        public OleDbConnection  AbreBanco()
        {
            //Abre a conexão com a Base de Dados
            OleDbConnection conn = new OleDbConnection(vConexao);
            conn.Open();
            return conn;
        }

        //método responsável por fechar a conexão com o banco de dados

        public void FechaBanco(OleDbConnection conn)
        {
            //Fecha a Conexão com a Base de Dados
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
                conn.Dispose();
            }
        }

        //método responsável por executar comandos (INSERT, UPDATE, DELETE) no banco de dados
        public void ExecutaComando(string strQuery)
        {
            //cria objeto de conexão
            OleDbConnection conn = new OleDbConnection();
            try
            {
                //abre o banco de dados
                conn = AbreBanco();

                //cria o objeto de comando
                OleDbCommand cmdComando = new OleDbCommand();
                cmdComando.CommandText = strQuery;
                cmdComando.CommandType = CommandType.Text;
                cmdComando.Connection = conn;

                //passa os valores da query SQL, tipo do comando,
                //conexão e executa o comando
                cmdComando.ExecuteNonQuery();
            }
            //tratamento de excessões
            catch (System.Exception ex)
            {
                throw ex;
            }
            finally
            {
                //em caso de erro ou não, o finally
                //é executado para fechar a conexão com o banco de dados
                FechaBanco(conn);
            }
        }


        //DataSet é utilizado para retornar um volume
        //grande de registros utilizado principalmente
        //para o componente datagridview
        public DataSet RetornaDataSet(string strQuery)
        {
            //cria o objeto de conexão
            OleDbConnection conn = new OleDbConnection();
            try
            {
                //abre a conexão com o banco de dados
                conn = AbreBanco();
                // Cria o objeto de Comando
                OleDbCommand cmdComando = new OleDbCommand();
                //passa os valores da query SQL, tipo do comando, conexão
                //e executa o comando
                cmdComando.CommandText = strQuery;
                cmdComando.CommandType = CommandType.Text;
                cmdComando.Connection = conn;
                //declara um dataadapter
                OleDbDataAdapter daAdaptador = new OleDbDataAdapter();
                //declara um dataset
                DataSet dsDataSet = new DataSet();
                //passa o comando a ser executado pelo dataadapter
                daAdaptador.SelectCommand = cmdComando;
                //o dataadapterfaz a conexão com o banco de dados,
                //carrega o dataset e fecha a conexão
                daAdaptador.Fill(dsDataSet);
                //retorna o dataset carregado
                return dsDataSet;
                //tratamento de excessões
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
            finally
            {
                //em caso de erro ou não, o finally
                //é executado para fechar a conexão com o banco de dados
                FechaBanco(conn);
            }
        }

        public OleDbDataReader RetornaDataReader(string strQuery)
        {
            //cria o objeto de conexão
            OleDbConnection conn = new OleDbConnection();
            try
            {
                //abre a conexão com o banco de dados
                conn = AbreBanco();
                //Cria o Objeto de Comando
                OleDbCommand cmdComando = new OleDbCommand();
                //passa os valores da query SQL, tipo de comando,
                //conexão e executa o comando
                cmdComando.CommandText = strQuery;
                cmdComando.CommandType = CommandType.Text;
                cmdComando.Connection = conn;
                //retorna o comando executando a leitura
                return cmdComando.ExecuteReader
                    (CommandBehavior.CloseConnection);
                //tratamento das excessões
            }
            catch (SystemException ex)
            {
                throw ex;
            }
        }

        public int ExecutaComandoRetorno(string strQuery)
        {
            //cria o objeto de conexão
            OleDbConnection conn = new OleDbConnection();
            //declara um novo datareader
            OleDbDataReader dr;
            try
            {
                //abre a conexão com o banco de dados
                conn = AbreBanco();
                //cria o objeto de comando
                OleDbCommand cmdComando = new OleDbCommand();
                cmdComando.CommandText = strQuery;
                cmdComando.CommandType = CommandType.Text;
                cmdComando.Connection = conn;
                cmdComando.ExecuteNonQuery();
                //cria uma nova query, que busca o valor 
                //do identity gerado pelo banco de dados
                cmdComando.CommandText = "Select @@Identity;";
                dr = cmdComando.ExecuteReader(CommandBehavior.CloseConnection);
                //le o datareader
                dr.Read();
                //retorna o valor
                return Convert.ToInt32(dr.GetValue(0));
                //tratamento de excessões
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
            finally
            {
                //em caso de erro ou não, o finally é executado
                //para fechar a conexão com o banco de dados
                FechaBanco(conn);
            }
        }
    }
}
