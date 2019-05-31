using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enfunip.modelo
{
    public class Paciente //Dados do Paciente
    {
        public int id { get; set; }
        public String nome { get; set; }
        public DateTime datanascimento { get; set; }
        public String cpf { get; set; }
        public String endereco { get; set; }
        public String numero { get; set; }
        public String complemento { get; set; }
        public String cidade { get; set; }
        public String bairro { get; set; }
        public String estado { get; set; }
        public String cep { get; set; }
        public String sexo { get; set; }
        public String estadocivil { get; set; }
        public String religiao { get; set; }
        public String filhos { get; set; }
        public String email { get; set; }
        public String celular { get; set; }
        public String telefone { get; set; }

        //Histórico do paciente
        public String tabagismo { get; set; }
        public String etilismo { get; set; }
        public String diabetes { get; set; }
        public String dislipidemias { get; set; }
        public String cardiovascular { get; set; }
        public String muscoloesqueletica { get; set; }
        public String neurologica { get; set; }
        public String respiratoria { get; set; }
        public String renal { get; set; }
        public String sexual { get; set; }
        public String outros { get; set; }
        //Histórico do paciente - condiçoes frequentes
        public String incourinaria { get; set; }
        public String incofecal { get; set; }
        public String demencia { get; set; }
        public String queda { get; set; }
        public String hospitalizacao { get; set; }
        //Histórico do paciente - familiar
        public String familiardiabetes { get; set; }
        public String familiardislipidemias { get; set; }
        public String familiarneurologica { get; set; }
        public String familiarcardiovascular { get; set; }
        public String familiaroutros { get; set; }
        public String familiarrenal { get; set; }
        //Hábitos do paciente
        public String frutas { get; set; }
        public String leitederivados { get; set; }
        public String legumesverduras { get; set; }
        public String proteinas { get; set; }
        public String massas { get; set; }
        public String liquidos { get; set; }
        public String dormebem { get; set; }
        public String dormepouco { get; set; }
        public String medsono { get; set; }
        public String ativfisica { get; set; }
        public String qlsativfisica { get; set; }
        public int qtdativfisica { get; set; }
        public String vdsexual { get; set; }
        public String mtparceiros { get; set; }
    }
}
