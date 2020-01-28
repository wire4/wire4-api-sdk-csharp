using System;
namespace MX.Wire4.Authenticator.Model
{
    [Serializable]
    public sealed class ScopeType
    {
        public static readonly ScopeType General = new ScopeType("general");
        public static readonly ScopeType SpeiAdmin = new ScopeType("spei_admin");
        public static readonly ScopeType SpidAdmin = new ScopeType("spid_admin");

        public string ScopeName { get; private set; }

        private ScopeType(string ScopeName)
        {
            this.ScopeName = ScopeName;
        }
    }
}
