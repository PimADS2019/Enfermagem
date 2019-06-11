using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enfunip.modelo
{
    public class Agenda
    {
        public String nomePaciente { get; set; }
        public DateTime dataHoraAgendamento { get; set; }
        public String localAgendamento { get; set; }
        public String  obsAgendamento { get; set; }
    }
}
