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
    public class ClienteController
    {
        #region Variaveis Locais
        DataBaseSqlServer dataBase = new DataBaseSqlServer();

        #endregion

        #region Inserir

        public int InserirCliente(Cliente cliente)
        {

            string queryInserir =
                "INSERT INTO cliente (Nome, Email, Telefone, CPF, Endereco, DatNasc) VALUES (@Nome, @Email, @Telefone, @CPF, @Endereco, @DatNasc)";

            dataBase.LimparParametros();

            dataBase.AdicionarParametros("@Nome", cliente.ClienteNome);
            dataBase.AdicionarParametros("@Email", cliente.ClienteEmail);
            dataBase.AdicionarParametros("@Telefone", cliente.ClienteTel);
            dataBase.AdicionarParametros("@CPF", cliente.ClienteCPF);
            dataBase.AdicionarParametros("@Endereco", cliente.ClienteEndereco);
            dataBase.AdicionarParametros("@DatNasc", cliente.ClienteDatNasc);


            dataBase.ExecutarManipulacao(CommandType.Text, queryInserir);
            return Convert.ToInt32(dataBase.ExecutarConsultaScalar(
                CommandType.Text, "SELECT MAX(IdCliente) FROM cliente"));
        }
        #endregion

        #region Alterar
        //Método public alterar
        public int AlterarCliente(Cliente cliente)
        {
            string queryAlterar =
                "UPDATE cliente SET " +
                "Nome = @Nome, " +
                "Email = @Email, " +
                "Telefone = @Telefone, " +
                "CPF = @CPF " +
                "Endereco = @Endereco" +
                "DataNasc = @DataNasc, " +
                "WHERE IdCliente = @IdCliente";

            dataBase.AdicionarParametros("@Nome", cliente.ClienteNome);
            dataBase.AdicionarParametros("@Email", cliente.ClienteEmail);
            dataBase.AdicionarParametros("@Telefone", cliente.ClienteTel);
            dataBase.AdicionarParametros("@CPF", cliente.ClienteCPF);
            dataBase.AdicionarParametros("@Endereco", cliente.ClienteEndereco);
            dataBase.AdicionarParametros("@DatNasc", cliente.ClienteDatNasc);

            return dataBase.ExecutarManipulacao(
                CommandType.Text, queryAlterar);
        }
        #endregion

        #region Apagar
        public int ApagarCliente(int IdCliente)
        {
            string queryApagar =
                "DELETE FROM cliente " +
                "WHERE IdCliente = @IdCliente";

            dataBase.LimparParametros();
            dataBase.AdicionarParametros("@IdCliente", IdCliente);

            return dataBase.ExecutarManipulacao(
                CommandType.Text, queryApagar);
        }
        #endregion

        #region Pesquisar
        public ClienteCollection PesquisarCliente(string nome)
        {
            ClienteCollection clienteColecao = new ClienteCollection();
            string query =
                "SELECT * FROM cliente ";

            dataBase.LimparParametros();
            dataBase.AdicionarParametros("@Nome", nome.Trim());

            DataTable dataTable = dataBase.ExecutarConsulta(
                CommandType.Text, query);

            foreach (DataRow dataRow in dataTable.Rows)
            {
                Cliente cliente = new Cliente();

                cliente.IdCliente = Convert.ToInt32(dataRow["IdCliente"]);
                cliente.ClienteNome = Convert.ToString(dataRow["nome"]);
                cliente.ClienteEmail = Convert.ToString(dataRow["Email"]);
                cliente.ClienteTel = Convert.ToString(dataRow["Telefone"]);
                cliente.ClienteCPF = Convert.ToString(dataRow["CPF"]);
                cliente.ClienteEndereco = Convert.ToString(dataRow["Endereco"]);

                if (!(dataRow["DataNasc"] is DBNull))
                    cliente.ClienteDatNasc =
                        Convert.ToDateTime(dataRow["DataNasc"]);

                clienteColecao.Add(cliente);
            }
            return clienteColecao;
        }
        #endregion

    }
}
