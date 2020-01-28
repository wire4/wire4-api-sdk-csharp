# MX.Wire4.Authenticator - librería C# para la Wire4RestAPI

Autenticador para la API de Wire4

- versión de API: 1.0.0
- versión de SDK: 0.0.1

<a name="frameworks-supported"></a>

## Frameworks supported

- .NET 4.0 o superior
- Windows Phone 7.1 (Mango)

<a name="dependencies"></a>

## Dependencies

- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0 o superior
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 o superior
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.2.0 o superior

Las DLLs incluídas en el paquete pueden no ser la versiones más recientes. Te recomendamos usar [NuGet](https://docs.nuget.org/consume/installing-nuget) para obtener las últimas versiones de los paquetes:

```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
```

NOTA: veriones de RestSharp superiores a 105.1.0 tiene un defecto (bug) conocido que causa que la subida de archivos falle. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

<a name="installation"></a>

## Instalación

Ejecutar el siguiente comando para generar la DLL, no olvides que es necesario antes descargar y compilar el cliente SDK [sdk-client](https://github.com/wire4/wire4-csharp-client)

- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Después puedes incluir la DLL (que se genera en el directorio `bin`) en tu proyecto de C# , y usar el espacio de nombres, una vez más, no olvides que es necesario antes descargar y compilar el cliente SDK [sdk-client](https://github.com/wire4/wire4-csharp-client) y también incluir esta DLL:

```csharp

using MX.Wire4.Authenticator.Client;
using MX.Wire4.Authenticator.Model;
```

<a name="packaging"></a>

## Empaquetando

Un archivo `.nuspec` está incluído en el proyecto. Puedes seguir la guía rápida de Nuget para [crear](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) y [publicar](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) paquetes.

El `.nuspec` usa constantes (placeholders) definidas en el archivo `.csproj`, debes generar el `.csproj`:

```
nuget pack -Build -OutputDirectory out MX.Wire4.Authenticator.csproj
```

Luego, puedes publicar a una fuente [local](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [host remoto](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) y consumir el paquete con nuget.

<a name="getting-started"></a>

## Para comenzar a usar

```csharp
using System;
using MX.Wire4.Api;
using MX.Wire4.Authenticator;
using MX.Wire4.Authenticator.Client;
using MX.Wire4.Authenticator.Model;
using MX.Wire4.Client;
using MX.Wire4.Model;

namespace Example
{
    public class Example
    {
        public void main()
        {
            // Create the api component
            IComprobanteElectrnicoDePagoCEPApi api = new ComprobanteElectrnicoDePagoCEPApi();

            // Create the authenticator to obtain access token
            // (the token URL and Service URL are defined for this environment enum value))
            IAuthenticator authenticator = new TokenAuthenticator(EnvironmentType.Sandbox);
            TokenRequest applicationTokenRequest = new TokenRequest {
                ClientKey = "FxUWmqYGZuv8O1qjxstvIyJothMa",
                ClientSecret = "kjwbkrPVgXsnaUGzthj55dsFhx4a",
            };
            
            try
            {
                // Obtain an access token use application flow and scope "general" and add the bearer token to request
                api.Configuration.AccessToken = authenticator.GetApplicationToken(applicationTokenRequest).AccessToken;

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
                CepResponse response = api.ObtainTransactionCepUsingPOST(body);

                Console.WriteLine(string.Format("\nResponse :: {0}", response.ToJson()));
            }
            catch (ApiException ex)
            {
                Console.WriteLine(string.Format("\n{0}\n", ex.Message));
            }
        }
    }
}
```
