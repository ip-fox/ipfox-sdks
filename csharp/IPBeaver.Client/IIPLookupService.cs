namespace IPFox.Client
{
    public interface IIPLookupService
    {
        Task<Location> GetLocationAsync(string ip);
    }
}