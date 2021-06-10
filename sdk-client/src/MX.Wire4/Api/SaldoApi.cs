/* 
 * Wire4RestAPI
 *
 * Referencia de la API de Wire4
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using MX.Wire4.Client;
using MX.Wire4.Model;

namespace MX.Wire4.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public interface ISaldoApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Consulta los saldo de una cuenta
        /// </summary>
        /// <remarks>
        /// Obtiene el saldo de un contrato, según las divisas que se manejen en dicho contrato, ya sea peso mexicano (MXP) o dólar estadounidense (USD).
        /// </remarks>
        /// <exception cref="MX.Wire4.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">Header para token</param>
        /// <param name="subscription">Es el identificador de la suscripción a esta API.</param>
        /// <returns>BalanceListResponse</returns>
        BalanceListResponse GetBalanceUsingGET (string authorization, string subscription);

        /// <summary>
        /// Consulta los saldo de una cuenta
        /// </summary>
        /// <remarks>
        /// Obtiene el saldo de un contrato, según las divisas que se manejen en dicho contrato, ya sea peso mexicano (MXP) o dólar estadounidense (USD).
        /// </remarks>
        /// <exception cref="MX.Wire4.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">Header para token</param>
        /// <param name="subscription">Es el identificador de la suscripción a esta API.</param>
        /// <returns>ApiResponse of BalanceListResponse</returns>
        ApiResponse<BalanceListResponse> GetBalanceUsingGETWithHttpInfo (string authorization, string subscription);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Consulta los saldo de una cuenta
        /// </summary>
        /// <remarks>
        /// Obtiene el saldo de un contrato, según las divisas que se manejen en dicho contrato, ya sea peso mexicano (MXP) o dólar estadounidense (USD).
        /// </remarks>
        /// <exception cref="MX.Wire4.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">Header para token</param>
        /// <param name="subscription">Es el identificador de la suscripción a esta API.</param>
        /// <returns>Task of BalanceListResponse</returns>
        System.Threading.Tasks.Task<BalanceListResponse> GetBalanceUsingGETAsync (string authorization, string subscription);

        /// <summary>
        /// Consulta los saldo de una cuenta
        /// </summary>
        /// <remarks>
        /// Obtiene el saldo de un contrato, según las divisas que se manejen en dicho contrato, ya sea peso mexicano (MXP) o dólar estadounidense (USD).
        /// </remarks>
        /// <exception cref="MX.Wire4.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">Header para token</param>
        /// <param name="subscription">Es el identificador de la suscripción a esta API.</param>
        /// <returns>Task of ApiResponse (BalanceListResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<BalanceListResponse>> GetBalanceUsingGETAsyncWithHttpInfo (string authorization, string subscription);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public partial class SaldoApi : ISaldoApi
    {
        private MX.Wire4.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="SaldoApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SaldoApi(String basePath)
        {
            this.Configuration = new MX.Wire4.Client.Configuration { BasePath = basePath };

            ExceptionFactory = MX.Wire4.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SaldoApi"/> class
        /// </summary>
        /// <returns></returns>
        public SaldoApi()
        {
            this.Configuration = MX.Wire4.Client.Configuration.Default;

            ExceptionFactory = MX.Wire4.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SaldoApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public SaldoApi(MX.Wire4.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = MX.Wire4.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = MX.Wire4.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public MX.Wire4.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public MX.Wire4.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Consulta los saldo de una cuenta Obtiene el saldo de un contrato, según las divisas que se manejen en dicho contrato, ya sea peso mexicano (MXP) o dólar estadounidense (USD).
        /// </summary>
        /// <exception cref="MX.Wire4.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">Header para token</param>
        /// <param name="subscription">Es el identificador de la suscripción a esta API.</param>
        /// <returns>BalanceListResponse</returns>
        public BalanceListResponse GetBalanceUsingGET (string authorization, string subscription)
        {
             ApiResponse<BalanceListResponse> localVarResponse = GetBalanceUsingGETWithHttpInfo(authorization, subscription);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Consulta los saldo de una cuenta Obtiene el saldo de un contrato, según las divisas que se manejen en dicho contrato, ya sea peso mexicano (MXP) o dólar estadounidense (USD).
        /// </summary>
        /// <exception cref="MX.Wire4.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">Header para token</param>
        /// <param name="subscription">Es el identificador de la suscripción a esta API.</param>
        /// <returns>ApiResponse of BalanceListResponse</returns>
        public ApiResponse< BalanceListResponse > GetBalanceUsingGETWithHttpInfo (string authorization, string subscription)
        {
            // verify the required parameter 'authorization' is set
            if (authorization == null)
                throw new ApiException(400, "Missing required parameter 'authorization' when calling SaldoApi->GetBalanceUsingGET");
            // verify the required parameter 'subscription' is set
            if (subscription == null)
                throw new ApiException(400, "Missing required parameter 'subscription' when calling SaldoApi->GetBalanceUsingGET");

            var localVarPath = "/subscriptions/{subscription}/balance";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (subscription != null) localVarPathParams.Add("subscription", this.Configuration.ApiClient.ParameterToString(subscription)); // path parameter
            if (authorization != null) localVarHeaderParams.Add("Authorization", this.Configuration.ApiClient.ParameterToString(authorization)); // header parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetBalanceUsingGET", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<BalanceListResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (BalanceListResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(BalanceListResponse)));
        }

        /// <summary>
        /// Consulta los saldo de una cuenta Obtiene el saldo de un contrato, según las divisas que se manejen en dicho contrato, ya sea peso mexicano (MXP) o dólar estadounidense (USD).
        /// </summary>
        /// <exception cref="MX.Wire4.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">Header para token</param>
        /// <param name="subscription">Es el identificador de la suscripción a esta API.</param>
        /// <returns>Task of BalanceListResponse</returns>
        public async System.Threading.Tasks.Task<BalanceListResponse> GetBalanceUsingGETAsync (string authorization, string subscription)
        {
             ApiResponse<BalanceListResponse> localVarResponse = await GetBalanceUsingGETAsyncWithHttpInfo(authorization, subscription);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Consulta los saldo de una cuenta Obtiene el saldo de un contrato, según las divisas que se manejen en dicho contrato, ya sea peso mexicano (MXP) o dólar estadounidense (USD).
        /// </summary>
        /// <exception cref="MX.Wire4.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">Header para token</param>
        /// <param name="subscription">Es el identificador de la suscripción a esta API.</param>
        /// <returns>Task of ApiResponse (BalanceListResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<BalanceListResponse>> GetBalanceUsingGETAsyncWithHttpInfo (string authorization, string subscription)
        {
            // verify the required parameter 'authorization' is set
            if (authorization == null)
                throw new ApiException(400, "Missing required parameter 'authorization' when calling SaldoApi->GetBalanceUsingGET");
            // verify the required parameter 'subscription' is set
            if (subscription == null)
                throw new ApiException(400, "Missing required parameter 'subscription' when calling SaldoApi->GetBalanceUsingGET");

            var localVarPath = "/subscriptions/{subscription}/balance";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (subscription != null) localVarPathParams.Add("subscription", this.Configuration.ApiClient.ParameterToString(subscription)); // path parameter
            if (authorization != null) localVarHeaderParams.Add("Authorization", this.Configuration.ApiClient.ParameterToString(authorization)); // header parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetBalanceUsingGET", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<BalanceListResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (BalanceListResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(BalanceListResponse)));
        }

    }
}
