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
        public interface IContactoApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Solicitud de contacto
        /// </summary>
        /// <remarks>
        /// Notifica a un asesor Monex para que se ponga en contacto con un posible cliente.
        /// </remarks>
        /// <exception cref="MX.Wire4.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Información del contacto</param>
        /// <param name="authorization">Header para token</param>
        /// <returns></returns>
        void SendContactUsingPOST (ContactRequest body, string authorization);

        /// <summary>
        /// Solicitud de contacto
        /// </summary>
        /// <remarks>
        /// Notifica a un asesor Monex para que se ponga en contacto con un posible cliente.
        /// </remarks>
        /// <exception cref="MX.Wire4.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Información del contacto</param>
        /// <param name="authorization">Header para token</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> SendContactUsingPOSTWithHttpInfo (ContactRequest body, string authorization);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Solicitud de contacto
        /// </summary>
        /// <remarks>
        /// Notifica a un asesor Monex para que se ponga en contacto con un posible cliente.
        /// </remarks>
        /// <exception cref="MX.Wire4.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Información del contacto</param>
        /// <param name="authorization">Header para token</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task SendContactUsingPOSTAsync (ContactRequest body, string authorization);

        /// <summary>
        /// Solicitud de contacto
        /// </summary>
        /// <remarks>
        /// Notifica a un asesor Monex para que se ponga en contacto con un posible cliente.
        /// </remarks>
        /// <exception cref="MX.Wire4.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Información del contacto</param>
        /// <param name="authorization">Header para token</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> SendContactUsingPOSTAsyncWithHttpInfo (ContactRequest body, string authorization);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public partial class ContactoApi : IContactoApi
    {
        private MX.Wire4.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ContactoApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ContactoApi(String basePath)
        {
            this.Configuration = new MX.Wire4.Client.Configuration { BasePath = basePath };

            ExceptionFactory = MX.Wire4.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContactoApi"/> class
        /// </summary>
        /// <returns></returns>
        public ContactoApi()
        {
            this.Configuration = MX.Wire4.Client.Configuration.Default;

            ExceptionFactory = MX.Wire4.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContactoApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ContactoApi(MX.Wire4.Client.Configuration configuration = null)
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
        /// Solicitud de contacto Notifica a un asesor Monex para que se ponga en contacto con un posible cliente.
        /// </summary>
        /// <exception cref="MX.Wire4.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Información del contacto</param>
        /// <param name="authorization">Header para token</param>
        /// <returns></returns>
        public void SendContactUsingPOST (ContactRequest body, string authorization)
        {
             SendContactUsingPOSTWithHttpInfo(body, authorization);
        }

        /// <summary>
        /// Solicitud de contacto Notifica a un asesor Monex para que se ponga en contacto con un posible cliente.
        /// </summary>
        /// <exception cref="MX.Wire4.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Información del contacto</param>
        /// <param name="authorization">Header para token</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> SendContactUsingPOSTWithHttpInfo (ContactRequest body, string authorization)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ContactoApi->SendContactUsingPOST");
            // verify the required parameter 'authorization' is set
            if (authorization == null)
                throw new ApiException(400, "Missing required parameter 'authorization' when calling ContactoApi->SendContactUsingPOST");

            var localVarPath = "/contact";
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
                Exception exception = ExceptionFactory("SendContactUsingPOST", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                null);
        }

        /// <summary>
        /// Solicitud de contacto Notifica a un asesor Monex para que se ponga en contacto con un posible cliente.
        /// </summary>
        /// <exception cref="MX.Wire4.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Información del contacto</param>
        /// <param name="authorization">Header para token</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task SendContactUsingPOSTAsync (ContactRequest body, string authorization)
        {
             await SendContactUsingPOSTAsyncWithHttpInfo(body, authorization);

        }

        /// <summary>
        /// Solicitud de contacto Notifica a un asesor Monex para que se ponga en contacto con un posible cliente.
        /// </summary>
        /// <exception cref="MX.Wire4.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Información del contacto</param>
        /// <param name="authorization">Header para token</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> SendContactUsingPOSTAsyncWithHttpInfo (ContactRequest body, string authorization)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ContactoApi->SendContactUsingPOST");
            // verify the required parameter 'authorization' is set
            if (authorization == null)
                throw new ApiException(400, "Missing required parameter 'authorization' when calling ContactoApi->SendContactUsingPOST");

            var localVarPath = "/contact";
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
                Exception exception = ExceptionFactory("SendContactUsingPOST", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                null);
        }

    }
}
