using System.Net;
using UnitTest.Entities;
using UnitTest.Services;

namespace UnitTest;

public class UnitCompraGado
{
    private Service<CompraGado> _service;
    private CompraGado _compraGado;

    [SetUp]
    public void InicializarTeste()
    {
        _service = new Service<CompraGado>();
        _compraGado = new CompraGado();
    }

    [Test]
    [TestCase("https://localhost:7079/api/CompraGado/BuscarCompraGado")]
    public void TestConexao(string url)
    {
        var retorno = _service.GetAll(url);

        Assert.IsNotNull(retorno);
    }

    [Test]
    [TestCase("https://localhost:7079/api/CompraGado/BuscarCompraGado")]
    public void TestRetorno(string url)
    {
        var retorno = _service.GetAll(url);

        Assert.IsNotNull(retorno);
    }

    [Test]
    [TestCase("https://localhost:7079/api/CompraGado/BuscarCompraGadoPorId?id=1")]
    [TestCase("https://localhost:7079/api/CompraGado/BuscarCompraGadoPorId?id=2")]
    [TestCase("https://localhost:7079/api/CompraGado/BuscarCompraGadoPorId?id=5")]
    public void TestRetornoPorId(string url)
    {
        var retorno = _service.GetById(url);

        Assert.IsNotNull(retorno);
        Assert.IsTrue(retorno != null);
    }

    [Test]
    [TestCase("https://localhost:7079/api/CompraGado/SalvarCompraGado")]
    [TestCase("https://localhost:7079/api/CompraGado/SalvarCompraGado")]
    public async Task TestNovo(string url)
    {
        _compraGado.IdPecuarista = 8;
        _compraGado.DataEntrega = DateTime.Now;

        var retorno = await _service.Save(_compraGado, url);

        var expected = HttpStatusCode.OK;

        Assert.That(retorno, Is.EqualTo(expected));
    }

    [Test]
    [TestCase("https://localhost:7079/api/CompraGado/AtualizarCompraGado")]
    public async Task TestAtualizar(string url)
    {
        _compraGado.Id = 27;
        _compraGado.IdPecuarista = 10;
        _compraGado.DataEntrega = DateTime.Now;

        var retorno = await _service.Update(_compraGado, url);

        var expected = HttpStatusCode.OK;

        Assert.That(retorno, Is.EqualTo(expected));
    }

    [Test]
    [TestCase("https://localhost:7079/api/CompraGado/ExcluirAnimal?id=29")]
    public async Task TestExcluir(string url)
    {
        var retorno = await _service.Delete(url);

        var expected = HttpStatusCode.OK;

        Assert.That(retorno, Is.EqualTo(expected));
    }
}