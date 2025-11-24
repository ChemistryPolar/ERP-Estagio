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
    public class FornecedorController
    {
        #region Variaveis Locais
        DataBaseSqlServer dataBase = new DataBaseSqlServer();

        #endregion

        #region Inserir

        public int InserirFornecedor(Fornecedor fornecedor)
        {

            string queryInserir =
                "INSERT funcionario (Nome, Email, Telefone, cnpj, Endereco)" +
                "VALUES (@Nome, @Email, @Telefone, @CNPJ, @Endereco)";

            dataBase.LimparParametros();

            dataBase.AdicionarParametros("@Nome", fornecedor.FornecedorNome);
            dataBase.AdicionarParametros("@Email", fornecedor.FornecedorEmail);
            dataBase.AdicionarParametros("@Telefone", fornecedor.FornecedorTel);
            dataBase.AdicionarParametros("@CNPJ", fornecedor.FornecedorCNPJ);
            dataBase.AdicionarParametros("@Endereco", fornecedor.FornecedorEndereco);


            dataBase.ExecutarManipulacao(CommandType.Text, queryInserir);
            return Convert.ToInt32(dataBase.ExecutarConsultaScalar(
                CommandType.Text, "SELECT MAX(IdFornecedor) FROM fornecedor"));
        }
        #endregion

        #region Alterar
        public int AlterarFuncionario(Fornecedor fornecedor)
        {
            string queryAlterar =
                "UPDATE funcionario SET " +
                "Nome = @Nome, " +
                "Email = @Email, " +
                "Telefone = @Telefone, " +
                "CNPJ = @CNPJ, " +
                "Endereco = @Endereco " +
                "WHERE IdFornecedor = @IdFornecedor";

            dataBase.LimparParametros();
            dataBase.AdicionarParametros("@Nome", fornecedor.FornecedorNome);
            dataBase.AdicionarParametros("@Email", fornecedor.FornecedorEmail);
            dataBase.AdicionarParametros("@Telefone", fornecedor.FornecedorTel);
            dataBase.AdicionarParametros("@CNPJ", fornecedor.FornecedorCNPJ);
            dataBase.AdicionarParametros("@Endereco", fornecedor.FornecedorEndereco);
            dataBase.AdicionarParametros("@IdFornecedor", fornecedor.IdFornecedor);

            return dataBase.ExecutarManipulacao(
                CommandType.Text, queryAlterar);
        }
        #endregion

        #region Apagar
        public int ApagarFuncionario(int IdFornecedor)
        {
            string queryApagar =
                "DELETE FROM fornecedor " +
                "WHERE IdFuncionario = @IdFuncionario";

            dataBase.LimparParametros();
            dataBase.AdicionarParametros("@IdFornecedor", IdFornecedor);

            return dataBase.ExecutarManipulacao(
                CommandType.Text, queryApagar);
        }
        #endregion

        #region Pesquisar
        public FornecedorCollection PesquisarFornecedorPorNome(string nome)
        {
            FornecedorCollection fornecedorColecao = new FornecedorCollection();
            string query =
                "SELECT * FROM Fornecedor " + "WHERE nome LIKE '%' + @Nome + '%'";

            dataBase.LimparParametros();
            dataBase.AdicionarParametros("@Nome", nome.Trim());

            DataTable dataTable = dataBase.ExecutarConsulta(
                CommandType.Text, query);

            foreach (DataRow dataRow in dataTable.Rows)
            {
                Fornecedor fornecedor = new Fornecedor();

                fornecedor.IdFornecedor = Convert.ToInt32(dataRow["IdFornecedor"]);
                fornecedor.FornecedorNome = Convert.ToString(dataRow["Nome"]);
                fornecedor.FornecedorEmail = Convert.ToString(dataRow["Email"]);
                fornecedor.FornecedorTel = Convert.ToString(dataRow["Telefone"]);
                fornecedor.FornecedorCNPJ = Convert.ToString(dataRow["CNPJ"]);
                fornecedor.FornecedorEndereco = Convert.ToString(dataRow["Endereco"]);

                fornecedorColecao.Add(fornecedor);
            }
            return fornecedorColecao;
        }
        #endregion

        #region PesqusiarAll
        public FuncionarioCollection PesquisarFuncionarioAll()
        {
            FuncionarioCollection funcionarioColecao = new FuncionarioCollection();
            string query =
                "SELECT * FROM funcionario";

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
