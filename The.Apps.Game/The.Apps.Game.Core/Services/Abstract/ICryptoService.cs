namespace The.Apps.Game.Core.Services.Abstract
{
    public interface ICryptoService
    {
        string Compute(string plainText, byte[] saltBytes);
        bool Verify(string plainText, string hashValue);
    }
}
