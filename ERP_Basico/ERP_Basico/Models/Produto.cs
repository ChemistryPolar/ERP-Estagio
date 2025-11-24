using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_Basico.Models
{
    public class Produto
    {
        public int IdProduto { get; set; }
        public string ProdutoNome { get; set; }
        public string ProdutoDesc {  get; set; }
        public string ProdutoLote { get; set; }
        public int ProdutoQuantidade {  get; set; }
        public int ProdutoPeso { get; set; }


    }
}
