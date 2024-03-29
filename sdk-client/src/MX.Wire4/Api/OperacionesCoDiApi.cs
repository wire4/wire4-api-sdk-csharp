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
        public interface IOperacionesCoDiApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Consulta de operaciones
        /// </summary>
        /// <remarks>
        /// Obtiene las operaciones generadas a partir de peticiones de pago CODI® de forma paginada, pudiendo aplicar filtros.
        /// </remarks>
        /// <exception cref="MX.Wire4.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">Header para token</param>
        /// <param name="body">Filtros de busqueda (optional)</param>
        /// <param name="companyId">Es el identificador de empresa CODI®. (optional)</param>
        /// <param name="page">Es el número de pago. (optional, default to 0)</param>
        /// <param name="salesPointId">Es el identificador del punto de venta. (optional)</param>
        /// <param name="size">Es el tamaño de página. (optional, default to 20)</param>
        /// <returns>PagerResponseDto</returns>
        PagerResponseDto ConsultCodiOperations (string authorization, CodiOperationsFiltersRequestDTO body = null, string companyId = null, string page = null, string salesPointId = null, string size = null);

        /// <summary>
        /// Consulta de operaciones
        /// </summary>
        /// <remarks>
        /// Obtiene las operaciones generadas a partir de peticiones de pago CODI® de forma paginada, pudiendo aplicar filtros.
        /// </remarks>
        /// <exception cref="MX.Wire4.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">Header para token</param>
        /// <param name="body">Filtros de busqueda (optional)</param>
        /// <param name="companyId">Es el identificador de empresa CODI®. (optional)</param>
        /// <param name="page">Es el número de pago. (optional, default to 0)</param>
        /// <param name="salesPointId">Es el identificador del punto de venta. (optional)</param>
        /// <param name="size">Es el tamaño de página. (optional, default to 20)</param>
        /// <returns>ApiResponse of PagerResponseDto</returns>
        ApiResponse<PagerResponseDto> ConsultCodiOperationsWithHttpInfo (string authorization, CodiOperationsFiltersRequestDTO body = null, string companyId = null, string page = null, string salesPointId = null, string size = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Consulta de operaciones
        /// </summary>
        /// <remarks>
        /// Obtiene las operaciones generadas a partir de peticiones de pago CODI® de forma paginada, pudiendo aplicar filtros.
        /// </remarks>
        /// <exception cref="MX.Wire4.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">Header para token</param>
        /// <param name="body">Filtros de busqueda (optional)</param>
        /// <param name="companyId">Es el identificador de empresa CODI®. (optional)</param>
        /// <param name="page">Es el número de pago. (optional, default to 0)</param>
        /// <param name="salesPointId">Es el identificador del punto de venta. (optional)</param>
        /// <param name="size">Es el tamaño de página. (optional, default to 20)</param>
        /// <returns>Task of PagerResponseDto</returns>
        System.Threading.Tasks.Task<PagerResponseDto> ConsultCodiOperationsAsync (string authorization, CodiOperationsFiltersRequestDTO body = null, string companyId = null, string page = null, string salesPointId = null, string size = null);

        /// <summary>
        /// Consulta de operaciones
        /// </summary>
        /// <remarks>
        /// Obtiene las operaciones generadas a partir de peticiones de pago CODI® de forma paginada, pudiendo aplicar filtros.
        /// </remarks>
        /// <exception cref="MX.Wire4.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">Header para token</param>
        /// <param name="body">Filtros de busqueda (optional)</param>
        /// <param name="companyId">Es el identificador de empresa CODI®. (optional)</param>
        /// <param name="page">Es el número de pago. (optional, default to 0)</param>
        /// <param name="salesPointId">Es el identificador del punto de venta. (optional)</param>
        /// <param name="size">Es el tamaño de página. (optional, default to 20)</param>
        /// <returns>Task of ApiResponse (PagerResponseDto)</returns>
        System.Threading.Tasks.Task<ApiResponse<PagerResponseDto>> ConsultCodiOperationsAsyncWithHttpInfo (string authorization, CodiOperationsFiltersRequestDTO body = null, string companyId = null, string page = null, string salesPointId = null, string size = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public partial class OperacionesCoDiApi : IOperacionesCoDiApi
    {
        private MX.Wire4.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="OperacionesCoDiApi"/> class.
        /// </summary>
        /// <returns></returns>
        public OperacionesCoDiApi(String basePath)
        {
            this.Configuration = new MX.Wire4.Client.Configuration { BasePath = basePath };

            ExceptionFactory = MX.Wire4.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OperacionesCoDiApi"/> class
        /// </summary>
        /// <returns></returns>
        public OperacionesCoDiApi()
        {
            this.Configuration = MX.Wire4.Client.Configuration.Default;

            ExceptionFactory = MX.Wire4.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OperacionesCoDiApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public OperacionesCoDiApi(MX.Wire4.Client.Configuration configuration = null)
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
        /// Consulta de operaciones Obtiene las operaciones generadas a partir de peticiones de pago CODI® de forma paginada, pudiendo aplicar filtros.
        /// </summary>
        /// <exception cref="MX.Wire4.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">Header para token</param>
        /// <param name="body">Filtros de busqueda (optional)</param>
        /// <param name="companyId">Es el identificador de empresa CODI®. (optional)</param>
        /// <param name="page">Es el número de pago. (optional, default to 0)</param>
        /// <param name="salesPointId">Es el identificador del punto de venta. (optional)</param>
        /// <param name="size">Es el tamaño de página. (optional, default to 20)</param>
        /// <returns>PagerResponseDto</returns>
        public PagerResponseDto ConsultCodiOperations (string authorization, CodiOperationsFiltersRequestDTO body = null, string companyId = null, string page = null, string salesPointId = null, string size = null)
        {
             ApiResponse<PagerResponseDto> localVarResponse = ConsultCodiOperationsWithHttpInfo(authorization, body, companyId, page, salesPointId, size);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Consulta de operaciones Obtiene las operaciones generadas a partir de peticiones de pago CODI® de forma paginada, pudiendo aplicar filtros.
        /// </summary>
        /// <exception cref="MX.Wire4.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">Header para token</param>
        /// <param name="body">Filtros de busqueda (optional)</param>
        /// <param name="companyId">Es el identificador de empresa CODI®. (optional)</param>
        /// <param name="page">Es el número de pago. (optional, default to 0)</param>
        /// <param name="salesPointId">Es el identificador del punto de venta. (optional)</param>
        /// <param name="size">Es el tamaño de página. (optional, default to 20)</param>
        /// <returns>ApiResponse of PagerResponseDto</returns>
        public ApiResponse< PagerResponseDto > ConsultCodiOperationsWithHttpInfo (string authorization, CodiOperationsFiltersRequestDTO body = null, string companyId = null, string page = null, string salesPointId = null, string size = null)
        {
            // verify the required parameter 'authorization' is set
            if (authorization == null)
                throw new ApiException(400, "Missing required parameter 'authorization' when calling OperacionesCoDiApi->ConsultCodiOperations");

            var localVarPath = "/codi/charges";
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

            if (companyId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "company_id", companyId)); // query parameter
            if (page != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page)); // query parameter
            if (salesPointId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "sales_point_id", salesPointId)); // query parameter
            if (size != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "size", size)); // query parameter
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
                Exception exception = ExceptionFactory("ConsultCodiOperations", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PagerResponseDto>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PagerResponseDto) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PagerResponseDto)));
        }

        /// <summary>
        /// Consulta de operaciones Obtiene las operaciones generadas a partir de peticiones de pago CODI® de forma paginada, pudiendo aplicar filtros.
        /// </summary>
        /// <exception cref="MX.Wire4.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">Header para token</param>
        /// <param name="body">Filtros de busqueda (optional)</param>
        /// <param name="companyId">Es el identificador de empresa CODI®. (optional)</param>
        /// <param name="page">Es el número de pago. (optional, default to 0)</param>
        /// <param name="salesPointId">Es el identificador del punto de venta. (optional)</param>
        /// <param name="size">Es el tamaño de página. (optional, default to 20)</param>
        /// <returns>Task of PagerResponseDto</returns>
        public async System.Threading.Tasks.Task<PagerResponseDto> ConsultCodiOperationsAsync (string authorization, CodiOperationsFiltersRequestDTO body = null, string companyId = null, string page = null, string salesPointId = null, string size = null)
        {
             ApiResponse<PagerResponseDto> localVarResponse = await ConsultCodiOperationsAsyncWithHttpInfo(authorization, body, companyId, page, salesPointId, size);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Consulta de operaciones Obtiene las operaciones generadas a partir de peticiones de pago CODI® de forma paginada, pudiendo aplicar filtros.
        /// </summary>
        /// <exception cref="MX.Wire4.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">Header para token</param>
        /// <param name="body">Filtros de busqueda (optional)</param>
        /// <param name="companyId">Es el identificador de empresa CODI®. (optional)</param>
        /// <param name="page">Es el número de pago. (optional, default to 0)</param>
        /// <param name="salesPointId">Es el identificador del punto de venta. (optional)</param>
        /// <param name="size">Es el tamaño de página. (optional, default to 20)</param>
        /// <returns>Task of ApiResponse (PagerResponseDto)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PagerResponseDto>> ConsultCodiOperationsAsyncWithHttpInfo (string authorization, CodiOperationsFiltersRequestDTO body = null, string companyId = null, string page = null, string salesPointId = null, string size = null)
        {
            // verify the required parameter 'authorization' is set
            if (authorization == null)
                throw new ApiException(400, "Missing required parameter 'authorization' when calling OperacionesCoDiApi->ConsultCodiOperations");

            var localVarPath = "/codi/charges";
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

            if (companyId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "company_id", companyId)); // query parameter
            if (page != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page)); // query parameter
            if (salesPointId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "sales_point_id", salesPointId)); // query parameter
            if (size != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "size", size)); // query parameter
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
                Exception exception = ExceptionFactory("ConsultCodiOperations", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PagerResponseDto>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PagerResponseDto) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PagerResponseDto)));
        }

    }
}
