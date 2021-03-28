using System;

namespace VelocMedia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            
            int Velo, Distancia, Tempo;

            Console.WriteLine("----------------------------");
            Console.WriteLine("/ Calculador de Velocidade /");
            Console.WriteLine("----------------------------");
            Console.WriteLine("");

            Console.Write("Distancia Percorrida (m): ");
            Distancia = Convert.ToInt32 (Console.ReadLine());
            Console.Write("Tempo Gasto (s): ");
            Tempo = Convert.ToInt32 (Console.ReadLine()); 

            Velo = (Distancia / Tempo);

            Console.WriteLine("");
            Console.WriteLine($"Velocidade Média: {Velo} m/s ");
        }
    }
}
