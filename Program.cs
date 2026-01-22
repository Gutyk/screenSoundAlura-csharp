Banda bandaQueen = new Banda("Queen");
Album albumDoQueen = new Album("Greatest Hits");

Musica musica1 = new Musica(bandaQueen, "Bohemian Rhapsody")
{
    Duracao = 354,
    Disponivel = true
};

Musica musica2 = new Musica(bandaQueen, "Don't Stop Me Now")
{
    Duracao = 210,
    Disponivel = false
};

albumDoQueen.AdicionarMusica(musica1);
albumDoQueen.AdicionarMusica(musica2);
bandaQueen.AdicionarAlbum(albumDoQueen);

Console.WriteLine("-------------------");
musica1.ExibirDetalhes();
Console.WriteLine("-------------------");
musica2.ExibirDetalhes();
Console.WriteLine("-------------------");
albumDoQueen.ExibirMusicas();
bandaQueen.ExibirDiscografia();
Console.WriteLine("-------------------");