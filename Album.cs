using System;
class Album
{
    private List<Musica> musicas = new List<Musica>();

    public Album(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; }
    public int DuracaoTotal =>
        musicas.Sum(m => m.Duracao);

    public void AdicionarMusica(Musica musica)
    {
        if (musica == null) return;
        musicas.Add(musica);
    }

    public void ExibirMusicas()
    {
        int numMusica = 1;

        Console.WriteLine($"Músicas do álbum {Nome}:");
        foreach (var musica in musicas)
        {
            Console.WriteLine($"{numMusica++}: {musica.Nome} - {musica.Duracao}s");
        }

    }
}