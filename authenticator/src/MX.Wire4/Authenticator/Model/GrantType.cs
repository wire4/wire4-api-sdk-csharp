using System;
namespace MX.Wire4.Authenticator.Model
{

    [Serializable]
    public sealed class GrantType
    {
        public static readonly GrantType GrantTypeKey = new GrantType("grant_type");
        public static readonly GrantType ClientCredentials = new GrantType("client_credentials");
        public static readonly GrantType Password = new GrantType("password");

        public string GrantTypeName { get; set; }

        private GrantType(string grantTypeName)
        {
            this.GrantTypeName = grantTypeName;
        }
    }
}
