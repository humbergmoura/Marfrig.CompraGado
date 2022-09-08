using System.Net;
using UnitTest.Entities;
using UnitTest.Services;

namespace UnitTest;

public class UnitPecuarista
{
    private Service<Pecuarista> _service;
    private Pecuarista _pecuarista;

    [SetUp]
    public void InicializarTeste()
    {
        _service = new Service<Pecuarista>();
        _pecuarista = new Pecuarista();
    }

    [Test]
    [TestCase("https://localhost:7079/api/Pecuarista/BuscarPecuaristas")]
    public void TestConexao(string url)
    {
        var retorno = _service.Connect(url);

        var expected = HttpStatusCode.OK;

        Assert.That(retorno, Is.EqualTo(expected));
    }

    [Test]
    [TestCase("https://localhost:7079/api/Pecuarista/BuscarPecuaristas")]
    public void TestRetorno(string url)
    {
        var retorno = _service.GetAll(url);

        Assert.IsNotNull(retorno);
    }

    [Test]
    [TestCase("https://localhost:7079/api/Pecuarista/BuscarPecuaristaPorId?id=1")]
    [TestCase("https://localhost:7079/api/Pecuarista/BuscarPecuaristaPorId?id=2")]
    [TestCase("https://localhost:7079/api/Pecuarista/BuscarPecuaristaPorId?id=5")]
    public void TestRetornoPorId(string url)
    {
        var retorno = _service.GetById(url);

        Assert.IsNotNull(retorno);
        Assert.IsTrue(retorno != null);
    }

    [Test]
    [TestCase("https://localhost:7079/api/Pecuarista/SalvarPecuarista")]
    public async Task TestNovo(string url)
    {
        _pecuarista.nome = "Novo Pecuarista";

        var retorno = await _service.Save(_pecuarista, url);

        var expected = HttpStatusCode.OK;

        Assert.That(retorno, Is.EqualTo(expected));
    }

    [Test]
    [TestCase("https://localhost:7079/api/Pecuarista/AtualizarPecuarista")]
    public async Task TestAtualizar(string url)
    {
        _pecuarista.id = 0;
        _pecuarista.nome = "Pecuarista João da Silva Borges";

        var retorno = await _service.Update(_pecuarista, url);

        var expected = HttpStatusCode.OK;

        Assert.That(retorno, Is.EqualTo(expected));
    }

    [Test]
    [TestCase("https://localhost:7079/api/Pecuarista/ExcluirPecuarista?id=21")]
    [TestCase("https://localhost:7079/api/Pecuarista/ExcluirPecuarista?id=22")]
    public async Task TestExcluir(string url)
    {
        var retorno = await _service.Delete(url);

        var expected = HttpStatusCode.OK;

        Assert.That(retorno, Is.EqualTo(expected));
    }
}