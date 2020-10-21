using LopesAula4Metereologia.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace LopesAula4Metereologia
{
    public class Estados
    {
        public string UF { get; set; }
        public string Estado { get; set; }
        public Regiao Regiao { get; set; }
        public Temperaturas Temperatura { get; set; }
    }
}
