using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using enfunip.modelo;

namespace enfunip.dao
{
    public interface intEstoquedao
    {
        void CadastrarItem(Estoque estoque);
        Estoque PesquisarItemPorID(Estoque estoque);
        void EditarItem(Estoque estoque);
        void ExcluirItem(Estoque estoque);
        List<Estoque> PesquisarItemPorNome(Estoque estoque);
    }
}
