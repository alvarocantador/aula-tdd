using AulaTDD.interfaces;
using AulaTDD.model;
using NUnit.Framework;

namespace AulaTDD.Test
{

    /*
        Feature: Novo livro
        Dado um livro
        Ao ser criado
        Então ele deverá ser marcado como disponível por padrão

        Feature: Emprestar livro
        Dado um livro disponível
        Ao ser emprestado
        Então ele deverá ser marcado como indisponível

        Feature: Emprestar livro indisponível
        Dado um livro indisponível
        Ao ser emprestado
        Então uma exceção deverá ser lançada informando o seu estado
    */

    [TestFixture]
    public class BookTest
    {


        [Test]
        public void NovoLivro()
        {
            // given
            IBook book = new Book();
            // when
            var isAvailable = book.IsAvailable;
            // then
            Assert.IsTrue(isAvailable);
        }

        [Test]
        public void EmprestarLivro()
        {
            // given
            IBook book = new Book();
            // when
            book.Borrow();
            // then
            Assert.IsFalse(book.IsAvailable);
        }


    }
}
