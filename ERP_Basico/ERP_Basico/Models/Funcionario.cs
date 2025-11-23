using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_Basico.Models
{
    public class Funcionario
    {
        public int IdFuncionario { get; set; }
        public string FuncionarioNome { get; set; }
        public string FuncionarioEmail {  get; set; }
        public string FuncionarioTel {  get; set; }
        public string FuncionarioCPF { get; set; }
        public string FuncionarioSetor {  get; set; }
        public string FuncionarioEndereco { get; set; }
        public DateTime FuncionarioDatNasc {  get; set; }
        public string FuncionarioUser {  get; set; }
        public string FuncionarioPassword { get; set; }
        public string FuncionarioRole { get; set; }


    }
}
