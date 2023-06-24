using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Cadastro
{
    internal class Pessoa
    {
        public string Nome { get; set; }
        public string Datanascimento { get; set; }
        public string EstadoCivil { get; set; }
        public string Telefone { get; set; }
        public bool CasaPropria { get; set; }
        public bool veiculo { get; set; }
        public char Sexo { get; set; }
    }
}
