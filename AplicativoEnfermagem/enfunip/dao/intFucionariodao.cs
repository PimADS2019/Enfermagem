using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using enfunip.modelo;

namespace enfunip.dao
{
    interface intFuncionariodao
    {
        void CadastrarFuncionario(Funcionario funcionario);
        Funcionario PesquisarFuncionarioPorID(Funcionario funcionario);
        void EditarFuncionario(Funcionario funcionario);
        void ExcluirFuncionario(Funcionario funcionario);
        List<Funcionario> PesquisarFuncionarioPorNome(Funcionario funcionario);
    }
}
