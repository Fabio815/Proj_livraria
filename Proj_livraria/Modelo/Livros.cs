using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proj_livraria.Modelo;

internal class Livros
{
    public Livros(string titulo, int anoPublicacao, string genero, int quantidade, Autores autor)
    {
        Titulo = titulo;
        AnoPublicacao = anoPublicacao;
        Genero = genero;
        Quantidade = quantidade;
        Autor = autor;
    }
    public string Titulo { get; }
    public int AnoPublicacao { get; }
    public string Genero { get; }
    public int Quantidade { get; }
    public Autores Autor { get; }

}
