using System;

namespace VelocMedia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            string D, T;
            int Velo, Distancia, Tempo;

            Console.WriteLine("----------------------------");
            Console.WriteLine("/ Calculador de Velocidade /");
            Console.WriteLine("----------------------------");
            Console.WriteLine("");

            Console.Write("Distancia Percorrida (m): ");
            D = Console.ReadLine();
            Console.Write("Tempo Gasto (s): ");
            T = Console.ReadLine();

            Distancia = Convert.ToInt32(D);
            Tempo = Convert.ToInt32(T);

            Velo = (Distancia / Tempo);

            Console.WriteLine("");
            Console.WriteLine($"Velocidade Média: {Velo} m/s ");
        }
    }
}
