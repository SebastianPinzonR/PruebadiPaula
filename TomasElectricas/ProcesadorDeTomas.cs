class ProcesadorDeTomas
{
    public List<CasoDePrueba> Casos { get; set; } = new List<CasoDePrueba>();

    public void AgregarCaso(CasoDePrueba caso)
    {
        Casos.Add(caso);
    }

    public void Doit()
    {
        for (int i = 0; i < Casos.Count; i++)
        {
            int resultado = Casos[i].Doit();
            Console.WriteLine($"Caso {i + 1}: {resultado} dispositivos que se pueden conectar");
        }
    }
}
