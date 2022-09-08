using NUnit.Framework.Internal;
using System.Net;
using UnitTest.Entities;
using UnitTest.Services;

namespace UnitTest;

public class UnitAnimal
{
    private Service<Animal> _service;
    private Animal _animal;

    [SetUp]
    public void InicializarTeste()
    {
        _service = new Service<Animal>();
        _animal = new Animal();
    }

    [Test]
    [TestCase("https://localhost:7079/api/Animais/BuscarAnimais")]
    [TestCase("https://localhost:7079/api/animais/buscaranimais")]
    public void TestConexao(string url)
    {
        var retorno = _service.Connect(url);

        var expected = HttpStatusCode.OK;

        Assert.That(retorno, Is.EqualTo(expected));
    }

    [Test]
    [TestCase("https://localhost:7079/api/Animais/BuscarAnimais")]
    public void TestRetorno(string url)
    {
        var retorno = _service.GetAll(url);

        Assert.IsNotNull(retorno);
    }

    [Test]
    [TestCase("https://localhost:7079/api/Animais/BuscarAnimalPorId?id=1")]
    [TestCase("https://localhost:7079/api/Animais/BuscarAnimalPorId?id=2")]
    [TestCase("https://localhost:7079/api/Animais/BuscarAnimalPorId?id=5")]
    public void TestRetornoPorId(string url)
    {
        var retorno = _service.GetById(url);

        Assert.IsNotNull(retorno);
        Assert.IsTrue(retorno != null);
    }

    [Test]
    [TestCase("https://localhost:7079/api/Animais/SalvarAnimal")]
    [TestCase("https://localhost:7079/api/animais/salvarAnimal")]
    public async Task TestNovo(string url)
    {
        _animal.Descricao = "Cacatua";
        _animal.Preco = 1320.85m;
        _animal.IdPecuarista = 10;
        _animal.Quantidade = 320;

        var retorno = await _service.Save(_animal, url);

        var expected = HttpStatusCode.OK;

        Assert.That(retorno, Is.EqualTo(expected));
    }

    [Test]
    [TestCase("https://localhost:7079/api/Animais/AtualizarAnimal")]
    public async Task TestAtualizar(string url)
    {
        _animal.Id = 24;
        _animal.Descricao = "Cacatua";
        _animal.Preco = 1320.85m;
        _animal.IdPecuarista = 10;
        _animal.Quantidade = 320;

        var retorno = await _service.Update(_animal, url);

        var expected = HttpStatusCode.OK;

        Assert.That(retorno, Is.EqualTo(expected));
    }

    [Test]
    [TestCase("https://localhost:7079/api/Animais/ExcluirAnimal?id=28")]
    [TestCase("https://localhost:7079/api/Animais/ExcluirAnimal?id=27")]
    public async Task TestExcluir(string url)
    {
        var retorno = await _service.Delete(url);

        var expected = HttpStatusCode.OK;

        Assert.That(retorno, Is.EqualTo(expected));
    }
}