namespace FlipCart.WebAPI.Model
{
    public class ApiResult
    {
        public bool Success { get; set; }

        public string Message { get; set; }
    }

    public class ApiResult<T> : ApiResult
    {
        public T Resource { get; set; }
    }

    public class Wrapper<T>
    {
        public List<T> Data { get; set; } = new List<T>();

        public string Error { get; set; }
    }
}
