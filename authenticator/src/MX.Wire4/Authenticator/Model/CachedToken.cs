using System;

namespace MX.Wire4.Authenticator.Model
{
    [Serializable]
    public sealed class CachedToken
    {
        private readonly string userKey;

        private readonly string userSecret;

        private TokenResponse token;

        public CachedToken(string userKey, string userSecret, TokenResponse token)
        {
            this.userKey = userKey;
            this.userSecret = userSecret;
            this.token = token;
        }

        public string GetUserKey()
        {
            return this.userKey;
        }

        public string GetUserSecret()
        {
            return this.userSecret;
        }

        public TokenResponse GetToken()
        {
            return this.token;
        }

        public void SetToken(TokenResponse tokenResponse)
        {
            this.token = tokenResponse;
        }

        public override string ToString()
        {
            return "CachedToken, userKey: " + this.userKey + ",  userSecret: " + this.userSecret
                + ", this.token: " + this.token;
                
        }
    }
}
