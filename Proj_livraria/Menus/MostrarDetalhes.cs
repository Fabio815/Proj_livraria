using Proj_livraria.Modelo;

namespace Proj_livraria.Menus;

internal class MostrarDetalhes
{
    public static void MostrarDetalhesLivros(Dictionary<string, Livros> listaDeLivros)
    {
        Console.Clear();
        Console.WriteLine("Digite o nome do livro: ");
        string nomeLivro = Console.ReadLine();
        if (listaDeLivros.ContainsKey(nomeLivro))
        {
            Livros livrosRegistrados = listaDeLivros[nomeLivro];

            Console.WriteLine($"Titulo: {livrosRegistrados.Titulo}");
            Console.WriteLine($"Genero: {livrosRegistrados.Genero}");
            Console.WriteLine($"Ano publicação: {livrosRegistrados.AnoPublicacao}");
            Console.WriteLine($"Quantidade: {livrosRegistrados.Quantidade}\n");
            Console.WriteLine("Digite qualquer tecla para sair.");
            Console.ReadKey();
        }
        else
        {
            Console.WriteLine("Livro não encontrado!");
        }
    }
}
