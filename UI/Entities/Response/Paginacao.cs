namespace UI.Entities.Response;

public class Paginacao
{
    public int PageSize { get; set; }
    public int PageIndex { get; set; }
    public int TotalResult { get; set; }
    public int TotalPages { get; set; }
    public bool HasPrevious { get; set; }
    public bool HasNext { get; set; }
}
