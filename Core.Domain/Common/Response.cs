namespace Core.Domain
{
    public class Response<T>
    {
        public T Data { get; set; }

        public string[] Error { get; set; }

        public bool? IsIssue { get; set; }
    }
}
