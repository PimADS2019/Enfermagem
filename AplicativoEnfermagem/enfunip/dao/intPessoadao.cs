using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using enfunip.modelo;

namespace enfunip.dao
{
    interface intPessoadao
    {
        void CadastrarPaciente(Paciente paciente);
        Paciente PesquisarPacientePorID(Paciente paciente);
        void EditarPaciente(Paciente paciente);
        void ExcluirPaciente(Paciente paciente);
        List<Paciente> PesquisarPacientePorNome(Paciente paciente);
    }
}
