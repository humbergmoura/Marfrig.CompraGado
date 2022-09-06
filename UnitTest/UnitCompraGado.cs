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
        var retorno = _service.Connect(url);

        var ex = Assert.Throws<ArgumentException>(() => retorno.Start());

        Assert.IsNotNull(retorno, ex.Message);
    }

    [Test]
    [TestCase("https://localhost:7079/api/CompraGado/BuscarCompraGado")]
    public void TestRetorno(string url)
    {
        var retorno = _service.GetAll(url);

        var ex = Assert.Throws<ArgumentException>(() => retorno.Start());

        Assert.IsNotNull(retorno, ex.Message);
    }

    [Test]
    [TestCase("https://localhost:7079/api/CompraGado/BuscarCompraGadoPorId?id=1")]
    [TestCase("https://localhost:7079/api/CompraGado/BuscarCompraGadoPorId?id=2")]
    [TestCase("https://localhost:7079/api/CompraGado/BuscarCompraGadoPorId?id=5")]
    public void TestRetornoPorId(string url)
    {
        var retorno = _service.GetById(url);

        var ex = Assert.Throws<ArgumentException>(() => retorno.Start());

        Assert.IsNotNull(retorno, ex.Message);
    }

    [Test]
    [TestCase("https://localhost:7079/api/CompraGado/SalvarCompraGado")]
    public void TestNovo(string url)
    {
        _compraGado.IdPecuarista = 0;
        _compraGado.DataEntrega = DateTime.Now;

        var retorno = _service.Save(_compraGado, url);

        var ex = Assert.Throws<ArgumentException>(() => retorno.Start());

        Assert.IsNotNull(retorno, ex.Message);
    }

    [Test]
    [TestCase("https://localhost:7079/api/CompraGado/AtualizarCompraGado")]
    public void TestAtualizar(string url)
    {
        _compraGado.Id = 0;
        _compraGado.IdPecuarista = 0;
        _compraGado.DataEntrega = DateTime.Now;

        var retorno = _service.Save(_compraGado, url);

        var ex = Assert.Throws<ArgumentException>(() => retorno.Start());

        Assert.IsNotNull(retorno, ex.Message);
    }

    [Test]
    [TestCase("https://localhost:7079/api/CompraGado/ExcluirCompraGado?id=21")]
    [TestCase("https://localhost:7079/api/CompraGado/ExcluirCompraGado?id=22")]
    public void TestExcluir(string url)
    {
        var retorno = _service.Delete(url);

        var ex = Assert.Throws<ArgumentException>(() => retorno.Start());

        Assert.IsNotNull(retorno, ex.Message);
    }
}