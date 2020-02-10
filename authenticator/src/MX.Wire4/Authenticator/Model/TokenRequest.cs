using System;

namespace MX.Wire4.Authenticator.Model
{
    [Serializable]
    public class TokenRequest
    {

        public string ClientKey { get; set; }
        public string ClientSecret { get; set; }
        public string UserKey { get; set; }
        public string UserSecret { get; set; }
        public string Authentication  { get; set; }
        public string Scope { get; set; }
    }
}
