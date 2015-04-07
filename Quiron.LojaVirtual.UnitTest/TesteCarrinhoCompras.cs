using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Quiron.LojaVirtual.Dominio.Entidade;

namespace Quiron.LojaVirtual.UnitTest
{
    [TestClass]
    class TesteCarrinhoCompras
    {
        // Teste adicionar itens ao carrinho
        [TestMethod]
        public void AdicionarItensAoCarrinho()
        { 
            Produto produto1 = new Produto
            {
                ProdutoId = 1,
                Nome = "Teste 1"
            };
            Produto produto2 = new Produto
            {
                ProdutoId = 2,
                Nome = "Teste 2"
            };

            Carrinho carrinho = new Carrinho();
            carrinho.AdicionarItem(produto1, 2);
            carrinho.AdicionarItem(produto2, 3);

            ItemCarrinho[] itens = carrinho.ItensCarrinho.ToArray();

            Assert.AreEqual(itens.Length, 2);
        }
    }
}
