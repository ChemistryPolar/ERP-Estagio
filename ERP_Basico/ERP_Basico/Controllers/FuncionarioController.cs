using ERP_Basico.Models;
using ERP_Basico.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_Basico.Controllers
{
    public class FuncionarioController
    {
        #region Variaveis Locais
        DataBaseSqlServer dataBase = new DataBaseSqlServer();

        #endregion

        #region Inserir

        public int InserirFuncionario(Funcionario funcionario)
        {

            string queryInserir =
                "INSERT funcionario (Nome, Email, Telefone, cpf, Setor, Endereco, DataNasc, Username, Password, Role)" +
                "VALUES (@Nome, @Email, @Telefone, @CPF, @Setor, @Endereco, @DatNasc, @Username, @Password, @Role)";

            dataBase.LimparParametros();

            dataBase.AdicionarParametros("@Nome", funcionario.FuncionarioNome);
            dataBase.AdicionarParametros("@Email", funcionario.FuncionarioEmail);
            dataBase.AdicionarParametros("@Telefone", funcionario.FuncionarioTel);
            dataBase.AdicionarParametros("@CPF", funcionario.FuncionarioCPF);
            dataBase.AdicionarParametros("@Setor", funcionario.FuncionarioSetor);
            dataBase.AdicionarParametros("@Endereco", funcionario.FuncionarioEndereco);
            dataBase.AdicionarParametros("@DatNasc", funcionario.FuncionarioDatNasc);
            dataBase.AdicionarParametros("@Username", funcionario.FuncionarioUser);
            dataBase.AdicionarParametros("@Password", funcionario.FuncionarioPassword);
            dataBase.AdicionarParametros("@Role", funcionario.FuncionarioRole);


            dataBase.ExecutarManipulacao(CommandType.Text, queryInserir);
            return Convert.ToInt32(dataBase.ExecutarConsultaScalar(
                CommandType.Text, "SELECT MAX(IdFuncionario) FROM funcionario"));
        }
        #endregion

        #region Alterar
        public int AlterarFuncionario(Funcionario funcionario)
        {
            string queryAlterar =
                "UPDATE funcionario SET " +
                "Nome = @Nome, " +
                "Email = @Email, " +
                "Telefone = @Telefone, " +
                "CPF = @CPF, " +
                "Setor = @Setor, " +
                "Endereco = @Endereco, " +
                "DataNasc = @DatNasc,  " +
                "Username = @Username, " +
                "Password = @Passowrd, " +
                "Role = @Role " +
                "WHERE IdFuncionario = @IdFuncionario";

            dataBase.LimparParametros();
            dataBase.AdicionarParametros("@Nome", funcionario.FuncionarioNome);
            dataBase.AdicionarParametros("@Email", funcionario.FuncionarioEmail);
            dataBase.AdicionarParametros("@Telefone", funcionario.FuncionarioTel);
            dataBase.AdicionarParametros("@CPF", funcionario.FuncionarioCPF);
            dataBase.AdicionarParametros("@Setor", funcionario.FuncionarioSetor);
            dataBase.AdicionarParametros("@Endereco", funcionario.FuncionarioEndereco);
            dataBase.AdicionarParametros("@DatNasc", funcionario.FuncionarioDatNasc);
            dataBase.AdicionarParametros("@Username", funcionario.FuncionarioUser);
            dataBase.AdicionarParametros("@Password", funcionario.FuncionarioPassword);
            dataBase.AdicionarParametros("@Role", funcionario.FuncionarioRole);

            return dataBase.ExecutarManipulacao(
                CommandType.Text, queryAlterar);
        }
        #endregion

        #region Apagar
        public int ApagarFuncionario(int IdFuncionario)
        {
            string queryApagar =
                "DELETE FROM funcionario " +
                "WHERE IdFuncionario = @IdFuncionario";

            dataBase.LimparParametros();
            dataBase.AdicionarParametros("@IdCliente", IdFuncionario);

            return dataBase.ExecutarManipulacao(
                CommandType.Text, queryApagar);
        }
        #endregion

        #region Pesquisar
        public FuncionarioCollection PesquisarFuncionarioPorNome(string nome)
        {
            FuncionarioCollection funcionarioColecao = new FuncionarioCollection();
            string query =
                "SELECT * FROM funcionario " + "WHERE nome LIKE '%' + @Nome + '%'";

            dataBase.LimparParametros();
            dataBase.AdicionarParametros("@Nome", nome.Trim());

            DataTable dataTable = dataBase.ExecutarConsulta(
                CommandType.Text, query);

            foreach (DataRow dataRow in dataTable.Rows)
            {
                Funcionario funcionario = new Funcionario();

                funcionario.IdFuncionario = Convert.ToInt32(dataRow["IdFuncionario"]);
                funcionario.FuncionarioNome  = Convert.ToString(dataRow["Nome"]);
                funcionario.FuncionarioEmail = Convert.ToString(dataRow["Email"]);
                funcionario.FuncionarioTel = Convert.ToString(dataRow["Telefone"]);
                funcionario.FuncionarioCPF = Convert.ToString(dataRow["CPF"]);
                funcionario.FuncionarioSetor = Convert.ToString(dataRow["Setor"]);
                funcionario.FuncionarioEndereco = Convert.ToString(dataRow["Endereco"]);
                funcionario.FuncionarioUser = Convert.ToString(dataRow["User"]);
                funcionario.FuncionarioRole = Convert.ToString(dataRow["Role"]);

                if (!(dataRow["DataNasc"] is DBNull))
                    funcionario.FuncionarioDatNasc =
                        Convert.ToDateTime(dataRow["DataNasc"]);

                funcionarioColecao.Add(funcionario);
            }
            return funcionarioColecao;
        }
        #endregion

        #region PesqusiarAll
        public FuncionarioCollection PesquisarClienteAll()
        {
            FuncionarioCollection funcionarioColecao = new FuncionarioCollection();
            string query =
                "SELECT * FROM cliente";

            DataTable dataTable = dataBase.ExecutarConsulta(
                CommandType.Text, query);

            foreach (DataRow dataRow in dataTable.Rows)
            {
                Funcionario funcionario = new Funcionario();

                funcionario.IdFuncionario = Convert.ToInt32(dataRow["IdFuncionario"]);
                funcionario.FuncionarioNome = Convert.ToString(dataRow["Nome"]);
                funcionario.FuncionarioEmail = Convert.ToString(dataRow["Email"]);
                funcionario.FuncionarioTel = Convert.ToString(dataRow["Telefone"]);
                funcionario.FuncionarioCPF = Convert.ToString(dataRow["CPF"]);
                funcionario.FuncionarioSetor = Convert.ToString(dataRow["Setor"]);
                funcionario.FuncionarioEndereco = Convert.ToString(dataRow["Endereco"]);
                funcionario.FuncionarioUser = Convert.ToString(dataRow["User"]);
                funcionario.FuncionarioRole = Convert.ToString(dataRow["Role"]);

                if (!(dataRow["DataNasc"] is DBNull))
                    funcionario.FuncionarioDatNasc =
                        Convert.ToDateTime(dataRow["DataNasc"]);

                funcionarioColecao.Add(funcionario);
            }
            return funcionarioColecao;
        }
        #endregion

    }
}
