using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_Basico.Models
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string ClienteNome   { get; set; }
        public string ClienteEmail {  get; set; }
        public string ClienteTel {  get; set; }
        public string ClienteCPF { get; set; }
        public string ClienteEndereco { get; set; }
        public DateTime ClienteDatNasc {  get; set; }

    }
}
