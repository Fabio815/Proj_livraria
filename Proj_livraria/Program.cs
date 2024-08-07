using Proj_livraria.Menus;
using Proj_livraria.Modelo;
using System.ComponentModel.Design;

Dictionary<string, Livros> listaDeLivros = new Dictionary<string, Livros>();

void MenuPrincipal()
{
    Console.Clear();
    Console.WriteLine("Sistema de Livros");
    Console.WriteLine("Escolha uma das opções");
    Console.WriteLine("1 - Adicionar livro\n" +
        "2 - Listar todos os livros\n" +
        "3 - Listar apenas um livro\n" +
        "4 - Remover livro\n" +
        "5 - Editar dados do livro\n" +
        "6 - Sair");
    Console.Write("Opção: ");
    int opcao = int.Parse(Console.ReadLine()!);
    switch (opcao)
    {
        case 1:
            CadastroLivros.AdicionarLivro(listaDeLivros);
            MenuPrincipal();
            break;
        case 2:
            ListarLivros.MostrarLivros(listaDeLivros);
            MenuPrincipal();
            break;
        case 3:
            Console.WriteLine("opcao");
            MenuPrincipal();
            break;
        case 4:
            Console.WriteLine("opcao");
            MenuPrincipal();
            break;
        case 5:
            Console.WriteLine("opcao");
            MenuPrincipal();
            break;
        case 6:
            Console.WriteLine("opcao");
            Console.WriteLine("Saindo...");
            break;
        default:
            Console.WriteLine("Opção incorreta!");
            MenuPrincipal();
            break;
    }
}

MenuPrincipal();