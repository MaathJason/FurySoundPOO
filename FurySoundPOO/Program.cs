Banda linkinPark = new Banda("Linkin Park");

Album albumLinkinPark = new Album("A Thousand Suns");

Musica musica1 = new Musica(linkinPark, "Waiting for the End")
{
    MusicaDuracao = 231,
    MusicaDisponivel = true
};

Musica musica2 = new Musica(linkinPark, "Burning in the Skies")
{
    MusicaDuracao = 253,
    MusicaDisponivel = false
};

albumLinkinPark.AdicionarMusica(musica1);
albumLinkinPark.AdicionarMusica(musica2);
linkinPark.AdicionarAlbum(albumLinkinPark);

musica1.ExibirInformacoesMusica();
musica2.ExibirInformacoesMusica();
albumLinkinPark.ExibirDiscografia();
linkinPark.ExibirDiscografia();


Podcast podcast1 = new Podcast("Flow Games", "Phoenix");
var episodio1 = podcast1.AdicionarEpisodio("GOTY: Baldur's Gate 3", 420);
episodio1.AdicionarConvidados("Cross");
var episodio2 = podcast1.AdicionarEpisodio("Jogamos o novo Subnatica!", 420);
episodio1.AdicionarConvidados("Davy Jones");
episodio1.AdicionarConvidados("Thais");
podcast1.ExibirDetalhesPodcast();

Podcast podcast2 = new Podcast("B. Sinistra", "Magalzao Show e Vinicin");
var podcast2episodio1 = podcast2.AdicionarEpisodio("ELEGEMOS OS MAIS ENGRAÇADOS DO BRASIL", 450);
podcast2episodio1.AdicionarConvidados("Lucas Inutilismo");
podcast2episodio1.AdicionarConvidados("Italo Sena");
podcast2.ExibirDetalhesPodcast();