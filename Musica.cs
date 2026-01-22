class Musica
{
    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }

    public string Nome { get; }
    public Banda Artista { get; }
    public int Duracao { get; set;  }
    public bool Disponivel { get; set; }
    public string DescricaoResumida => 
        $"{Nome} - {Artista} ({Duracao} segundos)";

    public void ExibirDetalhes()
    {
        string statusDisponivel = Disponivel ? "Sim" : "Não";
        System.Console.WriteLine($"Título: {Nome}");
        System.Console.WriteLine($"Artista: {Artista.Nome}");
        System.Console.WriteLine($"Duração: {Duracao} segundos");
        System.Console.WriteLine($"Disponivel: {statusDisponivel}");
    }
}