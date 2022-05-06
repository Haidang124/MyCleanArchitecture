namespace Infrastructure.CrossCutting.Exception
{
    public class ErrorResponse
    {
        public Error Error { get; set; }
        public string Message { get; set; }
    }

    public class Error
    {
        public const string Auth = "Auth";
        public const string Request = "Request";
        public const string System = "System";
        public string Code { get; set; }
        public string Description { get; set; }
    }
}