using Proj_livraria.Modelo;

namespace Proj_livraria.Menus;

internal class ListarLivros
{
    public void MostrarLivros(Dictionary<string, Livros> listaDeLivros)
    {
        Console.WriteLine("Listagem de livros:");
        foreach (var livros in listaDeLivros.Keys)
        {
            Console.WriteLine(livros);
        }
    }
}
