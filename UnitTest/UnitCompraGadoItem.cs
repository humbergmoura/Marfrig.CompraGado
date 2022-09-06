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
    [TestCase("https://localhost:7079/api/CompraGadoItem/BuscarCompraGadoItem")]
    public void TestConexao(string url)
    {
        var retorno = _service.Connect(url);

        var ex = Assert.Throws<ArgumentException>(() => retorno.Start());

        Assert.IsNotNull(retorno, ex.Message);
    }

    [Test]
    [TestCase("https://localhost:7079/api/CompraGadoItem/BuscarCompraGadoItem")]
    public void TestRetorno(string url)
    {
        var retorno = _service.GetAll(url);

        var ex = Assert.Throws<ArgumentException>(() => retorno.Start());

        Assert.IsNotNull(retorno, ex.Message);
    }

    [Test]
    [TestCase("https://localhost:7079/api/CompraGadoItem/BuscarCompraGadoItemPorId?id=1")]
    [TestCase("https://localhost:7079/api/CompraGadoItem/BuscarCompraGadoItemPorId?id=2")]
    [TestCase("https://localhost:7079/api/CompraGadoItem/BuscarCompraGadoItemPorId?id=5")]
    public void TestRetornoPorId(string url)
    {
        var retorno = _service.GetById(url);

        var ex = Assert.Throws<ArgumentException>(() => retorno.Start());

        Assert.IsNotNull(retorno, ex.Message);
    }

    [Test]
    [TestCase("https://localhost:7079/api/CompraGadoItem/SalvarCompraGadoItem")]
    public void TestNovo(string url)
    {
        _compraGadoItem.IdCompraGado = 0;
        _compraGadoItem.IdAnimal = 0;
        _compraGadoItem.Quantidade = 0;

        var retorno = _service.Save(_compraGadoItem, url);

        var ex = Assert.Throws<ArgumentException>(() => retorno.Start());

        Assert.IsNotNull(retorno, ex.Message);
    }

    [Test]
    [TestCase("https://localhost:7079/api/CompraGadoItem/AtualizarCompraGadoItem")]
    public void TestAtualizar(string url)
    {
        _compraGadoItem.Id = 0;
        _compraGadoItem.IdCompraGado = 0;
        _compraGadoItem.IdAnimal = 0;
        _compraGadoItem.Quantidade = 0;

        var retorno = _service.Save(_compraGadoItem, url);

        var ex = Assert.Throws<ArgumentException>(() => retorno.Start());

        Assert.IsNotNull(retorno, ex.Message);
    }

    [Test]
    [TestCase("https://localhost:7079/api/CompraGadoItem/ExcluirCompraGadoItem?id=21")]
    [TestCase("https://localhost:7079/api/CompraGadoItem/ExcluirCompraGadoItem?id=22")]
    public void TestExcluir(string url)
    {
        var retorno = _service.Delete(url);

        var ex = Assert.Throws<ArgumentException>(() => retorno.Start());

        Assert.IsNotNull(retorno, ex.Message);
    }
}