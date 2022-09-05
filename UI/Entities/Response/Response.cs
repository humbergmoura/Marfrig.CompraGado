namespace UI.Entities.Response;

public class Response<T> : Paginacao
{
    public Paginacao Pagination { get; set; } = new Paginacao();
    public bool Success { get; set; }
    public List<T> Data { get; set; }
}
