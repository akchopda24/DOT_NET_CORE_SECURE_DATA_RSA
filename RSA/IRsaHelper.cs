namespace DOT_NET_CORE_SECURE_DATA.RSA
{
    public interface IRsaHelper
    {
        string Encrypt(string text);
        string Decrypt(string encrypted);
    }
}
