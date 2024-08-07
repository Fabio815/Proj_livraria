using Proj_livraria.Menus;
using Proj_livraria.Modelo;

Dictionary<string, Livros> listaDeLivros = new Dictionary<string, Livros>();

CadastroLivros cadastroLivros = new CadastroLivros();
cadastroLivros.AdicionarLivro(listaDeLivros);
MostrarDetalhes listarLivros = new MostrarDetalhes();
listarLivros.MostrarDetalhesLivros(listaDeLivros);