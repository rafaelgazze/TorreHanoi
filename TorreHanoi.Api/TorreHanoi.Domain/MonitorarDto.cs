using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorreHanoi.Domain
{
    public class MonitorarDto
    {
        public Guid Id { get; set; }
        public int NumeroMovimentos { get; set; }
        public char Inicio { get; set; }
        public char Fim { get; set; }

    }
}
