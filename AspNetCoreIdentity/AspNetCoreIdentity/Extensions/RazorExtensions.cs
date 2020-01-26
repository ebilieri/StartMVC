using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Razor;

namespace AspNetCoreIdentity.Extensions
{
    public static class RazorExtensions
    {
        public static bool IfClaim(this RazorPage page, string clainName, string claimValue)
        {
            return CustomAuthorization.ValidarClaimsUsuario(page.Context, clainName, claimValue);
        }

        public static string IfClaimShow(this RazorPage page, string clainName, string claimValue)
        {
            return CustomAuthorization.ValidarClaimsUsuario(page.Context, clainName, claimValue) ? "" : "disabled";
        }

        public static IHtmlContent IfClaimShow(this IHtmlContent page, HttpContext context, string clainName, string claimValue)
        {
            return CustomAuthorization.ValidarClaimsUsuario(context, clainName, claimValue) ? page : null;
        }
    }
}
