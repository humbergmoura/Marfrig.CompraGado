using System.Net;
using UnitTest.Entities;
using UnitTest.Services;

namespace UnitTest;

public class UnitCompraGadoItem
{
    private Service<CompraGadoItem> _service;
    private CompraGadoItem _compraGadoItem;

    [SetUp]
    public void InicializarTeste()
    {
        _service = new Service<CompraGadoItem>();
        _compraGadoItem = new CompraGadoItem();
    }

    [Test]
    [TestCase("https://localhost:7079/api/CompraGadoItem/BuscarCompraGadoItems")]
    public void TestConexao(string url)
    {
        var retorno = _service.Connect(url);

        var expected = HttpStatusCode.OK;

        Assert.That(retorno, Is.EqualTo(expected));
    }

    [Test]
    [TestCase("https://localhost:7079/api/CompraGadoItem/BuscarCompraGadoItems")]
    public void TestRetorno(string url)
    {
        var retorno = _service.GetAll(url);

        Assert.IsNotNull(retorno);
    }

    [Test]
    [TestCase("https://localhost:7079/api/CompraGadoItem/BuscarCompraGadoItemPorId?id=1")]
    [TestCase("https://localhost:7079/api/CompraGadoItem/BuscarCompraGadoItemPorId?id=2")]
    [TestCase("https://localhost:7079/api/CompraGadoItem/BuscarCompraGadoItemPorId?id=5")]
    public void TestRetornoPorId(string url)
    {
        var retorno = _service.GetById(url);

        Assert.IsNotNull(retorno);
        Assert.IsTrue(retorno != null);
    }

    [Test]
    [TestCase("https://localhost:7079/api/CompraGadoItem/SalvarCompraGadoItem")]
    public async Task TestNovo(string url)
    {
        _compraGadoItem.IdCompraGado = 4;
        _compraGadoItem.IdAnimal = 10;
        _compraGadoItem.Quantidade = 100;

        var retorno = await _service.Save(_compraGadoItem, url);

        var expected = HttpStatusCode.OK;

        Assert.That(retorno, Is.EqualTo(expected));
    }

    [Test]
    [TestCase("https://localhost:7079/api/CompraGadoItem/AtualizarCompraGadoItem")]
    public async Task TestAtualizar(string url)
    {
        _compraGadoItem.Id = 23;
        _compraGadoItem.IdCompraGado = 19;
        _compraGadoItem.IdAnimal = 10;
        _compraGadoItem.Quantidade = 110;

        var retorno = await _service.Update(_compraGadoItem, url);

        var expected = HttpStatusCode.OK;

        Assert.That(retorno, Is.EqualTo(expected));
    }

    [Test]
    [TestCase("https://localhost:7079/api/CompraGadoItem/ExcluirCompraGadoItem?id=24")]
    [TestCase("https://localhost:7079/api/CompraGadoItem/ExcluirCompraGadoItem?id=25")]
    public async Task TestExcluir(string url)
    {
        var retorno = await _service.Delete(url);

        var expected = HttpStatusCode.OK;

        Assert.That(retorno, Is.EqualTo(expected));
    }
}