class Album
{
    public Album(string nome)
    {
        Nome = nome ;
    }

    private List<Musica> musicas = new List<Musica>();
    public string Nome { get; set; }
    public int DuracaoTotal => musicas.Sum(m => m.MusicaDuracao);

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void ExibirDiscografia()
    {
        Console.WriteLine($"Lista de musicas do album: {Nome}\n");
        foreach (var musica in musicas)
        {
            Console.WriteLine($"Musica: {musica.MusicaNome}");
        }
        Console.WriteLine($"\nDuração do álbum: {DuracaoTotal} segundos");
    }
}