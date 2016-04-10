using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Classes
{
    public class Cliente
    {
        public Int32 id_Cliente { get; set; }
        public String Nome { get; set; }
        public int Idade { get; set; }
        public String Email { get; set; }
        public String Rua { get; set; }
        public String Bairro { get; set; }
        public String Cidade { get; set; }
        public int Numero { get; set; }
        public String Estado { get; set; }

    }
}
