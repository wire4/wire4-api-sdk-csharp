using System;
using MX.Wire4.Authenticator.Model;

namespace MX.Wire4.Authenticator.Client
{
    public interface IAuthenticator
    {
        TokenResponse GetApplicationToken(TokenRequest request);
        TokenResponse GetApplicationUserToken(TokenRequest request);
        TokenResponse GetApplicationUserTokenSpid(TokenRequest request);
    }
}
