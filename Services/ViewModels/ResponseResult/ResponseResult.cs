namespace Services.ViewModels.ResponseResult;

public class ResponseResult<T> 
{
    public Paginacao Pagination { get; set; } = new Paginacao();
    public bool Success { get; set; }
    public List<T> Data { get; set; }
}
