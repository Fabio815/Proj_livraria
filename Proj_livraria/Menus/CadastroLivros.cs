using Proj_livraria.Modelo;

namespace Proj_livraria.Menus;

internal class CadastroLivros
{
    public static void AdicionarLivro(Dictionary<string ,Livros> listaDeLivros)
    {
        Console.Clear();
        Console.WriteLine("Cadastro de Livros");
        Console.Write("Titulo: ");
        string titulo = Console.ReadLine()!;
        if (!listaDeLivros.ContainsKey(titulo))
        {

            Console.Write("Ano publicacao: ");
            int anoPublicacao = int.Parse(Console.ReadLine()!);

            Console.Write("Genero: ");
            string genero = Console.ReadLine()!;

            Console.Write("Quantidade: ");
            int quantidade = int.Parse(Console.ReadLine()!);

            Console.Write("Autor: ");
            string autor = Console.ReadLine()!;

            Console.Write("Nacionalidade: ");
            string nacionalidade = Console.ReadLine()!;
            //Adicionando os dados do autor.
            Autores autores = new Autores(autor, nacionalidade);

            Livros livros = new Livros(titulo, anoPublicacao, genero, quantidade, autores);
            //Adicionando o livro ao autor.
            autores.AdicionarLivroAoArtista(livros);

            listaDeLivros.Add(livros.Titulo, livros);
            Console.WriteLine("Dados cadastrado com sucesso!");
            Thread.Sleep(2000);
        }
        else
        {
            Console.WriteLine("Livro já em estoque");
            Thread.Sleep(2000);
        }
    }
}
