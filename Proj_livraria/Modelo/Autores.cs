using System.ComponentModel.DataAnnotations;

namespace Proj_livraria.Modelo;

internal class Autores
{
    List<Livros> livrosDoAutor = new List<Livros>();
    public string NomeAutor { get; set; }
    public string Nacionalidade { get; set; }

    public void AdicionarLivroAoArtista(Livros livro)
    {
        livrosDoAutor.Add(livro);
    }
}
