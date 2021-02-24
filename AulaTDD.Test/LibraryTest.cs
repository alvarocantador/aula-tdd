using System;
using AulaTDD.interfaces;
using AulaTDD.model;
using NUnit.Framework;

namespace AulaTDD.Test
{

    [TestFixture]
    public class LibraryTest
    {
        /*
            Dado uma biblioteca
            E com livros cadastrados
            Quando requisitado o inventário
            Então deverá ser retornado todos os livros disponíveis

            Dado uma biblioteca
            E um novo livro
            Quando livro for adicionado ao inventário da biblioteca
            Então ele deverá constar na lista de livros disponíveis

            Dado uma biblioteca
            Quando um livro for removido do seu inventário
            Então ele não deverá aparecer na lista de livros disponíveis

            Dado uma biblioteca
            Quando um livro for emprestado
            E ele não existir
            Então um erro deverá ser emitido informando a ausência no inventário

            Dado uma biblioteca
            E com livros no seu inventário
            Quando um livro existente for emprestado
            Então ele deverá ser marcado como indisponível

            Dado uma biblioteca
            E com livros no indisponíveis seu inventário
            Quando um livro existente e indisponível for emprestado
            Então um erro deverá ser emitido informando a situação do livro
        */

        [Test]
        public void Test()
        {

        }

     

    }
}
