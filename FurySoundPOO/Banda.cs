class Banda
{
    private List<Album> albums = new List<Album>();

    public Banda(string nome)
    {
        NomeBanda = nome;
    }

    public string NomeBanda { get; set; }

    public void AdicionarAlbum(Album album)
    {
        albums.Add(album);
    }

    public void ExibirDiscografia()
    {
        Console.WriteLine($"Discografia da banda: {NomeBanda}");

        foreach(var item in albums)
        {
            Console.WriteLine($"Album: {item.Nome}. ({item.DuracaoTotal})");
        }
    }
}