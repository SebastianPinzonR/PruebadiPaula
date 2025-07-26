class CasoDePrueba
{
    public int NumeroDeMultitomas { get; set; }
    public List<int> TomasPorMultitoma { get; set; }

    public CasoDePrueba(int numeroDeMultitomas, List<int> tomasPorMultitoma)
    {
        NumeroDeMultitomas = numeroDeMultitomas;
        TomasPorMultitoma = tomasPorMultitoma;
    }
    
    //Este metodo calcula los electrodomesticos
    public int Doit()
    {
        int totalTomas = 0;
        foreach (var tomas in TomasPorMultitoma)
        {
            totalTomas += tomas;
        }
        return totalTomas - (NumeroDeMultitomas - 1);
    }
}
