using System;
using System.Collections.Generic;

class Programa
{
    static void Main()
    {
        //Console.WriteLine("Ingrese el número de casos de prueba:");
        int n = int.Parse(Console.ReadLine()); // Número de casos de prueba
        var procesador = new ProcesadorDeTomas();

        for (int i = 0; i < n; i++)
        {
            //Console.WriteLine($"Caso {i + 1}: Ingrese el número de multitomas seguido de la cantidad de tomas de cada multitoma, ");
            //Console.WriteLine("separados por espacios (ejemplo: 2 2 3):");
            string[] entrada = Console.ReadLine().Split();
            int k = int.Parse(entrada[0]); // Número de multitomas
            var tomasPorMultitoma = new List<int>();
            for (int j = 1; j <= k; j++)
            {
                tomasPorMultitoma.Add(int.Parse(entrada[j]));
            }
            var caso = new CasoDePrueba(k, tomasPorMultitoma);
            procesador.AgregarCaso(caso);
        }

        Console.WriteLine("Resultados:");
        procesador.Doit();
    }
}