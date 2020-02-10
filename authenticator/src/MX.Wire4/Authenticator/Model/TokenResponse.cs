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
        public long ExpiresIn { get; set; }

        [JsonIgnore]
        public DateTime ExpirationDate { get; set; }

        public override string ToString()
        {
            return "TokenResponse, AccessToken: " + this.AccessToken + ",  RefreshToken: "
                + this.RefreshToken + ", this.Scope: " + this.Scope + ", TokenType: "
                + this.TokenType + ",  ExpiresIn: " + this.ExpiresIn + ",  ExpirationDate: "
                + this.ExpirationDate;
        }
    }
}
