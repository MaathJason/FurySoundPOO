class Podcast
{
    private List<Episodio> episodioLista = new List<Episodio>();

    public Podcast(string nomePodcast, string nomeHost)
    {
        NomePodcast = nomePodcast;
        HostPodcast = nomeHost;
    }

    public string NomePodcast { get; set; }
    public string HostPodcast { get; set; }
    public int TotalEpisodios => episodioLista.Count();

    public Episodio AdicionarEpisodio(string titulo, int duracao)
    {
        var episodioNumero = TotalEpisodios + 1;
        Episodio episodioAdicionar = new Episodio(titulo, duracao, episodioNumero);

        episodioLista.Add(episodioAdicionar);

        return episodioAdicionar;
    }

    public void ExibirDetalhesPodcast()
    {
        Console.WriteLine($"\nPodcast: {NomePodcast}. Host: {HostPodcast}\n");

        var listaEpisodioOrdenada = episodioLista.OrderBy(x => x.EpisodioNumero);

        Console.Write("Lista de episodios:\n");

        foreach(var item in listaEpisodioOrdenada)
        {
            Console.Write($"\n{item.Resumo}");
        }

        Console.Write($"\nTotal de episodios: {TotalEpisodios}\n");
    }
}