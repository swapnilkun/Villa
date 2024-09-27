namespace FlipCart.Areas.Admin.Models
{
    public class ApiResult<T>
    {
        public T data { get; set; }
        public object error { get; set; }
    }
    public class Result<T>
    {
        public T resource { get; set; }
        public bool success { get; set; }
        public string message { get; set; }
    }       
}
