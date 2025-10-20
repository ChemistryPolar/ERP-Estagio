using ERP_Basico.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ERP_Basico.Services
{
     public class DataBaseSqlServer
    {
        private SqlConnection CriarConexao()
        {
            SqlConnection conexao = new SqlConnection();

            conexao.ConnectionString =


                "Data Source=.\\SQLExpress;" +
                "Initial Catalog=erpBasico;" +
                "Integrated Security=SSPI;" +
                "User Instance = false;";

            conexao.Open();
            return conexao;
            }



        public void ValidarUser(string User, string Password)
        {
            try
            {
                string queryInserir = "SELECT Role from funcionario WHERE Username = @username and Password= @password";
                string returnValue = "";
                using SqlConnection con = CriarConexao();
                {
                    using (SqlCommand sqlcmd = new SqlCommand(queryInserir, con))
                    {

                        sqlcmd.Parameters.Add("@username", SqlDbType.VarChar).Value = User;
                        sqlcmd.Parameters.Add("@password", SqlDbType.VarChar).Value = Password;
                        returnValue = (string)sqlcmd.ExecuteScalar();

                        if (String.IsNullOrEmpty(returnValue))
                        {
                            MessageBox.Show("User ou senha incorreta");
                            return;
                        }
                        else if (returnValue == "Admin")
                        {
                            MessageBox.Show("Sessão iniciada como Administrador");
                            tlHome home = new tlHome("Admin");
                            returnValue = returnValue.Trim();
                            home.Show();
                        }
                        else if (returnValue == "User")
                        {
                            MessageBox.Show("Sessão inciada como Usuário");
                            tlHome home = new tlHome("User");
                            returnValue = returnValue.Trim();
                            home.Show();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Houve uma falha ao execuar o " +
                    "comando no banco de dados.\r\n" +
                    "Mensagem original: " + ex.Message);
            }
        
    }



        private
            SqlParameterCollection sqlParameterCollection =
                new SqlCommand().Parameters;

        public void LimparParametros()
        {
            sqlParameterCollection.Clear();
        }

        public void
            AdicionarParametros(string nomeParametro,
                                object valorParametro)
        {
            sqlParameterCollection.Add(
                new SqlParameter(nomeParametro,
                                 valorParametro));
        }

        public int ExecutarManipulacao(
            CommandType commandType,
            string nomeStoredProcedureOuTextpSql)
        {
            try
            {
                SqlConnection sqlConnection = CriarConexao();
                SqlCommand sqlCommand = sqlConnection.CreateCommand();

                sqlCommand.CommandType = commandType;
                sqlCommand.CommandText = nomeStoredProcedureOuTextpSql;

                foreach (SqlParameter sqlParameter in sqlParameterCollection)
                {
                    sqlCommand.Parameters.Add(
                        new SqlParameter(sqlParameter.ParameterName,
                                            sqlParameter.Value));
                }

                return sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Houve uma falha ao execuar o " +
                    "comando no banco de dados.\r\n" +
                    "Mensagem original: " + ex.Message);
            }
        }

        public DataTable ExecutarConsulta(
            CommandType commandType,
            string nomeStoredProcedureOuTextpSql)
        {
            try
            {
                SqlConnection sqlConnection = CriarConexao();
                SqlCommand sqlCommand = sqlConnection.CreateCommand();

                sqlCommand.CommandType = commandType;
                sqlCommand.CommandText = nomeStoredProcedureOuTextpSql;

                foreach (SqlParameter sqlParameter
                    in sqlParameterCollection)
                {
                    sqlCommand.Parameters.Add(
                        new SqlParameter(sqlParameter.ParameterName,
                                            sqlParameter.Value));
                }

                SqlDataAdapter sqlDataAdapter =
                    new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();

                sqlDataAdapter.Fill(dataTable);

                return dataTable;
            }
            catch (Exception ex)
            {
                throw new Exception("Houve uma falha ao execuar o " +
                    "comando no banco de dados.\r\n" +
                    "Mensagem original: " + ex.Message);
            }
        }

        public object ExecutarConsultaScalar(CommandType commandType,
            string nomeStoredProcedureOuTextpSql)
        {
            try
            {
                SqlConnection sqlConnection = CriarConexao();
                SqlCommand sqlCommand = sqlConnection.CreateCommand();

                sqlCommand.CommandType = commandType;
                sqlCommand.CommandText = nomeStoredProcedureOuTextpSql;

                foreach (SqlParameter sqlParameter
                    in sqlParameterCollection)
                {
                    sqlCommand.Parameters.Add(
                        new SqlParameter(sqlParameter.ParameterName,
                                            sqlParameter.Value));
                }

                return sqlCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception("Houve uma falha ao execuar o " +
                    "comando no banco de dados.\r\n" +
                    "Mensagem original: " + ex.Message);
            }
        }

    }
}

