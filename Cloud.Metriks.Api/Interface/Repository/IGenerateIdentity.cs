namespace Cloud.Metriks.Api.Interface.Repository
{
    public interface IGenerateIdentity<T>
    {
        Func<T> GetKey();
    }
}