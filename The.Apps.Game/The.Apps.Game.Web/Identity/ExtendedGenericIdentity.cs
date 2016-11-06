using System.Security.Principal;
using System.Threading;

namespace The.Apps.Game.Web.Identity
{
    public class ExtendedGenericIdentity : GenericIdentity
    {
        public string[] UserData { get; set; }
        public string DisplayName { get; set; }
        public ExtendedGenericIdentity(string name, string displayName) : base(name)
        {
            DisplayName = displayName;
        }

        public static string GetCurrentUserDisplayName()
        {
            var currentPrincipal = Thread.CurrentPrincipal;
            if (currentPrincipal == null)
            {
                return null;
            }
            var identity = currentPrincipal.Identity as ExtendedGenericIdentity;
            if (identity == null)
            {
                return null;
            }
            return identity.DisplayName;
        }
    }
}