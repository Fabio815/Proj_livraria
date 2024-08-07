using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proj_livraria.Modelo;

internal class Livros
{
    public string Titulo { get; set; }
    public int AnoPublicacao { get; set; }
    public string Genero { get; set; }
    public int Quantidade { get; set; }
}
