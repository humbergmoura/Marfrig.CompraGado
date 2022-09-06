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
    [TestCase("https://localhost:7079/api/Pecuarista/BuscarPecuarista")]
    public void TestConexao(string url)
    {
        var retorno = _service.Connect(url);

        var ex = Assert.Throws<ArgumentException>(() => retorno.Start());

        Assert.IsNotNull(retorno, ex.Message);
    }

    [Test]
    [TestCase("https://localhost:7079/api/Pecuarista/BuscarPecuaristas")]
    public void TestRetorno(string url)
    {
        var retorno = _service.GetAll(url);

        var ex = Assert.Throws<ArgumentException>(() => retorno.Start());

        Assert.IsNotNull(retorno, ex.Message);
    }

    [Test]
    [TestCase("https://localhost:7079/api/Pecuarista/BuscarPecuaristaPorId?id=1")]
    [TestCase("https://localhost:7079/api/Pecuarista/BuscarPecuaristaPorId?id=2")]
    [TestCase("https://localhost:7079/api/Pecuarista/BuscarPecuaristaPorId?id=5")]
    public void TestRetornoPorId(string url)
    {
        var retorno = _service.GetById(url);

        var ex = Assert.Throws<ArgumentException>(() => retorno.Start());

        Assert.IsNotNull(retorno, ex.Message);
    }

    [Test]
    [TestCase("https://localhost:7079/api/Pecuarista/SalvarPecuarista")]
    public void TestNovo(string url)
    {
        _pecuarista.nome = "";

        var retorno = _service.Save(_pecuarista, url);

        var ex = Assert.Throws<ArgumentException>(() => retorno.Start());

        Assert.IsNotNull(retorno, ex.Message);
    }

    [Test]
    [TestCase("https://localhost:7079/api/Pecuarista/AtualizarPecuarista")]
    public void TestAtualizar(string url)
    {
        _pecuarista.id = 0;
        _pecuarista.nome = "";

        var retorno = _service.Save(_pecuarista, url);

        var ex = Assert.Throws<ArgumentException>(() => retorno.Start());

        Assert.IsNotNull(retorno, ex.Message);
    }

    [Test]
    [TestCase("https://localhost:7079/api/Pecuarista/ExcluirPecuarista?id=21")]
    [TestCase("https://localhost:7079/api/Pecuarista/ExcluirPecuarista?id=22")]
    public void TestExcluir(string url)
    {
        var retorno = _service.Delete(url);

        var ex = Assert.Throws<ArgumentException>(() => retorno.Start());

        Assert.IsNotNull(retorno, ex.Message);
    }
}