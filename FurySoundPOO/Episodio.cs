class Episodio
{
    public Episodio(string episodioTitulo, int episodioDuracao, int episodioNumero)
    {
        EpisodioTitulo = episodioTitulo;
        EpisodioDuracao = episodioDuracao;
        EpisodioNumero = episodioNumero;
    }

    public int EpisodioNumero { get; private set; }
    public string EpisodioTitulo { get; set; }
    public int EpisodioDuracao { get; set; }
    public string Resumo =>
        $"Episodio {EpisodioNumero}, Titulo: {EpisodioTitulo}, Duracao: {EpisodioDuracao}, Convidados: {string.Join(",",ListaConvidados)}";
    public List<string> ListaConvidados { get; private set; } = new List<string>();

    public void AdicionarConvidados(string convidados)
    {
        ListaConvidados.Add(convidados);
    }
}