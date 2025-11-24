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
    public class ProdutoController
    {
        #region Variaveis Locais
        DataBaseSqlServer dataBase = new DataBaseSqlServer();

        #endregion

        #region Inserir

        public int InserirFuncionario(Produto produto)
        {

            string queryInserir =
                "INSERT produto (Nome, Descricao, Lote, Quantidade, Peso) " +
                "VALUES (@Nome, @Descricao, @Lote, @Quantidade, @Peso)";

            dataBase.LimparParametros();


            dataBase.AdicionarParametros("@Nome", produto.ProdutoNome);
            dataBase.AdicionarParametros("@Descricao", produto.ProdutoDesc);
            dataBase.AdicionarParametros("@Lote", produto.ProdutoLote);
            dataBase.AdicionarParametros("@Quantidade", produto.ProdutoQuantidade);
            dataBase.AdicionarParametros("@Peso", produto.ProdutoPeso);


            dataBase.ExecutarManipulacao(CommandType.Text, queryInserir);
            return Convert.ToInt32(dataBase.ExecutarConsultaScalar(
                CommandType.Text, "SELECT MAX(IdFuncionario) FROM funcionario"));
        }
        #endregion

        #region Alterar
        public int AlterarProduto(Produto produto)
        {
            string queryAlterar =
                "UPDATE produto SET " +
                "Nome = @Nome, " +
                "Descricao = @Descricao, " +
                "Lote = @Lote, " +
                "Quantidade = @Quantidade, " +
                "Peso = @Peso " +
                "WHERE IdProduto = @IdProduto";

            dataBase.LimparParametros();

            dataBase.AdicionarParametros("@Nome", produto.ProdutoNome);
            dataBase.AdicionarParametros("@Descricao", produto.ProdutoDesc);
            dataBase.AdicionarParametros("@Lote", produto.ProdutoLote);
            dataBase.AdicionarParametros("@Quantidade", produto.ProdutoQuantidade);
            dataBase.AdicionarParametros("@Peso", produto.ProdutoPeso);

            dataBase.AdicionarParametros("@IdProduto", produto.IdProduto);

            return dataBase.ExecutarManipulacao(
                CommandType.Text, queryAlterar);
        }
        #endregion

        #region Apagar
        public int ApagarProduto(int IdProduto)
        {
            string queryApagar =
                "DELETE FROM produto " +
                "WHERE IdProduto = @IdProduto";

            dataBase.LimparParametros();

            dataBase.AdicionarParametros("@IdProduto", IdProduto);

            return dataBase.ExecutarManipulacao(
                CommandType.Text, queryApagar);
        }
        #endregion

        #region Pesquisar
        public ProdutoCollection PesquisarProdutoPorNome(string nome)
        {
            ProdutoCollection produtoColecao = new ProdutoCollection();

            string query =
                "SELECT * FROM produto " + "WHERE Nome LIKE @Nome";

            dataBase.LimparParametros();
            dataBase.AdicionarParametros("@Nome", "%" + nome.Trim() + "%");

            DataTable dataTable = dataBase.ExecutarConsulta(
                CommandType.Text, query);

            foreach (DataRow dataRow in dataTable.Rows)
            {
                Produto produto = new Produto();

                produto.IdProduto = Convert.ToInt32(dataRow["IdProduto"]);
                produto.ProdutoNome = Convert.ToString(dataRow["Nome"]);
                produto.ProdutoDesc = Convert.ToString(dataRow["Descricao"]);
                produto.ProdutoLote = Convert.ToString(dataRow["Lote"]);
                produto.ProdutoQuantidade = Convert.ToInt32(dataRow["Quantidade"]);
                produto.ProdutoPeso = Convert.ToInt32(dataRow["Peso"]);


                produtoColecao.Add(produto);
            }
            return produtoColecao;
        }
        #endregion

        #region PesqusiarAll
        public ProdutoCollection PesquisarProdutoAll()
        {
            ProdutoCollection produtoColecao = new ProdutoCollection();

            string query =
                "SELECT * FROM produto";

            DataTable dataTable = dataBase.ExecutarConsulta(
                CommandType.Text, query);

            foreach (DataRow dataRow in dataTable.Rows)
            {
                Produto produto = new Produto();
                produto.IdProduto = Convert.ToInt32(dataRow["IdProduto"]);
                produto.ProdutoNome = Convert.ToString(dataRow["Nome"]);
                produto.ProdutoDesc = Convert.ToString(dataRow["Descricao"]);
                produto.ProdutoLote = Convert.ToString(dataRow["Lote"]);
                produto.ProdutoQuantidade = Convert.ToInt32(dataRow["Quantidade"]);
                produto.ProdutoPeso = Convert.ToInt32(dataRow["Peso"]);

                produtoColecao.Add(produto);
            }
            return produtoColecao;
        }
        #endregion

    }
}
