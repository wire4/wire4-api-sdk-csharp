using System;
using MX.Wire4.Authenticator.Model;

namespace MX.Wire4.Authenticator.Client
{
    public interface IAuthenticator
    {
        string GetApplicationToken(TokenRequest request);
        string GetApplicationUserToken(TokenRequest request);
        string GetApplicationUserTokenSpid(TokenRequest request);
    }
}
