using System;

namespace MX.Wire4.Authenticator
{
    [Serializable]
    public sealed class EnvironmentType
    {
        public static readonly EnvironmentType Sandbox = new EnvironmentType("https://sandbox-api.wire4.mx", "/token", "/wire4/1.0.0");

        public static readonly EnvironmentType Production = new EnvironmentType("https://api.wire4.mx", "/token", "/wire4/1.0.0");

        private EnvironmentType(string basePath,string tokenUrl,string serviceUrl)
        {
            BasePath = basePath;
            TokenUrl = tokenUrl;
            ServiceUrl = serviceUrl;
        }

        public string BasePath { get; private set; }
        public string TokenUrl { get; private set; }
        public string ServiceUrl { get; private set; }
    }
}
