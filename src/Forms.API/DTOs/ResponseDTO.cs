namespace Forms.API.DTOs
{
    public class ResponseDTO
    {
        public bool Status { get; set; }
        public required string Message { get; set; }
    }

    public class ResponseDTO<T> : ResponseDTO
    {
        public T? Data { get; set; }
    }
}
