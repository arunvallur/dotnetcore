namespace Core6.Models
{
    public class Response<T>
    {
        public T Data { get; set; }

        public List<string> Error { get; set; }

        public bool? IsIssue { get; set; }
    }
}
