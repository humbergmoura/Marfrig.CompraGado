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
    public void TestConexao(string url)
    {
        var retorno = _service.Connect(url);

        var expected = Assert.Throws<Exception>(() => retorno.Start());

        Assert.Equals(retorno, expected);
    }

    [Test]
    [TestCase("https://localhost:7079/api/Animais/BuscarAnimais")]
    public void TestRetorno(string url)
    {
        var retorno = _service.GetAll(url);

        var ex = Assert.Throws<ArgumentException>(() => retorno.Start());

        Assert.IsNotNull(retorno, ex.Message);
    }

    [Test]
    [TestCase("https://localhost:7079/api/Animais/BuscarAnimalPorId?id=1")]
    [TestCase("https://localhost:7079/api/Animais/BuscarAnimalPorId?id=2")]
    [TestCase("https://localhost:7079/api/Animais/BuscarAnimalPorId?id=5")]
    public void TestRetornoPorId(string url)
    {
        var retorno = _service.GetById(url);

        var ex = Assert.Throws<ArgumentException>(() => retorno.Start());

        Assert.IsNotNull(retorno, ex.Message);
    }

    [Test]
    [TestCase("https://localhost:7079/api/Animais/SalvarAnimal")]
    public void TestNovo(string url)
    {
        _animal.Descricao = "";
        _animal.Preco = 10m;
        _animal.IdPecuarista = 8;
        _animal.Quantidade = 2;

        var retorno = _service.Save(_animal, url);

        var ex = Assert.Throws<ArgumentException>(() => retorno.Start());

        Assert.IsNotNull(retorno, ex.Message);
    }

    [Test]
    [TestCase("https://localhost:7079/api/Animais/AtualizarAnimal")]
    public void TestAtualizar(string url)
    {
        _animal.Id = 0;
        _animal.Descricao = "";
        _animal.Preco = 10m;
        _animal.IdPecuarista = 8;
        _animal.Quantidade = 2;

        var retorno = _service.Save(_animal, url);

        var ex = Assert.Throws<ArgumentException>(() => retorno.Start());

        Assert.IsNotNull(retorno, ex.Message);
    }

    [Test]
    [TestCase("https://localhost:7079/api/Animais/ExcluirAnimal?id=21")]
    [TestCase("https://localhost:7079/api/Animais/ExcluirAnimal?id=22")]
    public void TestExcluir(string url)
    {
        var retorno = _service.Delete(url);

        var ex = Assert.Throws<ArgumentException>(() => retorno.Start());

        Assert.IsNotNull(retorno, ex.Message);
    }
}