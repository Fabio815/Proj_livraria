using Proj_livraria.Modelo;

namespace Proj_livraria.Menus;

internal class MostrarDetalhes
{
    public void MostrarDetalhesLivros(Dictionary<string, Livros> listaDeLivros)
    {
        Console.WriteLine("Digite o nome do livro: ");
        string nomeLivro = Console.ReadLine();
        if (listaDeLivros.ContainsKey(nomeLivro))
        {
            Livros livrosRegistrados = listaDeLivros[nomeLivro];

            Console.WriteLine($"Titulo: {livrosRegistrados.Titulo}");
            Console.WriteLine($"Genero: {livrosRegistrados.Genero}");
            Console.WriteLine($"Ano publicação: {livrosRegistrados.AnoPublicacao}");
            Console.WriteLine($"Quantidade: {livrosRegistrados.Quantidade}");
        }
        else
        {
            Console.WriteLine("Livro não encontrado!");
        }
    }
}
