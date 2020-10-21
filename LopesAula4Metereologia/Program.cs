using System;
using System.Threading;
using System.Threading.Tasks;

namespace LopesAula4Metereologia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("By Order of the Peaky Fucking Hello Fuck Worlds!");
            PrevisaoTempo previsaoTempo = new PrevisaoTempo();

            previsaoTempo.MostrarClima();


            Task task = new Task(() =>
            {
                while (true)
                {                    
                    Thread.Sleep(5000);
                }
            });
            task.Start();
        }                            
    }
}
