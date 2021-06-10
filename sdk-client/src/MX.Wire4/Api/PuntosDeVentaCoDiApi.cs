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
        public interface IPuntosDeVentaCoDiApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Registro de punto de venta.
        /// </summary>
        /// <remarks>
        /// Se registra un punto de venta (TPV) desde donde se emitarán los cobros CODI®. El punto de venta se debe asociar a un cuenta CLABE registrada previamente ante Banxico para realizar cobros con CODI®.
        /// </remarks>
        /// <exception cref="MX.Wire4.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Es el objeto que contiene información del punto de venta CODI®.</param>
        /// <param name="authorization">Header para token</param>
        /// <param name="companyId">Es el identificador de la empresa.</param>
        /// <returns>SalesPointRespose</returns>
        SalesPointRespose CreateSalesPoint (SalesPointRequest body, string authorization, string companyId);

        /// <summary>
        /// Registro de punto de venta.
        /// </summary>
        /// <remarks>
        /// Se registra un punto de venta (TPV) desde donde se emitarán los cobros CODI®. El punto de venta se debe asociar a un cuenta CLABE registrada previamente ante Banxico para realizar cobros con CODI®.
        /// </remarks>
        /// <exception cref="MX.Wire4.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Es el objeto que contiene información del punto de venta CODI®.</param>
        /// <param name="authorization">Header para token</param>
        /// <param name="companyId">Es el identificador de la empresa.</param>
        /// <returns>ApiResponse of SalesPointRespose</returns>
        ApiResponse<SalesPointRespose> CreateSalesPointWithHttpInfo (SalesPointRequest body, string authorization, string companyId);
        /// <summary>
        /// Consulta de puntos de venta
        /// </summary>
        /// <remarks>
        /// Obtiene los puntos de venta asociados a una empresa en las cuales se hacen operaciones CODI®.
        /// </remarks>
        /// <exception cref="MX.Wire4.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">Header para token</param>
        /// <param name="companyId">Es el identificador de la empresa. Ejemplo: 8838d513-5916-4662-bb30-2448f0f543ed</param>
        /// <returns>List&lt;SalesPointFound&gt;</returns>
        List<SalesPointFound> ObtainSalePoints (string authorization, string companyId);

        /// <summary>
        /// Consulta de puntos de venta
        /// </summary>
        /// <remarks>
        /// Obtiene los puntos de venta asociados a una empresa en las cuales se hacen operaciones CODI®.
        /// </remarks>
        /// <exception cref="MX.Wire4.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">Header para token</param>
        /// <param name="companyId">Es el identificador de la empresa. Ejemplo: 8838d513-5916-4662-bb30-2448f0f543ed</param>
        /// <returns>ApiResponse of List&lt;SalesPointFound&gt;</returns>
        ApiResponse<List<SalesPointFound>> ObtainSalePointsWithHttpInfo (string authorization, string companyId);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Registro de punto de venta.
        /// </summary>
        /// <remarks>
        /// Se registra un punto de venta (TPV) desde donde se emitarán los cobros CODI®. El punto de venta se debe asociar a un cuenta CLABE registrada previamente ante Banxico para realizar cobros con CODI®.
        /// </remarks>
        /// <exception cref="MX.Wire4.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Es el objeto que contiene información del punto de venta CODI®.</param>
        /// <param name="authorization">Header para token</param>
        /// <param name="companyId">Es el identificador de la empresa.</param>
        /// <returns>Task of SalesPointRespose</returns>
        System.Threading.Tasks.Task<SalesPointRespose> CreateSalesPointAsync (SalesPointRequest body, string authorization, string companyId);

        /// <summary>
        /// Registro de punto de venta.
        /// </summary>
        /// <remarks>
        /// Se registra un punto de venta (TPV) desde donde se emitarán los cobros CODI®. El punto de venta se debe asociar a un cuenta CLABE registrada previamente ante Banxico para realizar cobros con CODI®.
        /// </remarks>
        /// <exception cref="MX.Wire4.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Es el objeto que contiene información del punto de venta CODI®.</param>
        /// <param name="authorization">Header para token</param>
        /// <param name="companyId">Es el identificador de la empresa.</param>
        /// <returns>Task of ApiResponse (SalesPointRespose)</returns>
        System.Threading.Tasks.Task<ApiResponse<SalesPointRespose>> CreateSalesPointAsyncWithHttpInfo (SalesPointRequest body, string authorization, string companyId);
        /// <summary>
        /// Consulta de puntos de venta
        /// </summary>
        /// <remarks>
        /// Obtiene los puntos de venta asociados a una empresa en las cuales se hacen operaciones CODI®.
        /// </remarks>
        /// <exception cref="MX.Wire4.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">Header para token</param>
        /// <param name="companyId">Es el identificador de la empresa. Ejemplo: 8838d513-5916-4662-bb30-2448f0f543ed</param>
        /// <returns>Task of List&lt;SalesPointFound&gt;</returns>
        System.Threading.Tasks.Task<List<SalesPointFound>> ObtainSalePointsAsync (string authorization, string companyId);

        /// <summary>
        /// Consulta de puntos de venta
        /// </summary>
        /// <remarks>
        /// Obtiene los puntos de venta asociados a una empresa en las cuales se hacen operaciones CODI®.
        /// </remarks>
        /// <exception cref="MX.Wire4.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">Header para token</param>
        /// <param name="companyId">Es el identificador de la empresa. Ejemplo: 8838d513-5916-4662-bb30-2448f0f543ed</param>
        /// <returns>Task of ApiResponse (List&lt;SalesPointFound&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<SalesPointFound>>> ObtainSalePointsAsyncWithHttpInfo (string authorization, string companyId);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public partial class PuntosDeVentaCoDiApi : IPuntosDeVentaCoDiApi
    {
        private MX.Wire4.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="PuntosDeVentaCoDiApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PuntosDeVentaCoDiApi(String basePath)
        {
            this.Configuration = new MX.Wire4.Client.Configuration { BasePath = basePath };

            ExceptionFactory = MX.Wire4.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PuntosDeVentaCoDiApi"/> class
        /// </summary>
        /// <returns></returns>
        public PuntosDeVentaCoDiApi()
        {
            this.Configuration = MX.Wire4.Client.Configuration.Default;

            ExceptionFactory = MX.Wire4.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PuntosDeVentaCoDiApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public PuntosDeVentaCoDiApi(MX.Wire4.Client.Configuration configuration = null)
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
        /// Registro de punto de venta. Se registra un punto de venta (TPV) desde donde se emitarán los cobros CODI®. El punto de venta se debe asociar a un cuenta CLABE registrada previamente ante Banxico para realizar cobros con CODI®.
        /// </summary>
        /// <exception cref="MX.Wire4.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Es el objeto que contiene información del punto de venta CODI®.</param>
        /// <param name="authorization">Header para token</param>
        /// <param name="companyId">Es el identificador de la empresa.</param>
        /// <returns>SalesPointRespose</returns>
        public SalesPointRespose CreateSalesPoint (SalesPointRequest body, string authorization, string companyId)
        {
             ApiResponse<SalesPointRespose> localVarResponse = CreateSalesPointWithHttpInfo(body, authorization, companyId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Registro de punto de venta. Se registra un punto de venta (TPV) desde donde se emitarán los cobros CODI®. El punto de venta se debe asociar a un cuenta CLABE registrada previamente ante Banxico para realizar cobros con CODI®.
        /// </summary>
        /// <exception cref="MX.Wire4.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Es el objeto que contiene información del punto de venta CODI®.</param>
        /// <param name="authorization">Header para token</param>
        /// <param name="companyId">Es el identificador de la empresa.</param>
        /// <returns>ApiResponse of SalesPointRespose</returns>
        public ApiResponse< SalesPointRespose > CreateSalesPointWithHttpInfo (SalesPointRequest body, string authorization, string companyId)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling PuntosDeVentaCoDiApi->CreateSalesPoint");
            // verify the required parameter 'authorization' is set
            if (authorization == null)
                throw new ApiException(400, "Missing required parameter 'authorization' when calling PuntosDeVentaCoDiApi->CreateSalesPoint");
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling PuntosDeVentaCoDiApi->CreateSalesPoint");

            var localVarPath = "/codi/companies/salespoint";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (companyId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "companyId", companyId)); // query parameter
            if (authorization != null) localVarHeaderParams.Add("Authorization", this.Configuration.ApiClient.ParameterToString(authorization)); // header parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CreateSalesPoint", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SalesPointRespose>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (SalesPointRespose) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SalesPointRespose)));
        }

        /// <summary>
        /// Registro de punto de venta. Se registra un punto de venta (TPV) desde donde se emitarán los cobros CODI®. El punto de venta se debe asociar a un cuenta CLABE registrada previamente ante Banxico para realizar cobros con CODI®.
        /// </summary>
        /// <exception cref="MX.Wire4.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Es el objeto que contiene información del punto de venta CODI®.</param>
        /// <param name="authorization">Header para token</param>
        /// <param name="companyId">Es el identificador de la empresa.</param>
        /// <returns>Task of SalesPointRespose</returns>
        public async System.Threading.Tasks.Task<SalesPointRespose> CreateSalesPointAsync (SalesPointRequest body, string authorization, string companyId)
        {
             ApiResponse<SalesPointRespose> localVarResponse = await CreateSalesPointAsyncWithHttpInfo(body, authorization, companyId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Registro de punto de venta. Se registra un punto de venta (TPV) desde donde se emitarán los cobros CODI®. El punto de venta se debe asociar a un cuenta CLABE registrada previamente ante Banxico para realizar cobros con CODI®.
        /// </summary>
        /// <exception cref="MX.Wire4.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Es el objeto que contiene información del punto de venta CODI®.</param>
        /// <param name="authorization">Header para token</param>
        /// <param name="companyId">Es el identificador de la empresa.</param>
        /// <returns>Task of ApiResponse (SalesPointRespose)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SalesPointRespose>> CreateSalesPointAsyncWithHttpInfo (SalesPointRequest body, string authorization, string companyId)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling PuntosDeVentaCoDiApi->CreateSalesPoint");
            // verify the required parameter 'authorization' is set
            if (authorization == null)
                throw new ApiException(400, "Missing required parameter 'authorization' when calling PuntosDeVentaCoDiApi->CreateSalesPoint");
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling PuntosDeVentaCoDiApi->CreateSalesPoint");

            var localVarPath = "/codi/companies/salespoint";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (companyId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "companyId", companyId)); // query parameter
            if (authorization != null) localVarHeaderParams.Add("Authorization", this.Configuration.ApiClient.ParameterToString(authorization)); // header parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CreateSalesPoint", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SalesPointRespose>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (SalesPointRespose) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SalesPointRespose)));
        }

        /// <summary>
        /// Consulta de puntos de venta Obtiene los puntos de venta asociados a una empresa en las cuales se hacen operaciones CODI®.
        /// </summary>
        /// <exception cref="MX.Wire4.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">Header para token</param>
        /// <param name="companyId">Es el identificador de la empresa. Ejemplo: 8838d513-5916-4662-bb30-2448f0f543ed</param>
        /// <returns>List&lt;SalesPointFound&gt;</returns>
        public List<SalesPointFound> ObtainSalePoints (string authorization, string companyId)
        {
             ApiResponse<List<SalesPointFound>> localVarResponse = ObtainSalePointsWithHttpInfo(authorization, companyId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Consulta de puntos de venta Obtiene los puntos de venta asociados a una empresa en las cuales se hacen operaciones CODI®.
        /// </summary>
        /// <exception cref="MX.Wire4.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">Header para token</param>
        /// <param name="companyId">Es el identificador de la empresa. Ejemplo: 8838d513-5916-4662-bb30-2448f0f543ed</param>
        /// <returns>ApiResponse of List&lt;SalesPointFound&gt;</returns>
        public ApiResponse< List<SalesPointFound> > ObtainSalePointsWithHttpInfo (string authorization, string companyId)
        {
            // verify the required parameter 'authorization' is set
            if (authorization == null)
                throw new ApiException(400, "Missing required parameter 'authorization' when calling PuntosDeVentaCoDiApi->ObtainSalePoints");
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling PuntosDeVentaCoDiApi->ObtainSalePoints");

            var localVarPath = "/codi/companies/salespoint";
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

            if (companyId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "companyId", companyId)); // query parameter
            if (authorization != null) localVarHeaderParams.Add("Authorization", this.Configuration.ApiClient.ParameterToString(authorization)); // header parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ObtainSalePoints", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<SalesPointFound>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (List<SalesPointFound>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<SalesPointFound>)));
        }

        /// <summary>
        /// Consulta de puntos de venta Obtiene los puntos de venta asociados a una empresa en las cuales se hacen operaciones CODI®.
        /// </summary>
        /// <exception cref="MX.Wire4.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">Header para token</param>
        /// <param name="companyId">Es el identificador de la empresa. Ejemplo: 8838d513-5916-4662-bb30-2448f0f543ed</param>
        /// <returns>Task of List&lt;SalesPointFound&gt;</returns>
        public async System.Threading.Tasks.Task<List<SalesPointFound>> ObtainSalePointsAsync (string authorization, string companyId)
        {
             ApiResponse<List<SalesPointFound>> localVarResponse = await ObtainSalePointsAsyncWithHttpInfo(authorization, companyId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Consulta de puntos de venta Obtiene los puntos de venta asociados a una empresa en las cuales se hacen operaciones CODI®.
        /// </summary>
        /// <exception cref="MX.Wire4.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">Header para token</param>
        /// <param name="companyId">Es el identificador de la empresa. Ejemplo: 8838d513-5916-4662-bb30-2448f0f543ed</param>
        /// <returns>Task of ApiResponse (List&lt;SalesPointFound&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<SalesPointFound>>> ObtainSalePointsAsyncWithHttpInfo (string authorization, string companyId)
        {
            // verify the required parameter 'authorization' is set
            if (authorization == null)
                throw new ApiException(400, "Missing required parameter 'authorization' when calling PuntosDeVentaCoDiApi->ObtainSalePoints");
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling PuntosDeVentaCoDiApi->ObtainSalePoints");

            var localVarPath = "/codi/companies/salespoint";
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

            if (companyId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "companyId", companyId)); // query parameter
            if (authorization != null) localVarHeaderParams.Add("Authorization", this.Configuration.ApiClient.ParameterToString(authorization)); // header parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ObtainSalePoints", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<SalesPointFound>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (List<SalesPointFound>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<SalesPointFound>)));
        }

    }
}
