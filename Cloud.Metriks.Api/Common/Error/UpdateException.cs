namespace Cloud.Metriks.Api.Common.Error
{
    public class UpdateException : Exception
    {
        public string Code { get; set; }

        public UpdateException(string messsage)
            : base(messsage)
        {
        }

        public UpdateException(string code, string message)
            : base(message)
        {
            Code = code;
        }
    }
}
