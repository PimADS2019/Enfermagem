using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enfunip.modelo
{
    public class Estoque
    {
        public int id { get; set; }
        public DateTime dataentrada { get; set; }
        public String produto { get; set; }
        public Int32 quantidade { get; set; }
        public String descricao { get; set; }
    }
}
