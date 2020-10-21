using LopesAula4Metereologia.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace LopesAula4Metereologia
{
    public class EstadosList
    {
        public List<Estados> AdicionaEstados()
        {
            List<Estados> estado = new List<Estados>();
            estado.Add(new Estados() { UF = "SC", Estado = "Santa Catarina", Regiao = Regiao.Sul });
            estado.Add(new Estados() { UF = "PR", Estado = "Parana", Regiao = Regiao.Sul });
            estado.Add(new Estados() { UF = "RS", Estado = "Rio Grande do Sul", Regiao = Regiao.Sul });
            estado.Add(new Estados() { UF = "SP", Estado = "São Paulo", Regiao = Regiao.Sudeste });
            estado.Add(new Estados() { UF = "MG", Estado = "Minas Gerais", Regiao = Regiao.Sudeste });
            estado.Add(new Estados() { UF = "RJ", Estado = "Rio de Janeiro", Regiao = Regiao.Sudeste });
            estado.Add(new Estados() { UF = "ES", Estado = "Espirito Santo", Regiao = Regiao.Sudeste });
            estado.Add(new Estados() { UF = "BA", Estado = "Bahia", Regiao = Regiao.Nordeste });
            estado.Add(new Estados() { UF = "SE", Estado = "Sergipe", Regiao = Regiao.Nordeste });
            estado.Add(new Estados() { UF = "AL", Estado = "Alagoas", Regiao = Regiao.Nordeste });
            estado.Add(new Estados() { UF = "PE", Estado = "Pernambuco", Regiao = Regiao.Nordeste });
            estado.Add(new Estados() { UF = "PB", Estado = "Paraíba", Regiao = Regiao.Nordeste });
            estado.Add(new Estados() { UF = "RN", Estado = "Rio Grande do Norte", Regiao = Regiao.Nordeste });
            estado.Add(new Estados() { UF = "CE", Estado = "Ceará", Regiao = Regiao.Nordeste });
            estado.Add(new Estados() { UF = "PI", Estado = "Piauí", Regiao = Regiao.Nordeste });
            estado.Add(new Estados() { UF = "MA", Estado = "Maranhão", Regiao = Regiao.Nordeste });
            estado.Add(new Estados() { UF = "GO", Estado = "Goiás", Regiao = Regiao.CentroOeste });
            estado.Add(new Estados() { UF = "DF", Estado = "Distrito Federal", Regiao = Regiao.CentroOeste });
            estado.Add(new Estados() { UF = "MS", Estado = "Mato Grosso do Sul", Regiao = Regiao.CentroOeste });
            estado.Add(new Estados() { UF = "MT", Estado = "Mato Grosso", Regiao = Regiao.CentroOeste });
            estado.Add(new Estados() { UF = "PA", Estado = "Pará", Regiao = Regiao.Norte });
            estado.Add(new Estados() { UF = "AC", Estado = "Acre", Regiao = Regiao.Norte });
            estado.Add(new Estados() { UF = "AP", Estado = "Amapá", Regiao = Regiao.Norte });
            estado.Add(new Estados() { UF = "RO", Estado = "Rondônia", Regiao = Regiao.Norte });
            estado.Add(new Estados() { UF = "TO", Estado = "Tocantins", Regiao = Regiao.Norte });

            return estado;
        }
     
    }
}
