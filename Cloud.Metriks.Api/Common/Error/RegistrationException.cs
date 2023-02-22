namespace Cloud.Metriks.Api.Common.Error
{
    public class RegistrationException : Exception
    {
        public string Code { get; set; }

        public RegistrationException(string messsage)
            : base(messsage)
        {
        }

        public RegistrationException(string code, string message)
            : base(message)
        {
            Code = code;
        }
    }
}
