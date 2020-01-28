using System;
using Newtonsoft.Json;

namespace MX.Wire4.Authenticator.Model
{
    [Serializable]
    public class TokenResponse
    {
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }

        [JsonProperty("refresh_token")]
        public string RefreshToken { get; set; }

        public string Scope { get; set; }
        [JsonProperty("token_type")]

        public string TokenType { get; set; }

        [JsonProperty("expires_in")]
        public int ExpiresIn { get; set; }

    }
    
}
