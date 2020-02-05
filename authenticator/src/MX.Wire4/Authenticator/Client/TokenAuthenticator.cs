using System.Net;
using MX.Wire4.Authenticator.Model;
using MX.Wire4.Client;
using Newtonsoft.Json;
using RestSharp;

namespace MX.Wire4.Authenticator.Client
{
    /// <summary>
    /// Represents a set of authentication helpers for token generation
    /// </summary>
    public class TokenAuthenticator : IAuthenticator
	{

		private RestRequest restRequest;

		private RestClient restClient;

		private readonly string ApplicationTokenTemplate = "grant_type={0}&scope={1}";

		private readonly string UserTokenTemplate = "grant_type={0}&scope={1}&username={2}&password={3}";

		private EnvironmentType environment;


		/// <summary>
		/// Initialization of authenticator helper that receive the configuration and a environment
		/// </summary>
		/// <param name="env">Environment for the authenticator </param>
		public TokenAuthenticator(EnvironmentType env)
		{
            
			//configuration = config;
			environment = env;
            Configuration.Default.BasePath = environment.BasePath + environment.ServiceUrl;

            this.restClient = new RestClient(environment.BasePath);
            restRequest = new RestRequest
			{
				Timeout = 30000,
				Method = Method.POST,
				Resource = environment.TokenUrl
			};
		}
		/// <summary>
		/// Method that request an Application Token
		/// </summary>
		/// <param name="request">Object thar includes all information for the token</param>
		/// <returns>return the token data </returns>
		public string GetApplicationToken(TokenRequest request)
		{

			return FormatToHeader(GetToken(request.ClientKey, request.ClientSecret,
				string.Format(ApplicationTokenTemplate, GrantType.ClientCredentials.GrantTypeName, ScopeType.General.ScopeName)).AccessToken);
		}
		/// <summary>
		/// Method that request an Application User Token for Spei Operations
		/// </summary>
		/// <param name="request">Object thar includes all information for the token</param>
		/// <returns>return the token data </returns>
		public string GetApplicationUserToken(TokenRequest request)
		{

			return FormatToHeader(GetToken(request.ClientKey, request.ClientSecret,
				string.Format(UserTokenTemplate, GrantType.Password.GrantTypeName, ScopeType.SpeiAdmin.ScopeName, request.UserKey, request.UserSecret)).AccessToken);
		}
		/// <summary>
		/// Method that request an Application User Token for Spid Operations
		/// </summary>
		/// <param name="request">Object thar includes all information for the token</param>
		/// <returns>return the token data </returns>
		public string GetApplicationUserTokenSpid(TokenRequest request)
		{

			return FormatToHeader(GetToken(request.ClientKey, request.ClientSecret,
				string.Format(UserTokenTemplate, GrantType.Password.GrantTypeName, ScopeType.SpidAdmin.ScopeName, request.UserKey, request.UserSecret)).AccessToken);
		}

		private string FormatToHeader(string token)
		{
			return "Bearer " + token;
		}

		/// <summary>
		/// Method that request a Token
		/// </summary>
		/// <param name="clientKey">Username for token request</param>
		/// <param name="clientSecret">Password for token request</param>
		/// <param name="tokenTemplate">Formatted text that includes all token parameters needed for token request</param>
		/// <returns>return the token data </returns>
		private TokenResponse GetToken(string clientKey, string clientSecret, string tokenTemplate)
		{
			try
			{

                restClient.Authenticator = new HttpBasicAuthenticator(clientKey, clientSecret);

                restRequest.Parameters.Clear();
                restRequest.AddHeader("Accept", "application/json");
                restRequest.AddParameter("application/x-www-form-urlencoded", tokenTemplate, ParameterType.RequestBody);

                IRestResponse response = restClient.Execute(restRequest);
                return JsonConvert.DeserializeObject<TokenResponse>(response.Content);
			}
			catch (System.Exception ex)
			{
				throw new ApiException((int)HttpStatusCode.ExpectationFailed, "An error happened while token was requested, :: " + ex.Message);
			}
		}
	}
}
