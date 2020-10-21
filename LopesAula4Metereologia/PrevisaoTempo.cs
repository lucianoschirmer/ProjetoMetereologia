using System;
using System.Collections.Generic;
using System.Text;

namespace LopesAula4Metereologia
{
    public class PrevisaoTempo
    {

        public void MostrarClima()
        {
            Random random = new Random();            
            Estados estados = new Estados();
            EstadosList estadosList = new EstadosList();
            Temperaturas temperaturas = new Temperaturas();

            List<Estados> listaEstados = estadosList.AdicionaEstados();


            List<Estados> estadosPreenchido = new List<Estados>();

            foreach (Estados estado in listaEstados)
            {                
 
                int valorInferior = 21, valorSuperior = 52;
                int temperaturaMaxima = random.Next(valorInferior, valorSuperior);

                int valorInf = -10, valorSup = 30;
                int temperaturaMinima = random.Next(valorInf, valorSup);

                if (estado.Regiao == Enum.Regiao.Nordeste && temperaturaMinima > 28)
                {
                    temperaturaMinima = 28;                    
                }
                temperaturas.temperaturaMin = temperaturaMinima;
                temperaturas.temperaturaMax = temperaturaMaxima;

                estado.Temperatura = temperaturas;

                estadosPreenchido.Add(estado);

                VerificaClima(estado);
            }
        }

        private EnumClima VerificaClima(Estados estado)
        {

            Random random = new Random();

            List<EnumClima> listaClima = new List<EnumClima>();

            if (estado.Temperatura.temperaturaMax < 4 )
            {
                listaClima.AddRange(new List<EnumClima>() { EnumClima.Nublado, EnumClima.Neve, EnumClima.Chuva });
            }
            if (estado.Temperatura.temperaturaMax < 4)
            {
                listaClima.AddRange(new List<EnumClima>() { EnumClima.Nublado, EnumClima.Neve, EnumClima.Chuva });
            }
            if (estado.Temperatura.temperaturaMin > 4 && estado.Temperatura.temperaturaMax < 20)
            {
                listaClima.AddRange(new List<EnumClima>() { EnumClima.Nublado, EnumClima.Chuva });
            }
            if (estado.Temperatura.temperaturaMin < 21 && estado.Temperatura.temperaturaMax < 28)
            {
                listaClima.AddRange(new List<EnumClima>() { EnumClima.Sol, EnumClima.SolEntreNuvens, EnumClima.Nublado, EnumClima.Chuva });
            }
            if (estado.Temperatura.temperaturaMin > 28)
            {
                listaClima.AddRange(new List<EnumClima>() { EnumClima.Sol, EnumClima.SolEntreNuvens });
            }
            
            int i = random.Next(0, listaClima.Count);

            return listaClima[i];
        } 
    }
}
