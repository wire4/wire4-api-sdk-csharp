using System;
using MX.Wire4.Authenticator.Model;

namespace MX.Wire4.Authenticator.Client
{
    public interface IAuthenticator
    {
        string GetApplicationToken(TokenRequest request);
        string GetApplicationUserToken(TokenRequest request);
        string GetApplicationUserTokenSpid(TokenRequest request);
        string GetApplicationToken(TokenRequest request, string scope);
        string GetApplicationUserToken(TokenRequest request, string scope);
        string RegenerateApplicationToken(TokenRequest request);
        string RegenerateApplicationUserToken(TokenRequest request);
        string RegenerateApplicationUserTokenSpid(TokenRequest request);
        string RegenerateApplicationToken(TokenRequest request, string scope);
        string RegenerateApplicationUserToken(TokenRequest request, string scope);
    }
}
