

class Musica
{
    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        MusicaNome = nome;
    }

    public string MusicaNome { get; set; }
    public Banda Artista { get; set; }
    public int MusicaDuracao { get; set; }
    public bool MusicaDisponivel { get; set; }
    public string Descricao =>
        $"A musica {MusicaNome} pertence ao artista {Artista}";
    public Genero Genero { get; set; }

    public void ExibirInformacoesMusica()
    {
        Console.WriteLine($"Nome: {MusicaNome}");

        Console.WriteLine($"Artista: {Artista.NomeBanda}");

        Console.WriteLine($"Duracao: {MusicaDuracao}");

        if (MusicaDisponivel)
        {
            Console.WriteLine("Disponivel no plano");
        }
        else
        {
            Console.WriteLine("Adquira o plano Plus+");
        }
    }

    public void exibirNomeArtista()
    {
        Console.WriteLine($"Nome: {MusicaNome} - Artista: {Artista.NomeBanda}");
    }

}


