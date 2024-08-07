using Proj_livraria.Modelo;

namespace Proj_livraria.Menus;

internal class ListarLivros
{
    public static void MostrarLivros(Dictionary<string, Livros> listaDeLivros)
    {
        Console.Clear();
        Console.WriteLine("Listagem de livros:\n");
        foreach (var livros in listaDeLivros.Keys)
        {
            Console.WriteLine(livros);
        }
        Console.WriteLine("\nDigite qualquer tecla para sair.");
        Console.ReadKey();
    }
}
