using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formulario
{
    public class Contato
    {
        public int ID { get; set; }
        
        public string Nome { get; set; }

        public string Num { get; set; }

        public string Email { get; set; }

        public DateTime DataRegistro { get; set; }
    }
}
