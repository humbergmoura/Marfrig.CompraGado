namespace Relatorio.Entities
{
    public class Animal
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }
        public int IdPecuarista { get; set; }
        public string Pecuarista { get; set; }
    }
}