:: Generated by: https://github.com/swagger-api/swagger-codegen.git
::

@echo off

SET CSCPATH=%SYSTEMROOT%\Microsoft.NET\Framework\v4.0.30319

if not exist ".\nuget.exe" powershell -Command "(new-object System.Net.WebClient).DownloadFile('https://dist.nuget.org/win-x86-commandline/latest/nuget.exe', '.\nuget.exe')"
.\nuget.exe install src\MX.Wire4\packages.config -o packages

if not exist ".\bin" mkdir bin

copy packages\JsonSubTypes.1.2.0\lib\net45\JsonSubTypes.dll bin\JsonSubTypes.dll
copy packages\Newtonsoft.Json.10.0.3\lib\net45\Newtonsoft.Json.dll bin\Newtonsoft.Json.dll
copy packages\RestSharp.105.1.0\lib\net45\RestSharp.dll bin\RestSharp.dll
copy packages\MX.Wire4.0.0.3\lib\net45\MX.Wire4.dll bin/MX.Wire4.dll
%CSCPATH%\csc  /reference:bin\Newtonsoft.Json.dll;bin\JsonSubTypes.dll;bin\RestSharp.dll;bin/MX.Wire4.dll;System.ComponentModel.DataAnnotations.dll  /target:library /out:bin\MX.Wire4.Authenticator.dll /recurse:src\MX.Wire4\*.cs /doc:bin\MX.Wire4.Authenticator.xml

