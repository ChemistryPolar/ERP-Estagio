using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_Basico.Models
{
    public class Pedido
    {
        public int IdPedido { get; set; }
        public string NomeCliente { get; set; }
        public string ProdutoNome { get; set; }
        public string EndrEntre { get; set; }
        public int PedidoValor { get; set; }
        public int DataEntrega { get; set; }
    }
}
