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
        public int AlterarFornecedor(Fornecedor fornecedor)
        {
            string queryAlterar =
                "UPDATE fornecedor SET " +
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
        public int ApagarFornecedor(int IdFornecedor)
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

        public FornecedorCollection PesquisarFornecedorAll()
        {
            FornecedorCollection fornecedorColecao = new FornecedorCollection();
            string query =
                "SELECT * FROM fornecedor";

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

    }
}
