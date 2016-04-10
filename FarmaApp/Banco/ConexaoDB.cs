using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Banco
{
    public class ConexaoDB
    {
        public string strConnection { get; set; }
        public SqlConnection sqlConection { get; set; }


        public ConexaoDB()
        {
            strConnection = config.Default.conexao;                
            sqlConection = new SqlConnection(strConnection);
            sqlConection.Open();                      
        }           
        

        //Metodo abrindo a conexão
        public SqlConnection conectar()
        {
          sqlConection = new SqlConnection(strConnection);
            try
            {
                sqlConection.Open();
                return sqlConection;
            }
            catch
            { 
              return null;
            }
        }



        //verificando e fechando a conexão
        protected SqlConnection desconectar()
        {
            if (sqlConection.State != ConnectionState.Closed)
            {
                sqlConection.Close();
                sqlConection.Dispose();//tira o objeConexao da memoria
                return sqlConection;
            }
            else
            {
                sqlConection.Dispose();
                return null;
            }
        }
    }
}

