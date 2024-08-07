using Proj_livraria.Modelo;

namespace Proj_livraria.Menus;

internal class CadastroLivros
{
    public void AdicionarLivro(Dictionary<string ,Livros> listaDeLivros)
    {
        Console.WriteLine("Preencha os dados");
        Console.Write("Titulo: ");
        string titulo = Console.ReadLine();
        Console.Write("Ano publicacao: ");
        int anoPublicacao = int.Parse(Console.ReadLine());
        Console.Write("Genero: ");
        string genero = Console.ReadLine();
        Console.Write("Quantidade: ");
        int quantidade = int.Parse(Console.ReadLine());
        Livros livros = new Livros(titulo, anoPublicacao, genero, quantidade);
        listaDeLivros.Add(livros.Titulo, livros);
        Console.WriteLine("Dados cadastrado com sucesso!");
    }
}
