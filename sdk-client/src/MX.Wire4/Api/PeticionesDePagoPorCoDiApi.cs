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
        public interface IPeticionesDePagoPorCoDiApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Obtiene la información de una petición de pago CODI® por orderId para un punto de venta
        /// </summary>
        /// <remarks>
        /// Obtiene la información de una petición de pago CODI® por orderId para un punto de venta
        /// </remarks>
        /// <exception cref="MX.Wire4.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">Header para token</param>
        /// <param name="orderId">Identificador del pago CODI®</param>
        /// <param name="salesPointId">Identificador del punto de venta</param>
        /// <returns>PaymentRequestCodiResponseDTO</returns>
        PaymentRequestCodiResponseDTO ConsultCodiRequestByOrderId (string authorization, string orderId, string salesPointId);

        /// <summary>
        /// Obtiene la información de una petición de pago CODI® por orderId para un punto de venta
        /// </summary>
        /// <remarks>
        /// Obtiene la información de una petición de pago CODI® por orderId para un punto de venta
        /// </remarks>
        /// <exception cref="MX.Wire4.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">Header para token</param>
        /// <param name="orderId">Identificador del pago CODI®</param>
        /// <param name="salesPointId">Identificador del punto de venta</param>
        /// <returns>ApiResponse of PaymentRequestCodiResponseDTO</returns>
        ApiResponse<PaymentRequestCodiResponseDTO> ConsultCodiRequestByOrderIdWithHttpInfo (string authorization, string orderId, string salesPointId);
        /// <summary>
        /// Genera un código QR para un pago mediante CODI®
        /// </summary>
        /// <remarks>
        /// Genera un código QR solicitado por un punto de venta para un pago mediante CODI®
        /// </remarks>
        /// <exception cref="MX.Wire4.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Información del pago CODI®</param>
        /// <param name="authorization">Header para token</param>
        /// <param name="salesPointId">Identificador del punto de venta</param>
        /// <returns>CodiCodeQrResponseDTO</returns>
        CodiCodeQrResponseDTO GenerateCodiCodeQR (CodiCodeRequestDTO body, string authorization, string salesPointId);

        /// <summary>
        /// Genera un código QR para un pago mediante CODI®
        /// </summary>
        /// <remarks>
        /// Genera un código QR solicitado por un punto de venta para un pago mediante CODI®
        /// </remarks>
        /// <exception cref="MX.Wire4.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Información del pago CODI®</param>
        /// <param name="authorization">Header para token</param>
        /// <param name="salesPointId">Identificador del punto de venta</param>
        /// <returns>ApiResponse of CodiCodeQrResponseDTO</returns>
        ApiResponse<CodiCodeQrResponseDTO> GenerateCodiCodeQRWithHttpInfo (CodiCodeRequestDTO body, string authorization, string salesPointId);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Obtiene la información de una petición de pago CODI® por orderId para un punto de venta
        /// </summary>
        /// <remarks>
        /// Obtiene la información de una petición de pago CODI® por orderId para un punto de venta
        /// </remarks>
        /// <exception cref="MX.Wire4.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">Header para token</param>
        /// <param name="orderId">Identificador del pago CODI®</param>
        /// <param name="salesPointId">Identificador del punto de venta</param>
        /// <returns>Task of PaymentRequestCodiResponseDTO</returns>
        System.Threading.Tasks.Task<PaymentRequestCodiResponseDTO> ConsultCodiRequestByOrderIdAsync (string authorization, string orderId, string salesPointId);

        /// <summary>
        /// Obtiene la información de una petición de pago CODI® por orderId para un punto de venta
        /// </summary>
        /// <remarks>
        /// Obtiene la información de una petición de pago CODI® por orderId para un punto de venta
        /// </remarks>
        /// <exception cref="MX.Wire4.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">Header para token</param>
        /// <param name="orderId">Identificador del pago CODI®</param>
        /// <param name="salesPointId">Identificador del punto de venta</param>
        /// <returns>Task of ApiResponse (PaymentRequestCodiResponseDTO)</returns>
        System.Threading.Tasks.Task<ApiResponse<PaymentRequestCodiResponseDTO>> ConsultCodiRequestByOrderIdAsyncWithHttpInfo (string authorization, string orderId, string salesPointId);
        /// <summary>
        /// Genera un código QR para un pago mediante CODI®
        /// </summary>
        /// <remarks>
        /// Genera un código QR solicitado por un punto de venta para un pago mediante CODI®
        /// </remarks>
        /// <exception cref="MX.Wire4.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Información del pago CODI®</param>
        /// <param name="authorization">Header para token</param>
        /// <param name="salesPointId">Identificador del punto de venta</param>
        /// <returns>Task of CodiCodeQrResponseDTO</returns>
        System.Threading.Tasks.Task<CodiCodeQrResponseDTO> GenerateCodiCodeQRAsync (CodiCodeRequestDTO body, string authorization, string salesPointId);

        /// <summary>
        /// Genera un código QR para un pago mediante CODI®
        /// </summary>
        /// <remarks>
        /// Genera un código QR solicitado por un punto de venta para un pago mediante CODI®
        /// </remarks>
        /// <exception cref="MX.Wire4.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Información del pago CODI®</param>
        /// <param name="authorization">Header para token</param>
        /// <param name="salesPointId">Identificador del punto de venta</param>
        /// <returns>Task of ApiResponse (CodiCodeQrResponseDTO)</returns>
        System.Threading.Tasks.Task<ApiResponse<CodiCodeQrResponseDTO>> GenerateCodiCodeQRAsyncWithHttpInfo (CodiCodeRequestDTO body, string authorization, string salesPointId);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public partial class PeticionesDePagoPorCoDiApi : IPeticionesDePagoPorCoDiApi
    {
        private MX.Wire4.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="PeticionesDePagoPorCoDiApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PeticionesDePagoPorCoDiApi(String basePath)
        {
            this.Configuration = new MX.Wire4.Client.Configuration { BasePath = basePath };

            ExceptionFactory = MX.Wire4.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PeticionesDePagoPorCoDiApi"/> class
        /// </summary>
        /// <returns></returns>
        public PeticionesDePagoPorCoDiApi()
        {
            this.Configuration = MX.Wire4.Client.Configuration.Default;

            ExceptionFactory = MX.Wire4.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PeticionesDePagoPorCoDiApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public PeticionesDePagoPorCoDiApi(MX.Wire4.Client.Configuration configuration = null)
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
        /// Obtiene la información de una petición de pago CODI® por orderId para un punto de venta Obtiene la información de una petición de pago CODI® por orderId para un punto de venta
        /// </summary>
        /// <exception cref="MX.Wire4.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">Header para token</param>
        /// <param name="orderId">Identificador del pago CODI®</param>
        /// <param name="salesPointId">Identificador del punto de venta</param>
        /// <returns>PaymentRequestCodiResponseDTO</returns>
        public PaymentRequestCodiResponseDTO ConsultCodiRequestByOrderId (string authorization, string orderId, string salesPointId)
        {
             ApiResponse<PaymentRequestCodiResponseDTO> localVarResponse = ConsultCodiRequestByOrderIdWithHttpInfo(authorization, orderId, salesPointId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Obtiene la información de una petición de pago CODI® por orderId para un punto de venta Obtiene la información de una petición de pago CODI® por orderId para un punto de venta
        /// </summary>
        /// <exception cref="MX.Wire4.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">Header para token</param>
        /// <param name="orderId">Identificador del pago CODI®</param>
        /// <param name="salesPointId">Identificador del punto de venta</param>
        /// <returns>ApiResponse of PaymentRequestCodiResponseDTO</returns>
        public ApiResponse< PaymentRequestCodiResponseDTO > ConsultCodiRequestByOrderIdWithHttpInfo (string authorization, string orderId, string salesPointId)
        {
            // verify the required parameter 'authorization' is set
            if (authorization == null)
                throw new ApiException(400, "Missing required parameter 'authorization' when calling PeticionesDePagoPorCoDiApi->ConsultCodiRequestByOrderId");
            // verify the required parameter 'orderId' is set
            if (orderId == null)
                throw new ApiException(400, "Missing required parameter 'orderId' when calling PeticionesDePagoPorCoDiApi->ConsultCodiRequestByOrderId");
            // verify the required parameter 'salesPointId' is set
            if (salesPointId == null)
                throw new ApiException(400, "Missing required parameter 'salesPointId' when calling PeticionesDePagoPorCoDiApi->ConsultCodiRequestByOrderId");

            var localVarPath = "/codi/sales-point/charges";
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

            if (orderId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "orderId", orderId)); // query parameter
            if (salesPointId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "salesPointId", salesPointId)); // query parameter
            if (authorization != null) localVarHeaderParams.Add("Authorization", this.Configuration.ApiClient.ParameterToString(authorization)); // header parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ConsultCodiRequestByOrderId", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PaymentRequestCodiResponseDTO>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PaymentRequestCodiResponseDTO) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PaymentRequestCodiResponseDTO)));
        }

        /// <summary>
        /// Obtiene la información de una petición de pago CODI® por orderId para un punto de venta Obtiene la información de una petición de pago CODI® por orderId para un punto de venta
        /// </summary>
        /// <exception cref="MX.Wire4.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">Header para token</param>
        /// <param name="orderId">Identificador del pago CODI®</param>
        /// <param name="salesPointId">Identificador del punto de venta</param>
        /// <returns>Task of PaymentRequestCodiResponseDTO</returns>
        public async System.Threading.Tasks.Task<PaymentRequestCodiResponseDTO> ConsultCodiRequestByOrderIdAsync (string authorization, string orderId, string salesPointId)
        {
             ApiResponse<PaymentRequestCodiResponseDTO> localVarResponse = await ConsultCodiRequestByOrderIdAsyncWithHttpInfo(authorization, orderId, salesPointId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Obtiene la información de una petición de pago CODI® por orderId para un punto de venta Obtiene la información de una petición de pago CODI® por orderId para un punto de venta
        /// </summary>
        /// <exception cref="MX.Wire4.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">Header para token</param>
        /// <param name="orderId">Identificador del pago CODI®</param>
        /// <param name="salesPointId">Identificador del punto de venta</param>
        /// <returns>Task of ApiResponse (PaymentRequestCodiResponseDTO)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PaymentRequestCodiResponseDTO>> ConsultCodiRequestByOrderIdAsyncWithHttpInfo (string authorization, string orderId, string salesPointId)
        {
            // verify the required parameter 'authorization' is set
            if (authorization == null)
                throw new ApiException(400, "Missing required parameter 'authorization' when calling PeticionesDePagoPorCoDiApi->ConsultCodiRequestByOrderId");
            // verify the required parameter 'orderId' is set
            if (orderId == null)
                throw new ApiException(400, "Missing required parameter 'orderId' when calling PeticionesDePagoPorCoDiApi->ConsultCodiRequestByOrderId");
            // verify the required parameter 'salesPointId' is set
            if (salesPointId == null)
                throw new ApiException(400, "Missing required parameter 'salesPointId' when calling PeticionesDePagoPorCoDiApi->ConsultCodiRequestByOrderId");

            var localVarPath = "/codi/sales-point/charges";
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

            if (orderId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "orderId", orderId)); // query parameter
            if (salesPointId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "salesPointId", salesPointId)); // query parameter
            if (authorization != null) localVarHeaderParams.Add("Authorization", this.Configuration.ApiClient.ParameterToString(authorization)); // header parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ConsultCodiRequestByOrderId", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PaymentRequestCodiResponseDTO>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PaymentRequestCodiResponseDTO) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PaymentRequestCodiResponseDTO)));
        }

        /// <summary>
        /// Genera un código QR para un pago mediante CODI® Genera un código QR solicitado por un punto de venta para un pago mediante CODI®
        /// </summary>
        /// <exception cref="MX.Wire4.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Información del pago CODI®</param>
        /// <param name="authorization">Header para token</param>
        /// <param name="salesPointId">Identificador del punto de venta</param>
        /// <returns>CodiCodeQrResponseDTO</returns>
        public CodiCodeQrResponseDTO GenerateCodiCodeQR (CodiCodeRequestDTO body, string authorization, string salesPointId)
        {
             ApiResponse<CodiCodeQrResponseDTO> localVarResponse = GenerateCodiCodeQRWithHttpInfo(body, authorization, salesPointId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Genera un código QR para un pago mediante CODI® Genera un código QR solicitado por un punto de venta para un pago mediante CODI®
        /// </summary>
        /// <exception cref="MX.Wire4.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Información del pago CODI®</param>
        /// <param name="authorization">Header para token</param>
        /// <param name="salesPointId">Identificador del punto de venta</param>
        /// <returns>ApiResponse of CodiCodeQrResponseDTO</returns>
        public ApiResponse< CodiCodeQrResponseDTO > GenerateCodiCodeQRWithHttpInfo (CodiCodeRequestDTO body, string authorization, string salesPointId)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling PeticionesDePagoPorCoDiApi->GenerateCodiCodeQR");
            // verify the required parameter 'authorization' is set
            if (authorization == null)
                throw new ApiException(400, "Missing required parameter 'authorization' when calling PeticionesDePagoPorCoDiApi->GenerateCodiCodeQR");
            // verify the required parameter 'salesPointId' is set
            if (salesPointId == null)
                throw new ApiException(400, "Missing required parameter 'salesPointId' when calling PeticionesDePagoPorCoDiApi->GenerateCodiCodeQR");

            var localVarPath = "/codi/sales-point/charges";
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

            if (salesPointId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "salesPointId", salesPointId)); // query parameter
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
                Exception exception = ExceptionFactory("GenerateCodiCodeQR", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CodiCodeQrResponseDTO>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (CodiCodeQrResponseDTO) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CodiCodeQrResponseDTO)));
        }

        /// <summary>
        /// Genera un código QR para un pago mediante CODI® Genera un código QR solicitado por un punto de venta para un pago mediante CODI®
        /// </summary>
        /// <exception cref="MX.Wire4.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Información del pago CODI®</param>
        /// <param name="authorization">Header para token</param>
        /// <param name="salesPointId">Identificador del punto de venta</param>
        /// <returns>Task of CodiCodeQrResponseDTO</returns>
        public async System.Threading.Tasks.Task<CodiCodeQrResponseDTO> GenerateCodiCodeQRAsync (CodiCodeRequestDTO body, string authorization, string salesPointId)
        {
             ApiResponse<CodiCodeQrResponseDTO> localVarResponse = await GenerateCodiCodeQRAsyncWithHttpInfo(body, authorization, salesPointId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Genera un código QR para un pago mediante CODI® Genera un código QR solicitado por un punto de venta para un pago mediante CODI®
        /// </summary>
        /// <exception cref="MX.Wire4.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Información del pago CODI®</param>
        /// <param name="authorization">Header para token</param>
        /// <param name="salesPointId">Identificador del punto de venta</param>
        /// <returns>Task of ApiResponse (CodiCodeQrResponseDTO)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CodiCodeQrResponseDTO>> GenerateCodiCodeQRAsyncWithHttpInfo (CodiCodeRequestDTO body, string authorization, string salesPointId)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling PeticionesDePagoPorCoDiApi->GenerateCodiCodeQR");
            // verify the required parameter 'authorization' is set
            if (authorization == null)
                throw new ApiException(400, "Missing required parameter 'authorization' when calling PeticionesDePagoPorCoDiApi->GenerateCodiCodeQR");
            // verify the required parameter 'salesPointId' is set
            if (salesPointId == null)
                throw new ApiException(400, "Missing required parameter 'salesPointId' when calling PeticionesDePagoPorCoDiApi->GenerateCodiCodeQR");

            var localVarPath = "/codi/sales-point/charges";
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

            if (salesPointId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "salesPointId", salesPointId)); // query parameter
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
                Exception exception = ExceptionFactory("GenerateCodiCodeQR", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CodiCodeQrResponseDTO>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (CodiCodeQrResponseDTO) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CodiCodeQrResponseDTO)));
        }

    }
}