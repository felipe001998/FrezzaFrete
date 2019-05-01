using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
     public class clFrete
    {
        public string banco { get; set; }
        public int idFrete { get; set; }
        public int idMotorista { get; set; }
        public int idViagem { get; set; }
        public string Vale { get; set; }
        public string Volume { get; set; }
        public string Data { get; set; }
        public string TotalComissao { get; set; }
        public string NF { get; set; }
        public string FreteTotal { get; set; }
        public string PlacaCarreta { get; set; }
        public string PlacaCavalo { get; set; }

        public void Gravar()
        {
            //variável utilizada para  "concatenar" texto
            //de forma estruturada
            StringBuilder strQuery = new StringBuilder();

            //montagem do insert
            strQuery.Append(" INSERT INTO tbFrete");

            strQuery.Append(" ( ");

            strQuery.Append(" idViagem ");
            strQuery.Append(", idMotorista ");
            strQuery.Append(", Vale ");
            strQuery.Append(", Volume ");
            strQuery.Append(", Data ");
            strQuery.Append(", TotalComissao ");
            strQuery.Append(", NF ");
            strQuery.Append(", FreteTotal ");
            strQuery.Append(", PlacaCarreta ");
            strQuery.Append(", PlacaCavalo ");

            strQuery.Append(" ) ");

            strQuery.Append(" VALUES ( ");

            strQuery.Append(" '" + idViagem + "'");
            strQuery.Append(", '" + idMotorista + "'");
            strQuery.Append(", '" + Vale + "'");
            strQuery.Append(", '" + Volume + "'");
            strQuery.Append(", '" + Data + "'");
            strQuery.Append(", '" + TotalComissao + "'");
            strQuery.Append(", '" + NF + "'");
            strQuery.Append(", '" + FreteTotal + "'");
            strQuery.Append(", '" + PlacaCarreta + "'");
            strQuery.Append(", '" + PlacaCavalo + "'");


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
            strQuery.Append(" UPDATE tbFrete");

            strQuery.Append(" SET ");

            strQuery.Append(" IdViagem = '" + idViagem + "'");
            strQuery.Append(", IdMotorista = '" + idMotorista + "'");
            strQuery.Append(", Vale = '" + Vale + "'");
            strQuery.Append(", Volume = '" + Volume + "'");
            strQuery.Append(", Data = '" + Data + "'");
            strQuery.Append(", TotalComissao = '" + TotalComissao + "'");
            strQuery.Append(", NF = '" + NF + "'");
            strQuery.Append(", FreteTotal = '" + FreteTotal + "'");
            strQuery.Append(", PlacaCarreta = '" + PlacaCarreta + "'");
            strQuery.Append(", PlacaCavalo = '" + PlacaCavalo + "'");



            strQuery.Append(" WHERE ");

            strQuery.Append("idFrete =" + idFrete);
            //INSTANCIA A CLASSE clAcessoDB e executa o comando
            clAcessoDB clAcessoDB = new clAcessoDB();
            clAcessoDB.vConexao = banco;
            clAcessoDB.ExecutaComando(strQuery.ToString());
        }

        public void Excluir()
        {
            StringBuilder strQuery = new StringBuilder();
            //montagem de delete
            strQuery.Append(" DELETE FROM tbFrete ");
            strQuery.Append(" WHERE ");
            strQuery.Append(" idFrete = " + idFrete);

            //instancia a classe clAcessoDB e xecutar o comando
            clAcessoDB clAcessoDB = new clAcessoDB();
            clAcessoDB.vConexao = banco;
            clAcessoDB.ExecutaComando(strQuery.ToString());
        }



        public DataSet PesquisaLoad(string dataload, string dt)
        {
            StringBuilder strQuery = new StringBuilder();

            //montagem do select
            string aspas = "" + (char)34;
            strQuery.Append(" SELECT tbMotorista.Nome, tbViagem.Remetente, tbViagem.Destinatario, tbFrete.Data, tbFrete.Volume, tbFrete.TotalComissao, tbFrete.PlacaCavalo, tbFrete.PlacaCarreta, tbFrete.idFrete");
            strQuery.Append(" FROM tbViagem INNER JOIN (tbMotorista INNER JOIN tbFrete ON tbMotorista.[idMotorista] = tbFrete.[idMotorista]) ON tbViagem.[idViagem] = tbFrete.[idViagem]");
            strQuery.Append(" WHERE (((tbFrete.Data) Between #"+dataload+"# And #"+dt+ "#)) ORDER BY tbMotorista.Nome, tbFrete.Data DESC; ");
           // strQuery.Append(" WHERE tbCortes.CorteData BETWEEN( '" + DataMin + "') AND ('" + DataMax + "') AND tbCortes.idBarbearia= " + CodBarbearia);

            //EXECUTA O COMANDO
            clAcessoDB clAcessoDB = new clAcessoDB();
            clAcessoDB.vConexao = banco;
            return clAcessoDB.RetornaDataSet(strQuery.ToString());
            
        }
        public DataSet PesquisaMoto(string dataload, string dt, string moto)
        {
            StringBuilder strQuery = new StringBuilder();

            //montagem do select
            string aspas = "" + (char)34;
            strQuery.Append(" SELECT tbMotorista.Nome, tbViagem.Remetente, tbViagem.Destinatario, tbFrete.Data, tbFrete.Volume, tbFrete.TotalComissao, tbFrete.PlacaCavalo, tbFrete.PlacaCarreta, tbFrete.idFrete");
            strQuery.Append(" FROM tbViagem INNER JOIN (tbMotorista INNER JOIN tbFrete ON tbMotorista.[idMotorista] = tbFrete.[idMotorista]) ON tbViagem.[idViagem] = tbFrete.[idViagem]");
            strQuery.Append(" WHERE (((tbFrete.Data) Between #" + dataload + "# And #" + dt + "#)AND ((tbMotorista.idMotorista)="+moto+")) ORDER BY " +
                "tbMotorista.Nome, tbFrete.Data DESC; ");
                            //WHERE(((tbFrete.Data)Between #4/1/2019# And #4/27/2019#) AND ((tbMotorista.idMotorista)=9))

            //EXECUTA O COMANDO
            clAcessoDB clAcessoDB = new clAcessoDB();
            clAcessoDB.vConexao = banco;
            return clAcessoDB.RetornaDataSet(strQuery.ToString());

        }

        public OleDbDataReader PesquisarDGVClick(int codFrete)
        {
            StringBuilder strQuery = new StringBuilder();
            //montagem do select
            strQuery.Append(" SELECT tbFrete.idFrete, tbFrete.idViagem, tbFrete.idMotorista, tbFrete.Vale, tbFrete.Volume, tbFrete.Data, tbFrete.TotalComissao, tbFrete.NF, tbFrete.FreteTotal, tbFrete.PlacaCarreta, tbFrete.PlacaCavalo, tbViagem.Remetente, tbViagem.Destinatario, tbViagem.ValorFrete, tbMotorista.Nome ");
            strQuery.Append(" FROM tbViagem INNER JOIN (tbMotorista INNER JOIN tbFrete ON tbMotorista.[idMotorista] = tbFrete.[idMotorista]) ON tbViagem.[idViagem] = tbFrete.[idViagem] ");
            strQuery.Append(" WHERE ");
            strQuery.Append(" idFrete = " + codFrete);
            //executa oo comando
            clAcessoDB clAcessoDB = new clAcessoDB();
            clAcessoDB.vConexao = banco;
            return clAcessoDB.RetornaDataReader(strQuery.ToString());
        }
        public OleDbDataReader RelMoto(string dataload, string dt, string moto)
        {
            StringBuilder strQuery = new StringBuilder();
            //montagem do select
            strQuery.Append(" SELECT tbMotorista.Nome, tbViagem.Remetente, tbViagem.Destinatario, tbFrete.Data, tbFrete.Volume, tbFrete.TotalComissao, tbFrete.PlacaCavalo, tbFrete.PlacaCarreta, tbFrete.idFrete");
            strQuery.Append(" FROM tbViagem INNER JOIN (tbMotorista INNER JOIN tbFrete ON tbMotorista.[idMotorista] = tbFrete.[idMotorista]) ON tbViagem.[idViagem] = tbFrete.[idViagem]");
            strQuery.Append(" WHERE (((tbFrete.Data) Between #" + dataload + "# And #" + dt + "#)AND ((tbMotorista.idMotorista)=" + moto + ")) ORDER BY " +
                "tbMotorista.Nome, tbFrete.Data DESC; ");
            //executa oo comando
            clAcessoDB clAcessoDB = new clAcessoDB();
            clAcessoDB.vConexao = banco;
            return clAcessoDB.RetornaDataReader(strQuery.ToString());
        }


    }
}
