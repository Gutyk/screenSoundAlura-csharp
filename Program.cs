Album albumDoQueen = new Album();
albumDoQueen.Titulo = "Greatest Hits";

Musica musica1 = new Musica();
musica1.Titulo = "Bohemian Rhapsody";
musica1.Duracao = 354;

Musica musica2 = new Musica();
musica2.Titulo = "Don't Stop Me Now";
musica2.Duracao = 210;

albumDoQueen.AdicionarMusica(musica1);
albumDoQueen.AdicionarMusica(musica2);

albumDoQueen.ExibirMusicas();


Banda bandaQueen = new Banda();
bandaQueen.Nome = "Queen";

bandaQueen.AdicionarAlbum(albumDoQueen);
bandaQueen.ExibirDiscografia();