using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Operario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public bool Disponible { get; set; }
        public List<string> Habilidades { get; set; } = new List<string>();
    }
}