using System;
class Album
{
    private List<Musica> musicas = new List<Musica>();
    public string Titulo { get; set; }
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

        Console.WriteLine($"Músicas do álbum {Titulo}:");
        foreach (var musica in musicas)
        {
            Console.WriteLine($"{numMusica++}: {musica.Titulo}");
        }

    }
}