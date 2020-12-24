using System;
using Interface.Classes;

namespace POO_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Carrinho carrinho = new Carrinho();

            Produto p1 = new Produto();
            p1.Codigo = 1;
            p1.Nome = "GTA V";
            p1.Preco = 2;

            Produto p2 = new Produto();
            p2.Codigo = 2;
            p2.Nome = "Cyberpunk 2077";
            p2.Preco = 3;


            carrinho.Cadastrar(p1);
            carrinho.Listar();

            carrinho.Cadastrar(p2);

            carrinho.Alterar(p1.Codigo, p2);
            carrinho.Listar();
            
        }
    }
}
