using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Domain.Classes;




namespace Banco
{
    public class OperacoesBD : ConexaoDB
    {
       string sql;

        public bool Insert(ArrayList arrInsert)
        {
            sql = "INSERT INTO CLIENTE (NOME, IDADE, EMAIL, RUA, NUMERO, BAIRRO, CIDADE, ESTADO)" +
                "VALUES (@NOME, @IDADE, @EMAIL, @RUA, @NUMERO, @BAIRRO, @CIDADE, @ESTADO)";

            SqlCommand objCon = null;
                      
                try
                {                  
                    objCon = new SqlCommand(sql, base.conectar());
                    objCon.Parameters.Add(new SqlParameter("@NOME", arrInsert[0]));
                    objCon.Parameters.Add(new SqlParameter("@IDADE", arrInsert[1]));
                    objCon.Parameters.Add(new SqlParameter("@EMAIL", arrInsert[2]));
                    objCon.Parameters.Add(new SqlParameter("@RUA", arrInsert[3]));
                    objCon.Parameters.Add(new SqlParameter("@NUMERO", arrInsert[4]));
                    objCon.Parameters.Add(new SqlParameter("@BAIRRO", arrInsert[5]));
                    objCon.Parameters.Add(new SqlParameter("@CIDADE", arrInsert[6]));
                    objCon.Parameters.Add(new SqlParameter("@ESTADO", arrInsert[7]));

                objCon.ExecuteNonQuery();

                return true;

                }
                catch(SqlException)
                {
                    throw;
                }
                finally
                {
                    this.desconectar();
                }          

        }

       
        public bool Update(ArrayList arrUpdate)
        {
            sql = "UPDATE CLIENTE SET NOME = @NOME, IDADE = @IDADE, EMAIL = @EMAIL, RUA = @RUA, NUMERO = @NUMERO, BAIRRO = @BAIRRO, CIDADE = @CIDADE, ESTADO = @ESTADO " +
                " WHERE ID_CLIENTE = @ID_CLIENTE";

            SqlCommand objCon = null;

            try
            {                
                objCon = new SqlCommand(sql, base.conectar());               
                objCon.Parameters.Add(new SqlParameter("@NOME", arrUpdate[0]));
                objCon.Parameters.Add(new SqlParameter("@IDADE", arrUpdate[1]));
                objCon.Parameters.Add(new SqlParameter("@EMAIL", arrUpdate[2]));
                objCon.Parameters.Add(new SqlParameter("@RUA", arrUpdate[3]));
                objCon.Parameters.Add(new SqlParameter("@NUMERO", arrUpdate[4]));
                objCon.Parameters.Add(new SqlParameter("@BAIRRO", arrUpdate[5]));
                objCon.Parameters.Add(new SqlParameter("@CIDADE", arrUpdate[6]));
                objCon.Parameters.Add(new SqlParameter("@ESTADO", arrUpdate[7]));
                objCon.Parameters.Add(new SqlParameter("@ID_CLIENTE", arrUpdate[8]));


                objCon.ExecuteNonQuery();

                return true;
            }
            catch (SqlException)
            {
                throw;
            }
            finally
            {
                this.desconectar();
            }

        }


        public bool Delete(int id_cliente)
        {
            sql = "DELETE FROM CLIENTE WHERE ID_CLIENTE = @ID_CLIENTE";

            SqlCommand objCon = null;

            try
            {
                objCon = new SqlCommand(sql, base.conectar());
                objCon.Parameters.AddWithValue("@ID_CLIENTE", id_cliente);
                objCon.ExecuteNonQuery();
                return true;
            }
            catch (SqlException)
            {
                throw;
            }
            finally
            {
                this.desconectar();
            }
            
        }

        public DataTable ListGrid()
        {
            sql = "SELECT NOME, EMAIL, RUA, NUMERO, BAIRRO, CIDADE, ESTADO  FROM CLIENTE";

            SqlCommand objCon = null;

            try
            {
                objCon = new SqlCommand(sql, base.conectar());
                SqlDataAdapter adp = new SqlDataAdapter(objCon);
                DataTable tabela = new DataTable();
                adp.Fill(tabela);
                return tabela;
               
            }
            catch (SqlException)
            {
                throw;
            }
            finally
            {
                this.desconectar();
            }
        }

        /*public List<Cliente> ListaCliente()
        {
            var sql = "select * from cliente";
            var listaDeCliente = new List<Cliente>();

            try
            {
                SqlCommand cmd = new SqlCommand(sql, sqlConection);
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    listaDeCliente.Add(
                        new Cliente {
                            Nome = rdr["Nome"].ToString(),
                            Idade = Convert.ToInt32(rdr["Idade"]),
                            Rua = rdr["Rua"].ToString(),
                            Numero = Convert.ToInt32(rdr["Numero"]),
                            Bairro = rdr["Bairro"].ToString(),
                            Cidade = rdr["Cidade"].ToString()
                        });
                }
                return listaDeCliente;
            }
           
            catch (Exception)
            {
                throw;
            }
        }*/
    }
}
