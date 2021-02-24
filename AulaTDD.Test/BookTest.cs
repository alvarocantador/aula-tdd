using System;
using AulaTDD.interfaces;
using AulaTDD.model;
using NUnit.Framework;

namespace AulaTDD.Test
{

    [TestFixture]
    public class BookTest
    {
        /*
            Feature: Novo livro
            Dado um livro
            Ao ser criado
            Então ele deverá ser marcado como disponível por padrão
        */
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

        /*
            Feature: Emprestar livro
            Dado um livro disponível
            Ao ser emprestado
            Então ele deverá ser marcado como indisponível
        */
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

        /*
            Feature: Emprestar livro indisponível
            Dado um livro indisponível
            Ao ser emprestado
            Então uma exceção deverá ser lançada informando o seu estado
        */
        [Test]
        public void EmprestarLivroIndisponivel()
        {
            // given
            IBook book = new Book();
            book.Borrow();
            // when
            var ex = Assert.Throws<InvalidOperationException>(() => book.Borrow());
            // then
            Assert.AreEqual("Unable to borrow the current book.", ex.Message);
        }


    }
}
