using System;
using System.Globalization;
using MX.Wire4.Api;
using MX.Wire4.Authenticator.Client;
using MX.Wire4.Authenticator.Model;
using MX.Wire4.Authenticator.Webhook.Verification.Signature;
using MX.Wire4.Client;
using MX.Wire4.Model;
using MX.Wire4.Tests.Config;

namespace MX.Wire4.Tests
{
    public class SdkClientTests
    {

        private readonly TokenTests tokenTests = new TokenTests();
        private readonly ApiTests apiTests = new ApiTests();

        public void Test()
        {
            /*Console.WriteLine("\n--====================================\n- CONSULTA DE TOKEN DE APLICACIÓN \n-===================================\n");
            tokenTests.GetApplicationTokenTest();

            Console.WriteLine("\n--====================================\n- CONSULTA DE TOKEN DE USUARIO SPEI \n-===================================\n");
            tokenTests.GetApplicationUserTokenTest();

            Console.WriteLine("\n--====================================\n- CONSULTA DE TOKEN DE USUARIO SPID \n-===================================\n");
            tokenTests.GetApplicationUserTokenSpidTest();

            Console.WriteLine("\n--====================================\n- CONSULTA DE CEPS \n-===================================\n");
            apiTests.ObtainTransactionCepUsingPOST();

            /*Console.WriteLine("\n--====================================\n- PRUEBA DE TOKENS DIFERENTES SCOPES \n-===================================\n");
            tokenTests.whenGenerateTokeForManyScopesShouldKeepsInCache();

            Console.WriteLine("\n--====================================\n- REGISTRO DE CONTACTO \n-===================================\n");
            apiTests.SendContactUsingPOST();

            Console.WriteLine("\n--====================================\n- PRE ENROLAMIENTO \n-===================================\n");
            apiTests.PreEnrollmentMonexUserUsingPOST();

            Console.WriteLine("\n--====================================\n- ELIMINACIÓN DE ENROLAMIENTO \n-===================================\n");
            apiTests.RemoveEnrollmentUserUsingDELETE();

            Console.WriteLine("\n--====================================\n- ELIMINACIÓN DE SUSCRIPCIÓN EN ESTATUS PENDIENTE \n-===================================\n");
            apiTests.RemoveSubscriptionPendingStatusUsingDELETE();

            Console.WriteLine("\n--====================================\n- CONSULTA DE RELATIONSHIPS PARA BENEFICIARIOS \n-===================================\n");
            apiTests.GetAvailableRelationshipsMonexUsingGET();

            Console.WriteLine("\n--====================================\n- CONSULTA DE BENEFICIARIOS \n-===================================\n");
            apiTests.GetBeneficiariesForAccountUsingGET();

            Console.WriteLine("\n--====================================\n- PRE REGISTRO DE CUENTAS DE BENEFICIARIO \n-===================================\n");
            apiTests.PreRegisterAccountsUsingPOST();

            Console.WriteLine("\n--====================================\n- ACTUALIZACIÓN DE MONTO LIMITE \n-===================================\n");
            apiTests.UpdateAmountLimitAccountUsingPUT();

            Console.WriteLine("\n--====================================\n- ELIMINACIÓN DE CUENTA \n-===================================\n");
            apiTests.DeleteAccountUsingDELETE();

            Console.WriteLine("\n--====================================\n- PRE REGISTRO DE CUENTAS DE BENEFICIARIO SPID \n-===================================\n");
            apiTests.PreRegisterAccountsUsingPOST_1();

            Console.WriteLine("\n--====================================\n- CONSULTA DE CLASIFICACIONES SPID \n-===================================\n");
            apiTests.GetSpidClassificationsUsingGET();

            Console.WriteLine("\n--====================================\n- CONSULTA DE BENEFICIARIOS SPID \n-===================================\n");
            apiTests.GetBeneficiariesSpid();

            Console.WriteLine("\n--====================================\n- CONSULTA DE INSTITUCIONES \n-===================================\n");
            apiTests.GetAllInstitutionsUsingGET();

            Console.WriteLine("\n--====================================\n- CONSULTA DE BALANCE \n-===================================\n");
            apiTests.GetBalanceUsingGET();

            Console.WriteLine("\n--====================================\n- REGISTRO DE DEPOSITANTE \n-===================================\n");
            apiTests.RegisterDepositantsUsingPOST();

            Console.WriteLine("\n--====================================\n- CONSULTA DE DEPOSITANTES \n-===================================\n");
            apiTests.GetDepositantsUsingGET();

            Console.WriteLine("\n--====================================\n- REGISTRO DE TRANSACCIONES DE SALIDA SPEI \n-===================================\n");
            apiTests.RegisterOutgoingSpeiTransactionUsingPOST();*/

            Console.WriteLine("\n--====================================\n- CONSULTA DE TRANSACCIONES DE ENTRADA \n-===================================\n");
            apiTests.IncomingSpeiTransactionsReportUsingGET();

            /*apiTests.OutgoingSpeiTransactionsReportUsingGET();

            Console.WriteLine("\n--====================================\n- REGISTRO DE TRANSACCIONES DE SALIDA SPID \n-===================================\n");
            apiTests.RegisterOutgoingSpidTransactionUsingPOST();

            Console.WriteLine("\n--====================================\n- ELIMINACIÓN DE TRANSACCIONES EN ESTADO PENDIENTE \n-===================================\n");
            apiTests.DropTransactionsPendingUsingDELETE();

            Console.WriteLine("\n--====================================\n- REGISTRO DE WEBHOOKS \n-===================================\n");
            apiTests.RegisterWebhook();

            Console.WriteLine("\n--====================================\n- CONSULTA DE WEBHOOKS \n-===================================\n");
            apiTests.GetWebhooks();

            Console.WriteLine("\n--====================================\n- CONSULTA DE WEBHOOK \n-===================================\n");
            apiTests.GetWebhook();

            Console.WriteLine("\n--====================================\n- ELIMINACIÓN DE CUENTAS DE BENEFICIARIO EN ESTATUS PENDIENTE \n-===================================\n");
            apiTests.RemoveBeneficiariesPendingUsingDELETE();

            Console.WriteLine("\n--====================================\n- CONSULTA DE FACTURACIÓN \n-===================================\n");
            apiTests.BillingsReportUsingGET();

            Console.WriteLine("\n--====================================\n- CONSULTA DE FACTURACIÓN POR ID \n-===================================\n");
            apiTests.BillingsReportByIdUsingGET();

            Console.WriteLine("\n--====================================\n- VERIFICACIÓN FIRMAS WEBHOOKS \n-===================================\n");
            apiTests.VerificationSignWebHookMessage();

            Console.WriteLine("\n--====================================\n- AUTORIZAR CUENTAS PENDIENTES \n-===================================\n");
            apiTests.AuthorizeAccountsPendingPUT();

            Console.WriteLine("\n--====================================\n- BENEFICIERIES POR IDENTIFICADOR DE PETICIÓN \n-===================================\n");
            apiTests.GetBeneficiariesByRequestId(); */

            /*Console.WriteLine("\n--====================================\n- AUTORIZACIÓN DE TRANSACCIONES EN GRUPO \n-===================================\n");
            apiTests.CreateAuthorizationTransactionsGroup();

            Console.WriteLine("\n--====================================\n- REGISTRAR EMPRESAS CODI \n-===================================\n");
            apiTests.RegisterCompanyUsingPOST();

            Console.WriteLine("\n--====================================\n- CONSULTAR EMPRESAS CODI \n-===================================\n");
            apiTests.ObtainCompanies();

            /*Console.WriteLine("\n--====================================\n- CREAR PUNTO DE VENTA CODI \n-===================================\n");
            apiTests.CreateSalesPoint();

            Console.WriteLine("\n--====================================\n- CONSULTAR PUNTOS DE VENTA CODI \n-===================================\n");
            apiTests.ObtainSalePoints();

            Console.WriteLine("\n--====================================\n- GENERAR CODIGO PARA PAGO CODI \n-===================================\n");
            apiTests.GenerateCodiCodeQR();

            Console.WriteLine("\n--====================================\n- CONSULTAR CODIGO PARA PAGO CODI POR ORDER ID \n-===================================\n");
            apiTests.ConsultCodiRequestByOrderId();

            Console.WriteLine("\n--====================================\n- CONSULTAR OPERACIONES DE PAGO CODI \n-===================================\n");
            apiTests.ConsultCodiOperations();

            Console.WriteLine("\n--====================================\n- CONSULTAR DETALLES DE LA EMPRESA ASOCIADA A UN CONTRATO \n-===================================\n");
            apiTests.ObtainContractDetails();

            Console.WriteLine("\n--====================================\n- AUTORIZAR UN CONTRATO PARA USAR WIRE4 \n-===================================\n");
            apiTests.CreateAuthorization();

            Console.WriteLine("\n--====================================\n- LISTA DE USUARIOS AUTORIZADOS PARA UN CONTRATO PARA USAR WIRE4 \n-===================================\n");
            apiTests.ObtainAuthorizedUsers();

            Console.WriteLine("\n--====================================\n- ACTUALIZA LAS CONFIGURACIONES PARA UN CONTRATO \n-===================================\n");
            apiTests.UpdateConfigurations();

            Console.WriteLine("\n--====================================\n- AUTORIZAR UN CONTRATO PARA USAR WIRE4 \n-===================================\n");
            apiTests.ChangeSubscriptionUsageUsingPATCH();

            Console.WriteLine("\n--====================================\n- OBTIENE LAS CONFIGURACIONES PARA UNA SUSCRIPCIÓN \n-===================================\n");
            apiTests.ObtaingConfigurations();*/
        }
    }

    public class TokenTests
    {
        private IAuthenticator authenticator;

        public TokenTests()
        {
            authenticator = new TokenAuthenticator(DataConfig.environment);
        }

        public void GetApplicationTokenTest()
        {
            try
            {
                var token = authenticator.GetApplicationToken(DataConfig.applicationTokenRequest);
                Console.WriteLine("Application Token:: " + token);
                Console.WriteLine();

            }
            catch (ApiException ex)
            {
                Console.WriteLine(string.Format("{0}", ex));

            }
        }

        public void GetApplicationUserTokenTest()
        {
            try
            {
                var token = authenticator.GetApplicationUserToken(DataConfig.speiUserTokenRequest);
                Console.WriteLine("Spei User Token:: " + token);
                Console.WriteLine();

            }
            catch (ApiException ex)
            {
                Console.WriteLine(string.Format("{0}", ex));

            }
        }

        public void GetApplicationUserTokenSpidTest()
        {
            try
            {
                var token = authenticator.GetApplicationUserTokenSpid(DataConfig.spidUserTokenRequest);
                Console.WriteLine("Spid User Token:: " + token);
                Console.WriteLine();
            }
            catch (ApiException ex)
            {
                Console.WriteLine(string.Format("{0}", ex));
            }
        }

        public void whenGenerateTokeForManyScopesShouldKeepsInCache()
        {
            TokenRequest appTokenRequest = new TokenRequest {
                ClientKey = "FxUWmqYGZuv8O1qjxstvIyJothMa",
                ClientSecret = "kjwbkrPVgXsnaUGzthj55dsFhx4a"
            };

            string appDoubleScopeFirst = authenticator.GetApplicationToken(appTokenRequest, "general codi_report");
            string appGeneralFirst = authenticator.GetApplicationToken(appTokenRequest, "general");
            string appCodiReportFirst = authenticator.GetApplicationToken(appTokenRequest, "codi_report");
            string appDoubleScopeSecond = authenticator.GetApplicationToken(appTokenRequest, "general codi_report");
            string appGeneralSecond = authenticator.GetApplicationToken(appTokenRequest, "general");
            string appCodiReportSecond = authenticator.GetApplicationToken(appTokenRequest, "codi_report");

            Console.WriteLine("First test, appDoubleScopeFirst == appDoubleScopeSecond: {0}",
                 appDoubleScopeFirst != null && appDoubleScopeFirst.Equals(appDoubleScopeSecond));

            Console.WriteLine("First test, appGeneralFirst == appGeneralSecond: {0}",
                 appGeneralFirst != null && appGeneralFirst.Equals(appGeneralSecond));

            Console.WriteLine("First test, appCodiReportFirst == appCodiReportSecond: {0}",
                 appCodiReportFirst != null && appCodiReportFirst.Equals(appCodiReportSecond));
        }
    }


    public class ApiTests
    {
        private static readonly string clientKey = "FxUWmqYGZuv8O1qjxstvIyJothMa";

        private static readonly string clientSecret = "kjwbkrPVgXsnaUGzthj55dsFhx4a";

        private static readonly string userKey = "071e2b59b354186b3a0158de493536@sandbox.wire4.mx";

        private static readonly string userSecret = "0d1e33e94604f01b4e00d2fcb6b48f";

        private static readonly string subscription = "f1504fea-3a8f-475a-a50a-90d3c40efc59";

        private IAuthenticator authenticator;

        public ApiTests()
        {
            authenticator = new TokenAuthenticator(DataConfig.environment);
        }

        public void ObtainTransactionCepUsingPOST()
        {

            // Create the api component
            IComprobanteElectrnicoDePagoCEPApi api = new ComprobanteElectrnicoDePagoCEPApi();

            // Create the authenticator to obtain access token
            // (the token URL and Service URL are defined for this environment enum value))
            //IAuthenticator authenticator = new TokenAuthenticator(DataConfig.environment);
            TokenRequest applicationTokenRequest = new TokenRequest
            {
                ClientKey = clientKey,
                ClientSecret = clientSecret
            };

            try
            {
                // Obtain an access token use application flow and scope "general" and add the bearer token to request
                string authorization = authenticator.GetApplicationToken(applicationTokenRequest);

                // Build body with info (check references for more info, types, required fields)
                CepSearchBanxico body = new CepSearchBanxico(
                    decimal.Parse("8963.25"),
                    "072680004657656853",
                    "40072",
                    "58735618",
                    "05-12-2018",
                    "1122334",
                    "112680000156896531",
                    "40112"
                );

                // Obtain the response
                CepResponse response = api.ObtainTransactionCepUsingPOST(body, authorization);

                Console.WriteLine(string.Format("Response :: {0}", response.ToJson()));
            }
            catch (ApiException ex)
            {
                Console.WriteLine(string.Format("{0}", ex.Message));
            }
        }

        public void SendContactUsingPOST()
        {
            
            // Create the api component
            IContactoApi api = new ContactoApi();

            // Create the authenticator to obtain access token
            // (the token URL and Service URL are defined for this environment enum value))
            //IAuthenticator authenticator = new TokenAuthenticator(DataConfig.environment);
            TokenRequest applicationTokenRequest = new TokenRequest
            {
                ClientKey = clientKey,
                ClientSecret = clientSecret
            };

            // Build body with info (check references for more info, types, required fields)
            ContactRequest body = new ContactRequest(
                address: "Calle Falsa 123, Col Fantasía",
                company: "Compu Mundo Hiper Mega Red",
                contactPerson: "Homer J Simpson",
                email: "homer.simpson@compumundohipermegared.com",
                phoneNumber: "4422102030"
            );

            try
            {
                // Obtain an access token use application flow and scope "general" and add the bearer token to request
                string authorization = authenticator.GetApplicationToken(applicationTokenRequest);

                ApiResponse<object> response = api.SendContactUsingPOSTWithHttpInfo(body, authorization);

                Console.WriteLine(string.Format("Response :: {0}", response.StatusCode));
            }
            catch (ApiException ex)
            {
                Console.WriteLine(string.Format("{0}", ex.Message));
            }
        }

        public void PreEnrollmentMonexUserUsingPOST()
        {
            // Create the api component
            ISuscripcionesApi api = new SuscripcionesApi();

            // Create the authenticator to obtain access token
            // (the token URL and Service URL are defined for this environment enum value))
            //IAuthenticator authenticator = new TokenAuthenticator(DataConfig.environment);
            TokenRequest applicationTokenRequest = new TokenRequest
            {
                ClientKey = clientKey,
                ClientSecret = clientSecret,
            };

            // Build body with info (check references for more info, types, required fields)
            PreEnrollmentData body = new PreEnrollmentData("https://your-app-url.mx/return", "https://your-app-url.mx/cancel");
            try
            {
                // Obtain an access token use application flow and scope "general" and add the bearer token to request
                string authorization = authenticator.GetApplicationToken(applicationTokenRequest);

                // Obtain the response
                PreEnrollmentResponse response = api.PreEnrollmentMonexUserUsingPOST(body, authorization);

                Console.WriteLine(string.Format("Response :: {0}", response.ToJson()));
            }
            catch (ApiException ex)
            {
                Console.WriteLine(string.Format("{0}", ex.Message));
            }

        }

        public void RemoveEnrollmentUserUsingDELETE()
        {
            String subscriptionToRemoveUserKey = "";
            String subscriptionToRemoveUserSecret = "";


            // Create the api component
            ISuscripcionesApi api = new SuscripcionesApi();

            // Create the authenticator to obtain access token
            // (the token URL and Service URL are defined for this environment enum value))
            //IAuthenticator authenticator = new TokenAuthenticator(DataConfig.environment);
            TokenRequest userTokenRequest = new TokenRequest
            {
                ClientKey = clientKey,
                ClientSecret = clientSecret,
                UserKey = subscriptionToRemoveUserKey,
                UserSecret = subscriptionToRemoveUserSecret,
            };

            string body = "5873240b-cf69-456a-ab5a-88f5e79ab4b8";

            try
            {
                // Obtain an access token use application flow and scope "spei_admin" and add the bearer token to request
                string authorization = authenticator.GetApplicationUserToken(userTokenRequest);

                // Obtain the response
                ApiResponse<object> response = api.RemoveEnrollmentUserUsingDELETEWithHttpInfo(authorization, body);

                Console.WriteLine(string.Format("Response :: {0}", response.StatusCode));
            }
            catch (ApiException ex)
            {
                Console.WriteLine(string.Format("{0}", ex.Message));
            }

        }

        public void RemoveSubscriptionPendingStatusUsingDELETE()
        {
            // Create the api component
            ISuscripcionesApi api = new SuscripcionesApi();

            // Create the authenticator to obtain access token
            // (the token URL and Service URL are defined for this environment enum value))
            //IAuthenticator authenticator = new TokenAuthenticator(DataConfig.environment);
            TokenRequest applicationTokenRequest = new TokenRequest
            {
                ClientKey = clientKey,
                ClientSecret = clientSecret,
            };

            // Build body with info (check references for more info, types, required fields)
            string body = "55af515a-43ec-4537-96a4-489d1deef127";

            try
            {
                // Obtain an access token use application flow and scope "general" and add the bearer token to request
                string authorization = authenticator.GetApplicationToken(applicationTokenRequest);

                // Obtain the response
                ApiResponse<object> response = api.RemoveSubscriptionPendingStatusUsingDELETEWithHttpInfo(authorization, body);

                Console.WriteLine(string.Format("Response :: {0}", response.StatusCode));
            }
            catch (ApiException ex)
            {
                Console.WriteLine(string.Format("{0}", ex.Message));
            }

        }

        public void ChangeSubscriptionUsageUsingPATCH()
        {
            /*// Create the api component
            ISuscripcionesApi api = new SuscripcionesApi();

            // Create the authenticator to obtain access token
            // (the token URL and Service URL are defined for this environment enum value))
            //IAuthenticator authenticator = new TokenAuthenticator(DataConfig.environment);
            TokenRequest applicationTokenRequest = new TokenRequest
            {
                ClientKey = clientKey,
                ClientSecret = clientSecret,
            };

            try
            {
                // Obtain an access token use application flow and scope "general" and add the bearer token to request
                string authorization = authenticator.GetApplicationToken(applicationTokenRequest);

                // Build body with info (check references for more info, types, required fields)
                SubscriptionChangeStatusRequest body = new SubscriptionChangeStatusRequest();
                body.Status = SubscriptionChangeStatusRequest.StatusEnum.INACTIVE;

                // Obtain the response
                ApiResponse<object> response = api.ChangeSubscriptionStatusUsingPUTWithHttpInfo(body, authorization, subscription);

                Console.WriteLine(string.Format("Response:: {0}", response.StatusCode));
            }
            catch (ApiException ex)
            {
                Console.WriteLine(string.Format("{0}", ex.Message));
            }*/
        }

        public void GetAvailableRelationshipsMonexUsingGET()
        {

            // Create the api component
            ICuentasDeBeneficiariosSPEIApi api = new CuentasDeBeneficiariosSPEIApi();

            // Create the authenticator to obtain access token
            // (the token URL and Service URL are defined for this environment enum value))
            //IAuthenticator authenticator = new TokenAuthenticator(DataConfig.environment);
            TokenRequest userTokenRequest = new TokenRequest
            {
                ClientKey = clientKey,
                ClientSecret = clientSecret,
                UserKey = userKey,
                UserSecret = userSecret
            };

            try
            {
                // Obtain an access token use application flow and scope "spei_admin" and add the bearer token to request
                string authorization = authenticator.GetApplicationUserToken(userTokenRequest);

                // Obtain the response
                RelationshipsResponse response = api.GetAvailableRelationshipsMonexUsingGET(authorization, subscription);

                Console.WriteLine(string.Format("Response :: {0}", response.ToJson()));
            }
            catch (ApiException ex)
            {
                Console.WriteLine(string.Format("{0}", ex.Message));
            }
        }

        public void GetBeneficiariesForAccountUsingGET()
        {
            // Create the api component
            ICuentasDeBeneficiariosSPEIApi api = new CuentasDeBeneficiariosSPEIApi();

            // Create the authenticator to obtain access token
            // (the token URL and Service URL are defined for this environment enum value))
            //IAuthenticator authenticator = new TokenAuthenticator(DataConfig.environment);
            TokenRequest userTokenRequest = new TokenRequest
            {
                ClientKey = clientKey,
                ClientSecret = clientSecret,
                UserKey = userKey,
                UserSecret = userSecret,
            };

            try
            {
                // Obtain an access token use application flow and scope "spei_admin" and add the bearer token to request
                string authorization = authenticator.GetApplicationUserToken(userTokenRequest);

                // Examples using filters, optional filters are all strings, not incluyde if you don't want to filter:
                // account, beneficiaryBank, beneficiaryName, rfc, 
                // endDate, initDate // format dd-mm-yyyy
                // status // PENDING, REGISTERED
                //
                // api.GetBeneficiariesForAccountUsingGET(authorization, subscription);
                // api.GetBeneficiariesForAccountUsingGET(authorization, subscription, rfc: "RFCE010980AR3");
                // api.GetBeneficiariesForAccountUsingGET(authorization, subscription, account: "112680000156896531");
                // api.GetBeneficiariesForAccountUsingGET(authorization, subscription, rfc: "RFCE010980AR3", account: "112680000156896531");
                // api.GetBeneficiariesForAccountUsingGET(authorization, subscription, any combination...);

                // Obtain the response
                BeneficiariesResponse response = api.GetBeneficiariesForAccountUsingGET(authorization, subscription);

                Console.WriteLine(string.Format("Response :: {0}", response.ToJson()));
            }
            catch (ApiException ex)
            {
                Console.WriteLine(string.Format("{0}", ex.Message));
            }
        }

        public void GetBeneficiariesByRequestId()
        {
            // Create the api component
            ICuentasDeBeneficiariosSPEIApi api = new CuentasDeBeneficiariosSPEIApi();

            // Create the authenticator to obtain access token
            // (the token URL and Service URL are defined for this environment enum value))
            //IAuthenticator authenticator = new TokenAuthenticator(DataConfig.environment);
            TokenRequest userTokenRequest = new TokenRequest
            {
                ClientKey = clientKey,
                ClientSecret = clientSecret,
                UserKey = userKey,
                UserSecret = userSecret,
            };

            try
            {
                // Obtain an access token use application flow and scope "spei_admin" and add the bearer token to request
                string authorization = authenticator.GetApplicationUserToken(userTokenRequest);
                string subscription = ApiTests.subscription;
                string requestId = "acbd7fb9-3999-4359-8bad-963a8f7d5853";

                // Obtain the response
                BeneficiariesResponse response = api.GetBeneficiariesByRequestId(authorization, requestId, subscription);

                Console.WriteLine(string.Format("Response :: {0}", response.ToJson()));
            }
            catch (ApiException ex)
            {
                Console.WriteLine(string.Format("{0}", ex.Message));
            }
        }

        public void PreRegisterAccountsUsingPOST()
        {
            // Create the api component
            ICuentasDeBeneficiariosSPEIApi api = new CuentasDeBeneficiariosSPEIApi();

            // Create the authenticator to obtain access token
            // (the token URL and Service URL are defined for this environment enum value))
            //IAuthenticator authenticator = new TokenAuthenticator(DataConfig.environment);
            TokenRequest userTokenRequest = new TokenRequest
            {
                ClientKey = clientKey,
                ClientSecret = clientSecret,
                UserKey = userKey,
                UserSecret = userSecret,
            };

            // Build body with info (check references for more info, types, required fields)
            AccountRequest body = new AccountRequest(
                accounts: new System.Collections.Generic.List<Account>() {
                    new Account(
                        decimal.Parse("10000.00"),
                        null,
                        "112680000156896531",
                        new System.Collections.Generic.List<string>(){"beneficiary@wire4.mx"},
                        null,
                        "RECURRENTE",
                        "1234567",
                        "Concepto SPEI",
                        new Person("Simpson","Jay","Bartolomeo"),
                        "ACREEDOR",
                        "SJBA920125AB1")
                    },
                cancelReturnUrl: "https://your-app-url.mx/cancel",
                returnUrl: "https://your-app-url.mx/return");

            try
            {
                // Obtain an access token use application flow and scope "spei_admin" and add the bearer token to request
                string authorization = authenticator.GetApplicationUserToken(userTokenRequest);

                // Obtain the response
                TokenRequiredResponse response = api.PreRegisterAccountsUsingPOST(body, authorization, subscription);

                Console.WriteLine(string.Format("Response :: {0}", response.ToJson()));
            }
            catch (ApiException ex)
            {
                Console.WriteLine(string.Format("{0}", ex.Message));
            }
        }

        public void UpdateAmountLimitAccountUsingPUT()
        {
            // Create the api component
            ICuentasDeBeneficiariosSPEIApi api = new CuentasDeBeneficiariosSPEIApi();

            // Create the authenticator to obtain access token
            // (the token URL and Service URL are defined for this environment enum value))
            //IAuthenticator authenticator = new TokenAuthenticator(DataConfig.environment);
            TokenRequest userTokenRequest = new TokenRequest
            {
                ClientKey = clientKey,
                ClientSecret = clientSecret,
                UserKey = userKey,
                UserSecret = userSecret,
            };

            string account = "112680000156896531";

            // Build body with info (check references for more info, types, required fields)
            AmountRequest body = new AmountRequest(
                amountLimit: decimal.Parse("20000.00"),
                previousAmountLimit: decimal.Parse("10000.00"),
                currencyCode: "MXP",
                returnUrl: "https://your-app-url.mx/return",
                cancelReturnUrl: "https://your-app-url.mx/cancel"
                );

            try
            {
                // Obtain an access token use application flow and scope "spei_admin" and add the bearer token to request
                string authorization = authenticator.GetApplicationUserToken(userTokenRequest);

                // Obtain the response
                TokenRequiredResponse response = api.UpdateAmountLimitAccountUsingPUT(body, authorization, account, subscription);

                Console.WriteLine(string.Format("Response :: {0}", response.ToJson()));
            }
            catch (ApiException ex)
            {
                Console.WriteLine(string.Format("{0}", ex.Message));
            }
        }

        public void DeleteAccountUsingDELETE()
        {
            // Create the api component
            ICuentasDeBeneficiariosSPEIApi api = new CuentasDeBeneficiariosSPEIApi();

            // Create the authenticator to obtain access token
            // (the token URL and Service URL are defined for this environment enum value))
            //IAuthenticator authenticator = new TokenAuthenticator(DataConfig.environment);
            TokenRequest userTokenRequest = new TokenRequest
            {
                ClientKey = clientKey,
                ClientSecret = clientSecret,
                UserKey = userKey,
                UserSecret = userSecret,
            };

            string account = "044680035044988526";

            try
            {
                // Obtain an access token use application flow and scope "spei_admin" and add the bearer token to request
                string authorization = authenticator.GetApplicationUserToken(userTokenRequest);

                // Obtain the response
                ApiResponse<object> response = api.DeleteAccountUsingDELETEWithHttpInfo(authorization, account, subscription);

                Console.WriteLine(string.Format("Response :: {0}", response.StatusCode));
            }
            catch (ApiException ex)
            {
                Console.WriteLine(string.Format("{0}", ex.Message));
            }

        }

        public void PreRegisterAccountsUsingPOST_1()
        {
            // Create the api component
            ICuentasDeBeneficiariosSPIDApi api = new CuentasDeBeneficiariosSPIDApi();

            // Create the authenticator to obtain access token
            // (the token URL and Service URL are defined for this environment enum value))
            //IAuthenticator authenticator = new TokenAuthenticator(DataConfig.environment);
            TokenRequest userTokenRequest = new TokenRequest
            {
                ClientKey = clientKey,
                ClientSecret = clientSecret,
                UserKey = userKey,
                UserSecret = userSecret,
            };

            // Build body with info (check references for more info, types, required fields)
            AccountSpid body = new AccountSpid(
                 decimal.Parse("10000.00"),
                 "23451",
                 "112680000156896531",
                 "https://your-app-url.mx/cancel",
                 new System.Collections.Generic.List<string>() { "beneficiary@wire4.mx" },
                 new BeneficiaryInstitution("BMONEX"),
                 "RECURRENTE",
                 "1234567",
                 "Concepto SPID",
                 "ACREEDOR",
                 "https://your-app-url.mx/return",
                 "SJBA920125AB1"
                );

            try
            {
                // Obtain an access token use application flow and scope "spid_admin" and add the bearer token to request
                string authorization = authenticator.GetApplicationUserTokenSpid(userTokenRequest);

                // Obtain the response
                TokenRequiredResponse response = api.PreRegisterAccountsUsingPOST1(body, authorization, subscription);

                Console.WriteLine(string.Format("Response :: {0}", response.ToJson()));
            }
            catch (ApiException ex)
            {
                Console.WriteLine(string.Format("{0}", ex.Message));
            }
        }

        public void GetSpidClassificationsUsingGET()
        {
            // Create the api component
            ITransferenciasSPIDApi api = new TransferenciasSPIDApi();

            // Create the authenticator to obtain access token
            // (the token URL and Service URL are defined for this environment enum value))
            //IAuthenticator authenticator = new TokenAuthenticator(DataConfig.environment);
            TokenRequest userTokenRequest = new TokenRequest
            {
                ClientKey = clientKey,
                ClientSecret = clientSecret,
                UserKey = userKey,
                UserSecret = userSecret,
            };

            try
            {
                // Obtain an access token use application flow and scope "spid_admin" and add the bearer token to request
                string authorization = authenticator.GetApplicationUserTokenSpid(userTokenRequest);

                // Obtain the response
                SpidClassificationsResponseDTO response = api.GetSpidClassificationsUsingGET(authorization, subscription);

                Console.WriteLine(string.Format("Response :: {0}", response.ToJson()));
            }
            catch (ApiException ex)
            {
                Console.WriteLine(string.Format("{0}", ex.Message));
            }
        }

        public void GetBeneficiariesSpid()
        {
            ICuentasDeBeneficiariosSPIDApi api = new CuentasDeBeneficiariosSPIDApi();

            // Create the authenticator to obtain access token
            // (the token URL and Service URL are defined for this environment enum value))
            //IAuthenticator authenticator = new TokenAuthenticator(DataConfig.environment);
            TokenRequest userTokenRequest = new TokenRequest
            {
                ClientKey = clientKey,
                ClientSecret = clientSecret,
                UserKey = userKey,
                UserSecret = userSecret,
            };

            try
            {
                // Obtain an access token use application flow and scope "spei_admin" and add the bearer token to request
                string authorization = authenticator.GetApplicationUserTokenSpid(userTokenRequest);

                // Obtain the response
                // api.GetSpidBeneficiariesForAccount(authorization, subscription);
                // api.GetSpidBeneficiariesForAccount(authorization, subscription, rfc: "RFCE010980AR3");
                // api.GetSpidBeneficiariesForAccount(authorization, subscription, account: "112680000156896531");
                // api.GetSpidBeneficiariesForAccount(authorization, subscription, rfc: "RFCE010980AR3", account: "112680000156896531");
                SpidBeneficiariesResponse response = api.GetSpidBeneficiariesForAccount(authorization, subscription);

                Console.WriteLine(string.Format("Response :: {0}", response.ToJson()));
            }
            catch (ApiException ex)
            {
                Console.WriteLine(string.Format("{0}", ex.Message));
            }
        }

        public void GetAllInstitutionsUsingGET()
        {
            IInstitucionesApi api = new InstitucionesApi();

            // Create the authenticator to obtain access token
            // (the token URL and Service URL are defined for this environment enum value))
            //IAuthenticator authenticator = new TokenAuthenticator(DataConfig.environment);
            TokenRequest applicationTokenRequest = new TokenRequest
            {
                ClientKey = clientKey,
                ClientSecret = clientSecret,
            };

            try
            {
                // Obtain an access token use application flow and scope "general" and add the bearer token to request
                string authorization = authenticator.GetApplicationToken(applicationTokenRequest);

                // Obtain the response
                InstitutionsList response = api.GetAllInstitutionsUsingGET(authorization);

                Console.WriteLine(string.Format("Response :: {0}", response.ToJson()));
            }
            catch (ApiException ex)
            {
                Console.WriteLine(string.Format("{0}", ex.Message));
            }

        }

        public void GetBalanceUsingGET()
        {
            // Create the api component
            ISaldoApi api = new SaldoApi();

            // Create the authenticator to obtain access token
            // (the token URL and Service URL are defined for this environment enum value))
            //IAuthenticator authenticator = new TokenAuthenticator(DataConfig.environment);
            TokenRequest userTokenRequest = new TokenRequest
            {
                ClientKey = clientKey,
                ClientSecret = clientSecret,
                UserKey = userKey,
                UserSecret = userSecret,
            };

            try
            {
                // Obtain an access token use application flow and scope "spei_admin" and add the bearer token to request
                string authorization = authenticator.GetApplicationUserToken(userTokenRequest);

                // Obtain the response
                BalanceListResponse response = api.GetBalanceUsingGET(authorization, subscription);

                Console.WriteLine(string.Format("Response :: {0}", response.ToJson()));
            }
            catch (ApiException ex)
            {
                Console.WriteLine(string.Format("{0}", ex.Message));
            }
        }

        public void RegisterDepositantsUsingPOST()
        {
            IDepositantesApi api = new DepositantesApi();

            // Create the authenticator to obtain access token
            // (the token URL and Service URL are defined for this environment enum value))
            //IAuthenticator authenticator = new TokenAuthenticator(DataConfig.environment);
            TokenRequest userTokenRequest = new TokenRequest
            {
                ClientKey = clientKey,
                ClientSecret = clientSecret,
                UserKey = userKey,
                UserSecret = userSecret,
            };

            // Build body with info (check references for more info, types, required fields)
            DepositantsRegister body = new DepositantsRegister(
                "Depositant 0292920",
                "MXP",
                new System.Collections.Generic.List<string>() { "depositant@wire4.mx" },
                "Marge Bouvier"
                );

            try
            {
                // Obtain an access token use application flow and scope "spei_admin" and add the bearer token to request
                string authorization = authenticator.GetApplicationUserToken(userTokenRequest);

                // Obtain the response
                var response = api.RegisterDepositantsUsingPOST(body, authorization, subscription);

                Console.WriteLine(string.Format("Response :: {0}", response.ToJson()));
            }
            catch (ApiException ex)
            {
                Console.WriteLine(string.Format("{0}", ex.Message));
            }
        }

        public void GetDepositantsUsingGET()
        {
            // Create the api component
            IDepositantesApi api = new DepositantesApi();

            // Create the authenticator to obtain access token
            // (the token URL and Service URL are defined for this environment enum value))
            //IAuthenticator authenticator = new TokenAuthenticator(DataConfig.environment);
            TokenRequest userTokenRequest = new TokenRequest
            {
                ClientKey = clientKey,
                ClientSecret = clientSecret,
                UserKey = userKey,
                UserSecret = userSecret,
            };

            try
            {
                // Obtain an access token use application flow and scope "spei_admin" and add the bearer token to request
                string authorization = authenticator.GetApplicationUserToken(userTokenRequest);

                // Obtain the response
                GetDepositants response = api.GetDepositantsUsingGET(authorization, subscription);

                Console.WriteLine(string.Format("Response :: {0}", response.ToJson()));
            }
            catch (ApiException ex)
            {
                Console.WriteLine(string.Format("{0}", ex.Message));
            }
        }

        public void RegisterOutgoingSpeiTransactionUsingPOST()
        {
            // Create the api component
            ITransferenciasSPEIApi api = new TransferenciasSPEIApi();

            // Create the authenticator to obtain access token
            // (the token URL and Service URL are defined for this environment enum value))
            //IAuthenticator authenticator = new TokenAuthenticator(DataConfig.environment);
            TokenRequest userTokenRequest = new TokenRequest
            {
                ClientKey = clientKey,
                ClientSecret = clientSecret,
                UserKey = userKey,
                UserSecret = userSecret,
            };

            // Build body with info (check references for more info, types, required fields)
            TransactionsOutgoingRegister body = new TransactionsOutgoingRegister(
                "https://your-app-url.mx/cancel",
                "https://your-app-url.mx/return",
                new System.Collections.Generic.List<TransactionOutgoing>() {
                    new TransactionOutgoing(
                        decimal.Parse("120.25"),
                        "112680000156896531",
                        null,
                        "Transfer out Test SPEI",
                        "MXP",
                        new System.Collections.Generic.List<string>(){ "notificar@wire4.mx" },
                        "3f85b276-0ef3-49d9-91b2-564a0e9298ea",
                        1234567
                        ),
                });

            try
            {
                // Obtain an access token use application flow and scope "spei_admin" and add the bearer token to request
                string authorization = authenticator.GetApplicationUserToken(userTokenRequest);

                // Obtain the response
                TokenRequiredResponse response = api.RegisterOutgoingSpeiTransactionUsingPOST(body, authorization, subscription);

                Console.WriteLine(string.Format("Response :: {0}", response.ToJson()));
            }
            catch (ApiException ex)
            {
                Console.WriteLine(string.Format("{0}", ex.Message));
            }
        }

        public void IncomingSpeiTransactionsReportUsingGET()
        {
            // Create the api component
            ITransferenciasSPEIApi api = new TransferenciasSPEIApi();

            // Create the authenticator to obtain access token
            // (the token URL and Service URL are defined for this environment enum value))
            //IAuthenticator authenticator = new TokenAuthenticator(DataConfig.environment);
            TokenRequest userTokenRequest = new TokenRequest
            {
                ClientKey = clientKey,
                ClientSecret = clientSecret,
                UserKey = userKey,
                UserSecret = userSecret,
            };

            try
            {
                /*
                 * Filtering by date is optional, but both parameters must be present when use filter by date:
                 * begin date, end date,
                 * Formato 'yyyy-MM-dd'
                 */
                string beginDate = null;
                string endDate = null;

                // Obtain an access token use application flow and scope "general" and add the bearer token to request
                string authorization = authenticator.GetApplicationUserToken(userTokenRequest);

                // Obtain the response
                System.Collections.Generic.List<Deposit> response = api.IncomingSpeiTransactionsReportUsingGET(authorization, subscription
                    , beginDate, endDate);

                Console.WriteLine("Response :: Deposits:");

                response.ForEach(x =>
                {
                    Console.WriteLine(string.Format("{0}", x.ToJson()));
                });
            }
            catch (ApiException ex)
            {
                Console.WriteLine(string.Format("{0}", ex.Message));
            }
        }

        public void OutgoingSpeiTransactionsReportUsingGET()
        {
            // Create the api component
            ITransferenciasSPEIApi api = new TransferenciasSPEIApi();

            // Create the authenticator to obtain access token
            // (the token URL and Service URL are defined for this environment enum value))
            //IAuthenticator authenticator = new TokenAuthenticator(DataConfig.environment);
            TokenRequest userTokenRequest = new TokenRequest
            {
                ClientKey = clientKey,
                ClientSecret = clientSecret,
                UserKey = userKey,
                UserSecret = userSecret,
            };

            try
            {
                // Obtain an access token use application flow and scope "spei_admin" and add the bearer token to request
                string authorization = authenticator.GetApplicationUserToken(userTokenRequest);

                // Obtain the response
                System.Collections.Generic.List<Payment> response = api.OutgoingSpeiTransactionsReportUsingGET(authorization, subscription);

                Console.WriteLine("Response :: Payments:");

                response.ForEach(x =>
                {
                    Console.WriteLine(string.Format("{0}", x.ToJson()));
                });
            }
            catch (ApiException ex)
            {
                Console.WriteLine(string.Format("{0}", ex.Message));
            }
        }

        public void RegisterOutgoingSpidTransactionUsingPOST()
        {
            // Create the api component
            ITransferenciasSPIDApi api = new TransferenciasSPIDApi();

            // Create the authenticator to obtain access token
            // (the token URL and Service URL are defined for this environment enum value))
            //IAuthenticator authenticator = new TokenAuthenticator(DataConfig.environment);
            TokenRequest userTokenRequest = new TokenRequest
            {
                ClientKey = clientKey,
                ClientSecret = clientSecret,
                UserKey = userKey,
                UserSecret = userSecret,
            };

            // Build body with info (check references for more info, types, required fields)
            TransactionOutgoingSpid body = new TransactionOutgoingSpid(
                 decimal.Parse("120.25"),
                   "112680000156896531",
                    "https://your-app-url.mx/cancel",
                    "01",
                    "USD",
                    new System.Collections.Generic.List<string>() { "notificar@wire4.mx" },
                    1234567,
                    "c3fc9fa3-d2d1-4eef-8906-ae2514fefdfa",
                    "Transfer out test SPID",
                    "https://your-app-url.mx/return"
                   );

            try
            {
                // Obtain an access token use application flow and scope "spei_admin" and add the bearer token to request
                string authorization = authenticator.GetApplicationUserTokenSpid(userTokenRequest);

                // Obtain the response
                TokenRequiredResponse response = api.RegisterOutgoingSpidTransactionUsingPOST(body, authorization, subscription);

                Console.WriteLine(string.Format("Response :: {0}", response.ToJson()));
            }
            catch (ApiException ex)
            {
                Console.WriteLine(string.Format("{0}", ex.Message));
            }
        }

        public void DropTransactionsPendingUsingDELETE()
        {
            // Create the api component
            ITransferenciasSPEIApi api = new TransferenciasSPEIApi();

            // Create the authenticator to obtain access token
            // (the token URL and Service URL are defined for this environment enum value))
            //IAuthenticator authenticator = new TokenAuthenticator(DataConfig.environment);
            TokenRequest userTokenRequest = new TokenRequest
            {
                ClientKey = clientKey,
                ClientSecret = clientSecret,
                UserKey = userKey,
                UserSecret = userSecret,
            };

            string requestId = "fcb62831-cc04-4b3b-93d4-39e698a3bad6";

            try
            {
                // Obtain an access token use application flow and scope "spei_admin" and add the bearer token to request
                string authorization = authenticator.GetApplicationUserToken(userTokenRequest);

                // Obtain the response
                ApiResponse<object> response = api.DropTransactionsPendingUsingDELETEWithHttpInfo(authorization, requestId, subscription);

                Console.WriteLine(string.Format("Response :: {0}", response.StatusCode));
            }
            catch (ApiException ex)
            {
                Console.WriteLine(string.Format("{0}", ex.Message));
            }
        }

        public void RegisterWebhook()
        {
            // Create the api component
            IWebhooksApi api = new WebhooksApi();

            // Create the authenticator to obtain access token
            // (the token URL and Service URL are defined for this environment enum value))
            //IAuthenticator authenticator = new TokenAuthenticator(DataConfig.environment);
            TokenRequest applicationTokenRequest = new TokenRequest
            {
                ClientKey = clientKey,
                ClientSecret = clientSecret,
            };

            // Build body with info (check references for more info, types, required fields)
            WebhookRequest body = new WebhookRequest(
                new System.Collections.Generic.List<string>(){
                    "ACCOUNT.CREATED",
                    "TRANSACTION.OUTGOING.RECEIVED",
                    "ENROLLMENT.CREATED" },
                "SDK-WEBHOOK-REGISTER",
                "https://en0fpu357pjff.x.pipedream.net"
                );

            try
            {
                // Obtain an access token use application flow and scope "general" and add the bearer token to request
                string authorization = authenticator.GetApplicationToken(applicationTokenRequest);

                // Obtain the response
                WebhookResponse response = api.RegisterWebhook(body, authorization);

                Console.WriteLine(string.Format("Response :: {0}", response.ToJson()));
            }
            catch (ApiException ex)
            {
                Console.WriteLine(string.Format("{0}", ex.Message));
            }
        }

        public void GetWebhooks()
        {
            // Create the api component
            IWebhooksApi api = new WebhooksApi();

            // Create the authenticator to obtain access token
            // (the token URL and Service URL are defined for this environment enum value))
            //IAuthenticator authenticator = new TokenAuthenticator(DataConfig.environment);
            TokenRequest applicationTokenRequest = new TokenRequest
            {
                ClientKey = clientKey,
                ClientSecret = clientSecret,
            };

            try
            {
                // Obtain an access token use application flow and scope "general" and add the bearer token to request
                string authorization = authenticator.GetApplicationToken(applicationTokenRequest);

                // Obtain the response
                WebhooksList response = api.GetWebhooks(authorization);

                Console.WriteLine(string.Format("Response :: {0}", response.ToJson()));
            }
            catch (ApiException ex)
            {
                Console.WriteLine(string.Format("{0}", ex.Message));
            }
        }

        public void GetWebhook()
        {
            // Create the api component
            IWebhooksApi api = new WebhooksApi();

            // Create the authenticator to obtain access token
            // (the token URL and Service URL are defined for this environment enum value))
            //IAuthenticator authenticator = new TokenAuthenticator(DataConfig.environment);
            TokenRequest applicationTokenRequest = new TokenRequest
            {
                ClientKey = clientKey,
                ClientSecret = clientSecret,
            };

            string id = "wh_27d38c83d63d46bb8bef4c0962ac60ab";

            try
            {
                // Obtain an access token use application flow and scope "general" and add the bearer token to request
                string authorization = authenticator.GetApplicationToken(applicationTokenRequest);

                // Obtain the response
                WebhookResponse response = api.GetWebhook(authorization, id);

                Console.WriteLine(string.Format("Response :: {0}", response != null ? response.ToJson() : ""));
            }
            catch (ApiException ex)
            {
                Console.WriteLine(string.Format("{0}", ex.Message));
            }
        }

        public void RemoveBeneficiariesPendingUsingDELETE()
        {
            // Create the api component
            ICuentasDeBeneficiariosSPEIApi api = new CuentasDeBeneficiariosSPEIApi();

            // Create the authenticator to obtain access token
            // (the token URL and Service URL are defined for this environment enum value))
            //IAuthenticator authenticator = new TokenAuthenticator(DataConfig.environment);
            TokenRequest userTokenRequest = new TokenRequest
            {
                ClientKey = clientKey,
                ClientSecret = clientSecret,
                UserKey = userKey,
                UserSecret = userSecret,
            };

            string requestId = "3f2c81c4-37e1-4931-9340-98ce1e732672";

            try
            {
                // Obtain an access token use application flow and scope "spei_admin" and add the bearer token to request
                string authorization = authenticator.GetApplicationUserToken(userTokenRequest);

                // Obtain the response
                ApiResponse<object> response = api.RemoveBeneficiariesPendingUsingDELETEWithHttpInfo(authorization, requestId, subscription);

                Console.WriteLine(string.Format("Response :: {0}", response.StatusCode));
            }
            catch (ApiException ex)
            {
                Console.WriteLine(string.Format("{0}", ex.Message));
            }
        }

        public void BillingsReportUsingGET()
        {
            // Create the api component
            IFacturasApi api = new FacturasApi();

            // Create the authenticator to obtain access token
            // (the token URL and Service URL are defined for this environment enum value))
            //IAuthenticator authenticator = new TokenAuthenticator(DataConfig.environment);
            TokenRequest userTokenRequest = new TokenRequest
            {
                ClientKey = clientKey,
                ClientSecret = clientSecret,
                UserKey = userKey,
                UserSecret = userSecret,
            };

            string period = "2019-10";

            try
            {
                // Obtain an access token use application flow and scope "spei_admin" and add the bearer token to request
                string authorization = authenticator.GetApplicationUserToken(userTokenRequest);

                // Obtain the response
                System.Collections.Generic.List<Billing> response = api.BillingsReportUsingGET(authorization, period);

                Console.WriteLine("Response :: Facturas:\n");

                response.ForEach(x =>
                {
                    Console.WriteLine(string.Format("{0}\n", x.ToJson()));
                });
            }
            catch (ApiException ex)
            {
                Console.WriteLine(string.Format("{0}", ex.Message));
            }

        }

        public void BillingsReportByIdUsingGET()
        {
            // Create the api component
            IFacturasApi api = new FacturasApi();

            // Create the authenticator to obtain access token
            // (the token URL and Service URL are defined for this environment enum value))
            //IAuthenticator authenticator = new TokenAuthenticator(DataConfig.environment);
            TokenRequest userTokenRequest = new TokenRequest
            {
                ClientKey = clientKey,
                ClientSecret = clientSecret,
                UserKey = userKey,
                UserSecret = userSecret,
            };

            string id = "834BA74A-BBBB-43C4-8400-A4528153C2BD";

            try
            {
                // Obtain an access token use application flow and scope "spei_admin" and add the bearer token to request
                string authorization = authenticator.GetApplicationUserToken(userTokenRequest);

                // Obtain the response
                Billing response = api.BillingsReportByIdUsingGET(authorization, id);

                Console.WriteLine(string.Format("Response :: {0}", response.ToJson()));
            }
            catch (ApiException ex)
            {
                Console.WriteLine(string.Format("{0}", ex.Message));
            }
        }

        public void OutCommingSpeiRequestIdTransactionsReportUsingGET()
        {

            // Create the api component
            ITransferenciasSPEIApi api = new TransferenciasSPEIApi();

            // Create the authenticator to obtain access token
            // (the token URL and Service URL are defined for this environment enum value))
            //IAuthenticator authenticator = new TokenAuthenticator(DataConfig.environment);
            TokenRequest userTokenRequest = new TokenRequest
            {
                ClientKey = clientKey,
                ClientSecret = clientSecret,
                UserKey = userKey,
                UserSecret = userSecret,
            };

            try
            {
                string request_id = "6a9efe39-a795-4e09-8f7f-197e647a0f8b";
                // Obtain an access token use application flow and scope "spei_admin" and add the bearer token to request
                string authorization = authenticator.GetApplicationUserToken(userTokenRequest);

                // Obtain the response
                PaymentsRequestId response = api.OutCommingSpeiRequestIdTransactionsReportUsingGET(authorization, request_id, subscription);

                Console.WriteLine("Response :: Payments:");
                Console.WriteLine(string.Format("{0}", response.ToJson()));
            }
            catch (ApiException ex)
            {
                Console.WriteLine(string.Format("{0}", ex.Message));
            }
        }

        public void VerificationSignWebHookMessage()
        {

            string message = "{ \"responseCode\":0, \n" +
                "  \"message\":\"Ya existe este beneficiario de pago a ctas nacionales en el contrato\",\n" +
                "  \"statusCode\":\"ERROR\",\n" +
                "  \"externalReference\":\"8939TR\"\n" +
                "}";
            string key = "9ie93030?=";
            string signature = "8e63e88434679473bdb28546d7d91537601f4588e801972376d5c5addcb8fd706e6c92421b73151de3c1945ce000a8a5aa1d5cc3cdd73f2769ee9980db420db9";


            bool areEquals = UtilsCompute.CompareWebHookMsgSignatures(message, key, signature);

            Console.WriteLine("VerificationSignWebHookMessage: " + areEquals);
        }

        public void AuthorizeAccountsPendingPUT()
        {
            // Create the api component
            ICuentasDeBeneficiariosSPEIApi api = new CuentasDeBeneficiariosSPEIApi();

            // Create the authenticator to obtain access token
            // (the token URL and Service URL are defined for this environment enum value))
            //IAuthenticator authenticator = new TokenAuthenticator(DataConfig.environment);
            TokenRequest userTokenRequest = new TokenRequest
            {
                ClientKey = clientKey,
                ClientSecret = clientSecret,
                UserKey = userKey,
                UserSecret = userSecret
            };

            // Build body with info (check references for more info, types, required fields)
            UrlsRedirect body = new UrlsRedirect(cancelReturnUrl: "https://your-app-url.mx/cancel",
                returnUrl: "https://your-app-url.mx/return");

            try
            {
                // Obtain an access token use application flow and scope "spei_admin" and add the bearer token to request
                string authorization = authenticator.GetApplicationUserToken(userTokenRequest);

                // Obtain the response
                AuthorizedBeneficiariesResponse response = api.AuthorizeAccountsPendingPUT(body, authorization, subscription);

                Console.WriteLine(string.Format("Response :: {0}", response));
            }
            catch (ApiException ex)
            {
                Console.WriteLine(string.Format("{0}", ex.Message));
            }
        }

        public void CreateAuthorizationTransactionsGroup()
        {
            // Create the api component
            ITransferenciasSPEIApi api = new TransferenciasSPEIApi();

            // Create the authenticator to obtain access token
            // (the token URL and Service URL are defined for this environment enum value))
            //IAuthenticator authenticator = new TokenAuthenticator(DataConfig.environment);
            TokenRequest userTokenRequest = new TokenRequest
            {
                ClientKey = clientKey,
                ClientSecret = clientSecret,
                UserKey = userKey,
                UserSecret = userSecret
            };

            // Build body with info (check references for more info, types, required fields)
            UrlsRedirect urls = new UrlsRedirect("https://your-app-url.mx/cancel",
                                                 "https://your-app-url.mx/return");
            AuthorizationTransactionGroup body = new AuthorizationTransactionGroup(urls,
                new System.Collections.Generic.List<string>() {
                    "2454ffb2-a699-408f-9812-9a12eed11bfc" // Add N transactions order identifiers
                });

            try
            {
                // Obtain an access token use application flow and scope "spei_admin" and add the bearer token to request
                string authorization = authenticator.GetApplicationUserToken(userTokenRequest);

                // Obtain the response
                TokenRequiredResponse response = api.CreateAuthorizationTransactionsGroup(body, authorization, subscription);

                Console.WriteLine(string.Format("Response :: {0}", response));
            }
            catch (ApiException ex)
            {
                Console.WriteLine(string.Format("{0}", ex.Message));
            }
        }

        public void RegisterCompanyUsingPOST()
        {
            // Create the api component
            IEmpresasCoDiApi api = new EmpresasCoDiApi();

            // Create the authenticator to obtain access token
            // (the token URL and Service URL are defined for this environment enum value))
            //IAuthenticator authenticator = new TokenAuthenticator(DataConfig.environment);
            TokenRequest userTokenRequest = new TokenRequest
            {
                ClientKey = clientKey,
                ClientSecret = clientSecret
            };

            // Build body with info (check references for more info, types, required fields)
            CompanyRequested body = new CompanyRequested("Tacos",
                new CertificateRequest("00040390904903904909", "4908439084390849084",
                    "1", "4309jij3490j43jf0j3490fFFFDSDS4393490"), "Tacos el Compa",
                "TACO580926LA1");

            try
            {
                // Obtain an access token use application flow and scope "codi_general" and add the bearer token to request
                string authorization = authenticator.GetApplicationToken(userTokenRequest, "codi_general");

                // Obtain the response
                CompanyRegistered response = api.RegisterCompanyUsingPOST(body, authorization);

                Console.WriteLine(string.Format("Response :: {0}", response));
            }
            catch (ApiException ex)
            {
                Console.WriteLine(string.Format("{0}", ex.Message));
            }
        }

        public void ObtainCompanies()
        {
            // Create the api component
            IEmpresasCoDiApi api = new EmpresasCoDiApi();

            // Create the authenticator to obtain access token
            // (the token URL and Service URL are defined for this environment enum value))
            //IAuthenticator authenticator = new TokenAuthenticator(DataConfig.environment);
            TokenRequest userTokenRequest = new TokenRequest
            {
                ClientKey = clientKey,
                ClientSecret = clientSecret
            };

            try
            {
                // Obtain an access token use application flow and scope "codi_general" and add the bearer token to request
                string authorization = authenticator.GetApplicationToken(userTokenRequest, "codi_general");

                // Obtain the response
                System.Collections.Generic.List<CompanyRegistered> response = api.ObtainCompanies(authorization);

                Console.WriteLine("Response:\n");

                response.ForEach(x =>
                {
                    Console.WriteLine(string.Format("{0}\n", x.ToJson()));
                });
            }
            catch (ApiException ex)
            {
                Console.WriteLine(string.Format("{0}", ex.Message));
            }
        }

        private static readonly string companyId = "0b43cbd2-2a86-4eb5-a51c-49a53d521295";

        public void CreateSalesPoint()
        {
            // Create the api component
            IPuntosDeVentaCoDiApi api = new PuntosDeVentaCoDiApi();

            // Create the authenticator to obtain access token
            // (the token URL and Service URL are defined for this environment enum value))
            //IAuthenticator authenticator = new TokenAuthenticator(DataConfig.environment);
            TokenRequest userTokenRequest = new TokenRequest
            {
                ClientKey = clientKey,
                ClientSecret = clientSecret
            };

            // Build body with info (check references for more info, types, required fields)
            SalesPointRequest body = new SalesPointRequest("189.180.255.229", "044680035044988526",
                "Taqueria Sur, caja 1 csharp", "https://webhook.site/3e32e1c4-1346-4f5a-92d5-2a921c5c85df");

            try
            {
                // Obtain an access token use application flow and scope "codi_general" and add the bearer token to request
                string authorization = authenticator.GetApplicationToken(userTokenRequest, "codi_general");

                // Obtain the response
                SalesPointRespose response = api.CreateSalesPoint(body, authorization, companyId);

                Console.WriteLine(string.Format("Response :: {0}", response));
            }
            catch (ApiException ex)
            {
                Console.WriteLine(string.Format("{0}", ex.Message));
            }
        }

        public void ObtainSalePoints()
        {
            // Create the api component
            IPuntosDeVentaCoDiApi api = new PuntosDeVentaCoDiApi();

            // Create the authenticator to obtain access token
            // (the token URL and Service URL are defined for this environment enum value))
            //IAuthenticator authenticator = new TokenAuthenticator(DataConfig.environment);
            TokenRequest userTokenRequest = new TokenRequest
            {
                ClientKey = clientKey,
                ClientSecret = clientSecret
            };

            try
            {
                // Obtain an access token use application flow and scope "codi_general" and add the bearer token to request
                string authorization = authenticator.GetApplicationToken(userTokenRequest, "codi_general");

                // Obtain the response
                System.Collections.Generic.List<SalesPointFound> response = api.ObtainSalePoints(authorization, companyId);

                Console.WriteLine("Response:\n");

                response.ForEach(x =>
                {
                    Console.WriteLine(string.Format("{0}\n", x.ToJson()));
                });
            }
            catch (ApiException ex)
            {
                Console.WriteLine(string.Format("{0}", ex.Message));
            }
        }

        private static readonly string salesPointId = "465ffc2c-10b5-4475-8d64-bc58e4ff098d";
        private static readonly string salesPointKey = "097db4157b74619b88f40550e7c1ee@develop.wire4.mx";
        private static readonly string salesPointSecret = "b722b8c8fc24d4bae0b1cd41b4c6af";

        public void GenerateCodiCodeQR()
        {
            // Create the api component
            IPeticionesDePagoPorCoDiApi api = new PeticionesDePagoPorCoDiApi();

            // Create the authenticator to obtain access token
            // (the token URL and Service URL are defined for this environment enum value))
            //IAuthenticator authenticator = new TokenAuthenticator(DataConfig.environment);
            TokenRequest userTokenRequest = new TokenRequest
            {
                ClientKey = clientKey,
                ClientSecret = clientSecret,
                UserKey = salesPointKey,
                UserSecret = salesPointSecret
            };

            // Build body with info (check references for more info, types, required fields)
            CodiCodeRequestDTO body = new CodiCodeRequestDTO(amount: 178.8m, concept: "consumo saintiago",
                dueDate: DateTime.ParseExact("2020-08-25T13:45:00", "yyyy-MM-dd'T'HH:mm:ss", CultureInfo.InvariantCulture),
                metadata: null, orderId: "b4408b4d-17a0-4d39-85f2-f3da1e2825e9", phoneNumber: null, CodiCodeRequestDTO.TypeEnum.QRCODE);

            try
            {
                // Obtain an access token use application flow and scope "codi_admin" and add the bearer token to request
                string authorization = authenticator.GetApplicationUserToken(userTokenRequest, "codi_admin");

                // Obtain the response
                CodiCodeQrResponseDTO response = api.GenerateCodiCodeQR(body, authorization, salesPointId);

                Console.WriteLine(string.Format("Response :: {0}", response));
            }
            catch (ApiException ex)
            {
                Console.WriteLine(string.Format("{0}", ex.Message));
            }
        }

        private static readonly string orderId = "b4408b4d-17a0-4d39-85f2-f3da1e2825e9";

        public void ConsultCodiRequestByOrderId()
        {
            // Create the api component
            IPeticionesDePagoPorCoDiApi api = new PeticionesDePagoPorCoDiApi();

            // Create the authenticator to obtain access token
            // (the token URL and Service URL are defined for this environment enum value))
            //IAuthenticator authenticator = new TokenAuthenticator(DataConfig.environment);
            TokenRequest userTokenRequest = new TokenRequest
            {
                ClientKey = clientKey,
                ClientSecret = clientSecret,
                UserKey = salesPointKey,
                UserSecret = salesPointSecret
            };

            try
            {
                // Obtain an access token use application flow and scope "codi_admin" and add the bearer token to request
                string authorization = authenticator.GetApplicationUserToken(userTokenRequest, "codi_admin");

                // Obtain the response
                PaymentRequestCodiResponseDTO response = api.ConsultCodiRequestByOrderId(authorization, orderId, salesPointId);

                Console.WriteLine(string.Format("Response :: {0}", response));
            }
            catch (ApiException ex)
            {
                Console.WriteLine(string.Format("{0}", ex.Message));
            }
        }

        public void ConsultCodiOperations()
        {
            // Create the api component
            IOperacionesCoDiApi api = new OperacionesCoDiApi();

            // Create the authenticator to obtain access token
            // (the token URL and Service URL are defined for this environment enum value))
            //IAuthenticator authenticator = new TokenAuthenticator(DataConfig.environment);
            TokenRequest userTokenRequest = new TokenRequest
            {
                ClientKey = clientKey,
                ClientSecret = clientSecret,
                UserKey = salesPointKey,
                UserSecret = salesPointSecret
            };

            // Build body with info (check references for more info, types, required fields)
            /*
             * All filters options are optional
             * orderId,
             * operationDateFrom, operationDateTo,
             * requestDateFrom, requestDateTo,
             * status (RECEIVED, COMPLETED, CANCELLED),
             * amountFrom, amountTo
             */
            CodiOperationsFiltersRequestDTO body = new CodiOperationsFiltersRequestDTO(orderId: orderId);

            try
            {
                // Obtain an access token use application flow and scope "codi_report" and add the bearer token to request
                string authorization = authenticator.GetApplicationUserToken(userTokenRequest, "codi_report");

                // Obtain the response
                PagerResponseDto response = api.ConsultCodiOperations(authorization, body, companyId, "0",
                    salesPointId, "20");

                Console.WriteLine(string.Format("Response :: {0}", response));
            }
            catch (ApiException ex)
            {
                Console.WriteLine(string.Format("{0}", ex.Message));
            }
        }

        private static readonly string accessKey = "YOUR_ACCESS_KEY_HERE";

        public void ObtainContractDetails()
        {
            // Create the api component
            IContractsDetailsApi api = new ContractsDetailsApi();

            // Create the authenticator to obtain access token
            // (the token URL and Service URL are defined for this environment enum value))
            //IAuthenticator authenticator = new TokenAuthenticator(DataConfig.environment);
            TokenRequest userTokenRequest = new TokenRequest
            {
                ClientKey = clientKey,
                ClientSecret = clientSecret
            };

            // Build body with info (check references for more info, types, required fields)
            ContractDetailRequest body = new ContractDetailRequest(contract: "1234567",
                userName: "amolina",
                password: "whatever",
                tokenCode: "258963");

            try
            {
                // Obtain an access token use application flow and scope "general" and add the bearer token to request
                string authorization = authenticator.GetApplicationToken(userTokenRequest, "general");

                // Obtain the response
                ContractDetailResponse response = api.ObtainContractDetails(body, authorization,
                    accessKey);

                Console.WriteLine(string.Format("Response :: {0}", response));
            }
            catch (ApiException ex)
            {
                Console.WriteLine(string.Format("{0}", ex.Message));
            }
        }

        public void CreateAuthorization()
        {
            // Create the api component
            IContractsDetailsApi api = new ContractsDetailsApi();

            // Create the authenticator to obtain access token
            // (the token URL and Service URL are defined for this environment enum value))
            //IAuthenticator authenticator = new TokenAuthenticator(DataConfig.environment);
            TokenRequest userTokenRequest = new TokenRequest
            {
                ClientKey = clientKey,
                ClientSecret = clientSecret
            };

            // Build body with info (check references for more info, types, required fields)
            PreMonexAuthorization body = new PreMonexAuthorization(
                returnUrl: "https://your-app-url.mx/return",
                cancelReturnUrl: "https://your-app-url.mx/cancel",
                rfc: "TACO890101LO0",
                businessName: "Compa Tacos");

            try
            {
                // Obtain an access token use application flow and scope "general" and add the bearer token to request
                string authorization = authenticator.GetApplicationToken(userTokenRequest, "general");

                // Obtain the response
                TokenRequiredResponse response = api.CreateAuthorization(body, authorization);

                Console.WriteLine(string.Format("Response :: {0}", response));
            }
            catch (ApiException ex)
            {
                Console.WriteLine(string.Format("{0}", ex.Message));
            }
        }

        private static readonly string requestId = "17fa79db-759f-4105-bc47-688fed75ddac";

        public void ObtainAuthorizedUsers()
        {
            // Create the api component
            IContractsDetailsApi api = new ContractsDetailsApi();

            // Create the authenticator to obtain access token
            // (the token URL and Service URL are defined for this environment enum value))
            //IAuthenticator authenticator = new TokenAuthenticator(DataConfig.environment);
            TokenRequest userTokenRequest = new TokenRequest
            {
                ClientKey = clientKey,
                ClientSecret = clientSecret
            };

            try
            {
                // Obtain an access token use application flow and scope "general" and add the bearer token to request
                string authorization = authenticator.GetApplicationToken(userTokenRequest, "general");

                // Obtain the response
                System.Collections.Generic.List<AuthorizedUsers> response = api.ObtainAuthorizedUsers(authorization, accessKey, requestId);

                Console.WriteLine("Response:\n");

                response.ForEach(x =>
                {
                    Console.WriteLine(string.Format("{0}\n", x.ToJson()));
                });
            }
            catch (ApiException ex)
            {
                Console.WriteLine(string.Format("{0}", ex.Message));
            }
        }

        public void ObtaingConfigurations()
        {

            // Create the api component
            ILmitesDeMontosApi api = new LmitesDeMontosApi();
             
            // Create the authenticator to obtain access token
            // (the token URL and Service URL are defined for this environment enum value))
            //IAuthenticator authenticator = new TokenAuthenticator(DataConfig.environment);

            TokenRequest userTokenRequest = new TokenRequest
            {
                ClientKey = clientKey,
                ClientSecret = clientSecret,
                UserKey = userKey,
                UserSecret = userSecret
            };

            try
            {
                // Obtain an access token use application flow and scope "spei_admin" and add the bearer token to request
                string authorization = authenticator.GetApplicationUserToken(userTokenRequest);

                // Obtain the response
                MessageConfigurationsLimits response = api.ObtainConfigurationsLimits(authorization, subscription);

                Console.WriteLine("Response::ConfigurationsLimits:");
                Console.WriteLine(response);
                if (response.Configurations != null)
                {
                    response.Configurations.ForEach(x =>
                    {
                        Console.WriteLine(string.Format("{0}\n", x.ToJson()));
                    });
                }
            }
            catch (ApiException ex)
            {
                Console.WriteLine(string.Format("{0}", ex.Message));
            }
        }

        public void UpdateConfigurations()
        {
            // Create the api component
            ILmitesDeMontosApi api = new LmitesDeMontosApi();

            // Create the authenticator to obtain access token
            // (the token URL and Service URL are defined for this environment enum value))
            //IAuthenticator authenticator = new TokenAuthenticator(DataConfig.environment);
            TokenRequest userTokenRequest = new TokenRequest
            {
                ClientKey = clientKey,
                ClientSecret = clientSecret,
                UserKey = userKey,
                UserSecret = userSecret,
            };


            System.Collections.Generic.List<ConfigurationsLimits> configurationsLimits = new System.Collections.Generic.List<ConfigurationsLimits>();
            configurationsLimits.Add(new ConfigurationsLimits("LIMIT_BY_TIME", new System.Collections.Generic.List<Item>(){
                new Item(key: "BY_AMOUNT", value: "15000.00"), new Item(key: "BY_OPERATION", value: "50") }));

            UpdateConfigurationsRequestDTO body = new UpdateConfigurationsRequestDTO(configurationsLimits);

            try
            {
                // Obtain an access token use application flow and scope "spei_admin" and add the bearer token to request
                string authorization = authenticator.GetApplicationUserToken(userTokenRequest);

                // Obtain the response
                ApiResponse<object> response = api.UpdateConfigurationsWithHttpInfo(body, authorization, subscription);

                Console.WriteLine(string.Format("Response :: {0}", response.StatusCode));
            }
            catch (ApiException ex)
            {
                Console.WriteLine(string.Format("{0}", ex.Message));
            }
        }

        /*public void ChangeSubscriptionStatusUsingPUT()
        {
            // Create the api component
            ISuscripcionesApi api = new SuscripcionesApi();

            // Create the authenticator to obtain access token
            // (the token URL and Service URL are defined for this environment enum value))
            //IAuthenticator authenticator = new TokenAuthenticator(DataConfig.environment);
            TokenRequest applicationTokenRequest = new TokenRequest
            {
                ClientKey = clientKey,
                ClientSecret = clientSecret,
            };

            try
            {
                // Obtain an access token use application flow and scope "general" and add the bearer token to request
                string authorization = authenticator.GetApplicationToken(applicationTokenRequest);

                Console.WriteLine("Application Token:: " + authorization);
                Console.WriteLine();

                // Build body with info (check references for more info, types, required fields)
                SubscriptionChangeStatusRequest body = new SubscriptionChangeStatusRequest();
                body.Status = SubscriptionChangeStatusRequest.StatusEnum.INACTIVE;

                // Obtain the response
                ApiResponse<object> response = api.ChangeSubscriptionStatusUsingPUTWithHttpInfo(body, authorization,subscription);

                Console.WriteLine(string.Format("Response :: {0}", response.StatusCode));
            }
            catch (ApiException ex)
            {
                Console.WriteLine(string.Format("{0}", ex.Message));
            }
        }*/
    }
}
