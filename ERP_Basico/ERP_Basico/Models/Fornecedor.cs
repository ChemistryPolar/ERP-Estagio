using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_Basico.Models
{
    public class Fornecedor
    {
        public int IdFornecedor { get; set; }
        public string FornecedorNome { get; set; }
        public string FornecedorEmail {  get; set; }
        public string FornecedorTel {  get; set; }
        public string FornecedorCNPJ { get; set; }
        public string FornecedorEndereco { get; set; }


    }
}
