
public class Livro
{
    public int Id { get; set; }
    public string Titulo { get; set; }
    public string Editora { get; set; }
    public int AnoDePublicacao { get; set; }
    public string Autor { get; set; }
    public string GeneroLiterario { get; set; }
    public string Sinopse { get; set; }
    public double PrecoDoLivro { get; set; }

    public Livro(
    string titulo,
    string editora,
    int anodepublicacao,
    string autor,
    string generoliterario,
    string sinopse,
    double precodolivro

    )
    {
        Titulo = titulo;
        Editora = editora;
        AnoDePublicacao = anodepublicacao;
        Autor = autor;
        GeneroLiterario = generoliterario;
        Sinopse = sinopse;
        PrecoDoLivro = precodolivro;
    }

}

