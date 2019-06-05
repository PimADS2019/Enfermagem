using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enfunip.modelo
{
    public class Funcionario
    {
        public int id { get; set; }
        public String tipousuario { get; set; }
        public String usuario { get; set; }
        public String senha { get; set; }
        public String confsenha { get; set; }
        public String nome { get; set; }
        public DateTime datanascimento { get; set; }
        public String cpf { get; set; }
        public String numeroContrato { get; set; }
        public String ra { get; set; }
        public String semestre { get; set; }
        public String periodo { get; set; }
        public String endereco { get; set; }
        public String numero { get; set; }
        public String complemento { get; set; }
        public String cidade { get; set; }
        public String bairro { get; set; }
        public String estado { get; set; }
        public String cep { get; set; }
        public String email { get; set; }
        public String celular { get; set; }
        public String telefone { get; set; }
    }
}
