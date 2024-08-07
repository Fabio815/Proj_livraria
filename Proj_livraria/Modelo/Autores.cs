using System.ComponentModel.DataAnnotations;

namespace Proj_livraria.Modelo;

internal class Autores
{
    List<Livros> livrosDoAutor = new List<Livros>();

    public Autores(string nomeAutor, string nacionalidade)
    {
        var livrosDoAutor = new List<Livros>();
        NomeAutor = nomeAutor;
        Nacionalidade = nacionalidade;
    }
    public string NomeAutor { get; }
    public string Nacionalidade { get; }

    public void AdicionarLivroAoArtista(Livros livro)
    {
        livrosDoAutor.Add(livro);
    }
}
