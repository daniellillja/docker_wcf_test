namespace DockerWcf.Host
{
    public class StringService : IStringService
    {
        public int Length(string str)
        {
            return str.Length;
        }

        public string Upper(string str)
        {
            return str.ToUpperInvariant();
        }
    }
}
