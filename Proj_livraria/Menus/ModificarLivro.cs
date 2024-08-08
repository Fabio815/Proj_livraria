using Proj_livraria.Modelo;

namespace Proj_livraria.Menus;

internal class ModificarLivro
{
    public static void EditarLivro(Dictionary<string, Livros> listaDeLivros)
    {
        Console.Clear();
        Console.Write("Qual livro deseja editar: ");
        string nomeLivro = Console.ReadLine();

        if (listaDeLivros.ContainsKey(nomeLivro))
        {
            Console.WriteLine("O que deseja editar\n" +
                "1 - Titulo\n" +
                "2 - Ano publicaçãon\n" +
                "3 - Autor/Nacionalidade\n" +
                "4 - Genero\n" +
                "5 - Quantidade");
            Console.Write("Opção: ");
            int opcao = int.Parse(Console.ReadLine());

            Livros livro = listaDeLivros[nomeLivro];
            switch (opcao)
            {
                case 1:
                    Console.Write("Digite o novo titulo: ");
                    string tituloLivro = Console.ReadLine();

                    Livros livroTitulo = new Livros(tituloLivro, livro.AnoPublicacao, livro.Genero, livro.Quantidade, livro.Autor);
                    listaDeLivros.Remove(nomeLivro);
                    listaDeLivros.Add(tituloLivro , livroTitulo);
                    Console.WriteLine("Dados modificado com sucesso!");
                    Thread.Sleep(2000);
                    break;
                case 2:
                    Console.Write("Digite o ano: ");
                    int anoPublicacao = int.Parse(Console.ReadLine());

                    Livros livroAno = new Livros(livro.Titulo, anoPublicacao, livro.Genero, livro.Quantidade, livro.Autor);
                    listaDeLivros.Remove(nomeLivro);
                    listaDeLivros.Add(nomeLivro, livroAno);
                    Console.WriteLine("Dados modificado com sucesso!");
                    Thread.Sleep(2000);
                    break;
                case 3:
                    Console.Write("Digite o autor: ");
                    string nomeAutor = Console.ReadLine();
                    Console.Write("Digite a nacionalidade: ");
                    string nacionalidade = Console.ReadLine();
                    Autores autores = new Autores(nomeAutor, nacionalidade);

                    Livros livroAutor = new Livros(livro.Titulo, livro.AnoPublicacao, livro.Genero, livro.Quantidade, autores);
                    listaDeLivros.Remove(nomeLivro);
                    listaDeLivros.Add(nomeLivro, livroAutor);
                    Console.WriteLine("Dados modificado com sucesso!");
                    Thread.Sleep(2000);
                    break;
                case 4:
                    Console.Write("Digite o novo genero: ");
                    string generoLivro = Console.ReadLine();

                    Livros livroGenero = new Livros(livro.Titulo, livro.AnoPublicacao, generoLivro, livro.Quantidade, livro.Autor);
                    listaDeLivros.Remove(nomeLivro);
                    listaDeLivros.Add(nomeLivro, livroGenero);
                    Console.WriteLine("Dados modificado com sucesso!");
                    Thread.Sleep(2000);
                    break;
                case 5:
                    Console.Write("Digite a quantidade: ");
                    int quantidade = int.Parse(Console.ReadLine());

                    Livros livroEditado = new Livros(livro.Titulo, livro.AnoPublicacao, livro.Genero, quantidade, livro.Autor);
                    listaDeLivros.Remove(nomeLivro);
                    listaDeLivros.Add(nomeLivro, livroEditado);
                    Console.WriteLine("Dados modificado com sucesso!");
                    Thread.Sleep(2000);
                    break;
                default:
                    Console.WriteLine("Opção incorreta");
                    break;
            }

        }
        else { Console.WriteLine("Livro não encontrado!"); }
    }
}
