class Musica
{
    public string Titulo { get; set; }
    public string Artista { get; set; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public string DescricaoResumida => 
        $"{Titulo} - {Artista} ({Duracao} segundos)";

    public void ExibirDetalhes()
    {
        string statusDisponivel = Disponivel ? "Sim" : "Não";
        System.Console.WriteLine($"Título: {Titulo}");
        System.Console.WriteLine($"Artista: {Artista}");
        System.Console.WriteLine($"Duração: {Duracao} segundos");
        System.Console.WriteLine($"Disponivel;: {statusDisponivel}");
    }
}