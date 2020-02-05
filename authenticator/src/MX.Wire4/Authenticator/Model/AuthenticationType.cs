using System;
namespace MX.Wire4.Authenticator.Model
{
    [Serializable]
    public sealed class AuthenticationType
    {
        public static readonly AuthenticationType ApplicationAuthentication = new AuthenticationType("wire4_aut_app");

        public static readonly AuthenticationType SpeiUserAuthentication = new AuthenticationType("wire4_aut_app_user_spei");

        public static readonly AuthenticationType SpidUserAuthentication = new AuthenticationType("wire4_aut_app_user_spid");

        public string AuthenticationName { get; private set; }

        private AuthenticationType(string AuthenticationName)
        {
            this.AuthenticationName = AuthenticationName;
        }
    }
}
