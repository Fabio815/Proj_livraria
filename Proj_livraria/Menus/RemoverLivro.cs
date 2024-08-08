using Proj_livraria.Modelo;

namespace Proj_livraria.Menus;

internal class RemoverLivro
{
    public static void DeletarLivro(Dictionary<string, Livros> listaDeLivros)
    {
        Console.Clear();
        Console.Write("Digite o nome do livro: ");
        string nomeLivro = Console.ReadLine();

        if (listaDeLivros.ContainsKey(nomeLivro))
        {
            listaDeLivros.Remove(nomeLivro);
            Console.WriteLine("Livro removido com sucesso!");

            Thread.Sleep(2000);
        }
        else
        {
            Console.WriteLine("Livro não encontrado!");
            Thread.Sleep(2000);
        }
    }
}
