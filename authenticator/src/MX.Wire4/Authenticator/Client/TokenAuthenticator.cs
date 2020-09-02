using System;
using System.Net;
using MX.Wire4.Authenticator.Model;
using MX.Wire4.Authenticator.Core;
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
		private static readonly string APPLICATION_TOKEN_TEMPLATE = "grant_type={0}&scope={1}";

		private static readonly string USER_TOKEN_TEMPLATE = "grant_type={0}&scope={1}&username={2}&password={3}";

		private RestRequest restRequest;

		private RestClient restClient;

		private EnvironmentType environment;

		private LRUCache<string, CachedToken> tokensCached;

		/// <summary>
		/// Initialization of authenticator helper that receive the configuration and a environment
		/// </summary>
		/// <param name="env">Environment for the authenticator </param>
		public TokenAuthenticator(EnvironmentType env)
		{

			//configuration = config;
			this.environment = env;
            Configuration.Default.BasePath = this.environment.BasePath + this.environment.ServiceUrl;

            this.restClient = new RestClient(this.environment.BasePath);
			this.restRequest = new RestRequest
			{
				Timeout = 30000,
				Method = Method.POST,
				Resource = environment.TokenUrl
			};

			this.tokensCached = new LRUCache<string, CachedToken>(100);
		}
		/// <summary>
		/// Method that request an Application Token
		/// </summary>
		/// <param name="request">Object that includes all information for the token</param>
		/// <returns>return the token data </returns>
		public string GetApplicationToken(TokenRequest request)
		{
            string keySearch = request.ClientKey + ScopeType.General.ScopeName;
            CachedToken cachedToken = GetCachedToken(keySearch);
            
            string bearer;
            if (cachedToken != null)
            {
                bearer = FormatToHeader(cachedToken.GetToken().AccessToken);
            }
            else
            {
				TokenResponse tokenResponse = GetToken(request.ClientKey, request.ClientSecret, string.Format(
					APPLICATION_TOKEN_TEMPLATE, GrantType.ClientCredentials.GrantTypeName, ScopeType.General.ScopeName));

				this.tokensCached.Add(keySearch, new CachedToken(null, null, tokenResponse));
                bearer = FormatToHeader(tokenResponse.AccessToken);
            }

            return bearer;
		}
		/// <summary>
		/// Method that request an Application User Token for Spei Operations
		/// </summary>
		/// <param name="request">Object that includes all information for the token</param>
		/// <returns>return the token data </returns>
		public string GetApplicationUserToken(TokenRequest request)
		{

			string keySearch = request.UserKey + ScopeType.SpeiAdmin.ScopeName;
			CachedToken cachedToken = GetCachedToken(keySearch);

			string bearer;
			if (cachedToken != null)
			{
				bearer = FormatToHeader(cachedToken.GetToken().AccessToken);
			}
			else
			{
				TokenResponse tokenResponse = GetToken(request.ClientKey, request.ClientSecret, string.Format(
                    USER_TOKEN_TEMPLATE, GrantType.Password.GrantTypeName, ScopeType.SpeiAdmin.ScopeName, request.UserKey, request.UserSecret));

				this.tokensCached.Add(keySearch, new CachedToken(request.UserKey, request.UserSecret, tokenResponse));
				bearer = FormatToHeader(tokenResponse.AccessToken);
			}

			return bearer;
		}
		/// <summary>
		/// Method that request an Application User Token for Spid Operations
		/// </summary>
		/// <param name="request">Object that includes all information for the token</param>
		/// <returns>return the token data </returns>
		public string GetApplicationUserTokenSpid(TokenRequest request)
		{

			string keySearch = request.UserKey + ScopeType.SpidAdmin.ScopeName;
			CachedToken cachedToken = GetCachedToken(keySearch);

			string bearer;
			if (cachedToken != null)
			{
				bearer = FormatToHeader(cachedToken.GetToken().AccessToken);
			}
			else
			{

				TokenResponse tokenResponse = GetToken(request.ClientKey, request.ClientSecret, string.Format(
                    USER_TOKEN_TEMPLATE, GrantType.Password.GrantTypeName, ScopeType.SpidAdmin.ScopeName, request.UserKey, request.UserSecret));

				this.tokensCached.Add(keySearch, new CachedToken(request.UserKey, request.UserSecret, tokenResponse));
				bearer = FormatToHeader(tokenResponse.AccessToken);
			}

			return bearer;
		}
        /// <summary>
		/// Method that request an Application Token
		/// </summary>
		/// <param name="request">Object that includes all information for the token</param>
		/// <param name="scope">Object that includes scope information for the token</param>
		/// <returns>return the token data </returns>
		public string GetApplicationToken(TokenRequest request, string scope)
		{
			string keySearch = request.ClientKey + scope;
			CachedToken cachedToken = GetCachedToken(keySearch);

			string bearer;
			if (cachedToken != null)
			{
				bearer = FormatToHeader(cachedToken.GetToken().AccessToken);
			}
			else
			{
				TokenResponse tokenResponse = GetToken(request.ClientKey, request.ClientSecret, string.Format(
					APPLICATION_TOKEN_TEMPLATE, GrantType.ClientCredentials.GrantTypeName, scope));

				this.tokensCached.Add(keySearch, new CachedToken(null, null, tokenResponse));
				bearer = FormatToHeader(tokenResponse.AccessToken);
			}

			return bearer;
		}
		/// <summary>
		/// Method that request an Application User Token for Spei Operations
		/// </summary>
		/// <param name="request">Object that includes all information for the token</param>
		/// <param name="scope">Object that includes scope information for the token</param>
		/// <returns>return the token data </returns>
		public string GetApplicationUserToken(TokenRequest request, string scope)
		{

			string keySearch = request.UserKey + scope;
			CachedToken cachedToken = GetCachedToken(keySearch);

			string bearer;
			if (cachedToken != null)
			{
				bearer = FormatToHeader(cachedToken.GetToken().AccessToken);
			}
			else
			{
				TokenResponse tokenResponse = GetToken(request.ClientKey, request.ClientSecret, string.Format(
					USER_TOKEN_TEMPLATE, GrantType.Password.GrantTypeName, scope, request.UserKey, request.UserSecret));

				this.tokensCached.Add(keySearch, new CachedToken(request.UserKey, request.UserSecret, tokenResponse));
				bearer = FormatToHeader(tokenResponse.AccessToken);
			}

			return bearer;
		}
		/// <summary>
		/// Obtain the cached token for a user and scope if exist
		/// </summary>
		/// <param name="keySearch">key to search the cached token</param>
		/// <returns>return the token data if exist</returns>
		private CachedToken GetCachedToken(string keySearch)
        {
			CachedToken cachedToken;
			if (this.tokensCached.TryGetValue(keySearch, out cachedToken))
			{
				if (cachedToken == null || cachedToken.GetToken() == null ||
                    DateTime.Compare(cachedToken.GetToken().ExpirationDate, DateTime.Now.AddSeconds(5 * 60 * -1)) < 0)
                {
					cachedToken = null;
                }
			}

			return cachedToken;
		}
		/// <summary>
		/// Formating the header for make petition with the token
		/// </summary>
		/// <param name="token">the token to format to header</param>
		/// <returns>return the token formated for bearer header</returns>
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
				TokenResponse tokenResponse = JsonConvert.DeserializeObject<TokenResponse>(response.Content);

				tokenResponse.ExpirationDate = DateTime.Now.AddSeconds(tokenResponse.ExpiresIn);

				return tokenResponse;
			}
			catch (System.Exception ex)
			{
				throw new ApiException((int)HttpStatusCode.ExpectationFailed, "An error happened while token was requested, :: " + ex.Message);
			}
		}
		/// <summary>
		/// Method that regenerate an Application Token
		/// </summary>
		/// <param name="request">Object that includes all information for the token</param>
		/// <returns>return the token data </returns>
		public string RegenerateApplicationToken(TokenRequest request)
		{
			string keySearch = request.ClientKey + ScopeType.General.ScopeName;

			TokenResponse tokenResponse = GetToken(request.ClientKey, request.ClientSecret, string.Format(
					APPLICATION_TOKEN_TEMPLATE, GrantType.ClientCredentials.GrantTypeName, ScopeType.General.ScopeName));

			this.tokensCached.Add(keySearch, new CachedToken(null, null, tokenResponse));

			return FormatToHeader(tokenResponse.AccessToken);
		}
		/// <summary>
		/// Method that regenerate an Application User Token for Spei Operations
		/// </summary>
		/// <param name="request">Object that includes all information for the token</param>
		/// <returns>return the token data </returns>
		public string RegenerateApplicationUserToken(TokenRequest request)
		{
			string keySearch = request.UserKey + ScopeType.SpeiAdmin.ScopeName;

			TokenResponse tokenResponse = GetToken(request.ClientKey, request.ClientSecret, string.Format(
					USER_TOKEN_TEMPLATE, GrantType.Password.GrantTypeName, ScopeType.SpeiAdmin.ScopeName, request.UserKey, request.UserSecret));

			this.tokensCached.Add(keySearch, new CachedToken(request.UserKey, request.UserSecret, tokenResponse));

			return FormatToHeader(tokenResponse.AccessToken);
		}
		/// <summary>
		/// Method that regenerate an Application User Token for Spid Operations
		/// </summary>
		/// <param name="request">Object that includes all information for the token</param>
		/// <returns>return the token data </returns>
		public string RegenerateApplicationUserTokenSpid(TokenRequest request)
		{
			string keySearch = request.UserKey + ScopeType.SpidAdmin.ScopeName;

			TokenResponse tokenResponse = GetToken(request.ClientKey, request.ClientSecret, string.Format(
					USER_TOKEN_TEMPLATE, GrantType.Password.GrantTypeName, ScopeType.SpidAdmin.ScopeName, request.UserKey, request.UserSecret));

			this.tokensCached.Add(keySearch, new CachedToken(request.UserKey, request.UserSecret, tokenResponse));

			return FormatToHeader(tokenResponse.AccessToken);
		}

		/// <summary>
		/// Method that regenerate an Application Token
		/// </summary>
		/// <param name="request">Object that includes all information for the token</param>
		/// <param name="scope">Object that includes scope information for the token</param>
		/// <returns>return the token data </returns>
		public string RegenerateApplicationToken(TokenRequest request, string scope)
		{
			string keySearch = request.ClientKey + scope;

			TokenResponse tokenResponse = GetToken(request.ClientKey, request.ClientSecret, string.Format(
					APPLICATION_TOKEN_TEMPLATE, GrantType.ClientCredentials.GrantTypeName, scope));

			this.tokensCached.Add(keySearch, new CachedToken(null, null, tokenResponse));

			return FormatToHeader(tokenResponse.AccessToken);
		}
		/// <summary>
		/// Method that regenerate an Application User Token for Spei Operations
		/// </summary>
		/// <param name="request">Object that includes all information for the token</param>
		/// <param name="scope">Object that includes scope information for the token</param>
		/// <returns>return the token data </returns>
		public string RegenerateApplicationUserToken(TokenRequest request, string scope)
		{
			string keySearch = request.UserKey + scope;

			TokenResponse tokenResponse = GetToken(request.ClientKey, request.ClientSecret, string.Format(
					USER_TOKEN_TEMPLATE, GrantType.Password.GrantTypeName, scope, request.UserKey, request.UserSecret));

			this.tokensCached.Add(keySearch, new CachedToken(request.UserKey, request.UserSecret, tokenResponse));

			return FormatToHeader(tokenResponse.AccessToken);
		}
	}
}
