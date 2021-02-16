using System;
using MX.Wire4.Authenticator;
using MX.Wire4.Authenticator.Model;

namespace MX.Wire4.Tests.Config
{
    public class DataConfig
    {

        private static readonly string clientKey = "FxUWmqYGZuv8O1qjxstvIyJothMa";
        private static readonly string clientSecret = "kjwbkrPVgXsnaUGzthj55dsFhx4a";
        private static readonly string userKey = "071e2b59b354186b3a0158de493536@sandbox.wire4.mx";
        private static readonly string userSecret = "0d1e33e94604f01b4e00d2fcb6b48f";

        public static readonly TokenRequest applicationTokenRequest = new TokenRequest
        {
            ClientKey = clientKey,
            ClientSecret = clientSecret,
        };
        public static readonly TokenRequest speiUserTokenRequest = new TokenRequest
        {
            ClientKey = clientKey,
            ClientSecret = clientSecret,
            UserKey = userKey,
            UserSecret = userSecret,
        };
        public static readonly TokenRequest spidUserTokenRequest = new TokenRequest
        {
            ClientKey = clientKey,
            ClientSecret = clientSecret,
            UserKey = userKey,
            UserSecret = userSecret,
        };

        public static readonly string subscription = "f1504fea-3a8f-475a-a50a-90d3c40efc59";

        public static readonly EnvironmentType environment = EnvironmentType.Sandbox;
    }
}
